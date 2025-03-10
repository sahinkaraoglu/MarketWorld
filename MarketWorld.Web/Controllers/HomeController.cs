using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MarketWorld.Web.Models;
using MarketWorld.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Application.Services.Interfaces;

namespace MarketWorld.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly MarketWorldDbContext _context;
    private readonly ICategoryService _categoryService;

    public HomeController(ILogger<HomeController> logger, MarketWorldDbContext context = null, ICategoryService categoryService = null)
    {
        _logger = logger;
        _context = context;
        _categoryService = categoryService;
    }

    public async Task<IActionResult> Index()
    {
        // kategorileri sub kategorilerle beraber getir
        // viewcomponent olu�tur ve kategorileri oradan �a��r

        var categories = await _categoryService.GetCategoriesWithProductsAsync();
        return View(categories.ToList());
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
