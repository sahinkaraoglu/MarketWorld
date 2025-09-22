using System.Text.Json;

namespace MarketWorld.Web.Services.Api
{
    public interface IRestService
    {
        Task<TResponse> GetAsync<TResponse>(string serviceName, string endpoint, Dictionary<string, string>? queryParams = null);
        Task<TResponse> PostAsync<TRequest, TResponse>(string serviceName, string endpoint, TRequest request);
        Task<TResponse> PutAsync<TRequest, TResponse>(string serviceName, string endpoint, TRequest request);
        Task DeleteAsync(string serviceName, string endpoint);
        Task<TResponse> PostAsync<TResponse>(string serviceName, string endpoint);
        void SetAuthorizationHeader(string token);
        void SetBaseUrl(string serviceName);
    }
}
