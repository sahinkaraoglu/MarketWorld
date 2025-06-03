using MarketWorld.Core.Interfaces.Services;
using MarketWorld.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace MarketWorld.Infrastructure.Services
{
    public class ReportService : IReportService
    {
        private readonly MarketWorldDbContext _context;

        public ReportService(MarketWorldDbContext context)
        {
            _context = context;
        }

        public async Task<(decimal monthlyRevenue, decimal dailyRevenue, 
            IEnumerable<dynamic> topSellingProducts, 
            IEnumerable<dynamic> topSellingCategories, 
            IEnumerable<dynamic> orderStatusDistribution)> GetReportDataAsync()
        {
            var orders = await _context.Orders
                .Include(o => o.OrderItems)
                .ToListAsync();

            var monthlyRevenue = orders
                .Where(o => o.CreatedDate >= DateTime.Now.AddMonths(-1))
                .Sum(o => o.TotalAmount);

            var dailyRevenue = orders
                .Where(o => o.CreatedDate == DateTime.Today)
                .Sum(o => o.TotalAmount);

            var topSellingProducts = await _context.OrderItems
                .Include(oi => oi.Product)
                .GroupBy(oi => oi.ProductId)
                .Select(g => new
                {
                    ProductId = g.Key,
                    ProductName = g.First().Product.Name,
                    TotalQuantity = g.Sum(oi => oi.Quantity),
                    TotalRevenue = g.Sum(oi => oi.Product.Price * oi.Quantity)
                })
                .OrderByDescending(x => x.TotalQuantity)
                .Take(10)
                .ToListAsync();

            var topSellingCategories = await _context.OrderItems
                .Include(oi => oi.Product)
                    .ThenInclude(p => p.SubCategory)
                        .ThenInclude(sc => sc.Category)
                .GroupBy(oi => oi.Product.SubCategory.CategoryId)
                .Select(g => new
                {
                    CategoryId = g.Key,
                    CategoryName = g.First().Product.SubCategory.Category.Name,
                    TotalQuantity = g.Sum(oi => oi.Quantity),
                    TotalRevenue = g.Sum(oi => oi.Product.Price * oi.Quantity)
                })
                .OrderByDescending(x => x.TotalQuantity)
                .Take(10)
                .ToListAsync();

            var orderStatusDistribution = orders
                .GroupBy(o => o.Status)
                .Select(g => new
                {
                    Status = g.Key,
                    Count = g.Count()
                })
                .ToList();

            return (monthlyRevenue, dailyRevenue, topSellingProducts, topSellingCategories, orderStatusDistribution);
        }
    }
} 