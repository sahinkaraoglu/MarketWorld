using MarketWorld.Application.Services.Abstract;
using MarketWorld.Core.Domain.Entities;
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
        [Authorize]
        public async Task<ActionResult<IEnumerable<BrandDto>>> GetAllBrands()
        {
            var brands = await _brandService.GetAllBrandsAsync();
            var brandDtos = _mapper.Map<List<BrandDto>>(brands);
            return Ok(brandDtos);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<BrandDto>> GetBrandById(int id)
        {
            var brand = await _brandService.GetBrandByIdAsync(id);
            
            if (brand == null)
                return NotFound($"ID: {id} ile marka bulunamadı.");
                
            var brandDto = _mapper.Map<BrandDto>(brand);
            return Ok(brandDto);
        }

        [HttpGet("{id}/products")]
        [Authorize]
        public async Task<ActionResult<BrandDto>> GetBrandWithProducts(int id)
        {
            var brand = await _brandService.GetBrandWithProductsAsync(id);
            
            if (brand == null)
                return NotFound($"ID: {id} ile marka bulunamadı.");
                
            var brandDto = _mapper.Map<BrandDto>(brand);
            return Ok(brandDto);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<BrandDto>> CreateBrand([FromBody] BrandDto brandDto)
        {
            if (brandDto == null)
                return BadRequest("Marka verisi boş olamaz.");

            try
            {
                // Marka adının benzersiz olup olmadığını kontrol et
                if (!await _brandService.IsBrandNameUniqueAsync(brandDto.Name))
                {
                    return BadRequest($"\"{brandDto.Name}\" adında bir marka zaten mevcut.");
                }

                var brand = _mapper.Map<Brand>(brandDto);
                var createdBrand = await _brandService.CreateBrandAsync(brand);
                var createdBrandDto = _mapper.Map<BrandDto>(createdBrand);
                
                return CreatedAtAction(nameof(GetBrandById), new { id = createdBrand.Id }, createdBrandDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Marka oluşturulurken bir hata oluştu: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<BrandDto>> UpdateBrand(int id, [FromBody] BrandDto brandDto)
        {
            if (brandDto == null)
                return BadRequest("Marka verisi boş olamaz.");

            if (id != brandDto.Id)
                return BadRequest("Marka ID'si eşleşmiyor.");
                
            try
            {
                var existingBrand = await _brandService.GetBrandByIdAsync(id);
                
                if (existingBrand == null)
                    return NotFound($"ID: {id} ile marka bulunamadı.");
                
                // Marka adının benzersiz olup olmadığını kontrol et (aynı marka olmadığı sürece)
                if (existingBrand.Name != brandDto.Name && !await _brandService.IsBrandNameUniqueAsync(brandDto.Name))
                {
                    return BadRequest($"\"{brandDto.Name}\" adında bir marka zaten mevcut.");
                }
                
                _mapper.Map(brandDto, existingBrand);
                
                await _brandService.UpdateBrandAsync(existingBrand);
                return Ok(_mapper.Map<BrandDto>(existingBrand));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Marka güncellenirken bir hata oluştu: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult> DeleteBrand(int id)
        {
            try
            {
                var brand = await _brandService.GetBrandByIdAsync(id);
                
                if (brand == null)
                    return NotFound($"ID: {id} ile marka bulunamadı.");

                await _brandService.DeleteBrandAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Marka silinirken bir hata oluştu: {ex.Message}");
            }
        }
    }
}