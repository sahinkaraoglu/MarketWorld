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

        public IActionResult Phones()
        {
            var products = _context.Products
                .Where(p => p.SubCategoryId == 3 && p.IsActive)
                .Include(p => p.Images)
                .Include(p => p.Brand)
                .ToList();

            var debugSql = products.Select(p => new
            {
                ProductId = p.Id,
                ImageCount = p.Images?.Count ?? 0,
                ImagePaths = string.Join(", ", p.Images?.Select(i => i.Path) ?? Enumerable.Empty<string>())
            }).ToList();

            foreach (var item in debugSql)
            {
                System.Diagnostics.Debug.WriteLine($"Product {item.ProductId}: {item.ImageCount} images - Paths: {item.ImagePaths}");
            }

            //log tablosu oluşturturken, log tablosuna yazdırılan sql sorgularını görebiliriz.

            var phones = products.Select(p => new ProductViewModel
            {
                Id = p.Id,
                BrandId = p.BrandId,
                BrandName = p.Brand?.Name ?? "Bilinmeyen Marka",
                Name = p.Name,
                Price = p.Price,
                ImageUrl = p.Images.FirstOrDefault() != null ? 
                          $"/{p.Images.FirstOrDefault().Path}" : 
                          "/img/default-product.jpg",
                HasFreeShipping = p.Price > 45000,
                Rating = 4.5,
                ReviewCount = 100,
                Stock = p.Stock,
                Description = p.Description
            }).ToList();

            return View(phones);
        }

        public async Task<IActionResult> WaterSports()
        {
            var products = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Images)
                .Where(p => p.SubCategory.Name == "Su Sporları" && p.IsActive && !p.IsDeleted)
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    BrandId = p.BrandId,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    ImageUrl = p.Images.FirstOrDefault() != null ? 
                              $"/{p.Images.FirstOrDefault().Path}" : 
                              "/img/default-product.jpg",
                    Rating = 4.5,
                    ReviewCount = 100,
                    HasFreeShipping = p.Price > 10000,
                    Stock = p.Stock
                })
                .ToListAsync();

            return View(products);
        }
    }
} 