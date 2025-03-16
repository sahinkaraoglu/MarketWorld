using MarketWorld.Domain.Entities;
using System;
using System.Collections.Generic;

namespace MarketWorld.Infrastructure.Data.SeedData
{
    public static class PropertySeedData
    {
        public static List<PropertyType> GetPropertyTypes()
        {
            return new List<PropertyType>
            {
                new PropertyType
                {
                    Id = 1,
                    Name = "Renk",
                    Description = "Ürün Renk Seçenekleri",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new PropertyType
                {
                    Id = 2,
                    Name = "Beden",
                    Description = "Beden Seçenekleri",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new PropertyType
                {
                    Id = 3,
                    Name = "Hafıza",
                    Description = "Dahili Hafıza",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                }
            };
        }

        public static List<PropertyValue> GetPropertyValues()
        {
            return new List<PropertyValue>
            {
                new PropertyValue { Id = 1, PropertyTypeId = 1, Value = "Uzay Siyahı", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 2, PropertyTypeId = 1, Value = "Altın", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 3, PropertyTypeId = 1, Value = "Gümüş", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 4, PropertyTypeId = 1, Value = "Mor", CreatedDate = DateTime.Now },

                new PropertyValue { Id = 5, PropertyTypeId = 2, Value = "XS", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 6, PropertyTypeId = 2, Value = "S", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 7, PropertyTypeId = 2, Value = "M", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 8, PropertyTypeId = 2, Value = "L", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 9, PropertyTypeId = 2, Value = "XL", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 10, PropertyTypeId = 2, Value = "XXL", CreatedDate = DateTime.Now },

                new PropertyValue { Id = 11, PropertyTypeId = 3, Value = "128GB", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 12, PropertyTypeId = 3, Value = "256GB", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 13, PropertyTypeId = 3, Value = "512GB", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 14, PropertyTypeId = 3, Value = "1TB", CreatedDate = DateTime.Now }
            };
        }

        public static List<ProductProperty> GetProductProperties()
        {
            return new List<ProductProperty>
            {
                // iPhone 14 Pro için Renk-Hafıza kombinasyonları (ProductId = 1 varsayılarak)
                
                // 128GB Seçenekleri
                new ProductProperty { Id = 1, ProductId = 1, PropertyTypeId = 1, PropertyValueId = 1, Stock = 50, IsActive = true, CreatedDate = DateTime.Now }, // Uzay Siyahı
                new ProductProperty { Id = 2, ProductId = 1, PropertyTypeId = 1, PropertyValueId = 2, Stock = 45, IsActive = true, CreatedDate = DateTime.Now }, // Altın
                new ProductProperty { Id = 3, ProductId = 1, PropertyTypeId = 1, PropertyValueId = 3, Stock = 40, IsActive = true, CreatedDate = DateTime.Now }, // Gümüş
                new ProductProperty { Id = 4, ProductId = 1, PropertyTypeId = 1, PropertyValueId = 4, Stock = 35, IsActive = true, CreatedDate = DateTime.Now }, // Mor
                new ProductProperty { Id = 5, ProductId = 1, PropertyTypeId = 2, PropertyValueId = 5, Stock = 100, IsActive = true, CreatedDate = DateTime.Now }, // 128GB

                // 256GB Seçenekleri
                new ProductProperty { Id = 6, ProductId = 1, PropertyTypeId = 2, PropertyValueId = 6, Stock = 75, IsActive = true, CreatedDate = DateTime.Now }, // 256GB

                // 512GB Seçenekleri
                new ProductProperty { Id = 7, ProductId = 1, PropertyTypeId = 2, PropertyValueId = 7, Stock = 50, IsActive = true, CreatedDate = DateTime.Now }, // 512GB

                // 1TB Seçenekleri
                new ProductProperty { Id = 8, ProductId = 1, PropertyTypeId = 2, PropertyValueId = 8, Stock = 25, IsActive = true, CreatedDate = DateTime.Now }  // 1TB
            };
        }
    }
} 