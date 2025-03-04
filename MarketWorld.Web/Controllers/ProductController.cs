using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Data;
using MarketWorld.Infrastructure;
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
            var phones = _context.Products
                .Where(p => p.SubCategoryId == 3 && p.IsActive) // SubCategoryId 3 olan telefonlar
                .Include(p => p.Images)
                .ToList();

            return View(phones);
        }
    }
} 