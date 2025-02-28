using MarketWorld.Domain.Entities;

public interface IProductService
{
    Task<IEnumerable<Products>> GetAllProducts();
    Task<Products> GetProductById(int id);
    Task<Products> CreateProduct(Products product);
    Task UpdateProduct(Products product);
    Task DeleteProduct(int id);
}