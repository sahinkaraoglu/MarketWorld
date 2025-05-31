using MarketWorld.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Repositories
{
    public interface ICommentRepository : IRepository<Comment>
    {
        Task<IEnumerable<Comment>> GetCommentsByProductId(int productId);
        Task<IEnumerable<Comment>> GetApprovedComments();
        Task<Comment> GetCommentWithDetails(int id);
    }
} 