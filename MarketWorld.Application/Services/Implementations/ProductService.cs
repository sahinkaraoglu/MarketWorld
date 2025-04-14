using MarketWorld.Application.Repositories;
using MarketWorld.Application.Services.Interfaces;
using MarketWorld.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Implementations
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

            // 6 haneli benzersiz rastgele ProductNumber oluştur
            product.ProductNumber = await GenerateUniqueProductNumber();
            
            await _unitOfWork.Products.AddAsync(product);
            await _unitOfWork.SaveChangesAsync();
            return product;
        }

        public async Task UpdateProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            // Eğer ProductNumber yoksa ya da boşsa yeni oluştur
            if (string.IsNullOrEmpty(product.ProductNumber))
            {
                product.ProductNumber = await GenerateUniqueProductNumber();
            }

            _unitOfWork.Products.Update(product);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(id);
            if (product == null)
                throw new ArgumentException($"Ürün bulunamadı. ID: {id}");

            _unitOfWork.Products.Remove(product);
            await _unitOfWork.SaveChangesAsync();
        }

        // 6 haneli benzersiz rastgele ProductNumber oluşturan yardımcı metod
        private async Task<string> GenerateUniqueProductNumber()
        {
            string productNumber;
            bool isUnique = false;

            do
            {
                // 6 haneli rastgele sayı oluştur (100000-999999 arası)
                productNumber = _random.Next(100000, 1000000).ToString();
                
                // Veritabanında bu numara var mı kontrol et
                isUnique = !await _unitOfWork.Products.AnyAsync(p => p.ProductNumber == productNumber);
                
            } while (!isUnique);

            return productNumber;
        }
    }
} 