using MarketWorld.Application.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using MarketWorld.API.DTOs;
using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using System.Text.Json;
using Microsoft.AspNetCore.JsonPatch;
using MarketWorld.Core.Domain.Entities;

namespace MarketWorld.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly IMemoryCache _cache;
        private const string CacheKey = "all_products";

        public ProductController(IProductService productService, IMapper mapper, IMemoryCache cache)
        {
            _productService = productService;
            _mapper = mapper;
            _cache = cache;
        }

        [HttpGet]
        //[ProducesResponseType(typeof(IEnumerable<Product>), 200)]
        [Authorize]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProducts([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            string cacheKey = $"{CacheKey}_{page}_{pageSize}";
            
            if (_cache.TryGetValue(cacheKey, out object cachedProducts))
            {
                return Ok(cachedProducts);
            }

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

            var cacheOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromMinutes(10))
                .SetAbsoluteExpiration(TimeSpan.FromHours(1));

            _cache.Set(cacheKey, result, cacheOptions);
            
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

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<ProductDto>> GetProductById(int id)
        {
            try
            {
                string cacheKey = $"{CacheKey}_single_{id}";
                
                if (_cache.TryGetValue(cacheKey, out ProductDto cachedProduct))
                {
                    return Ok(cachedProduct);
                }

                var product = await _productService.GetProductById(id);
                if (product == null)
                    return NotFound($"ID: {id} ile ürün bulunamadı.");

                var productDto = _mapper.Map<ProductDto>(product);

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(10))
                    .SetAbsoluteExpiration(TimeSpan.FromHours(1));

                _cache.Set(cacheKey, productDto, cacheOptions);

                return Ok(productDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ürün getirilirken bir hata oluştu: {ex.Message}");
            }
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

        [HttpPatch("{id}")]
        [Authorize]
        [ProducesResponseType(typeof(ProductDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<ProductDto>> PatchProduct(int id, [FromBody] JsonPatchDocument<ProductDto> patchDoc)
        {
            if (patchDoc == null)
                return BadRequest("Güncelleme verisi boş olamaz.");

            try
            {
                // Önbellekten veya veritabanından ürünü al
                Product existingProduct = await _productService.GetProductById(id);
                
                if (existingProduct == null)
                    return NotFound($"ID: {id} ile ürün bulunamadı.");
                

                var productDtoToUpdate = _mapper.Map<ProductDto>(existingProduct);

                patchDoc.ApplyTo(productDtoToUpdate);

                if (productDtoToUpdate.Name == existingProduct.Name)
                {
                    return BadRequest($"Güncelleme işlemi başarısız: Değerler değişmedi. Mevcut değer: {existingProduct.Name}");
                }

                _mapper.Map(productDtoToUpdate, existingProduct);
                
                var updateResult = await _productService.UpdateProduct(existingProduct);
                
                if (!updateResult)
                {
                    return StatusCode(500, "Ürün güncellenirken bir hata oluştu.");
                }

                string cacheKey = $"{CacheKey}_single_{id}";
                _cache.Remove(cacheKey);
                
                // Tüm ürün cache'lerini temizle
                var allCacheKeys = $"{CacheKey}_*";
                // Memory Cache'de pattern-based removal yok, manuel olarak temizle
                // Bu durumda sadece ilgili ürünün cache'ini temizliyoruz

                var updatedProductDto = _mapper.Map<ProductDto>(existingProduct);
                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(10))
                    .SetAbsoluteExpiration(TimeSpan.FromHours(1));
                
                _cache.Set(cacheKey, updatedProductDto, cacheOptions);

                return Ok(updatedProductDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ürün güncellenirken bir hata oluştu: {ex.Message}");
            }
        }
    }
}
