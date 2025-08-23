using MarketWorld.Application.Repositories;
using MarketWorld.Application.Services.Abstract;
using MarketWorld.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return (await _unitOfWork.Categories.GetAllAsync()).Where(c => !c.IsDeleted);
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            var category = await _unitOfWork.Categories.GetByIdAsync(id);
            if (category == null)
                throw new ArgumentException($"Kategori bulunamadı. ID: {id}");

            return category;
        }

        public async Task<Category> GetCategoryWithProductsAsync(int id)
        {
            var category = await _unitOfWork.Categories.GetCategoryWithProducts(id);
            if (category == null)
                throw new ArgumentException($"Kategori bulunamadı. ID: {id}");

            return category;
        }

        public async Task<IEnumerable<Category>> GetCategoriesWithProductsAsync()
        {
            var categories = await _unitOfWork.Categories.GetCategoriesWithProducts();
            return categories.Where(c => !c.IsDeleted);
        }

        public async Task<Category> CreateCategoryAsync(Category category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));

            if (!await IsCategoryNameUniqueAsync(category.Name))
                throw new InvalidOperationException($"Bu isimde bir kategori zaten mevcut: {category.Name}");

            await _unitOfWork.Categories.AddAsync(category);
            await _unitOfWork.SaveChangesAsync();

            return category;
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));

            var existingCategory = await GetCategoryByIdAsync(category.Id);
            
            if (existingCategory.Name != category.Name && !await IsCategoryNameUniqueAsync(category.Name))
                throw new InvalidOperationException($"Bu isimde bir kategori zaten mevcut: {category.Name}");

            existingCategory.Name = category.Name;
            existingCategory.Description = category.Description;
            existingCategory.IsActive = category.IsActive;
            existingCategory.IsDeleted = category.IsDeleted;
            existingCategory.ShortenedEntityName = category.ShortenedEntityName;

            _unitOfWork.Categories.Update(existingCategory);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var category = await GetCategoryByIdAsync(id);
            
            // Alt kategorileri ve ürünleri kontrol et
            var categoryWithDetails = await GetCategoryWithProductsAsync(id);
            if ((categoryWithDetails.SubCategories?.Count > 0) || (categoryWithDetails.Products?.Count > 0))
                throw new InvalidOperationException("Alt kategorileri veya ürünleri olan bir kategori silinemez.");

            category.IsDeleted = true;
            _unitOfWork.Categories.Update(category);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> IsCategoryNameUniqueAsync(string name)
        {
            return await _unitOfWork.Categories.IsCategoryNameUnique(name);
        }

        public async Task<IEnumerable<SubCategory>> GetSubCategoriesByCategoryIdAsync(int categoryId)
        {
            return (await _unitOfWork.Categories.GetSubCategoriesByCategoryId(categoryId)).Where(sc => !sc.IsDeleted);
        }

        public async Task<Category> GetCategoryWithSubCategoriesAsync(int id)
        {
            var category = await _unitOfWork.Categories.GetCategoryWithSubCategories(id);
            if (category == null)
                throw new ArgumentException($"Kategori bulunamadı. ID: {id}");

            return category;
        }

        public async Task<IEnumerable<Category>> GetMainCategoriesAsync()
        {
            return await _unitOfWork.Categories.GetMainCategories();
        }

        public async Task<IEnumerable<SubCategory>> GetSubCategoriesByMainCategoryAsync(string mainCategoryName)
        {
            var mainCategory = await _unitOfWork.Categories.GetCategoryByNameAsync(mainCategoryName);
            if (mainCategory == null)
                throw new ArgumentException($"Ana kategori bulunamadı: {mainCategoryName}");

            return await _unitOfWork.Categories.GetSubCategoriesByCategoryId(mainCategory.Id);
        }

        public async Task<SubCategory> GetSubCategoryByIdAsync(int id)
        {
            var subCategory = await _unitOfWork.SubCategories.GetByIdAsync(id);
            if (subCategory == null)
                throw new ArgumentException($"Alt kategori bulunamadı. ID: {id}");

            return subCategory;
        }

        public async Task DeleteSubCategoryAsync(int id)
        {
            var subCategory = await GetSubCategoryByIdAsync(id);
            
            // Ürünleri kontrol et
            var subCategoryWithProducts = await _unitOfWork.SubCategories.GetSubCategoryWithProducts(id);
            if (subCategoryWithProducts.Products?.Count > 0)
                throw new InvalidOperationException("Ürünleri olan bir alt kategori silinemez.");

            subCategory.IsDeleted = true;
            _unitOfWork.SubCategories.Update(subCategory);
            await _unitOfWork.SaveChangesAsync();
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

        private async Task<bool> IsSubCategoryNameUniqueAsync(string name)
        {
            return await _unitOfWork.SubCategories.IsSubCategoryNameUnique(name);
        }
    }
}
