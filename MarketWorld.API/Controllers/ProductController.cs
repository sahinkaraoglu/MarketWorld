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
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsByProductNumber([FromQuery] string productNumber)
        {
            var allProducts = await _productService.GetAllProducts();
            var filteredProducts = allProducts.Where(p => p.ProductNumber.Contains(productNumber)).ToList();
     
            return Ok(filteredProducts);
        }
    }
}
