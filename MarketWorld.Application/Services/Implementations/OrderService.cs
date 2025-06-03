using MarketWorld.Application.Repositories;
using MarketWorld.Application.Services.Interfaces;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Core.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Implementations
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

        public async Task<Order> UpdateOrderStatusAsync(int orderId, OrderStatus status)
        {
            var order = await GetOrderByIdAsync(orderId);
            order.Status = status;
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

        public async Task<Order> UpdateOrderAsync(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            var existingOrder = await GetOrderByIdAsync(order.Id);
            order.UpdatedDate = DateTime.Now;

            _unitOfWork.Orders.Update(order);
            await _unitOfWork.SaveChangesAsync();

            return order;
        }

        public async Task DeleteOrderAsync(int id)
        {
            var order = await GetOrderByIdAsync(id);
            _unitOfWork.Orders.Remove(order);
            await _unitOfWork.SaveChangesAsync();
        }
    }
} 