using MarketWorld.Core.Domain.Entities;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Interfaces
{
    public interface ICartService
    {
        Task<Cart> GetUserCartAsync(string userId);
        Task<Cart> AddToCartAsync(string userId, int productId, int quantity);
        Task<Cart> UpdateCartItemQuantityAsync(string userId, int productId, int quantity);
        Task RemoveFromCartAsync(string userId, int productId);
        Task ClearCartAsync(string userId);
        Task<decimal> GetCartTotalAsync(string userId);
    }
} 