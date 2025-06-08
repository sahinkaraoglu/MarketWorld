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
            try
            {
                string cacheKey = "admin_panel_dashboard";
                string cachedData = await _cache.GetStringAsync(cacheKey);

                if (!string.IsNullOrEmpty(cachedData))
                {
                    var cachedDashboardData = JsonSerializer.Deserialize<Dictionary<string, int>>(cachedData, _jsonOptions);
                    foreach (var item in cachedDashboardData)
                    {
                        ViewBag.SetValue(item.Key, item.Value);
                    }
                    return View();
                }

                // Sıralı işlem yapısı
                var products = await _productService.GetAllProducts() ?? new List<Product>();
                var categories = await _categoryService.GetAllCategoriesAsync() ?? new List<Category>();
                var subCategories = await _subCategoryService.GetAllSubCategoriesAsync() ?? new List<SubCategory>();
                var users = await _userManager.Users.ToListAsync() ?? new List<ApplicationUser>();
                var brands = await _brandService.GetAllBrandsAsync() ?? new List<Brand>();
                var topSellerBrands = await _orderService.GetTopSellingBrandsAsync(10) ?? new List<Brand>();
                
                // Ürün istatistikleri
                ViewBag.ProductsCount = products.Count();
                ViewBag.LowStockCount = products.Count(p => p.GetTotalStock() < 10);
                    
                // Kategori istatistikleri
                ViewBag.CategoriesCount = categories.Count();
                ViewBag.SubCategoriesCount = subCategories.Count();
                
                // Kullanıcı istatistikleri
                ViewBag.TotalUsersCount = users.Count;
                ViewBag.NewUsersCount = users.Count(u => u.CreateDate >= DateTime.Now.AddDays(-7));
                    
                // Marka istatistikleri
                ViewBag.BrandsCount = brands.Count();
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
                    .SetSlidingExpiration(TimeSpan.FromMinutes(15))
                    .SetAbsoluteExpiration(TimeSpan.FromHours(2));

                await _cache.SetStringAsync(
                    cacheKey,
                    JsonSerializer.Serialize(dashboardDataToCache, _jsonOptions),
                    cacheOptions
                );
                
                return View();
            }
            catch (Exception ex)
            {
                // Hata durumunda varsayılan değerler
                ViewBag.ProductsCount = 0;
                ViewBag.LowStockCount = 0;
                ViewBag.CategoriesCount = 0;
                ViewBag.SubCategoriesCount = 0;
                ViewBag.TotalUsersCount = 0;
                ViewBag.NewUsersCount = 0;
                ViewBag.BrandsCount = 0;
                ViewBag.TopSellerBrandsCount = 0;
                
                return View();
            }
        }

    }
} 