using Microsoft.AspNetCore.Mvc;
using MarketWorld.Domain.Entities;
using MarketWorld.Application.Services.Interfaces;
using System.Threading.Tasks;

namespace MarketWorld.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetMainCategoriesAsync();
            return View(categories);
        }

        public async Task<IActionResult> Details(int id)
        {
            var category = await _categoryService.GetCategoryWithProductsAsync(id);
            return View(category);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _categoryService.CreateCategoryAsync(category);
                    return RedirectToAction(nameof(Index));
                }
                catch (InvalidOperationException ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            return View(category);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _categoryService.UpdateCategoryAsync(category);
                    return RedirectToAction(nameof(Index));
                }
                catch (InvalidOperationException ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            return View(category);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _categoryService.DeleteCategoryAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (InvalidOperationException ex)
            {
                return RedirectToAction(nameof(Index), new { error = ex.Message });
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetSubCategories(int categoryId)
        {
            var subCategories = await _categoryService.GetSubCategoriesByCategoryIdAsync(categoryId);
            return Json(subCategories);
        }

        [HttpGet]
        public async Task<IActionResult> Electronic()
        {
            var electronicSubCategories = await _categoryService.GetSubCategoriesByMainCategoryAsync("Elektronik");
            return View(electronicSubCategories);
        }
    }
} 