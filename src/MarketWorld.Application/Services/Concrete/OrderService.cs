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

        public async Task<IEnumerable<Order>> GetAllOrdersAsync(int page = 1, int pageSize = 20)
        {
            var orders = await _unitOfWork.Orders.GetAllOrdersWithDetailsAsync();
            return orders.Skip((page - 1) * pageSize).Take(pageSize);
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

        public async Task<IEnumerable<Order>> GetOrdersByUserIdAsync(string userId)
        {
            return await _unitOfWork.Orders.GetUserOrdersAsync(userId);
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            return await GetOrderByIdAsync(id);
        }

        public async Task<Order> CreateOrderFromCartAsync(string userId, int shippingAddressId, string paymentMethod)
        {
            var cart = await _unitOfWork.Carts.GetCartByUserIdAsync(userId);
            if (cart == null || !cart.CartItems.Any())
                throw new ArgumentException("Sepet boş veya bulunamadı");

            var order = new Order
            {
                UserId = userId,
                OrderNumber = GenerateOrderNumber(),
                OrderDate = DateTime.UtcNow,
                Status = OrderStatus.Pending,
                TotalAmount = cart.CartItems.Sum(ci => ci.Quantity * ci.Product.Price),
                Note = "Sepetten oluşturulan sipariş",
                ShippingAddressId = shippingAddressId
            };

            // Cart items'ı order items'a çevir
            order.OrderItems = cart.CartItems.Select(ci => new OrderItem
            {
                ProductId = ci.ProductId,
                Quantity = ci.Quantity,
                UnitPrice = ci.Product.Price,
                TotalPrice = ci.Quantity * ci.Product.Price
            }).ToList();

            await _unitOfWork.Orders.AddAsync(order);
            
            // Payment entity'si oluştur
            var payment = new Payment
            {
                PaymentMethod = paymentMethod,
                Amount = order.TotalAmount,
                Status = PaymentStatus.Pending,
                PaymentDate = DateTime.UtcNow,
                TransactionId = GenerateTransactionId(),
                OrderId = order.Id
            };

            await _unitOfWork.SaveChangesAsync();
            
            // Sepeti temizle
            _unitOfWork.Carts.Remove(cart);
            
            await _unitOfWork.SaveChangesAsync();
            return order;
        }

        public async Task<Order> CancelOrderAsync(int orderId, string userId)
        {
            var order = await _unitOfWork.Orders.GetByIdAsync(orderId);
            if (order == null)
                throw new ArgumentException($"Sipariş bulunamadı. ID: {orderId}");

            if (order.UserId != userId)
                throw new UnauthorizedAccessException("Bu siparişi iptal etme yetkiniz yok");

            if (order.Status == OrderStatus.Shipped || order.Status == OrderStatus.Delivered)
                throw new InvalidOperationException("Kargoya verilmiş veya teslim edilmiş siparişler iptal edilemez");

            order.Status = OrderStatus.Cancelled;
            order.UpdatedDate = DateTime.UtcNow;

            _unitOfWork.Orders.Update(order);
            await _unitOfWork.SaveChangesAsync();
            
            return order;
        }

        private string GenerateOrderNumber()
        {
            return $"ORD-{DateTime.Now:yyyyMMdd}-{new Random().Next(1000, 9999)}";
        }

        private string GenerateTransactionId()
        {
            return $"TXN-{DateTime.Now:yyyyMMddHHmmss}-{new Random().Next(1000, 9999)}";
        }
    }
} 