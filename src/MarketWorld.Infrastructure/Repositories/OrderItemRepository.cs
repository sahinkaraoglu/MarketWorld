using MarketWorld.Application.Repositories;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketWorld.Infrastructure.Repositories
{
    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        private readonly MarketWorldDbContext _marketWorldContext;

        public OrderItemRepository(MarketWorldDbContext context) : base(context)
        {
            _marketWorldContext = context;
        }

        public async Task<IEnumerable<OrderItem>> GetOrderItemsWithDetailsAsync()
        {
            return await _marketWorldContext.OrderItems
                .Include(oi => oi.Order)
                .Include(oi => oi.Product)
                    .ThenInclude(p => p.Brand)
                .Include(oi => oi.Product)
                    .ThenInclude(p => p.Category)
                .ToListAsync();
        }

        public async Task<IEnumerable<OrderItem>> GetOrderItemsByOrderIdAsync(int orderId)
        {
            return await _marketWorldContext.OrderItems
                .Include(oi => oi.Product)
                    .ThenInclude(p => p.Brand)
                .Include(oi => oi.Product)
                    .ThenInclude(p => p.Category)
                .Where(oi => oi.OrderId == orderId)
                .ToListAsync();
        }

        public async Task<IEnumerable<dynamic>> GetTopSellingProductsAsync(int count)
        {
            return await _marketWorldContext.OrderItems
                .Include(oi => oi.Product)
                .GroupBy(oi => oi.ProductId)
                .Select(g => new
                {
                    ProductId = g.Key,
                    ProductName = g.First().Product.Name,
                    TotalQuantity = g.Sum(oi => oi.Quantity),
                    TotalRevenue = g.Sum(oi => oi.Product.Price * oi.Quantity)
                })
                .OrderByDescending(x => x.TotalQuantity)
                .Take(count)
                .ToListAsync();
        }

        public async Task<IEnumerable<dynamic>> GetTopSellingCategoriesAsync(int count)
        {
            return await _marketWorldContext.OrderItems
                .Include(oi => oi.Product)
                    .ThenInclude(p => p.SubCategory)
                        .ThenInclude(sc => sc.Category)
                .GroupBy(oi => oi.Product.SubCategory.CategoryId)
                .Select(g => new
                {
                    CategoryId = g.Key,
                    CategoryName = g.First().Product.SubCategory.Category.Name,
                    TotalQuantity = g.Sum(oi => oi.Quantity),
                    TotalRevenue = g.Sum(oi => oi.Product.Price * oi.Quantity)
                })
                .OrderByDescending(x => x.TotalQuantity)
                .Take(count)
                .ToListAsync();
        }
    }
} 