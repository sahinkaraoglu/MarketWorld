using MarketWorld.Application.Repositories;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketWorld.Infrastructure.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        private readonly MarketWorldDbContext _marketWorldDbContext;

        public AddressRepository(MarketWorldDbContext context) : base(context)
        {
            _marketWorldDbContext = context;
        }

        public async Task<IEnumerable<Address>> GetUserAddressesAsync(string userId)
        {
            return await _marketWorldDbContext.Addresses
                .Where(a => a.UserId == userId)
                .ToListAsync();
        }

        public async Task<Address> GetUserAddressByIdAsync(int id, string userId)
        {
            return await _marketWorldDbContext.Addresses
                .Include(a => a.User)
                .FirstOrDefaultAsync(a => a.Id == id && a.UserId == userId);
        }
    }
} 