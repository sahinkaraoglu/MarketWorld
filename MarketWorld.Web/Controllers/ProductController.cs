using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Data;
using MarketWorld.Infrastructure;
using MarketWorld.Web.Models;
using static MarketWorld.Web.Models.CategoryViewModel;
using ProductViewModel = MarketWorld.Web.Models.ProductViewModel;

namespace MarketWorld.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly MarketWorldDbContext _context;

        public ProductController(MarketWorldDbContext context)
        {
            _context = context;
        }

        private async Task<IActionResult> GetProductsBySubCategoryName(string subCategoryName)
        {
            var subCategory = await _context.SubCategories.FirstOrDefaultAsync(sc => sc.ShortenedEntityName.ToLower() == subCategoryName.ToLower());

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
                    DiscountPrice = p.HasDiscount ? p.DiscountPrice : null
                }) .ToListAsync();

            var brands = await _context.Brands
                 .Where(b => !b.IsDeleted && _context.Products
                     .Any(p => p.BrandId == b.Id && 
                              p.SubCategory.ShortenedEntityName.ToLower() == subCategoryName.ToLower() && 
                              p.IsActive && !p.IsDeleted))
                 .OrderBy(b => b.Name)
                 .ToListAsync();

            ViewBag.Brands = brands;

            return View("ProductList", products);
        }

        public async Task<IActionResult> ListBySubCategory(string subCategoryName, int page = 1)
        {
            if (string.IsNullOrEmpty(subCategoryName))
                return NotFound();

            var subCategory = await _context.SubCategories.FirstOrDefaultAsync(sc => sc.ShortenedEntityName.ToLower() == subCategoryName.ToLower());
            if (subCategory == null)
                return NotFound();

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
                    DiscountPrice = p.HasDiscount ? p.DiscountPrice : null
                })
                .ToListAsync();

            var brands = await _context.Brands
                .Where(b => !b.IsDeleted && _context.Products
                    .Any(p => p.BrandId == b.Id && 
                             p.SubCategory.ShortenedEntityName.ToLower() == subCategoryName.ToLower() && 
                             p.IsActive && !p.IsDeleted))
                .OrderBy(b => b.Name)
                .ToListAsync();

            ViewBag.Brands = brands;
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.SubCategoryName = subCategoryName;

            return View("ProductList", products);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Images)
                .Include(p => p.SubCategory)
                    .ThenInclude(sc => sc.Category)
                .Include(p => p.ProductProperties)
                    .ThenInclude(pp => pp.PropertyType)
                .Include(p => p.ProductProperties)
                    .ThenInclude(pp => pp.PropertyValue)
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

            var viewModel = new ProductDetailViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                BrandId = product.BrandId,
                BrandName = product.Brand?.Name,
                Price = product.Price,
                DiscountPrice = product.DiscountPrice,
                HasDiscount = product.HasDiscount,
                Stock = product.GetTotalStock(),
                Rating = 4.5,
                ReviewCount = 192,
                Images = product.Images.OrderBy(i => i.Id).Select(i => $"/{i.Path}").ToList(),
                CategoryName = product.SubCategory?.Category?.Name,
                SubCategoryName = product.SubCategory?.Name,
                HasFreeShipping = product.Price > 45000,
                ColorOptions = colorOptions,
                MemoryOptions = memoryOptions
            };

            return View(viewModel);
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
            if (string.IsNullOrWhiteSpace(query))
            {
                return RedirectToAction("Index", "Home");
            }

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
        public async Task<IActionResult> LoadMoreProducts(string subCategoryName, int page, [FromQuery] List<int> brandIds = null, [FromQuery] List<int> ratings = null, decimal minPrice = 0, decimal maxPrice = 0)
        {
            var pageSize = 9;
            var query = _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Images)
                .Include(p => p.SubCategory)
                    .ThenInclude(sc => sc.Category)
                .Where(p => p.SubCategory.ShortenedEntityName.ToLower() == subCategoryName.ToLower() && p.IsActive && !p.IsDeleted);

            // Filtreleri uygula
            if (brandIds != null && brandIds.Any())
            {
                query = query.Where(p => brandIds.Contains(p.BrandId));
            }

            if (ratings != null && ratings.Any())
            {
                query = query.Where(p => ratings.Contains((int)Math.Floor(p.Rating)));
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
                    hasFreeShipping = p.Price > 45000
                })
                .ToListAsync();

            return Json(new { products, hasMore = page < totalPages });
        }
    }
} 