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

        // Ayakkabı özellik değerleri
        public static readonly PropertyValue[] DefaultPropertyValues = new[]
        {
            // Cinsiyet değerleri
            new PropertyValue { Id = 1, Value = "Erkek", PropertyTypeId = 1 },
            new PropertyValue { Id = 2, Value = "Kadın", PropertyTypeId = 1 },
            new PropertyValue { Id = 3, Value = "Unisex", PropertyTypeId = 1 },
            new PropertyValue { Id = 4, Value = "Çocuk", PropertyTypeId = 1 },

            // Materyal değerleri
            new PropertyValue { Id = 5, Value = "Deri", PropertyTypeId = 2 },
            new PropertyValue { Id = 6, Value = "Süet", PropertyTypeId = 2 },
            new PropertyValue { Id = 7, Value = "Kumaş", PropertyTypeId = 2 },
            new PropertyValue { Id = 8, Value = "Sentetik", PropertyTypeId = 2 },

            // Taban değerleri
            new PropertyValue { Id = 9, Value = "Ortopedik", PropertyTypeId = 3 },
            new PropertyValue { Id = 10, Value = "Normal", PropertyTypeId = 3 },
            new PropertyValue { Id = 11, Value = "Masajlı", PropertyTypeId = 3 },
            new PropertyValue { Id = 12, Value = "Hafif", PropertyTypeId = 3 },

            // Renk değerleri
            new PropertyValue { Id = 13, Value = "Siyah", PropertyTypeId = 4 },
            new PropertyValue { Id = 14, Value = "Beyaz", PropertyTypeId = 4 },
            new PropertyValue { Id = 15, Value = "Kahverengi", PropertyTypeId = 4 },
            new PropertyValue { Id = 16, Value = "Lacivert", PropertyTypeId = 4 },

            // Numara değerleri
            new PropertyValue { Id = 17, Value = "36", PropertyTypeId = 5 },
            new PropertyValue { Id = 18, Value = "37", PropertyTypeId = 5 },
            new PropertyValue { Id = 19, Value = "38", PropertyTypeId = 5 },
            new PropertyValue { Id = 20, Value = "39", PropertyTypeId = 5 },
            new PropertyValue { Id = 21, Value = "40", PropertyTypeId = 5 },
            new PropertyValue { Id = 22, Value = "41", PropertyTypeId = 5 },
            new PropertyValue { Id = 23, Value = "42", PropertyTypeId = 5 },
            new PropertyValue { Id = 24, Value = "43", PropertyTypeId = 5 },
            new PropertyValue { Id = 25, Value = "44", PropertyTypeId = 5 },
            new PropertyValue { Id = 26, Value = "45", PropertyTypeId = 5 }
        };
    }
} 