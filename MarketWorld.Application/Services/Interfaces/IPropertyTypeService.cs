using MarketWorld.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Interfaces
{
    public interface IPropertyTypeService
    {
        Task<IEnumerable<PropertyType>> GetAllPropertyTypesAsync();
        Task<PropertyType> GetPropertyTypeByIdAsync(int id);
        Task<PropertyType> CreatePropertyTypeAsync(PropertyType propertyType);
        Task UpdatePropertyTypeAsync(PropertyType propertyType);
        Task DeletePropertyTypeAsync(int id);
        Task<bool> IsPropertyTypeNameUniqueAsync(string name);
    }
} 