using MarketWorld.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MarketWorld.Application.Services.Interfaces
{
    public interface ICommentService
    {
        Task<IEnumerable<Comment>> GetAllComments();
        Task<Comment> GetProductById(int id);
        Task<Comment> CreateProduct(Comment comment);
        Task UpdateProduct(Comment comment);
        Task DeleteProduct(int id);
    }
}