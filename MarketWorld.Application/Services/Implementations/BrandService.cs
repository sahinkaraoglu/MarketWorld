using MarketWorld.Application.Repositories;
using MarketWorld.Application.Services.Interfaces;
using MarketWorld.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Implementations
{
    public class BrandService : IBrandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BrandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Brand>> GetAllBrandsAsync()
        {
            var brands = await _unitOfWork.Brands.GetAllAsync();
            return brands.Where(b => !b.IsDeleted);
        }

        public async Task<Brand> GetBrandByIdAsync(int id)
        {
            return await _unitOfWork.Brands.GetByIdAsync(id);
        }

        public async Task<Brand> GetBrandWithProductsAsync(int id)
        {
            return await _unitOfWork.Brands.GetBrandWithProducts(id);
        }

        public async Task<Brand> CreateBrandAsync(Brand brand)
        {
            if (brand == null)
                throw new ArgumentNullException(nameof(brand));

            await _unitOfWork.Brands.AddAsync(brand);
            await _unitOfWork.SaveChangesAsync();
            return brand;
        }

        public async Task UpdateBrandAsync(Brand brand)
        {
            if (brand == null)
                throw new ArgumentNullException(nameof(brand));

            _unitOfWork.Brands.Update(brand);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteBrandAsync(int id)
        {
            var brand = await _unitOfWork.Brands.GetByIdAsync(id);
            if (brand != null)
            {
                _unitOfWork.Brands.Remove(brand);
                await _unitOfWork.SaveChangesAsync();
            }
        }

        public async Task<bool> IsBrandNameUniqueAsync(string name)
        {
            return await _unitOfWork.Brands.IsBrandNameUnique(name);
        }
    }
}