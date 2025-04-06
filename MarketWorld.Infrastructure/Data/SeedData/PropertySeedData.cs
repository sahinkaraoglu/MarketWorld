using MarketWorld.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

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
                new PropertyValue { Id = 54, PropertyTypeId = 1, Value = "Gri", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 55, PropertyTypeId = 1, Value = "Açık Mavi", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 56, PropertyTypeId = 1, Value = "Lacivert", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 57, PropertyTypeId = 1, Value = "Mavi", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 58, PropertyTypeId = 1, Value = "Mor", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 59, PropertyTypeId = 1, Value = "Altın", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 60, PropertyTypeId = 1, Value = "Nane Yeşili", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 61, PropertyTypeId = 1, Value = "Zümrüt Yeşili", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 62, PropertyTypeId = 1, Value = "Lacivert Taş", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 63, PropertyTypeId = 1, Value = "Natürel Titanyum", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 64, PropertyTypeId = 1, Value = "Grafit", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 65, PropertyTypeId = 1, Value = "Antrasit", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 66, PropertyTypeId = 1, Value = "Inox", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 67, PropertyTypeId = 1, Value = "Kırmızı", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 68, PropertyTypeId = 1, Value = "Turkuaz", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 69, PropertyTypeId = 1, Value = "Pembe", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 70, PropertyTypeId = 1, Value = "Turuncu", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 71, PropertyTypeId = 1, Value = "Sarı", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 72, PropertyTypeId = 1, Value = "Kahverengi", CreatedDate = DateTime.Now },
                new PropertyValue { Id = 73, PropertyTypeId = 1, Value = "Bej", CreatedDate = DateTime.Now }
            };
        }

        public static List<ProductProperty> GetProductProperties()
        {
            var productProperties = new List<ProductProperty>();
            int id = 1;

            // Laptoplar için özellikler (1-31 arası ürünler)
            for (int productId = 1; productId <= 31; productId++)
            {
                // Her bir ürün için özellikler ekleniyor
                if (ProductSeedData.GetProducts().Any(p => p.Id == productId))
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
            }

            // Yazıcılar için özellikler (32-73 arası ürünler)
            for (int productId = 32; productId <= 73; productId++)
            {
                if (ProductSeedData.GetProducts().Any(p => p.Id == productId))
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
            }

            // Telefonlar için özellikler (74-129 arası ürünler)
            for (int productId = 74; productId <= 129; productId++)
            {
                if (ProductSeedData.GetProducts().Any(p => p.Id == productId))
                {
                    // Renk seçenekleri
                    var colorValueId = GetPhoneColorValueId(productId);
                    productProperties.Add(new ProductProperty
                    {
                        Id = id++,
                        ProductId = productId,
                        PropertyTypeId = 1,
                        PropertyValueId = colorValueId,
                        Stock = 50,
                        IsActive = true,
                        CreatedDate = DateTime.Now
                    });

                    // Hafıza özelliği
                    var storageValueId = GetPhoneStorageValueId(productId);
                    productProperties.Add(new ProductProperty
                    {
                        Id = id++,
                        ProductId = productId,
                        PropertyTypeId = 3,
                        PropertyValueId = storageValueId,
                        Stock = 50,
                        IsActive = true,
                        CreatedDate = DateTime.Now
                    });
                }
            }

            // Beyaz eşyalar için özellikler (130-200 arası ürünler)
            for (int productId = 130; productId <= 200; productId++)
            {
                if (ProductSeedData.GetProducts().Any(p => p.Id == productId))
                {
                    // Renk seçenekleri
                    var colorValueId = GetWhiteGoodsColorValueId(productId);
                    productProperties.Add(new ProductProperty
                    {
                        Id = id++,
                        ProductId = productId,
                        PropertyTypeId = 1,
                        PropertyValueId = colorValueId,
                        Stock = 50,
                        IsActive = true,
                        CreatedDate = DateTime.Now
                    });
                }
            }

            // Ayakkabılar için özellikler (192-209 arası ürünler)
            for (int productId = 192; productId <= 209; productId++)
            {
                if (ProductSeedData.GetProducts().Any(p => p.Id == productId))
                {
                    // Renk seçenekleri
                    var colorValueId = GetShoesColorValueId(productId);
                    productProperties.Add(new ProductProperty
                    {
                        Id = id++,
                        ProductId = productId,
                        PropertyTypeId = 1,
                        PropertyValueId = colorValueId,
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

        private static int GetPhoneColorValueId(int productId)
        {
            return productId switch
            {
                74 => 53, // Beyaz
                75 => 52, // Siyah
                76 => 52, // Siyah
                77 => 52, // Siyah
                78 => 52, // Siyah
                79 => 58, // Mor
                80 => 55, // Açık Mavi
                81 => 54, // Gri
                82 => 54, // Gri
                83 => 52, // Siyah
                84 => 54, // Gri
                85 => 52, // Siyah
                86 => 53, // Beyaz
                87 => 55, // Açık Mavi
                88 => 60, // Nane Yeşili
                89 => 52, // Siyah
                90 => 54, // Gri
                91 => 64, // Grafit
                92 => 53, // Beyaz
                93 => 57, // Mavi
                94 => 56, // Lacivert
                95 => 56, // Lacivert
                96 => 59, // Altın
                97 => 52, // Siyah
                98 => 53, // Beyaz
                99 => 55, // Açık Mavi
                100 => 52, // Siyah
                101 => 52, // Siyah
                102 => 57, // Mavi
                103 => 53, // Beyaz
                104 => 52, // Siyah
                105 => 53, // Beyaz
                106 => 61, // Zümrüt Yeşili
                107 => 52, // Siyah
                108 => 58, // Mor
                109 => 56, // Lacivert
                110 => 62, // Lacivert Taş
                111 => 52, // Siyah
                112 => 63, // Natürel Titanyum
                113 => 52, // Siyah
                114 => 52, // Siyah
                115 => 52, // Siyah
                116 => 52, // Siyah
                117 => 52, // Siyah
                118 => 61, // Yeşil
                119 => 52, // Siyah
                120 => 52, // Siyah
                121 => 52, // Siyah
                122 => 53, // Beyaz
                123 => 52, // Siyah
                124 => 57, // Mavi
                125 => 52, // Siyah
                126 => 56, // Lacivert
                127 => 52, // Siyah
                128 => 52, // Siyah
                129 => 53, // Beyaz
                _ => 52
            };
        }

        private static int GetPhoneStorageValueId(int productId)
        {
            return productId switch
            {
                74 => 11, // 128GB
                75 => 11, // 128GB
                76 => 11, // 128GB
                77 => 11, // 128GB
                78 => 14, // 256GB
                79 => 14, // 256GB
                80 => 11, // 128GB
                81 => 14, // 256GB
                82 => 11, // 128GB
                83 => 14, // 256GB
                84 => 11, // 128GB
                85 => 14, // 256GB
                86 => 14, // 256GB
                87 => 11, // 128GB
                88 => 11, // 128GB
                89 => 11, // 128GB
                90 => 14, // 256GB
                91 => 14, // 256GB
                92 => 11, // 128GB
                93 => 11, // 128GB
                94 => 14, // 256GB
                95 => 11, // 128GB
                96 => 14, // 512GB
                97 => 14, // 512GB
                98 => 11, // 128GB
                99 => 11, // 128GB
                100 => 11, // 128GB
                101 => 14, // 256GB
                102 => 14, // 256GB
                103 => 14, // 256GB
                104 => 14, // 512GB
                105 => 11, // 128GB
                106 => 14, // 512GB
                107 => 14, // 256GB
                108 => 14, // 256GB
                109 => 11, // 128GB
                110 => 14, // 256GB
                111 => 14, // 512GB
                112 => 14, // 512GB
                113 => 11, // 64GB
                114 => 14, // 512GB
                115 => 11, // 128GB
                116 => 14, // 512GB
                117 => 11, // 128GB
                118 => 14, // 512GB
                119 => 14, // 256GB
                120 => 14, // 1TB
                121 => 11, // 128GB
                122 => 11, // 64GB
                123 => 14, // 512GB
                124 => 14, // 256GB
                125 => 14, // 256GB
                126 => 14, // 256GB
                127 => 11, // 128GB
                128 => 14, // 256GB
                129 => 11, // 128GB
                _ => 11
            };
        }

        private static int GetWhiteGoodsColorValueId(int productId)
        {
            // Beyaz eşyalar için renk dağılımı
            return productId switch
            {
                // Bulaşık Makineleri (130-150)
                >= 130 and <= 140 => 53, // Beyaz
                >= 141 and <= 145 => 65, // Antrasit
                >= 146 and <= 150 => 66, // Inox

                // Çamaşır Makineleri (151-170)
                >= 151 and <= 160 => 53, // Beyaz
                >= 161 and <= 165 => 65, // Antrasit
                >= 166 and <= 170 => 66, // Inox

                // Buzdolapları (171-190)
                >= 171 and <= 180 => 53, // Beyaz
                >= 181 and <= 185 => 65, // Antrasit
                >= 186 and <= 190 => 66, // Inox

                // Fırınlar (191-200)
                >= 191 and <= 195 => 65, // Antrasit
                >= 196 and <= 200 => 66, // Inox

                _ => 53 // Varsayılan olarak Beyaz
            };
        }

        private static int GetShoesColorValueId(int productId)
        {
            return productId switch
            {
                192 => 52, // Siyah
                193 => 52, // Siyah
                194 => 52, // Siyah
                195 => 52, // Siyah
                196 => 52, // Siyah
                197 => 67, // Kırmızı
                198 => 52, // Siyah
                199 => 52, // Siyah
                200 => 52, // Siyah
                201 => 52, // Siyah
                202 => 56, // Lacivert
                203 => 52, // Siyah
                204 => 52, // Siyah
                205 => 52, // Siyah
                206 => 72, // Kahverengi
                207 => 52, // Siyah
                208 => 56, // Lacivert
                209 => 73, // Bej
                _ => 52
            };
        }
    }
} 