using System;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Data;
using MarketWorld.Application.Services.Jwt;
using Microsoft.AspNetCore.Http.Extensions;
// Session için extensions sınıfları
using Microsoft.AspNetCore.Http;

namespace MarketWorld.Web.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;
        private readonly ILogger<JwtMiddleware> _logger;

        public JwtMiddleware(RequestDelegate next, IConfiguration configuration, ILogger<JwtMiddleware> logger)
        {
            _next = next;
            _configuration = configuration;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context, IJwtService jwtService, MarketWorldDbContext dbContext)
        {
            var token = context.Request.Cookies["X-Access-Token"];
            
            // Session kontrolü
            var sessionUserId = context.Session.GetString("UserId");
            if (!string.IsNullOrEmpty(sessionUserId))
            {
                context.Items["UserId"] = sessionUserId;
                context.Items["Username"] = context.Session.GetString("Username");
                context.Items["UserEmail"] = context.Session.GetString("UserEmail");
                
                Console.WriteLine($"Session'dan kullanıcı bilgileri yüklendi: UserId={sessionUserId}, Username={context.Session.GetString("Username")}");
                
                await _next(context);
                return;
            }
            
            if (!string.IsNullOrEmpty(token))
            {
                try
                {
                    // Token içeriğini loglama (sadece geliştirme aşamasında)
                    if (_configuration.GetValue<bool>("EnableTokenLogging", false))
                    {
                        var handler = new JwtSecurityTokenHandler();
                        if (handler.CanReadToken(token))
                        {
                            var jwtToken = handler.ReadJwtToken(token);
                            _logger.LogInformation("JWT Token içeriği: {@Claims}", jwtToken.Claims);
                        }
                    }
                    
                    // Token'ı doğrula ve kullanıcı ID'sini al
                    var userId = jwtService.ValidateJwtToken(token);
                    if (!string.IsNullOrEmpty(userId))
                    {
                        // Kullanıcıyı veritabanında kontrol et
                        var user = await dbContext.Users.FindAsync(userId);
                        if (user != null && user.IsActive)
                        {
                            // Kullanıcı ID'sini HttpContext.Items'a ekle
                            context.Items["UserId"] = userId;
                            context.Items["Username"] = user.UserName;
                            context.Items["UserEmail"] = user.Email;
                            
                            // Bu değerleri debug için yazdır
                            Console.WriteLine($"Middleware - UserId: {userId}, Username: {user.UserName}, Email: {user.Email}");
                            
                            _logger.LogDebug("Kullanıcı kimliği doğrulandı: {UserId}", userId);
                        }
                        else
                        {
                            _logger.LogWarning("Kullanıcı bulunamadı veya aktif değil: {UserId}", userId);
                        }
                    }
                    else
                    {
                        _logger.LogWarning("Geçersiz token");
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Token işlenirken hata oluştu");
                }
            }

            await _next(context);
        }
    }
} 