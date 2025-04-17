using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Data;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MarketWorld.Application.Services.Jwt;
using MarketWorld.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace MarketWorld.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly MarketWorldDbContext _context;
        private readonly IJwtService _jwtService;
        private readonly ILogger<LoginController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public LoginController(
            MarketWorldDbContext context, 
            IJwtService jwtService, 
            ILogger<LoginController> logger,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _jwtService = jwtService;
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
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

            // Identity kullanarak giriş işlemi
            var user = await _userManager.FindByEmailAsync(username);
            if (user == null)
            {
                _logger.LogWarning("Kullanıcı bulunamadı: {Email}", username);
                TempData["ErrorMessage"] = "E-posta veya şifre hatalı!";
                return RedirectToAction("Index");
            }

            var result = await _signInManager.PasswordSignInAsync(user, password, isPersistent: true, lockoutOnFailure: true);
            
            if (result.Succeeded)
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
                
                // Identity oturumunu yenile - bu önemli
                await _signInManager.RefreshSignInAsync(user);
                
                // Kullanıcı bilgilerini session'a ekle
                HttpContext.Session.SetString("UserId", user.Id);
                HttpContext.Session.SetString("Username", user.UserName ?? "Kullanıcı");
                HttpContext.Session.SetString("UserEmail", user.Email ?? "");
                
                // Giriş yapan kullanıcı bilgilerini HttpContext'e ekle
                HttpContext.Items["UserId"] = user.Id;
                HttpContext.Items["Username"] = user.UserName;
                HttpContext.Items["UserEmail"] = user.Email;
                
                // Debug bilgisi
                Console.WriteLine($"Login Controller - Giriş başarılı! UserId: {user.Id}, Username: {user.UserName}, Email: {user.Email}");
                
                //// ViewBag yerine TempData kullanarak başarılı giriş mesajı ekle
                //TempData["SuccessMessage"] = "Başarıyla giriş yaptınız!";
                
                return RedirectToAction("Index", "Home");
            }
            else if (result.IsLockedOut)
            {
                _logger.LogWarning("Hesap kilitlendi: {Email}", username);
                TempData["ErrorMessage"] = "Hesabınız çok fazla başarısız deneme nedeniyle kilitlendi. Lütfen daha sonra tekrar deneyin.";
            }
            else
            {
                _logger.LogWarning("Başarısız giriş denemesi: {Email}", username);
                TempData["ErrorMessage"] = "E-posta veya şifre hatalı!";
            }
            
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Logout()
        {
            if (HttpContext.Items["UserId"] != null || !string.IsNullOrEmpty(HttpContext.Session.GetString("UserId")))
            {
                var userId = HttpContext.Items.ContainsKey("UserId") ? HttpContext.Items["UserId"] : HttpContext.Session.GetString("UserId");
                _logger.LogInformation("Kullanıcı çıkış yapıyor: {UserId}", userId);
            }
            
            // Identity ile çıkış yap
            await _signInManager.SignOutAsync();
            
            // JWT token içeren cookie'yi sil
            Response.Cookies.Delete("X-Access-Token");
            
            // Session'ı temizle
            HttpContext.Session.Clear();
            
            return RedirectToAction("Index", "Home");
        }
        
        // Kayıt olma sayfası
        public IActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Register(string username, string email, string password, string confirmPassword)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || 
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                TempData["ErrorMessage"] = "Tüm alanlar zorunludur!";
                return RedirectToAction("Register");
            }
            
            if (password != confirmPassword)
            {
                TempData["ErrorMessage"] = "Şifreler eşleşmiyor!";
                return RedirectToAction("Register");
            }
            
            var user = new ApplicationUser
            {
                UserName = username,
                Email = email,
                IsActive = true,
                CreateDate = DateTime.Now
            };
            
            var result = await _userManager.CreateAsync(user, password);
            
            if (result.Succeeded)
            {
                _logger.LogInformation("Yeni kullanıcı oluşturuldu: {UserId}, {UserEmail}", user.Id, user.Email);
                
                // Kullanıcıyı otomatik giriş yap
                await _signInManager.SignInAsync(user, isPersistent: false);
                
                // JWT token oluştur
                var token = _jwtService.GenerateJwtToken(user);
                
                // Token'ı cookie olarak ekle
                Response.Cookies.Append("X-Access-Token", token, new CookieOptions
                {
                    HttpOnly = true,
                    SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict,
                    Expires = System.DateTimeOffset.UtcNow.AddDays(7)
                });
                
                TempData["SuccessMessage"] = "Hesabınız başarıyla oluşturuldu!";
                return RedirectToAction("Index", "Home");
            }
            
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            
            TempData["ErrorMessage"] = "Kayıt olurken bir hata oluştu, lütfen formu kontrol edin.";
            return RedirectToAction("Register");
        }
    }
} 