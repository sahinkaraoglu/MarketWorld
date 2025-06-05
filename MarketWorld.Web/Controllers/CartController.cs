using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Web.Attributes;
using MarketWorld.Application.Services.Interfaces;

namespace MarketWorld.Web.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly IAccountService _accountService;

        public CartController(ICartService cartService, IAccountService accountService)
        {
            _cartService = cartService;
            _accountService = accountService;
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId, int quantity = 1, string color = null)
        {
            try 
            {
                var userId = HttpContext.Items["UserId"]?.ToString();
                if (string.IsNullOrEmpty(userId))
                {
                    return Json(new { success = false, message = "Lütfen önce giriş yapın." });
                }

                if (string.IsNullOrEmpty(color))
                {
                    return Json(new { success = false, message = "Lütfen bir renk seçiniz." });
                }

                var cartItem = new CartItem
                {
                    ProductId = productId,
                    Quantity = quantity,
                    Color = color,
                    UserId = userId
                };

                var result = await _cartService.AddToCartAsync(cartItem);
                if (!result)
                {
                    return Json(new { success = false, message = "Ürün sepete eklenirken bir hata oluştu." });
                }

                var cartItems = await _cartService.GetCartItemsAsync(userId);
                var count = cartItems.Sum(ci => ci.Quantity);
                return Json(new { success = true, message = "Ürün sepete eklendi.", count });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = $"Sepete eklerken bir hata oluştu: {ex.Message}. Lütfen daha sonra tekrar deneyin." });
            }
        }

        public async Task<IActionResult> Index()
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Index", "Login");
            }

            var cartItems = await _cartService.GetCartItemsAsync(userId);
            var user = await _accountService.GetUserByIdAsync(userId);
            var addresses = await _accountService.GetUserAddressesAsync(userId);
            
            var cart = new Cart
            {
                UserId = userId,
                CartItems = cartItems,
                TotalAmount = await _cartService.GetCartTotalAsync(userId)
            };
            
            ViewBag.UserAddresses = addresses ?? new List<Address>();
            ViewBag.UserProfile = user;

            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQuantity(int cartItemId, int quantity)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            var cartItem = await _cartService.GetCartItemByIdAsync(cartItemId, userId);

            if (cartItem == null)
            {
                return Json(new { success = false, message = "Sepet öğesi bulunamadı." });
            }

            cartItem.Quantity = quantity;
            cartItem.UserId = userId;
            var result = await _cartService.UpdateCartItemAsync(cartItem);
            if (!result)
            {
                return Json(new { success = false, message = "Miktar güncellenirken bir hata oluştu." });
            }

            var totalAmount = await _cartService.GetCartTotalAsync(userId);
            var cartItems = await _cartService.GetCartItemsAsync(userId);
            var count = cartItems.Sum(ci => ci.Quantity);

            return Json(new { success = true, totalAmount, count });
        }

        [HttpPost]
        public async Task<IActionResult> RemoveItem(int cartItemId)
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            var result = await _cartService.RemoveFromCartAsync(cartItemId, userId);
            
            if (!result)
            {
                return Json(new { success = false, message = "Ürün sepetten kaldırılırken bir hata oluştu." });
            }

            var totalAmount = await _cartService.GetCartTotalAsync(userId);
            var cartItems = await _cartService.GetCartItemsAsync(userId);
            var count = cartItems.Sum(ci => ci.Quantity);

            return Json(new { success = true, totalAmount, count });
        }

        [HttpGet]
        public async Task<IActionResult> GetCartCount()
        {
            var userId = HttpContext.Items["UserId"]?.ToString();
            if (string.IsNullOrEmpty(userId))
            {
                return Json(new { count = 0 });
            }

            var cartItems = await _cartService.GetCartItemsAsync(userId);
            var count = cartItems.Sum(ci => ci.Quantity);
            return Json(new { count });
        }
    }
} 