using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MarketWorld.Web.Models;

namespace MarketWorld.Web.Controllers;

public class FooterController : Controller
{
    private readonly ILogger<FooterController> _logger;

    public FooterController(ILogger<FooterController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
    public IActionResult Career()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Blog()
    {
        return View();
    }
    public IActionResult OrderTracking()
    {
        return View();
    }
    public IActionResult ReturnAndExchange()
    {
        return View();
    }
    public IActionResult Faq()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
