using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Data;
using MarketWorld.Infrastructure;
using MarketWorld.Web.Models;
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
            // Debug için önce verileri çekelim
            var products = _context.Products
                .Where(p => p.SubCategoryId == 3 && p.IsActive)
                .Include(p => p.Images)
                .ToList();

            // Debug için SQL sorgusunu yazdıralım
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

            var phones = products.Select(p => new PhoneViewModel
            {
                Id = p.Id,
                Brand = p.Brand,
                Model = p.Name,
                Price = p.Price,
                ImageUrl = p.Images.FirstOrDefault() != null ? 
                          $"/{p.Images.FirstOrDefault().Path}" : 
                          "/img/default-product.jpg",
                HasFreeShipping = p.Price > 1000,
                Rating = 4.5,
                ReviewCount = 100,
                Stock = p.Stock,
                Description = p.Description
            }).ToList();

            return View(phones);
        }
    }
} 