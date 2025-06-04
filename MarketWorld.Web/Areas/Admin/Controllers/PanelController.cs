using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;
using MarketWorld.Web.Areas.Admin.Models.Panel;
using MarketWorld.Application.Services.Interfaces;

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

        public PanelController(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IProductService productService,
            IBrandService brandService,
            ICategoryService categoryService,
            ISubCategoryService subCategoryService,
            IOrderService orderService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _productService = productService;
            _brandService = brandService;
            _categoryService = categoryService;
            _subCategoryService = subCategoryService;
            _orderService = orderService;;
        }

        [HttpGet]
        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
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
            
            return View();
        }

       
       
    }
} 