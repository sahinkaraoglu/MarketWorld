using Microsoft.AspNetCore.Mvc;
using MarketWorld.Application.Services.Abstract;
using CatalogService.DTOs;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;

namespace CatalogService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts([FromQuery] int page = 1, [FromQuery] int pageSize = 20)
        {
            var products = await _productService.GetAllAsync();
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return Ok(productDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product == null)
                return NotFound("Ürün bulunamadı");

            var productDto = _mapper.Map<ProductDto>(product);
            return Ok(productDto);
        }

        [HttpGet("category/{categoryId}")]
        public async Task<IActionResult> GetProductsByCategory(int categoryId, [FromQuery] int page = 1, [FromQuery] int pageSize = 20)
        {
            var products = await _productService.GetProductsByCategoryAsync(categoryId);
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return Ok(productDtos);
        }

        [HttpGet("subcategory/{subCategoryId}")]
        public async Task<IActionResult> GetProductsBySubCategory(int subCategoryId, [FromQuery] int page = 1, [FromQuery] int pageSize = 20)
        {
            var products = await _productService.GetProductsBySubCategoryAsync(subCategoryId);
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return Ok(productDtos);
        }

        [HttpGet("brand/{brandId}")]
        public async Task<IActionResult> GetProductsByBrand(int brandId, [FromQuery] int page = 1, [FromQuery] int pageSize = 20)
        {
            var products = await _productService.GetProductsByBrandAsync(brandId);
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return Ok(productDtos);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchProducts([FromQuery] string query, [FromQuery] int page = 1, [FromQuery] int pageSize = 20)
        {
            var products = await _productService.SearchProductsAsync(query);
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return Ok(productDtos);
        }

        [HttpGet("featured")]
        public async Task<IActionResult> GetFeaturedProducts([FromQuery] int count = 10)
        {
            var products = await _productService.GetFeaturedProductsAsync(count);
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return Ok(productDtos);
        }

        [HttpGet("new-arrivals")]
        public async Task<IActionResult> GetNewArrivals([FromQuery] int count = 10)
        {
            var products = await _productService.GetNewArrivalsAsync(count);
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return Ok(productDtos);
        }

        [HttpGet("best-sellers")]
        public async Task<IActionResult> GetBestSellers([FromQuery] int count = 10)
        {
            var products = await _productService.GetBestSellersAsync(count);
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return Ok(productDtos);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] ProductDto productDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var product = _mapper.Map<MarketWorld.Core.Domain.Entities.Product>(productDto);
            await _productService.AddAsync(product);
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, productDto);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] ProductDto productDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingProduct = await _productService.GetByIdAsync(id);
            if (existingProduct == null)
                return NotFound("Ürün bulunamadı");

            _mapper.Map(productDto, existingProduct);
            await _productService.UpdateAsync(existingProduct);
            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product == null)
                return NotFound("Ürün bulunamadı");

            await _productService.DeleteAsync(product);
            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("{id}/activate")]
        public async Task<IActionResult> ActivateProduct(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product == null)
                return NotFound("Ürün bulunamadı");

            product.IsActive = true;
            await _productService.UpdateAsync(product);
            return Ok("Ürün aktif edildi");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("{id}/deactivate")]
        public async Task<IActionResult> DeactivateProduct(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product == null)
                return NotFound("Ürün bulunamadı");

            product.IsActive = false;
            await _productService.UpdateAsync(product);
            return Ok("Ürün deaktif edildi");
        }
    }
}
