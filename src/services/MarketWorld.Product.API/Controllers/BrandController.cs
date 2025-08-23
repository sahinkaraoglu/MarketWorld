using Microsoft.AspNetCore.Mvc;
using MarketWorld.Application.Services.Abstract;
using MarketWorld.API.DTOs;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;

namespace MarketWorld.Product.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        private readonly IMapper _mapper;

        public BrandController(IBrandService brandService, IMapper mapper)
        {
            _brandService = brandService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrands()
        {
            var brands = await _brandService.GetAllAsync();
            var brandDtos = _mapper.Map<List<BrandDto>>(brands);
            return Ok(brandDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrandById(int id)
        {
            var brand = await _brandService.GetByIdAsync(id);
            if (brand == null)
                return NotFound("Marka bulunamadı");

            var brandDto = _mapper.Map<BrandDto>(brand);
            return Ok(brandDto);
        }

        [HttpGet("popular")]
        public async Task<IActionResult> GetPopularBrands([FromQuery] int count = 10)
        {
            var brands = await _brandService.GetPopularBrandsAsync(count);
            var brandDtos = _mapper.Map<List<BrandDto>>(brands);
            return Ok(brandDtos);
        }

        [HttpGet("category/{categoryId}")]
        public async Task<IActionResult> GetBrandsByCategory(int categoryId)
        {
            var brands = await _brandService.GetBrandsByCategoryAsync(categoryId);
            var brandDtos = _mapper.Map<List<BrandDto>>(brands);
            return Ok(brandDtos);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateBrand([FromBody] BrandDto brandDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var brand = _mapper.Map<MarketWorld.Core.Domain.Entities.Brand>(brandDto);
            await _brandService.AddAsync(brand);
            return CreatedAtAction(nameof(GetBrandById), new { id = brand.Id }, brandDto);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBrand(int id, [FromBody] BrandDto brandDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingBrand = await _brandService.GetByIdAsync(id);
            if (existingBrand == null)
                return NotFound("Marka bulunamadı");

            _mapper.Map(brandDto, existingBrand);
            await _brandService.UpdateAsync(existingBrand);
            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            var brand = await _brandService.GetByIdAsync(id);
            if (brand == null)
                return NotFound("Marka bulunamadı");

            await _brandService.DeleteAsync(brand);
            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("{id}/activate")]
        public async Task<IActionResult> ActivateBrand(int id)
        {
            var brand = await _brandService.GetByIdAsync(id);
            if (brand == null)
                return NotFound("Marka bulunamadı");

            brand.IsActive = true;
            await _brandService.UpdateAsync(brand);
            return Ok("Marka aktif edildi");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("{id}/deactivate")]
        public async Task<IActionResult> DeactivateBrand(int id)
        {
            var brand = await _brandService.GetByIdAsync(id);
            if (brand == null)
                return NotFound("Marka bulunamadı");

            brand.IsActive = false;
            await _brandService.UpdateAsync(brand);
            return Ok("Marka deaktif edildi");
        }
    }
}
