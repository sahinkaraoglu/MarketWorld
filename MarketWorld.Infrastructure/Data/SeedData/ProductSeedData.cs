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
                    BrandId = 9,
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
                    BrandId = 8,
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
                    BrandId = 10,
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
                    BrandId = 9,
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
                    BrandId = 8,
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
                    BrandId = 9,
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
                    BrandId = 10,
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
                },
                new Product
                {
                    Id = 12,
                    Name = "Casper Excalibur G870.1270",
                    Description = "Intel Core i7 12700H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar",
                    Price = 39999.99M,
                    Stock = 100,
                    BrandId = 3,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 13,
                    Name = "MSI Modern 14 C12MO",
                    Description = "Intel Core i7 1255U 16GB 512GB SSD Freedos 14\" FHD Taşınabilir Bilgisayar",
                    Price = 21799.99M,
                    Stock = 75,
                    BrandId = 6,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 14,
                    Name = "Casper Nirvana S100",
                    Description = "Core i7-13620H 32GB DDR5 RAM 1TB NVME SSD 16\" Freedos Taşınabilir Bilgisayar",
                    Price = 27299.99M,
                    Stock = 50,
                    BrandId = 3,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 15,
                    Name = "Casper Excalibur G870.1362",
                    Description = "Intel Core i7 13620H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar",
                    Price = 50199.99M,
                    Stock = 60,
                    BrandId = 3,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 16,
                    Name = "HP 250 G10",
                    Description = "Intel Core i5 1334U 16GB 512GB SSD Freedos 15.6\" Taşınabilir Bilgisayar",
                    Price = 14999.99M,
                    Stock = 100,
                    BrandId = 4,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.7M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 17,
                    Name = "Lenovo Ideapad Slim 3",
                    Description = "Intel Core i5 13420H 16GB Ddr5 Ram 512 GB SSD 16'' WUXGA IPS Panel Freedos Taşınabilir Bilgisayar",
                    Price = 19799.99M,
                    Stock = 80,
                    BrandId = 5,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.9M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 18,
                    Name = "Lenovo Ideapad 1",
                    Description = "AMD Ryzen 7 5700U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar",
                    Price = 15999.99M,
                    Stock = 90,
                    BrandId = 5,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.6M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 19,
                    Name = "MSI Thin 15",
                    Description = "Intel Core i5 12450H 8GB 512GB SSD RTX2050 Freedos 15.6\" Taşınabilir Bilgisayar",
                    Price = 24799.99M,
                    Stock = 70,
                    BrandId = 6,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 20,
                    Name = "Casper Nirvana C550",
                    Description = "Intel Core i7 1255U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar",
                    Price = 18999.99M,
                    Stock = 85,
                    BrandId = 3,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 21,
                    Name = "Lenovo LOQ 15IRX9",
                    Description = "Intel Core i7 13650HX 32GB 1TB SSD RTX 4060 8GB (115W) 15.6\" FHD 144Hz IPS Panel Freedos Taşınabilir Bilgisayar",
                    Price = 59999.99M,
                    Stock = 45,
                    BrandId = 5,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 22,
                    Name = "Casper Excalibur G770",
                    Description = "Intel Core i5-12450H 32GB RAM 500GB SSD GEN4 RTX3050 Freedos Gaming Laptop",
                    Price = 31299.99M,
                    Stock = 65,
                    BrandId = 3,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.6M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 23,
                    Name = "Casper Nirvana X600",
                    Description = "AMD Ryzen 5 7430U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar",
                    Price = 16999.99M,
                    Stock = 80,
                    BrandId = 3,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 24,
                    Name = "Acer Aspire 3",
                    Description = "Intel Core i7 1255U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar",
                    Price = 24000.00M,
                    Stock = 70,
                    BrandId = 7,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 25,
                    Name = "Casper Nirvana X600.1270",
                    Description = "Intel Core i7 12700H 32GB 1TB SSD Freedos 15.6\" Taşınabilir Bilgisayar",
                    Price = 22999.99M,
                    Stock = 85,
                    BrandId = 3,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 26,
                    Name = "Casper Excalibur G870.1342",
                    Description = "Intel Core i5-13420H 32GB RAM 500GB NVME SSD GEN4 6GB RTX4050 Freedos Gaming Laptop",
                    Price = 38499.99M,
                    Stock = 55,
                    BrandId = 3,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.1M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 27,
                    Name = "Casper Excalibur G870.1270",
                    Description = "Intel Core i7 12700H 32GB 1TB SSD RTX4070 Freedos 15.6\" FHD Taşınabilir Bilgisayar",
                    Price = 50899.99M,
                    Stock = 40,
                    BrandId = 3,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 28,
                    Name = "HP Victus Gaming 15",
                    Description = "Intel Core i5 13500H 16GB 512GB SSD RTX4050 Freedos 15.6\" FHD Taşınabilir Bilgisayar",
                    Price = 33999.99M,
                    Stock = 90,
                    BrandId = 4,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.6M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 29,
                    Name = "Lenovo IdeaPad Slim 3",
                    Description = "Intel Core i5 12450H 8GB 512GB SSD 15.6\" FHD Freedos Taşınabilir Bilgisayar",
                    Price = 15359.04M,
                    Stock = 100,
                    BrandId = 5,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.7M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 30,
                    Name = "Asus TUF Gaming F15",
                    Description = "Intel Core i5 12500H 8GB 512GB SSD RTX3050 Freedos 15.6\" FHD Taşınabilir Bilgisayar",
                    Price = 29898.66M,
                    Stock = 75,
                    BrandId = 2,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.7M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 31,
                    Name = "Apple MacBook Air M1",
                    Description = "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Uzay Grisi",
                    Price = 39250.00M,
                    Stock = 60,
                    BrandId = 1,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.9M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 32,
                    Name = "Casper Excalibur G870.1342",
                    Description = "Intel Core i5-13420H 16GB RAM 1TB NVME SSD 8GB RTX4060 Freedos Gaming Laptop",
                    Price = 42299.99M,
                    Stock = 50,
                    BrandId = 3,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.3M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 33,
                    Name = "Lenovo Ideapad 5",
                    Description = "Intel Core i5 13420H 16GB 512GB SSD Freedos 14\" WUXGA Taşınabilir Bilgisayar",
                    Price = 29999.99M,
                    Stock = 70,
                    BrandId = 5,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 34,
                    Name = "Asus ROG Strix G16",
                    Description = "Intel Core Ultra 7 255HX 32GB 1TB SSD RTX5070Ti Freedos 16\" Taşınabilir Bilgisayar",
                    Price = 107999.99M,
                    Stock = 25,
                    BrandId = 2,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 35,
                    Name = "Casper Nirvana X600.1342",
                    Description = "Intel Core i5-13420H 32GB RAM 500GB NVME SSD Freedos",
                    Price = 19999.99M,
                    Stock = 85,
                    BrandId = 3,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 36,
                    Name = "Lenovo Thinkbook 16PG5",
                    Description = "Intel Core i9-14900HX 32GB DDR5 1TB SSD RTX4060 8GB 16 inç 3.2K (3200×2000) 165Hz FreeDos Laptop",
                    Price = 79999.40M,
                    Stock = 30,
                    BrandId = 5,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.7M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 37,
                    Name = "Casper Nirvana X600.1362",
                    Description = "Intel Core i7-13620H 16GB RAM 500GB NVME SSD Freedos Laptop",
                    Price = 22099.99M,
                    Stock = 75,
                    BrandId = 3,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 38,
                    Name = "MSI CYBORG 15",
                    Description = "Intel Core i5 13420H 16GB 1TB SSD RTX4060 Freedos 15.6\" FHD 144Hz Taşınabilir Bilgisayar",
                    Price = 37999.99M,
                    Stock = 60,
                    BrandId = 6,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.9M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 39,
                    Name = "Lenovo V15 G4",
                    Description = "AMD Ryzen 5 7520U 8gb 512GB SSD Freedos 15.6\" Fhd Taşınabilir Bilgisayar",
                    Price = 13299.99M,
                    Stock = 95,
                    BrandId = 5,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.3M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 40,
                    Name = "Lenovo V15 G4",
                    Description = "I5-13420H 32GB 1 Tb SSD 15.6 Fhd Windows 11 Pro",
                    Price = 27749.00M,
                    Stock = 70,
                    BrandId = 5,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 41,
                    Name = "Apple MacBook Air M4",
                    Description = "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Gece Yarısı",
                    Price = 49999.99M,
                    Stock = 45,
                    BrandId = 1,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 42,
                    Name = "Casper Excalibur G870.1245",
                    Description = "Intel Core i5 12450H 16GB 500GB SSD RTX2050 Freedos 15.6\" FHD Taşınabilir Bilgisayar",
                    Price = 27499.99M,
                    Stock = 80,
                    BrandId = 3,
                    SubCategoryId = 1,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 1,
                    Rating = 4.4M,
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
                },
                new Image
                {
                    Id = 45,
                    Path = "img/Products/Laptops/Casper_G870.1270.jpg",
                    EntityId = 12,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 46,
                    Path = "img/Products/Laptops/MSI_15.6.jpg",
                    EntityId = 13,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 47,
                    Path = "img/Products/Laptops/Casper_S100.1362.jpg",
                    EntityId = 14,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 48,
                    Path = "img/Products/Laptops/Casper_G870.1362.jpg",
                    EntityId = 15,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 49,
                    Path = "img/Products/Laptops/HP_15.6.jpg",
                    EntityId = 16,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 50,
                    Path = "img/Products/Laptops/Lenovo_15.6.jpg",
                    EntityId = 17,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 51,
                    Path = "img/Products/Laptops/Lenovo_model.jpg",
                    EntityId = 18,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 52,
                    Path = "img/Products/Laptops/MSI_model.jpg",
                    EntityId = 19,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 53,
                    Path = "img/Products/Laptops/Casper_C550.1255.jpg",
                    EntityId = 20,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 54,
                    Path = "img/Products/Laptops/Lenovo_3.2.jpg",
                    EntityId = 21,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 55,
                    Path = "img/Products/Laptops/Casper_G770.1245.jpg",
                    EntityId = 22,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 56,
                    Path = "img/Products/Laptops/Casper_X600.7430.jpg",
                    EntityId = 23,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 57,
                    Path = "img/Products/Laptops/Acer_15.6.jpg",
                    EntityId = 24,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 58,
                    Path = "img/Products/Laptops/Casper_X600.1270.jpg",
                    EntityId = 25,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 59,
                    Path = "img/Products/Laptops/Casper_G870.1342.jpg",
                    EntityId = 26,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 60,
                    Path = "img/Products/Laptops/Casper_G870.1270.jpg",
                    EntityId = 27,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 61,
                    Path = "img/Products/Laptops/HP_15.6.jpg",
                    EntityId = 28,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 62,
                    Path = "img/Products/Laptops/Lenovo_15.6.jpg",
                    EntityId = 29,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 63,
                    Path = "img/Products/Laptops/Asus_15.6.jpg",
                    EntityId = 30,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 64,
                    Path = "img/Products/Laptops/Apple_model.jpg",
                    EntityId = 31,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 65,
                    Path = "img/Products/Laptops/Casper_G870.1342.jpg",
                    EntityId = 32,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 66,
                    Path = "img/Products/Laptops/Lenovo_15.6.jpg",
                    EntityId = 33,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 67,
                    Path = "img/Products/Laptops/Asus_model.jpg",
                    EntityId = 34,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 68,
                    Path = "img/Products/Laptops/Casper_X600.1342.jpg",
                    EntityId = 35,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 69,
                    Path = "img/Products/Laptops/Lenovo_3.2.jpg",
                    EntityId = 36,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 70,
                    Path = "img/Products/Laptops/Casper_X600.1362.jpg",
                    EntityId = 37,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 71,
                    Path = "img/Products/Laptops/MSI_15.6.jpg",
                    EntityId = 38,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 72,
                    Path = "img/Products/Laptops/Lenovo_15.6.jpg",
                    EntityId = 39,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 73,
                    Path = "img/Products/Laptops/Lenovo_15.6.jpg",
                    EntityId = 40,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 74,
                    Path = "img/Products/Laptops/Apple_model.jpg",
                    EntityId = 41,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                },
                new Image
                {
                    Id = 75,
                    Path = "img/Products/Laptops/Casper_G870.1245.jpg",
                    EntityId = 42,
                    EntityType = (int)EntityTypes.Product,
                    CreatedDate = DateTime.Now
                }
            };
        }
    }
}
