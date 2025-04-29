using MarketWorld.Application.Repositories;
using MarketWorld.Domain.Entities;
using MarketWorld.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketWorld.Infrastructure.Repositories
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        private readonly MarketWorldDbContext _dbContext;

        public CommentRepository(MarketWorldDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Comment>> GetApprovedComments()
        {
            return await _dbContext.Comments
                .Where(c => c.IsApproved && !c.IsDeleted)
                .ToListAsync();
        }

        public async Task<Comment> GetCommentWithDetails(int id)
        {
            return await _dbContext.Comments
                .Include(c => c.Product)
                .FirstOrDefaultAsync(c => c.Id == id && !c.IsDeleted);
        }

        public async Task<IEnumerable<Comment>> GetCommentsByProductId(int productId)
        {
            return await _dbContext.Comments
                .Where(c => c.ProductId == productId && !c.IsDeleted)
                .ToListAsync();
        }
    }
} 