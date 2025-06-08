using MarketWorld.Application.Repositories;
using MarketWorld.Application.Services.Interfaces;
using MarketWorld.Core.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace MarketWorld.Application.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<AccountService> _logger;

        public AccountService(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager, ILogger<AccountService> logger)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _logger = logger;
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
                _logger.LogInformation($"Adding new address. Address details: {JsonSerializer.Serialize(address)}");

                // Varsayılan değerleri kontrol et
                if (string.IsNullOrEmpty(address.PostalCode))
                {
                    address.PostalCode = "34000";
                }

                if (string.IsNullOrEmpty(address.Country))
                {
                    address.Country = "Türkiye";
                }

                // Eğer bu adres varsayılan olarak işaretlendiyse, diğer adreslerin varsayılan işaretini kaldır
                if (address.IsDefault)
                {
                    var existingAddresses = await _unitOfWork.Addresses.GetUserAddressesAsync(address.UserId);
                    foreach (var existingAddress in existingAddresses)
                    {
                        if (existingAddress.IsDefault)
                        {
                            existingAddress.IsDefault = false;
                            await _unitOfWork.SaveChangesAsync();
                            _logger.LogInformation($"Removed default flag from existing address. AddressId: {existingAddress.Id}");
                        }
                    }
                }

                // Adres ekle
                await _unitOfWork.Addresses.AddAsync(address);
                var result = await _unitOfWork.SaveChangesAsync();

                if (result > 0)
                {
                    _logger.LogInformation($"Address added successfully. AddressId: {address.Id}");
                    return true;
                }
                else
                {
                    _logger.LogWarning("Failed to save address changes to database");
                    return false;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error adding new address. UserId: {address.UserId}");
                throw;
            }
        }

        public async Task<bool> UpdateAddressAsync(Address address)
        {
            try
            {
                var existingAddress = await _unitOfWork.Addresses.GetUserAddressByIdAsync(address.Id, address.UserId);
                if (existingAddress == null)
                {
                    _logger.LogWarning($"Address not found. AddressId: {address.Id}, UserId: {address.UserId}");
                    return false;
                }

                existingAddress.FullName = address.FullName;
                existingAddress.Title = address.Title;
                existingAddress.FullAddress = address.FullAddress;
                existingAddress.City = address.City;
                existingAddress.District = address.District;
                existingAddress.Phone = address.Phone;
                existingAddress.PostalCode = address.PostalCode;
                existingAddress.Country = address.Country;
                existingAddress.AddressType = address.AddressType;
                existingAddress.IsDefault = address.IsDefault;
                existingAddress.UpdatedDate = DateTime.Now;

                await _unitOfWork.SaveChangesAsync();
                _logger.LogInformation($"Address updated successfully. AddressId: {address.Id}");
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error updating address. AddressId: {address.Id}");
                throw;
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