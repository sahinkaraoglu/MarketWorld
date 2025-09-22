using MarketWorld.Web.Models.Api;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace MarketWorld.Web.Services.Api
{
    public class AuthApiService : IAuthApiService
    {
        private readonly IRestService _restService;
        private readonly IMemoryCache _cache;
        private readonly ILogger<AuthApiService> _logger;
        private const string CACHE_KEY_PREFIX = "jwt_token_";
        private const int CACHE_DURATION_MINUTES = 25; // JWT token'dan 5 dakika önce expire olsun

        public AuthApiService(IRestService restService, IMemoryCache cache, ILogger<AuthApiService> logger)
        {
            _restService = restService;
            _cache = cache;
            _logger = logger;
        }

        public async Task<TokenResponse> LoginAsync(LoginRequest request)
        {
            try
            {
                var response = await _restService.PostAsync<LoginRequest, TokenResponse>("AuthenticationService", "api/auth/login", request);
                
                // Token'ı cache'e kaydet
                if (!string.IsNullOrEmpty(response.Token))
                {
                    var cacheKey = $"{CACHE_KEY_PREFIX}{response.UserId}";
                    var cacheOptions = new MemoryCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(CACHE_DURATION_MINUTES),
                        SlidingExpiration = TimeSpan.FromMinutes(5)
                    };
                    
                    _cache.Set(cacheKey, response, cacheOptions);
                    _logger.LogInformation($"JWT token cache'e kaydedildi. UserId: {response.UserId}");
                }
                
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Login işlemi başarısız");
                throw;
            }
        }

        public async Task<TokenResponse> RefreshTokenAsync(string refreshToken)
        {
            try
            {
                // Refresh token endpoint'i henüz yok, şimdilik login'i tekrar çağırıyoruz
                // Bu kısım AuthenticationService'de refresh token endpoint'i eklendikten sonra güncellenecek
                throw new NotImplementedException("Refresh token endpoint'i henüz implement edilmedi");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Token refresh işlemi başarısız");
                throw;
            }
        }

        public async Task<bool> ValidateTokenAsync(string token)
        {
            try
            {
                // Token validation için AuthenticationService'e istek gönder
                // Şimdilik basit bir validation yapıyoruz
                return !string.IsNullOrEmpty(token) && token.Length > 10;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Token validation başarısız");
                return false;
            }
        }

        public async Task<TokenResponse?> GetCachedTokenAsync(string userId)
        {
            try
            {
                var cacheKey = $"{CACHE_KEY_PREFIX}{userId}";
                if (_cache.TryGetValue(cacheKey, out TokenResponse cachedToken))
                {
                    _logger.LogInformation($"Cached JWT token bulundu. UserId: {userId}");
                    return cachedToken;
                }
                
                _logger.LogWarning($"Cached JWT token bulunamadı. UserId: {userId}");
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Cached token alma işlemi başarısız");
                return null;
            }
        }

        public void RemoveCachedToken(string userId)
        {
            try
            {
                var cacheKey = $"{CACHE_KEY_PREFIX}{userId}";
                _cache.Remove(cacheKey);
                _logger.LogInformation($"Cached JWT token silindi. UserId: {userId}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Cached token silme işlemi başarısız");
            }
        }
    }
}
