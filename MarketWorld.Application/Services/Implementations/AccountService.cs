using MarketWorld.Application.Repositories;
using MarketWorld.Application.Services.Interfaces;
using MarketWorld.Core.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountService(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        public async Task<ApplicationUser> GetUserByIdAsync(string userId)
        {
            return await _userManager.FindByIdAsync(userId);
        }

        public async Task<List<Address>> GetUserAddressesAsync(string userId)
        {
            var addresses = await _unitOfWork.Addresses.GetUserAddressesAsync(userId);
            return addresses.ToList();
        }

        public async Task<Address> GetAddressByIdAsync(int id, string userId)
        {
            return await _unitOfWork.Addresses.GetUserAddressByIdAsync(id, userId);
        }

        public async Task<bool> AddAddressAsync(Address address)
        {
            try
            {
                await _unitOfWork.Addresses.AddAsync(address);
                await _unitOfWork.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateAddressAsync(Address address)
        {
            try
            {
                var existingAddress = await _unitOfWork.Addresses.GetUserAddressByIdAsync(address.Id, address.UserId);

                if (existingAddress == null)
                    return false;

                existingAddress.Title = address.Title;
                existingAddress.FullAddress = address.FullAddress;
                existingAddress.City = address.City;
                existingAddress.District = address.District;
                existingAddress.Phone = address.Phone;

                await _unitOfWork.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteAddressAsync(int id, string userId)
        {
            try
            {
                var address = await _unitOfWork.Addresses.GetUserAddressByIdAsync(id, userId);

                if (address == null)
                    return false;

                _unitOfWork.Addresses.Remove(address);
                await _unitOfWork.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateUserAsync(ApplicationUser user)
        {
            try
            {
                var result = await _userManager.UpdateAsync(user);
                return result.Succeeded;
            }
            catch
            {
                return false;
            }
        }
    }
} 