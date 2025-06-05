using System;
using System.Threading.Tasks;

namespace MarketWorld.Application.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        ISubCategoryRepository SubCategories { get; }
        ICommentRepository Comments { get; }
        IBrandRepository Brands { get; }
        IOrderRepository Orders { get; }
        IOrderItemRepository OrderItems { get; }
        IPropertyTypeRepository PropertyTypes { get; }
        IPropertyValueRepository PropertyValues { get; }
        ICartRepository Carts { get; }
        ICartItemRepository CartItems { get; }
        IAddressRepository Addresses { get; }
        
        Task<int> SaveChangesAsync();
        Task BeginTransactionAsync();
        Task CommitAsync();
        Task RollbackAsync();
    }
} 