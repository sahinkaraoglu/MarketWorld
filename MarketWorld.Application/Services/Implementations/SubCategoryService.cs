using MarketWorld.Application.Repositories;
using MarketWorld.Application.Services.Interfaces;
using MarketWorld.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Implementations
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SubCategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<SubCategory>> GetAllSubCategoriesAsync()
        {
            return await _unitOfWork.SubCategories.GetAllAsync();
        }

        public async Task<SubCategory> GetSubCategoryByIdAsync(int id)
        {
            var subCategory = await _unitOfWork.SubCategories.GetByIdAsync(id);
            if (subCategory == null)
                throw new ArgumentException($"Alt kategori bulunamadı. ID: {id}");

            return subCategory;
        }

        public async Task<SubCategory> CreateSubCategoryAsync(SubCategory subCategory)
        {
            if (subCategory == null)
                throw new ArgumentNullException(nameof(subCategory));

            if (!await IsSubCategoryNameUniqueAsync(subCategory.Name))
                throw new InvalidOperationException($"Bu isimde bir alt kategori zaten mevcut: {subCategory.Name}");

            await _unitOfWork.SubCategories.AddAsync(subCategory);
            await _unitOfWork.SaveChangesAsync();

            return subCategory;
        }

        public async Task UpdateSubCategoryAsync(SubCategory subCategory)
        {
            if (subCategory == null)
                throw new ArgumentNullException(nameof(subCategory));

            var existingSubCategory = await GetSubCategoryByIdAsync(subCategory.Id);
            
            if (existingSubCategory.Name != subCategory.Name && !await IsSubCategoryNameUniqueAsync(subCategory.Name))
                throw new InvalidOperationException($"Bu isimde bir alt kategori zaten mevcut: {subCategory.Name}");

            _unitOfWork.SubCategories.Update(subCategory);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteSubCategoryAsync(int id)
        {
            var subCategory = await GetSubCategoryByIdAsync(id);
            
            // Ürünleri kontrol et
            var subCategoryWithProducts = await _unitOfWork.SubCategories.GetSubCategoryWithProducts(id);
            if (subCategoryWithProducts.Products?.Count > 0)
                throw new InvalidOperationException("Ürünleri olan bir alt kategori silinemez.");

            _unitOfWork.SubCategories.Remove(subCategory);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> IsSubCategoryNameUniqueAsync(string name)
        {
            return !await _unitOfWork.SubCategories.AnyAsync(sc => sc.Name.ToLower() == name.ToLower());
        }

        public async Task<IEnumerable<SubCategory>> GetSubCategoriesByCategoryIdAsync(int categoryId)
        {
            return await _unitOfWork.Categories.GetSubCategoriesByCategoryId(categoryId);
        }
    }
} 