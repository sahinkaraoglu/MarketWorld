using Microsoft.AspNetCore.Mvc;
using MarketWorld.Application.Services.Abstract;
using MarketWorld.API.DTOs;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using AutoMapper;

namespace MarketWorld.Review.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentController(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }

        [HttpGet("product/{productId}")]
        public async Task<IActionResult> GetProductComments(int productId)
        {
            var comments = await _commentService.GetCommentsByProductIdAsync(productId);
            var commentDtos = _mapper.Map<List<CommentDTO>>(comments);
            return Ok(commentDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommentById(int id)
        {
            var comment = await _commentService.GetByIdAsync(id);
            if (comment == null)
                return NotFound("Yorum bulunamadı");

            var commentDto = _mapper.Map<CommentDTO>(comment);
            return Ok(commentDto);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateComment([FromBody] CreateCommentRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var comment = new MarketWorld.Core.Domain.Entities.Comment
            {
                ProductId = request.ProductId,
                UserId = userId,
                Content = request.Content,
                Rating = request.Rating,
                CreatedDate = DateTime.UtcNow
            };

            await _commentService.AddAsync(comment);
            return CreatedAtAction(nameof(GetCommentById), new { id = comment.Id }, comment);
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateComment(int id, [FromBody] UpdateCommentRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var existingComment = await _commentService.GetByIdAsync(id);
            if (existingComment == null)
                return NotFound("Yorum bulunamadı");

            // Kullanıcının kendi yorumunu düzenleyebilmesi için kontrol
            if (existingComment.UserId != userId && !User.IsInRole("Admin"))
                return Forbid();

            existingComment.Content = request.Content;
            existingComment.Rating = request.Rating;
            existingComment.UpdatedDate = DateTime.UtcNow;

            await _commentService.UpdateAsync(existingComment);
            return NoContent();
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var comment = await _commentService.GetByIdAsync(id);
            if (comment == null)
                return NotFound("Yorum bulunamadı");

            // Kullanıcının kendi yorumunu silebilmesi için kontrol
            if (comment.UserId != userId && !User.IsInRole("Admin"))
                return Forbid();

            await _commentService.DeleteAsync(comment);
            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("admin/all")]
        public async Task<IActionResult> GetAllComments([FromQuery] int page = 1, [FromQuery] int pageSize = 20)
        {
            var comments = await _commentService.GetAllAsync();
            var commentDtos = _mapper.Map<List<CommentDTO>>(comments);
            return Ok(commentDtos);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("{id}/approve")]
        public async Task<IActionResult> ApproveComment(int id)
        {
            var comment = await _commentService.GetByIdAsync(id);
            if (comment == null)
                return NotFound("Yorum bulunamadı");

            comment.IsApproved = true;
            comment.UpdatedDate = DateTime.UtcNow;

            await _commentService.UpdateAsync(comment);
            return Ok("Yorum onaylandı");
        }
    }

    public class CreateCommentRequest
    {
        public int ProductId { get; set; }
        public string Content { get; set; } = string.Empty;
        public int Rating { get; set; }
    }

    public class UpdateCommentRequest
    {
        public string Content { get; set; } = string.Empty;
        public int Rating { get; set; }
    }
}
