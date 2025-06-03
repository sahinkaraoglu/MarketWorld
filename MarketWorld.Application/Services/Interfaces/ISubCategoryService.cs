using MarketWorld.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Interfaces
{
    public interface ISubCategoryService
    {
        Task<IEnumerable<SubCategory>> GetAllSubCategoriesAsync();
        Task<SubCategory> GetSubCategoryByIdAsync(int id);
        Task<SubCategory> CreateSubCategoryAsync(SubCategory subCategory);
        Task UpdateSubCategoryAsync(SubCategory subCategory);
        Task DeleteSubCategoryAsync(int id);
        Task<bool> IsSubCategoryNameUniqueAsync(string name);
        Task<IEnumerable<SubCategory>> GetSubCategoriesByCategoryIdAsync(int categoryId);
    }
} 