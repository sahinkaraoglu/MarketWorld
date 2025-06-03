using MarketWorld.Application.Repositories;
using MarketWorld.Application.Services.Interfaces;
using MarketWorld.Core.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Implementations
{
    public class CartService : ICartService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CartService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Cart> GetUserCartAsync(string userId)
        {
            return await _unitOfWork.Carts.GetUserCartWithItemsAsync(userId);
        }

        public async Task<Cart> AddToCartAsync(string userId, int productId, int quantity)
        {
            var cart = await GetUserCartAsync(userId);
            if (cart == null)
            {
                cart = new Cart { UserId = userId };
                await _unitOfWork.Carts.AddAsync(cart);
            }

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
            if (cartItem != null)
            {
                cartItem.Quantity += quantity;
            }
            else
            {
                cartItem = new CartItem
                {
                    CartId = cart.Id,
                    ProductId = productId,
                    Quantity = quantity
                };
                cart.CartItems.Add(cartItem);
            }

            await _unitOfWork.SaveChangesAsync();
            return cart;
        }

        public async Task<Cart> UpdateCartItemQuantityAsync(string userId, int productId, int quantity)
        {
            var cart = await GetUserCartAsync(userId);
            if (cart == null)
                throw new ArgumentException("Sepet bulunamadı.");

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
            if (cartItem == null)
                throw new ArgumentException("Ürün sepette bulunamadı.");

            cartItem.Quantity = quantity;
            await _unitOfWork.SaveChangesAsync();
            return cart;
        }

        public async Task RemoveFromCartAsync(string userId, int productId)
        {
            var cart = await GetUserCartAsync(userId);
            if (cart == null)
                throw new ArgumentException("Sepet bulunamadı.");

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
            if (cartItem != null)
            {
                _unitOfWork.CartItems.Remove(cartItem);
                await _unitOfWork.SaveChangesAsync();
            }
        }

        public async Task ClearCartAsync(string userId)
        {
            var cart = await GetUserCartAsync(userId);
            if (cart != null)
            {
                _unitOfWork.CartItems.RemoveRange(cart.CartItems);
                await _unitOfWork.SaveChangesAsync();
            }
        }

        public async Task<decimal> GetCartTotalAsync(string userId)
        {
            var cart = await GetUserCartAsync(userId);
            if (cart == null)
                return 0;

            return cart.CartItems.Sum(ci => ci.Quantity * ci.Product.Price);
        }
    }
} 