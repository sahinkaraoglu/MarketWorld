﻿using Microsoft.EntityFrameworkCore;
using MarketWorld.Domain.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;
using System;

namespace MarketWorld.Infrastructure.Data
{
    public class MarketWorldDbContext : DbContext
    {
        public MarketWorldDbContext(DbContextOptions<MarketWorldDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Category>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<SubCategory>()
                .Property(sc => sc.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Product>()
                .HasOne(p => p.SubCategory)
                .WithMany(sc => sc.Products)
                .HasForeignKey("SubCategoryId")
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Product>()
                .Property(p => p.DiscountPrice)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Address>()
                .Property(a => a.AddressLine1)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Address>()
                .Property(a => a.City)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Order>()
                .Property(o => o.OrderNumber)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<Order>()
                .Property(o => o.TotalAmount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.UnitPrice)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Payment>()
                .Property(p => p.PaymentMethod)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(oi => oi.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Cart)
                .WithMany(c => c.CartItems)
                .HasForeignKey(ci => ci.CartId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Product)
                .WithMany(p => p.CartItems)
                .HasForeignKey(ci => ci.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SubCategory>()
                .HasOne(sc => sc.Category)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(sc => sc.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
                
            // Kategori seed verileri
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Elektronik",
                    Description = "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar",
                    CreatedDate = DateTime.Now
                },
                new Category
                {
                    Id = 2,
                    Name = "Giyim & Aksesuar",
                    Description = "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları",
                    CreatedDate = DateTime.Now
                },
                new Category
                {
                    Id = 3,
                    Name = "Ev & Yaşam",
                    Description = "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili",
                    CreatedDate = DateTime.Now
                },
                new Category
                {
                    Id = 4,
                    Name = "Kozmetik & Kişisel Bakım",
                    Description = "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri",
                    CreatedDate = DateTime.Now
                },
                new Category
                {
                    Id = 5,
                    Name = "Spor & Outdoor",
                    Description = "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri",
                    CreatedDate = DateTime.Now
                }
            );
            
            // Alt kategori seed verileri
            modelBuilder.Entity<SubCategory>().HasData(
                // Elektronik kategorisi (CategoryId=1) için alt kategoriler
                new SubCategory
                {
                    Id = 1,
                    Name = "Bilgisayarlar & Tabletler",
                    Description = "Dizüstü, masaüstü bilgisayarlar ve tabletler",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 2,
                    Name = "Yazıcılar & Projeksiyon",
                    Description = "Yazıcılar, tarayıcılar ve projeksiyon cihazları",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 3,
                    Name = "Telefonlar",
                    Description = "Akıllı telefonlar ve aksesuarları",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 4,
                    Name = "Beyaz Eşya",
                    Description = "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 5,
                    Name = "Klima ve Isıtıcılar",
                    Description = "Klimalar, ısıtıcılar ve hava temizleyiciler",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now
                },
                
                // Giyim & Aksesuar kategorisi (CategoryId=2) için alt kategoriler
                new SubCategory
                {
                    Id = 6,
                    Name = "Ayakkabı & Çanta",
                    Description = "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 7,
                    Name = "Kadın Giyim",
                    Description = "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 8,
                    Name = "Erkek Giyim",
                    Description = "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 9,
                    Name = "Çocuk Giyim",
                    Description = "Kız ve erkek çocuk giyim ürünleri",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now
                },
                
                // Ev & Yaşam kategorisi (CategoryId=3) için alt kategoriler
                new SubCategory
                {
                    Id = 10,
                    Name = "Mobilya",
                    Description = "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 11,
                    Name = "Ev Tekstili",
                    Description = "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 12,
                    Name = "Dekorasyon & Aydınlatma",
                    Description = "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 13,
                    Name = "Mutfak Gereçleri",
                    Description = "Pişirme, servis ve saklama ürünleri, mutfak aletleri",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 14,
                    Name = "Banyo & Ev Gereçleri",
                    Description = "Banyo aksesuarları, temizlik ve düzenleme ürünleri",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 15,
                    Name = "Kırtasiye & Ofis",
                    Description = "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                
                // Kozmetik & Kişisel Bakım kategorisi (CategoryId=4) için alt kategoriler
                new SubCategory
                {
                    Id = 16,
                    Name = "Parfüm & Deodorant",
                    Description = "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 17,
                    Name = "Saç Şekillendirme",
                    Description = "Saç bakım ve şekillendirme ürünleri",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 18,
                    Name = "Cilt Bakımı",
                    Description = "Yüz ve vücut bakım ürünleri, kremler ve serumlar",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 19,
                    Name = "Makyaj",
                    Description = "Renkli kozmetik ve makyaj malzemeleri",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 20,
                    Name = "Sağlık & Medikal Ürünler",
                    Description = "Vitamin, takviye gıdalar ve medikal ürünler",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 21,
                    Name = "Ağız & Diş Bakımı",
                    Description = "Diş bakım ürünleri ve ağız bakım ürünleri",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                
                // Spor & Outdoor kategorisi (CategoryId=5) için alt kategoriler
                new SubCategory
                {
                    Id = 22,
                    Name = "Fitness & Kondisyon",
                    Description = "Fitness ekipmanları, kondisyon aletleri ve aksesuarları",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 23,
                    Name = "Spor Giyim & Ayakkabı",
                    Description = "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 24,
                    Name = "Outdoor & Kamp",
                    Description = "Kamp malzemeleri, outdoor giyim ve ekipmanlar",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 25,
                    Name = "Kış Sporları",
                    Description = "Kayak ekipmanları ve kış sporları malzemeleri",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 26,
                    Name = "Su Sporları",
                    Description = "Yüzme ve su sporları ekipmanları",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now
                }
            );

            // Tüm entity'ler için BaseEntity'deki CreatedDate alanını nullable olmaktan çıkarıp 
            // otomatik değer ataması yapalım
            modelBuilder.Entity<User>()
                .Property(u => u.CreatedDate)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            modelBuilder.Entity<Order>()
                .Property(o => o.CreatedDate)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            modelBuilder.Entity<Address>()
                .Property(a => a.CreatedDate)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            modelBuilder.Entity<Cart>()
                .Property(c => c.CreatedDate)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            modelBuilder.Entity<Payment>()
                .Property(p => p.CreatedDate)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();
        }
    }
}