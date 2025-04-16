using MarketWorld.Domain.Entities;

namespace MarketWorld.Application.Services.Jwt;

public interface IJwtService
{
    string? GenerateJwtToken(ApplicationUser user);
    string GenerateToken(string userId, string email, string userName);
    string? ValidateJwtToken(string token);
}