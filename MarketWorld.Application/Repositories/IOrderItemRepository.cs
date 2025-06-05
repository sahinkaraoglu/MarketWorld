using MarketWorld.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Repositories
{
    public interface IOrderItemRepository : IRepository<OrderItem>
    {
        Task<IEnumerable<OrderItem>> GetOrderItemsWithDetailsAsync();
        Task<IEnumerable<OrderItem>> GetOrderItemsByOrderIdAsync(int orderId);
        Task<IEnumerable<dynamic>> GetTopSellingProductsAsync(int count);
        Task<IEnumerable<dynamic>> GetTopSellingCategoriesAsync(int count);
    }
} 