using Microsoft.AspNetCore.Mvc;
using MarketWorld.Application.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using MarketWorld.Core.Domain.Entities;
using System.Security.Claims;

namespace MarketWorld.Order.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly ICartService _cartService;

        public OrderController(IOrderService orderService, ICartService cartService)
        {
            _orderService = orderService;
            _cartService = cartService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserOrders()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var orders = await _orderService.GetOrdersByUserIdAsync(userId);
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var order = await _orderService.GetByIdAsync(id);
            if (order == null)
                return NotFound("Sipariş bulunamadı");

            // Kullanıcının kendi siparişini görüntüleyebilmesi için kontrol
            if (order.UserId != userId && !User.IsInRole("Admin"))
                return Forbid();

            return Ok(order);
        }

        [HttpPost("checkout")]
        public async Task<IActionResult> Checkout([FromBody] CheckoutRequest request)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var order = await _orderService.CreateOrderFromCartAsync(userId, request.ShippingAddressId, request.PaymentMethod);
                return CreatedAtAction(nameof(GetOrderById), new { id = order.Id }, order);
            }
            catch (Exception ex)
            {
                return BadRequest($"Sipariş oluşturulamadı: {ex.Message}");
            }
        }

        [HttpPost("{id}/cancel")]
        public async Task<IActionResult> CancelOrder(int id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var order = await _orderService.GetByIdAsync(id);
            if (order == null)
                return NotFound("Sipariş bulunamadı");

            if (order.UserId != userId && !User.IsInRole("Admin"))
                return Forbid();

            await _orderService.CancelOrderAsync(id);
            return Ok("Sipariş iptal edildi");
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}/status")]
        public async Task<IActionResult> UpdateOrderStatus(int id, [FromBody] UpdateOrderStatusRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _orderService.UpdateOrderStatusAsync(id, request.Status);
            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("admin/all")]
        public async Task<IActionResult> GetAllOrders([FromQuery] int page = 1, [FromQuery] int pageSize = 20)
        {
            var orders = await _orderService.GetAllOrdersAsync(page, pageSize);
            return Ok(orders);
        }
    }

    public class CheckoutRequest
    {
        public int ShippingAddressId { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
    }

    public class UpdateOrderStatusRequest
    {
        public MarketWorld.Core.Enums.OrderStatus Status { get; set; }
    }
}
