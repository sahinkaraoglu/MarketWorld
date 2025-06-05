using MarketWorld.Core.Domain.Entities;

namespace MarketWorld.Application.Services.Interfaces
{
    public interface IReportService
    {
        Task<(decimal monthlyRevenue, decimal dailyRevenue, 
            IEnumerable<dynamic> topSellingProducts, 
            IEnumerable<dynamic> topSellingCategories, 
            IEnumerable<dynamic> orderStatusDistribution)> GetReportDataAsync();
    }
} 