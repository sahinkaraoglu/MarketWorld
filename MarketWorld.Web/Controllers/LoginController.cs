using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Data;

namespace MarketWorld.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly MarketWorldDbContext _context;

        public LoginController(MarketWorldDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Kullanıcı giriş yapmışsa Anasayfaya yönlendir
            if (HttpContext.Session.GetInt32("UserId").HasValue)
            {
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
                // Kullanıcı girişi başarılı
                HttpContext.Session.SetInt32("UserId", user.Id);
                HttpContext.Session.SetString("UserEmail", user.Email);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["ErrorMessage"] = "E-posta veya şifre hatalı!";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
} 