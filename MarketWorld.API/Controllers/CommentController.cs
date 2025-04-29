using MarketWorld.Application.Services.Interfaces;
using MarketWorld.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using MarketWorld.API.DTOs;
using AutoMapper;
using MarketWorld.Application.Services.Implementations;

namespace MarketWorld.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentController(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<CommentDto>>> GetAllComments()
        {
            var comments = await _commentService.GetAllComments();
            var commentDtos = _mapper.Map<IEnumerable<CommentDto>>(comments);
            return Ok(commentDtos);
        }

        [HttpGet("filter")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<CommentDto>>> GetCommentsByProductCode([FromQuery] int ProductCode)
        {
            var allComments = await _commentService.GetAllComments();
            var filteredComments = allComments.Where(p => p.ProductCode == ProductCode).ToList();

            var commentDtos = _mapper.Map<List<CommentDto>>(filteredComments);

            return Ok(commentDtos);
        }

        [HttpDelete("number/{ProductCode}")]
        [Authorize]
        public async Task<ActionResult> DeleteCommentByCode(int ProductCode)
        {
            try
            {
                var allComments = await _commentService.GetAllComments();
                var comment = allComments.FirstOrDefault(p => p.ProductCode == ProductCode);

                if (comment == null)
                    return NotFound($"Yorum Numarasý: {ProductCode} ile yorum bulunamadý.");

                await _commentService.DeleteComment(comment.Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Yorum silinirken bir hata oluþtu: {ex.Message}");
            }
        }
    }
}