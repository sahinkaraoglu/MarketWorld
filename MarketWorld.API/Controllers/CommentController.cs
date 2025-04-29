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
    }
}