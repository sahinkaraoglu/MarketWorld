using AutoMapper;
using MarketWorld.API.DTOs;
using MarketWorld.Domain.Entities;

namespace MarketWorld.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>()
                .ReverseMap(); // ProductDto -> Product
                
            CreateMap<Comment, CommentDto>()
                .ReverseMap(); // CommentDto -> Comment
                
            CreateMap<Brand, BrandDto>()
                .ReverseMap(); // BrandDto -> Brand
        }
    }
} 