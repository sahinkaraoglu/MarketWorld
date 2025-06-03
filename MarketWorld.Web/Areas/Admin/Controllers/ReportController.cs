using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;
using MarketWorld.Web.Areas.Admin.Models.Panel;

namespace MarketWorld.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReportController : Controller
    {
        private readonly MarketWorldDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ReportController(
            MarketWorldDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                // Sipariş istatistikleri
                var orders = await _context.Orders
                    .Include(o => o.OrderItems)
                    .ToListAsync();

                // Aylık gelir
                var monthlyRevenue = orders
                    .Where(o => o.CreatedDate >= DateTime.Now.AddMonths(-1))
                    .Sum(o => o.TotalAmount);

                // Günlük gelir
                var dailyRevenue = orders
                    .Where(o => o.CreatedDate == DateTime.Today)
                    .Sum(o => o.TotalAmount);

                // En çok satan ürünler
                var topSellingProducts = await _context.OrderItems
                    .Include(oi => oi.Product)
                    .GroupBy(oi => oi.ProductId)
                    .Select(g => new
                    {
                        ProductId = g.Key,
                        ProductName = g.First().Product.Name,
                        TotalQuantity = g.Sum(oi => oi.Quantity),
                        TotalRevenue = g.Sum(oi => oi.Product.Price * oi.Quantity)
                    })
                    .OrderByDescending(x => x.TotalQuantity)
                    .Take(10)
                    .ToListAsync();

                // En çok satan kategoriler
                var topSellingCategories = await _context.OrderItems
                    .Include(oi => oi.Product)
                        .ThenInclude(p => p.SubCategory)
                            .ThenInclude(sc => sc.Category)
                    .GroupBy(oi => oi.Product.SubCategory.CategoryId)
                    .Select(g => new
                    {
                        CategoryId = g.Key,
                        CategoryName = g.First().Product.SubCategory.Category.Name,
                        TotalQuantity = g.Sum(oi => oi.Quantity),
                        TotalRevenue = g.Sum(oi => oi.Product.Price * oi.Quantity)
                    })
                    .OrderByDescending(x => x.TotalQuantity)
                    .Take(10)
                    .ToListAsync();

                // Sipariş durumu dağılımı
                var orderStatusDistribution = orders
                    .GroupBy(o => o.Status)
                    .Select(g => new
                    {
                        Status = g.Key,
                        Count = g.Count()
                    })
                    .ToList();

                ViewBag.MonthlyRevenue = monthlyRevenue;
                ViewBag.DailyRevenue = dailyRevenue;
                ViewBag.TopSellingProducts = topSellingProducts;
                ViewBag.TopSellingCategories = topSellingCategories;
                ViewBag.OrderStatusDistribution = orderStatusDistribution;

                return View();
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Raporlar yüklenirken bir hata oluştu: " + ex.Message;
                return View();
            }
        }
    }
} 