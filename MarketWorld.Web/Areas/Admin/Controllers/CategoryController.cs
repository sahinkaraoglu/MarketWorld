using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;
using MarketWorld.Web.Areas.Admin.Models.Panel;

namespace MarketWorld.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class CategoryController : Controller
    {
        private readonly MarketWorldDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public CategoryController(
            MarketWorldDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        [Route("Categories")]
        public async Task<IActionResult> Categories()
        {
            var categories = await _context.Categories
                .Include(c => c.SubCategories)
                    .ThenInclude(sc => sc.Products)
                .Include(c => c.Products)
                .ToListAsync();

            return View("Category/Index", categories);
        }

        [HttpGet]
        [Route("GetCategories")]
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                var categories = await _context.Categories
                    .Select(c => new { id = c.Id, name = c.Name })
                    .ToListAsync();

                System.Diagnostics.Debug.WriteLine($"Bulunan kategori sayısı: {categories.Count}");
                return Json(categories);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Kategori getirme hatası: {ex.Message}");
                return Json(new { error = ex.Message });
            }
        }


        [HttpGet]
        [Route("GetSubCategories/{categoryId}")]
        public async Task<IActionResult> GetSubCategories(int categoryId)
        {
            try
            {
                var category = await _context.Categories
                    .Include(c => c.SubCategories)
                    .FirstOrDefaultAsync(c => c.Id == categoryId);

                if (category == null)
                {
                    return NotFound($"Kategori bulunamadı: {categoryId}");
                }

                var subCategories = category.SubCategories
                    .Where(sc => !sc.IsDeleted)
                    .Select(sc => new { id = sc.Id, name = sc.Name })
                    .ToList();

                return Json(subCategories);
            }
            catch (Exception ex)
            {
                return BadRequest($"Alt kategoriler getirilirken hata oluştu: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("DeleteCategory/{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                var category = await _context.Categories
                    .Include(c => c.SubCategories)
                    .Include(c => c.Products)
                    .FirstOrDefaultAsync(c => c.Id == id);

                if (category == null)
                {
                    return Json(new { success = false, message = "Kategori bulunamadı" });
                }

                // Alt kategorileri veya ürünleri olan bir kategori silinememeli
                if (category.SubCategories != null && category.SubCategories.Any() ||
                    category.Products != null && category.Products.Any())
                {
                    return Json(new
                    {
                        success = false,
                        message = "Bu kategorinin alt kategorileri veya ürünleri bulunmaktadır. Önce bunları silmelisiniz."
                    });
                }

                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        [Route("DeleteSubCategory/{id}")]
        public async Task<IActionResult> DeleteSubCategory(int id)
        {
            try
            {
                var subCategory = await _context.SubCategories
                    .Include(sc => sc.Products)
                    .FirstOrDefaultAsync(sc => sc.Id == id);

                if (subCategory == null)
                {
                    return Json(new { success = false, message = "Alt kategori bulunamadı" });
                }

                // Ürünleri olan bir alt kategori silinememeli
                if (subCategory.Products != null && subCategory.Products.Any())
                {
                    return Json(new
                    {
                        success = false,
                        message = "Bu alt kategorinin ürünleri bulunmaktadır. Önce ürünleri silmelisiniz."
                    });
                }

                _context.SubCategories.Remove(subCategory);
                await _context.SaveChangesAsync();

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

    }
} 