using MarketWorld.Web.Models.Api;

namespace MarketWorld.Web.Services.Api
{
    public interface ICommentApiService
    {
        Task<CommentDto> CreateCommentAsync(CreateCommentRequest request, string token);
        Task<List<CommentDto>> GetProductCommentsAsync(int productId, int page = 1, int pageSize = 20);
        Task<CommentDto> GetCommentByIdAsync(int id);
        Task<CommentDto> UpdateCommentAsync(int id, CreateCommentRequest request, string token);
        Task DeleteCommentAsync(int id, string token);
    }
}
