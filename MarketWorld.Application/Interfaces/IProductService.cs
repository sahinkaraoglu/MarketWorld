using MarketWorld.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MarketWorld.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Products>> GetAllProducts();
        Task<Products> GetProductById(int id);
        Task<Products> CreateProduct(Products product);
        Task UpdateProduct(Products product);
        Task DeleteProduct(int id);
    }
}