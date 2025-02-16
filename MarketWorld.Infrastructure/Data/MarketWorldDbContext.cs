using Microsoft.EntityFrameworkCore;
using MarketWorld.Domain.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

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
        // Burada entity konfigürasyonları yapılacak
    }
}