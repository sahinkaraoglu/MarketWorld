using MarketWorld.Application.Repositories;
using MarketWorld.Application.Services.Abstract;
using MarketWorld.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Concrete
{
    public class PropertyTypeService : IPropertyTypeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PropertyTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<PropertyType>> GetAllPropertyTypesAsync()
        {
            return await _unitOfWork.PropertyTypes.GetAllAsync();
        }

        public async Task<PropertyType> GetPropertyTypeByIdAsync(int id)
        {
            var propertyType = await _unitOfWork.PropertyTypes.GetByIdAsync(id);
            if (propertyType == null)
                throw new ArgumentException($"Özellik tipi bulunamadı. ID: {id}");

            return propertyType;
        }

        public async Task<PropertyType> CreatePropertyTypeAsync(PropertyType propertyType)
        {
            if (propertyType == null)
                throw new ArgumentNullException(nameof(propertyType));

            if (!await IsPropertyTypeNameUniqueAsync(propertyType.Name))
                throw new InvalidOperationException($"Bu isimde bir özellik tipi zaten mevcut: {propertyType.Name}");

            await _unitOfWork.PropertyTypes.AddAsync(propertyType);
            await _unitOfWork.SaveChangesAsync();

            return propertyType;
        }

        public async Task UpdatePropertyTypeAsync(PropertyType propertyType)
        {
            if (propertyType == null)
                throw new ArgumentNullException(nameof(propertyType));

            var existingPropertyType = await GetPropertyTypeByIdAsync(propertyType.Id);
            
            if (existingPropertyType.Name != propertyType.Name && !await IsPropertyTypeNameUniqueAsync(propertyType.Name))
                throw new InvalidOperationException($"Bu isimde bir özellik tipi zaten mevcut: {propertyType.Name}");

            _unitOfWork.PropertyTypes.Update(propertyType);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeletePropertyTypeAsync(int id)
        {
            var propertyType = await GetPropertyTypeByIdAsync(id);
            _unitOfWork.PropertyTypes.Remove(propertyType);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> IsPropertyTypeNameUniqueAsync(string name)
        {
            return !await _unitOfWork.PropertyTypes.AnyAsync(pt => pt.Name.ToLower() == name.ToLower());
        }
    }
} 