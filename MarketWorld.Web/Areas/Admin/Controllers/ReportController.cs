using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Application.Services.Interfaces;
using MarketWorld.Web.Areas.Admin.Models.Panel;

namespace MarketWorld.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReportController : Controller
    {
        private readonly IReportService _reportService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ReportController(
            IReportService reportService,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _reportService = reportService;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var (monthlyRevenue, dailyRevenue, topSellingProducts, topSellingCategories, orderStatusDistribution) = 
                    await _reportService.GetReportDataAsync();

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