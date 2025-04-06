using MarketWorld.Domain.Entities.Base;
using System.Collections.Generic;

namespace MarketWorld.Domain.Entities
{
    public class PropertyType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
        
        public ICollection<PropertyValue> PropertyValues { get; set; }
        public ICollection<ProductProperty> ProductProperties { get; set; }

        // Ayakkabı özellikleri
        public static readonly PropertyType[] DefaultPropertyTypes = new[]
        {
            new PropertyType { Id = 1, Name = "Cinsiyet", Description = "Ayakkabının cinsiyet tipi" },
            new PropertyType { Id = 2, Name = "Materyal", Description = "Ayakkabının yapıldığı materyal" },
            new PropertyType { Id = 3, Name = "Taban", Description = "Ayakkabı taban özellikleri" },
            new PropertyType { Id = 4, Name = "Renk", Description = "Ayakkabı rengi" },
            new PropertyType { Id = 5, Name = "Numara", Description = "Ayakkabı numarası" }
        };
    }
} 