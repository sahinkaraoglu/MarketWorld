using MarketWorld.Domain.Entities;

namespace MarketWorld.Web.SeedData
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
                    Brand = "Apple",
                    Name = "iPhone 16 Pro Max 256GB Beyaz",
                    Price = 91999.99m,
                    Description = "iPhone 16 Pro Max 256GB Beyaz",
                    IsActive = true,
                    SubCategoryId = 3,
                    HasDiscount = false,
                    Stock = 100,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 2,
                    Brand = "Samsung",
                    Name = "Galaxy A35 256 GB 8 GB Ram",
                    Price = 15649m,
                    Description = "Galaxy A35 256 GB 8 GB Ram (Samsung Türkiye Garantili) Açık Mavi",
                    IsActive = true,
                    SubCategoryId = 3,
                    HasDiscount = false,
                    Stock = 150,
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
                    EntityType = 1,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 2,
                    Path = "img/ProducsPicture/Telephones/TelephoneTwo/resimiki.jpg",
                    EntityId = 2,  
                    EntityType = 1,
                    CreatedDate = DateTime.Now
                }
            };
        }
    }
} 