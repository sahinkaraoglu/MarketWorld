using MarketWorld.Domain.Entities;
using System;

namespace MarketWorld.API.DTOs
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public bool IsApproved { get; set; } = false;
        public int ProductId { get; set; }
        public int ProductCode { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
    }
} 