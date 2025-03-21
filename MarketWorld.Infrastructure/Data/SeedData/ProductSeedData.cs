using MarketWorld.Domain.Entities;
using MarketWorld.Domain.Enums;

namespace MarketWorld.Infrastructure.Data.SeedData
{
    public static class ProductSeedData
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "iPhone 14 Pro",
                    Description = "Apple iPhone 14 Pro 256 GB",
                    Price = 56999.99M,
                    DiscountPrice = 54999.99M,
                    Stock = 100,
                    BrandId = 1,
                    SubCategoryId = 3,
                    HasDiscount = true,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 2,
                    Name = "Samsung Galaxy S23 Ultra",
                    Description = "Samsung Galaxy S23 Ultra 256 GB",
                    Price = 75999.99M,
                    DiscountPrice = 65999.99M,
                    Stock = 150,
                    BrandId = 2,
                    SubCategoryId = 3,
                    HasDiscount = true,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 3,
                    Name = "iPhone 15 128 GB",
                    Description = "Apple iPhone 15 128 GB Mavi",
                    Price = 49999.99M,
                    DiscountPrice = 39999.99M,
                    Stock = 150,
                    BrandId = 1,
                    SubCategoryId = 3,
                    HasDiscount = true,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 4,
                    Name = "Xiaomi 13T Pro",
                    Description = "Xiaomi 13T Pro 512 GB",
                    Price = 39999.99M,
                    DiscountPrice = 37999.99M,
                    Stock = 75,
                    BrandId = 3,
                    SubCategoryId = 3,
                    HasDiscount = true,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 3M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 5,
                    Name = "Huawei P60 Pro",
                    Description = "Huawei P60 Pro 256 GB",
                    Price = 44999.99M,
                    Stock = 60,
                    BrandId = 4,
                    SubCategoryId = 3,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 6,
                    Name = "Samsung Galaxy Z Fold5",
                    Description = "Samsung Galaxy Z Fold5 512 GB",
                    Price = 89999.99M,
                    DiscountPrice = 84999.99M,
                    Stock = 40,
                    BrandId = 2,
                    SubCategoryId = 3,
                    HasDiscount = true,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.9M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 7,
                    Name = "iPhone 15 Pro Max",
                    Description = "Apple iPhone 15 Pro Max 512 GB",
                    Price = 92999.99M,
                    Stock = 25,
                    BrandId = 1,
                    SubCategoryId = 3,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 3M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 8,
                    Name = "Xiaomi Redmi Note 13 Pro+",
                    Description = "Xiaomi Redmi Note 13 Pro+ 256 GB",
                    Price = 29999.99M,
                    DiscountPrice = 27999.99M,
                    Stock = 200,
                    BrandId = 3,
                    SubCategoryId = 3,
                    HasDiscount = true,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.2M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 9,
                    Name = "Samsung Galaxy A54",
                    Description = "Samsung Galaxy A54 128 GB",
                    Price = 19999.99M,
                    DiscountPrice = 18499.99M,
                    Stock = 300,
                    BrandId = 2,
                    SubCategoryId = 3,
                    HasDiscount = true,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.1M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 10,
                    Name = "Huawei Nova 11 Pro",
                    Description = "Huawei Nova 11 Pro 256 GB",
                    Price = 34999.99M,
                    Stock = 85,
                    BrandId = 4,
                    SubCategoryId = 3,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 11,
                    Name = "MacBook Air M2 16GB 256GB SSD",
                    Description = "13inc Taşınabilir Bilgisayar Uzay Grisi MC7U4TU/A",
                    Price = 41599.99M,
                    Stock = 85,
                    BrandId = 1,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 5M,
                    CreatedDate = DateTime.Now
                }
            };
        }

        public static List<Brand> GetBrands()
        {
            return new List<Brand>
            {
                new Brand
                {
                    Id = 1,
                    Name = "Apple",
                    CreatedDate = DateTime.Now,
                    SubCategoryId = 3
                },
                new Brand
                {
                    Id = 2,
                    Name = "Samsung",
                    CreatedDate = DateTime.Now,
                    SubCategoryId = 3
                },
                new Brand
                {
                    Id = 3,
                    Name = "Xiaomi",
                    CreatedDate = DateTime.Now,
                    SubCategoryId = 3
                },
                new Brand
                {
                    Id = 4,
                    Name = "Huawei",
                    CreatedDate = DateTime.Now,
                    SubCategoryId = 3
                }
            };
        }

        public static List<Image> GetImages()
        {
            return new List<Image>
            {
                new Image
                {
                    Id = 1,
                    Path = "img/ProductsPicture/Telephones/TelephoneOne/resimbir.jpg",
                    EntityId = 1,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 2,
                    Path = "img/ProductsPicture/Telephones/TelephoneOne/resimiki.jpg",
                    EntityId = 1,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 3,
                    Path = "img/ProductsPicture/Telephones/TelephoneOne/resimuc.jpg",
                    EntityId = 1,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 4,
                    Path = "img/ProductsPicture/Telephones/TelephoneOne/resimdort.jpg",
                    EntityId = 1,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 5,
                    Path = "img/ProductsPicture/Telephones/TelephoneTwo/resimbir.jpg",
                    EntityId = 2,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 6,
                    Path = "img/ProductsPicture/Telephones/TelephoneTwo/resimiki.jpg",
                    EntityId = 2,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 7,
                    Path = "img/ProductsPicture/Telephones/TelephoneTwo/resimuc.jpg",
                    EntityId = 2,
                    EntityType = (int) EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 8,
                    Path = "img/ProductsPicture/Telephones/TelephoneTwo/resimdort.jpg",
                    EntityId = 2,
                    EntityType = (int) EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 9,
                    Path = "img/ProductsPicture/Telephones/TelephoneThree/resimbir.jpg",
                    EntityId = 3,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 10,
                    Path = "img/ProductsPicture/Telephones/TelephoneThree/resimiki.jpg",
                    EntityId = 3,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 11,
                    Path = "img/ProductsPicture/Telephones/TelephoneThree/resimuc.jpg",
                    EntityId = 3,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 12,
                    Path = "img/ProductsPicture/Telephones/TelephoneThree/resimdort.jpg",
                    EntityId = 3,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                }
                ,
                new Image
                {
                    Id = 13,
                    Path = "img/ProductsPicture/Telephones/TelephoneFour/resimbir.jpg",
                    EntityId = 4,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 14,
                    Path = "img/ProductsPicture/Telephones/TelephoneFour/resimiki.jpg",
                    EntityId = 4,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 15,
                    Path = "img/ProductsPicture/Telephones/TelephoneFour/resimuc.jpg",
                    EntityId = 4,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 16,
                    Path = "img/ProductsPicture/Telephones/TelephoneFour/resimdort.jpg",
                    EntityId = 4,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },

                // 5. Telefon için resimler
                new Image
                {
                    Id = 17,
                    Path = "img/ProductsPicture/Telephones/TelephoneFive/resimbir.jpg",
                    EntityId = 5,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 18,
                    Path = "img/ProductsPicture/Telephones/TelephoneFive/resimiki.jpg",
                    EntityId = 5,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 19,
                    Path = "img/ProductsPicture/Telephones/TelephoneFive/resimuc.jpg",
                    EntityId = 5,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 20,
                    Path = "img/ProductsPicture/Telephones/TelephoneFive/resimdort.jpg",
                    EntityId = 5,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },

                // 6. Telefon için resimler
                new Image
                {
                    Id = 21,
                    Path = "img/ProductsPicture/Telephones/TelephoneSix/resimbir.jpg",
                    EntityId = 6,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 22,
                    Path = "img/ProductsPicture/Telephones/TelephoneSix/resimiki.jpg",
                    EntityId = 6,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 23,
                    Path = "img/ProductsPicture/Telephones/TelephoneSix/resimuc.jpg",
                    EntityId = 6,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 24,
                    Path = "img/ProductsPicture/Telephones/TelephoneSix/resimdort.jpg",
                    EntityId = 6,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },

                // 7. Telefon için resimler
                new Image
                {
                    Id = 25,
                    Path = "img/ProductsPicture/Telephones/TelephoneSeven/resimbir.jpg",
                    EntityId = 7,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 26,
                    Path = "img/ProductsPicture/Telephones/TelephoneSeven/resimiki.jpg",
                    EntityId = 7,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 27,
                    Path = "img/ProductsPicture/Telephones/TelephoneSeven/resimuc.jpg",
                    EntityId = 7,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 28,
                    Path = "img/ProductsPicture/Telephones/TelephoneSeven/resimdort.jpg",
                    EntityId = 7,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },

                // 8. Telefon için resimler
                new Image
                {
                    Id = 29,
                    Path = "img/ProductsPicture/Telephones/TelephoneEight/resimbir.jpg",
                    EntityId = 8,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 30,
                    Path = "img/ProductsPicture/Telephones/TelephoneEight/resimiki.jpg",
                    EntityId = 8,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 31,
                    Path = "img/ProductsPicture/Telephones/TelephoneEight/resimuc.jpg",
                    EntityId = 8,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 32,
                    Path = "img/ProductsPicture/Telephones/TelephoneEight/resimdort.jpg",
                    EntityId = 8,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },

                // 9. Telefon için resimler
                new Image
                {
                    Id = 33,
                    Path = "img/ProductsPicture/Telephones/TelephoneNine/resimbir.jpg",
                    EntityId = 9,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 34,
                    Path = "img/ProductsPicture/Telephones/TelephoneNine/resimiki.jpg",
                    EntityId = 9,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 35,
                    Path = "img/ProductsPicture/Telephones/TelephoneNine/resimuc.jpg",
                    EntityId = 9,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 36,
                    Path = "img/ProductsPicture/Telephones/TelephoneNine/resimdort.jpg",
                    EntityId = 9,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },

                // 10. Telefon için resimler
                new Image
                {
                    Id = 37,
                    Path = "img/ProductsPicture/Telephones/TelephoneTen/resimbir.jpg",
                    EntityId = 10,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 38,
                    Path = "img/ProductsPicture/Telephones/TelephoneTen/resimiki.jpg",
                    EntityId = 10,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 39,
                    Path = "img/ProductsPicture/Telephones/TelephoneTen/resimuc.jpg",
                    EntityId = 10,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 40,
                    Path = "img/ProductsPicture/Telephones/TelephoneTen/resimdort.jpg",
                    EntityId = 10,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 41,
                    Path = "img/ProductsPicture/Pc/PcOne/resimbir.jpg",
                    EntityId = 11,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 42,
                    Path = "img/ProductsPicture/Pc/PcOne/resimiki.jpg",
                    EntityId = 11,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 43,
                    Path = "img/ProductsPicture/Pc/PcOne/resimuc.jpg",
                    EntityId = 11,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 44,
                    Path = "img/ProductsPicture/Pc/PcOne/resimdort.jpg",
                    EntityId = 11,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                }
            };
        }
    }
}
