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
        IPropertyTypeRepository PropertyTypes { get; }
        IPropertyValueRepository PropertyValues { get; }
        
        Task<int> SaveChangesAsync();
        Task BeginTransactionAsync();
        Task CommitAsync();
        Task RollbackAsync();
    }
} 