using MarketWorld.Core.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MarketWorld.Application.Services.Abstract
{
    public interface ICommentService
    {
        Task<IEnumerable<Comment>> GetAllComments();
        Task<IEnumerable<Comment>> GetAllAsync();
        Task<Comment> GetCommentById(int id);
        Task<Comment> GetByIdAsync(int id);
        Task<IEnumerable<Comment>> GetCommentsByProductIdAsync(int productId);
        Task<Comment> CreateComment(Comment comment);
        Task AddAsync(Comment comment);
        Task UpdateComment(Comment comment);
        Task UpdateAsync(Comment comment);
        Task DeleteComment(int id);
        Task DeleteAsync(Comment comment);
    }
}