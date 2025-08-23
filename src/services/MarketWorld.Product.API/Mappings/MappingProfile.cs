using AutoMapper;
using MarketWorld.Product.API.DTOs;
using MarketWorld.Core.Domain.Entities;
using ProductEntity = MarketWorld.Core.Domain.Entities.Product;

namespace MarketWorld.Product.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Product mapping
            CreateMap<ProductEntity, ProductDto>()
                .ForMember(dest => dest.TotalStock, opt => opt.MapFrom(src => src.GetTotalStock()))
                .ReverseMap();
                
            // Category mapping
            CreateMap<Category, CategoryDto>()
                .ReverseMap();
                
            // Brand mapping
            CreateMap<Brand, BrandDto>()
                .ReverseMap();
        }
    }
}
