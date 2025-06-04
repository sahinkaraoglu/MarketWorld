using MarketWorld.Application.Repositories;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketWorld.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly MarketWorldDbContext _marketWorldContext;

        public ProductRepository(MarketWorldDbContext context) : base(context)
        {
            _marketWorldContext = context;
        }

        public async Task<IEnumerable<Product>> GetProductsByCategory(int categoryId)
        {
            return await _marketWorldContext.Products
                .Where(p => p.CategoryId == categoryId)
                .Include(p => p.Category)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetActiveProducts()
        {
            return await _marketWorldContext.Products
                .Where(p => p.IsActive)
                .Include(p => p.Category)
                .ToListAsync();
        }

        public async Task<decimal> GetProductAveragePrice()
        {
            return await _marketWorldContext.Products
                .Where(p => p.IsActive)
                .AverageAsync(p => p.Price);
        }

        public async Task<Product> GetProductWithDetails(int id)
        {
            return await _marketWorldContext.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public override async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _marketWorldContext.Products
                .Include(p => p.SubCategory)
                    .ThenInclude(sc => sc.Category)
                .Include(p => p.Brand)
                .Include(p => p.Images)
                .Include(p => p.ProductProperties)
                    .ThenInclude(pp => pp.PropertyType)
                .Include(p => p.ProductProperties)
                    .ThenInclude(pp => pp.PropertyValue)
                .Include(p => p.Comments)
                .AsNoTracking()
                .ToListAsync();
        }
    }
} 