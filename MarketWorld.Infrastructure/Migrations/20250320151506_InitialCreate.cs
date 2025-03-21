﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketWorld.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortenedEntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortenedEntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropertyValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PropertyTypeId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyValues_PropertyTypes_PropertyTypeId",
                        column: x => x.PropertyTypeId,
                        principalTable: "PropertyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    AddressType = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brands_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ShippingAddressId = table.Column<int>(type: "int", nullable: true),
                    BillingAddressId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_BillingAddressId",
                        column: x => x.BillingAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_ShippingAddressId",
                        column: x => x.ShippingAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HasDiscount = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    SubCategoryId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: false),
                    EntityType = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Products_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PropertyTypeId = table.Column<int>(type: "int", nullable: false),
                    PropertyValueId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductProperties_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProperties_PropertyTypes_PropertyTypeId",
                        column: x => x.PropertyTypeId,
                        principalTable: "PropertyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductProperties_PropertyValues_PropertyValueId",
                        column: x => x.PropertyValueId,
                        principalTable: "PropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2082), "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar", false, "Elektronik", "elektronik", null, null },
                    { 2, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2098), "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları", false, "Giyim & Aksesuar", "giyim-aksesuar", null, null },
                    { 3, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2099), "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili", false, "Ev & Yaşam", "ev-yasam", null, null },
                    { 4, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2100), "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri", false, "Kozmetik & Kişisel Bakım", "kozmetik-kisisel-bakim", null, null },
                    { 5, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2102), "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri", false, "Spor & Outdoor", "spor-outdoor", null, null }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsActive", "IsDeleted", "Name", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6128), "Ürün Renk Seçenekleri", true, false, "Renk", null, null },
                    { 2, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6136), "Beden Seçenekleri", true, false, "Beden", null, null },
                    { 3, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6137), "Dahili Hafıza", true, false, "Hafıza", null, null }
                });

            migrationBuilder.InsertData(
                table: "PropertyValues",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "PropertyTypeId", "UpdatedById", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6167), true, false, 1, null, null, "Uzay Siyahı" },
                    { 2, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6169), true, false, 1, null, null, "Altın" },
                    { 3, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6171), true, false, 1, null, null, "Gümüş" },
                    { 4, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6172), true, false, 1, null, null, "Mor" },
                    { 5, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6173), true, false, 2, null, null, "XS" },
                    { 6, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6176), true, false, 2, null, null, "S" },
                    { 7, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6177), true, false, 2, null, null, "M" },
                    { 8, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6178), true, false, 2, null, null, "L" },
                    { 9, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6179), true, false, 2, null, null, "XL" },
                    { 10, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6180), true, false, 2, null, null, "XXL" },
                    { 11, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6182), true, false, 3, null, null, "128GB" },
                    { 12, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6183), true, false, 3, null, null, "256GB" },
                    { 13, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6184), true, false, 3, null, null, "512GB" },
                    { 14, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6185), true, false, 3, null, null, "1TB" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedDate", "Description", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2296), "Dizüstü, masaüstü bilgisayarlar ve tabletler", false, "Bilgisayarlar & Tabletler", "bilgisayarlar-tabletler", null, null },
                    { 2, 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2298), "Yazıcılar, tarayıcılar ve projeksiyon cihazları", false, "Yazıcılar & Projeksiyon", "yazicilar-projeksiyon", null, null },
                    { 3, 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2300), "Akıllı telefonlar ve aksesuarları", false, "Telefonlar", "telefonlar", null, null },
                    { 4, 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2301), "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar", false, "Beyaz Eşya", "beyaz-esya", null, null },
                    { 5, 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2302), "Klimalar, ısıtıcılar ve hava temizleyiciler", false, "Klima ve Isıtıcılar", "klima-isitici", null, null },
                    { 6, 2, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2303), "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar", false, "Ayakkabı & Çanta", "ayakkabi-canta", null, null },
                    { 7, 2, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2304), "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim", false, "Kadın Giyim", "kadin-giyim", null, null },
                    { 8, 2, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2306), "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim", false, "Erkek Giyim", "erkek-giyim", null, null },
                    { 9, 2, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2307), "Kız ve erkek çocuk giyim ürünleri", false, "Çocuk Giyim", "cocuk-giyim", null, null },
                    { 10, 3, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2308), "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları", false, "Mobilya", "mobilya", null, null },
                    { 11, 3, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2309), "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri", false, "Ev Tekstili", "ev-tekstili", null, null },
                    { 12, 3, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2310), "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri", false, "Dekorasyon & Aydınlatma", "dekorasyon-aydinlatma", null, null },
                    { 13, 3, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2311), "Pişirme, servis ve saklama ürünleri, mutfak aletleri", false, "Mutfak Gereçleri", "mutfak-gerecleri", null, null },
                    { 14, 3, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2313), "Banyo aksesuarları, temizlik ve düzenleme ürünleri", false, "Banyo & Ev Gereçleri", "banyo-ev-gerecleri", null, null },
                    { 15, 3, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2314), "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri", false, "Kırtasiye & Ofis", "kirtasiye-ve-ofis", null, null },
                    { 16, 4, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2315), "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri", false, "Parfüm & Deodorant", "parfum-deodorant", null, null },
                    { 17, 4, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2316), "Saç bakım ve şekillendirme ürünleri", false, "Saç Şekillendirme", "sac-sekillendirme", null, null },
                    { 18, 4, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2318), "Yüz ve vücut bakım ürünleri, kremler ve serumlar", false, "Cilt Bakımı", "cilt-bakimi", null, null },
                    { 19, 4, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2320), "Renkli kozmetik ve makyaj malzemeleri", false, "Makyaj", "makyaj", null, null },
                    { 20, 4, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2321), "Vitamin, takviye gıdalar ve medikal ürünler", false, "Sağlık & Medikal Ürünler", "saglik-medikal-urunler", null, null },
                    { 21, 4, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2322), "Diş bakım ürünleri ve ağız bakım ürünleri", false, "Ağız & Diş Bakımı", "agiz-dis-bakimi", null, null },
                    { 22, 5, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2323), "Fitness ekipmanları, kondisyon aletleri ve aksesuarları", false, "Fitness & Kondisyon", "fitness-kondisyon", null, null },
                    { 23, 5, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2324), "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar", false, "Spor Giyim & Ayakkabı", "spor-giyim-ayakkabi", null, null },
                    { 24, 5, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2325), "Kamp malzemeleri, outdoor giyim ve ekipmanlar", false, "Outdoor & Kamp", "outdoor-kamp", null, null },
                    { 25, 5, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2327), "Kayak ekipmanları ve kış sporları malzemeleri", false, "Kış Sporları", "kis-sporlari", null, null },
                    { 26, 5, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2328), "Yüzme ve su sporları ekipmanları", false, "Su Sporları", "su-sporlari", null, null }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsDeleted", "Name", "SubCategoryId", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2359), false, "Apple", 3, null, null },
                    { 2, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2362), false, "Samsung", 3, null, null },
                    { 3, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2363), false, "Xiaomi", 3, null, null },
                    { 4, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2364), false, "Huawei", 3, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedById", "CreatedDate", "Description", "DiscountPrice", "HasDiscount", "IsActive", "IsDeleted", "Name", "Price", "Rating", "Stock", "SubCategoryId", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2395), "Apple iPhone 14 Pro 256 GB", 54999.99m, true, true, false, "iPhone 14 Pro", 56999.99m, 5m, 100, 3, null, null },
                    { 2, 2, 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2399), "Samsung Galaxy S23 Ultra 256 GB", 65999.99m, true, true, false, "Samsung Galaxy S23 Ultra", 75999.99m, 5m, 150, 3, null, null },
                    { 3, 1, 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2402), "Apple iPhone 15 128 GB Mavi", 39999.99m, true, true, false, "iPhone 15 128 GB", 49999.99m, 4m, 150, 3, null, null },
                    { 4, 3, 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2405), "Xiaomi 13T Pro 512 GB", 37999.99m, true, true, false, "Xiaomi 13T Pro", 39999.99m, 3m, 75, 3, null, null },
                    { 5, 4, 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2411), "Huawei P60 Pro 256 GB", 0m, false, true, false, "Huawei P60 Pro", 44999.99m, 4m, 60, 3, null, null },
                    { 6, 2, 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2415), "Samsung Galaxy Z Fold5 512 GB", 84999.99m, true, true, false, "Samsung Galaxy Z Fold5", 89999.99m, 4.9m, 40, 3, null, null },
                    { 7, 1, 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2417), "Apple iPhone 15 Pro Max 512 GB", 0m, false, true, false, "iPhone 15 Pro Max", 92999.99m, 3m, 25, 3, null, null },
                    { 8, 3, 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2419), "Xiaomi Redmi Note 13 Pro+ 256 GB", 27999.99m, true, true, false, "Xiaomi Redmi Note 13 Pro+", 29999.99m, 4.2m, 200, 3, null, null },
                    { 9, 2, 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2421), "Samsung Galaxy A54 128 GB", 18499.99m, true, true, false, "Samsung Galaxy A54", 19999.99m, 4.1m, 300, 3, null, null },
                    { 10, 4, 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2424), "Huawei Nova 11 Pro 256 GB", 0m, false, true, false, "Huawei Nova 11 Pro", 34999.99m, 5m, 85, 3, null, null },
                    { 11, 1, 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2456), "13inc Taşınabilir Bilgisayar Uzay Grisi MC7U4TU/A", 0m, false, true, false, "MacBook Air M2 16GB 256GB SSD", 41599.99m, 5m, 85, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "EntityId", "EntityType", "IsDeleted", "Path", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2490), 1, 1, false, "img/ProductsPicture/Telephones/TelephoneOne/resimbir.jpg", null, null },
                    { 2, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2493), 1, 1, false, "img/ProductsPicture/Telephones/TelephoneOne/resimiki.jpg", null, null },
                    { 3, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2494), 1, 1, false, "img/ProductsPicture/Telephones/TelephoneOne/resimuc.jpg", null, null },
                    { 4, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2495), 1, 1, false, "img/ProductsPicture/Telephones/TelephoneOne/resimdort.jpg", null, null },
                    { 5, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2496), 2, 1, false, "img/ProductsPicture/Telephones/TelephoneTwo/resimbir.jpg", null, null },
                    { 6, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2498), 2, 1, false, "img/ProductsPicture/Telephones/TelephoneTwo/resimiki.jpg", null, null },
                    { 7, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2500), 2, 1, false, "img/ProductsPicture/Telephones/TelephoneTwo/resimuc.jpg", null, null },
                    { 8, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2501), 2, 1, false, "img/ProductsPicture/Telephones/TelephoneTwo/resimdort.jpg", null, null },
                    { 9, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2502), 3, 1, false, "img/ProductsPicture/Telephones/TelephoneThree/resimbir.jpg", null, null },
                    { 10, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2504), 3, 1, false, "img/ProductsPicture/Telephones/TelephoneThree/resimiki.jpg", null, null },
                    { 11, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2505), 3, 1, false, "img/ProductsPicture/Telephones/TelephoneThree/resimuc.jpg", null, null },
                    { 12, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2511), 3, 1, false, "img/ProductsPicture/Telephones/TelephoneThree/resimdort.jpg", null, null },
                    { 13, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2512), 4, 1, false, "img/ProductsPicture/Telephones/TelephoneFour/resimbir.jpg", null, null },
                    { 14, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2513), 4, 1, false, "img/ProductsPicture/Telephones/TelephoneFour/resimiki.jpg", null, null },
                    { 15, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2514), 4, 1, false, "img/ProductsPicture/Telephones/TelephoneFour/resimuc.jpg", null, null },
                    { 16, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2515), 4, 1, false, "img/ProductsPicture/Telephones/TelephoneFour/resimdort.jpg", null, null },
                    { 17, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2516), 5, 1, false, "img/ProductsPicture/Telephones/TelephoneFive/resimbir.jpg", null, null },
                    { 18, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2518), 5, 1, false, "img/ProductsPicture/Telephones/TelephoneFive/resimiki.jpg", null, null },
                    { 19, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2519), 5, 1, false, "img/ProductsPicture/Telephones/TelephoneFive/resimuc.jpg", null, null },
                    { 20, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2520), 5, 1, false, "img/ProductsPicture/Telephones/TelephoneFive/resimdort.jpg", null, null },
                    { 21, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2521), 6, 1, false, "img/ProductsPicture/Telephones/TelephoneSix/resimbir.jpg", null, null },
                    { 22, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2522), 6, 1, false, "img/ProductsPicture/Telephones/TelephoneSix/resimiki.jpg", null, null },
                    { 23, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2523), 6, 1, false, "img/ProductsPicture/Telephones/TelephoneSix/resimuc.jpg", null, null },
                    { 24, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2524), 6, 1, false, "img/ProductsPicture/Telephones/TelephoneSix/resimdort.jpg", null, null },
                    { 25, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2525), 7, 1, false, "img/ProductsPicture/Telephones/TelephoneSeven/resimbir.jpg", null, null },
                    { 26, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2527), 7, 1, false, "img/ProductsPicture/Telephones/TelephoneSeven/resimiki.jpg", null, null },
                    { 27, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2528), 7, 1, false, "img/ProductsPicture/Telephones/TelephoneSeven/resimuc.jpg", null, null },
                    { 28, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2529), 7, 1, false, "img/ProductsPicture/Telephones/TelephoneSeven/resimdort.jpg", null, null },
                    { 29, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2530), 8, 1, false, "img/ProductsPicture/Telephones/TelephoneEight/resimbir.jpg", null, null },
                    { 30, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2531), 8, 1, false, "img/ProductsPicture/Telephones/TelephoneEight/resimiki.jpg", null, null },
                    { 31, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2532), 8, 1, false, "img/ProductsPicture/Telephones/TelephoneEight/resimuc.jpg", null, null },
                    { 32, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2533), 8, 1, false, "img/ProductsPicture/Telephones/TelephoneEight/resimdort.jpg", null, null },
                    { 33, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2534), 9, 1, false, "img/ProductsPicture/Telephones/TelephoneNine/resimbir.jpg", null, null },
                    { 34, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2536), 9, 1, false, "img/ProductsPicture/Telephones/TelephoneNine/resimiki.jpg", null, null },
                    { 35, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2537), 9, 1, false, "img/ProductsPicture/Telephones/TelephoneNine/resimuc.jpg", null, null },
                    { 36, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2538), 9, 1, false, "img/ProductsPicture/Telephones/TelephoneNine/resimdort.jpg", null, null },
                    { 37, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2539), 10, 1, false, "img/ProductsPicture/Telephones/TelephoneTen/resimbir.jpg", null, null },
                    { 38, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2540), 10, 1, false, "img/ProductsPicture/Telephones/TelephoneTen/resimiki.jpg", null, null },
                    { 39, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2541), 10, 1, false, "img/ProductsPicture/Telephones/TelephoneTen/resimuc.jpg", null, null },
                    { 40, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2543), 10, 1, false, "img/ProductsPicture/Telephones/TelephoneTen/resimdort.jpg", null, null },
                    { 41, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2544), 11, 1, false, "img/ProductsPicture/Pc/PcOne/resimbir.jpg", null, null },
                    { 42, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2545), 11, 1, false, "img/ProductsPicture/Pc/PcOne/resimiki.jpg", null, null },
                    { 43, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2546), 11, 1, false, "img/ProductsPicture/Pc/PcOne/resimuc.jpg", null, null },
                    { 44, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(2547), 11, 1, false, "img/ProductsPicture/Pc/PcOne/resimdort.jpg", null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductProperties",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "ProductId", "PropertyTypeId", "PropertyValueId", "Stock", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6255), true, false, 1, 1, 1, 50, null, null },
                    { 2, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6263), true, false, 1, 1, 2, 50, null, null },
                    { 3, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6264), true, false, 1, 1, 3, 50, null, null },
                    { 4, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6264), true, false, 1, 1, 4, 50, null, null },
                    { 5, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6266), true, false, 1, 3, 11, 75, null, null },
                    { 6, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6267), true, false, 1, 3, 12, 75, null, null },
                    { 7, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6268), true, false, 1, 3, 13, 75, null, null },
                    { 8, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6269), true, false, 1, 3, 14, 75, null, null },
                    { 9, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6269), true, false, 2, 1, 1, 50, null, null },
                    { 10, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6270), true, false, 2, 1, 2, 50, null, null },
                    { 11, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6271), true, false, 2, 1, 3, 50, null, null },
                    { 12, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6271), true, false, 2, 1, 4, 50, null, null },
                    { 13, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6272), true, false, 2, 3, 11, 75, null, null },
                    { 14, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6272), true, false, 2, 3, 12, 75, null, null },
                    { 15, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6273), true, false, 2, 3, 13, 75, null, null },
                    { 16, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6273), true, false, 2, 3, 14, 75, null, null },
                    { 17, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6274), true, false, 3, 1, 1, 50, null, null },
                    { 18, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6275), true, false, 3, 1, 2, 50, null, null },
                    { 19, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6275), true, false, 3, 1, 3, 50, null, null },
                    { 20, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6276), true, false, 3, 1, 4, 50, null, null },
                    { 21, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6276), true, false, 3, 3, 11, 75, null, null },
                    { 22, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6277), true, false, 3, 3, 12, 75, null, null },
                    { 23, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6277), true, false, 3, 3, 13, 75, null, null },
                    { 24, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6278), true, false, 3, 3, 14, 75, null, null },
                    { 25, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6278), true, false, 4, 1, 1, 50, null, null },
                    { 26, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6279), true, false, 4, 1, 2, 50, null, null },
                    { 27, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6279), true, false, 4, 1, 3, 50, null, null },
                    { 28, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6279), true, false, 4, 1, 4, 50, null, null },
                    { 29, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6280), true, false, 4, 3, 11, 75, null, null },
                    { 30, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6280), true, false, 4, 3, 12, 75, null, null },
                    { 31, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6281), true, false, 4, 3, 13, 75, null, null },
                    { 32, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6281), true, false, 4, 3, 14, 75, null, null },
                    { 33, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6282), true, false, 5, 1, 1, 50, null, null },
                    { 34, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6283), true, false, 5, 1, 2, 50, null, null },
                    { 35, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6283), true, false, 5, 1, 3, 50, null, null },
                    { 36, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6284), true, false, 5, 1, 4, 50, null, null },
                    { 37, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6284), true, false, 5, 3, 11, 75, null, null },
                    { 38, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6284), true, false, 5, 3, 12, 75, null, null },
                    { 39, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6285), true, false, 5, 3, 13, 75, null, null },
                    { 40, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6285), true, false, 5, 3, 14, 75, null, null },
                    { 41, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6286), true, false, 6, 1, 1, 50, null, null },
                    { 42, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6286), true, false, 6, 1, 2, 50, null, null },
                    { 43, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6287), true, false, 6, 1, 3, 50, null, null },
                    { 44, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6287), true, false, 6, 1, 4, 50, null, null },
                    { 45, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6288), true, false, 6, 3, 11, 75, null, null },
                    { 46, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6288), true, false, 6, 3, 12, 75, null, null },
                    { 47, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6289), true, false, 6, 3, 13, 75, null, null },
                    { 48, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6289), true, false, 6, 3, 14, 75, null, null },
                    { 49, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6290), true, false, 7, 1, 1, 50, null, null },
                    { 50, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6333), true, false, 7, 1, 2, 50, null, null },
                    { 51, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6334), true, false, 7, 1, 3, 50, null, null },
                    { 52, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6334), true, false, 7, 1, 4, 50, null, null },
                    { 53, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6335), true, false, 7, 3, 11, 75, null, null },
                    { 54, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6335), true, false, 7, 3, 12, 75, null, null },
                    { 55, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6335), true, false, 7, 3, 13, 75, null, null },
                    { 56, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6336), true, false, 7, 3, 14, 75, null, null },
                    { 57, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6337), true, false, 8, 1, 1, 50, null, null },
                    { 58, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6337), true, false, 8, 1, 2, 50, null, null },
                    { 59, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6338), true, false, 8, 1, 3, 50, null, null },
                    { 60, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6338), true, false, 8, 1, 4, 50, null, null },
                    { 61, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6339), true, false, 8, 3, 11, 75, null, null },
                    { 62, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6339), true, false, 8, 3, 12, 75, null, null },
                    { 63, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6339), true, false, 8, 3, 13, 75, null, null },
                    { 64, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6340), true, false, 8, 3, 14, 75, null, null },
                    { 65, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6340), true, false, 9, 1, 1, 50, null, null },
                    { 66, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6342), true, false, 9, 1, 2, 50, null, null },
                    { 67, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6342), true, false, 9, 1, 3, 50, null, null },
                    { 68, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6342), true, false, 9, 1, 4, 50, null, null },
                    { 69, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6343), true, false, 9, 3, 11, 75, null, null },
                    { 70, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6343), true, false, 9, 3, 12, 75, null, null },
                    { 71, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6344), true, false, 9, 3, 13, 75, null, null },
                    { 72, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6344), true, false, 9, 3, 14, 75, null, null },
                    { 73, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6345), true, false, 10, 1, 1, 50, null, null },
                    { 74, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6345), true, false, 10, 1, 2, 50, null, null },
                    { 75, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6346), true, false, 10, 1, 3, 50, null, null },
                    { 76, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6346), true, false, 10, 1, 4, 50, null, null },
                    { 77, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6347), true, false, 10, 3, 11, 75, null, null },
                    { 78, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6347), true, false, 10, 3, 12, 75, null, null },
                    { 79, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6347), true, false, 10, 3, 13, 75, null, null },
                    { 80, null, new DateTime(2025, 3, 20, 18, 15, 6, 692, DateTimeKind.Local).AddTicks(6348), true, false, 10, 3, 14, 75, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_SubCategoryId",
                table: "Brands",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_EntityId",
                table: "Images",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BillingAddressId",
                table: "Orders",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShippingAddressId",
                table: "Orders",
                column: "ShippingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                table: "Payments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProperties_ProductId",
                table: "ProductProperties",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProperties_PropertyTypeId",
                table: "ProductProperties",
                column: "PropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProperties_PropertyValueId",
                table: "ProductProperties",
                column: "PropertyValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyValues_PropertyTypeId",
                table: "PropertyValues",
                column: "PropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "ProductProperties");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PropertyValues");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "PropertyTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
