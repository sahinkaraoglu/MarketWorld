using MarketWorld.Core.Domain.Entities;
using MarketWorld.Core.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllOrdersAsync();
        Task<IEnumerable<Order>> GetOrdersByStatusAsync(OrderStatus? status);
        Task<Order> GetOrderByIdAsync(int id);
        Task<Order> GetOrderWithDetailsAsync(int id);
        Task<Order> UpdateOrderStatusAsync(int orderId, OrderStatus status);
        Task<Order> CreateOrderAsync(Order order);
        Task<Order> UpdateOrderAsync(Order order);
        Task DeleteOrderAsync(int id);
    }
} 