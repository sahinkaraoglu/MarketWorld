using AutoMapper;
using MarketWorld.Catalog.API.DTOs;
using MarketWorld.Core.Domain.Entities;
using ProductEntity = MarketWorld.Core.Domain.Entities.Product;
using CommentEntity = MarketWorld.Core.Domain.Entities.Comment;

namespace MarketWorld.Catalog.API.Mappings
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
                
            // Comment mapping
            CreateMap<CommentEntity, CommentDto>()
                .ReverseMap(); // CommentDto -> Comment
                
            // Request sınıfları için mapping
            CreateMap<CreateCommentRequest, CommentEntity>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Content));
                
            CreateMap<UpdateCommentRequest, CommentEntity>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Content));
        }
    }
}
