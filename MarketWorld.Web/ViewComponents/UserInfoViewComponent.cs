using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MarketWorld.Infrastructure.Data;
using System.Threading.Tasks;

namespace MarketWorld.Web.ViewComponents
{
    public class UserInfoViewComponent : ViewComponent
    {
        private readonly MarketWorldDbContext _context;
        private readonly ILogger<UserInfoViewComponent> _logger;

        public UserInfoViewComponent(MarketWorldDbContext context, ILogger<UserInfoViewComponent> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (HttpContext.Items["UserId"] != null)
            {
                var userId = (int)HttpContext.Items["UserId"];
                _logger.LogInformation("UserInfoViewComponent: Kullanıcı bilgileri yükleniyor. UserId: {UserId}", userId);
                
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
                
                if (user != null)
                {
                    _logger.LogInformation("Kullanıcı bilgileri yüklendi: {Username}", user.Username);
                    ViewBag.UserId = user.Id;
                    ViewBag.Username = user.Username;
                    ViewBag.UserEmail = user.Email;
                }
                else
                {
                    _logger.LogWarning("Kullanıcı ID'si {UserId} olan kullanıcı bulunamadı", userId);
                }
            }
            else
            {
                _logger.LogDebug("Oturum açmış kullanıcı bulunamadı");
            }
            
            return View();
        }
    }
} 