using MarketWorld.Core.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MarketWorld.Application.Services.Abstract
{
    public interface IProductService
    {
        // Mevcut metodlar
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task<Product> CreateProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task DeleteProduct(int id);
        
        // Product API için gerekli metodlar
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId);
        Task<IEnumerable<Product>> GetProductsBySubCategoryAsync(int subCategoryId);
        Task<IEnumerable<Product>> GetProductsByBrandAsync(int brandId);
        Task<IEnumerable<Product>> SearchProductsAsync(string query);
        Task<IEnumerable<Product>> GetFeaturedProductsAsync(int count = 10);
        Task<IEnumerable<Product>> GetNewArrivalsAsync(int count = 10);
        Task<IEnumerable<Product>> GetBestSellersAsync(int count = 10);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Product product);
    }
}