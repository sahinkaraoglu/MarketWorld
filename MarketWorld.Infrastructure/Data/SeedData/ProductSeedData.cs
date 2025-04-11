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
                    Price = 100149,
                    BrandId = 1,
                    CategoryId = 1,
                    SubCategoryId = 3,
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
                    Price = 100149,
                    BrandId = 9,
                    CategoryId = 1,
                    SubCategoryId = 3,
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
                    HasDiscount = false,
                    Rating = 3.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 130,
                    Name = "Arçelik 6167 6 Programlı Beyaz Bulaşık Makinesi",
                    Description = "Arçelik 6167 6 Programlı Beyaz Bulaşık Makinesi",
                    Price = 25739.01M,
                    BrandId = 22, // Arçelik
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Bulaşık Makinesi alt kategorisi
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 131,
                    Name = "Kumtel Beyaz Cam Digital / Dokunmatik Ankastre Set",
                    Description = "Kumtel Beyaz Cam Digital / Dokunmatik Ankastre Set - 8 Programlı (KO-40 TAHDF Ocak B66-Sf2 Ddt Fırın DA6-835 Davlumbaz)",
                    Price = 11299M,
                    BrandId = 23, // Kumtel
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Bulaşık Makinesi alt kategorisi
                    HasDiscount = false,
                    Rating = 4.1M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 132,
                    Name = "Regal Bm 310 3 Programlı Bulaşık Makinesi",
                    Description = "Regal Bm 310 3 Programlı Bulaşık Makinesi",
                    Price = 11549M,
                    BrandId = 24, // Regal
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Bulaşık Makinesi alt kategorisi
                    HasDiscount = false,
                    Rating = 4.6M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 133,
                    Name = "Profilo BM6320MA D Enerji Sınıfı 6 Programlı Bulaşık Makinesi",
                    Description = "Profilo BM6320MA D Enerji Sınıfı 6 Programlı Bulaşık Makinesi",
                    Price = 15999M,
                    BrandId = 25, // Profilo
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Bulaşık Makinesi alt kategorisi
                    HasDiscount = false,
                    Rating = 4.7M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 134,
                    Name = "Altus AL 7103 MD 1000 Devir 7 kg Çamaşır Makinesi",
                    Description = "Altus AL 7103 MD 1000 Devir 7 kg Çamaşır Makinesi",
                    Price = 12479M,
                    BrandId = 26, // Altus
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Çamaşır Makinesi alt kategorisi
                    HasDiscount = false,
                    Rating = 4.6M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 135,
                    Name = "Altus AL 10123 D C Enerji 10 Kg Çamaşır Makinesi",
                    Description = "Altus AL 10123 D C Enerji 10 Kg Çamaşır Makinesi",
                    Price = 17028M,
                    BrandId = 26, // Altus
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Çamaşır Makinesi alt kategorisi
                    HasDiscount = false,
                    Rating = 4.7M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 136,
                    Name = "Hoover NDEH 10A2TSBE-17 10 kg Isı Pompalı Kurutma Makinesi",
                    Description = "Hoover NDEH 10A2TSBE-17 10 kg Wi-Fi + Bluetooth Bağlantılı Isı Pompalı Kurutma Makinesi",
                    Price = 14999M,
                    BrandId = 27, // Hoover
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Kurutma Makinesi alt kategorisi
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 137,
                    Name = "Arçelik 7103 D 7 Kg 1000 Devir Çamaşır Makinesi",
                    Description = "Arçelik 7103 D 7 Kg 1000 Devir Çamaşır Makinesi",
                    Price = 14999M,
                    BrandId = 22, // Arçelik
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Çamaşır Makinesi alt kategorisi
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 138,
                    Name = "Uğur UES 507 D/S 3 Kapılı No-Frost Buzdolabı",
                    Description = "Uğur UES 507 D/S 3 Kapılı No-Frost Buzdolabı",
                    Price = 29999M,
                    BrandId = 28, // Uğur
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Buzdolabı alt kategorisi
                    HasDiscount = false,
                    Rating = 4.3M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 139,
                    Name = "Vestel NF480 EX Siyah No-Frost Buzdolabı",
                    Description = "Vestel NF480 EX A++ Siyah 453 Lt No-Frost Buzdolabı",
                    Price = 23599M,
                    BrandId = 33, // Vestel
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Buzdolabı alt kategorisi
                    HasDiscount = false,
                    Rating = 4.4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 140,
                    Name = "Regal 90 LT A+ Mini Buzdolabı",
                    Description = "Regal 90 LT A+ Mini Buzdolabı",
                    Price = 6499M,
                    BrandId = 24, // Regal
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Buzdolabı alt kategorisi
                    HasDiscount = false,
                    Rating = 4.6M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 141,
                    Name = "Arnell Ankastre Set",
                    Description = "Arnell Ankastre Set (8665 MDOC Ankastre Fırın + 1140-CSBDF 4 Gözlü Ocak + DS3490EC / EC3490 Davlumbaz)",
                    Price = 13499M,
                    BrandId = 29, // Arnell
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Ankastre alt kategorisi
                    HasDiscount = false,
                    Rating = 4.2M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 142,
                    Name = "Evora Siyah Cam Set",
                    Description = "Evora 3'lü Siyah Cam Ankastre Set (EAF-6056 Fırın + EAO-8505 Ocak + EAD-9263 Davlumbaz)",
                    Price = 10990M,
                    BrandId = 30, // Evora
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Ankastre alt kategorisi
                    HasDiscount = false,
                    Rating = 4.1M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 143,
                    Name = "Albergio AL-FO-005-E Ankastre Fırın",
                    Description = "Albergio AL-FO-005-E Ankastre Fırın",
                    Price = 5499M,
                    BrandId = 31, // Albergio
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Ankastre alt kategorisi
                    HasDiscount = false,
                    Rating = 4.0M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 144,
                    Name = "Kiwi KSW-4215 Beyaz Soğuk Su Sebili",
                    Description = "Kiwi KSW-4215 Beyaz Soğuk Su Sebili",
                    Price = 1299M,
                    BrandId = 32, // Kiwi
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Su Sebili alt kategorisi
                    HasDiscount = false,
                    Rating = 3.9M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 145,
                    Name = "Vestel SP 100 Beyaz Soğuk Su Sebili",
                    Description = "Vestel SP 100 Beyaz Soğuk Su Sebili",
                    Price = 1499M,
                    BrandId = 33, // Vestel
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Su Sebili alt kategorisi
                    HasDiscount = false,
                    Rating = 4.0M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 146,
                    Name = "Arçelik 1100 S Beyaz Su Sebili",
                    Description = "Arçelik 1100 S Beyaz Su Sebili",
                    Price = 1999M,
                    BrandId = 22, // Arçelik
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Su Sebili alt kategorisi
                    HasDiscount = false,
                    Rating = 4.2M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 147,
                    Name = "Profilo SP 100 Sıcak/Soğuk Su Sebili",
                    Description = "Profilo SP 100 Sıcak/Soğuk Su Sebili",
                    Price = 2299M,
                    BrandId = 25, // Profilo
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Su Sebili alt kategorisi
                    HasDiscount = false,
                    Rating = 4.3M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 148,
                    Name = "Arçelik 5500 BT Mini Fırın",
                    Description = "Arçelik 5500 BT Mini Fırın - 15 Litre",
                    Price = 4999M,
                    BrandId = 22, // Arçelik
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Mini Fırın alt kategorisi
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 149,
                    Name = "Kumtel KF3150 Mini Fırın",
                    Description = "Kumtel KF3150 Mini Fırın - 36 Litre Beyaz",
                    Price = 2699M,
                    BrandId = 23, // Kumtel
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Mini Fırın alt kategorisi
                    HasDiscount = false,
                    Rating = 4.3M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 150,
                    Name = "Vestel R8080 Retro Buzdolabı",
                    Description = "Vestel R8080 Retro Buzdolabı - Kırmızı",
                    Price = 28900M,
                    BrandId = 33, // Vestel
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Buzdolabı alt kategorisi
                    HasDiscount = false,
                    Rating = 4.7M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 151,
                    Name = "Arçelik 9144 YI Ultra Hijyen 9 Kg Çamaşır Makinesi",
                    Description = "Arçelik 9144 YI Ultra Hijyen 9 Kg 1400 Devir Çamaşır Makinesi",
                    Price = 21950M,
                    BrandId = 22, // Arçelik
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Çamaşır Makinesi alt kategorisi
                    HasDiscount = false,
                    Rating = 4.8M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 152,
                    Name = "Profilo CGA242X1TR A++ 9 Kg Çamaşır Makinesi",
                    Description = "Profilo CGA242X1TR A++ 9 Kg 1200 Devir Çamaşır Makinesi",
                    Price = 18999M,
                    BrandId = 25, // Profilo
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Çamaşır Makinesi alt kategorisi
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 153,
                    Name = "Regal Pratik 2000 Elektrikli Süpürge",
                    Description = "Regal Pratik 2000 Toz Torbasız Elektrikli Süpürge",
                    Price = 2999M,
                    BrandId = 24, // Regal
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Elektrikli Süpürge alt kategorisi
                    HasDiscount = false,
                    Rating = 4.2M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 154,
                    Name = "Vestel EKO PLUS Bulaşık Makinesi",
                    Description = "Vestel BM 5201 X EKO PLUS Bulaşık Makinesi",
                    Price = 12999M,
                    BrandId = 33, // Vestel
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Bulaşık Makinesi alt kategorisi
                    HasDiscount = false,
                    Rating = 4.3M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 155,
                    Name = "Arçelik K 3290 Telve Türk Kahve Makinesi",
                    Description = "Arçelik K 3290 Telve Otomatik Türk Kahve Makinesi - Siyah",
                    Price = 3299M,
                    BrandId = 22, // Arçelik
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Küçük Ev Aletleri alt kategorisi
                    HasDiscount = false,
                    Rating = 4.9M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 156,
                    Name = "Altus AL 413 E 4 Programlı Bulaşık Makinesi",
                    Description = "Altus AL 413 E 4 Programlı Bulaşık Makinesi",
                    Price = 13499M,
                    BrandId = 26, // Altus
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Bulaşık Makinesi alt kategorisi
                    HasDiscount = false,
                    Rating = 4.1M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 157,
                    Name = "Hoover HLWOQ 59B-S Çamaşır Kurutma Makinesi",
                    Description = "Hoover HLWOQ 59B-S 9 Kg Çamaşır Kurutma Makinesi",
                    Price = 17999M,
                    BrandId = 27, // Hoover
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Kurutma Makinesi alt kategorisi
                    HasDiscount = false,
                    Rating = 4.4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 158,
                    Name = "Vestel MAYA 10100 ST Çamaşır Makinesi",
                    Description = "Vestel MAYA 10100 ST 10 Kg 1000 Devir Çamaşır Makinesi",
                    Price = 14599M,
                    BrandId = 33, // Vestel
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 4, // Çamaşır Makinesi alt kategorisi
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 159,
                    Name = "Airfel LTXM35N 12000 BTU R32 Inverter Duvar Tipi Klima",
                    Description = "Airfel LTXM35N 12000 BTU R32 Inverter Duvar Tipi Klima",
                    Price = 25541.01M,
                    BrandId = 34, // Airfel
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.6M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 160,
                    Name = "Regal Luna A++ 15000 BTU Inverter Duvar Tipi Klima",
                    Description = "Regal Luna A++ 15000 BTU Inverter Duvar Tipi Klima",
                    Price = 26499M,
                    BrandId = 35, // Regal
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.6M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 161,
                    Name = "Kumtel Bej Fanlı Isıtıcı 2000 W LX - 6331",
                    Description = "Kumtel Bej Fanlı Isıtıcı 2000 W LX - 6331",
                    Price = 509M,
                    BrandId = 36, // Kumtel
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.2M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 162,
                    Name = "Bosch Climate CL2000U W 35 E A++ 12000 BTU Duvar Tipi Klima",
                    Description = "Bosch Climate CL2000U W 35 E A++ 12000 BTU Duvar Tipi Klima",
                    Price = 26999M,
                    BrandId = 37, // Bosch
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 163,
                    Name = "Kaira DTXR35E A++ 12000 BTU Wifi Inverter Duvar Tipi Klima",
                    Description = "Kaira DTXR35E A++ 12000 BTU Wifi Inverter Duvar Tipi Klima (Montaj Dahil)",
                    Price = 25840M,
                    BrandId = 38, // Kaira
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 164,
                    Name = "Kumtel Juniper Portatif Taşınabilir Klima Kmpac-7",
                    Description = "Kumtel Juniper Portatif Taşınabilir Klima Kmpac-7",
                    Price = 9999M,
                    BrandId = 36, // Kumtel
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.3M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 165,
                    Name = "Vestel Flora Doğa 124 A++ Wifi 12000 BTU Inverter Duvar Tipi Klima",
                    Description = "Vestel Flora Doğa 124 A++ Wifi 12000 BTU Inverter Duvar Tipi Klima",
                    Price = 26235M,
                    BrandId = 33, // Vestel
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.6M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 166,
                    Name = "Xiaomi ZMYDFS01DM Şarj Edilebilir Mini Fan",
                    Description = "Xiaomi ZMYDFS01DM Şarj Edilebilir Mini Fan",
                    Price = 1889M,
                    BrandId = 39, // Xiaomi
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 167,
                    Name = "Kumtel LX-2832 Siyah 1500 Watt Isıtıcı",
                    Description = "Kumtel LX-2832 Siyah 1500 Watt Isıtıcı",
                    Price = 549M,
                    BrandId = 36, // Kumtel
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 168,
                    Name = "Mirkraft Future 2500 Watt Elektrikli Isıtıcı",
                    Description = "Mirkraft Future 2500 Watt Elektrikli Isıtıcı - IP24 - LCD Ekran - Uzaktan Kumandalı - 4 Isı Ayarı",
                    Price = 5559.66M,
                    BrandId = 40, // Mirkraft
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 169,
                    Name = "Samsung Premium AR18TSHZHWK A++ 18000 BTU Inverter Duvar Tipi Klima",
                    Description = "Samsung Premium AR18TSHZHWK A++ 18000 BTU Inverter Duvar Tipi Klima",
                    Price = 38599M,
                    BrandId = 41, // Samsung
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 170,
                    Name = "Arnell Elektrikli Isıtıcı Quartz",
                    Description = "Arnell Elektrikli Isıtıcı Quartz Ev Ve Ofis Oda Tipi 3+1 Çubuklu Güvenli Elektrikli Soba - 2600 Watt",
                    Price = 2218.63M,
                    BrandId = 42, // Arnell
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 3M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 171,
                    Name = "Kumtel Ks-2760 Quartz Isıtıcı Siyah",
                    Description = "Kumtel Ks-2760 Quartz Isıtıcı Siyah",
                    Price = 999M,
                    BrandId = 36, // Kumtel
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.1M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 172,
                    Name = "Zeeful Süper Güç Üfleyici Mini Turbo Jet Fan",
                    Description = "Zeeful Süper Güç Üfleyici Mini Turbo Jet Fan 130000RPM 52+M/s 4000MAH (Yurt Dışından)",
                    Price = 1750.32M,
                    BrandId = 43, // Zeeful
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 173,
                    Name = "Beko 31225 Ekolojik A++ 12000 BTU Duvar Tipi Klima",
                    Description = "Beko 31225 Ekolojik A++ 12000 BTU Duvar Tipi Klima",
                    Price = 27754.65M,
                    BrandId = 44, // Beko
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.6M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 174,
                    Name = "Vestel Flora Doğa 244 A++ 24000 BTU Wifi Inverter Duvar Tipi Klima",
                    Description = "Vestel Flora Doğa 244 A++ 24000 BTU Wifi Inverter Duvar Tipi Klima",
                    Price = 42362.10M,
                    BrandId = 33, // Vestel
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 175,
                    Name = "Arçelik Ekolojik 18325 A++ 18000 BTU Inverter Duvar Tipi Klima",
                    Description = "Arçelik Ekolojik 18325 A++ 18000 BTU Inverter Duvar Tipi Klima",
                    Price = 39897M,
                    BrandId = 45, // Arçelik
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 176,
                    Name = "Arnell Elektrikli Isıtıcı Duvar Tip Soba",
                    Description = "Arnell Elektrikli Isıtıcı Duvar Tip Soba 3000 Watt",
                    Price = 1431.06M,
                    BrandId = 42, // Arnell
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.8M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 177,
                    Name = "Baymak Elegant Plus UV 18 A++ 18000 BTU Duvar Tipi Klima",
                    Description = "Baymak Elegant Plus UV 18 A++ (Montaj Dahil) 18000 BTU Duvar Tipi Klima",
                    Price = 44989M,
                    BrandId = 46, // Baymak
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 178,
                    Name = "FujiPlus Sakura 12000 Btu Inverter Duvar Tipi Klima",
                    Description = "FujiPlus Fujiplus Sakura 12000 Btu Inverter Duvar Tipi Klima",
                    Price = 22777.03M,
                    BrandId = 47, // FujiPlus
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 3.9M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 179,
                    Name = "Baymak Aqua Konfor 65 Litre Termosifon",
                    Description = "Baymak Aqua Konfor 65 Litre Termosifon",
                    Price = 8439M,
                    BrandId = 46, // Baymak
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 180,
                    Name = "Kumtel Ecoray Ex-25 2500 Watt Duvar Tipi Infrared Isıtıcı",
                    Description = "Kumtel Ecoray Ex-25 2500 Watt Duvar Tipi Infrared Isıtıcı",
                    Price = 886.05M,
                    BrandId = 36, // Kumtel
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.3M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 181,
                    Name = "UFO Ufo Star 2400 W Duvar Tipi Isıtıcı",
                    Description = "UFO Ufo Star 2400 W Duvar Tipi Isıtıcı - Termostatlı",
                    Price = 4190M,
                    BrandId = 48, // UFO
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 182,
                    Name = "Abbruch Şarj Edilebilir Taşınabilir Mini El Fanı",
                    Description = "Abbruch Şarj Edilebilir Taşınabilir Ipli Mini El Fanı Üç Kademe Hızlı Güçlü Soğutucu Pervane Vantilatör",
                    Price = 289.90M,
                    BrandId = 49, // Abbruch
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 183,
                    Name = "Sinbo SF-6783 Vantilatör",
                    Description = "Sinbo SF-6783 Vantilatör",
                    Price = 1200M,
                    BrandId = 50, // Sinbo
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 3.4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 184,
                    Name = "Beko 31650 Vantilatör",
                    Description = "Beko 31650 Vantilatör uzaktan kumandalı",
                    Price = 3259M,
                    BrandId = 44, // Beko
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.6M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 185,
                    Name = "UFO Ufo Micatronic 1900 W Kule Tipi Isıtıcı",
                    Description = "UFO Ufo Micatronic 1900 W Kule Tipi Isıtıcı",
                    Price = 4390M,
                    BrandId = 48, // UFO
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 186,
                    Name = "UFO Omri 1200 W Termostatlı Isıtıcı",
                    Description = "UFO Omri 1200 W Termostatlı Hem Yatay Hem Dikey Isıtıcı",
                    Price = 3400M,
                    BrandId = 48, // UFO
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 3.9M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 187,
                    Name = "Kaira DTXR71E A++ 24000 BTU Inverter Duvar Tipi Klima",
                    Description = "Kaira DTXR71E A++ 24000 BTU Inverter Duvar Tipi Klima (Montaj Dahil)",
                    Price = 45250.40M,
                    BrandId = 38, // Kaira
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 188,
                    Name = "Baymak Duo Tec Compact Premix 24 kw Yoğuşmalı Kombi",
                    Description = "Baymak Duo Tec Compact Premix 24 kw Yoğuşmalı Kombi (Baca Dahil)",
                    Price = 27400M,
                    BrandId = 46, // Baymak
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.6M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 189,
                    Name = "UFO ISITICI STAR S/19 1900 W",
                    Description = "UFO ISITICI STAR S/19 1900 W",
                    Price = 3690M,
                    BrandId = 48, // UFO
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 190,
                    Name = "Magiceham Lilo Stitch Peluş Sıcak Su Isıtıcısı",
                    Description = "Magiceham Lilo Stitch Peluş Sıcak Su Isıtıcısı - Lacivert (Yurt Dışından)",
                    Price = 528.45M,
                    BrandId = 51, // Magiceham
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 4.6M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 191,
                    Name = "Xnews A Üstü USB Fan Soğutucu",
                    Description = "Xnews A Üstü USB Fan Soğutucu Vantilatör Klima USB Girişli Metal Serinlci Fan Mini Vantilatör Fan Klima Fan",
                    Price = 269.90M,
                    BrandId = 64, // Xnews
                    CategoryId = 1, // Beyaz Eşya kategorisi
                    SubCategoryId = 5, // Klima alt kategorisi
                    HasDiscount = false,
                    Rating = 5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 192,
                    Name = "Lacoste Sport Court-Master Pro Erkek Siyah Sneaker 744SMA0084 02H",
                    Description = "Lacoste Sport Court-Master Pro Erkek Siyah Sneaker 744SMA0084 02H",
                    Price = 3239.10M,
                    BrandId = 65, // Lacoste
                    CategoryId = 2, // Ayakkabı ve Çanta kategorisi
                    SubCategoryId = 6, // Ayakkabı alt kategorisi
                    HasDiscount = false,
                    Rating = 4.9M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 193,
                    Name = "Letoon 2104 Günlük Unisex Spor Ayakkabı",
                    Description = "Letoon 2104 Günlük Unisex Spor Ayakkabı",
                    Price = 564M,
                    BrandId = 66, // Letoon
                    CategoryId = 2,
                    SubCategoryId = 6,
                    HasDiscount = false,
                    Rating = 4.2M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 194,
                    Name = "Derilax Hakiki Deri Tam Ortopedik Erkek Ayakkabı",
                    Description = "Derilax Hakiki Deri Tam Ortopedik Erkek Ayakkabı",
                    Price = 1200M,
                    BrandId = 67, // Derilax
                    CategoryId = 2,
                    SubCategoryId = 6,
                    HasDiscount = false,
                    Rating = 4.6M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 195,
                    Name = "Hotiç Hakiki Deri Siyah Erkek Günlük Ayakkabı",
                    Description = "Hotiç Hakiki Deri Siyah Erkek Günlük Ayakkabı",
                    Price = 1679.40M,
                    BrandId = 68, // Hotiç
                    CategoryId = 2,
                    SubCategoryId = 6,
                    HasDiscount = false,
                    Rating = 4.1M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 196,
                    Name = "Ispartalılar 7575 Ortopedik Taban Yumuşak Hakiki Deri Mevsimlik Kışlık Erkek Ayakkabı",
                    Description = "Ispartalılar 7575 Ortopedik Taban Yumuşak Hakiki Deri Mevsimlik Kışlık Erkek Ayakkabı",
                    Price = 670.65M,
                    BrandId = 69, // Ispartalılar
                    CategoryId = 2,
                    SubCategoryId = 6,
                    HasDiscount = false,
                    Rating = 4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 197,
                    Name = "Under Armour Çocuk Ua Bgs Charged Rogue 4 Koşu Ayakkabısı 3027106-400",
                    Description = "Under Armour Çocuk Ua Bgs Charged Rogue 4 Koşu Ayakkabısı 3027106-400",
                    Price = 2090M,
                    BrandId = 70, // Under Armour
                    CategoryId = 2,
                    SubCategoryId = 6,
                    HasDiscount = false,
                    Rating = 5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 198,
                    Name = "Ispartalılar 502 Ortopedik Topuk Masajlı Hakiki Deri Kışlık Erkek Ayakkabı Bağcıklı",
                    Description = "Ispartalılar 502 Ortopedik Topuk Masajlı Hakiki Deri Kışlık Erkek Ayakkabı Bağcıklı",
                    Price = 679.15M,
                    BrandId = 69, // Ispartalılar
                    CategoryId = 2,
                    SubCategoryId = 6,
                    HasDiscount = false,
                    Rating = 4M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 199,
                    Name = "Muggo Samuel Garantili Günlük Klasik Deri Casual Rahat Ortopedik Kalın Taban Erkek Ayakkabı",
                    Description = "Muggo Samuel Garantili Günlük Klasik Deri Casual Rahat Ortopedik Kalın Taban Erkek Ayakkabı",
                    Price = 899.90M,
                    BrandId = 71, // Muggo
                    CategoryId = 2,
                    SubCategoryId = 6,
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 200,
                    Name = "Tomiross Erkek Atlanta Günlük Kullanım Sneaker Ayakkabı ATLNT-5025",
                    Description = "Tomiross Erkek Atlanta Günlük Kullanım Sneaker Ayakkabı ATLNT-5025",
                    Price = 699.90M,
                    BrandId = 72, // Tomiross
                    CategoryId = 2,
                    SubCategoryId = 6,
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 201,
                    Name = "Yaya By Hotic 02ayy296160a100 Siyah Erkek Ayakkabı",
                    Description = "Yaya By Hotic 02ayy296160a100 Siyah Erkek Ayakkabı",
                    Price = 899.90M,
                    BrandId = 73, // Yaya
                    CategoryId = 2,
                    SubCategoryId = 6,
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 202,
                    Name = "Hotic Hakiki Deri Lacivert Erkek Günlük Ayakkabı",
                    Description = "Hotic Hakiki Deri Lacivert Erkek Günlük Ayakkabı",
                    Price = 799.90M,
                    BrandId = 74, // Hotic
                    CategoryId = 2,
                    SubCategoryId = 6,
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 203,
                    Name = "Derilax Deri Tam Ortopedik Erkek Ayakkabı",
                    Description = "Derilax Deri Tam Ortopedik Erkek Ayakkabı",
                    Price = 699.90M,
                    BrandId = 75, // Derilax
                    CategoryId = 2,
                    SubCategoryId = 6,
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 204,
                    Name = "Ispartalılar 909 Tam Ortopedik Taban Hakiki Deri Erkek Ayakkabı",
                    Description = "Ispartalılar 909 Tam Ortopedik Taban Hakiki Deri Erkek Ayakkabı",
                    Price = 599.90M,
                    BrandId = 76, // Ispartalılar
                    CategoryId = 2,
                    SubCategoryId = 6,
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 205,
                    Name = "Selin Soylu Hakiki Deri Erkek Ayakkabı Kışlık Günlük Ayakkabı",
                    Description = "Selin Soylu Hakiki Deri Erkek Ayakkabı Kışlık Günlük Ayakkabı",
                    Price = 499.90M,
                    BrandId = 77, // Selin Soylu
                    CategoryId = 2,
                    SubCategoryId = 6,
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 206,
                    Name = "Sebago Nubuk Koyu Kahve Siyah Erkek Günlük Ayakkabı 7111m5w",
                    Description = "Sebago Nubuk Koyu Kahve Siyah Erkek Günlük Ayakkabı 7111m5w",
                    Price = 399.90M,
                    BrandId = 78, // Sebago
                    CategoryId = 2,
                    SubCategoryId = 6,
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 207,
                    Name = "Lumberjack 4m Navigator 4fx",
                    Description = "Lumberjack 4m Navigator 4fx",
                    Price = 299.90M,
                    BrandId = 79, // Lumberjack
                    CategoryId = 2,
                    SubCategoryId = 6,
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 208,
                    Name = "Sebago Deri Lacivert Erkek Günlük Ayakkabı 70004z0",
                    Description = "Sebago Deri Lacivert Erkek Günlük Ayakkabı 70004z0",
                    Price = 199.90M,
                    BrandId = 78, // Sebago
                    CategoryId = 2,
                    SubCategoryId = 6,
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 209,
                    Name = "Dakirs Yazlık Erkek Keten Günlük Rahat Hafif Bağcıklı Spor Ayakkabı 40-44",
                    Description = "Dakirs Yazlık Erkek Keten Günlük Rahat Hafif Bağcıklı Spor Ayakkabı 40-44",
                    Price = 99.90M,
                    BrandId = 80, // Dakirs
                    CategoryId = 2,
                    SubCategoryId = 6,
                    HasDiscount = false,
                    Rating = 4.5M,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                }
            };
        }
    }
}
