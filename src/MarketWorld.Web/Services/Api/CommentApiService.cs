using MarketWorld.Web.Models.Api;
using Microsoft.Extensions.Logging;

namespace MarketWorld.Web.Services.Api
{
    public class CommentApiService : ICommentApiService
    {
        private readonly IRestService _restService;
        private readonly ILogger<CommentApiService> _logger;

        public CommentApiService(IRestService restService, ILogger<CommentApiService> logger)
        {
            _restService = restService;
            _logger = logger;
        }

        public async Task<CommentDto> CreateCommentAsync(CreateCommentRequest request, string token)
        {
            try
            {
                _logger.LogInformation($"Yorum oluşturuluyor - ProductId: {request.ProductId}");
                
                // Authorization header'ı ekle
                _restService.SetAuthorizationHeader(token);
                
                var result = await _restService.PostAsync<CreateCommentRequest, CommentDto>("CatalogService", "api/comment", request);
                
                _logger.LogInformation($"Yorum başarıyla oluşturuldu - CommentId: {result.Id}");
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Yorum oluşturulurken hata oluştu - ProductId: {request.ProductId}");
                throw;
            }
        }

        public async Task<List<CommentDto>> GetProductCommentsAsync(int productId, int page = 1, int pageSize = 20)
        {
            try
            {
                _logger.LogInformation($"Ürün yorumları getiriliyor - ProductId: {productId}");
                
                var queryParams = new Dictionary<string, string>
                {
                    { "page", page.ToString() },
                    { "pageSize", pageSize.ToString() }
                };
                
                var result = await _restService.GetAsync<List<CommentDto>>("CatalogService", $"api/comment/product/{productId}", queryParams);
                
                _logger.LogInformation($"Ürün yorumları başarıyla getirildi - ProductId: {productId}, Count: {result.Count}");
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Ürün yorumları getirilirken hata oluştu - ProductId: {productId}");
                throw;
            }
        }

        public async Task<CommentDto> GetCommentByIdAsync(int id)
        {
            try
            {
                _logger.LogInformation($"Yorum getiriliyor - CommentId: {id}");
                
                var result = await _restService.GetAsync<CommentDto>("CatalogService", $"api/comment/{id}");
                
                _logger.LogInformation($"Yorum başarıyla getirildi - CommentId: {id}");
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Yorum getirilirken hata oluştu - CommentId: {id}");
                throw;
            }
        }

        public async Task<CommentDto> UpdateCommentAsync(int id, CreateCommentRequest request, string token)
        {
            try
            {
                _logger.LogInformation($"Yorum güncelleniyor - CommentId: {id}");
                
                // Authorization header'ı ekle
                _restService.SetAuthorizationHeader(token);
                
                var result = await _restService.PutAsync<CreateCommentRequest, CommentDto>("CatalogService", $"api/comment/{id}", request);
                
                _logger.LogInformation($"Yorum başarıyla güncellendi - CommentId: {id}");
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Yorum güncellenirken hata oluştu - CommentId: {id}");
                throw;
            }
        }

        public async Task DeleteCommentAsync(int id, string token)
        {
            try
            {
                _logger.LogInformation($"Yorum siliniyor - CommentId: {id}");
                
                // Authorization header'ı ekle
                _restService.SetAuthorizationHeader(token);
                
                await _restService.DeleteAsync("CatalogService", $"api/comment/{id}");
                
                _logger.LogInformation($"Yorum başarıyla silindi - CommentId: {id}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Yorum silinirken hata oluştu - CommentId: {id}");
                throw;
            }
        }
    }
}
