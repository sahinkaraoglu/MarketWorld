using MarketWorld.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Repositories
{
    public interface IBrandRepository : IRepository<Brand>
    {
        Task<IEnumerable<Brand>> GetBrandsWithProducts();
        Task<Brand> GetBrandWithProducts(int id);
        Task<bool> IsBrandNameUnique(string name);
    }
} 