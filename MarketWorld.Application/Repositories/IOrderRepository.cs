using MarketWorld.Core.Domain.Entities;
using MarketWorld.Core.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<IEnumerable<Order>> GetAllOrdersWithDetailsAsync();
        Task<IEnumerable<Order>> GetOrdersByStatusAsync(OrderStatus status);
        Task<Order> GetOrderWithDetailsAsync(int id);
    }
} 