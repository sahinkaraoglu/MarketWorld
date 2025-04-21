using MarketWorld.Application.Services.Interfaces;
using MarketWorld.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using MarketWorld.API.DTOs;
using AutoMapper;

namespace MarketWorld.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        //[ProducesResponseType(typeof(IEnumerable<Product>), 200)]
        [Authorize]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProducts([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var products = await _productService.GetAllProducts();
            
            var totalProducts = products.Count();
            var pagedProducts = products
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
                
            var productDtos = _mapper.Map<List<ProductDto>>(pagedProducts);
                
            var result = new
            {
                Products = productDtos,
                TotalPages = (int)Math.Ceiling(totalProducts / (double)pageSize),
                CurrentPage = page,
                PageSize = pageSize,
                TotalProducts = totalProducts
            };
            
            return Ok(result);
        }

        [HttpGet("filter")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProductsByProductCode([FromQuery] int ProductCode)
        {
            var allProducts = await _productService.GetAllProducts();
            var filteredProducts = allProducts.Where(p => p.ProductCode == ProductCode).ToList();
            
            var productDtos = _mapper.Map<List<ProductDto>>(filteredProducts);
     
            return Ok(productDtos);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<ProductDto>> CreateProduct([FromBody] ProductDto productDto)
        {
            if (productDto == null)
                return BadRequest("Ürün verisi boş olamaz.");

            try
            {
                var product = _mapper.Map<Product>(productDto);
                var createdProduct = await _productService.CreateProduct(product);
                var createdProductDto = _mapper.Map<ProductDto>(createdProduct);
                return CreatedAtAction(nameof(GetAllProducts), new { id = createdProduct.Id }, createdProductDto);
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

        [HttpPut("{id}")]
        public async Task<ActionResult<ProductDto>> UpdateProduct(int id, [FromBody] ProductDto productDto)
        {
            if (productDto == null)
                return BadRequest("Ürün verisi boş olamaz.");

            if (id != productDto.Id)
                return BadRequest("Ürün ID'si eşleşmiyor.");
                
            try
            {
                var existingProduct = await _productService.GetProductById(id);
                if (existingProduct == null)
                    return NotFound($"ID: {id} ile ürün bulunamadı.");
                
                _mapper.Map(productDto, existingProduct);
                
                await _productService.UpdateProduct(existingProduct);
                return Ok(_mapper.Map<ProductDto>(existingProduct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ürün güncellenirken bir hata oluştu: {ex.Message}");
            }
        }
    }
}
