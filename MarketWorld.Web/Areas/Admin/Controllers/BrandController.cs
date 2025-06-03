using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Web.Areas.Admin.Models.Panel;
using MarketWorld.Application.Services.Interfaces;

namespace MarketWorld.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        [Route("GetBrands")]
        public async Task<IActionResult> GetBrands()
        {
            var brands = await _brandService.GetAllBrandsAsync();
            return Json(brands.Select(b => new { id = b.Id, name = b.Name }));
        }

        [HttpGet]
        [Route("Brands")]
        public async Task<IActionResult> Brands(int page = 1, int pageSize = 20)
        {
            var brands = await _brandService.GetAllBrandsAsync();
            
            // Aktif ve toplam marka sayılarını hesapla
            ViewBag.TotalBrandsCount = brands.Count();
            ViewBag.ActiveBrandsCount = brands.Count(b => !b.IsDeleted);

            // Toplam sayfa sayısını hesapla
            var totalBrands = brands.Count();
            var totalPages = (int)Math.Ceiling(totalBrands / (double)pageSize);

            // Markaları sayfalayarak getir
            var pagedBrands = brands
                .OrderBy(b => b.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // Sayfalama bilgilerini ViewBag'e ekle
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.PageSize = pageSize;

            return View("Index", pagedBrands);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var brand = await _brandService.GetBrandByIdAsync(id);
            if (brand == null)
            {
                return NotFound();
            }

            return View("Edit", brand);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, string name, bool isDeleted)
        {
            var brand = await _brandService.GetBrandByIdAsync(id);
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

                await _brandService.UpdateBrandAsync(brand);

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
            var brand = await _brandService.GetBrandByIdAsync(id);
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
                var brand = await _brandService.GetBrandByIdAsync(id);
                if (brand == null)
                {
                    return Json(new { success = false, message = "Marka bulunamadı" });
                }

                // Markayı doğrudan silmek yerine IsDeleted'i true yapabiliriz
                brand.IsDeleted = true;
                brand.UpdatedDate = DateTime.Now;

                await _brandService.UpdateBrandAsync(brand);

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
            bool brandExists = !await _brandService.IsBrandNameUniqueAsync(name);
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
                await _brandService.CreateBrandAsync(brand);

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