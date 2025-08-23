using MarketWorld.Application.Repositories;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MarketWorld.Infrastructure.Repositories
{
    public class SubCategoryRepository : Repository<SubCategory>, ISubCategoryRepository
    {
        private readonly MarketWorldDbContext _marketWorldContext;

        public SubCategoryRepository(MarketWorldDbContext context) : base(context)
        {
            _marketWorldContext = context;
        }

        public async Task<SubCategory> GetSubCategoryWithProducts(int id)
        {
            return await _marketWorldContext.SubCategories
                .Include(sc => sc.Products)
                .FirstOrDefaultAsync(sc => sc.Id == id);
        }

        public async Task<bool> IsSubCategoryNameUnique(string name)
        {
            return !await _marketWorldContext.SubCategories
                .AnyAsync(sc => sc.Name == name && !sc.IsDeleted);
        }
    }
} 