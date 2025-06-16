using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Web.Areas.Admin.Models.Panel;
using MarketWorld.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MarketWorld.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public CategoryController(
            ICategoryService categoryService,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _categoryService = categoryService;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        [Route("Categories")]
        public async Task<IActionResult> Categories()
        {
            var categories = await _categoryService.GetCategoriesWithProductsAsync();
            return View("Index", categories);
        }

        [HttpGet]
        [Route("GetCategories")]
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                var categories = await _categoryService.GetAllCategoriesAsync();
                var categoryDtos = categories.Select(c => new { id = c.Id, name = c.Name });

                System.Diagnostics.Debug.WriteLine($"Bulunan kategori sayısı: {categories.Count()}");
                return Json(categoryDtos);
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
                var subCategories = await _categoryService.GetSubCategoriesByCategoryIdAsync(categoryId);
                var subCategoryDtos = subCategories
                    .Where(sc => !sc.IsDeleted)
                    .Select(sc => new { id = sc.Id, name = sc.Name })
                    .ToList();

                return Json(subCategoryDtos);
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
                var category = await _categoryService.GetCategoryWithProductsAsync(id);
                if (category == null)
                {
                    return Json(new { success = false, message = "Kategori bulunamadı" });
                }

                // Alt kategorileri veya ürünleri olan bir kategori silinememeli
                if ((category.SubCategories?.Count > 0) || (category.Products?.Count > 0))
                {
                    return Json(new
                    {
                        success = false,
                        message = "Bu kategorinin alt kategorileri veya ürünleri bulunmaktadır. Önce bunları silmelisiniz."
                    });
                }

                await _categoryService.DeleteCategoryAsync(id);
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
                var subCategory = await _categoryService.GetSubCategoryByIdAsync(id);
                if (subCategory == null)
                {
                    return Json(new { success = false, message = "Alt kategori bulunamadı" });
                }

                // Ürünleri olan bir alt kategori silinememeli
                if (subCategory.Products?.Count > 0)
                {
                    return Json(new
                    {
                        success = false,
                        message = "Bu alt kategorinin ürünleri bulunmaktadır. Önce ürünleri silmelisiniz."
                    });
                }

                await _categoryService.DeleteSubCategoryAsync(id);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        [Route("UpdateSubCategory")]
        public async Task<IActionResult> UpdateSubCategory([FromBody] UpdateSubCategoryModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Json(new { success = false, message = "Geçersiz veri" });
                }

                var subCategory = await _categoryService.GetSubCategoryByIdAsync(model.Id);
                if (subCategory == null)
                {
                    return Json(new { success = false, message = "Alt kategori bulunamadı" });
                }

                subCategory.Name = model.Name;
                subCategory.Description = model.Description;
                subCategory.IsActive = model.IsActive;
                subCategory.CategoryId = model.CategoryId;

                await _categoryService.UpdateSubCategoryAsync(subCategory);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpGet]
        [Route("Edit/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View("CategoryEdit", category);
        }

        [HttpPost]
        [Route("Edit")]
        public async Task<IActionResult> Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                await _categoryService.UpdateCategoryAsync(category);
                return RedirectToAction(nameof(Categories));
            }
            return View("CategoryEdit", category);
        }

        [HttpGet]
        [Route("EditSubCategory/{id}")]
        public async Task<IActionResult> EditSubCategory(int id)
        {
            var subCategory = await _categoryService.GetSubCategoryByIdAsync(id);
            if (subCategory == null)
            {
                return NotFound();
            }

            ViewBag.Categories = new SelectList(await _categoryService.GetAllCategoriesAsync(), "Id", "Name");
            return View("SubCategoryEdit", subCategory);
        }

        [HttpPost]
        [Route("EditSubCategory")]
        public async Task<IActionResult> EditSubCategory(SubCategory subCategory)
        {
            if (ModelState.IsValid)
            {
                await _categoryService.UpdateSubCategoryAsync(subCategory);
                return RedirectToAction(nameof(Categories));
            }

            ViewBag.Categories = new SelectList(await _categoryService.GetAllCategoriesAsync(), "Id", "Name");
            return View("SubCategoryEdit", subCategory);
        }
    }

    public class UpdateSubCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
    }
} 