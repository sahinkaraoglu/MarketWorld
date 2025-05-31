using MarketWorld.Application.Repositories;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketWorld.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly MarketWorldDbContext _marketWorldContext;

        public CategoryRepository(MarketWorldDbContext context) : base(context)
        {
            _marketWorldContext = context;
        }

        public async Task<IEnumerable<Category>> GetCategoriesWithProducts()
        {
            return await _marketWorldContext.Categories
                .Include(c => c.Products)
                .Include(c => c.SubCategories)
                .ToListAsync();
        }

        public async Task<Category> GetCategoryWithProducts(int id)
        {
            return await _marketWorldContext.Categories
                .Include(c => c.Products)
                .Include(c => c.SubCategories)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> IsCategoryNameUnique(string name)
        {
            return !await _marketWorldContext.Categories
                .AnyAsync(c => c.Name.ToLower() == name.ToLower());
        }

        public async Task<IEnumerable<SubCategory>> GetSubCategoriesByCategoryId(int categoryId)
        {
            return await _marketWorldContext.SubCategories
                .Where(sc => sc.CategoryId == categoryId)
                .ToListAsync();
        }

        public async Task<Category> GetCategoryWithSubCategories(int id)
        {
            return await _marketWorldContext.Categories
                .Include(c => c.SubCategories)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Category>> GetMainCategories()
        {
            return await _marketWorldContext.Categories
                //.Where(c => c. == null)
                .Include(c => c.SubCategories)
                .ToListAsync();
        }

        public async Task<Category> GetCategoryByNameAsync(string name)
        {
            return await _marketWorldContext.Categories
                .Include(c => c.SubCategories)
                .FirstOrDefaultAsync(c => c.Name.ToLower() == name.ToLower());
        }
    }
} 