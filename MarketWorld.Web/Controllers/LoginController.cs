using Microsoft.AspNetCore.Mvc;

namespace MarketWorld.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // TODO: Gerçek kimlik doğrulama işlemleri burada yapılacak
            // Şimdilik basit bir kontrol yapıyoruz
            if (username == "admin" && password == "123456")
            {
                // Başarılı giriş
                return RedirectToAction("Index", "Panel");
            }
            else
            {
                // Başarısız giriş
                TempData["ErrorMessage"] = "Kullanıcı adı veya parola hatalı!";
                return RedirectToAction("Index");
            }
        }
    }
} 