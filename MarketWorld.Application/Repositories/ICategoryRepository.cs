using MarketWorld.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<IEnumerable<Category>> GetCategoriesWithProducts();
        Task<Category> GetCategoryWithProducts(int id);
        Task<bool> IsCategoryNameUnique(string name);
        Task<IEnumerable<SubCategory>> GetSubCategoriesByCategoryId(int categoryId);
        Task<Category> GetCategoryWithSubCategories(int id);
        Task<IEnumerable<Category>> GetMainCategories();
    }
} 