using MarketWorld.Domain.Entities.Base;

namespace MarketWorld.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        
        public long OrderId { get; set; }
        public Order Order { get; set; }
        
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
} 