using MarketWorld.Domain.Entities.Base;
using System.Collections.Generic;

namespace MarketWorld.Domain.Entities
{
    public class Products : BaseEntity
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; } = true;
        public string Description { get; set; }
        public decimal DiscountPrice { get; set; }
        public bool HasDiscount { get; set; } = false;
        public string Images { get; set; }
        
        public SubCategories? SubCategory { get; set; }
        
        public ICollection<OrderItem>? OrderItems { get; set; }
        public ICollection<CartItem>? CartItems { get; set; }
    }
}
