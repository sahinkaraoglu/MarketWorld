using MarketWorld.Domain.Entities;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllProducts();
    Task<Product> GetProductById(int id);
    Task<Product> CreateProduct(Product product);
    Task UpdateProduct(Product product);
    Task DeleteProduct(int id);
}