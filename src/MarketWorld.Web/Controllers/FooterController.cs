using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MarketWorld.Web.Models;
using MarketWorld.Application.Services.Abstract;
using MarketWorld.Core.Domain.Entities;

namespace MarketWorld.Web.Controllers;

public class FooterController : Controller
{
    private readonly ILogger<FooterController> _logger;
    private readonly IOrderService _orderService;

    public FooterController(ILogger<FooterController> logger, IOrderService orderService)
    {
        _logger = logger;
        _orderService = orderService;
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
        
        var orders = await _orderService.GetAllOrdersAsync();
        var order = orders.FirstOrDefault(o => o.OrderNumber == orderNumber);

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
