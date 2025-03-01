using MarketWorld.Domain.Entities.Base;
using System.Collections.Generic;

namespace MarketWorld.Domain.Entities
{
    public class Cart : BaseEntity
    {
        public long UserId { get; set; }
        public User User { get; set; }
        
        public ICollection<CartItem> CartItems { get; set; }
    }
} 