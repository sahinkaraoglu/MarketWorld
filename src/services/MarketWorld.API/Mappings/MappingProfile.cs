using AutoMapper;
using MarketWorld.API.DTOs;
using MarketWorld.Core.Domain.Entities;

namespace MarketWorld.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>()
                .ReverseMap(); // ProductDto -> Product
                
            CreateMap<Comment, CommentDto>()
                .ReverseMap(); // CommentDto -> Comment (Text property'si otomatik map edilir)
                
            CreateMap<Brand, BrandDto>()
                .ReverseMap(); // BrandDto -> Brand
        }
    }
} 