using Microsoft.EntityFrameworkCore;
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

        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<SubCategories> SubCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Products>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Categories>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<SubCategories>()
                .Property(sc => sc.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Products>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Products>()
                .HasOne(p => p.SubCategory)
                .WithMany(sc => sc.Products)
                .HasForeignKey("SubCategoryId")
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<SubCategories>()
                .HasOne(sc => sc.Categories)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(sc => sc.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
                
            // Kategori seed verileri
            modelBuilder.Entity<Categories>().HasData(
                new Categories
                {
                    Id = 1,
                    Name = "Elektronik",
                    Description = "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar",
                    CreatedDate = DateTime.Now
                },
                new Categories
                {
                    Id = 2,
                    Name = "Giyim & Aksesuar",
                    Description = "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları",
                    CreatedDate = DateTime.Now
                },
                new Categories
                {
                    Id = 3,
                    Name = "Ev & Yaşam",
                    Description = "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili",
                    CreatedDate = DateTime.Now
                },
                new Categories
                {
                    Id = 4,
                    Name = "Kozmetik & Kişisel Bakım",
                    Description = "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri",
                    CreatedDate = DateTime.Now
                },
                new Categories
                {
                    Id = 5,
                    Name = "Spor & Outdoor",
                    Description = "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri",
                    CreatedDate = DateTime.Now
                }
            );
            
            // Alt kategori seed verileri
            modelBuilder.Entity<SubCategories>().HasData(
                // Elektronik kategorisi (CategoryId=1) için alt kategoriler
                new SubCategories
                {
                    Id = 1,
                    Name = "Bilgisayarlar & Tabletler",
                    Description = "Dizüstü, masaüstü bilgisayarlar ve tabletler",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 2,
                    Name = "Yazıcılar & Projeksiyon",
                    Description = "Yazıcılar, tarayıcılar ve projeksiyon cihazları",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 3,
                    Name = "Telefonlar",
                    Description = "Akıllı telefonlar ve aksesuarları",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 4,
                    Name = "Beyaz Eşya",
                    Description = "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 5,
                    Name = "Klima ve Isıtıcılar",
                    Description = "Klimalar, ısıtıcılar ve hava temizleyiciler",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now
                },
                
                // Giyim & Aksesuar kategorisi (CategoryId=2) için alt kategoriler
                new SubCategories
                {
                    Id = 6,
                    Name = "Ayakkabı & Çanta",
                    Description = "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 7,
                    Name = "Kadın Giyim",
                    Description = "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 8,
                    Name = "Erkek Giyim",
                    Description = "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 9,
                    Name = "Çocuk Giyim",
                    Description = "Kız ve erkek çocuk giyim ürünleri",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now
                },
                
                // Ev & Yaşam kategorisi (CategoryId=3) için alt kategoriler
                new SubCategories
                {
                    Id = 10,
                    Name = "Mobilya",
                    Description = "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 11,
                    Name = "Ev Tekstili",
                    Description = "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 12,
                    Name = "Dekorasyon & Aydınlatma",
                    Description = "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 13,
                    Name = "Mutfak Gereçleri",
                    Description = "Pişirme, servis ve saklama ürünleri, mutfak aletleri",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 14,
                    Name = "Banyo & Ev Gereçleri",
                    Description = "Banyo aksesuarları, temizlik ve düzenleme ürünleri",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 15,
                    Name = "Kırtasiye & Ofis",
                    Description = "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                
                // Kozmetik & Kişisel Bakım kategorisi (CategoryId=4) için alt kategoriler
                new SubCategories
                {
                    Id = 16,
                    Name = "Parfüm & Deodorant",
                    Description = "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 17,
                    Name = "Saç Şekillendirme",
                    Description = "Saç bakım ve şekillendirme ürünleri",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 18,
                    Name = "Cilt Bakımı",
                    Description = "Yüz ve vücut bakım ürünleri, kremler ve serumlar",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 19,
                    Name = "Makyaj",
                    Description = "Renkli kozmetik ve makyaj malzemeleri",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 20,
                    Name = "Sağlık & Medikal Ürünler",
                    Description = "Vitamin, takviye gıdalar ve medikal ürünler",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 21,
                    Name = "Ağız & Diş Bakımı",
                    Description = "Diş bakım ürünleri ve ağız bakım ürünleri",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                
                // Spor & Outdoor kategorisi (CategoryId=5) için alt kategoriler
                new SubCategories
                {
                    Id = 22,
                    Name = "Fitness & Kondisyon",
                    Description = "Fitness ekipmanları, kondisyon aletleri ve aksesuarları",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 23,
                    Name = "Spor Giyim & Ayakkabı",
                    Description = "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 24,
                    Name = "Outdoor & Kamp",
                    Description = "Kamp malzemeleri, outdoor giyim ve ekipmanlar",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 25,
                    Name = "Kış Sporları",
                    Description = "Kayak ekipmanları ve kış sporları malzemeleri",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now
                },
                new SubCategories
                {
                    Id = 26,
                    Name = "Su Sporları",
                    Description = "Yüzme ve su sporları ekipmanları",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now
                }
            );
        }
    }
}