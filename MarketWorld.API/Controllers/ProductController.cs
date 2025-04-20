using MarketWorld.Application.Services.Interfaces;
using MarketWorld.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace MarketWorld.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        //[ProducesResponseType(typeof(IEnumerable<Product>), 200)]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var products = await _productService.GetAllProducts();
            
            var totalProducts = products.Count();
            var pagedProducts = products
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
                
            var result = new
            {
                Products = pagedProducts,
                TotalPages = (int)Math.Ceiling(totalProducts / (double)pageSize),
                CurrentPage = page,
                PageSize = pageSize,
                TotalProducts = totalProducts
            };
            
            return Ok(result);
        }

        [HttpGet("filter")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsByProductCode([FromQuery] int ProductCode)
        {
            var allProducts = await _productService.GetAllProducts();
            var filteredProducts = allProducts.Where(p => p.ProductCode == ProductCode).ToList();
     
            return Ok(filteredProducts);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Product>> CreateProduct([FromBody] Product product)
        {
            if (product == null)
                return BadRequest("Ürün verisi boş olamaz.");

            try
            {
                var createdProduct = await _productService.CreateProduct(product);
                return CreatedAtAction(nameof(GetAllProducts), new { id = createdProduct.Id }, createdProduct);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ürün oluşturulurken bir hata oluştu: {ex.Message}");
            }
        }
        

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            try
            {
                var product = await _productService.GetProductById(id);
                if (product == null)
                    return NotFound($"ID: {id} ile ürün bulunamadı.");

                await _productService.DeleteProduct(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ürün silinirken bir hata oluştu: {ex.Message}");
            }
        }

        [HttpDelete("number/{ProductCode}")]
        [Authorize]
        public async Task<ActionResult> DeleteProductByCode(int ProductCode)
        {
            try
            {
                var allProducts = await _productService.GetAllProducts();
                var product = allProducts.FirstOrDefault(p => p.ProductCode == ProductCode);
                
                if (product == null)
                    return NotFound($"Ürün Numarası: {ProductCode} ile ürün bulunamadı.");

                await _productService.DeleteProduct(product.Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ürün silinirken bir hata oluştu: {ex.Message}");
            }
        }

      
    }
}
