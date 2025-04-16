using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Data;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MarketWorld.Application.Services.Jwt;

namespace MarketWorld.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly MarketWorldDbContext _context;
        private readonly IJwtService _jwtService;
        private readonly ILogger<LoginController> _logger;

        public LoginController(MarketWorldDbContext context, IJwtService jwtService, ILogger<LoginController> logger)
        {
            _context = context;
            _jwtService = jwtService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Kullanıcı giriş yapmışsa Anasayfaya yönlendir
            if (HttpContext.Items["UserId"] != null)
            {
                _logger.LogInformation("Kullanıcı zaten oturum açmış: {UserId}", HttpContext.Items["UserId"]);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                TempData["ErrorMessage"] = "E-posta ve şifre alanları zorunludur!";
                return RedirectToAction("Index");
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == username && u.Password == password && u.IsActive);

            if (user != null)
            {
                _logger.LogInformation("Kullanıcı giriş başarılı: {UserId}, {UserEmail}", user.Id, user.Email);
                
                // JWT token oluştur
                var token = _jwtService.GenerateJwtToken(user);
                _logger.LogDebug("Oluşturulan token: {Token}", token);
                
                // Token'ı cookie olarak ekle
                Response.Cookies.Append("X-Access-Token", token, new CookieOptions
                {
                    HttpOnly = true,
                    SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict,
                    Expires = System.DateTimeOffset.UtcNow.AddDays(7)
                });
                
                // Kullanıcı bilgilerini ViewBag'e ekle
                ViewBag.Username = user.Username;
                ViewBag.UserEmail = user.Email;
                
                return RedirectToAction("Index", "Home");
            }
            else
            {
                _logger.LogWarning("Başarısız giriş denemesi: {Email}", username);
                TempData["ErrorMessage"] = "E-posta veya şifre hatalı!";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Logout()
        {
            if (HttpContext.Items["UserId"] != null)
            {
                _logger.LogInformation("Kullanıcı çıkış yapıyor: {UserId}", HttpContext.Items["UserId"]);
            }
            
            // JWT token içeren cookie'yi sil
            Response.Cookies.Delete("X-Access-Token");
            return RedirectToAction("Index", "Home");
        }
    }
} 