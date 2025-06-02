using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;
using MarketWorld.Web.Areas.Admin.Models.Panel;

namespace MarketWorld.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly MarketWorldDbContext _context;

        public BrandController(MarketWorldDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetBrands")]
        public async Task<IActionResult> GetBrands()
        {
            var brands = await _context.Brands
                .Select(b => new { id = b.Id, name = b.Name })
                .ToListAsync();
            return Json(brands);
        }

        [HttpGet]
        [Route("Brands")]
        public async Task<IActionResult> Brands(int page = 1, int pageSize = 20)
        {
            // Aktif ve toplam marka sayılarını hesapla
            ViewBag.TotalBrandsCount = await _context.Brands.CountAsync();
            ViewBag.ActiveBrandsCount = await _context.Brands.Where(b => !b.IsDeleted).CountAsync();

            // Çok satan markaları hesapla
            var topSellerBrands = await _context.OrderItems
                .Include(oi => oi.Product)
                .ThenInclude(p => p.Brand)
                .Where(oi => oi.Product.Brand != null)
                .GroupBy(oi => oi.Product.BrandId)
                .Select(g => new { BrandId = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .Take(10)
                .CountAsync();

            ViewBag.TopSellerBrandsCount = topSellerBrands;

            // Toplam sayfa sayısını hesapla
            var totalBrands = await _context.Brands.CountAsync();
            var totalPages = (int)Math.Ceiling(totalBrands / (double)pageSize);

            // Markaları sayfalayarak getir
            var brands = await _context.Brands
                .Include(b => b.Products)
                .OrderBy(b => b.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            // Sayfalama bilgilerini ViewBag'e ekle
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.PageSize = pageSize;

            return View("Index", brands);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var brand = await _context.Brands.FindAsync(id);
            if (brand == null)
            {
                return NotFound();
            }

            return View("Edit", brand);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, string name, bool isDeleted)
        {
            var brand = await _context.Brands.FindAsync(id);
            if (brand == null)
            {
                return NotFound();
            }

            // Validasyon
            if (string.IsNullOrWhiteSpace(name))
            {
                ModelState.AddModelError("Name", "Marka adı boş olamaz");
                return View("Edit", brand);
            }

            try
            {
                brand.Name = name;
                brand.IsDeleted = isDeleted;
                brand.UpdatedDate = DateTime.Now;

                await _context.SaveChangesAsync();

                return RedirectToAction("Brands");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Hata oluştu: {ex.Message}");
                return View("Edit", brand);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            var brand = await _context.Brands.FindAsync(id);
            if (brand == null)
            {
                return NotFound();
            }

            return View("BrandDelete", brand);
        }

        [HttpPost]
        [ActionName("DeleteBrand")]
        public async Task<IActionResult> DeleteBrandConfirmed(int id)
        {
            try
            {
                var brand = await _context.Brands.FindAsync(id);
                if (brand == null)
                {
                    return Json(new { success = false, message = "Marka bulunamadı" });
                }

                // Markayı doğrudan silmek yerine IsDeleted'i true yapabiliriz
                brand.IsDeleted = true;
                brand.UpdatedDate = DateTime.Now;

                await _context.SaveChangesAsync();

                return Json(new { success = true, message = "Marka başarıyla silindi" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = $"Marka silinirken hata oluştu: {ex.Message}" });
            }
        }

        [HttpGet]
        public IActionResult AddBrand()
        {
            return View("Create");
        }

        [HttpPost]
        public async Task<IActionResult> AddBrand(string name, bool isDeleted)
        {
            // Validasyon
            if (string.IsNullOrWhiteSpace(name))
            {
                ViewBag.Error = "Marka adı boş olamaz";
                return View("Create");
            }

            // Marka adının benzersiz olup olmadığını kontrol et
            bool brandExists = await _context.Brands.AnyAsync(b => b.Name.ToLower() == name.ToLower());
            if (brandExists)
            {
                ViewBag.Error = "Bu isimde bir marka zaten var";
                return View("Create");
            }

            try
            {
                // Yeni marka oluştur
                var brand = new Brand
                {
                    Name = name,
                    IsDeleted = isDeleted,
                    CreatedDate = DateTime.Now
                };

                // Veritabanına ekle
                _context.Brands.Add(brand);
                await _context.SaveChangesAsync();

                return RedirectToAction("Brands");
            }
            catch (Exception ex)
            {
                ViewBag.Error = $"Marka eklenirken hata oluştu: {ex.Message}";
                return View("Create");
            }
        }
    }
}