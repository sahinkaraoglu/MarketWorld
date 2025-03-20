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
            var productProperties = new List<ProductProperty>();
            int id = 1;

            for (int productId = 1; productId <= 10; productId++)
            {
                for (int colorId = 1; colorId <= 4; colorId++)
                {
                    productProperties.Add(new ProductProperty
                    {
                        Id = id++,
                        ProductId = productId,
                        PropertyTypeId = 1,
                        PropertyValueId = colorId,
                        Stock = 50,
                        IsActive = true,
                        CreatedDate = DateTime.Now
                    });
                }

                for (int memoryId = 11; memoryId <= 14; memoryId++)
                {
                    productProperties.Add(new ProductProperty
                    {
                        Id = id++,
                        ProductId = productId,
                        PropertyTypeId = 3, 
                        PropertyValueId = memoryId,
                        Stock = 75,
                        IsActive = true,
                        CreatedDate = DateTime.Now
                    });
                }
            }

            return productProperties;
        }
    }
} 