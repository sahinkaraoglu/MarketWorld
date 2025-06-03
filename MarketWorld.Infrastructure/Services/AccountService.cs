using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Core.Interfaces.Services;
using MarketWorld.Infrastructure.Context;

namespace MarketWorld.Infrastructure.Services
{
    public class AccountService : IAccountService
    {
        private readonly MarketWorldDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountService(MarketWorldDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<ApplicationUser> GetUserByIdAsync(string userId)
        {
            return await _userManager.FindByIdAsync(userId);
        }

        public async Task<List<Address>> GetUserAddressesAsync(string userId)
        {
            return await _context.Addresses
                .Where(a => a.UserId == userId)
                .ToListAsync();
        }

        public async Task<Address> GetAddressByIdAsync(int id, string userId)
        {
            return await _context.Addresses
                .FirstOrDefaultAsync(a => a.Id == id && a.UserId == userId);
        }

        public async Task<bool> AddAddressAsync(Address address)
        {
            try
            {
                _context.Addresses.Add(address);
                await _context.SaveChangesAsync();
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
                var existingAddress = await _context.Addresses
                    .FirstOrDefaultAsync(a => a.Id == address.Id && a.UserId == address.UserId);

                if (existingAddress == null)
                    return false;

                existingAddress.Title = address.Title;
                existingAddress.FullAddress = address.FullAddress;
                existingAddress.City = address.City;
                existingAddress.District = address.District;
                existingAddress.Phone = address.Phone;

                await _context.SaveChangesAsync();
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
                var address = await _context.Addresses
                    .FirstOrDefaultAsync(a => a.Id == id && a.UserId == userId);

                if (address == null)
                    return false;

                _context.Addresses.Remove(address);
                await _context.SaveChangesAsync();
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