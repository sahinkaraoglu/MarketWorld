using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Data;
using MarketWorld.Domain.Entities;
using MarketWorld.Domain.Enums;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MarketWorld.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly MarketWorldDbContext _context;

        public OrderController(MarketWorldDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Checkout()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (!userId.HasValue)
            {
                return RedirectToAction("Index", "Login");
            }

            var cart = await _context.Carts
                .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null || !cart.CartItems.Any())
            {
                return RedirectToAction("Index", "Cart");
            }

            var user = await _context.Users
                .Include(u => u.Addresses)
                .FirstOrDefaultAsync(u => u.Id == userId);

            ViewBag.Addresses = user.Addresses;
            
            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> ProcessOrder(int shippingAddressId, int billingAddressId, string paymentMethod)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (!userId.HasValue)
            {
                return RedirectToAction("Index", "Login");
            }

            var cart = await _context.Carts
                .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null || !cart.CartItems.Any())
            {
                return RedirectToAction("Index", "Cart");
            }

            // Stok kontrolü
            foreach (var item in cart.CartItems)
            {
                var product = await _context.Products
                    .Include(p => p.ProductProperties)
                    .FirstOrDefaultAsync(p => p.Id == item.ProductId);
                    
                if (product != null && product.GetTotalStock() < item.Quantity)
                {
                    TempData["ErrorMessage"] = $"{item.Product.Name} için yeterli stok bulunmamaktadır.";
                    return RedirectToAction("Checkout");
                }
            }

            // Sipariş oluşturma
            var order = new Order
            {
                OrderNumber = GenerateOrderNumber(),
                OrderDate = DateTime.Now,
                Status = OrderStatus.Pending,
                TotalAmount = cart.TotalAmount,
                UserId = userId.Value,
                ShippingAddressId = shippingAddressId,
                BillingAddressId = billingAddressId,
                OrderItems = cart.CartItems.Select(ci => new OrderItem
                {
                    ProductId = ci.ProductId,
                    Quantity = ci.Quantity,
                    UnitPrice = ci.UnitPrice
                }).ToList()
            };

            _context.Orders.Add(order);

            // Stoklardan düşme
            foreach (var item in cart.CartItems)
            {
                var product = await _context.Products
                    .Include(p => p.ProductProperties)
                    .FirstOrDefaultAsync(p => p.Id == item.ProductId);
                
                if (product != null && product.ProductProperties != null && product.ProductProperties.Any())
                {
                    // İlgili renk vb. özelliklere göre stoğu azalt
                    // Bu örnek için ilk bulunan property'den azaltma yapıyoruz
                    var property = product.ProductProperties.FirstOrDefault(pp => pp.IsActive);
                    if (property != null)
                    {
                        property.Stock -= item.Quantity;
                        if (property.Stock < 0) property.Stock = 0;
                    }
                }
            }

            // Sepeti temizleme
            _context.CartItems.RemoveRange(cart.CartItems);
            cart.TotalAmount = 0;

            await _context.SaveChangesAsync();

            // Ödeme işlemi (basitleştirilmiş)
            var payment = new Payment
            {
                OrderId = order.Id,
                PaymentDate = DateTime.Now,
                Amount = order.TotalAmount,
                PaymentMethod = paymentMethod,
                Status = PaymentStatus.Completed
            };

            _context.Payments.Add(payment);
            order.Status = OrderStatus.Processing;
            
            await _context.SaveChangesAsync();

            return RedirectToAction("OrderConfirmation", new { orderId = order.Id });
        }

        public async Task<IActionResult> OrderConfirmation(int orderId)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (!userId.HasValue)
            {
                return RedirectToAction("Index", "Login");
            }

            var order = await _context.Orders
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Product)
                        .ThenInclude(p => p.Images)
                .Include(o => o.ShippingAddress)
                .FirstOrDefaultAsync(o => o.Id == orderId && o.UserId == userId);

            if (order == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(order);
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderDetails(int id)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (!userId.HasValue)
            {
                return Json(new { success = false, message = "Oturum bulunamadı." });
            }

            var order = await _context.Orders
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Product)
                        .ThenInclude(p => p.Images)
                .Include(o => o.ShippingAddress)
                .FirstOrDefaultAsync(o => o.Id == id && o.UserId == userId);

            if (order == null)
            {
                return Json(new { success = false, message = "Sipariş bulunamadı." });
            }

            return PartialView("_OrderDetails", order);
        }

        private string GenerateOrderNumber()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1000, 9999).ToString();
        }
    }
} 