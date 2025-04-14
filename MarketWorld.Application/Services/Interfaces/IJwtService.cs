using MarketWorld.Domain.Entities;

namespace MarketWorld.Application.Services.Interfaces
{
    public interface IJwtService
    {
        string GenerateJwtToken(User user);
        int? ValidateJwtToken(string token);
    }
} 