using MarketWorld.Core.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MarketWorld.Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task<Product> CreateProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task DeleteProduct(int id);
    }
}