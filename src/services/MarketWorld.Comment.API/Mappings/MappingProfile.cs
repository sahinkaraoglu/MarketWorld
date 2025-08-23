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
        }
    }
}
