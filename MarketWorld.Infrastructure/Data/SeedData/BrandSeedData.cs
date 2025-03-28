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
                }
            };
        }
    }
}