using MarketWorld.Application.Repositories;
using MarketWorld.Application.Services.Abstract;
using MarketWorld.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Concrete
{
    public class PropertyValueService : IPropertyValueService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PropertyValueService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<PropertyValue>> GetAllPropertyValuesAsync()
        {
            return await _unitOfWork.PropertyValues.GetAllAsync();
        }

        public async Task<PropertyValue> GetPropertyValueByIdAsync(int id)
        {
            var propertyValue = await _unitOfWork.PropertyValues.GetByIdAsync(id);
            if (propertyValue == null)
                throw new ArgumentException($"Özellik değeri bulunamadı. ID: {id}");

            return propertyValue;
        }

        public async Task<PropertyValue> CreatePropertyValueAsync(PropertyValue propertyValue)
        {
            if (propertyValue == null)
                throw new ArgumentNullException(nameof(propertyValue));

            if (!await IsPropertyValueUniqueAsync(propertyValue.Value, propertyValue.PropertyTypeId))
                throw new InvalidOperationException($"Bu değer zaten mevcut: {propertyValue.Value}");

            await _unitOfWork.PropertyValues.AddAsync(propertyValue);
            await _unitOfWork.SaveChangesAsync();

            return propertyValue;
        }

        public async Task UpdatePropertyValueAsync(PropertyValue propertyValue)
        {
            if (propertyValue == null)
                throw new ArgumentNullException(nameof(propertyValue));

            var existingPropertyValue = await GetPropertyValueByIdAsync(propertyValue.Id);
            
            if (existingPropertyValue.Value != propertyValue.Value && 
                !await IsPropertyValueUniqueAsync(propertyValue.Value, propertyValue.PropertyTypeId))
                throw new InvalidOperationException($"Bu değer zaten mevcut: {propertyValue.Value}");

            _unitOfWork.PropertyValues.Update(propertyValue);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeletePropertyValueAsync(int id)
        {
            var propertyValue = await GetPropertyValueByIdAsync(id);
            _unitOfWork.PropertyValues.Remove(propertyValue);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> IsPropertyValueUniqueAsync(string value, int propertyTypeId)
        {
            return await _unitOfWork.PropertyValues.IsPropertyValueUnique(value, propertyTypeId);
        }

        public async Task<IEnumerable<PropertyValue>> GetPropertyValuesByTypeIdAsync(int propertyTypeId)
        {
            return await _unitOfWork.PropertyValues.GetPropertyValuesByTypeId(propertyTypeId);
        }
    }
} 