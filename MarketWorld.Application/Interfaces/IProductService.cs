using MarketWorld.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MarketWorld.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task<Product> CreateProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(int id);
    }
}