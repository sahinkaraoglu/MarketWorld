using MarketWorld.Application.Repositories;
using MarketWorld.Application.Services.Abstract;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await _unitOfWork.Orders.GetAllOrdersWithDetailsAsync();
        }

        public async Task<IEnumerable<Order>> GetOrdersByStatusAsync(OrderStatus? status)
        {
            if (status.HasValue)
            {
                return await _unitOfWork.Orders.GetOrdersByStatusAsync(status.Value);
            }
            return await GetAllOrdersAsync();
        }

        public async Task<Order> GetOrderByIdAsync(int id)
        {
            var order = await _unitOfWork.Orders.GetByIdAsync(id);
            if (order == null)
                throw new ArgumentException($"Sipariş bulunamadı. ID: {id}");

            return order;
        }

        public async Task<Order> GetOrderWithDetailsAsync(int id)
        {
            var order = await _unitOfWork.Orders.GetOrderWithDetailsAsync(id);
            if (order == null)
                throw new ArgumentException($"Sipariş bulunamadı. ID: {id}");

            return order;
        }

        public async Task<Order> UpdateOrderStatusAsync(int orderId, OrderStatus status, string note = null)
        {
            var order = await GetOrderByIdAsync(orderId);
            order.Status = status;
            order.Note = note;
            order.UpdatedDate = DateTime.Now;

            _unitOfWork.Orders.Update(order);
            await _unitOfWork.SaveChangesAsync();

            return order;
        }

        public async Task<Order> CreateOrderAsync(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            order.CreatedDate = DateTime.Now;
            await _unitOfWork.Orders.AddAsync(order);
            await _unitOfWork.SaveChangesAsync();

            return order;
        }

        public async Task UpdateOrderAsync(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            var existingOrder = await GetOrderByIdAsync(order.Id);
            order.UpdatedDate = DateTime.Now;

            _unitOfWork.Orders.Update(order);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteOrderAsync(int id)
        {
            var order = await GetOrderByIdAsync(id);
            _unitOfWork.Orders.Remove(order);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<Brand>> GetTopSellingBrandsAsync(int count)
        {
            var orders = await _unitOfWork.Orders.GetAllOrdersWithDetailsAsync();
            
            var topBrands = orders
                .SelectMany(o => o.OrderItems)
                .Where(oi => oi.Product?.Brand != null)
                .GroupBy(oi => oi.Product.Brand)
                .OrderByDescending(g => g.Count())
                .Take(count)
                .Select(g => g.Key);

            return topBrands;
        }

        public async Task<IEnumerable<Order>> GetOrdersByStatusAsync(string status)
        {
            if (Enum.TryParse<OrderStatus>(status, out var orderStatus))
            {
                return await _unitOfWork.Orders.GetOrdersByStatusAsync(orderStatus);
            }
            return await GetAllOrdersAsync();
        }

        public async Task<IEnumerable<Order>> GetUserOrdersAsync(string userId)
        {
            return await _unitOfWork.Orders.GetUserOrdersAsync(userId);
        }
    }
} 