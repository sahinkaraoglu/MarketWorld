using MarketWorld.Core.Domain.Entities;
using System.Threading.Tasks;

namespace MarketWorld.Application.Repositories
{
    public interface ICartRepository : IRepository<Cart>
    {
        Task<Cart> GetUserCartWithItemsAsync(string userId);
    }
} 