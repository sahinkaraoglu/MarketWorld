using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MarketWorld.Web.Models;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Application.Services.Interfaces;
using MarketWorld.Infrastructure.Context;

namespace MarketWorld.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ICategoryService _categoryService;

    public HomeController(ILogger<HomeController> logger, ICategoryService categoryService = null)
    {
        _logger = logger;
        _categoryService = categoryService;
    }

    public async Task<IActionResult> Index()
    {
        // kategorileri sub kategorilerle beraber getir
        // viewcomponent oluþtur ve kategorileri oradan çaðýr

        var categories = await _categoryService.GetCategoriesWithProductsAsync();
        return View(categories.ToList());
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
