using MarketWorld.Domain.Entities;

namespace MarketWorld.Application.Services.Jwt
{
    public interface IJwtService
    {
        string GenerateJwtToken(User user);
        int? ValidateJwtToken(string token);
    }
}