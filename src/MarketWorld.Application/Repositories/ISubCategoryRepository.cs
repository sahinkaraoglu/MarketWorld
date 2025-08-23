using MarketWorld.Core.Domain.Entities;
using System.Threading.Tasks;

namespace MarketWorld.Application.Repositories
{
    public interface ISubCategoryRepository : IRepository<SubCategory>
    {
        Task<SubCategory> GetSubCategoryWithProducts(int id);
        Task<bool> IsSubCategoryNameUnique(string name);
    }
} 