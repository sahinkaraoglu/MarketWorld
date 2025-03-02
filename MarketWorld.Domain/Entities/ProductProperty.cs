using MarketWorld.Domain.Entities.Base;

namespace MarketWorld.Domain.Entities
{
    public class ProductProperty : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        public int PropertyTypeId { get; set; }
        public PropertyType PropertyType { get; set; }
        
        public int PropertyValueId { get; set; }
        public PropertyValue PropertyValue { get; set; }
        
        public int Stock { get; set; }
        public bool IsActive { get; set; } = true;
    }
} 