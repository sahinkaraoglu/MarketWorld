using MarketWorld.Application.Repositories;
using MarketWorld.Application.Services.Abstract;
using MarketWorld.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace MarketWorld.Application.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly Random _random;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _random = new Random();
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _unitOfWork.Products.GetAllAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _unitOfWork.Products.GetProductWithDetails(id);
        }

        public async Task<Product> CreateProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            // 6 haneli benzersiz rastgele ProductCode oluştur
            product.ProductCode = await GenerateUniqueProductCode();
            
            await _unitOfWork.Products.AddAsync(product);
            await _unitOfWork.SaveChangesAsync();
            return product;
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            if (product.ProductCode == 0)
            {
                product.ProductCode = await GenerateUniqueProductCode();
            }

            _unitOfWork.Products.Update(product);
            var result = await _unitOfWork.SaveChangesAsync();
            return result > 0;
        }

        public async Task DeleteProduct(int id)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(id);
            if (product == null)
                throw new ArgumentException($"Ürün bulunamadı. ID: {id}");

            _unitOfWork.Products.Remove(product);
            await _unitOfWork.SaveChangesAsync();
        }

        // 6 haneli benzersiz rastgele ProductCode oluşturan yardımcı metod
        private async Task<int> GenerateUniqueProductCode()
        {
            int productCode;
            bool isUnique = false;

            do
            {
                // 6 haneli rastgele sayı oluştur (100000-999999 arası)
                productCode = _random.Next(100000, 1000000);
                
                // Veritabanında bu numara var mı kontrol et
                isUnique = !await _unitOfWork.Products.AnyAsync(p => p.ProductCode == productCode);
                
            } while (!isUnique);

            return productCode;
        }
        
        // Product API için gerekli metodlar
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            return products.Where(p => !p.IsDeleted);
        }
        
        public async Task<Product> GetByIdAsync(int id)
        {
            return await _unitOfWork.Products.GetByIdAsync(id);
        }
        
        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            return products.Where(p => !p.IsDeleted && p.CategoryId == categoryId);
        }
        
        public async Task<IEnumerable<Product>> GetProductsBySubCategoryAsync(int subCategoryId)
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            return products.Where(p => !p.IsDeleted && p.SubCategoryId == subCategoryId);
        }
        
        public async Task<IEnumerable<Product>> GetProductsByBrandAsync(int brandId)
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            return products.Where(p => !p.IsDeleted && p.BrandId == brandId);
        }
        
        public async Task<IEnumerable<Product>> SearchProductsAsync(string query)
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            return products.Where(p => !p.IsDeleted && 
                                     (p.Name.Contains(query, StringComparison.OrdinalIgnoreCase) || 
                                      p.Description.Contains(query, StringComparison.OrdinalIgnoreCase)));
        }
        
        public async Task<IEnumerable<Product>> GetFeaturedProductsAsync(int count = 10)
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            return products.Where(p => !p.IsDeleted && p.IsActive)
                          .OrderByDescending(p => p.Rating)
                          .Take(count);
        }
        
        public async Task<IEnumerable<Product>> GetNewArrivalsAsync(int count = 10)
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            return products.Where(p => !p.IsDeleted && p.IsActive)
                          .OrderByDescending(p => p.CreatedDate)
                          .Take(count);
        }
        
        public async Task<IEnumerable<Product>> GetBestSellersAsync(int count = 10)
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            return products.Where(p => !p.IsDeleted && p.IsActive)
                          .OrderByDescending(p => p.Rating)
                          .Take(count);
        }
        
        public async Task AddAsync(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            // 6 haneli benzersiz rastgele ProductCode oluştur
            product.ProductCode = await GenerateUniqueProductCode();
            
            await _unitOfWork.Products.AddAsync(product);
            await _unitOfWork.SaveChangesAsync();
        }
        
        public async Task UpdateAsync(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            if (product.ProductCode == 0)
            {
                product.ProductCode = await GenerateUniqueProductCode();
            }

            _unitOfWork.Products.Update(product);
            await _unitOfWork.SaveChangesAsync();
        }
        
        public async Task DeleteAsync(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            _unitOfWork.Products.Remove(product);
            await _unitOfWork.SaveChangesAsync();
        }
    }
} 