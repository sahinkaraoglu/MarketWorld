using MarketWorld.Web.Models.Api;

namespace MarketWorld.Web.Services.Api
{
    public interface IAuthApiService
    {
        Task<TokenResponse> LoginAsync(LoginRequest request);
        Task<TokenResponse> RefreshTokenAsync(string refreshToken);
        Task<bool> ValidateTokenAsync(string token);
        Task<TokenResponse?> GetCachedTokenAsync(string userId);
        void RemoveCachedToken(string userId);
    }
}
