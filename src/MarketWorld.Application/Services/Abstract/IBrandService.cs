using MarketWorld.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Abstract
{
    public interface IBrandService
    {
        // Mevcut metodlar
        Task<IEnumerable<Brand>> GetAllBrandsAsync();
        Task<Brand> GetBrandByIdAsync(int id);
        Task<Brand> GetBrandWithProductsAsync(int id);
        Task<Brand> CreateBrandAsync(Brand brand);
        Task UpdateBrandAsync(Brand brand);
        Task DeleteBrandAsync(int id);
        Task<bool> IsBrandNameUniqueAsync(string name);
        
        // Product API için gerekli metodlar
        Task<IEnumerable<Brand>> GetAllAsync();
        Task<Brand> GetByIdAsync(int id);
        Task<IEnumerable<Brand>> GetPopularBrandsAsync(int count = 10);
        Task<IEnumerable<Brand>> GetBrandsByCategoryAsync(int categoryId);
        Task AddAsync(Brand brand);
        Task UpdateAsync(Brand brand);
        Task DeleteAsync(Brand brand);
    }
} 