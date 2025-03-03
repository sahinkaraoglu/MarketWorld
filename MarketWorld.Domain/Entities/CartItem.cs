using MarketWorld.Domain.Entities.Base;

namespace MarketWorld.Domain.Entities
{
    public class CartItem : BaseEntity
    {
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
} 