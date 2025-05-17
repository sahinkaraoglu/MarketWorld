using MarketWorld.Domain.Entities.Base;
using System.Collections.Generic;

namespace MarketWorld.Domain.Entities
{
    public class PropertyValue : BaseEntity
    {
        public string Value { get; set; }
        public bool IsActive { get; set; } = true;
        
        public int PropertyTypeId { get; set; }
        public PropertyType PropertyType { get; set; }
        
        public ICollection<ProductProperty> ProductProperties { get; set; }
    }
} 