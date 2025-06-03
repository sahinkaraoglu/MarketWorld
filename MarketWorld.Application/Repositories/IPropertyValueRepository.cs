using MarketWorld.Core.Domain.Entities;

namespace MarketWorld.Application.Repositories
{
    public interface IPropertyValueRepository : IRepository<PropertyValue>
    {
        Task<bool> IsPropertyValueUnique(string value, int propertyTypeId);
        Task<IEnumerable<PropertyValue>> GetPropertyValuesByTypeId(int propertyTypeId);
    }
} 