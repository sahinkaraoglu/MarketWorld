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
        public DbSet<Category> Category { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Products>()
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

            modelBuilder.Entity<Products>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

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
        }
    }
}