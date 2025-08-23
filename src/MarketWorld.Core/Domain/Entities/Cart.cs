using MarketWorld.Core.Domain.Entities.Base;
using System.Collections.Generic;

namespace MarketWorld.Core.Domain.Entities
{
    public class Cart : BaseEntity
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        
        public ICollection<CartItem> CartItems { get; set; }
        public decimal TotalAmount { get; set; }
    }
} 