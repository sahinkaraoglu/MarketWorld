﻿// <auto-generated />
using System;
using MarketWorld.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MarketWorld.Infrastructure.Migrations
{
    [DbContext(typeof(MarketWorldDbContext))]
    partial class MarketWorldDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MarketWorld.Domain.Entities.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AddressType")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.Cart", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.CartItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CartId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.Categories", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1867),
                            Description = "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar",
                            IsDeleted = false,
                            Name = "Elektronik"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1881),
                            Description = "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları",
                            IsDeleted = false,
                            Name = "Giyim & Aksesuar"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1882),
                            Description = "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili",
                            IsDeleted = false,
                            Name = "Ev & Yaşam"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1883),
                            Description = "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri",
                            IsDeleted = false,
                            Name = "Kozmetik & Kişisel Bakım"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1884),
                            Description = "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri",
                            IsDeleted = false,
                            Name = "Spor & Outdoor"
                        });
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("BillingAddressId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<long?>("ShippingAddressId")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BillingAddressId");

                    b.HasIndex("ShippingAddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.OrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.Payment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long?>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.Products", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CategoriesId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DiscountPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("HasDiscount")
                        .HasColumnType("bit");

                    b.Property<string>("Images")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<long?>("SubCategoryId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.SubCategories", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CategoryId = 1L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1981),
                            Description = "Dizüstü, masaüstü bilgisayarlar ve tabletler",
                            IsDeleted = false,
                            Name = "Bilgisayarlar & Tabletler"
                        },
                        new
                        {
                            Id = 2L,
                            CategoryId = 1L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1982),
                            Description = "Yazıcılar, tarayıcılar ve projeksiyon cihazları",
                            IsDeleted = false,
                            Name = "Yazıcılar & Projeksiyon"
                        },
                        new
                        {
                            Id = 3L,
                            CategoryId = 1L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1984),
                            Description = "Akıllı telefonlar ve aksesuarları",
                            IsDeleted = false,
                            Name = "Telefonlar"
                        },
                        new
                        {
                            Id = 4L,
                            CategoryId = 1L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1985),
                            Description = "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar",
                            IsDeleted = false,
                            Name = "Beyaz Eşya"
                        },
                        new
                        {
                            Id = 5L,
                            CategoryId = 1L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1986),
                            Description = "Klimalar, ısıtıcılar ve hava temizleyiciler",
                            IsDeleted = false,
                            Name = "Klima ve Isıtıcılar"
                        },
                        new
                        {
                            Id = 6L,
                            CategoryId = 2L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1987),
                            Description = "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar",
                            IsDeleted = false,
                            Name = "Ayakkabı & Çanta"
                        },
                        new
                        {
                            Id = 7L,
                            CategoryId = 2L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1988),
                            Description = "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim",
                            IsDeleted = false,
                            Name = "Kadın Giyim"
                        },
                        new
                        {
                            Id = 8L,
                            CategoryId = 2L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1989),
                            Description = "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim",
                            IsDeleted = false,
                            Name = "Erkek Giyim"
                        },
                        new
                        {
                            Id = 9L,
                            CategoryId = 2L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1990),
                            Description = "Kız ve erkek çocuk giyim ürünleri",
                            IsDeleted = false,
                            Name = "Çocuk Giyim"
                        },
                        new
                        {
                            Id = 10L,
                            CategoryId = 3L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1991),
                            Description = "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları",
                            IsDeleted = false,
                            Name = "Mobilya"
                        },
                        new
                        {
                            Id = 11L,
                            CategoryId = 3L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1992),
                            Description = "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri",
                            IsDeleted = false,
                            Name = "Ev Tekstili"
                        },
                        new
                        {
                            Id = 12L,
                            CategoryId = 3L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1993),
                            Description = "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri",
                            IsDeleted = false,
                            Name = "Dekorasyon & Aydınlatma"
                        },
                        new
                        {
                            Id = 13L,
                            CategoryId = 3L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1994),
                            Description = "Pişirme, servis ve saklama ürünleri, mutfak aletleri",
                            IsDeleted = false,
                            Name = "Mutfak Gereçleri"
                        },
                        new
                        {
                            Id = 14L,
                            CategoryId = 3L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1995),
                            Description = "Banyo aksesuarları, temizlik ve düzenleme ürünleri",
                            IsDeleted = false,
                            Name = "Banyo & Ev Gereçleri"
                        },
                        new
                        {
                            Id = 15L,
                            CategoryId = 3L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1996),
                            Description = "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri",
                            IsDeleted = false,
                            Name = "Kırtasiye & Ofis"
                        },
                        new
                        {
                            Id = 16L,
                            CategoryId = 4L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1998),
                            Description = "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri",
                            IsDeleted = false,
                            Name = "Parfüm & Deodorant"
                        },
                        new
                        {
                            Id = 17L,
                            CategoryId = 4L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1999),
                            Description = "Saç bakım ve şekillendirme ürünleri",
                            IsDeleted = false,
                            Name = "Saç Şekillendirme"
                        },
                        new
                        {
                            Id = 18L,
                            CategoryId = 4L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2000),
                            Description = "Yüz ve vücut bakım ürünleri, kremler ve serumlar",
                            IsDeleted = false,
                            Name = "Cilt Bakımı"
                        },
                        new
                        {
                            Id = 19L,
                            CategoryId = 4L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2001),
                            Description = "Renkli kozmetik ve makyaj malzemeleri",
                            IsDeleted = false,
                            Name = "Makyaj"
                        },
                        new
                        {
                            Id = 20L,
                            CategoryId = 4L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2002),
                            Description = "Vitamin, takviye gıdalar ve medikal ürünler",
                            IsDeleted = false,
                            Name = "Sağlık & Medikal Ürünler"
                        },
                        new
                        {
                            Id = 21L,
                            CategoryId = 4L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2003),
                            Description = "Diş bakım ürünleri ve ağız bakım ürünleri",
                            IsDeleted = false,
                            Name = "Ağız & Diş Bakımı"
                        },
                        new
                        {
                            Id = 22L,
                            CategoryId = 5L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2004),
                            Description = "Fitness ekipmanları, kondisyon aletleri ve aksesuarları",
                            IsDeleted = false,
                            Name = "Fitness & Kondisyon"
                        },
                        new
                        {
                            Id = 23L,
                            CategoryId = 5L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2005),
                            Description = "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar",
                            IsDeleted = false,
                            Name = "Spor Giyim & Ayakkabı"
                        },
                        new
                        {
                            Id = 24L,
                            CategoryId = 5L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2007),
                            Description = "Kamp malzemeleri, outdoor giyim ve ekipmanlar",
                            IsDeleted = false,
                            Name = "Outdoor & Kamp"
                        },
                        new
                        {
                            Id = 25L,
                            CategoryId = 5L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2008),
                            Description = "Kayak ekipmanları ve kış sporları malzemeleri",
                            IsDeleted = false,
                            Name = "Kış Sporları"
                        },
                        new
                        {
                            Id = 26L,
                            CategoryId = 5L,
                            CreatedDate = new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2009),
                            Description = "Yüzme ve su sporları ekipmanları",
                            IsDeleted = false,
                            Name = "Su Sporları"
                        });
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.Address", b =>
                {
                    b.HasOne("MarketWorld.Domain.Entities.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.Cart", b =>
                {
                    b.HasOne("MarketWorld.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.CartItem", b =>
                {
                    b.HasOne("MarketWorld.Domain.Entities.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarketWorld.Domain.Entities.Products", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.Order", b =>
                {
                    b.HasOne("MarketWorld.Domain.Entities.Address", "BillingAddress")
                        .WithMany()
                        .HasForeignKey("BillingAddressId");

                    b.HasOne("MarketWorld.Domain.Entities.Address", "ShippingAddress")
                        .WithMany()
                        .HasForeignKey("ShippingAddressId");

                    b.HasOne("MarketWorld.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BillingAddress");

                    b.Navigation("ShippingAddress");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.OrderItem", b =>
                {
                    b.HasOne("MarketWorld.Domain.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarketWorld.Domain.Entities.Products", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.Payment", b =>
                {
                    b.HasOne("MarketWorld.Domain.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.Products", b =>
                {
                    b.HasOne("MarketWorld.Domain.Entities.Categories", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoriesId");

                    b.HasOne("MarketWorld.Domain.Entities.SubCategories", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.SubCategories", b =>
                {
                    b.HasOne("MarketWorld.Domain.Entities.Categories", "Categories")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.Categories", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.Products", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.SubCategories", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.User", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
