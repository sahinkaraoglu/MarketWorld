using MarketWorld.Application.Repositories;
using MarketWorld.Domain.Entities;
using MarketWorld.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Infrastructure.Repositories
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        private readonly MarketWorldDbContext _marketWorldContext;

        public BrandRepository(MarketWorldDbContext context) : base(context)
        {
            _marketWorldContext = context;
        }

        public async Task<IEnumerable<Brand>> GetBrandsWithProducts()
        {
            return await _marketWorldContext.Brands
                .Include(b => b.Products)
                .ToListAsync();
        }

        public async Task<Brand> GetBrandWithProducts(int id)
        {
            return await _marketWorldContext.Brands
                .Include(b => b.Products)
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<bool> IsBrandNameUnique(string name)
        {
            return !await _marketWorldContext.Brands
                .AnyAsync(b => b.Name.ToLower() == name.ToLower());
        }
    }
} 