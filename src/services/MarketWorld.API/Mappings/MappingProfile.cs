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
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Content ?? src.Text))
                .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Text ?? src.Content))
                .ReverseMap(); // CommentDto -> Comment
                
            CreateMap<Brand, BrandDto>()
                .ReverseMap(); // BrandDto -> Brand
        }
    }
} 