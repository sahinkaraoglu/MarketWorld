using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using MarketWorld.Infrastructure.Context;

namespace MarketWorld.Web.ViewComponents
{
    public class UserInfoViewComponent : ViewComponent
    {
        private readonly ILogger<UserInfoViewComponent> _logger;

        public UserInfoViewComponent(MarketWorldDbContext context, ILogger<UserInfoViewComponent> logger)
        {
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (HttpContext.Items.ContainsKey("UserId") && HttpContext.Items["UserId"] != null)
            {
                var userId = HttpContext.Items["UserId"].ToString();
                _logger.LogInformation("UserInfoViewComponent: Kullanıcı bilgileri yükleniyor. UserId: {UserId}", userId);
                
                ViewBag.UserId = userId;
                ViewBag.Username = HttpContext.Items.ContainsKey("Username") ? HttpContext.Items["Username"]?.ToString() : "Kullanıcı";
                ViewBag.UserEmail = HttpContext.Items.ContainsKey("UserEmail") ? HttpContext.Items["UserEmail"]?.ToString() : "";
                
                // Debug bilgisi
                Console.WriteLine($"UserInfoViewComponent - UserId: {userId}, Username: {ViewBag.Username}, Email: {ViewBag.UserEmail}");
                
                string username = ViewBag.Username?.ToString() ?? "";
                _logger.LogInformation("Kullanıcı bilgileri yüklendi: ID: {UserId}, Name: {Username}", userId, username);
            }
            else
            {
                _logger.LogDebug("Oturum açmış kullanıcı bulunamadı");
                Console.WriteLine("UserInfoViewComponent - Kullanıcı bulunamadı");
            }
            
            return View();
        }
    }
} 