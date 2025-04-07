using Microsoft.EntityFrameworkCore;
using MarketWorld.Domain.Entities;
using MarketWorld.Infrastructure.Data.SeedData;

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
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<PropertyValue> PropertyValues { get; set; }
        public DbSet<ProductProperty> ProductProperties { get; set; }
        public DbSet<Brand> Brands { get; set; }

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

            modelBuilder.Entity<CartItem>()
                .Property(ci => ci.UnitPrice)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<CartItem>()
                .Property(ci => ci.Quantity)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Category>()
                .HasMany(c => c.SubCategories)
                .WithOne(sc => sc.Category)
                .HasForeignKey(sc => sc.CategoryId);

            modelBuilder.Entity<SubCategory>()
                .HasOne(sc => sc.Category)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(sc => sc.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
                
            // Önce kategorileri ekle
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Elektronik",
                    ShortenedEntityName = "elektronik",
                    Description = "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar",
                    CreatedDate = DateTime.Now
                },
                new Category
                {
                    Id = 2,
                    Name = "Giyim & Aksesuar",
                    ShortenedEntityName = "giyim-aksesuar",
                    Description = "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları",
                    CreatedDate = DateTime.Now
                },
                new Category
                {
                    Id = 3,
                    Name = "Ev & Yaşam",
                    ShortenedEntityName = "ev-yasam",
                    Description = "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili",
                    CreatedDate = DateTime.Now
                },
                new Category
                {
                    Id = 4,
                    Name = "Kozmetik & Kişisel Bakım",
                    ShortenedEntityName = "kozmetik-kisisel-bakim",
                    Description = "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri",
                    CreatedDate = DateTime.Now
                },
                new Category
                {
                    Id = 5,
                    Name = "Spor & Outdoor",
                    ShortenedEntityName = "spor-outdoor",
                    Description = "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri",
                    CreatedDate = DateTime.Now
                }
            );
            
            // Sonra alt kategorileri ekle
            modelBuilder.Entity<SubCategory>().HasData(
                // Elektronik kategorisi (CategoryId=1) için alt kategoriler
                new SubCategory
                {
                    Id = 1,
                    Name = "Bilgisayarlar & Tabletler",
                    ShortenedEntityName = "bilgisayarlar-tabletler",
                    Description = "Dizüstü, masaüstü bilgisayarlar ve tabletler",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 2,
                    Name = "Yazıcılar & Projeksiyon",
                    ShortenedEntityName = "yazicilar-projeksiyon",
                    Description = "Yazıcılar, tarayıcılar ve projeksiyon cihazları",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 3,
                    Name = "Telefonlar",
                    ShortenedEntityName = "telefonlar",
                    Description = "Akıllı telefonlar ve aksesuarları",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 4,
                    Name = "Beyaz Eşya",
                    ShortenedEntityName = "beyaz-esya",
                    Description = "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 5,
                    Name = "Klima ve Isıtıcılar",
                    ShortenedEntityName = "klima-isitici",
                    Description = "Klimalar, ısıtıcılar ve hava temizleyiciler",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now
                },
                
                // Giyim & Aksesuar kategorisi (CategoryId=2) için alt kategoriler
                new SubCategory
                {
                    Id = 6,
                    Name = "Ayakkabı & Çanta",
                    ShortenedEntityName = "ayakkabi-canta",
                    Description = "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 7,
                    Name = "Kadın Giyim",
                    ShortenedEntityName = "kadin-giyim",
                    Description = "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 8,
                    Name = "Erkek Giyim",
                    ShortenedEntityName = "erkek-giyim",
                    Description = "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 9,
                    Name = "Çocuk Giyim",
                    ShortenedEntityName = "cocuk-giyim",
                    Description = "Kız ve erkek çocuk giyim ürünleri",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now
                },
                
                // Ev & Yaşam kategorisi (CategoryId=3) için alt kategoriler
                new SubCategory
                {
                    Id = 10,
                    Name = "Mobilya",
                    ShortenedEntityName = "mobilya",
                    Description = "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 11,
                    Name = "Ev Tekstili",
                    ShortenedEntityName = "ev-tekstili",
                    Description = "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 12,
                    Name = "Dekorasyon & Aydınlatma",
                    ShortenedEntityName = "dekorasyon-aydinlatma",
                    Description = "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 13,
                    Name = "Mutfak Gereçleri",
                    ShortenedEntityName = "mutfak-gerecleri",
                    Description = "Pişirme, servis ve saklama ürünleri, mutfak aletleri",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 14,
                    Name = "Banyo & Ev Gereçleri",
                    ShortenedEntityName = "banyo-ev-gerecleri",
                    Description = "Banyo aksesuarları, temizlik ve düzenleme ürünleri",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 15,
                    Name = "Kırtasiye & Ofis",
                    ShortenedEntityName = "kirtasiye-ve-ofis",
                    Description = "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now
                },
                
                // Kozmetik & Kişisel Bakım kategorisi (CategoryId=4) için alt kategoriler
                new SubCategory
                {
                    Id = 16,
                    Name = "Parfüm & Deodorant",
                    ShortenedEntityName = "parfum-deodorant",
                    Description = "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 17,
                    Name = "Saç Şekillendirme",
                    ShortenedEntityName = "sac-sekillendirme",
                    Description = "Saç bakım ve şekillendirme ürünleri",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 18,
                    Name = "Cilt Bakımı",
                    ShortenedEntityName = "cilt-bakimi",
                    Description = "Yüz ve vücut bakım ürünleri, kremler ve serumlar",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 19,
                    Name = "Makyaj",
                    ShortenedEntityName = "makyaj",
                    Description = "Renkli kozmetik ve makyaj malzemeleri",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 20,
                    Name = "Sağlık & Medikal Ürünler",
                    ShortenedEntityName = "saglik-medikal-urunler",
                    Description = "Vitamin, takviye gıdalar ve medikal ürünler",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 21,
                    Name = "Ağız & Diş Bakımı",
                    ShortenedEntityName = "agiz-dis-bakimi",
                    Description = "Diş bakım ürünleri ve ağız bakım ürünleri",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now
                },
                
                // Spor & Outdoor kategorisi (CategoryId=5) için alt kategoriler
                new SubCategory
                {
                    Id = 22,
                    Name = "Fitness & Kondisyon",
                    ShortenedEntityName = "fitness-kondisyon",
                    Description = "Fitness ekipmanları, kondisyon aletleri ve aksesuarları",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 23,
                    Name = "Spor Giyim & Ayakkabı",
                    ShortenedEntityName = "spor-giyim-ayakkabi",
                    Description = "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 24,
                    Name = "Outdoor & Kamp",
                    ShortenedEntityName = "outdoor-kamp",
                    Description = "Kamp malzemeleri, outdoor giyim ve ekipmanlar",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 25,
                    Name = "Kış Sporları",
                    ShortenedEntityName = "kis-sporlari",
                    Description = "Kayak ekipmanları ve kış sporları malzemeleri",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now
                },
                new SubCategory
                {
                    Id = 26,
                    Name = "Su Sporları",
                    ShortenedEntityName = "su-sporlari",
                    Description = "Yüzme ve su sporları ekipmanları",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now
                }
            );

            // Markaları ekle
            modelBuilder.Entity<Brand>().HasData(BrandSeedData.GetBrands());

            // Ürünleri ekle
            modelBuilder.Entity<Product>().HasData(ProductSeedData.GetProducts());

            // En son resimleri ekle
            modelBuilder.Entity<Image>().HasData(ImageSeedData.GetImages());

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

            modelBuilder.Entity<PropertyType>()
                .Property(pt => pt.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<PropertyValue>()
                .Property(pv => pv.Value)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<PropertyValue>()
                .HasOne(pv => pv.PropertyType)
                .WithMany(pt => pt.PropertyValues)
                .HasForeignKey(pv => pv.PropertyTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductProperty>()
                .HasOne(pp => pp.Product)
                .WithMany(p => p.ProductProperties)
                .HasForeignKey(pp => pp.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProductProperty>()
                .HasOne(pp => pp.PropertyType)
                .WithMany(pt => pt.ProductProperties)
                .HasForeignKey(pp => pp.PropertyTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductProperty>()
                .HasOne(pp => pp.PropertyValue)
                .WithMany(pv => pv.ProductProperties)
                .HasForeignKey(pp => pp.PropertyValueId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PropertyType>().HasData(PropertySeedData.GetPropertyTypes());

            modelBuilder.Entity<PropertyValue>().HasData(PropertySeedData.GetPropertyValues());

            modelBuilder.Entity<ProductProperty>().HasData(PropertySeedData.GetProductProperties());

            modelBuilder.Entity<Cart>()
                .Property(c => c.TotalAmount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Order>()
                .HasOne(o => o.ShippingAddress)
                .WithMany()
                .HasForeignKey(o => o.ShippingAddressId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.BillingAddress)
                .WithMany()
                .HasForeignKey(o => o.BillingAddressId)
                .OnDelete(DeleteBehavior.Restrict);

            // Image ve Product arasındaki ilişki
            modelBuilder.Entity<Image>()
                .HasOne<Product>()
                .WithMany(p => p.Images)
                .HasForeignKey(i => i.EntityId)
                .HasPrincipalKey(p => p.Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Brand)
                .WithMany(b => b.Products)
                .HasForeignKey(p => p.BrandId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Brand>()
                .Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<UserRole>().HasData(UserSeedData.GetUserRoles());
            modelBuilder.Entity<User>().HasData(UserSeedData.GetUser());

            // User ve UserRole arasındaki ilişki
            modelBuilder.Entity<User>()
                .HasOne(u => u.UserRole)
                .WithMany(ur => ur.Users)
                .HasForeignKey(u => u.UserRoleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}