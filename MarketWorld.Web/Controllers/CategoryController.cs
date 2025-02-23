using Microsoft.AspNetCore.Mvc;
using MarketWorld.Domain.Entities;

namespace MarketWorld.Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
} 