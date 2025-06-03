using MarketWorld.Core.Domain.Entities;
using MarketWorld.Core.Enums;
using MarketWorld.Infrastructure.Context;
using MarketWorld.Web.Attributes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MarketWorld.Web.Controllers
{

    public class OrderController : Controller
    {
        private readonly MarketWorldDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public OrderController(
            MarketWorldDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }


        public async Task<IActionResult> Index()
        {
            // Sipariş istatistikleri
            var orders = await _context.Orders.ToListAsync();

            // Debug için sipariş detaylarını kontrol et
            foreach (var order in orders)
            {
                System.Diagnostics.Debug.WriteLine($"Sipariş ID: {order.Id}, Durum: {order.Status}, Tarih: {order.CreatedDate}");
            }

            // Sipariş sayılarını yeniden hesapla
            ViewBag.NewOrdersCount = orders.Count;
            ViewBag.ShippingOrdersCount = orders.Count(o => o.Status == Core.Enums.OrderStatus.Shipped);

            // Gelir istatistikleri
            var monthlyOrders = orders.Where(o => o.CreatedDate >= DateTime.Now.AddMonths(-1));
            var monthlyRevenue = monthlyOrders.Sum(o => o.TotalAmount);
            ViewBag.MonthlyRevenue = monthlyRevenue.ToString("0.#K");
            ViewBag.MonthlyOrdersCount = monthlyOrders.Count();

            // Günlük istatistikler
            var todayOrders = orders.Where(o => o.CreatedDate == DateTime.Today);
            var todayRevenue = todayOrders.Sum(o => o.TotalAmount);
            ViewBag.TodayRevenue = todayRevenue.ToString("0.#K");

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Orders(int? status = null)
        {
            try
            {
                var query = _context.Orders
                    .Include(o => o.User)
                    .Include(o => o.OrderItems)
                    .AsQueryable();

                // Durum filtresini uygula
                if (status.HasValue)
                {
                    query = query.Where(o => (int)o.Status == status.Value);
                }

                var orders = await query
                    .OrderByDescending(o => o.OrderDate)
                    .ToListAsync();

                return View("Order/Index", orders);
            }
            catch (Exception ex)
            {
                // Hata durumunda boş liste gönderiyoruz, böylece sayfa hata vermeden açılır
                return View("Order/Index", new List<Order>());
            }
        }

        [HttpGet]
        [Route("GetOrderStatus/{id}")]
        public async Task<IActionResult> GetOrderStatus(int id)
        {
            try
            {
                var order = await _context.Orders.FindAsync(id);
                if (order == null)
                {
                    return Json(new { success = false, message = "Sipariş bulunamadı" });
                }

                return Json(new { success = true, status = (int)order.Status });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        [Route("UpdateOrderStatus")]
        public async Task<IActionResult> UpdateOrderStatus(int orderId, int status, string note)
        {
            try
            {
                var order = await _context.Orders.FindAsync(orderId);
                if (order == null)
                {
                    return Json(new { success = false, message = "Sipariş bulunamadı" });
                }

                order.Status = (Core.Enums.OrderStatus)status;
                // Not işleme eklenebilir

                await _context.SaveChangesAsync();

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpGet]
        [Route("PrintOrder/{id}")]
        public async Task<IActionResult> PrintOrder(int id)
        {
            try
            {
                var order = await _context.Orders
                    .Include(o => o.User)
                    .Include(o => o.OrderItems)
                        .ThenInclude(oi => oi.Product)
                    .Include(o => o.ShippingAddress)
                    .Include(o => o.BillingAddress)
                    .FirstOrDefaultAsync(o => o.Id == id);

                if (order == null)
                {
                    return NotFound();
                }

                return View("PrintOrder", order);
            }
            catch (Exception ex)
            {
                return View("Error", ex.Message);
            }
        }

        [HttpGet]
        [Route("Order/Checkout")]
        public async Task<IActionResult> Checkout()
        {
            try
            {
                // Kullanıcının sepetini kontrol et
                var currentUser = await _userManager.GetUserAsync(User);
                if (currentUser == null)
                {
                    return RedirectToAction("Login", "Account");
                }

                // Sepet bilgilerini getir
                var cart = await _context.Carts
                    .Include(c => c.CartItems)
                        .ThenInclude(ci => ci.Product)
                    .FirstOrDefaultAsync(c => c.UserId == currentUser.Id);

                if (cart == null || !cart.CartItems.Any())
                {
                    return RedirectToAction("Index", "Cart");
                }

                // Sipariş özeti için gerekli bilgileri hazırla
                ViewBag.CartItems = cart.CartItems;
                ViewBag.TotalAmount = cart.CartItems.Sum(ci => ci.Quantity * ci.Product.Price);
                ViewBag.User = currentUser;

                return View();
            }
            catch (Exception ex)
            {
                // Hata durumunda ana sayfaya yönlendir
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        [Route("Checkout")]
        public async Task<IActionResult> Checkout(Order order)
        {
            try
            {
                var currentUser = await _userManager.GetUserAsync(User);
                if (currentUser == null)
                {
                    return RedirectToAction("Login", "Account");
                }

                // Sepet bilgilerini getir
                var cart = await _context.Carts
                    .Include(c => c.CartItems)
                        .ThenInclude(ci => ci.Product)
                    .FirstOrDefaultAsync(c => c.UserId == currentUser.Id);

                if (cart == null || !cart.CartItems.Any())
                {
                    return RedirectToAction("Index", "Cart");
                }

                // Yeni sipariş oluştur
                var newOrder = new Order
                {
                    UserId = currentUser.Id,
                    OrderDate = DateTime.Now,
                    Status = Core.Enums.OrderStatus.Pending,
                    TotalAmount = cart.CartItems.Sum(ci => ci.Quantity * ci.Product.Price),
                    ShippingAddress = order.ShippingAddress,
                    BillingAddress = order.BillingAddress,
                    OrderItems = cart.CartItems.Select(ci => new OrderItem
                    {
                        ProductId = ci.ProductId,
                        Quantity = ci.Quantity,
                        UnitPrice = ci.Product.Price
                    }).ToList()
                };

                // Siparişi kaydet
                _context.Orders.Add(newOrder);

                // Sepeti temizle
                _context.CartItems.RemoveRange(cart.CartItems);
                await _context.SaveChangesAsync();

                // Başarılı sipariş sayfasına yönlendir
                return RedirectToAction("OrderConfirmation", new { id = newOrder.Id });
            }
            catch (Exception ex)
            {
                // Hata durumunda checkout sayfasına geri dön
                ModelState.AddModelError("", "Sipariş oluşturulurken bir hata oluştu.");
                return View(order);
            }
        }

        [HttpGet]
        [Route("OrderConfirmation/{id}")]
        public async Task<IActionResult> OrderConfirmation(int id)
        {
            try
            {
                var order = await _context.Orders
                    .Include(o => o.OrderItems)
                        .ThenInclude(oi => oi.Product)
                    .FirstOrDefaultAsync(o => o.Id == id);

                if (order == null)
                {
                    return NotFound();
                }

                return View(order);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}