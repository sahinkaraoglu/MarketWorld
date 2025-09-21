using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure;
using MarketWorld.Web.Models;
using static MarketWorld.Web.Models.CategoryViewModel;
using ProductViewModel = MarketWorld.Web.Models.ProductViewModel;
using Microsoft.Extensions.Caching.Memory;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;
using MarketWorld.Application.Services.Abstract;

namespace MarketWorld.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMemoryCache _cache;
        private const string CacheKey = "web_products";
        private readonly JsonSerializerOptions _jsonOptions;

        public ProductController(IProductService productService, IMemoryCache cache)
        {
            _productService = productService;
            _cache = cache;
            _jsonOptions = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                MaxDepth = 128
            };
        }

        private async Task<IActionResult> GetProductsBySubCategoryName(string subCategoryName)
        {
            string cacheKey = $"{CacheKey}_subcategory_{subCategoryName.ToLower()}";
            
            if (_cache.TryGetValue(cacheKey, out List<ProductViewModel> cachedProducts))
            {
                ViewBag.Brands = await GetBrandsForSubCategory(subCategoryName);
                return View("ProductList", cachedProducts);
            }

            var products = await _productService.GetAllProducts();
            var filteredProducts = products
                .Where(p => p.SubCategory?.ShortenedEntityName.ToLower() == subCategoryName.ToLower() && p.IsActive && !p.IsDeleted)
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    BrandId = p.BrandId,
                    BrandName = p.Brand?.Name,
                    CreatedDate = p.CreatedDate,
                    Price = p.Price,
                    ImageUrl = p.Images?.FirstOrDefault() != null ?
                              $"/{p.Images.FirstOrDefault().Path}" :
                              "/img/default-product.jpg",
                    Rating = p.Rating,
                    ReviewCount = 100,
                    HasFreeShipping = p.Price > 45000,
                    Stock = p.GetTotalStock(),
                    CategoryName = p.SubCategory?.Category?.Name,
                    HasDiscount = p.HasDiscount,
                    DiscountPrice = p.HasDiscount ? p.DiscountPrice : null,
                    ProductCode = p.ProductCode,
                    Color = p.ProductProperties?
                        .Where(pp => pp.PropertyType.Name == "Renk" && pp.IsActive)
                        .Select(pp => pp.PropertyValue.Value)
                        .FirstOrDefault() ?? "Varsayılan"
                }).ToList();

            var brands = await GetBrandsForSubCategory(subCategoryName);
            ViewBag.Brands = brands;

            var cacheOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromMinutes(10))
                .SetAbsoluteExpiration(TimeSpan.FromHours(1));

            _cache.Set(cacheKey, filteredProducts, cacheOptions);

            return View("ProductList", filteredProducts);
        }

        private async Task<List<Brand>> GetBrandsForSubCategory(string subCategoryName)
        {
            string brandsCacheKey = $"{CacheKey}_brands_{subCategoryName.ToLower()}";
            
            if (_cache.TryGetValue(brandsCacheKey, out List<Brand> cachedBrands))
            {
                return cachedBrands;
            }

            var products = await _productService.GetAllProducts();
            var brands = products
                .Where(p => p.SubCategory?.ShortenedEntityName.ToLower() == subCategoryName.ToLower() && p.IsActive && !p.IsDeleted)
                .Select(p => p.Brand)
                .Where(b => b != null && !b.IsDeleted)
                .GroupBy(b => b.Name)
                .Select(g => g.First())
                .OrderBy(b => b.Name)
                .ToList();

            var cacheOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromMinutes(15))
                .SetAbsoluteExpiration(TimeSpan.FromHours(2));

            _cache.Set(brandsCacheKey, brands, cacheOptions);

            return brands;
        }

        public async Task<IActionResult> ListBySubCategory(string subCategoryName, int page = 1)
        {
            if (string.IsNullOrEmpty(subCategoryName))
                return NotFound();

            string cacheKey = $"{CacheKey}_subcategory_paged_{subCategoryName.ToLower()}_{page}";
            
            if (_cache.TryGetValue(cacheKey, out object cachedData))
            {
                var cachedResult = (dynamic)cachedData;
                var cachedProducts = (List<ProductViewModel>)cachedResult.Products;
                var cachedBrands = await GetBrandsForSubCategory(subCategoryName);
                
                ViewBag.Brands = cachedBrands;
                ViewBag.CurrentPage = cachedResult.CurrentPage;
                ViewBag.TotalPages = cachedResult.TotalPages;
                ViewBag.SubCategoryName = subCategoryName;
                
                return View("ProductList", cachedProducts);
            }

            var products = await _productService.GetAllProducts();
            var filteredProducts = products
                .Where(p => p.SubCategory != null && 
                           p.SubCategory.ShortenedEntityName.ToLower() == subCategoryName.ToLower() && 
                           p.IsActive && !p.IsDeleted)
                .ToList();

            var pageSize = 9;
            var totalItems = filteredProducts.Count;
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            var pagedProducts = filteredProducts
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    BrandId = p.BrandId,
                    BrandName = p.Brand?.Name,
                    Price = p.Price,
                    ImageUrl = p.Images?.FirstOrDefault() != null ? $"/{p.Images.FirstOrDefault().Path}" : "/img/default-product.jpg",
                    Rating = p.Rating,
                    ReviewCount = p.Comments?.Count ?? 0,
                    HasFreeShipping = p.Price > 45000,
                    Stock = p.GetTotalStock(),
                    CategoryName = p.SubCategory?.Category?.Name,
                    HasDiscount = p.HasDiscount,
                    DiscountPrice = p.HasDiscount ? p.DiscountPrice : null,
                    ProductCode = p.ProductCode,
                    Color = p.ProductProperties?
                        .Where(pp => pp.PropertyType.Name == "Renk" && pp.IsActive)
                        .Select(pp => pp.PropertyValue.Value)
                        .FirstOrDefault() ?? "Varsayılan"
                })
                .ToList();

            var brands = await GetBrandsForSubCategory(subCategoryName);

            var result = new
            {
                Products = pagedProducts,
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

            var cacheOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromMinutes(10))
                .SetAbsoluteExpiration(TimeSpan.FromHours(1));

            _cache.Set(cacheKey, result, cacheOptions);

            return View("ProductList", pagedProducts);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            ViewBag.IsLoggedIn = !string.IsNullOrEmpty(userId);
            
            string cacheKey = $"{CacheKey}_product_detail_{id}";
            
            if (_cache.TryGetValue(cacheKey, out ProductDetailViewModel cachedProduct))
            {
                return View(cachedProduct);
            }

            var product = await _productService.GetProductById(id);
            if (product == null)
                return NotFound();

            var viewModel = new ProductDetailViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                BrandName = product.Brand?.Name,
                Rating = product.Rating,
                ReviewCount = product.Comments?.Count ?? 0,
                HasFreeShipping = product.Price > 45000,
                Stock = product.GetTotalStock(),
                CategoryName = product.SubCategory?.Category?.Name,
                SubCategoryName = product.SubCategory?.Name,
                HasDiscount = product.HasDiscount,
                DiscountPrice = product.HasDiscount ? product.DiscountPrice : null,
                ProductCode = product.ProductCode,
                Images = product.Images?.Select(i => $"/{i.Path}").ToList() ?? new List<string> { "/img/default-product.jpg" },
                Properties = product.ProductProperties?
                    .Where(pp => pp.IsActive)
                    .Select(pp => new ProductPropertyViewModel
                    {
                        TypeName = pp.PropertyType.Name,
                        Value = pp.PropertyValue.Value,
                        Stock = pp.Stock
                    }).ToList() ?? new List<ProductPropertyViewModel>(),
                ColorOptions = product.ProductProperties?
                    .Where(pp => pp.PropertyType.Name == "Renk" && pp.IsActive)
                    .Select(pp => new ProductPropertyViewModel
                    {
                        Id = pp.Id,
                        Value = pp.PropertyValue.Value,
                        Stock = pp.Stock,
                        IsSelected = false,
                        TypeName = pp.PropertyType.Name
                    }).ToList() ?? new List<ProductPropertyViewModel>(),
                MemoryOptions = product.ProductProperties?
                    .Where(pp => pp.PropertyType.Name == "Hafıza" && pp.IsActive)
                    .Select(pp => new ProductPropertyViewModel
                    {
                        Id = pp.Id,
                        Value = pp.PropertyValue.Value,
                        Stock = pp.Stock,
                        IsSelected = false,
                        TypeName = pp.PropertyType.Name
                    }).ToList() ?? new List<ProductPropertyViewModel>(),
                Comments = product.Comments?
                    .Where(c => c.IsApproved)
                    .Select(c => new CommentViewModel
                    {
                        Id = c.Id,
                        UserName = c.UserName,
                        Rating = c.Rating,
                        Text = c.Text,
                        CreatedDate = c.CreatedDate
                    }).ToList() ?? new List<CommentViewModel>()
            };

            var cacheOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromMinutes(10))
                .SetAbsoluteExpiration(TimeSpan.FromMinutes(10))
                .SetAbsoluteExpiration(TimeSpan.FromHours(1));

            _cache.Set(cacheKey, viewModel, cacheOptions);

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(CommentViewModel model)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Detail", new { id = model.ProductId });

            var product = await _productService.GetProductById(model.ProductId);
            if (product == null)
                return NotFound();

            var userId = HttpContext.Items["UserId"]?.ToString();
            if (string.IsNullOrEmpty(userId))
                return RedirectToAction("Index", "Login");

            // userId'yi int'e çevir - Identity kullanıcı ID'leri string olduğu için
            int userIdInt;
            if (!int.TryParse(userId, out userIdInt))
            {
                // Eğer string ID ise (admin-001 gibi), hash'leyerek int'e çevir
                userIdInt = Math.Abs(userId.GetHashCode());
            }

            var comment = new Comment
            {
                ProductId = model.ProductId,
                UserId = userIdInt,
                Text = model.Text,
                Rating = model.Rating,
                CreatedDate = DateTime.Now,
                UserName = HttpContext.User.Identity?.Name ?? "Anonim"
            };

            product.Comments.Add(comment);
            await _productService.UpdateProduct(product);

            return RedirectToAction("Detail", new { id = model.ProductId });
        }

        public async Task<IActionResult> ListSubCategories()
        {
            var products = await _productService.GetAllProducts();
            var subCategories = products
                .Where(p => p.SubCategory != null)
                .Select(p => p.SubCategory)
                .Distinct()
                .OrderBy(sc => sc.Name)
                .ToList();

            return View(subCategories);
        }

        public async Task<IActionResult> Search(string query)
        {
            if (string.IsNullOrEmpty(query))
                return RedirectToAction("Index", "Home");

            var products = await _productService.GetAllProducts();
            var searchResults = products
                .Where(p => p.IsActive && !p.IsDeleted && 
                    (p.Name.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                     p.Description.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                     p.Brand?.Name.Contains(query, StringComparison.OrdinalIgnoreCase) == true))
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    BrandId = p.BrandId,
                    BrandName = p.Brand?.Name,
                    Price = p.Price,
                    ImageUrl = p.Images?.FirstOrDefault() != null ? $"/{p.Images.FirstOrDefault().Path}" : "/img/default-product.jpg",
                    Rating = p.Rating,
                    ReviewCount = p.Comments?.Count ?? 0,
                    HasFreeShipping = p.Price > 45000,
                    Stock = p.GetTotalStock(),
                    CategoryName = p.SubCategory?.Category?.Name,
                    HasDiscount = p.HasDiscount,
                    DiscountPrice = p.HasDiscount ? p.DiscountPrice : null,
                    ProductCode = p.ProductCode,
                    Color = p.ProductProperties?
                        .Where(pp => pp.PropertyType.Name == "Renk" && pp.IsActive)
                        .Select(pp => pp.PropertyValue.Value)
                        .FirstOrDefault() ?? "Varsayılan"
                })
                .ToList();

            ViewBag.SearchQuery = query;
            return View("ProductList", searchResults);
        }

        [HttpGet]
        public async Task<IActionResult> LoadMoreProducts(string subCategoryName, int page = 1, 
            List<int> brandIds = null, List<decimal> ratings = null, decimal minPrice = 0, decimal maxPrice = 0)
        {
            var products = await _productService.GetAllProducts();
            var filteredProducts = products
                .Where(p => p.SubCategory?.ShortenedEntityName.ToLower() == subCategoryName.ToLower() && 
                           p.IsActive && !p.IsDeleted)
                .ToList();

            if (brandIds != null && brandIds.Any())
                filteredProducts = filteredProducts.Where(p => brandIds.Contains(p.BrandId)).ToList();

            if (ratings != null && ratings.Any())
                filteredProducts = filteredProducts.Where(p => ratings.Contains(Math.Floor(p.Rating))).ToList();

            if (minPrice > 0)
                filteredProducts = filteredProducts.Where(p => p.Price >= minPrice).ToList();

            if (maxPrice > 0)
                filteredProducts = filteredProducts.Where(p => p.Price <= maxPrice).ToList();

            var pageSize = 9;
            var pagedProducts = filteredProducts
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    BrandId = p.BrandId,
                    BrandName = p.Brand?.Name,
                    Price = p.Price,
                    ImageUrl = p.Images?.FirstOrDefault() != null ? $"/{p.Images.FirstOrDefault().Path}" : "/img/default-product.jpg",
                    Rating = p.Rating,
                    ReviewCount = p.Comments?.Count ?? 0,
                    HasFreeShipping = p.Price > 45000,
                    Stock = p.GetTotalStock(),
                    CategoryName = p.SubCategory?.Category?.Name,
                    HasDiscount = p.HasDiscount,
                    DiscountPrice = p.HasDiscount ? p.DiscountPrice : null,
                    ProductCode = p.ProductCode,
                    Color = p.ProductProperties?
                        .Where(pp => pp.PropertyType.Name == "Renk" && pp.IsActive)
                        .Select(pp => pp.PropertyValue.Value)
                        .FirstOrDefault() ?? "Varsayılan"
                })
                .ToList();

            bool hasMore = (page * pageSize) < filteredProducts.Count;

            return Json(new { products = pagedProducts, hasMore });
        }
    }
} 