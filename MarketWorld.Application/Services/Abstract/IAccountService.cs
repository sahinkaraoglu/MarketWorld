using System.Threading.Tasks;
using System.Collections.Generic;
using MarketWorld.Core.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace MarketWorld.Application.Services.Abstract
{
    public interface IAccountService
    {
        Task<ApplicationUser> GetUserByIdAsync(string userId);
        Task<List<Address>> GetUserAddressesAsync(string userId);
        Task<Address> GetAddressByIdAsync(int id, string userId);
        Task<bool> AddAddressAsync(Address address);
        Task<bool> UpdateAddressAsync(Address address);
        Task<bool> DeleteAddressAsync(int id, string userId);
        Task<bool> UpdateUserAsync(ApplicationUser user);
    }
} 