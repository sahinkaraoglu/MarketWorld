using MarketWorld.Application.Repositories;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MarketWorld.Infrastructure.Repositories
{
    public class PropertyTypeRepository : Repository<PropertyType>, IPropertyTypeRepository
    {
        private readonly MarketWorldDbContext _marketWorldContext;

        public PropertyTypeRepository(MarketWorldDbContext context) : base(context)
        {
            _marketWorldContext = context;
        }

        public async Task<bool> IsPropertyTypeNameUnique(string name)
        {
            return !await _marketWorldContext.PropertyTypes
                .AnyAsync(pt => pt.Name.ToLower() == name.ToLower());
        }
    }
} 