using MarketWorld.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int id);
        Task<Category> GetCategoryWithProductsAsync(int id);
        Task<IEnumerable<Category>> GetCategoriesWithProductsAsync();
        Task<Category> CreateCategoryAsync(Category category);
        Task UpdateCategoryAsync(Category category);
        Task DeleteCategoryAsync(int id);
        Task<bool> IsCategoryNameUniqueAsync(string name);
        Task<IEnumerable<SubCategory>> GetSubCategoriesByCategoryIdAsync(int categoryId);
        Task<Category> GetCategoryWithSubCategoriesAsync(int id);
        Task<IEnumerable<Category>> GetMainCategoriesAsync();
        Task<IEnumerable<SubCategory>> GetSubCategoriesByMainCategoryAsync(string mainCategoryName);
        Task<SubCategory> GetSubCategoryByIdAsync(int id);
        Task DeleteSubCategoryAsync(int id);
        Task UpdateSubCategoryAsync(SubCategory subCategory);
    }
}
