using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Data;
using MarketWorld.Domain.Entities;

namespace MarketWorld.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly MarketWorldDbContext _context;

        public CartController(MarketWorldDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId, int quantity = 1, string color = null)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (!userId.HasValue)
            {
                return Json(new { success = false, message = "Lütfen önce giriş yapın." });
            }

            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                return Json(new { success = false, message = "Ürün bulunamadı." });
            }

            if (product.Stock < quantity)
            {
                return Json(new { success = false, message = "Yeterli stok bulunmamaktadır." });
            }

            var cart = await _context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null)
            {
                cart = new Cart
                {
                    UserId = userId.Value,
                    CartItems = new List<CartItem>(),
                    TotalAmount = 0
                };
                _context.Carts.Add(cart);
            }

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId && ci.Color == color);
            if (cartItem != null)
            {
                cartItem.Quantity += quantity;
            }
            else
            {
                cartItem = new CartItem
                {
                    ProductId = productId,
                    Quantity = quantity,
                    UnitPrice = product.Price,
                    Color = color
                };
                cart.CartItems.Add(cartItem);
            }

            cart.TotalAmount = cart.CartItems.Sum(ci => ci.Quantity * ci.UnitPrice);

            await _context.SaveChangesAsync();

            var count = cart.CartItems.Sum(ci => ci.Quantity);
            return Json(new { success = true, message = "Ürün sepete eklendi.", count });
        }

        public async Task<IActionResult> Index()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (!userId.HasValue)
            {
                return RedirectToAction("Index", "Login");
            }

            var cart = await _context.Carts
                .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Product)
                        .ThenInclude(p => p.Images)
                .FirstOrDefaultAsync(c => c.UserId == userId);
            
            // Kullanıcı bilgilerini ve adreslerini yükle
            var user = await _context.Users
                .Include(u => u.Addresses)
                .FirstOrDefaultAsync(u => u.Id == userId);
            
            if (user != null)
            {
                // Adresleri ayrı bir ViewBag özelliği olarak ekle
                ViewBag.UserAddresses = user.Addresses?.ToList() ?? new List<Address>();
                
                // Kullanıcı nesnesinde Addresses koleksiyonunu null kontrolü ile liste haline getir
                if (user.Addresses == null)
                {
                    user.Addresses = new List<Address>();
                }
            }
            else
            {
                ViewBag.UserAddresses = new List<Address>();
            }
            
            ViewBag.UserProfile = user;

            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQuantity(int cartItemId, int quantity)
        {
            var cartItem = await _context.CartItems
                .Include(ci => ci.Product)
                .FirstOrDefaultAsync(ci => ci.Id == cartItemId);

            if (cartItem == null)
            {
                return Json(new { success = false, message = "Sepet öğesi bulunamadı." });
            }

            if (cartItem.Product.Stock < quantity)
            {
                return Json(new { success = false, message = "Yeterli stok bulunmamaktadır." });
            }

            cartItem.Quantity = quantity;
            await _context.SaveChangesAsync();

            var cart = await _context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.Id == cartItem.CartId);

            cart.TotalAmount = cart.CartItems.Sum(ci => ci.Quantity * ci.UnitPrice);
            await _context.SaveChangesAsync();

            var count = cart.CartItems.Sum(ci => ci.Quantity);
            return Json(new { success = true, totalAmount = cart.TotalAmount, count });
        }

        [HttpPost]
        public async Task<IActionResult> RemoveItem(int cartItemId)
        {
            var cartItem = await _context.CartItems.FindAsync(cartItemId);
            if (cartItem == null)
            {
                return Json(new { success = false, message = "Sepet öğesi bulunamadı." });
            }

            _context.CartItems.Remove(cartItem);
            await _context.SaveChangesAsync();

            var cart = await _context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.Id == cartItem.CartId);

            cart.TotalAmount = cart.CartItems.Sum(ci => ci.Quantity * ci.UnitPrice);
            await _context.SaveChangesAsync();

            var count = cart.CartItems.Sum(ci => ci.Quantity);
            return Json(new { success = true, totalAmount = cart.TotalAmount, count });
        }

        [HttpGet]
        public async Task<IActionResult> GetCartCount()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (!userId.HasValue)
            {
                return Json(new { count = 0 });
            }

            var cart = await _context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            var count = cart?.CartItems?.Sum(ci => ci.Quantity) ?? 0;
            return Json(new { count });
        }
    }
} 