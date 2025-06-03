using MarketWorld.Application.Repositories;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Infrastructure.Repositories
{
    public class PropertyValueRepository : Repository<PropertyValue>, IPropertyValueRepository
    {
        private readonly MarketWorldDbContext _marketWorldContext;

        public PropertyValueRepository(MarketWorldDbContext context) : base(context)
        {
            _marketWorldContext = context;
        }

        public async Task<bool> IsPropertyValueUnique(string value, int propertyTypeId)
        {
            return !await _marketWorldContext.PropertyValues
                .AnyAsync(pv => pv.Value.ToLower() == value.ToLower() && pv.PropertyTypeId == propertyTypeId);
        }

        public async Task<IEnumerable<PropertyValue>> GetPropertyValuesByTypeId(int propertyTypeId)
        {
            return await _marketWorldContext.PropertyValues
                .Where(pv => pv.PropertyTypeId == propertyTypeId)
                .ToListAsync();
        }
    }
} 