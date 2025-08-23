using Microsoft.AspNetCore.Mvc;
using MarketWorld.Application.Services.Abstract;
using MarketWorld.Comment.API.DTOs;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using System.Security.Claims;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Comment.API.Mappings;

namespace MarketWorld.Comment.API.Controllers
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
        public async Task<IActionResult> GetProductComments(int productId, [FromQuery] int page = 1, [FromQuery] int pageSize = 20)
        {
            var comments = await _commentService.GetCommentsByProductIdAsync(productId);
            var commentDtos = _mapper.Map<List<CommentDto>>(comments);
            return Ok(commentDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommentById(int id)
        {
            var comment = await _commentService.GetByIdAsync(id);
            if (comment == null)
                return NotFound("Yorum bulunamadı");

            var commentDto = _mapper.Map<CommentDto>(comment);
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

            // userId'yi int'e çevir
            if (!int.TryParse(userId, out int userIdInt))
                return BadRequest("Geçersiz kullanıcı ID");

            var comment = new MarketWorld.Core.Domain.Entities.Comment
            {
                ProductId = request.ProductId,
                UserId = userIdInt,
                Text = request.Content,
                Rating = request.Rating
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
            if (existingComment.UserId.ToString() != userId && !User.IsInRole("Admin"))
                return Forbid();

            existingComment.Text = request.Content;
            existingComment.Rating = request.Rating;

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
            if (comment.UserId.ToString() != userId && !User.IsInRole("Admin"))
                return Forbid();

            await _commentService.DeleteAsync(comment);
            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("admin/all")]
        public async Task<IActionResult> GetAllComments([FromQuery] int page = 1, [FromQuery] int pageSize = 20)
        {
            var comments = await _commentService.GetAllAsync();
            var commentDtos = _mapper.Map<List<CommentDto>>(comments);
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

            await _commentService.UpdateAsync(comment);
            return Ok("Yorum onaylandı");
        }
    }
}
