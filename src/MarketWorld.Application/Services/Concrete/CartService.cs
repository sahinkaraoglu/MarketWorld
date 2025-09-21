using MarketWorld.Application.Repositories;
using MarketWorld.Application.Services.Abstract;
using MarketWorld.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MarketWorld.Application.Services.Concrete
{
    public class CartService : ICartService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CartService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<CartItem>> GetCartItemsAsync(string userId)
        {
            var cart = await _unitOfWork.Carts.GetUserCartWithItemsAsync(userId);
            if (cart == null) return new List<CartItem>();

            var cartItems = await _unitOfWork.CartItems.FindAsync(ci => ci.CartId == cart.Id);
            if (cartItems == null) return new List<CartItem>();
            
            var items = cartItems.ToList();

            foreach (var item in items)
            {
                if (item.UnitPrice == 0)
                {
                    item.UnitPrice = item.Product.Price;
                }
            }

            return items;
        }

        public async Task<CartItem> GetCartItemByIdAsync(int id, string userId)
        {
            var cart = await _unitOfWork.Carts.GetUserCartWithItemsAsync(userId);
            return cart?.CartItems.FirstOrDefault(ci => ci.Id == id);
        }

        public async Task<bool> AddToCartAsync(CartItem cartItem, string userId)
        {
            var cart = await _unitOfWork.Carts.GetUserCartWithItemsAsync(userId);
            if (cart == null)
            {
                cart = new Cart { UserId = userId };
                await _unitOfWork.Carts.AddAsync(cart);
            }

            // CartItems null ise boş liste oluştur
            if (cart.CartItems == null)
            {
                cart.CartItems = new List<CartItem>();
            }

            var existingItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == cartItem.ProductId);
            if (existingItem != null)
            {
                existingItem.Quantity += cartItem.Quantity;
            }
            else
            {
                cartItem.CartId = cart.Id;
                cart.CartItems.Add(cartItem);
            }

            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateCartItemAsync(CartItem cartItem, string userId)
        {
            var cart = await _unitOfWork.Carts.GetUserCartWithItemsAsync(userId);
            if (cart == null)
                return false;

            var existingItem = cart.CartItems?.FirstOrDefault(ci => ci.Id == cartItem.Id);
            if (existingItem == null)
                return false;

            existingItem.Quantity = cartItem.Quantity;
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> RemoveFromCartAsync(int id, string userId)
        {
            var cart = await _unitOfWork.Carts.GetUserCartWithItemsAsync(userId);
            if (cart == null)
                return false;

            var cartItem = cart.CartItems?.FirstOrDefault(ci => ci.Id == id);
            if (cartItem == null)
                return false;

            _unitOfWork.CartItems.Remove(cartItem);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ClearCartAsync(string userId)
        {
            var cart = await _unitOfWork.Carts.GetUserCartWithItemsAsync(userId);
            if (cart == null)
                return false;

            if (cart.CartItems != null && cart.CartItems.Any())
            {
                _unitOfWork.CartItems.RemoveRange(cart.CartItems);
                await _unitOfWork.SaveChangesAsync();
            }
            return true;
        }

        public async Task<decimal> GetCartTotalAsync(string userId)
        {
            var cart = await _unitOfWork.Carts.GetUserCartWithItemsAsync(userId);
            if (cart == null)
                return 0;

            return cart.CartItems?.Sum(ci => ci.Quantity * ci.Product.Price) ?? 0;
        }
    }
} 