using MarketWorld.Core.Domain.Entities;

namespace MarketWorld.Application.Services.Jwt
{
    public interface IJwtService
    {
        string? GenerateJwtToken(ApplicationUser user);
        string GenerateToken(string userId, string email, string userName);
        Task<string> GenerateToken(ApplicationUser user);
        string? ValidateJwtToken(string token);
    }
}