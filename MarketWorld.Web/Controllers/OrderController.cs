using MarketWorld.Core.Domain.Entities;
using MarketWorld.Core.Enums;
using MarketWorld.Web.Attributes;
using MarketWorld.Application.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MarketWorld.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly ICartService _cartService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public OrderController(
            IOrderService orderService,
            ICartService cartService,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _orderService = orderService;
            _cartService = cartService;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            // Sipariş istatistikleri
            var orders = await _orderService.GetAllOrdersAsync();

            // Debug için sipariş detaylarını kontrol et
            foreach (var order in orders)
            {
                System.Diagnostics.Debug.WriteLine($"Sipariş ID: {order.Id}, Durum: {order.Status}, Tarih: {order.CreatedDate}");
            }

            // Sipariş sayılarını yeniden hesapla
            ViewBag.NewOrdersCount = orders.Count();
            ViewBag.ShippingOrdersCount = orders.Count(o => o.Status == OrderStatus.Shipped);

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
                var orders = await _orderService.GetOrdersByStatusAsync(status.HasValue ? (OrderStatus)status.Value : null);
                return View("Order/Index", orders);
            }
            catch (Exception ex)
            {
                return View("Order/Index", new List<Order>());
            }
        }

        [HttpGet]
        [Route("GetOrderStatus/{id}")]
        public async Task<IActionResult> GetOrderStatus(int id)
        {
            try
            {
                var order = await _orderService.GetOrderByIdAsync(id);
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
                var order = await _orderService.UpdateOrderStatusAsync(orderId, (OrderStatus)status);
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
                var order = await _orderService.GetOrderWithDetailsAsync(id);
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
                var cartItems = await _cartService.GetCartItemsAsync(currentUser.Id);
                if (cartItems == null || !cartItems.Any())
                {
                    return RedirectToAction("Index", "Cart");
                }

                // Sipariş özeti için gerekli bilgileri hazırla
                ViewBag.CartItems = cartItems;
                ViewBag.TotalAmount = await _cartService.GetCartTotalAsync(currentUser.Id);
                ViewBag.User = currentUser;

                return View();
            }
            catch (Exception ex)
            {
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
                var cartItems = await _cartService.GetCartItemsAsync(currentUser.Id);
                if (cartItems == null || !cartItems.Any())
                {
                    return RedirectToAction("Index", "Cart");
                }

                // Yeni sipariş oluştur
                var newOrder = new Order
                {
                    UserId = currentUser.Id,
                    OrderDate = DateTime.Now,
                    Status = OrderStatus.Pending,
                    TotalAmount = await _cartService.GetCartTotalAsync(currentUser.Id),
                    ShippingAddress = order.ShippingAddress,
                    BillingAddress = order.BillingAddress,
                    OrderItems = cartItems.Select(ci => new OrderItem
                    {
                        ProductId = ci.ProductId,
                        Quantity = ci.Quantity,
                        UnitPrice = ci.Product.Price
                    }).ToList()
                };

                // Siparişi kaydet
                await _orderService.CreateOrderAsync(newOrder);

                // Sepeti temizle
                await _cartService.ClearCartAsync(currentUser.Id);

                // Başarılı sipariş sayfasına yönlendir
                return RedirectToAction("OrderConfirmation", new { id = newOrder.Id });
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet]
        [Route("OrderConfirmation/{id}")]
        public async Task<IActionResult> OrderConfirmation(int id)
        {
            try
            {
                var order = await _orderService.GetOrderWithDetailsAsync(id);
                if (order == null)
                {
                    return RedirectToAction("Index", "Home");
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