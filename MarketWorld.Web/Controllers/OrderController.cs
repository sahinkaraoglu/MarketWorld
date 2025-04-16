using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Data;
using MarketWorld.Domain.Entities;
using MarketWorld.Domain.Enums;
using System;
using System.Linq;
using System.Threading.Tasks;
using MarketWorld.Web.Attributes;

namespace MarketWorld.Web.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly MarketWorldDbContext _context;

        public OrderController(MarketWorldDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Checkout()
        {
            var userId = HttpContext.Items["UserId"].ToString();

            var cart = await _context.Carts
                .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null || !cart.CartItems.Any())
            {
                return RedirectToAction("Index", "Cart");
            }

            var userAddresses = await _context.Addresses
                .Where(a => a.UserId == userId)
                .ToListAsync();

            ViewBag.Addresses = userAddresses;
            
            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> ProcessOrder(int shippingAddressId, int billingAddressId, string paymentMethod, 
            string cardHolderName, string cardNumber, string expiryDate, string cvv)
        {
            var userId = HttpContext.Items["UserId"].ToString();

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
                UserId = userId,
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

            // Kredi kartı bilgilerini kaydetme (eğer kredi kartı ile ödeme yapılıyorsa)
            if (paymentMethod == "CreditCard" && !string.IsNullOrEmpty(cardNumber))
            {
                var creditCard = new CreditCard
                {
                    CardHolderName = cardHolderName,
                    CardNumber = cardNumber,
                    ExpiryDate = expiryDate,
                    CardType = DetermineCardType(cardNumber),
                    Cvv = cvv,
                    UserId = userId,
                    OrderId = order.Id,
                    IsDefault = false
                };

                _context.CreditCards.Add(creditCard);
            }

            // Ödeme işlemi (basitleştirilmiş)
            var payment = new Payment
            {
                OrderId = order.Id,
                PaymentDate = DateTime.Now,
                Amount = order.TotalAmount,
                PaymentMethod = paymentMethod,
                Status = PaymentStatus.Completed,
                TransactionId = GenerateTransactionId()
            };

            _context.Payments.Add(payment);
            order.Status = OrderStatus.Processing;
            
            await _context.SaveChangesAsync();

            return RedirectToAction("OrderConfirmation", new { orderId = order.Id });
        }

        public async Task<IActionResult> OrderConfirmation(int orderId)
        {
            var userId = HttpContext.Items["UserId"].ToString();

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
            var userId = HttpContext.Items["UserId"].ToString();

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
        
        private string GenerateTransactionId()
        {
            return "TRX-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + new Random().Next(1000, 9999).ToString();
        }
        
        private string DetermineCardType(string cardNumber)
        {
            // Boşlukları kaldır
            cardNumber = cardNumber.Replace(" ", "");
            
            // Visa kartları 4 ile başlar
            if (cardNumber.StartsWith("4"))
            {
                return "Visa";
            }
            // Mastercard kartları 51-55 aralığında başlar
            else if (cardNumber.StartsWith("51") || cardNumber.StartsWith("52") || 
                     cardNumber.StartsWith("53") || cardNumber.StartsWith("54") || 
                     cardNumber.StartsWith("55"))
            {
                return "MasterCard";
            }
            // American Express kartları 34 veya 37 ile başlar
            else if (cardNumber.StartsWith("34") || cardNumber.StartsWith("37"))
            {
                return "AmericanExpress";
            }
            // Discovery kartları 6011, 622126-622925, 644-649 veya 65 ile başlar
            else if (cardNumber.StartsWith("6011") || 
                     (cardNumber.Length >= 6 && int.TryParse(cardNumber.Substring(0, 6), out int prefix) && prefix >= 622126 && prefix <= 622925) ||
                     (cardNumber.StartsWith("64") && cardNumber.Length >= 3 && int.TryParse(cardNumber.Substring(0, 3), out int prefix3) && prefix3 >= 644 && prefix3 <= 649) ||
                     cardNumber.StartsWith("65"))
            {
                return "Discover";
            }
            else
            {
                return "Other";
            }
        }
    }
} 