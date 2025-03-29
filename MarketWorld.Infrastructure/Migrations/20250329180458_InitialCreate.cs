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
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRoleId = table.Column<int>(type: "int", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Users_UserRoles_UserRoleId",
                        column: x => x.UserRoleId,
                        principalTable: "UserRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsDeleted", "Name", "SubCategoryId", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2302), false, "Apple", null, null, null },
                    { 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2305), false, "Asus", null, null, null },
                    { 3, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2306), false, "Casper", null, null, null },
                    { 4, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2307), false, "HP", null, null, null },
                    { 5, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2308), false, "Lenovo", null, null, null },
                    { 6, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2309), false, "MSI", null, null, null },
                    { 7, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2310), false, "Acer", null, null, null },
                    { 8, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2312), false, "Xiaomi", null, null, null },
                    { 9, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2313), false, "Samsung", null, null, null },
                    { 10, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2315), false, "Huawei", null, null, null },
                    { 11, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2316), false, "Canon", null, null, null },
                    { 12, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2317), false, "Epson", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2073), "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar", false, "Elektronik", "elektronik", null, null },
                    { 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2087), "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları", false, "Giyim & Aksesuar", "giyim-aksesuar", null, null },
                    { 3, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2088), "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili", false, "Ev & Yaşam", "ev-yasam", null, null },
                    { 4, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2089), "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri", false, "Kozmetik & Kişisel Bakım", "kozmetik-kisisel-bakim", null, null },
                    { 5, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2091), "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri", false, "Spor & Outdoor", "spor-outdoor", null, null }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsActive", "IsDeleted", "Name", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5912), "Ürün Renk Seçenekleri", true, false, "Renk", null, null },
                    { 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5918), "Beden Seçenekleri", true, false, "Beden", null, null },
                    { 3, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5919), "Dahili Hafıza", true, false, "Hafıza", null, null },
                    { 4, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5920), "Bilgisayar İşlemci Seçenekleri", true, false, "İşlemci", null, null },
                    { 5, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5921), "Bellek Kapasitesi", true, false, "RAM", null, null },
                    { 6, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5923), "SSD Kapasitesi", true, false, "SSD", null, null },
                    { 7, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5925), "Ekran Boyutu", true, false, "Ekran", null, null },
                    { 8, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5926), "Yazıcı Teknolojisi", true, false, "Yazıcı Tipi", null, null },
                    { 9, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5927), "Mürekkep/Kartuş Sistemi", true, false, "Mürekkep Sistemi", null, null },
                    { 10, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5928), "Desteklenen Kağıt Boyutları", true, false, "Kağıt Boyutu", null, null },
                    { 11, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5930), "Yazıcı Fonksiyonları", true, false, "Fonksiyonlar", null, null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsDeleted", "Role", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, false, "Admin", null, null },
                    { 2, null, null, false, "User", null, null }
                });

            migrationBuilder.InsertData(
                table: "PropertyValues",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "PropertyTypeId", "UpdatedById", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5958), true, false, 1, null, null, "Uzay Siyahı" },
                    { 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5961), true, false, 1, null, null, "Altın" },
                    { 3, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5962), true, false, 1, null, null, "Gümüş" },
                    { 4, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5963), true, false, 1, null, null, "Mor" },
                    { 5, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5965), true, false, 2, null, null, "XS" },
                    { 6, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5966), true, false, 2, null, null, "S" },
                    { 7, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5969), true, false, 2, null, null, "M" },
                    { 8, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5996), true, false, 2, null, null, "L" },
                    { 9, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(5998), true, false, 2, null, null, "XL" },
                    { 10, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6000), true, false, 2, null, null, "XXL" },
                    { 11, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6001), true, false, 3, null, null, "128GB" },
                    { 12, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6002), true, false, 3, null, null, "256GB" },
                    { 13, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6003), true, false, 3, null, null, "512GB" },
                    { 14, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6004), true, false, 3, null, null, "1TB" },
                    { 15, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6005), true, false, 4, null, null, "Intel Core i7 12700H" },
                    { 16, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6006), true, false, 4, null, null, "Intel Core i7 1255U" },
                    { 17, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6008), true, false, 4, null, null, "Intel Core i7 13620H" },
                    { 18, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6009), true, false, 4, null, null, "Intel Core i5 1334U" },
                    { 19, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6010), true, false, 4, null, null, "Intel Core i5 13420H" },
                    { 20, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6011), true, false, 4, null, null, "AMD Ryzen 7 5700U" },
                    { 21, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6012), true, false, 4, null, null, "Intel Core i5 12450H" },
                    { 22, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6013), true, false, 5, null, null, "8GB" },
                    { 23, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6014), true, false, 5, null, null, "16GB" },
                    { 24, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6015), true, false, 5, null, null, "32GB" },
                    { 25, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6016), true, false, 6, null, null, "256GB" },
                    { 26, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6017), true, false, 6, null, null, "500GB" },
                    { 27, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6018), true, false, 6, null, null, "512GB" },
                    { 28, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6019), true, false, 6, null, null, "1TB" },
                    { 29, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6020), true, false, 7, null, null, "14\"" },
                    { 30, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6025), true, false, 7, null, null, "15.6\"" },
                    { 31, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6026), true, false, 7, null, null, "16\"" },
                    { 32, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6027), true, false, 4, null, null, "Intel Core i7 13650HX" },
                    { 33, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6028), true, false, 4, null, null, "Intel Core i5 13500H" },
                    { 34, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6030), true, false, 4, null, null, "Intel Core i9-14900HX" },
                    { 35, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6031), true, false, 4, null, null, "Intel Core Ultra 7 255HX" },
                    { 36, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6033), true, false, 4, null, null, "AMD Ryzen 5 7520U" },
                    { 37, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6034), true, false, 8, null, null, "Mürekkep Püskürtmeli" },
                    { 38, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6035), true, false, 8, null, null, "Lazer" },
                    { 39, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6036), true, false, 8, null, null, "Süblimasyon" },
                    { 40, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6037), true, false, 9, null, null, "Kartuşlu" },
                    { 41, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6038), true, false, 9, null, null, "Tanklı" },
                    { 42, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6039), true, false, 9, null, null, "Dolum Üniteli" },
                    { 43, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6040), true, false, 10, null, null, "A4" },
                    { 44, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6042), true, false, 10, null, null, "A3" },
                    { 45, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6043), true, false, 10, null, null, "A4/A3" },
                    { 46, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6044), true, false, 11, null, null, "Yazdırma" },
                    { 47, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6045), true, false, 11, null, null, "Tarama" },
                    { 48, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6046), true, false, 11, null, null, "Fotokopi" },
                    { 49, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6047), true, false, 11, null, null, "Faks" },
                    { 50, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6048), true, false, 11, null, null, "Wi-Fi" },
                    { 51, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6049), true, false, 11, null, null, "AirPrint" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedDate", "Description", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2215), "Dizüstü, masaüstü bilgisayarlar ve tabletler", false, "Bilgisayarlar & Tabletler", "bilgisayarlar-tabletler", null, null },
                    { 2, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2217), "Yazıcılar, tarayıcılar ve projeksiyon cihazları", false, "Yazıcılar & Projeksiyon", "yazicilar-projeksiyon", null, null },
                    { 3, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2219), "Akıllı telefonlar ve aksesuarları", false, "Telefonlar", "telefonlar", null, null },
                    { 4, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2245), "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar", false, "Beyaz Eşya", "beyaz-esya", null, null },
                    { 5, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2246), "Klimalar, ısıtıcılar ve hava temizleyiciler", false, "Klima ve Isıtıcılar", "klima-isitici", null, null },
                    { 6, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2248), "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar", false, "Ayakkabı & Çanta", "ayakkabi-canta", null, null },
                    { 7, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2249), "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim", false, "Kadın Giyim", "kadin-giyim", null, null },
                    { 8, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2250), "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim", false, "Erkek Giyim", "erkek-giyim", null, null },
                    { 9, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2251), "Kız ve erkek çocuk giyim ürünleri", false, "Çocuk Giyim", "cocuk-giyim", null, null },
                    { 10, 3, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2252), "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları", false, "Mobilya", "mobilya", null, null },
                    { 11, 3, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2253), "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri", false, "Ev Tekstili", "ev-tekstili", null, null },
                    { 12, 3, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2255), "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri", false, "Dekorasyon & Aydınlatma", "dekorasyon-aydinlatma", null, null },
                    { 13, 3, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2256), "Pişirme, servis ve saklama ürünleri, mutfak aletleri", false, "Mutfak Gereçleri", "mutfak-gerecleri", null, null },
                    { 14, 3, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2257), "Banyo aksesuarları, temizlik ve düzenleme ürünleri", false, "Banyo & Ev Gereçleri", "banyo-ev-gerecleri", null, null },
                    { 15, 3, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2258), "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri", false, "Kırtasiye & Ofis", "kirtasiye-ve-ofis", null, null },
                    { 16, 4, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2259), "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri", false, "Parfüm & Deodorant", "parfum-deodorant", null, null },
                    { 17, 4, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2260), "Saç bakım ve şekillendirme ürünleri", false, "Saç Şekillendirme", "sac-sekillendirme", null, null },
                    { 18, 4, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2261), "Yüz ve vücut bakım ürünleri, kremler ve serumlar", false, "Cilt Bakımı", "cilt-bakimi", null, null },
                    { 19, 4, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2262), "Renkli kozmetik ve makyaj malzemeleri", false, "Makyaj", "makyaj", null, null },
                    { 20, 4, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2263), "Vitamin, takviye gıdalar ve medikal ürünler", false, "Sağlık & Medikal Ürünler", "saglik-medikal-urunler", null, null },
                    { 21, 4, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2266), "Diş bakım ürünleri ve ağız bakım ürünleri", false, "Ağız & Diş Bakımı", "agiz-dis-bakimi", null, null },
                    { 22, 5, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2267), "Fitness ekipmanları, kondisyon aletleri ve aksesuarları", false, "Fitness & Kondisyon", "fitness-kondisyon", null, null },
                    { 23, 5, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2268), "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar", false, "Spor Giyim & Ayakkabı", "spor-giyim-ayakkabi", null, null },
                    { 24, 5, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2269), "Kamp malzemeleri, outdoor giyim ve ekipmanlar", false, "Outdoor & Kamp", "outdoor-kamp", null, null },
                    { 25, 5, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2270), "Kayak ekipmanları ve kış sporları malzemeleri", false, "Kış Sporları", "kis-sporlari", null, null },
                    { 26, 5, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2271), "Yüzme ve su sporları ekipmanları", false, "Su Sporları", "su-sporlari", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedById", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "Password", "PhoneNumber", "UpdatedById", "UpdatedDate", "UserRoleId", "Username" },
                values: new object[,]
                {
                    { 1, null, "admin@admin.com", "Şahin", true, false, null, "123", null, null, null, 1, "sahinkaraoglu" },
                    { 2, null, "ali@example.com", "Ali", true, false, null, "456", null, null, null, 2, "aliuzun" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedById", "CreatedDate", "Description", "DiscountPrice", "HasDiscount", "IsActive", "IsDeleted", "Name", "Price", "Rating", "Stock", "SubCategoryId", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2353), "Apple iPhone 14 Pro 256 GB", 54999.99m, true, true, false, "iPhone 14 Pro", 56999.99m, 5m, 100, 3, null, null },
                    { 2, 9, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2357), "Samsung Galaxy S23 Ultra 256 GB", 65999.99m, true, true, false, "Samsung Galaxy S23 Ultra", 75999.99m, 5m, 150, 3, null, null },
                    { 3, 1, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2359), "Apple iPhone 15 128 GB Mavi", 39999.99m, true, true, false, "iPhone 15 128 GB", 49999.99m, 4m, 150, 3, null, null },
                    { 4, 8, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2361), "Xiaomi 13T Pro 512 GB", 37999.99m, true, true, false, "Xiaomi 13T Pro", 39999.99m, 3m, 75, 3, null, null },
                    { 5, 10, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2364), "Huawei P60 Pro 256 GB", 0m, false, true, false, "Huawei P60 Pro", 44999.99m, 4m, 60, 3, null, null },
                    { 6, 9, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2367), "Samsung Galaxy Z Fold5 512 GB", 84999.99m, true, true, false, "Samsung Galaxy Z Fold5", 89999.99m, 4.9m, 40, 3, null, null },
                    { 7, 1, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2369), "Apple iPhone 15 Pro Max 512 GB", 0m, false, true, false, "iPhone 15 Pro Max", 92999.99m, 3m, 25, 3, null, null },
                    { 8, 8, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2397), "Xiaomi Redmi Note 13 Pro+ 256 GB", 27999.99m, true, true, false, "Xiaomi Redmi Note 13 Pro+", 29999.99m, 4.2m, 200, 3, null, null },
                    { 9, 9, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2400), "Samsung Galaxy A54 128 GB", 18499.99m, true, true, false, "Samsung Galaxy A54", 19999.99m, 4.1m, 300, 3, null, null },
                    { 10, 10, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2403), "Huawei Nova 11 Pro 256 GB", 0m, false, true, false, "Huawei Nova 11 Pro", 34999.99m, 5m, 85, 3, null, null },
                    { 11, 1, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2405), "13inc Taşınabilir Bilgisayar Uzay Grisi MC7U4TU/A", 0m, false, true, false, "MacBook Air M2 16GB 256GB SSD", 41599.99m, 5m, 85, 1, null, null },
                    { 12, 3, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2408), "Intel Core i7 12700H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1270", 39999.99m, 4.5m, 100, 1, null, null },
                    { 13, 6, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2410), "Intel Core i7 1255U 16GB 512GB SSD Freedos 14\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "MSI Modern 14 C12MO", 21799.99m, 4.5m, 75, 1, null, null },
                    { 14, 3, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2412), "Core i7-13620H 32GB DDR5 RAM 1TB NVME SSD 16\" Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana S100", 27299.99m, 5m, 50, 1, null, null },
                    { 15, 3, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2415), "Intel Core i7 13620H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1362", 50199.99m, 4.5m, 60, 1, null, null },
                    { 16, 4, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2418), "Intel Core i5 1334U 16GB 512GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "HP 250 G10", 14999.99m, 4.7m, 100, 1, null, null },
                    { 17, 5, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2420), "Intel Core i5 13420H 16GB Ddr5 Ram 512 GB SSD 16'' WUXGA IPS Panel Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad Slim 3", 19799.99m, 4.9m, 80, 1, null, null },
                    { 18, 5, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2423), "AMD Ryzen 7 5700U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad 1", 15999.99m, 4.6m, 90, 1, null, null },
                    { 19, 6, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2425), "Intel Core i5 12450H 8GB 512GB SSD RTX2050 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "MSI Thin 15", 24799.99m, 4.5m, 70, 1, null, null },
                    { 20, 3, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2427), "Intel Core i7 1255U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana C550", 18999.99m, 4.5m, 85, 1, null, null },
                    { 21, 5, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2429), "Intel Core i7 13650HX 32GB 1TB SSD RTX 4060 8GB (115W) 15.6\" FHD 144Hz IPS Panel Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo LOQ 15IRX9", 59999.99m, 5m, 45, 1, null, null },
                    { 22, 3, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2432), "Intel Core i5-12450H 32GB RAM 500GB SSD GEN4 RTX3050 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G770", 31299.99m, 4.6m, 65, 1, null, null },
                    { 23, 3, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2434), "AMD Ryzen 5 7430U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana X600", 16999.99m, 5m, 80, 1, null, null },
                    { 24, 7, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2436), "Intel Core i7 1255U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Acer Aspire 3", 24000.00m, 5m, 70, 1, null, null },
                    { 25, 3, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2438), "Intel Core i7 12700H 32GB 1TB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana X600.1270", 22999.99m, 4.5m, 85, 1, null, null },
                    { 26, 3, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2440), "Intel Core i5-13420H 32GB RAM 500GB NVME SSD GEN4 6GB RTX4050 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G870.1342", 38499.99m, 4.1m, 55, 1, null, null },
                    { 27, 3, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2442), "Intel Core i7 12700H 32GB 1TB SSD RTX4070 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1270", 50899.99m, 4m, 40, 1, null, null },
                    { 28, 4, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2444), "Intel Core i5 13500H 16GB 512GB SSD RTX4050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "HP Victus Gaming 15", 33999.99m, 4.6m, 90, 1, null, null },
                    { 29, 5, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2450), "Intel Core i5 12450H 8GB 512GB SSD 15.6\" FHD Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo IdeaPad Slim 3", 15359.04m, 4.7m, 100, 1, null, null },
                    { 30, 2, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2452), "Intel Core i5 12500H 8GB 512GB SSD RTX3050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Asus TUF Gaming F15", 29898.66m, 4.7m, 75, 1, null, null },
                    { 31, 1, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2454), "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Uzay Grisi", 0m, false, true, false, "Apple MacBook Air M1", 39250.00m, 4.9m, 60, 1, null, null },
                    { 32, 3, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2456), "Intel Core i5-13420H 16GB RAM 1TB NVME SSD 8GB RTX4060 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G870.1342", 42299.99m, 4.3m, 50, 1, null, null },
                    { 33, 5, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2458), "Intel Core i5 13420H 16GB 512GB SSD Freedos 14\" WUXGA Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad 5", 29999.99m, 5m, 70, 1, null, null },
                    { 34, 2, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2460), "Intel Core Ultra 7 255HX 32GB 1TB SSD RTX5070Ti Freedos 16\" Taşınabilir Bilgisayar", 0m, false, true, false, "Asus ROG Strix G16", 107999.99m, 5m, 25, 1, null, null },
                    { 35, 3, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2463), "Intel Core i5-13420H 32GB RAM 500GB NVME SSD Freedos", 0m, false, true, false, "Casper Nirvana X600.1342", 19999.99m, 5m, 85, 1, null, null },
                    { 36, 5, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2466), "Intel Core i9-14900HX 32GB DDR5 1TB SSD RTX4060 8GB 16 inç 3.2K (3200×2000) 165Hz FreeDos Laptop", 0m, false, true, false, "Lenovo Thinkbook 16PG5", 79999.40m, 4.7m, 30, 1, null, null },
                    { 37, 3, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2467), "Intel Core i7-13620H 16GB RAM 500GB NVME SSD Freedos Laptop", 0m, false, true, false, "Casper Nirvana X600.1362", 22099.99m, 5m, 75, 1, null, null },
                    { 38, 6, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2517), "Intel Core i5 13420H 16GB 1TB SSD RTX4060 Freedos 15.6\" FHD 144Hz Taşınabilir Bilgisayar", 0m, false, true, false, "MSI CYBORG 15", 37999.99m, 4.9m, 60, 1, null, null },
                    { 39, 5, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2519), "AMD Ryzen 5 7520U 8gb 512GB SSD Freedos 15.6\" Fhd Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo V15 G4", 13299.99m, 4.3m, 95, 1, null, null },
                    { 40, 5, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2521), "I5-13420H 32GB 1 Tb SSD 15.6 Fhd Windows 11 Pro", 0m, false, true, false, "Lenovo V15 G4", 27749.00m, 5m, 70, 1, null, null },
                    { 41, 1, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2523), "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Gece Yarısı", 0m, false, true, false, "Apple MacBook Air M4", 49999.99m, 5m, 45, 1, null, null },
                    { 42, 3, 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2527), "Intel Core i5 12450H 16GB 500GB SSD RTX2050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1245", 27499.99m, 4.4m, 80, 1, null, null },
                    { 43, 4, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2529), "HP Deskjet Ink Advantage 2878 All-In-One Yazıcı", 0m, false, true, false, "HP Deskjet Ink Advantage 2878 All-In-One Yazıcı", 2799.00m, 4.1m, 100, 2, null, null },
                    { 44, 11, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2531), "Canon Dolan Kartuşlu E414 Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Canon Dolan Kartuşlu E414 Yazıcı", 2299.08m, 4.4m, 150, 2, null, null },
                    { 45, 11, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2533), "Canon Pixma TR4650 Tarayıcı + Fotokopi + Wi-Fi + Faks + Çok Fonksiyonlu Yazıcı", 0m, false, true, false, "Canon Pixma TR4650", 3379.00m, 4.2m, 75, 2, null, null },
                    { 46, 11, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2535), "Canon Pixma E3640 Wi-Fi Tarayıcı - Fotokopi Çok Fonksiyonlu Mürekkep Püskürtmeli Yazıcı", 0m, false, true, false, "Canon Pixma E3640 Wi-Fi", 3399.00m, 4.6m, 120, 2, null, null },
                    { 47, 12, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2537), "Epson L5290 Wi-Fi Renk Tanklı Yazıcı", 0m, false, true, false, "Epson L5290 Wi-Fi Renk Tanklı Yazıcı", 11983.51m, 4.4m, 60, 2, null, null },
                    { 48, 12, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2540), "Epson Tanklı L3150 Photoink Muadil Mürekkepli Tanklı Yazıcı", 0m, false, true, false, "Epson Tanklı L3150 Photoink", 6033.86m, 4.6m, 90, 2, null, null },
                    { 49, 4, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2543), "HP Officejet Pro 7720 Fotokopi + Faks + Tarayıcı + Wi-Fi + Airprint + A3 Yazıcı", 0m, false, true, false, "HP Officejet Pro 7720", 11138.06m, 4.6m, 45, 2, null, null },
                    { 50, 11, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2546), "Canon E3640 Wifi Yazıcı ve Tıpalı Kartuş Sistemi", 0m, false, true, false, "Canon E3640 Wifi Yazıcı", 3306.56m, 4.3m, 100, 2, null, null },
                    { 51, 12, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2548), "Epson L3151 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L3151 Tanklı Yazıcı", 4999.00m, 4.5m, 120, 2, null, null },
                    { 52, 4, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2551), "HP LaserJet Pro M428f MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428f", 7999.00m, 4.3m, 80, 2, null, null },
                    { 53, 11, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2552), "Canon PIXMA G3110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G3110", 3999.00m, 4.4m, 150, 2, null, null },
                    { 54, 12, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2555), "Epson L3250 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L3250 Tanklı Yazıcı", 4499.00m, 4.6m, 100, 2, null, null },
                    { 55, 4, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2557), "HP LaserJet Pro M428dw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428dw", 8999.00m, 4.5m, 60, 2, null, null },
                    { 56, 11, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2559), "Canon PIXMA G4110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G4110", 4499.00m, 4.3m, 90, 2, null, null },
                    { 57, 12, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2561), "Epson L4260 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4260 Tanklı Yazıcı", 5499.00m, 4.7m, 75, 2, null, null },
                    { 58, 4, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2563), "HP LaserJet Pro M428fnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fnw", 9999.00m, 4.4m, 50, 2, null, null },
                    { 59, 11, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2565), "Canon PIXMA G5110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G5110", 4999.00m, 4.5m, 110, 2, null, null },
                    { 60, 12, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2567), "Epson L4266 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4266 Tanklı Yazıcı", 5999.00m, 4.6m, 85, 2, null, null },
                    { 61, 4, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2569), "HP LaserJet Pro M428fdw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdw", 10999.00m, 4.5m, 45, 2, null, null },
                    { 62, 11, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2572), "Canon PIXMA G6110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G6110", 5499.00m, 4.4m, 95, 2, null, null },
                    { 63, 12, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2574), "Epson L4268 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4268 Tanklı Yazıcı", 6499.00m, 4.7m, 70, 2, null, null },
                    { 64, 4, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2576), "HP LaserJet Pro M428fdn MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdn", 11999.00m, 4.6m, 40, 2, null, null },
                    { 65, 11, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2578), "Canon PIXMA G7110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G7110", 5999.00m, 4.5m, 80, 2, null, null },
                    { 66, 12, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2581), "Epson L4269 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4269 Tanklı Yazıcı", 6999.00m, 4.8m, 60, 2, null, null },
                    { 67, 4, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2583), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 12999.00m, 4.7m, 35, 2, null, null },
                    { 68, 11, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2601), "Canon PIXMA G8110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G8110", 6499.00m, 4.6m, 70, 2, null, null },
                    { 69, 12, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2603), "Epson L4267 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4267 Tanklı Yazıcı", 7499.00m, 4.9m, 50, 2, null, null },
                    { 70, 4, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2605), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 13999.00m, 4.8m, 30, 2, null, null },
                    { 71, 11, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2607), "Canon PIXMA G9110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G9110", 6999.00m, 4.7m, 60, 2, null, null },
                    { 72, 12, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2609), "Epson L4265 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4265 Tanklı Yazıcı", 7999.00m, 4.8m, 45, 2, null, null },
                    { 73, 4, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2612), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 14999.00m, 4.9m, 25, 2, null, null },
                    { 74, 11, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2614), "Canon PIXMA G1010 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1010", 7499.00m, 4.8m, 50, 2, null, null },
                    { 75, 12, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2616), "Epson L4264 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4264 Tanklı Yazıcı", 8499.00m, 4.9m, 40, 2, null, null },
                    { 76, 4, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2619), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 15999.00m, 5.0m, 20, 2, null, null },
                    { 77, 11, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2621), "Canon PIXMA G1110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1110", 7999.00m, 4.9m, 45, 2, null, null },
                    { 78, 12, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2623), "Epson L4263 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4263 Tanklı Yazıcı", 8999.00m, 5.0m, 35, 2, null, null },
                    { 79, 4, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2625), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 16999.00m, 5.0m, 15, 2, null, null },
                    { 80, 11, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2627), "Canon PIXMA G1210 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1210", 8499.00m, 5.0m, 40, 2, null, null },
                    { 81, 12, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2629), "Epson L4262 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4262 Tanklı Yazıcı", 9499.00m, 5.0m, 30, 2, null, null },
                    { 82, 4, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2632), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 17999.00m, 5.0m, 10, 2, null, null },
                    { 83, 11, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2637), "Canon PIXMA G1310 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1310", 8999.00m, 5.0m, 35, 2, null, null },
                    { 84, 12, 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2641), "Epson L4261 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4261 Tanklı Yazıcı", 9999.00m, 5.0m, 25, 2, null, null }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "EntityId", "EntityType", "IsDeleted", "Path", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2695), 1, 1, false, "img/ProductsPicture/Telephones/TelephoneOne/resimbir.jpg", null, null },
                    { 2, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2699), 1, 1, false, "img/ProductsPicture/Telephones/TelephoneOne/resimiki.jpg", null, null },
                    { 3, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2700), 1, 1, false, "img/ProductsPicture/Telephones/TelephoneOne/resimuc.jpg", null, null },
                    { 4, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2701), 1, 1, false, "img/ProductsPicture/Telephones/TelephoneOne/resimdort.jpg", null, null },
                    { 5, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2702), 2, 1, false, "img/ProductsPicture/Telephones/TelephoneTwo/resimbir.jpg", null, null },
                    { 6, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2704), 2, 1, false, "img/ProductsPicture/Telephones/TelephoneTwo/resimiki.jpg", null, null },
                    { 7, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2705), 2, 1, false, "img/ProductsPicture/Telephones/TelephoneTwo/resimuc.jpg", null, null },
                    { 8, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2707), 2, 1, false, "img/ProductsPicture/Telephones/TelephoneTwo/resimdort.jpg", null, null },
                    { 9, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2711), 3, 1, false, "img/ProductsPicture/Telephones/TelephoneThree/resimbir.jpg", null, null },
                    { 10, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2714), 3, 1, false, "img/ProductsPicture/Telephones/TelephoneThree/resimiki.jpg", null, null },
                    { 11, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2717), 3, 1, false, "img/ProductsPicture/Telephones/TelephoneThree/resimuc.jpg", null, null },
                    { 12, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2720), 3, 1, false, "img/ProductsPicture/Telephones/TelephoneThree/resimdort.jpg", null, null },
                    { 13, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2762), 4, 1, false, "img/ProductsPicture/Telephones/TelephoneFour/resimbir.jpg", null, null },
                    { 14, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2763), 4, 1, false, "img/ProductsPicture/Telephones/TelephoneFour/resimiki.jpg", null, null },
                    { 15, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2764), 4, 1, false, "img/ProductsPicture/Telephones/TelephoneFour/resimuc.jpg", null, null },
                    { 16, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2767), 4, 1, false, "img/ProductsPicture/Telephones/TelephoneFour/resimdort.jpg", null, null },
                    { 17, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2769), 5, 1, false, "img/ProductsPicture/Telephones/TelephoneFive/resimbir.jpg", null, null },
                    { 18, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2770), 5, 1, false, "img/ProductsPicture/Telephones/TelephoneFive/resimiki.jpg", null, null },
                    { 19, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2771), 5, 1, false, "img/ProductsPicture/Telephones/TelephoneFive/resimuc.jpg", null, null },
                    { 20, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2772), 5, 1, false, "img/ProductsPicture/Telephones/TelephoneFive/resimdort.jpg", null, null },
                    { 21, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2774), 6, 1, false, "img/ProductsPicture/Telephones/TelephoneSix/resimbir.jpg", null, null },
                    { 22, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2775), 6, 1, false, "img/ProductsPicture/Telephones/TelephoneSix/resimiki.jpg", null, null },
                    { 23, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2776), 6, 1, false, "img/ProductsPicture/Telephones/TelephoneSix/resimuc.jpg", null, null },
                    { 24, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2778), 6, 1, false, "img/ProductsPicture/Telephones/TelephoneSix/resimdort.jpg", null, null },
                    { 25, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2779), 7, 1, false, "img/ProductsPicture/Telephones/TelephoneSeven/resimbir.jpg", null, null },
                    { 26, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2780), 7, 1, false, "img/ProductsPicture/Telephones/TelephoneSeven/resimiki.jpg", null, null },
                    { 27, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2781), 7, 1, false, "img/ProductsPicture/Telephones/TelephoneSeven/resimuc.jpg", null, null },
                    { 28, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2782), 7, 1, false, "img/ProductsPicture/Telephones/TelephoneSeven/resimdort.jpg", null, null },
                    { 29, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2783), 8, 1, false, "img/ProductsPicture/Telephones/TelephoneEight/resimbir.jpg", null, null },
                    { 30, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2785), 8, 1, false, "img/ProductsPicture/Telephones/TelephoneEight/resimiki.jpg", null, null },
                    { 31, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2786), 8, 1, false, "img/ProductsPicture/Telephones/TelephoneEight/resimuc.jpg", null, null },
                    { 32, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2789), 8, 1, false, "img/ProductsPicture/Telephones/TelephoneEight/resimdort.jpg", null, null },
                    { 33, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2790), 9, 1, false, "img/ProductsPicture/Telephones/TelephoneNine/resimbir.jpg", null, null },
                    { 34, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2792), 9, 1, false, "img/ProductsPicture/Telephones/TelephoneNine/resimiki.jpg", null, null },
                    { 35, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2794), 9, 1, false, "img/ProductsPicture/Telephones/TelephoneNine/resimuc.jpg", null, null },
                    { 36, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2795), 9, 1, false, "img/ProductsPicture/Telephones/TelephoneNine/resimdort.jpg", null, null },
                    { 37, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2797), 10, 1, false, "img/ProductsPicture/Telephones/TelephoneTen/resimbir.jpg", null, null },
                    { 38, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2798), 10, 1, false, "img/ProductsPicture/Telephones/TelephoneTen/resimiki.jpg", null, null },
                    { 39, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2800), 10, 1, false, "img/ProductsPicture/Telephones/TelephoneTen/resimuc.jpg", null, null },
                    { 40, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2801), 10, 1, false, "img/ProductsPicture/Telephones/TelephoneTen/resimdort.jpg", null, null },
                    { 41, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2802), 11, 1, false, "img/ProductsPicture/Pc/PcOne/resimbir.jpg", null, null },
                    { 42, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2803), 11, 1, false, "img/ProductsPicture/Pc/PcOne/resimiki.jpg", null, null },
                    { 43, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2804), 11, 1, false, "img/ProductsPicture/Pc/PcOne/resimuc.jpg", null, null },
                    { 44, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2805), 11, 1, false, "img/ProductsPicture/Pc/PcOne/resimdort.jpg", null, null },
                    { 45, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2806), 12, 1, false, "img/Products/Laptops/Casper_G870.1270.jpg", null, null },
                    { 46, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2807), 13, 1, false, "img/Products/Laptops/MSI_15.6.jpg", null, null },
                    { 47, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2808), 14, 1, false, "img/Products/Laptops/Casper_S100.1362.jpg", null, null },
                    { 48, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2809), 15, 1, false, "img/Products/Laptops/Casper_G870.1362.jpg", null, null },
                    { 49, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2810), 16, 1, false, "img/Products/Laptops/HP_15.6.jpg", null, null },
                    { 50, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2811), 17, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 51, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2812), 18, 1, false, "img/Products/Laptops/Lenovo_model.jpg", null, null },
                    { 52, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2814), 19, 1, false, "img/Products/Laptops/MSI_model.jpg", null, null },
                    { 53, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2815), 20, 1, false, "img/Products/Laptops/Casper_C550.1255.jpg", null, null },
                    { 54, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2816), 21, 1, false, "img/Products/Laptops/Lenovo_3.2.jpg", null, null },
                    { 55, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2817), 22, 1, false, "img/Products/Laptops/Casper_G770.1245.jpg", null, null },
                    { 56, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2818), 23, 1, false, "img/Products/Laptops/Casper_X600.7430.jpg", null, null },
                    { 57, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2819), 24, 1, false, "img/Products/Laptops/Acer_15.6.jpg", null, null },
                    { 58, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2825), 25, 1, false, "img/Products/Laptops/Casper_X600.1270.jpg", null, null },
                    { 59, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2826), 26, 1, false, "img/Products/Laptops/Casper_G870.1342.jpg", null, null },
                    { 60, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2827), 27, 1, false, "img/Products/Laptops/Casper_G870.1270.jpg", null, null },
                    { 61, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2828), 28, 1, false, "img/Products/Laptops/HP_15.6.jpg", null, null },
                    { 62, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2829), 29, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 63, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2830), 30, 1, false, "img/Products/Laptops/Asus_15.6.jpg", null, null },
                    { 64, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2831), 31, 1, false, "img/Products/Laptops/Apple_model.jpg", null, null },
                    { 65, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2832), 32, 1, false, "img/Products/Laptops/Casper_G870.1342.jpg", null, null },
                    { 66, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2834), 33, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 67, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2835), 34, 1, false, "img/Products/Laptops/Asus_model.jpg", null, null },
                    { 68, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2836), 35, 1, false, "img/Products/Laptops/Casper_X600.1342.jpg", null, null },
                    { 69, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2837), 36, 1, false, "img/Products/Laptops/Lenovo_3.2.jpg", null, null },
                    { 70, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2838), 37, 1, false, "img/Products/Laptops/Casper_X600.1362.jpg", null, null },
                    { 71, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2839), 38, 1, false, "img/Products/Laptops/MSI_15.6.jpg", null, null },
                    { 72, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2840), 39, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 73, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2841), 40, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 74, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2872), 41, 1, false, "img/Products/Laptops/Apple_model.jpg", null, null },
                    { 75, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2874), 42, 1, false, "img/Products/Laptops/Casper_G870.1245.jpg", null, null },
                    { 76, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2875), 43, 1, false, "img/Products/PrintersandScanner/hp_hp_deskjet_ink_advantage_2878_allinone_yazc.jpg", null, null },
                    { 77, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2876), 44, 1, false, "img/Products/PrintersandScanner/canon_dolan_kartulu_e414_yazc_tarayc_fotokopi.jpg", null, null },
                    { 78, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2877), 45, 1, false, "img/Products/PrintersandScanner/canon_pixma_tr4650_tarayc_fotokopi_wifi_faks_ok_fonksiyonlu_yazc_canon_eurasia_garantili.jpg", null, null },
                    { 79, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2878), 46, 1, false, "img/Products/PrintersandScanner/canon_pixma_e3640_wifi_tarayc_fotokopi_ok_fonksiyonlu_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 80, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2879), 47, 1, false, "img/Products/PrintersandScanner/epson_l5290_wifi_renk_tankl_yazc.jpg", null, null },
                    { 81, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2880), 48, 1, false, "img/Products/PrintersandScanner/epson_tankl_l3150_photoink_muadil_mrekkepli_tankl_yazc_1_siyah_mrekkep_ve_fotoraf_kad_hediyeli.jpg", null, null },
                    { 82, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2882), 49, 1, false, "img/Products/PrintersandScanner/hp_officejet_pro_7720_fotokopi_faks_tarayc_wifi_airprint_a3_yazc_y0s18a.jpg", null, null },
                    { 83, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2883), 50, 1, false, "img/Products/PrintersandScanner/canon_e3640_wifi_yazc_ve_tpal_kartu_sistemi.jpg", null, null },
                    { 84, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2884), 51, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_l3250_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 85, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2885), 52, 1, false, "img/Products/PrintersandScanner/enp_canon_mf264dw_lazer_yazc_tarayc_fotokopi_wifi_lan_duplex.jpg", null, null },
                    { 86, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2886), 53, 1, false, "img/Products/PrintersandScanner/canon_pxma_g3430_renkli_mrekkep_mega_tankl_yazc_tarayc_fotokopi_wifi_1_ie_orijinal_siyah_mrekkep_hed.jpg", null, null },
                    { 87, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2887), 54, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_l3250_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 88, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2888), 55, 1, false, "img/Products/PrintersandScanner/canon_isensys_mf453dw_wf_ok_fonksiyonlu_lazer_yazc.jpg", null, null },
                    { 89, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2889), 56, 1, false, "img/Products/PrintersandScanner/canon_pixma_e3440_dolabilen_kartu_sistemli_yazc.jpg", null, null },
                    { 90, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2890), 57, 1, false, "img/Products/PrintersandScanner/epson_l6550_color_tankl_wifi_a4_yazc_fotokopi_tarayc_fax.jpg", null, null },
                    { 91, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2891), 58, 1, false, "img/Products/PrintersandScanner/hp_deskjet_2632_wifi_tarayc_fotokopi_renkli_ok_fonksiyonlu_mrekkep_pskrtmeli_yazc_v1n05b.jpg", null, null },
                    { 92, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2893), 59, 1, false, "img/Products/PrintersandScanner/canon_pixma_e514_fotokopi_tarayc_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 93, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2894), 60, 1, false, "img/Products/PrintersandScanner/epson_epson_ecotank_l11050_a3_tek_fonk_yazici.jpg", null, null },
                    { 94, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2895), 61, 1, false, "img/Products/PrintersandScanner/hp_hp_6uu47a_smart_tank_750_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 95, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2896), 62, 1, false, "img/Products/PrintersandScanner/canon_gx6040_yazctaraycfotokopi_renkli_mrekkep_tankl_yazc_wifi_ethernet.jpg", null, null },
                    { 96, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2897), 63, 1, false, "img/Products/PrintersandScanner/epson_surecolor_sc_f100_mrekkep_pskrtme_sblimasyon_yazc.jpg", null, null },
                    { 97, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2898), 64, 1, false, "img/Products/PrintersandScanner/hp_deskjet_1516_fotokopi_tarayc_yazc_b2l60c.jpg", null, null },
                    { 98, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2899), 65, 1, false, "img/Products/PrintersandScanner/canon_ix6850_renkli_inkjet_a3_fotoraf_yazcswifi_canon_eurasia_garantili.jpg", null, null },
                    { 99, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2900), 66, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 100, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2901), 67, 1, false, "img/Products/PrintersandScanner/hp_officejet_j4500_wifi_faxl_ok_fonksiyonlu_renkli_yazc_cn547a.jpg", null, null },
                    { 101, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2902), 68, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 102, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2903), 69, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_m1170_yazc_a4.jpg", null, null },
                    { 103, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2904), 70, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_wifi_ok_fonksiyonlu_yazc_bitmeyen_kartu_siyah_depo.jpg", null, null },
                    { 104, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2905), 71, 1, false, "img/Products/PrintersandScanner/canon_pixma_mg3050bk_wifi_fotokopi_tarayc_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 105, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2906), 72, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 106, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2907), 73, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 107, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2908), 74, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 108, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2909), 75, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 109, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2911), 76, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 110, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2912), 77, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 111, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2913), 78, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 112, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2914), 79, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 113, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2915), 80, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 114, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2916), 81, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 115, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2917), 82, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 116, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2918), 83, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 117, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(2919), 84, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductProperties",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "ProductId", "PropertyTypeId", "PropertyValueId", "Stock", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 81, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6085), true, false, 1, 1, 1, 50, null, null },
                    { 82, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6088), true, false, 1, 1, 2, 50, null, null },
                    { 83, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6088), true, false, 1, 1, 3, 50, null, null },
                    { 84, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6089), true, false, 1, 1, 4, 50, null, null },
                    { 85, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6112), true, false, 1, 3, 11, 75, null, null },
                    { 86, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6114), true, false, 1, 3, 12, 75, null, null },
                    { 87, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6114), true, false, 1, 3, 13, 75, null, null },
                    { 88, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6115), true, false, 1, 3, 14, 75, null, null },
                    { 89, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6116), true, false, 2, 1, 1, 50, null, null },
                    { 90, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6117), true, false, 2, 1, 2, 50, null, null },
                    { 91, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6117), true, false, 2, 1, 3, 50, null, null },
                    { 92, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6118), true, false, 2, 1, 4, 50, null, null },
                    { 93, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6118), true, false, 2, 3, 11, 75, null, null },
                    { 94, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6119), true, false, 2, 3, 12, 75, null, null },
                    { 95, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6119), true, false, 2, 3, 13, 75, null, null },
                    { 96, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6120), true, false, 2, 3, 14, 75, null, null },
                    { 97, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6120), true, false, 3, 1, 1, 50, null, null },
                    { 98, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6177), true, false, 3, 1, 2, 50, null, null },
                    { 99, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6180), true, false, 3, 1, 3, 50, null, null },
                    { 100, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6181), true, false, 3, 1, 4, 50, null, null },
                    { 101, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6182), true, false, 3, 3, 11, 75, null, null },
                    { 102, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6183), true, false, 3, 3, 12, 75, null, null },
                    { 103, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6183), true, false, 3, 3, 13, 75, null, null },
                    { 104, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6184), true, false, 3, 3, 14, 75, null, null },
                    { 105, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6184), true, false, 4, 1, 1, 50, null, null },
                    { 106, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6185), true, false, 4, 1, 2, 50, null, null },
                    { 107, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6185), true, false, 4, 1, 3, 50, null, null },
                    { 108, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6186), true, false, 4, 1, 4, 50, null, null },
                    { 109, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6186), true, false, 4, 3, 11, 75, null, null },
                    { 110, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6186), true, false, 4, 3, 12, 75, null, null },
                    { 111, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6187), true, false, 4, 3, 13, 75, null, null },
                    { 112, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6187), true, false, 4, 3, 14, 75, null, null },
                    { 113, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6188), true, false, 5, 1, 1, 50, null, null },
                    { 114, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6190), true, false, 5, 1, 2, 50, null, null },
                    { 115, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6191), true, false, 5, 1, 3, 50, null, null },
                    { 116, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6191), true, false, 5, 1, 4, 50, null, null },
                    { 117, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6192), true, false, 5, 3, 11, 75, null, null },
                    { 118, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6192), true, false, 5, 3, 12, 75, null, null },
                    { 119, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6193), true, false, 5, 3, 13, 75, null, null },
                    { 120, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6193), true, false, 5, 3, 14, 75, null, null },
                    { 121, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6194), true, false, 6, 1, 1, 50, null, null },
                    { 122, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6194), true, false, 6, 1, 2, 50, null, null },
                    { 123, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6195), true, false, 6, 1, 3, 50, null, null },
                    { 124, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6195), true, false, 6, 1, 4, 50, null, null },
                    { 125, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6195), true, false, 6, 3, 11, 75, null, null },
                    { 126, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6196), true, false, 6, 3, 12, 75, null, null },
                    { 127, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6196), true, false, 6, 3, 13, 75, null, null },
                    { 128, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6197), true, false, 6, 3, 14, 75, null, null },
                    { 129, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6197), true, false, 7, 1, 1, 50, null, null },
                    { 130, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6198), true, false, 7, 1, 2, 50, null, null },
                    { 131, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6198), true, false, 7, 1, 3, 50, null, null },
                    { 132, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6198), true, false, 7, 1, 4, 50, null, null },
                    { 133, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6199), true, false, 7, 3, 11, 75, null, null },
                    { 134, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6199), true, false, 7, 3, 12, 75, null, null },
                    { 135, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6200), true, false, 7, 3, 13, 75, null, null },
                    { 136, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6200), true, false, 7, 3, 14, 75, null, null },
                    { 137, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6201), true, false, 8, 1, 1, 50, null, null },
                    { 138, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6223), true, false, 8, 1, 2, 50, null, null },
                    { 139, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6224), true, false, 8, 1, 3, 50, null, null },
                    { 140, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6224), true, false, 8, 1, 4, 50, null, null },
                    { 141, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6225), true, false, 8, 3, 11, 75, null, null },
                    { 142, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6225), true, false, 8, 3, 12, 75, null, null },
                    { 143, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6226), true, false, 8, 3, 13, 75, null, null },
                    { 144, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6226), true, false, 8, 3, 14, 75, null, null },
                    { 145, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6227), true, false, 9, 1, 1, 50, null, null },
                    { 146, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6228), true, false, 9, 1, 2, 50, null, null },
                    { 147, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6228), true, false, 9, 1, 3, 50, null, null },
                    { 148, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6229), true, false, 9, 1, 4, 50, null, null },
                    { 149, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6229), true, false, 9, 3, 11, 75, null, null },
                    { 150, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6229), true, false, 9, 3, 12, 75, null, null },
                    { 151, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6230), true, false, 9, 3, 13, 75, null, null },
                    { 152, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6230), true, false, 9, 3, 14, 75, null, null },
                    { 153, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6231), true, false, 10, 1, 1, 50, null, null },
                    { 154, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6231), true, false, 10, 1, 2, 50, null, null },
                    { 155, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6232), true, false, 10, 1, 3, 50, null, null },
                    { 156, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6232), true, false, 10, 1, 4, 50, null, null },
                    { 157, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6232), true, false, 10, 3, 11, 75, null, null },
                    { 158, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6233), true, false, 10, 3, 12, 75, null, null },
                    { 159, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6233), true, false, 10, 3, 13, 75, null, null },
                    { 160, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6234), true, false, 10, 3, 14, 75, null, null },
                    { 161, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6235), true, false, 11, 1, 1, 50, null, null },
                    { 162, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6236), true, false, 11, 1, 2, 50, null, null },
                    { 163, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6236), true, false, 11, 1, 3, 50, null, null },
                    { 164, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6237), true, false, 11, 1, 4, 50, null, null },
                    { 165, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6238), true, false, 11, 3, 11, 75, null, null },
                    { 166, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6239), true, false, 11, 3, 12, 75, null, null },
                    { 167, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6239), true, false, 11, 3, 13, 75, null, null },
                    { 168, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6239), true, false, 11, 3, 14, 75, null, null },
                    { 169, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6242), true, false, 11, 4, 15, 50, null, null },
                    { 170, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6243), true, false, 11, 5, 23, 50, null, null },
                    { 171, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6245), true, false, 11, 6, 27, 50, null, null },
                    { 172, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6248), true, false, 11, 7, 30, 50, null, null },
                    { 173, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6249), true, false, 12, 1, 1, 50, null, null },
                    { 174, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6249), true, false, 12, 1, 2, 50, null, null },
                    { 175, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6249), true, false, 12, 1, 3, 50, null, null },
                    { 176, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6250), true, false, 12, 1, 4, 50, null, null },
                    { 177, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6250), true, false, 12, 3, 11, 75, null, null },
                    { 178, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6251), true, false, 12, 3, 12, 75, null, null },
                    { 179, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6251), true, false, 12, 3, 13, 75, null, null },
                    { 180, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6252), true, false, 12, 3, 14, 75, null, null },
                    { 181, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6253), true, false, 12, 4, 15, 50, null, null },
                    { 182, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6253), true, false, 12, 5, 24, 50, null, null },
                    { 183, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6254), true, false, 12, 6, 28, 50, null, null },
                    { 184, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6254), true, false, 12, 7, 30, 50, null, null },
                    { 185, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6255), true, false, 13, 1, 1, 50, null, null },
                    { 186, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6255), true, false, 13, 1, 2, 50, null, null },
                    { 187, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6256), true, false, 13, 1, 3, 50, null, null },
                    { 188, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6256), true, false, 13, 1, 4, 50, null, null },
                    { 189, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6256), true, false, 13, 3, 11, 75, null, null },
                    { 190, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6272), true, false, 13, 3, 12, 75, null, null },
                    { 191, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6273), true, false, 13, 3, 13, 75, null, null },
                    { 192, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6273), true, false, 13, 3, 14, 75, null, null },
                    { 193, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6274), true, false, 13, 4, 16, 50, null, null },
                    { 194, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6274), true, false, 13, 5, 23, 50, null, null },
                    { 195, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6275), true, false, 13, 6, 27, 50, null, null },
                    { 196, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6276), true, false, 13, 7, 29, 50, null, null },
                    { 197, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6276), true, false, 14, 1, 1, 50, null, null },
                    { 198, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6277), true, false, 14, 1, 2, 50, null, null },
                    { 199, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6277), true, false, 14, 1, 3, 50, null, null },
                    { 200, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6277), true, false, 14, 1, 4, 50, null, null },
                    { 201, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6278), true, false, 14, 3, 11, 75, null, null },
                    { 202, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6278), true, false, 14, 3, 12, 75, null, null },
                    { 203, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6279), true, false, 14, 3, 13, 75, null, null },
                    { 204, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6279), true, false, 14, 3, 14, 75, null, null },
                    { 205, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6280), true, false, 14, 4, 17, 50, null, null },
                    { 206, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6280), true, false, 14, 5, 24, 50, null, null },
                    { 207, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6281), true, false, 14, 6, 28, 50, null, null },
                    { 208, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6282), true, false, 14, 7, 31, 50, null, null },
                    { 209, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6282), true, false, 15, 1, 1, 50, null, null },
                    { 210, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6283), true, false, 15, 1, 2, 50, null, null },
                    { 211, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6284), true, false, 15, 1, 3, 50, null, null },
                    { 212, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6284), true, false, 15, 1, 4, 50, null, null },
                    { 213, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6285), true, false, 15, 3, 11, 75, null, null },
                    { 214, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6285), true, false, 15, 3, 12, 75, null, null },
                    { 215, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6285), true, false, 15, 3, 13, 75, null, null },
                    { 216, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6286), true, false, 15, 3, 14, 75, null, null },
                    { 217, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6287), true, false, 15, 4, 17, 50, null, null },
                    { 218, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6287), true, false, 15, 5, 24, 50, null, null },
                    { 219, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6288), true, false, 15, 6, 28, 50, null, null },
                    { 220, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6288), true, false, 15, 7, 30, 50, null, null },
                    { 221, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6289), true, false, 16, 1, 1, 50, null, null },
                    { 222, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6289), true, false, 16, 1, 2, 50, null, null },
                    { 223, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6290), true, false, 16, 1, 3, 50, null, null },
                    { 224, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6290), true, false, 16, 1, 4, 50, null, null },
                    { 225, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6290), true, false, 16, 3, 11, 75, null, null },
                    { 226, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6291), true, false, 16, 3, 12, 75, null, null },
                    { 227, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6291), true, false, 16, 3, 13, 75, null, null },
                    { 228, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6292), true, false, 16, 3, 14, 75, null, null },
                    { 229, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6292), true, false, 16, 4, 18, 50, null, null },
                    { 230, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6293), true, false, 16, 5, 23, 50, null, null },
                    { 231, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6293), true, false, 16, 6, 27, 50, null, null },
                    { 232, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6294), true, false, 16, 7, 30, 50, null, null },
                    { 233, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6327), true, false, 17, 1, 1, 50, null, null },
                    { 234, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6328), true, false, 17, 1, 2, 50, null, null },
                    { 235, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6329), true, false, 17, 1, 3, 50, null, null },
                    { 236, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6329), true, false, 17, 1, 4, 50, null, null },
                    { 237, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6330), true, false, 17, 3, 11, 75, null, null },
                    { 238, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6330), true, false, 17, 3, 12, 75, null, null },
                    { 239, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6331), true, false, 17, 3, 13, 75, null, null },
                    { 240, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6331), true, false, 17, 3, 14, 75, null, null },
                    { 241, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6332), true, false, 17, 4, 19, 50, null, null },
                    { 242, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6332), true, false, 17, 5, 23, 50, null, null },
                    { 243, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6333), true, false, 17, 6, 27, 50, null, null },
                    { 244, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6333), true, false, 17, 7, 31, 50, null, null },
                    { 245, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6334), true, false, 18, 1, 1, 50, null, null },
                    { 246, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6334), true, false, 18, 1, 2, 50, null, null },
                    { 247, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6335), true, false, 18, 1, 3, 50, null, null },
                    { 248, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6335), true, false, 18, 1, 4, 50, null, null },
                    { 249, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6336), true, false, 18, 3, 11, 75, null, null },
                    { 250, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6336), true, false, 18, 3, 12, 75, null, null },
                    { 251, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6336), true, false, 18, 3, 13, 75, null, null },
                    { 252, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6337), true, false, 18, 3, 14, 75, null, null },
                    { 253, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6338), true, false, 18, 4, 20, 50, null, null },
                    { 254, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6338), true, false, 18, 5, 23, 50, null, null },
                    { 255, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6339), true, false, 18, 6, 27, 50, null, null },
                    { 256, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6339), true, false, 18, 7, 30, 50, null, null },
                    { 257, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6340), true, false, 19, 1, 1, 50, null, null },
                    { 258, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6340), true, false, 19, 1, 2, 50, null, null },
                    { 259, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6340), true, false, 19, 1, 3, 50, null, null },
                    { 260, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6341), true, false, 19, 1, 4, 50, null, null },
                    { 261, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6341), true, false, 19, 3, 11, 75, null, null },
                    { 262, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6342), true, false, 19, 3, 12, 75, null, null },
                    { 263, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6342), true, false, 19, 3, 13, 75, null, null },
                    { 264, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6343), true, false, 19, 3, 14, 75, null, null },
                    { 265, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6343), true, false, 19, 4, 21, 50, null, null },
                    { 266, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6344), true, false, 19, 5, 22, 50, null, null },
                    { 267, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6344), true, false, 19, 6, 27, 50, null, null },
                    { 268, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6345), true, false, 19, 7, 30, 50, null, null },
                    { 269, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6345), true, false, 20, 1, 1, 50, null, null },
                    { 270, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6346), true, false, 20, 1, 2, 50, null, null },
                    { 271, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6346), true, false, 20, 1, 3, 50, null, null },
                    { 272, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6347), true, false, 20, 1, 4, 50, null, null },
                    { 273, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6347), true, false, 20, 3, 11, 75, null, null },
                    { 274, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6347), true, false, 20, 3, 12, 75, null, null },
                    { 275, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6348), true, false, 20, 3, 13, 75, null, null },
                    { 276, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6348), true, false, 20, 3, 14, 75, null, null },
                    { 277, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6349), true, false, 20, 4, 16, 50, null, null },
                    { 278, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6350), true, false, 20, 5, 23, 50, null, null },
                    { 279, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6350), true, false, 20, 6, 26, 50, null, null },
                    { 280, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6351), true, false, 20, 7, 30, 50, null, null },
                    { 281, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6351), true, false, 21, 1, 1, 50, null, null },
                    { 282, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6352), true, false, 21, 1, 2, 50, null, null },
                    { 283, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6352), true, false, 21, 1, 3, 50, null, null },
                    { 284, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6352), true, false, 21, 1, 4, 50, null, null },
                    { 285, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6353), true, false, 21, 3, 11, 75, null, null },
                    { 286, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6353), true, false, 21, 3, 12, 75, null, null },
                    { 287, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6354), true, false, 21, 3, 13, 75, null, null },
                    { 288, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6354), true, false, 21, 3, 14, 75, null, null },
                    { 289, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6355), true, false, 21, 4, 32, 50, null, null },
                    { 290, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6355), true, false, 21, 5, 24, 50, null, null },
                    { 291, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6356), true, false, 21, 6, 28, 50, null, null },
                    { 292, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6356), true, false, 21, 7, 30, 50, null, null },
                    { 293, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6357), true, false, 22, 1, 1, 50, null, null },
                    { 294, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6386), true, false, 22, 1, 2, 50, null, null },
                    { 295, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6387), true, false, 22, 1, 3, 50, null, null },
                    { 296, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6387), true, false, 22, 1, 4, 50, null, null },
                    { 297, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6388), true, false, 22, 3, 11, 75, null, null },
                    { 298, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6388), true, false, 22, 3, 12, 75, null, null },
                    { 299, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6388), true, false, 22, 3, 13, 75, null, null },
                    { 300, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6389), true, false, 22, 3, 14, 75, null, null },
                    { 301, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6390), true, false, 22, 4, 21, 50, null, null },
                    { 302, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6390), true, false, 22, 5, 24, 50, null, null },
                    { 303, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6391), true, false, 22, 6, 26, 50, null, null },
                    { 304, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6392), true, false, 22, 7, 30, 50, null, null },
                    { 305, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6392), true, false, 23, 1, 1, 50, null, null },
                    { 306, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6393), true, false, 23, 1, 2, 50, null, null },
                    { 307, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6393), true, false, 23, 1, 3, 50, null, null },
                    { 308, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6394), true, false, 23, 1, 4, 50, null, null },
                    { 309, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6394), true, false, 23, 3, 11, 75, null, null },
                    { 310, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6395), true, false, 23, 3, 12, 75, null, null },
                    { 311, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6395), true, false, 23, 3, 13, 75, null, null },
                    { 312, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6395), true, false, 23, 3, 14, 75, null, null },
                    { 313, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6396), true, false, 23, 4, 36, 50, null, null },
                    { 314, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6397), true, false, 23, 5, 23, 50, null, null },
                    { 315, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6397), true, false, 23, 6, 26, 50, null, null },
                    { 316, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6398), true, false, 23, 7, 30, 50, null, null },
                    { 317, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6398), true, false, 24, 1, 1, 50, null, null },
                    { 318, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6398), true, false, 24, 1, 2, 50, null, null },
                    { 319, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6399), true, false, 24, 1, 3, 50, null, null },
                    { 320, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6399), true, false, 24, 1, 4, 50, null, null },
                    { 321, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6400), true, false, 24, 3, 11, 75, null, null },
                    { 322, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6400), true, false, 24, 3, 12, 75, null, null },
                    { 323, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6401), true, false, 24, 3, 13, 75, null, null },
                    { 324, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6401), true, false, 24, 3, 14, 75, null, null },
                    { 325, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6402), true, false, 24, 4, 16, 50, null, null },
                    { 326, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6402), true, false, 24, 5, 23, 50, null, null },
                    { 327, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6403), true, false, 24, 6, 27, 50, null, null },
                    { 328, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6403), true, false, 24, 7, 30, 50, null, null },
                    { 329, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6404), true, false, 25, 1, 1, 50, null, null },
                    { 330, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6404), true, false, 25, 1, 2, 50, null, null },
                    { 331, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6404), true, false, 25, 1, 3, 50, null, null },
                    { 332, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6405), true, false, 25, 1, 4, 50, null, null },
                    { 333, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6405), true, false, 25, 3, 11, 75, null, null },
                    { 334, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6406), true, false, 25, 3, 12, 75, null, null },
                    { 335, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6406), true, false, 25, 3, 13, 75, null, null },
                    { 336, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6407), true, false, 25, 3, 14, 75, null, null },
                    { 337, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6407), true, false, 25, 4, 15, 50, null, null },
                    { 338, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6436), true, false, 25, 5, 24, 50, null, null },
                    { 339, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6436), true, false, 25, 6, 28, 50, null, null },
                    { 340, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6437), true, false, 25, 7, 30, 50, null, null },
                    { 341, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6437), true, false, 26, 1, 1, 50, null, null },
                    { 342, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6438), true, false, 26, 1, 2, 50, null, null },
                    { 343, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6438), true, false, 26, 1, 3, 50, null, null },
                    { 344, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6439), true, false, 26, 1, 4, 50, null, null },
                    { 345, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6439), true, false, 26, 3, 11, 75, null, null },
                    { 346, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6440), true, false, 26, 3, 12, 75, null, null },
                    { 347, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6440), true, false, 26, 3, 13, 75, null, null },
                    { 348, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6440), true, false, 26, 3, 14, 75, null, null },
                    { 349, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6441), true, false, 26, 4, 19, 50, null, null },
                    { 350, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6442), true, false, 26, 5, 24, 50, null, null },
                    { 351, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6442), true, false, 26, 6, 26, 50, null, null },
                    { 352, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6443), true, false, 26, 7, 30, 50, null, null },
                    { 353, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6443), true, false, 27, 1, 1, 50, null, null },
                    { 354, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6444), true, false, 27, 1, 2, 50, null, null },
                    { 355, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6444), true, false, 27, 1, 3, 50, null, null },
                    { 356, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6445), true, false, 27, 1, 4, 50, null, null },
                    { 357, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6445), true, false, 27, 3, 11, 75, null, null },
                    { 358, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6445), true, false, 27, 3, 12, 75, null, null },
                    { 359, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6446), true, false, 27, 3, 13, 75, null, null },
                    { 360, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6446), true, false, 27, 3, 14, 75, null, null },
                    { 361, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6447), true, false, 27, 4, 15, 50, null, null },
                    { 362, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6447), true, false, 27, 5, 24, 50, null, null },
                    { 363, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6448), true, false, 27, 6, 28, 50, null, null },
                    { 364, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6448), true, false, 27, 7, 30, 50, null, null },
                    { 365, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6449), true, false, 28, 1, 1, 50, null, null },
                    { 366, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6449), true, false, 28, 1, 2, 50, null, null },
                    { 367, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6450), true, false, 28, 1, 3, 50, null, null },
                    { 368, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6450), true, false, 28, 1, 4, 50, null, null },
                    { 369, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6451), true, false, 28, 3, 11, 75, null, null },
                    { 370, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6451), true, false, 28, 3, 12, 75, null, null },
                    { 371, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6452), true, false, 28, 3, 13, 75, null, null },
                    { 372, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6452), true, false, 28, 3, 14, 75, null, null },
                    { 373, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6453), true, false, 28, 4, 33, 50, null, null },
                    { 374, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6453), true, false, 28, 5, 23, 50, null, null },
                    { 375, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6454), true, false, 28, 6, 27, 50, null, null },
                    { 376, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6454), true, false, 28, 7, 30, 50, null, null },
                    { 377, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6455), true, false, 29, 1, 1, 50, null, null },
                    { 378, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6455), true, false, 29, 1, 2, 50, null, null },
                    { 379, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6455), true, false, 29, 1, 3, 50, null, null },
                    { 380, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6456), true, false, 29, 1, 4, 50, null, null },
                    { 381, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6456), true, false, 29, 3, 11, 75, null, null },
                    { 382, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6457), true, false, 29, 3, 12, 75, null, null },
                    { 383, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6457), true, false, 29, 3, 13, 75, null, null },
                    { 384, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6479), true, false, 29, 3, 14, 75, null, null },
                    { 385, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6480), true, false, 29, 4, 21, 50, null, null },
                    { 386, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6481), true, false, 29, 5, 22, 50, null, null },
                    { 387, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6481), true, false, 29, 6, 27, 50, null, null },
                    { 388, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6482), true, false, 29, 7, 30, 50, null, null },
                    { 389, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6482), true, false, 30, 1, 1, 50, null, null },
                    { 390, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6483), true, false, 30, 1, 2, 50, null, null },
                    { 391, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6483), true, false, 30, 1, 3, 50, null, null },
                    { 392, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6483), true, false, 30, 1, 4, 50, null, null },
                    { 393, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6484), true, false, 30, 3, 11, 75, null, null },
                    { 394, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6484), true, false, 30, 3, 12, 75, null, null },
                    { 395, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6485), true, false, 30, 3, 13, 75, null, null },
                    { 396, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6485), true, false, 30, 3, 14, 75, null, null },
                    { 397, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6486), true, false, 30, 4, 21, 50, null, null },
                    { 398, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6486), true, false, 30, 5, 22, 50, null, null },
                    { 399, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6487), true, false, 30, 6, 27, 50, null, null },
                    { 400, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6488), true, false, 30, 7, 30, 50, null, null },
                    { 401, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6488), true, false, 31, 1, 1, 50, null, null },
                    { 402, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6489), true, false, 31, 1, 2, 50, null, null },
                    { 403, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6489), true, false, 31, 1, 3, 50, null, null },
                    { 404, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6489), true, false, 31, 1, 4, 50, null, null },
                    { 405, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6490), true, false, 31, 3, 11, 75, null, null },
                    { 406, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6490), true, false, 31, 3, 12, 75, null, null },
                    { 407, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6491), true, false, 31, 3, 13, 75, null, null },
                    { 408, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6491), true, false, 31, 3, 14, 75, null, null },
                    { 409, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6492), true, false, 31, 4, 16, 50, null, null },
                    { 410, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6492), true, false, 31, 5, 23, 50, null, null },
                    { 411, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6493), true, false, 31, 6, 12, 50, null, null },
                    { 412, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6493), true, false, 31, 7, 29, 50, null, null },
                    { 413, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6494), true, false, 32, 1, 1, 50, null, null },
                    { 414, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6494), true, false, 32, 1, 2, 50, null, null },
                    { 415, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6495), true, false, 32, 1, 3, 50, null, null },
                    { 416, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6495), true, false, 32, 1, 4, 50, null, null },
                    { 417, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6496), true, false, 32, 3, 11, 75, null, null },
                    { 418, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6496), true, false, 32, 3, 12, 75, null, null },
                    { 419, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6496), true, false, 32, 3, 13, 75, null, null },
                    { 420, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6497), true, false, 32, 3, 14, 75, null, null },
                    { 421, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6497), true, false, 32, 4, 19, 50, null, null },
                    { 422, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6498), true, false, 32, 5, 23, 50, null, null },
                    { 423, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6499), true, false, 32, 6, 28, 50, null, null },
                    { 424, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6499), true, false, 32, 7, 30, 50, null, null },
                    { 425, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6500), true, false, 33, 1, 1, 50, null, null },
                    { 426, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6500), true, false, 33, 1, 2, 50, null, null },
                    { 427, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6501), true, false, 33, 1, 3, 50, null, null },
                    { 428, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6501), true, false, 33, 1, 4, 50, null, null },
                    { 429, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6501), true, false, 33, 3, 11, 75, null, null },
                    { 430, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6502), true, false, 33, 3, 12, 75, null, null },
                    { 431, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6502), true, false, 33, 3, 13, 75, null, null },
                    { 432, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6503), true, false, 33, 3, 14, 75, null, null },
                    { 433, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6503), true, false, 33, 4, 19, 50, null, null },
                    { 434, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6504), true, false, 33, 5, 23, 50, null, null },
                    { 435, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6504), true, false, 33, 6, 27, 50, null, null },
                    { 436, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6505), true, false, 33, 7, 29, 50, null, null },
                    { 437, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6505), true, false, 34, 1, 1, 50, null, null },
                    { 438, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6506), true, false, 34, 1, 2, 50, null, null },
                    { 439, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6506), true, false, 34, 1, 3, 50, null, null },
                    { 440, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6506), true, false, 34, 1, 4, 50, null, null },
                    { 441, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6507), true, false, 34, 3, 11, 75, null, null },
                    { 442, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6507), true, false, 34, 3, 12, 75, null, null },
                    { 443, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6508), true, false, 34, 3, 13, 75, null, null },
                    { 444, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6530), true, false, 34, 3, 14, 75, null, null },
                    { 445, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6531), true, false, 34, 4, 35, 50, null, null },
                    { 446, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6532), true, false, 34, 5, 24, 50, null, null },
                    { 447, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6532), true, false, 34, 6, 28, 50, null, null },
                    { 448, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6533), true, false, 34, 7, 31, 50, null, null },
                    { 449, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6533), true, false, 35, 1, 1, 50, null, null },
                    { 450, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6534), true, false, 35, 1, 2, 50, null, null },
                    { 451, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6534), true, false, 35, 1, 3, 50, null, null },
                    { 452, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6535), true, false, 35, 1, 4, 50, null, null },
                    { 453, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6535), true, false, 35, 3, 11, 75, null, null },
                    { 454, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6535), true, false, 35, 3, 12, 75, null, null },
                    { 455, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6536), true, false, 35, 3, 13, 75, null, null },
                    { 456, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6536), true, false, 35, 3, 14, 75, null, null },
                    { 457, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6537), true, false, 35, 4, 19, 50, null, null },
                    { 458, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6537), true, false, 35, 5, 24, 50, null, null },
                    { 459, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6538), true, false, 35, 6, 26, 50, null, null },
                    { 460, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6539), true, false, 35, 7, 30, 50, null, null },
                    { 461, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6539), true, false, 36, 1, 1, 50, null, null },
                    { 462, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6539), true, false, 36, 1, 2, 50, null, null },
                    { 463, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6540), true, false, 36, 1, 3, 50, null, null },
                    { 464, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6540), true, false, 36, 1, 4, 50, null, null },
                    { 465, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6541), true, false, 36, 3, 11, 75, null, null },
                    { 466, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6541), true, false, 36, 3, 12, 75, null, null },
                    { 467, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6542), true, false, 36, 3, 13, 75, null, null },
                    { 468, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6542), true, false, 36, 3, 14, 75, null, null },
                    { 469, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6543), true, false, 36, 4, 34, 50, null, null },
                    { 470, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6543), true, false, 36, 5, 24, 50, null, null },
                    { 471, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6544), true, false, 36, 6, 28, 50, null, null },
                    { 472, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6545), true, false, 36, 7, 31, 50, null, null },
                    { 473, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6545), true, false, 37, 1, 1, 50, null, null },
                    { 474, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6545), true, false, 37, 1, 2, 50, null, null },
                    { 475, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6546), true, false, 37, 1, 3, 50, null, null },
                    { 476, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6546), true, false, 37, 1, 4, 50, null, null },
                    { 477, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6547), true, false, 37, 3, 11, 75, null, null },
                    { 478, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6547), true, false, 37, 3, 12, 75, null, null },
                    { 479, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6547), true, false, 37, 3, 13, 75, null, null },
                    { 480, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6548), true, false, 37, 3, 14, 75, null, null },
                    { 481, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6549), true, false, 37, 4, 17, 50, null, null },
                    { 482, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6549), true, false, 37, 5, 23, 50, null, null },
                    { 483, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6550), true, false, 37, 6, 26, 50, null, null },
                    { 484, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6550), true, false, 37, 7, 30, 50, null, null },
                    { 485, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6550), true, false, 38, 1, 1, 50, null, null },
                    { 486, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6551), true, false, 38, 1, 2, 50, null, null },
                    { 487, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6551), true, false, 38, 1, 3, 50, null, null },
                    { 488, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6552), true, false, 38, 1, 4, 50, null, null },
                    { 489, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6552), true, false, 38, 3, 11, 75, null, null },
                    { 490, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6553), true, false, 38, 3, 12, 75, null, null },
                    { 491, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6553), true, false, 38, 3, 13, 75, null, null },
                    { 492, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6553), true, false, 38, 3, 14, 75, null, null },
                    { 493, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6554), true, false, 38, 4, 19, 50, null, null },
                    { 494, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6555), true, false, 38, 5, 23, 50, null, null },
                    { 495, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6555), true, false, 38, 6, 28, 50, null, null },
                    { 496, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6556), true, false, 38, 7, 30, 50, null, null },
                    { 497, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6556), true, false, 39, 1, 1, 50, null, null },
                    { 498, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6556), true, false, 39, 1, 2, 50, null, null },
                    { 499, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6557), true, false, 39, 1, 3, 50, null, null },
                    { 500, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6557), true, false, 39, 1, 4, 50, null, null },
                    { 501, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6558), true, false, 39, 3, 11, 75, null, null },
                    { 502, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6558), true, false, 39, 3, 12, 75, null, null },
                    { 503, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6558), true, false, 39, 3, 13, 75, null, null },
                    { 504, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6559), true, false, 39, 3, 14, 75, null, null },
                    { 505, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6606), true, false, 39, 4, 36, 50, null, null },
                    { 506, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6607), true, false, 39, 5, 22, 50, null, null },
                    { 507, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6608), true, false, 39, 6, 27, 50, null, null },
                    { 508, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6608), true, false, 39, 7, 30, 50, null, null },
                    { 509, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6609), true, false, 40, 1, 1, 50, null, null },
                    { 510, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6609), true, false, 40, 1, 2, 50, null, null },
                    { 511, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6610), true, false, 40, 1, 3, 50, null, null },
                    { 512, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6610), true, false, 40, 1, 4, 50, null, null },
                    { 513, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6611), true, false, 40, 3, 11, 75, null, null },
                    { 514, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6611), true, false, 40, 3, 12, 75, null, null },
                    { 515, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6611), true, false, 40, 3, 13, 75, null, null },
                    { 516, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6612), true, false, 40, 3, 14, 75, null, null },
                    { 517, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6613), true, false, 40, 4, 19, 50, null, null },
                    { 518, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6613), true, false, 40, 5, 24, 50, null, null },
                    { 519, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6614), true, false, 40, 6, 28, 50, null, null },
                    { 520, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6614), true, false, 40, 7, 30, 50, null, null },
                    { 521, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6615), true, false, 41, 1, 1, 50, null, null },
                    { 522, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6615), true, false, 41, 1, 2, 50, null, null },
                    { 523, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6616), true, false, 41, 1, 3, 50, null, null },
                    { 524, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6616), true, false, 41, 1, 4, 50, null, null },
                    { 525, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6616), true, false, 41, 3, 11, 75, null, null },
                    { 526, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6617), true, false, 41, 3, 12, 75, null, null },
                    { 527, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6617), true, false, 41, 3, 13, 75, null, null },
                    { 528, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6618), true, false, 41, 3, 14, 75, null, null },
                    { 529, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6618), true, false, 41, 4, 16, 50, null, null },
                    { 530, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6619), true, false, 41, 5, 23, 50, null, null },
                    { 531, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6619), true, false, 41, 6, 12, 50, null, null },
                    { 532, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6620), true, false, 41, 7, 29, 50, null, null },
                    { 533, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6621), true, false, 42, 1, 1, 50, null, null },
                    { 534, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6621), true, false, 42, 1, 2, 50, null, null },
                    { 535, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6621), true, false, 42, 1, 3, 50, null, null },
                    { 536, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6622), true, false, 42, 1, 4, 50, null, null },
                    { 537, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6622), true, false, 42, 3, 11, 75, null, null },
                    { 538, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6623), true, false, 42, 3, 12, 75, null, null },
                    { 539, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6623), true, false, 42, 3, 13, 75, null, null },
                    { 540, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6624), true, false, 42, 3, 14, 75, null, null },
                    { 541, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6624), true, false, 42, 4, 21, 50, null, null },
                    { 542, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6625), true, false, 42, 5, 23, 50, null, null },
                    { 543, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6626), true, false, 42, 6, 26, 50, null, null },
                    { 544, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6626), true, false, 42, 7, 30, 50, null, null },
                    { 545, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6629), true, false, 43, 8, 37, 50, null, null },
                    { 546, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6630), true, false, 43, 9, 40, 50, null, null },
                    { 547, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6632), true, false, 43, 10, 43, 50, null, null },
                    { 548, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6642), true, false, 43, 11, 46, 50, null, null },
                    { 549, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6643), true, false, 43, 11, 47, 50, null, null },
                    { 550, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6643), true, false, 43, 11, 48, 50, null, null },
                    { 551, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6644), true, false, 43, 11, 50, 50, null, null },
                    { 552, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6644), true, false, 43, 11, 51, 50, null, null },
                    { 553, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6645), true, false, 44, 8, 37, 50, null, null },
                    { 554, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6646), true, false, 44, 9, 40, 50, null, null },
                    { 555, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6647), true, false, 44, 10, 43, 50, null, null },
                    { 556, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6648), true, false, 44, 11, 46, 50, null, null },
                    { 557, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6649), true, false, 44, 11, 47, 50, null, null },
                    { 558, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6649), true, false, 44, 11, 48, 50, null, null },
                    { 559, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6650), true, false, 44, 11, 50, 50, null, null },
                    { 560, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6650), true, false, 44, 11, 51, 50, null, null },
                    { 561, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6651), true, false, 45, 8, 37, 50, null, null },
                    { 562, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6651), true, false, 45, 9, 40, 50, null, null },
                    { 563, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6675), true, false, 45, 10, 43, 50, null, null },
                    { 564, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6676), true, false, 45, 11, 46, 50, null, null },
                    { 565, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6676), true, false, 45, 11, 47, 50, null, null },
                    { 566, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6677), true, false, 45, 11, 48, 50, null, null },
                    { 567, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6677), true, false, 45, 11, 50, 50, null, null },
                    { 568, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6678), true, false, 45, 11, 51, 50, null, null },
                    { 569, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6679), true, false, 46, 8, 37, 50, null, null },
                    { 570, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6679), true, false, 46, 9, 40, 50, null, null },
                    { 571, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6680), true, false, 46, 10, 43, 50, null, null },
                    { 572, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6681), true, false, 46, 11, 46, 50, null, null },
                    { 573, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6682), true, false, 46, 11, 47, 50, null, null },
                    { 574, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6682), true, false, 46, 11, 48, 50, null, null },
                    { 575, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6682), true, false, 46, 11, 50, 50, null, null },
                    { 576, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6683), true, false, 46, 11, 51, 50, null, null },
                    { 577, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6684), true, false, 47, 8, 37, 50, null, null },
                    { 578, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6684), true, false, 47, 9, 40, 50, null, null },
                    { 579, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6685), true, false, 47, 10, 43, 50, null, null },
                    { 580, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6686), true, false, 47, 11, 46, 50, null, null },
                    { 581, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6686), true, false, 47, 11, 47, 50, null, null },
                    { 582, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6687), true, false, 47, 11, 48, 50, null, null },
                    { 583, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6687), true, false, 47, 11, 50, 50, null, null },
                    { 584, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6687), true, false, 47, 11, 51, 50, null, null },
                    { 585, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6688), true, false, 48, 8, 37, 50, null, null },
                    { 586, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6689), true, false, 48, 9, 40, 50, null, null },
                    { 587, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6689), true, false, 48, 10, 43, 50, null, null },
                    { 588, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6690), true, false, 48, 11, 46, 50, null, null },
                    { 589, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6691), true, false, 48, 11, 47, 50, null, null },
                    { 590, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6691), true, false, 48, 11, 48, 50, null, null },
                    { 591, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6692), true, false, 48, 11, 50, 50, null, null },
                    { 592, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6692), true, false, 48, 11, 51, 50, null, null },
                    { 593, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6693), true, false, 49, 8, 37, 50, null, null },
                    { 594, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6747), true, false, 49, 9, 40, 50, null, null },
                    { 595, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6748), true, false, 49, 10, 43, 50, null, null },
                    { 596, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6750), true, false, 49, 11, 46, 50, null, null },
                    { 597, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6750), true, false, 49, 11, 47, 50, null, null },
                    { 598, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6751), true, false, 49, 11, 48, 50, null, null },
                    { 599, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6751), true, false, 49, 11, 50, 50, null, null },
                    { 600, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6752), true, false, 49, 11, 51, 50, null, null },
                    { 601, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6753), true, false, 50, 8, 37, 50, null, null },
                    { 602, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6754), true, false, 50, 9, 40, 50, null, null },
                    { 603, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6755), true, false, 50, 10, 43, 50, null, null },
                    { 604, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6756), true, false, 50, 11, 46, 50, null, null },
                    { 605, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6756), true, false, 50, 11, 47, 50, null, null },
                    { 606, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6757), true, false, 50, 11, 48, 50, null, null },
                    { 607, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6757), true, false, 50, 11, 50, 50, null, null },
                    { 608, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6758), true, false, 50, 11, 51, 50, null, null },
                    { 609, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6758), true, false, 51, 8, 37, 50, null, null },
                    { 610, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6759), true, false, 51, 9, 40, 50, null, null },
                    { 611, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6760), true, false, 51, 10, 43, 50, null, null },
                    { 612, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6761), true, false, 51, 11, 46, 50, null, null },
                    { 613, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6762), true, false, 51, 11, 47, 50, null, null },
                    { 614, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6762), true, false, 51, 11, 48, 50, null, null },
                    { 615, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6762), true, false, 51, 11, 50, 50, null, null },
                    { 616, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6763), true, false, 51, 11, 51, 50, null, null },
                    { 617, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6772), true, false, 52, 8, 37, 50, null, null },
                    { 618, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6773), true, false, 52, 9, 40, 50, null, null },
                    { 619, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6773), true, false, 52, 10, 43, 50, null, null },
                    { 620, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6775), true, false, 52, 11, 46, 50, null, null },
                    { 621, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6775), true, false, 52, 11, 47, 50, null, null },
                    { 622, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6776), true, false, 52, 11, 48, 50, null, null },
                    { 623, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6776), true, false, 52, 11, 50, 50, null, null },
                    { 624, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6776), true, false, 52, 11, 51, 50, null, null },
                    { 625, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6777), true, false, 53, 8, 37, 50, null, null },
                    { 626, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6778), true, false, 53, 9, 40, 50, null, null },
                    { 627, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6778), true, false, 53, 10, 43, 50, null, null },
                    { 628, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6780), true, false, 53, 11, 46, 50, null, null },
                    { 629, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6780), true, false, 53, 11, 47, 50, null, null },
                    { 630, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6780), true, false, 53, 11, 48, 50, null, null },
                    { 631, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6781), true, false, 53, 11, 50, 50, null, null },
                    { 632, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6781), true, false, 53, 11, 51, 50, null, null },
                    { 633, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6782), true, false, 54, 8, 37, 50, null, null },
                    { 634, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6782), true, false, 54, 9, 40, 50, null, null },
                    { 635, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6783), true, false, 54, 10, 43, 50, null, null },
                    { 636, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6784), true, false, 54, 11, 46, 50, null, null },
                    { 637, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6785), true, false, 54, 11, 47, 50, null, null },
                    { 638, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6785), true, false, 54, 11, 48, 50, null, null },
                    { 639, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6786), true, false, 54, 11, 50, 50, null, null },
                    { 640, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6786), true, false, 54, 11, 51, 50, null, null },
                    { 641, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6787), true, false, 55, 8, 37, 50, null, null },
                    { 642, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6787), true, false, 55, 9, 40, 50, null, null },
                    { 643, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6788), true, false, 55, 10, 43, 50, null, null },
                    { 644, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6789), true, false, 55, 11, 46, 50, null, null },
                    { 645, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6789), true, false, 55, 11, 47, 50, null, null },
                    { 646, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6790), true, false, 55, 11, 48, 50, null, null },
                    { 647, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6790), true, false, 55, 11, 50, 50, null, null },
                    { 648, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6791), true, false, 55, 11, 51, 50, null, null },
                    { 649, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6791), true, false, 56, 8, 37, 50, null, null },
                    { 650, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6792), true, false, 56, 9, 40, 50, null, null },
                    { 651, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6792), true, false, 56, 10, 43, 50, null, null },
                    { 652, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6794), true, false, 56, 11, 46, 50, null, null },
                    { 653, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6794), true, false, 56, 11, 47, 50, null, null },
                    { 654, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6794), true, false, 56, 11, 48, 50, null, null },
                    { 655, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6795), true, false, 56, 11, 50, 50, null, null },
                    { 656, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6795), true, false, 56, 11, 51, 50, null, null },
                    { 657, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6796), true, false, 57, 8, 37, 50, null, null },
                    { 658, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6796), true, false, 57, 9, 40, 50, null, null },
                    { 659, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6797), true, false, 57, 10, 43, 50, null, null },
                    { 660, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6798), true, false, 57, 11, 46, 50, null, null },
                    { 661, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6798), true, false, 57, 11, 47, 50, null, null },
                    { 662, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6799), true, false, 57, 11, 48, 50, null, null },
                    { 663, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6799), true, false, 57, 11, 50, 50, null, null },
                    { 664, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6800), true, false, 57, 11, 51, 50, null, null },
                    { 665, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6800), true, false, 58, 8, 37, 50, null, null },
                    { 666, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6801), true, false, 58, 9, 40, 50, null, null },
                    { 667, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6802), true, false, 58, 10, 43, 50, null, null },
                    { 668, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6803), true, false, 58, 11, 46, 50, null, null },
                    { 669, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6803), true, false, 58, 11, 47, 50, null, null },
                    { 670, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6813), true, false, 58, 11, 48, 50, null, null },
                    { 671, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6813), true, false, 58, 11, 50, 50, null, null },
                    { 672, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6813), true, false, 58, 11, 51, 50, null, null },
                    { 673, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6814), true, false, 59, 8, 37, 50, null, null },
                    { 674, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6814), true, false, 59, 9, 40, 50, null, null },
                    { 675, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6815), true, false, 59, 10, 43, 50, null, null },
                    { 676, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6816), true, false, 59, 11, 46, 50, null, null },
                    { 677, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6817), true, false, 59, 11, 47, 50, null, null },
                    { 678, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6817), true, false, 59, 11, 48, 50, null, null },
                    { 679, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6818), true, false, 59, 11, 50, 50, null, null },
                    { 680, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6818), true, false, 59, 11, 51, 50, null, null },
                    { 681, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6819), true, false, 60, 8, 37, 50, null, null },
                    { 682, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6819), true, false, 60, 9, 40, 50, null, null },
                    { 683, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6820), true, false, 60, 10, 43, 50, null, null },
                    { 684, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6821), true, false, 60, 11, 46, 50, null, null },
                    { 685, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6821), true, false, 60, 11, 47, 50, null, null },
                    { 686, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6822), true, false, 60, 11, 48, 50, null, null },
                    { 687, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6822), true, false, 60, 11, 50, 50, null, null },
                    { 688, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6823), true, false, 60, 11, 51, 50, null, null },
                    { 689, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6823), true, false, 61, 8, 37, 50, null, null },
                    { 690, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6824), true, false, 61, 9, 40, 50, null, null },
                    { 691, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6824), true, false, 61, 10, 43, 50, null, null },
                    { 692, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6825), true, false, 61, 11, 46, 50, null, null },
                    { 693, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6826), true, false, 61, 11, 47, 50, null, null },
                    { 694, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6826), true, false, 61, 11, 48, 50, null, null },
                    { 695, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6827), true, false, 61, 11, 50, 50, null, null },
                    { 696, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6827), true, false, 61, 11, 51, 50, null, null },
                    { 697, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6828), true, false, 62, 8, 37, 50, null, null },
                    { 698, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6828), true, false, 62, 9, 40, 50, null, null },
                    { 699, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6829), true, false, 62, 10, 43, 50, null, null },
                    { 700, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6830), true, false, 62, 11, 46, 50, null, null },
                    { 701, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6830), true, false, 62, 11, 47, 50, null, null },
                    { 702, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6831), true, false, 62, 11, 48, 50, null, null },
                    { 703, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6831), true, false, 62, 11, 50, 50, null, null },
                    { 704, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6832), true, false, 62, 11, 51, 50, null, null },
                    { 705, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6832), true, false, 63, 8, 37, 50, null, null },
                    { 706, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6833), true, false, 63, 9, 40, 50, null, null },
                    { 707, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6833), true, false, 63, 10, 43, 50, null, null },
                    { 708, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6834), true, false, 63, 11, 46, 50, null, null },
                    { 709, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6835), true, false, 63, 11, 47, 50, null, null },
                    { 710, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6835), true, false, 63, 11, 48, 50, null, null },
                    { 711, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6836), true, false, 63, 11, 50, 50, null, null },
                    { 712, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6836), true, false, 63, 11, 51, 50, null, null },
                    { 713, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6836), true, false, 64, 8, 37, 50, null, null },
                    { 714, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6837), true, false, 64, 9, 40, 50, null, null },
                    { 715, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6837), true, false, 64, 10, 43, 50, null, null },
                    { 716, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6839), true, false, 64, 11, 46, 50, null, null },
                    { 717, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6839), true, false, 64, 11, 47, 50, null, null },
                    { 718, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6840), true, false, 64, 11, 48, 50, null, null },
                    { 719, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6840), true, false, 64, 11, 50, 50, null, null },
                    { 720, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6840), true, false, 64, 11, 51, 50, null, null },
                    { 721, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6841), true, false, 65, 8, 37, 50, null, null },
                    { 722, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6841), true, false, 65, 9, 40, 50, null, null },
                    { 723, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6842), true, false, 65, 10, 43, 50, null, null },
                    { 724, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6852), true, false, 65, 11, 46, 50, null, null },
                    { 725, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6852), true, false, 65, 11, 47, 50, null, null },
                    { 726, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6853), true, false, 65, 11, 48, 50, null, null },
                    { 727, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6853), true, false, 65, 11, 50, 50, null, null },
                    { 728, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6853), true, false, 65, 11, 51, 50, null, null },
                    { 729, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6854), true, false, 66, 8, 37, 50, null, null },
                    { 730, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6855), true, false, 66, 9, 40, 50, null, null },
                    { 731, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6855), true, false, 66, 10, 43, 50, null, null },
                    { 732, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6856), true, false, 66, 11, 46, 50, null, null },
                    { 733, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6857), true, false, 66, 11, 47, 50, null, null },
                    { 734, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6857), true, false, 66, 11, 48, 50, null, null },
                    { 735, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6857), true, false, 66, 11, 50, 50, null, null },
                    { 736, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6858), true, false, 66, 11, 51, 50, null, null },
                    { 737, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6858), true, false, 67, 8, 37, 50, null, null },
                    { 738, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6859), true, false, 67, 9, 40, 50, null, null },
                    { 739, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6859), true, false, 67, 10, 43, 50, null, null },
                    { 740, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6861), true, false, 67, 11, 46, 50, null, null },
                    { 741, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6861), true, false, 67, 11, 47, 50, null, null },
                    { 742, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6861), true, false, 67, 11, 48, 50, null, null },
                    { 743, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6862), true, false, 67, 11, 50, 50, null, null },
                    { 744, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6862), true, false, 67, 11, 51, 50, null, null },
                    { 745, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6863), true, false, 68, 8, 37, 50, null, null },
                    { 746, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6863), true, false, 68, 9, 40, 50, null, null },
                    { 747, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6864), true, false, 68, 10, 43, 50, null, null },
                    { 748, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6865), true, false, 68, 11, 46, 50, null, null },
                    { 749, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6865), true, false, 68, 11, 47, 50, null, null },
                    { 750, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6866), true, false, 68, 11, 48, 50, null, null },
                    { 751, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6866), true, false, 68, 11, 50, 50, null, null },
                    { 752, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6867), true, false, 68, 11, 51, 50, null, null },
                    { 753, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6867), true, false, 69, 8, 37, 50, null, null },
                    { 754, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6868), true, false, 69, 9, 40, 50, null, null },
                    { 755, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6868), true, false, 69, 10, 43, 50, null, null },
                    { 756, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6869), true, false, 69, 11, 46, 50, null, null },
                    { 757, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6870), true, false, 69, 11, 47, 50, null, null },
                    { 758, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6870), true, false, 69, 11, 48, 50, null, null },
                    { 759, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6871), true, false, 69, 11, 50, 50, null, null },
                    { 760, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6871), true, false, 69, 11, 51, 50, null, null },
                    { 761, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6872), true, false, 70, 8, 37, 50, null, null },
                    { 762, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6872), true, false, 70, 9, 40, 50, null, null },
                    { 763, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6872), true, false, 70, 10, 43, 50, null, null },
                    { 764, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6874), true, false, 70, 11, 46, 50, null, null },
                    { 765, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6874), true, false, 70, 11, 47, 50, null, null },
                    { 766, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6875), true, false, 70, 11, 48, 50, null, null },
                    { 767, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6875), true, false, 70, 11, 50, 50, null, null },
                    { 768, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6876), true, false, 70, 11, 51, 50, null, null },
                    { 769, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6876), true, false, 71, 8, 37, 50, null, null },
                    { 770, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6877), true, false, 71, 9, 40, 50, null, null },
                    { 771, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6877), true, false, 71, 10, 43, 50, null, null },
                    { 772, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6878), true, false, 71, 11, 46, 50, null, null },
                    { 773, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6879), true, false, 71, 11, 47, 50, null, null },
                    { 774, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6879), true, false, 71, 11, 48, 50, null, null },
                    { 775, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6880), true, false, 71, 11, 50, 50, null, null },
                    { 776, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6880), true, false, 71, 11, 51, 50, null, null },
                    { 777, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6881), true, false, 72, 8, 37, 50, null, null },
                    { 778, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6881), true, false, 72, 9, 40, 50, null, null },
                    { 779, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6890), true, false, 72, 10, 43, 50, null, null },
                    { 780, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6892), true, false, 72, 11, 46, 50, null, null },
                    { 781, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6892), true, false, 72, 11, 47, 50, null, null },
                    { 782, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6893), true, false, 72, 11, 48, 50, null, null },
                    { 783, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6893), true, false, 72, 11, 50, 50, null, null },
                    { 784, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6893), true, false, 72, 11, 51, 50, null, null },
                    { 785, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6894), true, false, 73, 8, 37, 50, null, null },
                    { 786, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6895), true, false, 73, 9, 40, 50, null, null },
                    { 787, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6895), true, false, 73, 10, 43, 50, null, null },
                    { 788, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6896), true, false, 73, 11, 46, 50, null, null },
                    { 789, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6897), true, false, 73, 11, 47, 50, null, null },
                    { 790, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6897), true, false, 73, 11, 48, 50, null, null },
                    { 791, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6898), true, false, 73, 11, 50, 50, null, null },
                    { 792, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6898), true, false, 73, 11, 51, 50, null, null },
                    { 793, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6899), true, false, 74, 8, 37, 50, null, null },
                    { 794, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6899), true, false, 74, 9, 40, 50, null, null },
                    { 795, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6900), true, false, 74, 10, 43, 50, null, null },
                    { 796, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6901), true, false, 74, 11, 46, 50, null, null },
                    { 797, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6901), true, false, 74, 11, 47, 50, null, null },
                    { 798, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6902), true, false, 74, 11, 48, 50, null, null },
                    { 799, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6902), true, false, 74, 11, 50, 50, null, null },
                    { 800, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6902), true, false, 74, 11, 51, 50, null, null },
                    { 801, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6903), true, false, 75, 8, 37, 50, null, null },
                    { 802, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6904), true, false, 75, 9, 40, 50, null, null },
                    { 803, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6904), true, false, 75, 10, 43, 50, null, null },
                    { 804, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6905), true, false, 75, 11, 46, 50, null, null },
                    { 805, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6906), true, false, 75, 11, 47, 50, null, null },
                    { 806, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6906), true, false, 75, 11, 48, 50, null, null },
                    { 807, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6907), true, false, 75, 11, 50, 50, null, null },
                    { 808, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6907), true, false, 75, 11, 51, 50, null, null },
                    { 809, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6908), true, false, 76, 8, 37, 50, null, null },
                    { 810, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6908), true, false, 76, 9, 40, 50, null, null },
                    { 811, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6909), true, false, 76, 10, 43, 50, null, null },
                    { 812, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6910), true, false, 76, 11, 46, 50, null, null },
                    { 813, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6910), true, false, 76, 11, 47, 50, null, null },
                    { 814, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6911), true, false, 76, 11, 48, 50, null, null },
                    { 815, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6911), true, false, 76, 11, 50, 50, null, null },
                    { 816, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6912), true, false, 76, 11, 51, 50, null, null },
                    { 817, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6912), true, false, 77, 8, 37, 50, null, null },
                    { 818, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6913), true, false, 77, 9, 40, 50, null, null },
                    { 819, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6913), true, false, 77, 10, 43, 50, null, null },
                    { 820, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6915), true, false, 77, 11, 46, 50, null, null },
                    { 821, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6915), true, false, 77, 11, 47, 50, null, null },
                    { 822, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6916), true, false, 77, 11, 48, 50, null, null },
                    { 823, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6916), true, false, 77, 11, 50, 50, null, null },
                    { 824, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6916), true, false, 77, 11, 51, 50, null, null },
                    { 825, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6917), true, false, 78, 8, 37, 50, null, null },
                    { 826, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6917), true, false, 78, 9, 40, 50, null, null },
                    { 827, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6918), true, false, 78, 10, 43, 50, null, null },
                    { 828, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6919), true, false, 78, 11, 46, 50, null, null },
                    { 829, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6920), true, false, 78, 11, 47, 50, null, null },
                    { 830, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6920), true, false, 78, 11, 48, 50, null, null },
                    { 831, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6920), true, false, 78, 11, 50, 50, null, null },
                    { 832, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6930), true, false, 78, 11, 51, 50, null, null },
                    { 833, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6930), true, false, 79, 8, 37, 50, null, null },
                    { 834, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6931), true, false, 79, 9, 40, 50, null, null },
                    { 835, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6931), true, false, 79, 10, 43, 50, null, null },
                    { 836, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6933), true, false, 79, 11, 46, 50, null, null },
                    { 837, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6933), true, false, 79, 11, 47, 50, null, null },
                    { 838, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6933), true, false, 79, 11, 48, 50, null, null },
                    { 839, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6934), true, false, 79, 11, 50, 50, null, null },
                    { 840, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6934), true, false, 79, 11, 51, 50, null, null },
                    { 841, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6935), true, false, 80, 8, 37, 50, null, null },
                    { 842, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6935), true, false, 80, 9, 40, 50, null, null },
                    { 843, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6936), true, false, 80, 10, 43, 50, null, null },
                    { 844, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6937), true, false, 80, 11, 46, 50, null, null },
                    { 845, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6937), true, false, 80, 11, 47, 50, null, null },
                    { 846, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6938), true, false, 80, 11, 48, 50, null, null },
                    { 847, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6938), true, false, 80, 11, 50, 50, null, null },
                    { 848, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6939), true, false, 80, 11, 51, 50, null, null },
                    { 849, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6939), true, false, 81, 8, 37, 50, null, null },
                    { 850, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6940), true, false, 81, 9, 40, 50, null, null },
                    { 851, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6940), true, false, 81, 10, 43, 50, null, null },
                    { 852, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6942), true, false, 81, 11, 46, 50, null, null },
                    { 853, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6942), true, false, 81, 11, 47, 50, null, null },
                    { 854, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6942), true, false, 81, 11, 48, 50, null, null },
                    { 855, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6943), true, false, 81, 11, 50, 50, null, null },
                    { 856, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6943), true, false, 81, 11, 51, 50, null, null },
                    { 857, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6944), true, false, 82, 8, 37, 50, null, null },
                    { 858, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6944), true, false, 82, 9, 40, 50, null, null },
                    { 859, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6945), true, false, 82, 10, 43, 50, null, null },
                    { 860, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6946), true, false, 82, 11, 46, 50, null, null },
                    { 861, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6947), true, false, 82, 11, 47, 50, null, null },
                    { 862, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6947), true, false, 82, 11, 48, 50, null, null },
                    { 863, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6948), true, false, 82, 11, 50, 50, null, null },
                    { 864, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6948), true, false, 82, 11, 51, 50, null, null },
                    { 865, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6949), true, false, 83, 8, 37, 50, null, null },
                    { 866, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6949), true, false, 83, 9, 40, 50, null, null },
                    { 867, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6950), true, false, 83, 10, 43, 50, null, null },
                    { 868, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6951), true, false, 83, 11, 46, 50, null, null },
                    { 869, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6951), true, false, 83, 11, 47, 50, null, null },
                    { 870, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6952), true, false, 83, 11, 48, 50, null, null },
                    { 871, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6952), true, false, 83, 11, 50, 50, null, null },
                    { 872, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6953), true, false, 83, 11, 51, 50, null, null },
                    { 873, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6953), true, false, 84, 8, 37, 50, null, null },
                    { 874, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6953), true, false, 84, 9, 40, 50, null, null },
                    { 875, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6954), true, false, 84, 10, 43, 50, null, null },
                    { 876, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6955), true, false, 84, 11, 46, 50, null, null },
                    { 877, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6955), true, false, 84, 11, 47, 50, null, null },
                    { 878, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6956), true, false, 84, 11, 48, 50, null, null },
                    { 879, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6956), true, false, 84, 11, 50, 50, null, null },
                    { 880, null, new DateTime(2025, 3, 29, 21, 4, 57, 959, DateTimeKind.Local).AddTicks(6957), true, false, 84, 11, 51, 50, null, null }
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

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserRoleId",
                table: "Users",
                column: "UserRoleId");
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
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
