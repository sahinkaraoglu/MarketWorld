using MarketWorld.Application.Repositories;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MarketWorld.Infrastructure.Repositories
{
    public class CartItemRepository : Repository<CartItem>, ICartItemRepository
    {
        private readonly MarketWorldDbContext _marketWorldContext;

        public CartItemRepository(MarketWorldDbContext context) : base(context)
        {
            _marketWorldContext = context;
        }

        public override async Task<IEnumerable<CartItem>> FindAsync(Expression<Func<CartItem, bool>> predicate)
        {
            return await _marketWorldContext.CartItems
                .Include(ci => ci.Product)
                    .ThenInclude(p => p.Images)
                .Include(ci => ci.Product)
                    .ThenInclude(p => p.ProductProperties)
                .Where(predicate)
                .ToListAsync();
        }
    }
} 