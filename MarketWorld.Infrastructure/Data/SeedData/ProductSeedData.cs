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
                    Brand = "Apple",
                    Price = 56999.99m,
                    Stock = 100,
                    IsActive = true,
                    Description = "Apple iPhone 14 Pro 256 GB Uzay Siyahı Cep Telefonu",
                    DiscountPrice = 54999.99m,
                    HasDiscount = true,
                    SubCategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 2,
                    Name = "Samsung Galaxy S23",
                    Brand = "Samsung", 
                    Price = 41999.99m,
                    Stock = 150,
                    IsActive = true,
                    Description = "Samsung Galaxy S23 Ultra 256 GB Krem Cep Telefonu",
                    DiscountPrice = 39999.99m,
                    HasDiscount = true,
                    SubCategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 3,
                    Name = "Apple iPhone 15 128 GB Mavi",
                    Brand = "Apple",
                    Price = 49999.99m,
                    Stock = 150,
                    IsActive = true,
                    Description = "Apple iPhone 15 128 GB Mavi",
                    DiscountPrice = 39999.99m,
                    HasDiscount = true,
                    SubCategoryId = 3,
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
                    Path = "img/ProducsPicture/Telephones/TelephoneTwo/resimbir.jpg",
                    EntityId = 2,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 3,
                    Path = "img/ProducsPicture/Telephones/TelephoneThree/resimbir.jpg",
                    EntityId = 3,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                }
            };
        }
    }
} 