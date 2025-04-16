using System;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Data;
using MarketWorld.Application.Services.Jwt;

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
                    
                    // Token doğrulama ve kullanıcı id'sini context'e ekleme
                    var userId = jwtService.ValidateJwtToken(token);
                    if (userId != null)
                    {
                        _logger.LogInformation("Oturum açık kullanıcı ID: {UserId}", userId);
                        context.Items["UserId"] = userId;
                        
                        // Kullanıcı bilgilerini veritabanından al
                        var user = await dbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
                        if (user != null)
                        {
                            _logger.LogInformation("Kullanıcı bilgileri yüklendi: {Username}", user.Username);
                            
                            // HttpContext.Items'a kullanıcı bilgilerini ekle
                            context.Items["Username"] = user.Username;
                            context.Items["Email"] = user.Email;
                        }
                        else
                        {
                            _logger.LogWarning("Token geçerli, fakat kullanıcı {UserId} bulunamadı", userId);
                        }
                    }
                    else
                    {
                        _logger.LogWarning("Token doğrulanamadı");
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