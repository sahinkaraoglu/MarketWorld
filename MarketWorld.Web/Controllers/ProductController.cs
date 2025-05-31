using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Data;
using MarketWorld.Infrastructure;
using MarketWorld.Web.Models;
using static MarketWorld.Web.Models.CategoryViewModel;
using ProductViewModel = MarketWorld.Web.Models.ProductViewModel;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
using MarketWorld.Core.Domain.Entities;

namespace MarketWorld.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly MarketWorldDbContext _context;
        private readonly IDistributedCache _cache;
        private const string CacheKey = "web_products";
        private readonly JsonSerializerOptions _jsonOptions;

        public ProductController(MarketWorldDbContext context, IDistributedCache cache)
        {
            _context = context;
            _cache = cache;
            _jsonOptions = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                MaxDepth = 128
            };
        }

        private async Task<IActionResult> GetProductsBySubCategoryName(string subCategoryName)
        {
            string cacheKey = $"{CacheKey}_subcategory_{subCategoryName.ToLower()}";
            string cachedProducts = await _cache.GetStringAsync(cacheKey);

            if (!string.IsNullOrEmpty(cachedProducts))
            {
                var cachedResult = JsonSerializer.Deserialize<List<ProductViewModel>>(cachedProducts, _jsonOptions);
                ViewBag.Brands = await GetBrandsForSubCategory(subCategoryName);
                return View("ProductList", cachedResult);
            }

            var subCategory = await _context.SubCategories.FirstOrDefaultAsync(sc => sc.ShortenedEntityName.ToLower() == subCategoryName.ToLower());

            var userId = HttpContext.Items["UserId"]?.ToString();
            ViewBag.IsLoggedIn = !string.IsNullOrEmpty(userId);

            var products = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Images)
                .Include(p => p.SubCategory)
                .ThenInclude(sc => sc.Category)
                .Where(p => p.SubCategory.ShortenedEntityName.ToLower() == subCategoryName.ToLower() && p.IsActive && !p.IsDeleted)
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    BrandId = p.BrandId,
                    BrandName = p.Brand.Name,
                    CreatedDate = p.CreatedDate,
                    Price = p.Price,
                    ImageUrl = p.Images.FirstOrDefault() != null ?
                              $"/{p.Images.FirstOrDefault().Path}" :
                              "/img/default-product.jpg",
                    Rating = p.Rating,
                    ReviewCount = 100,
                    HasFreeShipping = p.Price > 45000,
                    Stock = p.GetTotalStock(),
                    CategoryName = p.SubCategory.Category.Name,
                    HasDiscount = p.HasDiscount,
                    DiscountPrice = p.HasDiscount ? p.DiscountPrice : null,
                    ProductCode = p.ProductCode,
                    Color = p.ProductProperties
                        .Where(pp => pp.PropertyType.Name == "Renk" && pp.IsActive)
                        .Select(pp => pp.PropertyValue.Value)
                        .FirstOrDefault() ?? "Varsayılan"
                }).ToListAsync();

            var brands = await GetBrandsForSubCategory(subCategoryName);
            ViewBag.Brands = brands;

            var cacheOptions = new DistributedCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromMinutes(10))
                .SetAbsoluteExpiration(TimeSpan.FromHours(1));

            await _cache.SetStringAsync(
                cacheKey,
                JsonSerializer.Serialize(products, _jsonOptions),
                cacheOptions
            );

            return View("ProductList", products);
        }

        private async Task<List<Brand>> GetBrandsForSubCategory(string subCategoryName)
        {
            string brandsCacheKey = $"{CacheKey}_brands_{subCategoryName.ToLower()}";
            string cachedBrands = await _cache.GetStringAsync(brandsCacheKey);

            if (!string.IsNullOrEmpty(cachedBrands))
            {
                return JsonSerializer.Deserialize<List<Brand>>(cachedBrands, _jsonOptions);
            }

            var brands = await _context.Brands
                .Where(b => !b.IsDeleted && _context.Products
                    .Any(p => p.BrandId == b.Id && 
                            p.SubCategory.ShortenedEntityName.ToLower() == subCategoryName.ToLower() && 
                            p.IsActive && !p.IsDeleted))
                .OrderBy(b => b.Name)
                .ToListAsync();

            var cacheOptions = new DistributedCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromMinutes(15))
                .SetAbsoluteExpiration(TimeSpan.FromHours(2));

            await _cache.SetStringAsync(
                brandsCacheKey,
                JsonSerializer.Serialize(brands, _jsonOptions),
                cacheOptions
            );

            return brands;
        }

        public async Task<IActionResult> ListBySubCategory(string subCategoryName, int page = 1)
        {
            if (string.IsNullOrEmpty(subCategoryName))
                return NotFound();

            string cacheKey = $"{CacheKey}_subcategory_paged_{subCategoryName.ToLower()}_{page}";
            string cachedData = await _cache.GetStringAsync(cacheKey);

            if (!string.IsNullOrEmpty(cachedData))
            {
                // JsonDocument kullanarak daha güvenli erişim
                using JsonDocument document = JsonDocument.Parse(cachedData);
                JsonElement root = document.RootElement;
                
                // Ürünleri ve diğer bilgileri önce JsonElement olarak al, daha sonra deserialize et
                var productsElement = root.GetProperty("Products");
                
                // Markaları veritabanından doğrudan al
                var cachedBrands = await GetBrandsForSubCategory(subCategoryName);
                
                // ViewBag değerlerini ayarla
                ViewBag.Brands = cachedBrands;
                ViewBag.CurrentPage = root.GetProperty("CurrentPage").GetInt32();
                ViewBag.TotalPages = root.GetProperty("TotalPages").GetInt32();
                ViewBag.SubCategoryName = subCategoryName;
                
                // Ürünleri deserialize et ve view'a gönder
                var cachedProducts = JsonSerializer.Deserialize<List<ProductViewModel>>(productsElement.GetRawText(), _jsonOptions);
                return View("ProductList", cachedProducts);
            }

            var subCategory = await _context.SubCategories.FirstOrDefaultAsync(sc => sc.ShortenedEntityName.ToLower() == subCategoryName.ToLower());
            if (subCategory == null)
                return NotFound();

            var userId = HttpContext.Items["UserId"]?.ToString();
            ViewBag.IsLoggedIn = !string.IsNullOrEmpty(userId);

            var pageSize = 9;
            var query = _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Images)
                .Include(p => p.SubCategory)
                    .ThenInclude(sc => sc.Category)
                .Where(p => p.SubCategory.ShortenedEntityName.ToLower() == subCategoryName.ToLower() && p.IsActive && !p.IsDeleted);

            var totalItems = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            var products = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    BrandId = p.BrandId,
                    BrandName = p.Brand.Name,
                    Price = p.Price,
                    ImageUrl = p.Images.FirstOrDefault() != null ? $"/{p.Images.FirstOrDefault().Path}" : "/img/default-product.jpg",
                    Rating = p.Rating,
                    ReviewCount = 100,
                    HasFreeShipping = p.Price > 45000,
                    Stock = p.GetTotalStock(),
                    CategoryName = p.SubCategory.Category.Name,
                    HasDiscount = p.HasDiscount,
                    DiscountPrice = p.HasDiscount ? p.DiscountPrice : null,
                    ProductCode = p.ProductCode,
                    Color = p.ProductProperties
                        .Where(pp => pp.PropertyType.Name == "Renk" && pp.IsActive)
                        .Select(pp => pp.PropertyValue.Value)
                        .FirstOrDefault() ?? "Varsayılan"
                })
                .ToListAsync();

            var brands = await GetBrandsForSubCategory(subCategoryName);

            var result = new
            {
                Products = products,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                TotalProducts = totalItems,
                Brands = brands
            };

            ViewBag.Brands = brands;
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.SubCategoryName = subCategoryName;

            var cacheOptions = new DistributedCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromMinutes(10))
                .SetAbsoluteExpiration(TimeSpan.FromHours(1));

            await _cache.SetStringAsync(
                cacheKey,
                JsonSerializer.Serialize(result, _jsonOptions),
                cacheOptions
            );

            return await GetProductsBySubCategoryName(subCategoryName);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            ViewBag.IsLoggedIn = !string.IsNullOrEmpty(userId);
            
            string cacheKey = $"{CacheKey}_product_detail_{id}";
            string cachedProduct = await _cache.GetStringAsync(cacheKey);

            if (!string.IsNullOrEmpty(cachedProduct))
            {
                var cachedViewModel = JsonSerializer.Deserialize<ProductDetailViewModel>(cachedProduct, _jsonOptions);
                return View(cachedViewModel);
            }

            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Images)
                .Include(p => p.SubCategory)
                    .ThenInclude(sc => sc.Category)
                .Include(p => p.ProductProperties)
                    .ThenInclude(pp => pp.PropertyType)
                .Include(p => p.ProductProperties)
                    .ThenInclude(pp => pp.PropertyValue)
                .Include(p => p.Comments.Where(c => c.IsApproved && !c.IsDeleted))
                .FirstOrDefaultAsync(p => p.Id == id && p.IsActive && !p.IsDeleted);

            if (product == null)
                return NotFound();

            var colorOptions = product.ProductProperties?
                .Where(pp => pp.PropertyType.Name == "Renk" && pp.IsActive)
                .Select(pp => new ProductPropertyViewModel
                {
                    Id = pp.Id,
                    Value = pp.PropertyValue.Value,
                    Stock = pp.Stock,
                    IsSelected = false
                })
                .ToList() ?? new List<ProductPropertyViewModel>();

            // Hafıza seçeneklerini sadece telefonlar için göster (SubCategoryId = 3)
            var memoryOptions = product.SubCategoryId == 3 ? 
                product.ProductProperties?
                    .Where(pp => pp.PropertyType.Name == "Hafıza" && pp.IsActive)
                    .Select(pp => new ProductPropertyViewModel
                    {
                        Id = pp.Id,
                        Value = pp.PropertyValue.Value,
                        Stock = pp.Stock,
                        IsSelected = false
                    })
                    .ToList() ?? new List<ProductPropertyViewModel>() 
                : new List<ProductPropertyViewModel>();
                
            var comments = product.Comments?
                .Select(c => new CommentViewModel
                {
                    Id = c.Id,
                    Text = c.Text,
                    Rating = c.Rating,
                    ProductId = c.ProductId,
                    ProductCode = c.ProductCode,
                    UserName = c.UserName,
                    CreatedDate = c.CreatedDate
                })
                .ToList() ?? new List<CommentViewModel>();

            var viewModel = new ProductDetailViewModel
            {
                Id = product.Id,
                ProductCode = product.ProductCode,
                Name = product.Name,
                Description = product.Description,
                BrandId = product.BrandId,
                BrandName = product.Brand?.Name,
                Price = product.Price,
                DiscountPrice = product.DiscountPrice,
                HasDiscount = product.HasDiscount,
                Stock = product.GetTotalStock(),
                Rating = product.Comments != null && product.Comments.Any() ? 
                    (double)product.Comments.Average(c => c.Rating) : 4.5,
                ReviewCount = product.Comments?.Count ?? 0,
                Images = product.Images.OrderBy(i => i.Id).Select(i => $"/{i.Path}").ToList(),
                CategoryName = product.SubCategory?.Category?.Name,
                SubCategoryName = product.SubCategory?.Name,
                HasFreeShipping = product.Price > 45000,
                ColorOptions = colorOptions,
                MemoryOptions = memoryOptions,
                Comments = comments
            };

            var cacheOptions = new DistributedCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromMinutes(10))
                .SetAbsoluteExpiration(TimeSpan.FromHours(1));

            await _cache.SetStringAsync(
                cacheKey,
                JsonSerializer.Serialize(viewModel, _jsonOptions),
                cacheOptions
            );

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(CommentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = await _context.Products
                    .Include(p => p.Comments)
                    .FirstOrDefaultAsync(p => p.Id == model.ProductId && p.IsActive && !p.IsDeleted);
                
                if (product == null)
                    return NotFound();
                
                var comment = new MarketWorld.Core.Domain.Entities.Comment
                {
                    Text = model.Text,
                    Rating = model.Rating,
                    ProductId = model.ProductId,
                    ProductCode = product.ProductCode,
                    UserName = model.UserName,
                    IsApproved = true, // Otomatik onaylı (gerçek uygulamada admin onayı gerekebilir)
                    CreatedDate = DateTime.Now
                };
                
                await _context.AddAsync(comment);
                await _context.SaveChangesAsync();
                
                // Ürünün ortalama puanını güncelle
                if (product.Comments != null && product.Comments.Any())
                {
                    product.Rating = (decimal)product.Comments.Average(c => c.Rating);
                    await _context.SaveChangesAsync();
                }

                // Önbelleği temizle
                string productDetailCacheKey = $"{CacheKey}_product_detail_{model.ProductId}";
                await _cache.RemoveAsync(productDetailCacheKey);
                
                // İlgili alt kategori önbelleklerini de temizleyelim
                if (product.SubCategory != null)
                {
                    string subCategoryName = product.SubCategory.ShortenedEntityName.ToLower();
                    string subcategoryCacheKey = $"{CacheKey}_subcategory_{subCategoryName}";
                    await _cache.RemoveAsync(subcategoryCacheKey);
                    
                    // Sayfalanmış önbellekleri temizle
                    for (int i = 1; i <= 10; i++) 
                    {
                        string pagedCacheKey = $"{CacheKey}_subcategory_paged_{subCategoryName}_{i}";
                        await _cache.RemoveAsync(pagedCacheKey);
                    }

                    // Markalar önbelleğini de temizleyelim
                    string brandsCacheKey = $"{CacheKey}_brands_{subCategoryName.ToLower()}";
                    await _cache.RemoveAsync(brandsCacheKey);
                }
                
                return RedirectToAction("Detail", new { id = model.ProductId });
            }
            
            return RedirectToAction("Detail", new { id = model.ProductId });
        }

        // Alt kategorileri listeleyen test metodu
        public async Task<IActionResult> ListSubCategories()
        {
            var subCategories = await _context.SubCategories
                .Select(sc => new { sc.Id, sc.Name, sc.ShortenedEntityName, sc.CategoryId })
                .ToListAsync();
            
            return Json(subCategories);
        }

        public async Task<IActionResult> Search(string query)
        {
            if (string.IsNullOrEmpty(query))
                return RedirectToAction("Index", "Home");

            var userId = HttpContext.Items["UserId"]?.ToString();
            ViewBag.IsLoggedIn = !string.IsNullOrEmpty(userId);

            var products = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Images)
                .Include(p => p.SubCategory)
                    .ThenInclude(sc => sc.Category)
                .Where(p => p.Name.Contains(query) || 
                           p.Description.Contains(query) ||
                           p.Brand.Name.Contains(query) ||
                           p.SubCategory.Name.Contains(query) ||
                           p.SubCategory.Category.Name.Contains(query))
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    DiscountPrice = p.DiscountPrice,
                    HasDiscount = p.HasDiscount,
                    ImageUrl = p.Images.FirstOrDefault() != null ?
                              $"/{p.Images.FirstOrDefault().Path}" :
                              "/img/default-product.jpg",
                    BrandName = p.Brand.Name,
                    CategoryName = p.SubCategory.Category.Name,
                    Rating = p.Rating,
                    ReviewCount = 100,
                    HasFreeShipping = p.Price > 45000
                })
                .ToListAsync();

            var brands = await _context.Brands
                .Where(b => !b.IsDeleted)
                .OrderBy(b => b.Name)
                .ToListAsync();

            ViewBag.Brands = brands;
            ViewBag.SearchQuery = query;
            return View("ProductList", products);
        }

        [HttpGet]
        public async Task<IActionResult> LoadMoreProducts(string subCategoryName, int page = 1, 
            List<int> brandIds = null, List<decimal> ratings = null, decimal minPrice = 0, decimal maxPrice = 0)
        {
            if (string.IsNullOrEmpty(subCategoryName))
                return BadRequest("Alt kategori adı gereklidir.");

            var userId = HttpContext.Items["UserId"]?.ToString();
            ViewBag.IsLoggedIn = !string.IsNullOrEmpty(userId);

            var pageSize = 9;
            var query = _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Images)
                .Include(p => p.SubCategory)
                    .ThenInclude(sc => sc.Category)
                .Where(p => p.SubCategory.ShortenedEntityName.ToLower() == subCategoryName.ToLower() && p.IsActive && !p.IsDeleted);

            if (brandIds != null && brandIds.Any())
            {
                query = query.Where(p => brandIds.Contains(p.BrandId));
            }

            if (ratings != null && ratings.Any())
            {
                query = query.Where(p => ratings.Contains(p.Rating));
            }

            if (minPrice > 0)
            {
                query = query.Where(p => p.Price >= minPrice);
            }

            if (maxPrice > 0)
            {
                query = query.Where(p => p.Price <= maxPrice);
            }

            var totalItems = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            var products = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(p => new
                {
                    id = p.Id,
                    name = p.Name,
                    brandName = p.Brand.Name,
                    price = p.Price,
                    discountPrice = p.DiscountPrice,
                    hasDiscount = p.HasDiscount,
                    imageUrl = p.Images.FirstOrDefault() != null ? $"/{p.Images.FirstOrDefault().Path}" : "/img/default-product.jpg",
                    rating = p.Rating,
                    reviewCount = 100, // Örnek değer
                    hasFreeShipping = p.Price > 45000,
                    productCode = p.ProductCode
                })
                .ToListAsync();

            return Json(new { products, hasMore = page < totalPages });
        }
    }
} 