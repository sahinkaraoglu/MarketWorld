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
                },
                new PropertyType
                {
                    Id = 4,
                    Name = "İşlemci",
                    Description = "Bilgisayar İşlemci Seçenekleri",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new PropertyType
                {
                    Id = 5,
                    Name = "RAM",
                    Description = "Bellek Kapasitesi",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new PropertyType
                {
                    Id = 6,
                    Name = "SSD",
                    Description = "SSD Kapasitesi",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new PropertyType
                {
                    Id = 7,
                    Name = "Ekran",
                    Description = "Ekran Boyutu",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new PropertyType
                {
                    Id = 8,
                    Name = "Yazıcı Tipi",
                    Description = "Yazıcı Teknolojisi",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new PropertyType
                {
                    Id = 9,
                    Name = "Mürekkep Sistemi",
                    Description = "Mürekkep/Kartuş Sistemi",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new PropertyType
                {
                    Id = 10,
                    Name = "Kağıt Boyutu",
                    Description = "Desteklenen Kağıt Boyutları",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new PropertyType
                {
                    Id = 11,
                    Name = "Fonksiyonlar",
                    Description = "Yazıcı Fonksiyonları",
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
                new PropertyValue { Id = 14, PropertyTypeId = 3, Value = "1TB", CreatedDate = DateTime.Now },

                new PropertyValue { Id = 15, PropertyTypeId = 4, Value = "Intel Core i7 12700H", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 16, PropertyTypeId = 4, Value = "Intel Core i7 1255U", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 17, PropertyTypeId = 4, Value = "Intel Core i7 13620H", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 18, PropertyTypeId = 4, Value = "Intel Core i5 1334U", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 19, PropertyTypeId = 4, Value = "Intel Core i5 13420H", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 20, PropertyTypeId = 4, Value = "AMD Ryzen 7 5700U", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 21, PropertyTypeId = 4, Value = "Intel Core i5 12450H", CreatedDate = DateTime.Now },

                new PropertyValue { Id = 22, PropertyTypeId = 5, Value = "8GB", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 23, PropertyTypeId = 5, Value = "16GB", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 24, PropertyTypeId = 5, Value = "32GB", CreatedDate = DateTime.Now },

                new PropertyValue { Id = 25, PropertyTypeId = 6, Value = "256GB", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 26, PropertyTypeId = 6, Value = "500GB", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 27, PropertyTypeId = 6, Value = "512GB", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 28, PropertyTypeId = 6, Value = "1TB", CreatedDate = DateTime.Now },

                new PropertyValue { Id = 29, PropertyTypeId = 7, Value = "14\"", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 30, PropertyTypeId = 7, Value = "15.6\"", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 31, PropertyTypeId = 7, Value = "16\"", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 32, PropertyTypeId = 4, Value = "Intel Core i7 13650HX", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 33, PropertyTypeId = 4, Value = "Intel Core i5 13500H", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 34, PropertyTypeId = 4, Value = "Intel Core i9-14900HX", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 35, PropertyTypeId = 4, Value = "Intel Core Ultra 7 255HX", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 36, PropertyTypeId = 4, Value = "AMD Ryzen 5 7520U", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 37, PropertyTypeId = 8, Value = "Mürekkep Püskürtmeli", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 38, PropertyTypeId = 8, Value = "Lazer", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 39, PropertyTypeId = 8, Value = "Süblimasyon", CreatedDate = DateTime.Now },

                new PropertyValue { Id = 40, PropertyTypeId = 9, Value = "Kartuşlu", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 41, PropertyTypeId = 9, Value = "Tanklı", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 42, PropertyTypeId = 9, Value = "Dolum Üniteli", CreatedDate = DateTime.Now },

                new PropertyValue { Id = 43, PropertyTypeId = 10, Value = "A4", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 44, PropertyTypeId = 10, Value = "A3", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 45, PropertyTypeId = 10, Value = "A4/A3", CreatedDate = DateTime.Now },

                new PropertyValue { Id = 46, PropertyTypeId = 11, Value = "Yazdırma", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 47, PropertyTypeId = 11, Value = "Tarama", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 48, PropertyTypeId = 11, Value = "Fotokopi", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 49, PropertyTypeId = 11, Value = "Faks", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 50, PropertyTypeId = 11, Value = "Wi-Fi", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 51, PropertyTypeId = 11, Value = "AirPrint", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 52, PropertyTypeId = 1, Value = "Siyah", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 53, PropertyTypeId = 1, Value = "Beyaz", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 54, PropertyTypeId = 1, Value = "Gri", CreatedDate = DateTime.Now }
            };
        }

        public static List<ProductProperty> GetProductProperties()
        {
            var productProperties = new List<ProductProperty>();
            int id = 1;

            // Laptoplar için özellikler (1-31 arası ürünler)
            for (int productId = 1; productId <= 31; productId++)
            {
                // Renk seçenekleri
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

                // İşlemci özelliği
                productProperties.Add(new ProductProperty
                {
                    Id = id++,
                    ProductId = productId,
                    PropertyTypeId = 4,
                    PropertyValueId = GetProcessorValueId(productId),
                    Stock = 50,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                });

                // RAM özelliği
                productProperties.Add(new ProductProperty
                {
                    Id = id++,
                    ProductId = productId,
                    PropertyTypeId = 5,
                    PropertyValueId = GetRamValueId(productId),
                    Stock = 50,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                });

                // SSD özelliği
                productProperties.Add(new ProductProperty
                {
                    Id = id++,
                    ProductId = productId,
                    PropertyTypeId = 6,
                    PropertyValueId = GetSsdValueId(productId),
                    Stock = 50,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                });

                // Ekran özelliği
                productProperties.Add(new ProductProperty
                {
                    Id = id++,
                    ProductId = productId,
                    PropertyTypeId = 7,
                    PropertyValueId = GetScreenValueId(productId),
                    Stock = 50,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                });
            }

            // Yazıcılar için özellikler (32-73 arası ürünler)
            for (int productId = 32; productId <= 73; productId++)
            {
                // Renk seçenekleri
                for (int colorId = 52; colorId <= 54; colorId++)
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

                // Yazıcı tipi
                productProperties.Add(new ProductProperty
                {
                    Id = id++,
                    ProductId = productId,
                    PropertyTypeId = 8,
                    PropertyValueId = GetPrinterTypeValueId(productId),
                    Stock = 50,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                });

                // Mürekkep sistemi
                productProperties.Add(new ProductProperty
                {
                    Id = id++,
                    ProductId = productId,
                    PropertyTypeId = 9,
                    PropertyValueId = GetInkSystemValueId(productId),
                    Stock = 50,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                });

                // Kağıt boyutu
                productProperties.Add(new ProductProperty
                {
                    Id = id++,
                    ProductId = productId,
                    PropertyTypeId = 10,
                    PropertyValueId = GetPaperSizeValueId(productId),
                    Stock = 50,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                });

                // Fonksiyonlar
                var functionIds = GetFunctionValueIds(productId);
                foreach (var functionId in functionIds)
                {
                    productProperties.Add(new ProductProperty
                    {
                        Id = id++,
                        ProductId = productId,
                        PropertyTypeId = 11,
                        PropertyValueId = functionId,
                        Stock = 50,
                        IsActive = true,
                        CreatedDate = DateTime.Now
                    });
                }
            }

            return productProperties;
        }

        private static int GetProcessorValueId(int productId)
        {
            return productId switch
            {
                1 => 15, // Intel Core i7 12700H
                2 => 16, // Intel Core i7 1255U
                3 => 17, // Intel Core i7 13620H
                4 => 17, // Intel Core i7 13620H
                5 => 18, // Intel Core i5 1334U
                6 => 19, // Intel Core i5 13420H
                7 => 20, // AMD Ryzen 7 5700U
                8 => 21, // Intel Core i5 12450H
                9 => 16, // Intel Core i7 1255U
                10 => 32, // Intel Core i7 13650HX
                11 => 21, // Intel Core i5 12450H
                12 => 36, // AMD Ryzen 5 7430U
                13 => 16, // Intel Core i7 1255U
                14 => 15, // Intel Core i7 12700H
                15 => 19, // Intel Core i5 13420H
                16 => 15, // Intel Core i7 12700H
                17 => 33, // Intel Core i5 13500H
                18 => 21, // Intel Core i5 12450H
                19 => 21, // Intel Core i5 12450H
                20 => 16, // Intel Core i7 1255U
                21 => 19, // Intel Core i5 13420H
                22 => 19, // Intel Core i5 13420H
                23 => 35, // Intel Core Ultra 7 255HX
                24 => 19, // Intel Core i5 13420H
                25 => 34, // Intel Core i9-14900HX
                26 => 17, // Intel Core i7 13620H
                27 => 19, // Intel Core i5 13420H
                28 => 36, // AMD Ryzen 5 7520U
                29 => 19, // Intel Core i5 13420H
                30 => 16, // Intel Core i7 1255U
                31 => 21, // Intel Core i5 12450H
                _ => 15
            };
        }

        private static int GetRamValueId(int productId)
        {
            return productId switch
            {
                1 => 24, // 32GB
                2 => 23, // 16GB
                3 => 24, // 32GB
                4 => 24, // 32GB
                5 => 23, // 16GB
                6 => 23, // 16GB
                7 => 23, // 16GB
                8 => 22, // 8GB
                9 => 23, // 16GB
                10 => 24, // 32GB
                11 => 24, // 32GB
                12 => 23, // 16GB
                13 => 23, // 16GB
                14 => 24, // 32GB
                15 => 24, // 32GB
                16 => 24, // 32GB
                17 => 24, // 32GB
                18 => 23, // 16GB
                19 => 22, // 8GB
                20 => 22, // 8GB
                21 => 23, // 16GB
                22 => 23, // 16GB
                23 => 23, // 16GB
                24 => 24, // 32GB
                25 => 24, // 32GB
                26 => 24, // 32GB
                27 => 23, // 16GB
                28 => 23, // 16GB
                29 => 22, // 8GB
                30 => 24, // 32GB
                31 => 23, // 16GB
                _ => 23
            };
        }

        private static int GetSsdValueId(int productId)
        {
            return productId switch
            {
                1 => 28, // 1TB
                2 => 27, // 512GB
                3 => 28, // 1TB
                4 => 28, // 1TB
                5 => 27, // 512GB
                6 => 27, // 512GB
                7 => 27, // 512GB
                8 => 27, // 512GB
                9 => 26, // 500GB
                10 => 28, // 1TB
                11 => 26, // 500GB
                12 => 26, // 500GB
                13 => 27, // 512GB
                14 => 28, // 1TB
                15 => 26, // 500GB
                16 => 28, // 1TB
                17 => 28, // 1TB
                18 => 28, // 1TB
                19 => 27, // 512GB
                20 => 27, // 512GB
                21 => 12, // 256GB
                22 => 28, // 1TB
                23 => 27, // 512GB
                24 => 28, // 1TB
                25 => 26, // 500GB
                26 => 28, // 1TB
                27 => 26, // 500GB
                28 => 28, // 1TB
                29 => 27, // 512GB
                30 => 28, // 1TB
                31 => 12, // 256GB
                _ => 27
            };
        }

        private static int GetScreenValueId(int productId)
        {
            return productId switch
            {
                2 => 29, // 14"
                3 => 31, // 16"
                6 => 31, // 16"
                7 => 30, // 15.6"
                8 => 30, // 15.6"
                9 => 30, // 15.6"
                10 => 30, // 15.6"
                11 => 30, // 15.6"
                12 => 30, // 15.6"
                13 => 30, // 15.6"
                14 => 30, // 15.6"
                15 => 30, // 15.6"
                16 => 30, // 15.6"
                17 => 30, // 15.6"
                18 => 30, // 15.6"
                19 => 30, // 15.6"
                20 => 30, // 15.6"
                21 => 29, // 13"
                22 => 30, // 15.6"
                23 => 29, // 14"
                24 => 31, // 16"
                25 => 30, // 15.6"
                26 => 31, // 16"
                27 => 30, // 15.6"
                28 => 30, // 15.6"
                29 => 30, // 15.6"
                30 => 30, // 15.6"
                31 => 29, // 13"
                _ => 30
            };
        }

        private static int GetPrinterTypeValueId(int productId)
        {
            // Ürün ID'sine göre yazıcı tipini belirle
            if (productId >= 32 && productId <= 73)
            {
                return 37; // Mürekkep Püskürtmeli
            }
            return 38; // Lazer
        }

        private static int GetInkSystemValueId(int productId)
        {
            // Ürün ID'sine göre mürekkep sistemini belirle
            if (productId >= 32 && productId <= 73)
            {
                return 40; // Kartuşlu
            }
            return 41; // Tanklı
        }

        private static int GetPaperSizeValueId(int productId)
        {
            // Ürün ID'sine göre kağıt boyutunu belirle
            if (productId >= 32 && productId <= 73)
            {
                return 43; // A4
            }
            return 44; // A3
        }

        private static List<int> GetFunctionValueIds(int productId)
        {
            var functionIds = new List<int> { 46 }; // Tüm yazıcılar yazdırma yapabilir

            // Tarama özelliği
            if (productId >= 32 && productId <= 73)
            {
                functionIds.Add(47); // Tarama
                functionIds.Add(48); // Fotokopi
            }

            // Wi-Fi özelliği
            if (productId >= 32 && productId <= 73)
            {
                functionIds.Add(50); // Wi-Fi
            }

            // AirPrint özelliği
            if (productId >= 32 && productId <= 73)
            {
                functionIds.Add(51); // AirPrint
            }

            return functionIds;
        }
    }
} 