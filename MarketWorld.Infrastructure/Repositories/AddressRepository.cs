using MarketWorld.Application.Repositories;
using MarketWorld.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketWorld.Infrastructure.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(DbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Address>> GetUserAddressesAsync(string userId)
        {
            return await _dbSet
                .Where(a => a.UserId == userId)
                .ToListAsync();
        }

        public async Task<Address> GetUserAddressByIdAsync(int id, string userId)
        {
            return await _dbSet
                .FirstOrDefaultAsync(a => a.Id == id && a.UserId == userId);
        }
    }
} 