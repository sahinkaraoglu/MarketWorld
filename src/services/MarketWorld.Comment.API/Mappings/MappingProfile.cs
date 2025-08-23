using AutoMapper;
using MarketWorld.Comment.API.DTOs;
using CommentEntity = MarketWorld.Core.Domain.Entities.Comment;

namespace MarketWorld.Comment.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
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
