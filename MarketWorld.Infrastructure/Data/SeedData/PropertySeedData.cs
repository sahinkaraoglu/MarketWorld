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
                new PropertyValue { Id = 51, PropertyTypeId = 11, Value = "AirPrint", CreatedDate = DateTime.Now }
            };
        }

        public static List<ProductProperty> GetProductProperties()
        {
            var productProperties = new List<ProductProperty>();
            int id = 81;

            // Telefonlar için özellikler (1-10 arası ürünler)
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

            // Bilgisayarlar için özellikler (11-42 arası ürünler)
            for (int productId = 11; productId <= 42; productId++)
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

                // Hafıza seçenekleri
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

            // Yazıcılar için özellikler (43-84 arası ürünler)
            for (int productId = 43; productId <= 84; productId++)
            {
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
                12 => 15, // Intel Core i7 12700H
                13 => 16, // Intel Core i7 1255U
                14 => 17, // Intel Core i7 13620H
                15 => 17, // Intel Core i7 13620H
                16 => 18, // Intel Core i5 1334U
                17 => 19, // Intel Core i5 13420H
                18 => 20, // AMD Ryzen 7 5700U
                19 => 21, // Intel Core i5 12450H
                20 => 16, // Intel Core i7 1255U
                21 => 32, // Intel Core i7 13650HX
                22 => 21, // Intel Core i5 12450H
                23 => 36, // AMD Ryzen 5 7430U
                24 => 16, // Intel Core i7 1255U
                25 => 15, // Intel Core i7 12700H
                26 => 19, // Intel Core i5 13420H
                27 => 15, // Intel Core i7 12700H
                28 => 33, // Intel Core i5 13500H
                29 => 21, // Intel Core i5 12450H
                30 => 21, // Intel Core i5 12450H
                31 => 16, // Intel Core i7 1255U
                32 => 19, // Intel Core i5 13420H
                33 => 19, // Intel Core i5 13420H
                34 => 35, // Intel Core Ultra 7 255HX
                35 => 19, // Intel Core i5 13420H
                36 => 34, // Intel Core i9-14900HX
                37 => 17, // Intel Core i7 13620H
                38 => 19, // Intel Core i5 13420H
                39 => 36, // AMD Ryzen 5 7520U
                40 => 19, // Intel Core i5 13420H
                41 => 16, // Intel Core i7 1255U
                42 => 21, // Intel Core i5 12450H
                _ => 15
            };
        }

        private static int GetRamValueId(int productId)
        {
            return productId switch
            {
                12 => 24, // 32GB
                13 => 23, // 16GB
                14 => 24, // 32GB
                15 => 24, // 32GB
                16 => 23, // 16GB
                17 => 23, // 16GB
                18 => 23, // 16GB
                19 => 22, // 8GB
                20 => 23, // 16GB
                21 => 24, // 32GB
                22 => 24, // 32GB
                23 => 23, // 16GB
                24 => 23, // 16GB
                25 => 24, // 32GB
                26 => 24, // 32GB
                27 => 24, // 32GB
                28 => 23, // 16GB
                29 => 22, // 8GB
                30 => 22, // 8GB
                31 => 23, // 16GB
                32 => 23, // 16GB
                33 => 23, // 16GB
                34 => 24, // 32GB
                35 => 24, // 32GB
                36 => 24, // 32GB
                37 => 23, // 16GB
                38 => 23, // 16GB
                39 => 22, // 8GB
                40 => 24, // 32GB
                41 => 23, // 16GB
                42 => 23, // 16GB
                _ => 23
            };
        }

        private static int GetSsdValueId(int productId)
        {
            return productId switch
            {
                12 => 28, // 1TB
                13 => 27, // 512GB
                14 => 28, // 1TB
                15 => 28, // 1TB
                16 => 27, // 512GB
                17 => 27, // 512GB
                18 => 27, // 512GB
                19 => 27, // 512GB
                20 => 26, // 500GB
                21 => 28, // 1TB
                22 => 26, // 500GB
                23 => 26, // 500GB
                24 => 27, // 512GB
                25 => 28, // 1TB
                26 => 26, // 500GB
                27 => 28, // 1TB
                28 => 27, // 512GB
                29 => 27, // 512GB
                30 => 27, // 512GB
                31 => 12, // 256GB
                32 => 28, // 1TB
                33 => 27, // 512GB
                34 => 28, // 1TB
                35 => 26, // 500GB
                36 => 28, // 1TB
                37 => 26, // 500GB
                38 => 28, // 1TB
                39 => 27, // 512GB
                40 => 28, // 1TB
                41 => 12, // 256GB
                42 => 26, // 500GB
                _ => 27
            };
        }

        private static int GetScreenValueId(int productId)
        {
            return productId switch
            {
                13 => 29, // 14"
                14 => 31, // 16"
                17 => 31, // 16"
                18 => 30, // 15.6"
                19 => 30, // 15.6"
                20 => 30, // 15.6"
                21 => 30, // 15.6"
                22 => 30, // 15.6"
                23 => 30, // 15.6"
                24 => 30, // 15.6"
                25 => 30, // 15.6"
                26 => 30, // 15.6"
                27 => 30, // 15.6"
                28 => 30, // 15.6"
                29 => 30, // 15.6"
                30 => 30, // 15.6"
                31 => 29, // 13"
                32 => 30, // 15.6"
                33 => 29, // 14"
                34 => 31, // 16"
                35 => 30, // 15.6"
                36 => 31, // 16"
                37 => 30, // 15.6"
                38 => 30, // 15.6"
                39 => 30, // 15.6"
                40 => 30, // 15.6"
                41 => 29, // 13"
                42 => 30, // 15.6"
                _ => 30
            };
        }

        private static int GetPrinterTypeValueId(int productId)
        {
            // Ürün ID'sine göre yazıcı tipini belirle
            if (productId == 43 || productId == 44 || productId == 45 || productId == 46 || productId == 47 || 
                productId == 48 || productId == 49 || productId == 50 || productId == 51 || productId == 52 || 
                productId == 53 || productId == 54 || productId == 55 || productId == 56 || productId == 57 || 
                productId == 58 || productId == 59 || productId == 60 || productId == 61 || productId == 62 || 
                productId == 63 || productId == 64 || productId == 65 || productId == 66 || productId == 67 || 
                productId == 68 || productId == 69 || productId == 70 || productId == 71 || productId == 72 || 
                productId == 73 || productId == 74 || productId == 75 || productId == 76 || productId == 77 || 
                productId == 78 || productId == 79 || productId == 80 || productId == 81 || productId == 82 || 
                productId == 83 || productId == 84)
            {
                return 37; // Mürekkep Püskürtmeli
            }
            return 38; // Lazer
        }

        private static int GetInkSystemValueId(int productId)
        {
            // Ürün ID'sine göre mürekkep sistemini belirle
            if (productId == 43 || productId == 44 || productId == 45 || productId == 46 || productId == 47 || 
                productId == 48 || productId == 49 || productId == 50 || productId == 51 || productId == 52 || 
                productId == 53 || productId == 54 || productId == 55 || productId == 56 || productId == 57 || 
                productId == 58 || productId == 59 || productId == 60 || productId == 61 || productId == 62 || 
                productId == 63 || productId == 64 || productId == 65 || productId == 66 || productId == 67 || 
                productId == 68 || productId == 69 || productId == 70 || productId == 71 || productId == 72 || 
                productId == 73 || productId == 74 || productId == 75 || productId == 76 || productId == 77 || 
                productId == 78 || productId == 79 || productId == 80 || productId == 81 || productId == 82 || 
                productId == 83 || productId == 84)
            {
                return 40; // Kartuşlu
            }
            return 41; // Tanklı
        }

        private static int GetPaperSizeValueId(int productId)
        {
            // Ürün ID'sine göre kağıt boyutunu belirle
            if (productId == 43 || productId == 44 || productId == 45 || productId == 46 || productId == 47 || 
                productId == 48 || productId == 49 || productId == 50 || productId == 51 || productId == 52 || 
                productId == 53 || productId == 54 || productId == 55 || productId == 56 || productId == 57 || 
                productId == 58 || productId == 59 || productId == 60 || productId == 61 || productId == 62 || 
                productId == 63 || productId == 64 || productId == 65 || productId == 66 || productId == 67 || 
                productId == 68 || productId == 69 || productId == 70 || productId == 71 || productId == 72 || 
                productId == 73 || productId == 74 || productId == 75 || productId == 76 || productId == 77 || 
                productId == 78 || productId == 79 || productId == 80 || productId == 81 || productId == 82 || 
                productId == 83 || productId == 84)
            {
                return 43; // A4
            }
            return 44; // A3
        }

        private static List<int> GetFunctionValueIds(int productId)
        {
            var functionIds = new List<int> { 46 }; // Tüm yazıcılar yazdırma yapabilir

            // Tarama özelliği
            if (productId == 43 || productId == 44 || productId == 45 || productId == 46 || productId == 47 || 
                productId == 48 || productId == 49 || productId == 50 || productId == 51 || productId == 52 || 
                productId == 53 || productId == 54 || productId == 55 || productId == 56 || productId == 57 || 
                productId == 58 || productId == 59 || productId == 60 || productId == 61 || productId == 62 || 
                productId == 63 || productId == 64 || productId == 65 || productId == 66 || productId == 67 || 
                productId == 68 || productId == 69 || productId == 70 || productId == 71 || productId == 72 || 
                productId == 73 || productId == 74 || productId == 75 || productId == 76 || productId == 77 || 
                productId == 78 || productId == 79 || productId == 80 || productId == 81 || productId == 82 || 
                productId == 83 || productId == 84)
            {
                functionIds.Add(47); // Tarama
                functionIds.Add(48); // Fotokopi
            }

            // Wi-Fi özelliği
            if (productId == 43 || productId == 44 || productId == 45 || productId == 46 || productId == 47 || 
                productId == 48 || productId == 49 || productId == 50 || productId == 51 || productId == 52 || 
                productId == 53 || productId == 54 || productId == 55 || productId == 56 || productId == 57 || 
                productId == 58 || productId == 59 || productId == 60 || productId == 61 || productId == 62 || 
                productId == 63 || productId == 64 || productId == 65 || productId == 66 || productId == 67 || 
                productId == 68 || productId == 69 || productId == 70 || productId == 71 || productId == 72 || 
                productId == 73 || productId == 74 || productId == 75 || productId == 76 || productId == 77 || 
                productId == 78 || productId == 79 || productId == 80 || productId == 81 || productId == 82 || 
                productId == 83 || productId == 84)
            {
                functionIds.Add(50); // Wi-Fi
            }

            // AirPrint özelliği
            if (productId == 43 || productId == 44 || productId == 45 || productId == 46 || productId == 47 || 
                productId == 48 || productId == 49 || productId == 50 || productId == 51 || productId == 52 || 
                productId == 53 || productId == 54 || productId == 55 || productId == 56 || productId == 57 || 
                productId == 58 || productId == 59 || productId == 60 || productId == 61 || productId == 62 || 
                productId == 63 || productId == 64 || productId == 65 || productId == 66 || productId == 67 || 
                productId == 68 || productId == 69 || productId == 70 || productId == 71 || productId == 72 || 
                productId == 73 || productId == 74 || productId == 75 || productId == 76 || productId == 77 || 
                productId == 78 || productId == 79 || productId == 80 || productId == 81 || productId == 82 || 
                productId == 83 || productId == 84)
            {
                functionIds.Add(51); // AirPrint
            }

            return functionIds;
        }
    }
} 