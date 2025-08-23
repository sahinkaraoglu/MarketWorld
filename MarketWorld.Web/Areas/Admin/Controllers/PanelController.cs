using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;
using MarketWorld.Web.Areas.Admin.Models.Panel;
using MarketWorld.Application.Services.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using System.Text.Json;
using MarketWorld.Core.Enums;

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
        private readonly IMemoryCache _cache;
        private readonly JsonSerializerOptions _jsonOptions;

        public PanelController(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IProductService productService,
            IBrandService brandService,
            ICategoryService categoryService,
            ISubCategoryService subCategoryService,
            IOrderService orderService,
            IMemoryCache cache)
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
                
                if (_cache.TryGetValue(cacheKey, out Dictionary<string, int> cachedDashboardData))
                {
                    if (cachedDashboardData != null)
                    {
                        foreach (var item in cachedDashboardData)
                        {
                            ViewBag.SetValue(item.Key, item.Value);
                        }
                        return View();
                    }
                }

                // Sıralı işlem yapısı
                var products = await _productService.GetAllProducts() ?? new List<Product>();
                var categories = await _categoryService.GetAllCategoriesAsync() ?? new List<Category>();
                var subCategories = await _subCategoryService.GetAllSubCategoriesAsync() ?? new List<SubCategory>();
                var users = await _userManager.Users.ToListAsync() ?? new List<ApplicationUser>();
                var brands = await _brandService.GetAllBrandsAsync() ?? new List<Brand>();
                var topSellerBrands = await _orderService.GetTopSellingBrandsAsync(10) ?? new List<Brand>();
                
                // Sipariş istatistikleri
                var orders = await _orderService.GetAllOrdersAsync() ?? new List<Order>();
                ViewBag.NewOrdersCount = orders.Count(o => o.Status == OrderStatus.Pending);
                ViewBag.ShippingOrdersCount = orders.Count(o => o.Status == OrderStatus.Shipped);
                
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
                var dashboardData = new Dictionary<string, int>
                {
                    { "ProductsCount", (int)ViewBag.ProductsCount },
                    { "LowStockCount", (int)ViewBag.LowStockCount },
                    { "CategoriesCount", (int)ViewBag.CategoriesCount },
                    { "SubCategoriesCount", (int)ViewBag.SubCategoriesCount },
                    { "TotalUsersCount", (int)ViewBag.TotalUsersCount },
                    { "NewUsersCount", (int)ViewBag.NewUsersCount },
                    { "BrandsCount", (int)ViewBag.BrandsCount },
                    { "TopSellerBrandsCount", (int)ViewBag.TopSellerBrandsCount },
                    { "NewOrdersCount", (int)ViewBag.NewOrdersCount },
                    { "ShippingOrdersCount", (int)ViewBag.ShippingOrdersCount }
                };

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(5))
                    .SetAbsoluteExpiration(TimeSpan.FromHours(1));

                _cache.Set(cacheKey, dashboardData, cacheOptions);
                
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
                ViewBag.NewOrdersCount = 0;
                ViewBag.ShippingOrdersCount = 0;
                
                return View();
            }
        }

    }
} 