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
                    Stock = p.Stock,
                    CategoryName = p.SubCategory.Category.Name,
                    HasDiscount = p.HasDiscount,
                    DiscountPrice = p.HasDiscount ? p.DiscountPrice : null
                }) .ToListAsync();

            var brands = await _context.Brands
                 .Where(b => !b.IsDeleted)
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

            var pageSize = 12;
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
                    Stock = p.Stock,
                    CategoryName = p.SubCategory.Category.Name,
                    HasDiscount = p.HasDiscount,
                    DiscountPrice = p.HasDiscount ? p.DiscountPrice : null
                })
                .ToListAsync();

            ViewBag.Brands = await _context.Brands.Where(b => !b.IsDeleted).OrderBy(b => b.Name).ToListAsync();
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
                Stock = product.Stock,
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
    }
} 