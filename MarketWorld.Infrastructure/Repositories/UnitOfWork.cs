using MarketWorld.Application.Repositories;
using MarketWorld.Infrastructure.Data;
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
        private IDbContextTransaction _transaction;

        public UnitOfWork(MarketWorldDbContext context)
        {
            _context = context;
        }

        public IProductRepository Products => 
            _productRepository ??= new ProductRepository(_context);

        public ICategoryRepository Categories => 
            _categoryRepository ??= new CategoryRepository(_context);

        public async Task BeginTransactionAsync()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            try
            {
                await _transaction.CommitAsync();
            }
            catch
            {
                await _transaction.RollbackAsync();
                throw;
            }
        }

        public async Task RollbackAsync()
        {
            await _transaction.RollbackAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _context.Dispose();
        }
    }
} 