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
                }
            );
        }
    }
}