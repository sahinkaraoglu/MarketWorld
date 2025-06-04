using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;
using MarketWorld.Web.Areas.Admin.Models.Panel;
using MarketWorld.Application.Services.Interfaces;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace MarketWorld.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class PanelController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IProductService _productService;
        private readonly IBrandService _brandService;
        private readonly ICategoryService _categoryService;
        private readonly ISubCategoryService _subCategoryService;
        private readonly IOrderService _orderService;
        private readonly IDistributedCache _cache;
        private readonly JsonSerializerOptions _jsonOptions;

        public PanelController(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IProductService productService,
            IBrandService brandService,
            ICategoryService categoryService,
            ISubCategoryService subCategoryService,
            IOrderService orderService,
            IDistributedCache cache)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _productService = productService;
            _brandService = brandService;
            _categoryService = categoryService;
            _subCategoryService = subCategoryService;
            _orderService = orderService;
            _cache = cache;
            _jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        [HttpGet]
        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            string cacheKey = "admin_panel_dashboard";
            string cachedData = await _cache.GetStringAsync(cacheKey);

            if (!string.IsNullOrEmpty(cachedData))
            {
                var cachedDashboardData = JsonSerializer.Deserialize<Dictionary<string, int>>(cachedData, _jsonOptions);
                foreach (var item in cachedDashboardData)
                {
                    ViewBag[item.Key] = item.Value;
                }
                return View();
            }

            var products = await _productService.GetAllProducts();
            
            // Ürün istatistikleri
            ViewBag.ProductsCount = products.Count();
            
            // Stok az olan ürün sayısını hesaplama
            ViewBag.LowStockCount = products.Count(p => p.GetTotalStock() < 10);
                
            // Kategori istatistikleri
            var categories = await _categoryService.GetAllCategoriesAsync();
            var subCategories = await _subCategoryService.GetAllSubCategoriesAsync();
            ViewBag.CategoriesCount = categories.Count();
            ViewBag.SubCategoriesCount = subCategories.Count();
            
            // Kullanıcı istatistikleri
            var users = await _userManager.Users.ToListAsync();
            ViewBag.TotalUsersCount = users.Count;
            ViewBag.NewUsersCount = users.Count(u => u.CreateDate >= DateTime.Now.AddDays(-7));
                
            // Marka istatistikleri
            var brands = await _brandService.GetAllBrandsAsync();
            ViewBag.BrandsCount = brands.Count();
            
            // Çok satan markaları hesapla
            var topSellerBrands = await _orderService.GetTopSellingBrandsAsync(10);
            ViewBag.TopSellerBrandsCount = topSellerBrands.Count();
            
            // Önbelleğe kaydet
            var dashboardDataToCache = new Dictionary<string, int>
            {
                { "ProductsCount", ViewBag.ProductsCount },
                { "LowStockCount", ViewBag.LowStockCount },
                { "CategoriesCount", ViewBag.CategoriesCount },
                { "SubCategoriesCount", ViewBag.SubCategoriesCount },
                { "TotalUsersCount", ViewBag.TotalUsersCount },
                { "NewUsersCount", ViewBag.NewUsersCount },
                { "BrandsCount", ViewBag.BrandsCount },
                { "TopSellerBrandsCount", ViewBag.TopSellerBrandsCount }
            };

            var cacheOptions = new DistributedCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromMinutes(5))
                .SetAbsoluteExpiration(TimeSpan.FromHours(1));

            await _cache.SetStringAsync(
                cacheKey,
                JsonSerializer.Serialize(dashboardDataToCache, _jsonOptions),
                cacheOptions
            );
            
            return View();
        }

        [HttpGet]
        [Route("Products")]
        public IActionResult Products()
        {
            return RedirectToAction("Products", "Product", new { area = "Admin" });
        }
    }
} 