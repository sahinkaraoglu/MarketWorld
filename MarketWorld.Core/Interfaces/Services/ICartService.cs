using System.Threading.Tasks;
using System.Collections.Generic;
using MarketWorld.Core.Domain.Entities;

namespace MarketWorld.Core.Interfaces.Services
{
    public interface ICartService
    {
        Task<List<CartItem>> GetCartItemsAsync(string userId);
        Task<CartItem> GetCartItemByIdAsync(int id, string userId);
        Task<bool> AddToCartAsync(CartItem cartItem);
        Task<bool> UpdateCartItemAsync(CartItem cartItem);
        Task<bool> RemoveFromCartAsync(int id, string userId);
        Task<bool> ClearCartAsync(string userId);
        Task<decimal> GetCartTotalAsync(string userId);
    }
} 