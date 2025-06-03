using MarketWorld.Core.Domain.Entities;

namespace MarketWorld.Application.Repositories
{
    public interface IPropertyTypeRepository : IRepository<PropertyType>
    {
        Task<bool> IsPropertyTypeNameUnique(string name);
    }
} 