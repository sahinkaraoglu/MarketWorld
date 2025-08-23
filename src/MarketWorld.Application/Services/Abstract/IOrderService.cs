using MarketWorld.Core.Domain.Entities;
using MarketWorld.Core.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Abstract
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllOrdersAsync(int page = 1, int pageSize = 20);
        Task<Order> GetOrderByIdAsync(int id);
        Task<Order> GetByIdAsync(int id);
        Task<Order> GetOrderWithDetailsAsync(int id);
        Task<Order> CreateOrderAsync(Order order);
        Task<Order> CreateOrderFromCartAsync(string userId, int shippingAddressId, string paymentMethod);
        Task UpdateOrderAsync(Order order);
        Task DeleteOrderAsync(int id);
        Task<Order> CancelOrderAsync(int orderId, string userId);
        Task<IEnumerable<Brand>> GetTopSellingBrandsAsync(int count);
        Task<IEnumerable<Order>> GetOrdersByStatusAsync(OrderStatus? status);
        Task<Order> UpdateOrderStatusAsync(int orderId, OrderStatus status, string note = null);
        Task<IEnumerable<Order>> GetUserOrdersAsync(string userId);
        Task<IEnumerable<Order>> GetOrdersByUserIdAsync(string userId);
    }
} 