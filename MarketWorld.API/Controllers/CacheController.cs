using Microsoft.AspNetCore.Mvc;
using MarketWorld.Application.Services.Interfaces;
using MarketWorld.Domain.Entities;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using MarketWorld.API.DTOs;
using AutoMapper;

namespace MarketWorld.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CacheController : ControllerBase
    {
        private readonly ICacheService _cacheService;
        private readonly IProductService _productService;
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;
        private const string PRODUCT_CACHE_PREFIX = "product:";
        private const string COMMENT_CACHE_PREFIX = "comment:";

        public CacheController(
            ICacheService cacheService,
            IProductService productService,
            ICommentService commentService,
            IMapper mapper)
        {
            _cacheService = cacheService;
            _productService = productService;
            _commentService = commentService;
            _mapper = mapper;
        }

        #region Product Cache Operations

        [HttpGet("products/{id}")]
        public async Task<ActionResult<ProductDto>> GetProductFromCache(int id)
        {
            try
            {
                var cacheKey = $"{PRODUCT_CACHE_PREFIX}{id}";
                
                // Cache'den kontrol et
                var cachedProduct = await _cacheService.GetAsync<ProductDto>(cacheKey);
                if (cachedProduct != null)
                {
                    return Ok(cachedProduct);
                }

                // Cache'de yoksa veritabanından al
                var product = await _productService.GetProductById(id);
                if (product == null)
                {
                    return NotFound();
                }

                // ProductDto'ya dönüştür
                var productDto = new ProductDto
                {
                    Id = product.Id,
                    ProductCode = product.ProductCode,
                    Name = product.Name,
                    BrandId = product.BrandId,
                    BrandName = product.Brand?.Name,
                    Price = product.Price,
                    IsActive = product.IsActive,
                    Description = product.Description,
                    DiscountPrice = product.DiscountPrice,
                    Rating = product.Rating,
                    HasDiscount = product.HasDiscount,
                    CategoryId = product.CategoryId,
                    CategoryName = product.Category?.Name,
                    SubCategoryId = product.SubCategoryId,
                    SubCategoryName = product.SubCategory?.Name,
                    ImageUrls = product.Images?.Select(i => i.Path).ToList(),
                    ProductProperties = product.ProductProperties?.Select(pp => new ProductPropertyDto
                    {
                        Id = pp.Id,
                        PropertyTypeName = pp.PropertyType?.Name,
                        PropertyValue = pp.PropertyValue?.Value,
                        Stock = pp.Stock,
                        IsActive = pp.IsActive
                    }).ToList()
                };

                // Cache'e kaydet (1 saat süreyle)
                await _cacheService.SetAsync(cacheKey, productDto, TimeSpan.FromHours(1));
                
                return Ok(productDto);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, $"Bir hata oluştu: {ex.Message}");
            }
        }

        [HttpPost("products/{id}")]
        public async Task<IActionResult> CacheProduct(int id)
        {
            try
            {
                var product = await _productService.GetProductById(id);
                if (product == null)
                {
                    return NotFound();
                }

                var productDto = new ProductDto
                {
                    Id = product.Id,
                    ProductCode = product.ProductCode,
                    Name = product.Name,
                    BrandId = product.BrandId,
                    BrandName = product.Brand?.Name,
                    Price = product.Price,
                    IsActive = product.IsActive,
                    Description = product.Description,
                    DiscountPrice = product.DiscountPrice,
                    Rating = product.Rating,
                    HasDiscount = product.HasDiscount,
                    CategoryId = product.CategoryId,
                    CategoryName = product.Category?.Name,
                    SubCategoryId = product.SubCategoryId,
                    SubCategoryName = product.SubCategory?.Name,
                    ImageUrls = product.Images?.Select(i => i.Path).ToList(),
                    ProductProperties = product.ProductProperties?.Select(pp => new ProductPropertyDto
                    {
                        Id = pp.Id,
                        PropertyTypeName = pp.PropertyType?.Name,
                        PropertyValue = pp.PropertyValue?.Value,
                        Stock = pp.Stock,
                        IsActive = pp.IsActive
                    }).ToList()
                };

                var cacheKey = $"{PRODUCT_CACHE_PREFIX}{id}";
                await _cacheService.SetAsync(cacheKey, productDto, TimeSpan.FromHours(1));
                
                return Ok();
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, $"Bir hata oluştu: {ex.Message}");
            }
        }

        [HttpDelete("products/{id}")]
        public async Task<IActionResult> RemoveProductFromCache(int id)
        {
            var cacheKey = $"{PRODUCT_CACHE_PREFIX}{id}";
            await _cacheService.RemoveAsync(cacheKey);
            return Ok();
        }

        #endregion

        #region Comment Cache Operations

        [HttpGet("comments/product/{productId}")]
        public async Task<ActionResult<IEnumerable<CommentDto>>> GetCommentsFromCache(int productId)
        {
            var cacheKey = $"{COMMENT_CACHE_PREFIX}product:{productId}";
            
            // Cache'den kontrol et
            var cachedComments = await _cacheService.GetAsync<List<Comment>>(cacheKey);
            if (cachedComments != null)
            {
                var commentDtos = _mapper.Map<IEnumerable<CommentDto>>(cachedComments);
                return Ok(commentDtos);
            }

            // Cache'de yoksa veritabanından al
            var comments = await _commentService.GetAllComments();
            var filteredComments = comments.Where(c => c.ProductId == productId).ToList();
            if (!filteredComments.Any())
            {
                return NotFound();
            }

            // Cache'e kaydet (30 dakika süreyle)
            await _cacheService.SetAsync(cacheKey, filteredComments, TimeSpan.FromMinutes(30));
            
            var result = _mapper.Map<IEnumerable<CommentDto>>(filteredComments);
            return Ok(result);
        }

        [HttpPost("comments/product/{productId}")]
        public async Task<IActionResult> CacheComments(int productId)
        {
            var comments = await _commentService.GetAllComments();
            var filteredComments = comments.Where(c => c.ProductId == productId).ToList();
            if (!filteredComments.Any())
            {
                return NotFound();
            }

            var cacheKey = $"{COMMENT_CACHE_PREFIX}product:{productId}";
            await _cacheService.SetAsync(cacheKey, filteredComments, TimeSpan.FromMinutes(30));
            
            return Ok();
        }

        [HttpDelete("comments/product/{productId}")]
        public async Task<IActionResult> RemoveCommentsFromCache(int productId)
        {
            var cacheKey = $"{COMMENT_CACHE_PREFIX}product:{productId}";
            await _cacheService.RemoveAsync(cacheKey);
            return Ok();
        }

        #endregion
    }
} 