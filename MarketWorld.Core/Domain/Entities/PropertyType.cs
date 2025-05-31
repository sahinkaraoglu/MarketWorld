using MarketWorld.Core.Domain.Entities.Base;
using System.Collections.Generic;

namespace MarketWorld.Core.Domain.Entities
{
    public class PropertyType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
        
        public ICollection<PropertyValue> PropertyValues { get; set; }
        public ICollection<ProductProperty> ProductProperties { get; set; }
    }
} 