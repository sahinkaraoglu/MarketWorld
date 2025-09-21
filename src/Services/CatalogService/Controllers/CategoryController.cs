using Microsoft.AspNetCore.Mvc;
using MarketWorld.Application.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using CatalogService.DTOs;

namespace CatalogService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _categoryService.GetAllAsync();
            var categoryDtos = _mapper.Map<List<CategoryDto>>(categories);
            return Ok(categoryDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null)
                return NotFound("Kategori bulunamadı");

            var categoryDto = _mapper.Map<CategoryDto>(category);
            return Ok(categoryDto);
        }

        [HttpGet("{id}/subcategories")]
        public async Task<IActionResult> GetSubCategories(int id)
        {
            var subCategories = await _categoryService.GetSubCategoriesByCategoryIdAsync(id);
            return Ok(subCategories);
        }

        [HttpGet("main")]
        public async Task<IActionResult> GetMainCategories()
        {
            var mainCategories = await _categoryService.GetMainCategoriesAsync();
            return Ok(mainCategories);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CategoryDto categoryDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var category = _mapper.Map<MarketWorld.Core.Domain.Entities.Category>(categoryDto);
            await _categoryService.AddAsync(category);
            return CreatedAtAction(nameof(GetCategoryById), new { id = category.Id }, categoryDto);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] CategoryDto categoryDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingCategory = await _categoryService.GetByIdAsync(id);
            if (existingCategory == null)
                return NotFound("Kategori bulunamadı");

            _mapper.Map(categoryDto, existingCategory);
            await _categoryService.UpdateAsync(existingCategory);
            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null)
                return NotFound("Kategori bulunamadı");

            await _categoryService.DeleteAsync(category);
            return NoContent();
        }
    }
}
