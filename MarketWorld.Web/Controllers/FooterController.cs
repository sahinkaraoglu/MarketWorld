using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MarketWorld.Web.Models;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Context;

namespace MarketWorld.Web.Controllers;

public class FooterController : Controller
{
    private readonly ILogger<FooterController> _logger;
    private readonly MarketWorldDbContext _context;

    public FooterController(ILogger<FooterController> logger, MarketWorldDbContext context)
    {
        _logger = logger;
        _context = context;
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

    [HttpPost]
    public async Task<IActionResult> OrderTracking(string orderNumber)
    {
        if (string.IsNullOrEmpty(orderNumber))
        {
            TempData["Error"] = "Lütfen bir sipariş numarası giriniz.";
            return View();
        }
        
        var order = await _context.Orders
            .Include(o => o.OrderItems)
            .FirstOrDefaultAsync(o => o.OrderNumber == orderNumber);

        if (order == null)
        {
            TempData["Error"] = "Sipariş bulunamadı. Lütfen numarayı kontrol edip tekrar deneyiniz.";
            return View();
        }

        return View("OrderTrackingResult", order);
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
