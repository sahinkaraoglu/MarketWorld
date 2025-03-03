using MarketWorld.Domain.Entities.Base;
using System.Collections.Generic;

namespace MarketWorld.Domain.Entities
{
    public class Cart : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        
        public ICollection<CartItem> CartItems { get; set; }
        public decimal TotalAmount { get; set; }
    }
} 