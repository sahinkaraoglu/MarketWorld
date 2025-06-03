using MarketWorld.Core.Domain.Entities;
using MarketWorld.Core.Enums;
using MarketWorld.Web.Attributes;
using MarketWorld.Web.Areas.Admin.Models.Panel;
using MarketWorld.Application.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Index()
        {
            var orders = await _orderService.GetAllOrdersAsync();
            return View(orders);
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

        [HttpPost]
        [Route("UpdateOrderStatus")]
        public async Task<IActionResult> UpdateOrderStatus(int orderId, int status, string note)
        {
            try
            {
                var order = await _orderService.UpdateOrderStatusAsync(orderId, (OrderStatus)status);
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