using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace MarketWorld.Web.Services.Api
{
    public class RestService : IRestService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly ILogger<RestService> _logger;
        private readonly JsonSerializerOptions _jsonOptions;
        private readonly Dictionary<string, string> _serviceUrls;

        public RestService(HttpClient httpClient, IConfiguration configuration, ILogger<RestService> logger)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _logger = logger;
            
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            // Tüm servis URL'lerini configuration'dan al
            _serviceUrls = new Dictionary<string, string>();
            var servicesSection = _configuration.GetSection("ApiSettings:Services");
            foreach (var service in servicesSection.GetChildren())
            {
                _serviceUrls[service.Key] = service.Value ?? string.Empty;
            }
        }

        public void SetAuthorizationHeader(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = 
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            
            _logger.LogInformation($"Authorization header set: Bearer {token?.Substring(0, Math.Min(20, token?.Length ?? 0))}...");
        }

        public void SetBaseUrl(string serviceName)
        {
            if (_serviceUrls.TryGetValue(serviceName, out var baseUrl) && !string.IsNullOrEmpty(baseUrl))
            {
                _httpClient.BaseAddress = new Uri(baseUrl);
            }
            else
            {
                throw new ArgumentException($"Service '{serviceName}' not found in configuration", nameof(serviceName));
            }
        }

        public async Task<TResponse> GetAsync<TResponse>(string serviceName, string endpoint, Dictionary<string, string>? queryParams = null)
        {
            try
            {
                SetBaseUrl(serviceName);
                var url = BuildUrl(endpoint, queryParams);
                _logger.LogInformation($"GET isteği gönderiliyor: {serviceName} - {url}");

                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<TResponse>(content, _jsonOptions);
                
                _logger.LogInformation($"GET isteği başarılı: {serviceName} - {url}");
                return result!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GET isteği başarısız: {serviceName} - {endpoint}");
                throw;
            }
        }

        public async Task<TResponse> PostAsync<TRequest, TResponse>(string serviceName, string endpoint, TRequest request)
        {
            try
            {
                SetBaseUrl(serviceName);
                var json = JsonSerializer.Serialize(request, _jsonOptions);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                
                _logger.LogInformation($"POST isteği gönderiliyor: {serviceName} - {endpoint}");
                _logger.LogInformation($"Authorization header: {_httpClient.DefaultRequestHeaders.Authorization}");

                var response = await _httpClient.PostAsync(endpoint, content);
                
                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"POST isteği başarısız: {serviceName} - {endpoint}, Status: {response.StatusCode}, Error: {errorContent}");
                }
                
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<TResponse>(responseContent, _jsonOptions);
                
                _logger.LogInformation($"POST isteği başarılı: {serviceName} - {endpoint}");
                return result!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"POST isteği başarısız: {serviceName} - {endpoint}");
                throw;
            }
        }

        public async Task<TResponse> PutAsync<TRequest, TResponse>(string serviceName, string endpoint, TRequest request)
        {
            try
            {
                SetBaseUrl(serviceName);
                var json = JsonSerializer.Serialize(request, _jsonOptions);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                
                _logger.LogInformation($"PUT isteği gönderiliyor: {serviceName} - {endpoint}");

                var response = await _httpClient.PutAsync(endpoint, content);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<TResponse>(responseContent, _jsonOptions);
                
                _logger.LogInformation($"PUT isteği başarılı: {serviceName} - {endpoint}");
                return result!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"PUT isteği başarısız: {serviceName} - {endpoint}");
                throw;
            }
        }

        public async Task DeleteAsync(string serviceName, string endpoint)
        {
            try
            {
                SetBaseUrl(serviceName);
                _logger.LogInformation($"DELETE isteği gönderiliyor: {serviceName} - {endpoint}");

                var response = await _httpClient.DeleteAsync(endpoint);
                response.EnsureSuccessStatusCode();
                
                _logger.LogInformation($"DELETE isteği başarılı: {serviceName} - {endpoint}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"DELETE isteği başarısız: {serviceName} - {endpoint}");
                throw;
            }
        }

        public async Task<TResponse> PostAsync<TResponse>(string serviceName, string endpoint)
        {
            try
            {
                SetBaseUrl(serviceName);
                _logger.LogInformation($"POST isteği gönderiliyor: {serviceName} - {endpoint}");

                var response = await _httpClient.PostAsync(endpoint, null);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<TResponse>(responseContent, _jsonOptions);
                
                _logger.LogInformation($"POST isteği başarılı: {serviceName} - {endpoint}");
                return result!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"POST isteği başarısız: {serviceName} - {endpoint}");
                throw;
            }
        }

        private string BuildUrl(string endpoint, Dictionary<string, string>? queryParams)
        {
            var url = endpoint;
            
            if (queryParams != null && queryParams.Any())
            {
                var queryString = string.Join("&", queryParams.Select(kvp => $"{kvp.Key}={Uri.EscapeDataString(kvp.Value)}"));
                url += $"?{queryString}";
            }
            
            return url;
        }
    }
}
