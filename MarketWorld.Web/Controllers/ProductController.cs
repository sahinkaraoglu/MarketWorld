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
            var products = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Images)
                .Where(p => p.SubCategory.Name == subCategoryName && p.IsActive && !p.IsDeleted)
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
                    HasFreeShipping = p.Price > 45000,
                    Stock = p.Stock
                })
                .ToListAsync();

            return View("ProductList", products);
        }


        public async Task<IActionResult> Computers()
        {
            return await GetProductsBySubCategoryName("Bilgisayarlar & Tabletler");
        }

        public async Task<IActionResult> Printers()
        {
            return await GetProductsBySubCategoryName("Yazıcılar & Projeksiyon");
        }

        public async Task<IActionResult> Phones()
        {
            return await GetProductsBySubCategoryName("Telefonlar");
        }

        public async Task<IActionResult> Appliances()
        {
            return await GetProductsBySubCategoryName("Beyaz Eşya");
        }

        public async Task<IActionResult> Climate()
        {
            return await GetProductsBySubCategoryName("Klima ve Isıtıcılar");
        }

        public async Task<IActionResult> ShoesAndBags()
        {
            return await GetProductsBySubCategoryName("Ayakkabı & Çanta");
        }

        public async Task<IActionResult> WomensClothing()
        {
            return await GetProductsBySubCategoryName("Kadın Giyim");
        }

        public async Task<IActionResult> MensClothing()
        {
            return await GetProductsBySubCategoryName("Erkek Giyim");
        }

        public async Task<IActionResult> KidsClothing()
        {
            return await GetProductsBySubCategoryName("Çocuk Giyim");
        }

        public async Task<IActionResult> Furniture()
        {
            return await GetProductsBySubCategoryName("Mobilya");
        }

        public async Task<IActionResult> HomeTextile()
        {
            return await GetProductsBySubCategoryName("Ev Tekstili");
        }

        public async Task<IActionResult> Decoration()
        {
            return await GetProductsBySubCategoryName("Dekorasyon & Aydınlatma");
        }

        public async Task<IActionResult> Kitchen()
        {
            return await GetProductsBySubCategoryName("Mutfak Gereçleri");
        }

        public async Task<IActionResult> Bathroom()
        {
            return await GetProductsBySubCategoryName("Banyo & Ev Gereçleri");
        }

        public async Task<IActionResult> Stationery()
        {
            return await GetProductsBySubCategoryName("Kırtasiye & Ofis");
        }

        public async Task<IActionResult> Perfume()
        {
            return await GetProductsBySubCategoryName("Parfüm & Deodorant");
        }

        public async Task<IActionResult> HairCare()
        {
            return await GetProductsBySubCategoryName("Saç Şekillendirme");
        }

        public async Task<IActionResult> SkinCare()
        {
            return await GetProductsBySubCategoryName("Cilt Bakımı");
        }

        public async Task<IActionResult> Makeup()
        {
            return await GetProductsBySubCategoryName("Makyaj");
        }

        public async Task<IActionResult> Health()
        {
            return await GetProductsBySubCategoryName("Sağlık & Medikal Ürünler");
        }

        public async Task<IActionResult> DentalCare()
        {
            return await GetProductsBySubCategoryName("Ağız & Diş Bakımı");
        }

        public async Task<IActionResult> Fitness()
        {
            return await GetProductsBySubCategoryName("Fitness & Kondisyon");
        }

        public async Task<IActionResult> SportswearAndShoes()
        {
            return await GetProductsBySubCategoryName("Spor Giyim & Ayakkabı");
        }

        public async Task<IActionResult> OutdoorAndCamp()
        {
            return await GetProductsBySubCategoryName("Outdoor & Kamp");
        }

        public async Task<IActionResult> WinterSports()
        {
            return await GetProductsBySubCategoryName("Kış Sporları");
        }

        public async Task<IActionResult> WaterSports()
        {
            return await GetProductsBySubCategoryName("Su Sporları");
        }
    }
} 