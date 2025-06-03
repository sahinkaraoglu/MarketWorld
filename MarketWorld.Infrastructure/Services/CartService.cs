using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Core.Interfaces.Services;
using MarketWorld.Infrastructure.Context;

namespace MarketWorld.Infrastructure.Services
{
    public class CartService : ICartService
    {
        private readonly MarketWorldDbContext _context;

        public CartService(MarketWorldDbContext context)
        {
            _context = context;
        }

        public async Task<List<CartItem>> GetCartItemsAsync(string userId)
        {
            var cart = await _context.Carts
                .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            return cart?.CartItems?.ToList() ?? new List<CartItem>();
        }

        public async Task<CartItem> GetCartItemByIdAsync(int id, string userId)
        {
            var cart = await _context.Carts
                .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            return cart?.CartItems?.FirstOrDefault(ci => ci.Id == id);
        }

        public async Task<bool> AddToCartAsync(CartItem cartItem)
        {
            try
            {
                var cart = await _context.Carts
                    .Include(c => c.CartItems)
                    .FirstOrDefaultAsync(c => c.UserId == cartItem.Cart.UserId);

                if (cart == null)
                {
                    cart = new Cart
                    {
                        UserId = cartItem.Cart.UserId,
                        CartItems = new List<CartItem>()
                    };
                    _context.Carts.Add(cart);
                }

                var existingItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == cartItem.ProductId && ci.Color == cartItem.Color);
                if (existingItem != null)
                {
                    existingItem.Quantity += cartItem.Quantity;
                    _context.CartItems.Update(existingItem);
                }
                else
                {
                    cartItem.CartId = cart.Id;
                    _context.CartItems.Add(cartItem);
                }

                cart.TotalAmount = cart.CartItems.Sum(ci => ci.Quantity * ci.UnitPrice);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateCartItemAsync(CartItem cartItem)
        {
            try
            {
                var cart = await _context.Carts
                    .Include(c => c.CartItems)
                    .FirstOrDefaultAsync(c => c.UserId == cartItem.Cart.UserId);

                if (cart == null)
                    return false;

                var existingItem = cart.CartItems.FirstOrDefault(ci => ci.Id == cartItem.Id);
                if (existingItem == null)
                    return false;

                existingItem.Quantity = cartItem.Quantity;
                cart.TotalAmount = cart.CartItems.Sum(ci => ci.Quantity * ci.UnitPrice);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> RemoveFromCartAsync(int id, string userId)
        {
            try
            {
                var cart = await _context.Carts
                    .Include(c => c.CartItems)
                    .FirstOrDefaultAsync(c => c.UserId == userId);

                if (cart == null)
                    return false;

                var cartItem = cart.CartItems.FirstOrDefault(ci => ci.Id == id);
                if (cartItem == null)
                    return false;

                _context.CartItems.Remove(cartItem);
                cart.TotalAmount = cart.CartItems.Sum(ci => ci.Quantity * ci.UnitPrice);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> ClearCartAsync(string userId)
        {
            try
            {
                var cart = await _context.Carts
                    .Include(c => c.CartItems)
                    .FirstOrDefaultAsync(c => c.UserId == userId);

                if (cart == null)
                    return false;

                _context.CartItems.RemoveRange(cart.CartItems);
                cart.TotalAmount = 0;
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<decimal> GetCartTotalAsync(string userId)
        {
            var cart = await _context.Carts
                .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            return cart?.CartItems?.Sum(ci => ci.Quantity * ci.UnitPrice) ?? 0;
        }
    }
} 