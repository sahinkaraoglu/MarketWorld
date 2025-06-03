using MarketWorld.Application.Repositories;
using MarketWorld.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;

namespace MarketWorld.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MarketWorldDbContext _context;
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private ICommentRepository _commentRepository;
        private IBrandRepository _brandRepository;
        private IOrderRepository _orderRepository;
        private ISubCategoryRepository _subCategories;
        private IPropertyTypeRepository _propertyTypes;
        private IPropertyValueRepository _propertyValues;
        private ICartRepository _cartRepository;
        private ICartItemRepository _cartItemRepository;
        private IDbContextTransaction _transaction;
        private bool _disposed;

        public UnitOfWork(MarketWorldDbContext context)
        {
            _context = context;
        }

        public IProductRepository Products => 
            _productRepository ??= new ProductRepository(_context);

        public ICategoryRepository Categories => 
            _categoryRepository ??= new CategoryRepository(_context);
            
        public ICommentRepository Comments => 
            _commentRepository ??= new CommentRepository(_context);
            
        public IBrandRepository Brands => 
            _brandRepository ??= new BrandRepository(_context);

        public IOrderRepository Orders =>
            _orderRepository ??= new OrderRepository(_context);

        public ISubCategoryRepository SubCategories =>
            _subCategories ??= new SubCategoryRepository(_context);

        public IPropertyTypeRepository PropertyTypes =>
            _propertyTypes ??= new PropertyTypeRepository(_context);

        public IPropertyValueRepository PropertyValues =>
            _propertyValues ??= new PropertyValueRepository(_context);

        public ICartRepository Carts =>
            _cartRepository ??= new CartRepository(_context);

        public ICartItemRepository CartItems =>
            _cartItemRepository ??= new CartItemRepository(_context);

        public async Task BeginTransactionAsync()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
                if (_transaction != null)
                {
                    await _transaction.CommitAsync();
                }
            }
            catch
            {
                await RollbackAsync();
                throw;
            }
            finally
            {
                if (_transaction != null)
                {
                    _transaction.Dispose();
                    _transaction = null;
                }
            }
        }

        public async Task RollbackAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
                _transaction.Dispose();
                _transaction = null;
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _context.Dispose();
                if (_transaction != null)
                {
                    _transaction.Dispose();
                }
            }
            _disposed = true;
        }
    }
} 