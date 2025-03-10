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
                    BrandId = 1,
                    Price = 56999.99m,
                    Stock = 100,
                    IsActive = true,
                    Description = "Apple iPhone 14 Pro 256 GB",
                    DiscountPrice = 54999.99m,
                    HasDiscount = true,
                    SubCategoryId = 3,
                    CreatedDate = DateTime.Now,
                    CategoryId = 1,
                    Rating = 4m
                },
                new Product
                {
                    Id = 2,
                    Name = "Samsung Galaxy S23",
                    BrandId = 2,
                    Price = 75999.99m,
                    Stock = 150,
                    IsActive = true,
                    Description = "Samsung Galaxy S23 Ultra 256 GB",
                    DiscountPrice = 65999.99m,
                    HasDiscount = true,
                    SubCategoryId = 3,
                    CreatedDate = DateTime.Now,
                    CategoryId = 1,
                    Rating = 3m
                },
                new Product
                {
                    Id = 3,
                    Name = "Apple iPhone 15 128 GB Mavi",
                    BrandId = 1,
                    Price = 49999.99m,
                    Stock = 150,
                    IsActive = true,
                    Description = "Apple iPhone 15 128 GB",
                    DiscountPrice = 39999.99m,
                    HasDiscount = true,
                    SubCategoryId = 3,
                    CreatedDate = DateTime.Now,
                    CategoryId = 1,
                    Rating = 5m
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
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 2,
                    Name = "Samsung",
                    CreatedDate = DateTime.Now
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
                    Path = "img/ProducsPicture/Telephones/TelephoneOne/resimbir.jpg",
                    EntityId = 1,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 2,
                    Path = "img/ProducsPicture/Telephones/TelephoneOne/resimiki.jpg",
                    EntityId = 1,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 3,
                    Path = "img/ProducsPicture/Telephones/TelephoneOne/resimuc.jpg",
                    EntityId = 1,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 4,
                    Path = "img/ProducsPicture/Telephones/TelephoneOne/resimdort.jpg",
                    EntityId = 1,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 5,
                    Path = "img/ProducsPicture/Telephones/TelephoneTwo/resimbir.jpg",
                    EntityId = 2,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 6,
                    Path = "img/ProducsPicture/Telephones/TelephoneTwo/resimiki.jpg",
                    EntityId = 2,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 7,
                    Path = "img/ProducsPicture/Telephones/TelephoneTwo/resimuc.jpg",
                    EntityId = 2,
                    EntityType = (int) EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 8,
                    Path = "img/ProducsPicture/Telephones/TelephoneTwo/resimdort.jpg",
                    EntityId = 2,
                    EntityType = (int) EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 9,
                    Path = "img/ProducsPicture/Telephones/TelephoneThree/resimbir.jpg",
                    EntityId = 3,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                }
            };
        }
    }
} 