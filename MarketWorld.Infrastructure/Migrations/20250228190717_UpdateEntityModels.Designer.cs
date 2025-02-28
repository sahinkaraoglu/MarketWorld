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
    [Migration("20250228190717_UpdateEntityModels")]
    partial class UpdateEntityModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MarketWorld.Domain.Entities.Category", b =>
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
                            CreatedDate = new DateTime(2025, 2, 28, 22, 7, 16, 944, DateTimeKind.Local).AddTicks(2618),
                            Description = "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar",
                            IsDeleted = false,
                            Name = "Elektronik",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 2L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 7, 16, 944, DateTimeKind.Local).AddTicks(2631),
                            Description = "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları",
                            IsDeleted = false,
                            Name = "Giyim & Aksesuar",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 3L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 7, 16, 944, DateTimeKind.Local).AddTicks(2632),
                            Description = "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili",
                            IsDeleted = false,
                            Name = "Ev & Yaşam",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 4L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 7, 16, 944, DateTimeKind.Local).AddTicks(2633),
                            Description = "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri",
                            IsDeleted = false,
                            Name = "Kozmetik & Kişisel Bakım",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 5L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 7, 16, 944, DateTimeKind.Local).AddTicks(2634),
                            Description = "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri",
                            IsDeleted = false,
                            Name = "Spor & Outdoor",
                            RecVersion = 0
                        });
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CategoryId")
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

                    b.HasIndex("CategoryId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.SubCategory", b =>
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
                            CreatedDate = new DateTime(2025, 2, 28, 22, 7, 16, 944, DateTimeKind.Local).AddTicks(2706),
                            Description = "Dizüstü, masaüstü bilgisayarlar ve tabletler",
                            IsDeleted = false,
                            Name = "Bilgisayarlar & Tabletler",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 2L,
                            CategoryId = 1L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 7, 16, 944, DateTimeKind.Local).AddTicks(2707),
                            Description = "Yazıcılar, tarayıcılar ve projeksiyon cihazları",
                            IsDeleted = false,
                            Name = "Yazıcılar & Projeksiyon",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 3L,
                            CategoryId = 1L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 7, 16, 944, DateTimeKind.Local).AddTicks(2709),
                            Description = "Akıllı telefonlar ve aksesuarları",
                            IsDeleted = false,
                            Name = "Telefonlar",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 4L,
                            CategoryId = 1L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 7, 16, 944, DateTimeKind.Local).AddTicks(2710),
                            Description = "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar",
                            IsDeleted = false,
                            Name = "Beyaz Eşya",
                            RecVersion = 0
                        },
                        new
                        {
                            Id = 5L,
                            CategoryId = 1L,
                            CreatedDate = new DateTime(2025, 2, 28, 22, 7, 16, 944, DateTimeKind.Local).AddTicks(2757),
                            Description = "Klimalar, ısıtıcılar ve hava temizleyiciler",
                            IsDeleted = false,
                            Name = "Klima ve Isıtıcılar",
                            RecVersion = 0
                        });
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.Product", b =>
                {
                    b.HasOne("MarketWorld.Domain.Entities.Category", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.HasOne("MarketWorld.Domain.Entities.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryId");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.SubCategory", b =>
                {
                    b.HasOne("MarketWorld.Domain.Entities.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("MarketWorld.Domain.Entities.SubCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
