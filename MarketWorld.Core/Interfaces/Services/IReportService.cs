using MarketWorld.Core.Domain.Entities;

namespace MarketWorld.Core.Interfaces.Services
{
    public interface IReportService
    {
        Task<(decimal monthlyRevenue, decimal dailyRevenue, 
            IEnumerable<dynamic> topSellingProducts, 
            IEnumerable<dynamic> topSellingCategories, 
            IEnumerable<dynamic> orderStatusDistribution)> GetReportDataAsync();
    }
} 