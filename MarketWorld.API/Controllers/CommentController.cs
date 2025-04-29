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

        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<CommentDto>> UpdateComment(int id, [FromBody] CommentDto commentDto)
        {
            if (commentDto == null)
                return BadRequest("Yorum verisi boş olamaz.");

            if (id != commentDto.Id)
                return BadRequest("Yorum ID'si eşleşmiyor.");

            try
            {
                var existingComment = await _commentService.GetCommentById(id);
                if (existingComment == null)
                    return NotFound($"ID: {id} ile yorum bulunamadı.");

                _mapper.Map(commentDto, existingComment);

                await _commentService.UpdateComment(existingComment);
                return Ok(_mapper.Map<CommentDto>(existingComment));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Yorum güncellenirken bir hata oluştu: {ex.Message}");
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CommentDto>> CreateComment([FromBody] CommentDto commentDto)
        {
            if (commentDto == null)
                return BadRequest("Yorum verisi boş olamaz.");

            try
            {
                var comment = _mapper.Map<Comment>(commentDto);
                var createdComment = await _commentService.CreateComment(comment);
                var createdCommentDto = _mapper.Map<CommentDto>(createdComment);
                return CreatedAtAction(nameof(GetAllComments), new { id = createdComment.Id }, createdCommentDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Yorum oluşturulurken bir hata oluştu: {ex.Message}");
            }
        }

        [HttpDelete("{Id}")]
        [Authorize]
        public async Task<ActionResult> DeleteCommentById(int Id)
        {
            try
            {
                var allComments = await _commentService.GetAllComments();
                var comment = allComments.FirstOrDefault(p => p.Id == Id);

                if (comment == null)
                    return NotFound($"Yorum Numarası: {Id} ile yorum bulunamadı.");

                await _commentService.DeleteComment(comment.Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Yorum silinirken bir hata oluştu: {ex.Message}");
            }
        }
    }
}