using MarketWorld.Domain.Entities.Base;

namespace MarketWorld.Domain.Entities
{
    public class CartItem : BaseEntity
    {
        public int Quantity { get; set; }
        
        public long CartId { get; set; }
        public Cart Cart { get; set; }
        
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
} 