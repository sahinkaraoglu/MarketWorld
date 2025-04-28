using MarketWorld.Domain.Entities.Base;
using System;

namespace MarketWorld.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string Text { get; set; }
        public int Rating { get; set; }
        public bool IsApproved { get; set; } = false;
        
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        public int ProductCode { get; set; }
        
        public int? UserId { get; set; }
        public string UserName { get; set; }
    }
} 