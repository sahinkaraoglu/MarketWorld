using Microsoft.AspNetCore.Mvc;

namespace MarketWorld.Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Phones()
        {
            return View();
        }
    }
} 