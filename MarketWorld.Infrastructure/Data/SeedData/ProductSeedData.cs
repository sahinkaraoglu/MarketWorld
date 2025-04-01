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
                    Id = 2,
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
                    Id = 3,
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
                    Id = 4,
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
                    Id = 5,
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
                    Id = 6,
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
                    Id = 7,
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
                    Id = 8,
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
                    Id = 9,
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
                    Id = 10,
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
                    Id = 11,
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
                    Id = 12,
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
                    Id = 13,
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
                    Id = 14,
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
                    Id = 15,
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
                    Id = 16,
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
                    Id = 17,
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
                    Id = 18,
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
                    Id = 19,
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
                    Id = 20,
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
                    Id = 21,
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
                    Id = 22,
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
                    Id = 23,
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
                    Id = 24,
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
                    Id = 25,
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
                    Id = 26,
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
                    Id = 27,
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
                    Id = 28,
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
                    Id = 29,
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
                    Id = 30,
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
                    Id = 31,
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
                },
                new Product
                {
                    Id = 32,
                    Name = "HP Deskjet Ink Advantage 2878 All-In-One Yazıcı",
                    Description = "HP Deskjet Ink Advantage 2878 All-In-One Yazıcı",
                    Price = 2799.00M,
                    Stock = 100,
                    BrandId = 4,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.1M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 33,
                    Name = "Canon Dolan Kartuşlu E414 Yazıcı",
                    Description = "Canon Dolan Kartuşlu E414 Yazıcı / Tarayıcı / Fotokopi",
                    Price = 2299.08M,
                    Stock = 150,
                    BrandId = 11,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.4M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 34,
                    Name = "Canon Pixma TR4650",
                    Description = "Canon Pixma TR4650 Tarayıcı + Fotokopi + Wi-Fi + Faks + Çok Fonksiyonlu Yazıcı",
                    Price = 3379.00M,
                    Stock = 75,
                    BrandId = 11,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.2M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 35,
                    Name = "Canon Pixma E3640 Wi-Fi",
                    Description = "Canon Pixma E3640 Wi-Fi Tarayıcı - Fotokopi Çok Fonksiyonlu Mürekkep Püskürtmeli Yazıcı",
                    Price = 3399.00M,
                    Stock = 120,
                    BrandId = 11,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.6M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 36,
                    Name = "Epson L5290 Wi-Fi Renk Tanklı Yazıcı",
                    Description = "Epson L5290 Wi-Fi Renk Tanklı Yazıcı",
                    Price = 11983.51M,
                    Stock = 60,
                    BrandId = 12,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.4M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 37,
                    Name = "Epson Tanklı L3150 Photoink",
                    Description = "Epson Tanklı L3150 Photoink Muadil Mürekkepli Tanklı Yazıcı",
                    Price = 6033.86M,
                    Stock = 90,
                    BrandId = 12,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.6M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 38,
                    Name = "HP Officejet Pro 7720",
                    Description = "HP Officejet Pro 7720 Fotokopi + Faks + Tarayıcı + Wi-Fi + Airprint + A3 Yazıcı",
                    Price = 11138.06M,
                    Stock = 45,
                    BrandId = 4,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.6M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 39,
                    Name = "Canon E3640 Wifi Yazıcı",
                    Description = "Canon E3640 Wifi Yazıcı ve Tıpalı Kartuş Sistemi",
                    Price = 3306.56M,
                    Stock = 100,
                    BrandId = 11,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.3M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 40,
                    Name = "Epson L3151 Tanklı Yazıcı",
                    Description = "Epson L3151 Tanklı Yazıcı / Tarayıcı / Fotokopi",
                    Price = 4999.00M,
                    Stock = 120,
                    BrandId = 12,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 41,
                    Name = "HP LaserJet Pro M428f",
                    Description = "HP LaserJet Pro M428f MFP Siyah Beyaz Lazer Yazıcı",
                    Price = 7999.00M,
                    Stock = 80,
                    BrandId = 4,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.3M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 42,
                    Name = "Canon PIXMA G3110",
                    Description = "Canon PIXMA G3110 Tanklı Yazıcı",
                    Price = 3999.00M,
                    Stock = 150,
                    BrandId = 11,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.4M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 43,
                    Name = "Epson L3250 Tanklı Yazıcı",
                    Description = "Epson L3250 Tanklı Yazıcı / Tarayıcı / Fotokopi",
                    Price = 4499.00M,
                    Stock = 100,
                    BrandId = 12,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.6M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 44,
                    Name = "HP LaserJet Pro M428dw",
                    Description = "HP LaserJet Pro M428dw MFP Siyah Beyaz Lazer Yazıcı",
                    Price = 8999.00M,
                    Stock = 60,
                    BrandId = 4,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 45,
                    Name = "Canon PIXMA G4110",
                    Description = "Canon PIXMA G4110 Tanklı Yazıcı",
                    Price = 4499.00M,
                    Stock = 90,
                    BrandId = 11,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.3M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 46,
                    Name = "Epson L4260 Tanklı Yazıcı",
                    Description = "Epson L4260 Tanklı Yazıcı / Tarayıcı / Fotokopi",
                    Price = 5499.00M,
                    Stock = 75,
                    BrandId = 12,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.7M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 47,
                    Name = "HP LaserJet Pro M428fnw",
                    Description = "HP LaserJet Pro M428fnw MFP Siyah Beyaz Lazer Yazıcı",
                    Price = 9999.00M,
                    Stock = 50,
                    BrandId = 4,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.4M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 48,
                    Name = "Canon PIXMA G5110",
                    Description = "Canon PIXMA G5110 Tanklı Yazıcı",
                    Price = 4999.00M,
                    Stock = 110,
                    BrandId = 11,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 49,
                    Name = "Epson L4266 Tanklı Yazıcı",
                    Description = "Epson L4266 Tanklı Yazıcı / Tarayıcı / Fotokopi",
                    Price = 5999.00M,
                    Stock = 85,
                    BrandId = 12,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.6M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 50,
                    Name = "HP LaserJet Pro M428fdw",
                    Description = "HP LaserJet Pro M428fdw MFP Siyah Beyaz Lazer Yazıcı",
                    Price = 10999.00M,
                    Stock = 45,
                    BrandId = 4,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 51,
                    Name = "Canon PIXMA G6110",
                    Description = "Canon PIXMA G6110 Tanklı Yazıcı",
                    Price = 5499.00M,
                    Stock = 95,
                    BrandId = 11,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.4M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 52,
                    Name = "Epson L4268 Tanklı Yazıcı",
                    Description = "Epson L4268 Tanklı Yazıcı / Tarayıcı / Fotokopi",
                    Price = 6499.00M,
                    Stock = 70,
                    BrandId = 12,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.7M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 53,
                    Name = "HP LaserJet Pro M428fdn",
                    Description = "HP LaserJet Pro M428fdn MFP Siyah Beyaz Lazer Yazıcı",
                    Price = 11999.00M,
                    Stock = 40,
                    BrandId = 4,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.6M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 54,
                    Name = "Canon PIXMA G7110",
                    Description = "Canon PIXMA G7110 Tanklı Yazıcı",
                    Price = 5999.00M,
                    Stock = 80,
                    BrandId = 11,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.5M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 55,
                    Name = "Epson L4269 Tanklı Yazıcı",
                    Description = "Epson L4269 Tanklı Yazıcı / Tarayıcı / Fotokopi",
                    Price = 6999.00M,
                    Stock = 60,
                    BrandId = 12,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.8M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 56,
                    Name = "HP LaserJet Pro M428fdnw",
                    Description = "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı",
                    Price = 12999.00M,
                    Stock = 35,
                    BrandId = 4,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.7M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 57,
                    Name = "Canon PIXMA G8110",
                    Description = "Canon PIXMA G8110 Tanklı Yazıcı",
                    Price = 6499.00M,
                    Stock = 70,
                    BrandId = 11,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.6M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 58,
                    Name = "Epson L4267 Tanklı Yazıcı",
                    Description = "Epson L4267 Tanklı Yazıcı / Tarayıcı / Fotokopi",
                    Price = 7499.00M,
                    Stock = 50,
                    BrandId = 12,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.9M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 59,
                    Name = "HP LaserJet Pro M428fdnw",
                    Description = "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı",
                    Price = 13999.00M,
                    Stock = 30,
                    BrandId = 4,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.8M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 60,
                    Name = "Canon PIXMA G9110",
                    Description = "Canon PIXMA G9110 Tanklı Yazıcı",
                    Price = 6999.00M,
                    Stock = 60,
                    BrandId = 11,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.7M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 61,
                    Name = "Epson L4265 Tanklı Yazıcı",
                    Description = "Epson L4265 Tanklı Yazıcı / Tarayıcı / Fotokopi",
                    Price = 7999.00M,
                    Stock = 45,
                    BrandId = 12,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.8M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 62,
                    Name = "HP LaserJet Pro M428fdnw",
                    Description = "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı",
                    Price = 14999.00M,
                    Stock = 25,
                    BrandId = 4,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.9M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 63,
                    Name = "Canon PIXMA G1010",
                    Description = "Canon PIXMA G1010 Tanklı Yazıcı",
                    Price = 7499.00M,
                    Stock = 50,
                    BrandId = 11,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.8M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 64,
                    Name = "Epson L4264 Tanklı Yazıcı",
                    Description = "Epson L4264 Tanklı Yazıcı / Tarayıcı / Fotokopi",
                    Price = 8499.00M,
                    Stock = 40,
                    BrandId = 12,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.9M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 65,
                    Name = "HP LaserJet Pro M428fdnw",
                    Description = "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı",
                    Price = 15999.00M,
                    Stock = 20,
                    BrandId = 4,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 5.0M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 66,
                    Name = "Canon PIXMA G1110",
                    Description = "Canon PIXMA G1110 Tanklı Yazıcı",
                    Price = 7999.00M,
                    Stock = 45,
                    BrandId = 11,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 4.9M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 67,
                    Name = "Epson L4263 Tanklı Yazıcı",
                    Description = "Epson L4263 Tanklı Yazıcı / Tarayıcı / Fotokopi",
                    Price = 8999.00M,
                    Stock = 35,
                    BrandId = 12,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 5.0M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 68,
                    Name = "HP LaserJet Pro M428fdnw",
                    Description = "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı",
                    Price = 16999.00M,
                    Stock = 15,
                    BrandId = 4,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 5.0M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 69,
                    Name = "Canon PIXMA G1210",
                    Description = "Canon PIXMA G1210 Tanklı Yazıcı",
                    Price = 8499.00M,
                    Stock = 40,
                    BrandId = 11,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 5.0M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 70,
                    Name = "Epson L4262 Tanklı Yazıcı",
                    Description = "Epson L4262 Tanklı Yazıcı / Tarayıcı / Fotokopi",
                    Price = 9499.00M,
                    Stock = 30,
                    BrandId = 12,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 5.0M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 71,
                    Name = "HP LaserJet Pro M428fdnw",
                    Description = "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı",
                    Price = 17999.00M,
                    Stock = 10,
                    BrandId = 4,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 5.0M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 72,
                    Name = "Canon PIXMA G1310",
                    Description = "Canon PIXMA G1310 Tanklı Yazıcı",
                    Price = 8999.00M,
                    Stock = 35,
                    BrandId = 11,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 5.0M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 73,
                    Name = "Epson L4261 Tanklı Yazıcı",
                    Description = "Epson L4261 Tanklı Yazıcı / Tarayıcı / Fotokopi",
                    Price = 9999.00M,
                    Stock = 25,
                    BrandId = 12,
                    SubCategoryId = 2,
                    HasDiscount = false,
                    IsActive = true,
                    CategoryId = 2,
                    Rating = 5.0M,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 74,
                    Name = "Apple iPhone 13 128 GB Beyaz",
                    Description = "Apple iPhone 13 128 GB Beyaz",
                    Price = 1149,
                    BrandId = 1,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 75,
                    Name = "Samsung Galaxy A06 128 GB 4 GB RAM Siyah",
                    Description = "Samsung Galaxy A06 128 GB 4 GB RAM Siyah",
                    Price = 1149,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.0M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 76,
                    Name = "Apple iPhone 13 128 GB Siyah",
                    Description = "Apple iPhone 13 128 GB Siyah",
                    Price = 33699,
                    BrandId = 1,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 77,
                    Name = "Samsung Galaxy A16 128 GB 6 GB Ram Siyah",
                    Description = "Samsung Galaxy A16 128 GB 6 GB Ram Siyah",
                    Price = 8789,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.2M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 78,
                    Name = "Samsung Galaxy A35 256 GB 8 GB Ram Siyah",
                    Description = "Samsung Galaxy A35 256 GB 8 GB Ram Siyah",
                    Price = 14449,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.3M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 79,
                    Name = "HONOR Magic 7 Lite 256 GB 8 GB Ram Mor",
                    Description = "HONOR Magic 7 Lite 256 GB 8 GB Ram Mor",
                    Price = 15999,
                    BrandId = 13,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 80,
                    Name = "Samsung Galaxy A06 128 GB 4 GB Ram Açık Mavi",
                    Description = "Samsung Galaxy A06 128 GB 4 GB Ram Açık Mavi",
                    Price = 6303,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.0M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 81,
                    Name = "Samsung Galaxy S24+ 256 GB 12 GB Ram Gri",
                    Description = "Samsung Galaxy S24+ 256 GB 12 GB Ram Gri",
                    Price = 41599,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.8M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 82,
                    Name = "Samsung Galaxy A16 128 GB 6 GB Ram Gri",
                    Description = "Samsung Galaxy A16 128 GB 6 GB Ram Gri",
                    Price = 8789,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.2M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 83,
                    Name = "HONOR Magic 7 Lite 256 GB 8 GB Ram Siyah",
                    Description = "HONOR Magic 7 Lite 256 GB 8 GB Ram Siyah",
                    Price = 15999,
                    BrandId = 13,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 84,
                    Name = "Samsung Galaxy S24 FE 128 GB 8 GB Ram Gri",
                    Description = "Samsung Galaxy S24 FE 128 GB 8 GB Ram Gri",
                    Price = 23849,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.6M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 85,
                    Name = "Nothing Phone 1 256 GB 8 GB Ram Siyah",
                    Description = "Nothing Phone 1 256 GB 8 GB Ram Siyah",
                    Price = 13999,
                    BrandId = 14,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.3M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 86,
                    Name = "Nothing Phone (2a) 256 GB 12 GB Ram Beyaz",
                    Description = "Nothing Phone (2a) 256 GB 12 GB Ram Beyaz",
                    Price = 18999,
                    BrandId = 14,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 87,
                    Name = "Samsung Galaxy A35 128 GB 8 GB Ram Açık Mavi",
                    Description = "Samsung Galaxy A35 128 GB 8 GB Ram Açık Mavi",
                    Price = 13701,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.3M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 88,
                    Name = "Infinix Smart 9 128 GB 4 GB Ram Nane Yeşili",
                    Description = "Infinix Smart 9 128 GB 4 GB Ram Nane Yeşili",
                    Price = 5499,
                    BrandId = 15,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.0M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 89,
                    Name = "Samsung Galaxy A55 128 GB 8 GB Ram Siyah",
                    Description = "Samsung Galaxy A55 128 GB 8 GB Ram Siyah",
                    Price = 16170,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 90,
                    Name = "Nothing Phone 2A Plus 256 GB 12 GB Ram Gri",
                    Description = "Nothing Phone 2A Plus 256 GB 12 GB Ram Gri",
                    Price = 22999,
                    BrandId = 14,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 91,
                    Name = "Samsung Galaxy S24 Fe 256 GB 8 GB Ram Grafit",
                    Description = "Samsung Galaxy S24 Fe 256 GB 8 GB Ram Grafit",
                    Price = 26299,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.6M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 92,
                    Name = "Apple iPhone 16e 128GB Beyaz",
                    Description = "Apple iPhone 16e 128GB Beyaz",
                    Price = 44799,
                    BrandId = 1,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.7M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 93,
                    Name = "Samsung Galaxy S24 FE 128 GB 8 GB Ram Mavi",
                    Description = "Samsung Galaxy S24 FE 128 GB 8 GB Ram Mavi",
                    Price = 23849,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.6M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 94,
                    Name = "Samsung Galaxy S25+ 256 GB 12 GB Ram Lacivert",
                    Description = "Samsung Galaxy S25+ 256 GB 12 GB Ram Lacivert",
                    Price = 54799,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.8M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 95,
                    Name = "Samsung B310 Dual Sim Lacivert",
                    Description = "Samsung B310 Dual Sim Lacivert",
                    Price = 1149,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 3.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 96,
                    Name = "Samsung Galaxy S23 Ultra 512 GB 12 GB Ram Altın",
                    Description = "Samsung Galaxy S23 Ultra 512 GB 12 GB Ram Altın",
                    Price = 48899,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.9M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 97,
                    Name = "Redmi Note 14 Pro 12GB 512GB",
                    Description = "Redmi Note 14 Pro 12GB 512GB",
                    Price = 18999,
                    BrandId = 16,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 98,
                    Name = "Samsung B310E Dual Sim Kamerasız Cep Telefonu Beyaz",
                    Description = "Samsung B310E Dual Sim Kamerasız Cep Telefonu Beyaz",
                    Price = 1149,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 3.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 99,
                    Name = "Samsung Galaxy A55 128 GB 8 GB Ram Açık Mavi",
                    Description = "Samsung Galaxy A55 128 GB 8 GB Ram Açık Mavi",
                    Price = 16507,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 100,
                    Name = "Samsung Galaxy A35 128 GB 8 GB Ram Siyah",
                    Description = "Samsung Galaxy A35 128 GB 8 GB Ram Siyah",
                    Price = 13559,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.3M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 101,
                    Name = "Redmi Note 14 Pro 8GB 256GB",
                    Description = "Redmi Note 14 Pro 8GB 256GB",
                    Price = 16599,
                    BrandId = 16,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 102,
                    Name = "Apple iPhone 15 256 GB Mavi",
                    Description = "Apple iPhone 15 256 GB Mavi",
                    Price = 55999,
                    BrandId = 1,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.8M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 103,
                    Name = "Apple iPhone 16 Pro 256GB Beyaz",
                    Description = "Apple iPhone 16 Pro 256GB Beyaz",
                    Price = 84599,
                    BrandId = 1,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.9M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 104,
                    Name = "Xiaomi 14T Pro 12GB 512GB",
                    Description = "Xiaomi 14T Pro 12GB 512GB",
                    Price = 41000,
                    BrandId = 8,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 105,
                    Name = "Apple iPhone 16 Pro 128GB Beyaz",
                    Description = "Apple iPhone 16 Pro 128GB Beyaz",
                    Price = 78499,
                    BrandId = 1,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 4.8M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 106,
                    Name = "HONOR 200 512 GB 12 GB Ram Zümrüt Yeşili",
                    Description = "HONOR 200 512 GB 12 GB Ram Zümrüt Yeşili",
                    Price = 23999,
                    BrandId = 13,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 107,
                    Name = "Apple iPhone 16 Pro 256GB Siyah",
                    Description = "Apple iPhone 16 Pro 256GB Siyah",
                    Price = 88825,
                    BrandId = 1,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 108,
                    Name = "Xiaomi Redmi Note 13 Pro 256GB 8gb Ram Mor",
                    Description = "Xiaomi Redmi Note 13 Pro 256GB 8gb Ram Mor",
                    Price = 15999,
                    BrandId = 16,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 109,
                    Name = "Samsung Galaxy S25 128 GB 12 GB Ram Lacivert",
                    Description = "Samsung Galaxy S25 128 GB 12 GB Ram Lacivert",
                    Price = 45999,
                    BrandId = 9,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 110,
                    Name = "Apple iPhone 16 256GB Lacivert Taş",
                    Description = "Apple iPhone 16 256GB Lacivert Taş",
                    Price = 66999,
                    BrandId = 1,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 111,
                    Name = "Xiaomi Redmi Note 14 Pro Plus 5g 512 GB 12 GB Ram",
                    Description = "Xiaomi Redmi Note 14 Pro Plus 5g 512 GB 12 GB Ram",
                    Price = 27250,
                    BrandId = 16,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 112,
                    Name = "Apple iPhone 16 Pro Max 512GB Natürel Titanyum",
                    Description = "Apple iPhone 16 Pro Max 512GB Natürel Titanyum",
                    Price = 101939,
                    BrandId = 1,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 113,
                    Name = "Samsung Galaxy A04S 64 GB Siyah",
                    Description = "Samsung Galaxy A04S 64 GB Siyah",
                    Price = 6839,
                    BrandId = 9,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 114,
                    Name = "Redmi Note 14 Pro 5G 12GB 512GB",
                    Description = "Redmi Note 14 Pro 5G 12GB 512GB",
                    Price = 22500,
                    BrandId = 16,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 115,
                    Name = "Nothing Phone 1 128 GB 8 GB Ram Siyah",
                    Description = "Nothing Phone 1 128 GB 8 GB Ram Siyah",
                    Price = 12999,
                    BrandId = 14,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 116,
                    Name = "Xiaomi Redmi Note 13 Pro 512GB 12GB Siyah",
                    Description = "Xiaomi Redmi Note 13 Pro 512GB 12GB Siyah",
                    Price = 18999,
                    BrandId = 16,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 117,
                    Name = "Xiaomi Redmi 12 128 GB 8 GB Ram Siyah",
                    Description = "Xiaomi Redmi 12 128 GB 8 GB Ram Siyah",
                    Price = 8190,
                    BrandId = 16,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 118,
                    Name = "HONOR Magic V3 512 GB 12 GB Ram Yeşil",
                    Description = "HONOR Magic V3 512 GB 12 GB Ram Yeşil",
                    Price = 79999,
                    BrandId = 13,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 119,
                    Name = "Tecno Spark 30 256 GB 8 GB Ram",
                    Description = "Tecno Spark 30 256 GB 8 GB Ram",
                    Price = 9199,
                    BrandId = 21,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 120,
                    Name = "Samsung Galaxy S25 Ultra 1 Tb 12 GB Ram",
                    Description = "Samsung Galaxy S25 Ultra 1 Tb 12 GB Ram",
                    Price = 88999,
                    BrandId = 9,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 121,
                    Name = "Apple iPhone 16 Pro 128GB Siyah",
                    Description = "Apple iPhone 16 Pro 128GB Siyah",
                    Price = 79324,
                    BrandId = 1,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 122,
                    Name = "Reeder P13 Blue Max L 2022 64 GB Beyaz",
                    Description = "Reeder P13 Blue Max L 2022 64 GB Beyaz",
                    Price = 3399,
                    BrandId = 20,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 123,
                    Name = "POCO X7 12GB 512GB",
                    Description = "POCO X7 12GB 512GB",
                    Price = 17499,
                    BrandId = 17,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 124,
                    Name = "Oppo A60 8GB 256GB Mavi",
                    Description = "Oppo A60 8GB 256GB Mavi",
                    Price = 10199,
                    BrandId = 18,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 125,
                    Name = "Samsung Galaxy A25 5G 256 GB 8 GB Ram Siyah",
                    Description = "Samsung Galaxy A25 5G 256 GB 8 GB Ram Siyah",
                    Price = 13250,
                    BrandId = 9,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 126,
                    Name = "Samsung Galaxy S25 256 GB Lacivert",
                    Description = "Samsung Galaxy S25 256 GB Lacivert",
                    Price = 47670,
                    BrandId = 9,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 127,
                    Name = "Panasonic KX-TU550EXB Katlanabilir Renkli Ekran 4g Tuşlu Cep Telefonu Siyah",
                    Description = "Panasonic KX-TU550EXB Katlanabilir Renkli Ekran 4g Tuşlu Cep Telefonu Siyah",
                    Price = 4269,
                    BrandId = 19,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 128,
                    Name = "Reeder S19 Max Pro 256 GB 6 GB Ram Siyah",
                    Description = "Reeder S19 Max Pro 256 GB 6 GB Ram Siyah",
                    Price = 4799,
                    BrandId = 20,
                    CategoryId = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 129,
                    Name = "Samsung B310E Cep Telefonu Beyaz",
                    Description = "Samsung B310E Cep Telefonu Beyaz",
                    Price = 1149,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
                    Stock = 50,
                    HasDiscount = false,
                    Rating = 3.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                }
            };
        }
    }
}
