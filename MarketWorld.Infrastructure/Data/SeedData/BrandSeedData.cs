using MarketWorld.Domain.Entities;

namespace MarketWorld.Infrastructure.Data.SeedData
{
    public static class BrandSeedData
    {
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
                    Name = "Asus",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 3,
                    Name = "Casper",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 4,
                    Name = "HP",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 5,
                    Name = "Lenovo",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 6,
                    Name = "MSI",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 7,
                    Name = "Acer",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 8,
                    Name = "Xiaomi",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 9,
                    Name = "Samsung",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 10,
                    Name = "Huawei",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 11,
                    Name = "Canon",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 12,
                    Name = "Epson",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 13,
                    Name = "Honor",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 14,
                    Name = "Nothing",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 15,
                    Name = "Infinix",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 16,
                    Name = "Redmi",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 17,
                    Name = "POCO",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 18,
                    Name = "Oppo",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 19,
                    Name = "Panasonic",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 20,
                    Name = "Reeder",
                    CreatedDate = DateTime.Now
                },
                new Brand
                {
                    Id = 21,
                    Name = "Tecno",
                    CreatedDate = DateTime.Now
                }
            };
        }
    }
}