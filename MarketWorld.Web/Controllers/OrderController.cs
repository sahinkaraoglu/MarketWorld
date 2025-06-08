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
        private readonly IAccountService _accountService;

        public OrderController(
            IOrderService orderService,
            ICartService cartService,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IAccountService accountService)
        {
            _orderService = orderService;
            _cartService = cartService;
            _userManager = userManager;
            _roleManager = roleManager;
            _accountService = accountService;
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
        public async Task<IActionResult> Checkout()
        {
            try
            {
                // Kullanıcının sepetini kontrol et
                var userId = HttpContext.Items["UserId"]?.ToString();
                if (string.IsNullOrEmpty(userId))
                {
                    return RedirectToAction("Login", "Account");
                }

                // Sepet bilgilerini getir
                var cartItems = await _cartService.GetCartItemsAsync(userId);
                if (cartItems == null || !cartItems.Any())
                {
                    return RedirectToAction("Index", "Cart");
                }

                // Sipariş özeti için gerekli bilgileri hazırla
                ViewBag.CartItems = cartItems;
                ViewBag.TotalAmount = await _cartService.GetCartTotalAsync(userId);
                ViewBag.User = await _userManager.FindByIdAsync(userId);
                ViewBag.UserAddresses = await _accountService.GetUserAddressesAsync(userId);

                return View();
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(Order order)
        {
            try
            {
                var userId = HttpContext.Items["UserId"]?.ToString();
                if (string.IsNullOrEmpty(userId))
                {
                    return RedirectToAction("Login", "Account");
                }

                // Sepet bilgilerini getir
                var cartItems = await _cartService.GetCartItemsAsync(userId);
                if (cartItems == null || !cartItems.Any())
                {
                    TempData["OrderError"] = "Sepetinizde ürün yok!";
                    return RedirectToAction("Checkout");
                }

                if (order.ShippingAddressId == null)
                {
                    TempData["OrderError"] = "Teslimat adresi seçilmedi!";
                    return RedirectToAction("Checkout");
                }

                var shippingAddress = await _accountService.GetAddressByIdAsync(order.ShippingAddressId.Value, userId);
                if (shippingAddress == null)
                {
                    TempData["OrderError"] = "Seçili teslimat adresi bulunamadı!";
                    return RedirectToAction("Checkout");
                }

                // Sipariş numarası üret
                var random = new Random();
                string orderNumber = DateTime.Now.ToString("yyMMdd") + random.Next(10, 99).ToString();

                // Yeni sipariş oluştur
                var newOrder = new Order
                {
                    UserId = userId,
                    OrderDate = DateTime.Now,
                    Status = OrderStatus.Pending,
                    TotalAmount = await _cartService.GetCartTotalAsync(userId),
                    ShippingAddressId = shippingAddress.Id,
                    ShippingAddress = shippingAddress,
                    OrderNumber = orderNumber,
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
                await _cartService.ClearCartAsync(userId);

                // Başarılı sipariş sayfasına yönlendir
                return RedirectToAction("OrderConfirmation", new { orderId = newOrder.Id });
            }
            catch (Exception ex)
            {
                TempData["OrderError"] = ex.ToString();
                return RedirectToAction("Checkout");
            }
        }

        [HttpGet]
        public async Task<IActionResult> OrderConfirmation(int orderId)
        {
            try
            {
                var order = await _orderService.GetOrderWithDetailsAsync(orderId);
                if (order == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                if (order.ShippingAddressId == null)
                    throw new Exception("ShippingAddressId null geliyor!");

                return View(order);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}