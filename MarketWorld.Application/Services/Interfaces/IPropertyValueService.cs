using MarketWorld.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Interfaces
{
    public interface IPropertyValueService
    {
        Task<IEnumerable<PropertyValue>> GetAllPropertyValuesAsync();
        Task<PropertyValue> GetPropertyValueByIdAsync(int id);
        Task<PropertyValue> CreatePropertyValueAsync(PropertyValue propertyValue);
        Task UpdatePropertyValueAsync(PropertyValue propertyValue);
        Task DeletePropertyValueAsync(int id);
        Task<bool> IsPropertyValueUniqueAsync(string value, int propertyTypeId);
        Task<IEnumerable<PropertyValue>> GetPropertyValuesByTypeIdAsync(int propertyTypeId);
    }
} 