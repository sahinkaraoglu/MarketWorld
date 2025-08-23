using MarketWorld.Core.Domain.Entities;
using MarketWorld.Core.Enums;
using MarketWorld.Web.Attributes;
using MarketWorld.Web.Areas.Admin.Models.Panel;
using MarketWorld.Application.Services.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace MarketWorld.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(
            IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index(int page = 1, int pageSize = 10)
        {
            try
            {
                var orders = await _orderService.GetAllOrdersAsync();
                
                // Toplam sipariş sayısını hesapla
                var totalOrders = orders.Count();
                var totalPages = (int)Math.Ceiling(totalOrders / (double)pageSize);

                // Siparişleri sayfalayarak getir
                var pagedOrders = orders
                    .OrderByDescending(o => o.CreatedDate)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                // Sayfalama bilgilerini ViewBag'e ekle
                ViewBag.CurrentPage = page;
                ViewBag.TotalPages = totalPages;
                ViewBag.PageSize = pageSize;
                ViewBag.TotalOrders = totalOrders;

                return View(pagedOrders);
            }
            catch (Exception ex)
            {
                return View(new List<Order>());
            }
        }

        [HttpGet]
        [Route("Orders")]
        public async Task<IActionResult> Orders(int? status = null)
        {
            try
            {
                var orders = await _orderService.GetOrdersByStatusAsync(status.HasValue ? (OrderStatus)status.Value : null);
                return View("Order/Index", orders);
            }
            catch (Exception ex)
            {
                return View("Order/Index", new List<Order>());
            }
        }

        [HttpGet]
        [Route("GetOrderStatus/{id}")]
        public async Task<IActionResult> GetOrderStatus(int id)
        {
            try
            {
                var order = await _orderService.GetOrderByIdAsync(id);
                return Json(new { success = true, status = (int)order.Status });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpGet]
        [Route("Edit/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var order = await _orderService.GetOrderByIdAsync(id);
                if (order == null)
                {
                    return NotFound();
                }
                return View(order);
            }
            catch (Exception ex)
            {
                return View("Error", ex.Message);
            }
        }

        [HttpPost]
        [Route("UpdateOrderStatus")]
        public async Task<IActionResult> UpdateOrderStatus(int orderId, int status, string note)
        {
            try
            {
                await _orderService.UpdateOrderStatusAsync(orderId, (OrderStatus)status, note);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpGet]
        [Route("PrintOrder/{id}")]
        public async Task<IActionResult> PrintOrder(int id)
        {
            try
            {
                var order = await _orderService.GetOrderWithDetailsAsync(id);
                return View("PrintOrder", order);
            }
            catch (Exception ex)
            {
                return View("Error", ex.Message);
            }
        }
    }
}