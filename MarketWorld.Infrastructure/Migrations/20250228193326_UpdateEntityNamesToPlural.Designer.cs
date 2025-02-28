﻿// <auto-generated />
using System;
using MarketWorld.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MarketWorld.Infrastructure.Migrations
{
    [DbContext(typeof(MarketWorldDbContext))]
    [Migration("20250228193326_UpdateEntityNamesToPlural")]
    partial class UpdateEntityNamesToPlural
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.Property<long?>("DbTableId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RecVersion")
                        .HasColumnType("int");

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
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(129),
                            Description = "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar",
                            IsDeleted = false,
                            Name = "Elektronik",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 2L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(141),
                            Description = "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları",
                            IsDeleted = false,
                            Name = "Giyim & Aksesuar",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 3L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(142),
                            Description = "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili",
                            IsDeleted = false,
                            Name = "Ev & Yaşam",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 4L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(143),
                            Description = "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri",
                            IsDeleted = false,
                            Name = "Kozmetik & Kişisel Bakım",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 5L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(145),
                            Description = "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri",
                            IsDeleted = false,
                            Name = "Spor & Outdoor",
                            RecVersion = 0
                        });
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

                    b.Property<long?>("DbTableId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RecVersion")
                        .HasColumnType("int");

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

                    b.Property<long?>("DbTableId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RecVersion")
                        .HasColumnType("int");

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
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(237),
                            Description = "Dizüstü, masaüstü bilgisayarlar ve tabletler",
                            IsDeleted = false,
                            Name = "Bilgisayarlar & Tabletler",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 2L,
                            CategoryId = 1L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(239),
                            Description = "Yazıcılar, tarayıcılar ve projeksiyon cihazları",
                            IsDeleted = false,
                            Name = "Yazıcılar & Projeksiyon",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 3L,
                            CategoryId = 1L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(240),
                            Description = "Akıllı telefonlar ve aksesuarları",
                            IsDeleted = false,
                            Name = "Telefonlar",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 4L,
                            CategoryId = 1L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(241),
                            Description = "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar",
                            IsDeleted = false,
                            Name = "Beyaz Eşya",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 5L,
                            CategoryId = 1L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(242),
                            Description = "Klimalar, ısıtıcılar ve hava temizleyiciler",
                            IsDeleted = false,
                            Name = "Klima ve Isıtıcılar",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 6L,
                            CategoryId = 2L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(243),
                            Description = "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar",
                            IsDeleted = false,
                            Name = "Ayakkabı & Çanta",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 7L,
                            CategoryId = 2L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(244),
                            Description = "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim",
                            IsDeleted = false,
                            Name = "Kadın Giyim",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 8L,
                            CategoryId = 2L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(246),
                            Description = "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim",
                            IsDeleted = false,
                            Name = "Erkek Giyim",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 9L,
                            CategoryId = 2L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(247),
                            Description = "Kız ve erkek çocuk giyim ürünleri",
                            IsDeleted = false,
                            Name = "Çocuk Giyim",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 10L,
                            CategoryId = 3L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(248),
                            Description = "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları",
                            IsDeleted = false,
                            Name = "Mobilya",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 11L,
                            CategoryId = 3L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(249),
                            Description = "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri",
                            IsDeleted = false,
                            Name = "Ev Tekstili",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 12L,
                            CategoryId = 3L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(250),
                            Description = "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri",
                            IsDeleted = false,
                            Name = "Dekorasyon & Aydınlatma",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 13L,
                            CategoryId = 3L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(251),
                            Description = "Pişirme, servis ve saklama ürünleri, mutfak aletleri",
                            IsDeleted = false,
                            Name = "Mutfak Gereçleri",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 14L,
                            CategoryId = 3L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(252),
                            Description = "Banyo aksesuarları, temizlik ve düzenleme ürünleri",
                            IsDeleted = false,
                            Name = "Banyo & Ev Gereçleri",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 15L,
                            CategoryId = 3L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(253),
                            Description = "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri",
                            IsDeleted = false,
                            Name = "Kırtasiye & Ofis",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 16L,
                            CategoryId = 4L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(254),
                            Description = "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri",
                            IsDeleted = false,
                            Name = "Parfüm & Deodorant",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 17L,
                            CategoryId = 4L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(255),
                            Description = "Saç bakım ve şekillendirme ürünleri",
                            IsDeleted = false,
                            Name = "Saç Şekillendirme",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 18L,
                            CategoryId = 4L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(256),
                            Description = "Yüz ve vücut bakım ürünleri, kremler ve serumlar",
                            IsDeleted = false,
                            Name = "Cilt Bakımı",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 19L,
                            CategoryId = 4L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(257),
                            Description = "Renkli kozmetik ve makyaj malzemeleri",
                            IsDeleted = false,
                            Name = "Makyaj",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 20L,
                            CategoryId = 4L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(297),
                            Description = "Vitamin, takviye gıdalar ve medikal ürünler",
                            IsDeleted = false,
                            Name = "Sağlık & Medikal Ürünler",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 21L,
                            CategoryId = 4L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(298),
                            Description = "Diş bakım ürünleri ve ağız bakım ürünleri",
                            IsDeleted = false,
                            Name = "Ağız & Diş Bakımı",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 22L,
                            CategoryId = 5L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(299),
                            Description = "Fitness ekipmanları, kondisyon aletleri ve aksesuarları",
                            IsDeleted = false,
                            Name = "Fitness & Kondisyon",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 23L,
                            CategoryId = 5L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(301),
                            Description = "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar",
                            IsDeleted = false,
                            Name = "Spor Giyim & Ayakkabı",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 24L,
                            CategoryId = 5L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(302),
                            Description = "Kamp malzemeleri, outdoor giyim ve ekipmanlar",
                            IsDeleted = false,
                            Name = "Outdoor & Kamp",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 25L,
                            CategoryId = 5L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(303),
                            Description = "Kayak ekipmanları ve kış sporları malzemeleri",
                            IsDeleted = false,
                            Name = "Kış Sporları",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 26L,
                            CategoryId = 5L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 33, 26, 408, DateTimeKind.Local).AddTicks(304),
                            Description = "Yüzme ve su sporları ekipmanları",
                            IsDeleted = false,
                            Name = "Su Sporları",
                            RecVersion = 0
                        });
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

            modelBuilder.Entity("MarketWorld.Domain.Entities.Categories", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.SubCategories", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
