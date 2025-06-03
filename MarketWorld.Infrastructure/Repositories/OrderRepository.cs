using MarketWorld.Application.Repositories;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Core.Enums;
using MarketWorld.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketWorld.Infrastructure.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly MarketWorldDbContext _marketWorldContext;

        public OrderRepository(MarketWorldDbContext context) : base(context)
        {
            _marketWorldContext = context;
        }

        public async Task<IEnumerable<Order>> GetAllOrdersWithDetailsAsync()
        {
            return await _marketWorldContext.Orders
                .Include(o => o.User)
                .Include(o => o.OrderItems)
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<Order>> GetOrdersByStatusAsync(OrderStatus status)
        {
            return await _marketWorldContext.Orders
                .Include(o => o.User)
                .Include(o => o.OrderItems)
                .Where(o => o.Status == status)
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();
        }

        public async Task<Order> GetOrderWithDetailsAsync(int id)
        {
            return await _marketWorldContext.Orders
                .Include(o => o.User)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Product)
                .Include(o => o.ShippingAddress)
                .Include(o => o.BillingAddress)
                .FirstOrDefaultAsync(o => o.Id == id);
        }
    }
} 