using MarketWorld.Application.Repositories;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;

namespace MarketWorld.Infrastructure.Repositories
{
    public class CartItemRepository : Repository<CartItem>, ICartItemRepository
    {
        public CartItemRepository(MarketWorldDbContext context) : base(context)
        {
        }
    }
} 