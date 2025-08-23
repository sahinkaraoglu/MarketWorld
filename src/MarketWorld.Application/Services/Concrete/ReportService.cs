using MarketWorld.Application.Repositories;
using MarketWorld.Application.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketWorld.Application.Services.Concrete
{
    public class ReportService : IReportService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReportService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<(decimal monthlyRevenue, decimal dailyRevenue, 
            IEnumerable<dynamic> topSellingProducts, 
            IEnumerable<dynamic> topSellingCategories, 
            IEnumerable<dynamic> orderStatusDistribution)> GetReportDataAsync()
        {
            var monthlyRevenue = await _unitOfWork.Orders.GetTotalRevenueByDateRangeAsync(
                DateTime.Now.AddMonths(-1), DateTime.Now);

            var dailyRevenue = await _unitOfWork.Orders.GetTotalRevenueByDateRangeAsync(
                DateTime.Today, DateTime.Today.AddDays(1).AddTicks(-1));

            var topSellingProducts = await _unitOfWork.OrderItems.GetTopSellingProductsAsync(10);
            var topSellingCategories = await _unitOfWork.OrderItems.GetTopSellingCategoriesAsync(10);

            var orders = await _unitOfWork.Orders.GetAllOrdersWithDetailsAsync();
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