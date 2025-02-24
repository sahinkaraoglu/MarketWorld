using Microsoft.EntityFrameworkCore;
using MarketWorld.Domain.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

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

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Category>()
                .HasOne(c => c.Parent)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(c => c.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Category>().HasData(
                new Category 
                { 
                    Id = 1, 
                    Name = "Elektronik",
                    Description = "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar",
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 2, 
                    Name = "Giyim & Aksesuar",
                    Description = "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları",
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 3, 
                    Name = "Ev & Yaşam",
                    Description = "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili",
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 4, 
                    Name = "Kozmetik & Kişisel Bakım",
                    Description = "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri",
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 5, 
                    Name = "Spor & Outdoor",
                    Description = "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri",
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 6, 
                    Name = "Bilgisayarlar & Tabletler",
                    Description = "Dizüstü, masaüstü bilgisayarlar ve tabletler",
                    ParentId = 1,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 7, 
                    Name = "Yazıcılar & Projeksiyon",
                    Description = "Yazıcılar, tarayıcılar ve projeksiyon cihazları",
                    ParentId = 1,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 8, 
                    Name = "Telefonlar",
                    Description = "Akıllı telefonlar ve aksesuarları",
                    ParentId = 1,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 9, 
                    Name = "Beyaz Eşya",
                    Description = "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar",
                    ParentId = 1,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 10, 
                    Name = "Klima ve Isıtıcılar",
                    Description = "Klimalar, ısıtıcılar ve hava temizleyiciler",
                    ParentId = 1,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 11, 
                    Name = "Ayakkabı & Çanta",
                    Description = "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar",
                    ParentId = 2,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 12, 
                    Name = "Kadın Giyim",
                    Description = "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim",
                    ParentId = 2,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 13, 
                    Name = "Erkek Giyim",
                    Description = "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim",
                    ParentId = 2,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 14, 
                    Name = "Çocuk Giyim",
                    Description = "Kız ve erkek çocuk giyim ürünleri",
                    ParentId = 2,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 15, 
                    Name = "Mobilya",
                    Description = "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları",
                    ParentId = 3,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 16, 
                    Name = "Ev Tekstili",
                    Description = "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri",
                    ParentId = 3,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 17, 
                    Name = "Dekorasyon & Aydınlatma",
                    Description = "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri",
                    ParentId = 3,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 18, 
                    Name = "Mutfak Gereçleri",
                    Description = "Pişirme, servis ve saklama ürünleri, mutfak aletleri",
                    ParentId = 3,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 19, 
                    Name = "Banyo & Ev Gereçleri",
                    Description = "Banyo aksesuarları, temizlik ve düzenleme ürünleri",
                    ParentId = 3,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 20, 
                    Name = "Kırtasiye & Ofis",
                    Description = "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri",
                    ParentId = 3,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 21, 
                    Name = "Parfüm & Deodarant",
                    Description = "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri",
                    ParentId = 4,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 22, 
                    Name = "Saç Şekillendirme",
                    Description = "Saç bakım ve şekillendirme ürünleri",
                    ParentId = 4,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 23, 
                    Name = "Cilt Bakımı",
                    Description = "Yüz ve vücut bakım ürünleri, kremler ve serumlar",
                    ParentId = 4,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 24, 
                    Name = "Makyaj",
                    Description = "Renkli kozmetik ve makyaj malzemeleri",
                    ParentId = 4,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 25, 
                    Name = "Sağlık & Medikal Ürünler",
                    Description = "Vitamin, takviye gıdalar ve medikal ürünler",
                    ParentId = 4,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 26, 
                    Name = "Ağız & Diş Bakımı",
                    Description = "Diş bakım ürünleri ve ağız bakım ürünleri",
                    ParentId = 4,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 27, 
                    Name = "Fitness & Kondisyon",
                    Description = "Fitness ekipmanları, kondisyon aletleri ve aksesuarları",
                    ParentId = 5,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 28, 
                    Name = "Spor Giyim & Ayakkabı",
                    Description = "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar",
                    ParentId = 5,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 29, 
                    Name = "Outdoor & Kamp",
                    Description = "Kamp malzemeleri, outdoor giyim ve ekipmanlar",
                    ParentId = 5,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 30, 
                    Name = "Kış Sporları",
                    Description = "Kayak ekipmanları ve kış sporları malzemeleri",
                    ParentId = 5,
                    CreatedDate = new DateTime(2024, 1, 1)
                },
                new Category 
                { 
                    Id = 31, 
                    Name = "Su Sporları",
                    Description = "Yüzme ve su sporları ekipmanları",
                    ParentId = 5,
                    CreatedDate = new DateTime(2024, 1, 1)
                }
            );
        }
    }
}