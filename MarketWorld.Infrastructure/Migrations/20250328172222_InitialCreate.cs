using System;
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
                    { 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7588), false, "Apple", null, null, null },
                    { 2, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7591), false, "Asus", null, null, null },
                    { 3, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7593), false, "Casper", null, null, null },
                    { 4, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7594), false, "HP", null, null, null },
                    { 5, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7595), false, "Lenovo", null, null, null },
                    { 6, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7598), false, "MSI", null, null, null },
                    { 7, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7600), false, "Acer", null, null, null },
                    { 8, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7602), false, "Xiaomi", null, null, null },
                    { 9, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7603), false, "Samsung", null, null, null },
                    { 10, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7606), false, "Huawei", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7229), "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar", false, "Elektronik", "elektronik", null, null },
                    { 2, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7246), "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları", false, "Giyim & Aksesuar", "giyim-aksesuar", null, null },
                    { 3, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7248), "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili", false, "Ev & Yaşam", "ev-yasam", null, null },
                    { 4, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7250), "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri", false, "Kozmetik & Kişisel Bakım", "kozmetik-kisisel-bakim", null, null },
                    { 5, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7252), "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri", false, "Spor & Outdoor", "spor-outdoor", null, null }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsActive", "IsDeleted", "Name", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4010), "Ürün Renk Seçenekleri", true, false, "Renk", null, null },
                    { 2, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4021), "Beden Seçenekleri", true, false, "Beden", null, null },
                    { 3, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4023), "Dahili Hafıza", true, false, "Hafıza", null, null },
                    { 4, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4025), "Bilgisayar İşlemci Seçenekleri", true, false, "İşlemci", null, null },
                    { 5, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4026), "Bellek Kapasitesi", true, false, "RAM", null, null },
                    { 6, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4029), "SSD Kapasitesi", true, false, "SSD", null, null },
                    { 7, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4031), "Ekran Boyutu", true, false, "Ekran", null, null }
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
                    { 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4074), true, false, 1, null, null, "Uzay Siyahı" },
                    { 2, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4077), true, false, 1, null, null, "Altın" },
                    { 3, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4079), true, false, 1, null, null, "Gümüş" },
                    { 4, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4080), true, false, 1, null, null, "Mor" },
                    { 5, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4082), true, false, 2, null, null, "XS" },
                    { 6, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4085), true, false, 2, null, null, "S" },
                    { 7, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4086), true, false, 2, null, null, "M" },
                    { 8, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4088), true, false, 2, null, null, "L" },
                    { 9, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4090), true, false, 2, null, null, "XL" },
                    { 10, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4092), true, false, 2, null, null, "XXL" },
                    { 11, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4094), true, false, 3, null, null, "128GB" },
                    { 12, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4095), true, false, 3, null, null, "256GB" },
                    { 13, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4097), true, false, 3, null, null, "512GB" },
                    { 14, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4100), true, false, 3, null, null, "1TB" },
                    { 15, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4101), true, false, 4, null, null, "Intel Core i7 12700H" },
                    { 16, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4103), true, false, 4, null, null, "Intel Core i7 1255U" },
                    { 17, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4104), true, false, 4, null, null, "Intel Core i7 13620H" },
                    { 18, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4107), true, false, 4, null, null, "Intel Core i5 1334U" },
                    { 19, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4108), true, false, 4, null, null, "Intel Core i5 13420H" },
                    { 20, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4110), true, false, 4, null, null, "AMD Ryzen 7 5700U" },
                    { 21, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4111), true, false, 4, null, null, "Intel Core i5 12450H" },
                    { 22, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4113), true, false, 5, null, null, "8GB" },
                    { 23, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4114), true, false, 5, null, null, "16GB" },
                    { 24, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4116), true, false, 5, null, null, "32GB" },
                    { 25, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4155), true, false, 6, null, null, "256GB" },
                    { 26, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4157), true, false, 6, null, null, "500GB" },
                    { 27, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4159), true, false, 6, null, null, "512GB" },
                    { 28, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4161), true, false, 6, null, null, "1TB" },
                    { 29, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4162), true, false, 7, null, null, "14\"" },
                    { 30, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4164), true, false, 7, null, null, "15.6\"" },
                    { 31, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4165), true, false, 7, null, null, "16\"" },
                    { 32, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4167), true, false, 4, null, null, "Intel Core i7 13650HX" },
                    { 33, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4169), true, false, 4, null, null, "Intel Core i5 13500H" },
                    { 34, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4171), true, false, 4, null, null, "Intel Core i9-14900HX" },
                    { 35, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4173), true, false, 4, null, null, "Intel Core Ultra 7 255HX" },
                    { 36, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4174), true, false, 4, null, null, "AMD Ryzen 5 7520U" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedDate", "Description", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7458), "Dizüstü, masaüstü bilgisayarlar ve tabletler", false, "Bilgisayarlar & Tabletler", "bilgisayarlar-tabletler", null, null },
                    { 2, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7461), "Yazıcılar, tarayıcılar ve projeksiyon cihazları", false, "Yazıcılar & Projeksiyon", "yazicilar-projeksiyon", null, null },
                    { 3, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7463), "Akıllı telefonlar ve aksesuarları", false, "Telefonlar", "telefonlar", null, null },
                    { 4, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7465), "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar", false, "Beyaz Eşya", "beyaz-esya", null, null },
                    { 5, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7467), "Klimalar, ısıtıcılar ve hava temizleyiciler", false, "Klima ve Isıtıcılar", "klima-isitici", null, null },
                    { 6, 2, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7469), "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar", false, "Ayakkabı & Çanta", "ayakkabi-canta", null, null },
                    { 7, 2, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7471), "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim", false, "Kadın Giyim", "kadin-giyim", null, null },
                    { 8, 2, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7473), "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim", false, "Erkek Giyim", "erkek-giyim", null, null },
                    { 9, 2, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7475), "Kız ve erkek çocuk giyim ürünleri", false, "Çocuk Giyim", "cocuk-giyim", null, null },
                    { 10, 3, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7476), "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları", false, "Mobilya", "mobilya", null, null },
                    { 11, 3, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7478), "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri", false, "Ev Tekstili", "ev-tekstili", null, null },
                    { 12, 3, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7480), "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri", false, "Dekorasyon & Aydınlatma", "dekorasyon-aydinlatma", null, null },
                    { 13, 3, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7482), "Pişirme, servis ve saklama ürünleri, mutfak aletleri", false, "Mutfak Gereçleri", "mutfak-gerecleri", null, null },
                    { 14, 3, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7483), "Banyo aksesuarları, temizlik ve düzenleme ürünleri", false, "Banyo & Ev Gereçleri", "banyo-ev-gerecleri", null, null },
                    { 15, 3, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7485), "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri", false, "Kırtasiye & Ofis", "kirtasiye-ve-ofis", null, null },
                    { 16, 4, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7522), "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri", false, "Parfüm & Deodorant", "parfum-deodorant", null, null },
                    { 17, 4, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7524), "Saç bakım ve şekillendirme ürünleri", false, "Saç Şekillendirme", "sac-sekillendirme", null, null },
                    { 18, 4, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7526), "Yüz ve vücut bakım ürünleri, kremler ve serumlar", false, "Cilt Bakımı", "cilt-bakimi", null, null },
                    { 19, 4, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7528), "Renkli kozmetik ve makyaj malzemeleri", false, "Makyaj", "makyaj", null, null },
                    { 20, 4, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7529), "Vitamin, takviye gıdalar ve medikal ürünler", false, "Sağlık & Medikal Ürünler", "saglik-medikal-urunler", null, null },
                    { 21, 4, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7532), "Diş bakım ürünleri ve ağız bakım ürünleri", false, "Ağız & Diş Bakımı", "agiz-dis-bakimi", null, null },
                    { 22, 5, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7534), "Fitness ekipmanları, kondisyon aletleri ve aksesuarları", false, "Fitness & Kondisyon", "fitness-kondisyon", null, null },
                    { 23, 5, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7536), "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar", false, "Spor Giyim & Ayakkabı", "spor-giyim-ayakkabi", null, null },
                    { 24, 5, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7538), "Kamp malzemeleri, outdoor giyim ve ekipmanlar", false, "Outdoor & Kamp", "outdoor-kamp", null, null },
                    { 25, 5, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7539), "Kayak ekipmanları ve kış sporları malzemeleri", false, "Kış Sporları", "kis-sporlari", null, null },
                    { 26, 5, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7541), "Yüzme ve su sporları ekipmanları", false, "Su Sporları", "su-sporlari", null, null }
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
                    { 1, 1, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7655), "Apple iPhone 14 Pro 256 GB", 54999.99m, true, true, false, "iPhone 14 Pro", 56999.99m, 5m, 100, 3, null, null },
                    { 2, 9, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7660), "Samsung Galaxy S23 Ultra 256 GB", 65999.99m, true, true, false, "Samsung Galaxy S23 Ultra", 75999.99m, 5m, 150, 3, null, null },
                    { 3, 1, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7664), "Apple iPhone 15 128 GB Mavi", 39999.99m, true, true, false, "iPhone 15 128 GB", 49999.99m, 4m, 150, 3, null, null },
                    { 4, 8, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7668), "Xiaomi 13T Pro 512 GB", 37999.99m, true, true, false, "Xiaomi 13T Pro", 39999.99m, 3m, 75, 3, null, null },
                    { 5, 10, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7671), "Huawei P60 Pro 256 GB", 0m, false, true, false, "Huawei P60 Pro", 44999.99m, 4m, 60, 3, null, null },
                    { 6, 9, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7675), "Samsung Galaxy Z Fold5 512 GB", 84999.99m, true, true, false, "Samsung Galaxy Z Fold5", 89999.99m, 4.9m, 40, 3, null, null },
                    { 7, 1, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7679), "Apple iPhone 15 Pro Max 512 GB", 0m, false, true, false, "iPhone 15 Pro Max", 92999.99m, 3m, 25, 3, null, null },
                    { 8, 8, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7683), "Xiaomi Redmi Note 13 Pro+ 256 GB", 27999.99m, true, true, false, "Xiaomi Redmi Note 13 Pro+", 29999.99m, 4.2m, 200, 3, null, null },
                    { 9, 9, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7687), "Samsung Galaxy A54 128 GB", 18499.99m, true, true, false, "Samsung Galaxy A54", 19999.99m, 4.1m, 300, 3, null, null },
                    { 10, 10, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7692), "Huawei Nova 11 Pro 256 GB", 0m, false, true, false, "Huawei Nova 11 Pro", 34999.99m, 5m, 85, 3, null, null },
                    { 11, 1, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7695), "13inc Taşınabilir Bilgisayar Uzay Grisi MC7U4TU/A", 0m, false, true, false, "MacBook Air M2 16GB 256GB SSD", 41599.99m, 5m, 85, 1, null, null },
                    { 12, 3, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7698), "Intel Core i7 12700H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1270", 39999.99m, 4.5m, 100, 1, null, null },
                    { 13, 6, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7701), "Intel Core i7 1255U 16GB 512GB SSD Freedos 14\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "MSI Modern 14 C12MO", 21799.99m, 4.5m, 75, 1, null, null },
                    { 14, 3, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7704), "Core i7-13620H 32GB DDR5 RAM 1TB NVME SSD 16\" Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana S100", 27299.99m, 5m, 50, 1, null, null },
                    { 15, 3, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7733), "Intel Core i7 13620H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1362", 50199.99m, 4.5m, 60, 1, null, null },
                    { 16, 4, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7742), "Intel Core i5 1334U 16GB 512GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "HP 250 G10", 14999.99m, 4.7m, 100, 1, null, null },
                    { 17, 5, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7746), "Intel Core i5 13420H 16GB Ddr5 Ram 512 GB SSD 16'' WUXGA IPS Panel Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad Slim 3", 19799.99m, 4.9m, 80, 1, null, null },
                    { 18, 5, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7750), "AMD Ryzen 7 5700U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad 1", 15999.99m, 4.6m, 90, 1, null, null },
                    { 19, 6, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7754), "Intel Core i5 12450H 8GB 512GB SSD RTX2050 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "MSI Thin 15", 24799.99m, 4.5m, 70, 1, null, null },
                    { 20, 3, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7758), "Intel Core i7 1255U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana C550", 18999.99m, 4.5m, 85, 1, null, null },
                    { 21, 5, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7761), "Intel Core i7 13650HX 32GB 1TB SSD RTX 4060 8GB (115W) 15.6\" FHD 144Hz IPS Panel Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo LOQ 15IRX9", 59999.99m, 5m, 45, 1, null, null },
                    { 22, 3, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7765), "Intel Core i5-12450H 32GB RAM 500GB SSD GEN4 RTX3050 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G770", 31299.99m, 4.6m, 65, 1, null, null },
                    { 23, 3, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7769), "AMD Ryzen 5 7430U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana X600", 16999.99m, 5m, 80, 1, null, null },
                    { 24, 7, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7772), "Intel Core i7 1255U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Acer Aspire 3", 24000.00m, 5m, 70, 1, null, null },
                    { 25, 3, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7776), "Intel Core i7 12700H 32GB 1TB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana X600.1270", 22999.99m, 4.5m, 85, 1, null, null },
                    { 26, 3, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7779), "Intel Core i5-13420H 32GB RAM 500GB NVME SSD GEN4 6GB RTX4050 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G870.1342", 38499.99m, 4.1m, 55, 1, null, null },
                    { 27, 3, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7783), "Intel Core i7 12700H 32GB 1TB SSD RTX4070 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1270", 50899.99m, 4m, 40, 1, null, null },
                    { 28, 4, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7786), "Intel Core i5 13500H 16GB 512GB SSD RTX4050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "HP Victus Gaming 15", 33999.99m, 4.6m, 90, 1, null, null },
                    { 29, 5, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7790), "Intel Core i5 12450H 8GB 512GB SSD 15.6\" FHD Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo IdeaPad Slim 3", 15359.04m, 4.7m, 100, 1, null, null },
                    { 30, 2, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7793), "Intel Core i5 12500H 8GB 512GB SSD RTX3050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Asus TUF Gaming F15", 29898.66m, 4.7m, 75, 1, null, null },
                    { 31, 1, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7796), "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Uzay Grisi", 0m, false, true, false, "Apple MacBook Air M1", 39250.00m, 4.9m, 60, 1, null, null },
                    { 32, 3, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7799), "Intel Core i5-13420H 16GB RAM 1TB NVME SSD 8GB RTX4060 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G870.1342", 42299.99m, 4.3m, 50, 1, null, null },
                    { 33, 5, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7802), "Intel Core i5 13420H 16GB 512GB SSD Freedos 14\" WUXGA Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad 5", 29999.99m, 5m, 70, 1, null, null },
                    { 34, 2, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7807), "Intel Core Ultra 7 255HX 32GB 1TB SSD RTX5070Ti Freedos 16\" Taşınabilir Bilgisayar", 0m, false, true, false, "Asus ROG Strix G16", 107999.99m, 5m, 25, 1, null, null },
                    { 35, 3, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7810), "Intel Core i5-13420H 32GB RAM 500GB NVME SSD Freedos", 0m, false, true, false, "Casper Nirvana X600.1342", 19999.99m, 5m, 85, 1, null, null },
                    { 36, 5, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7813), "Intel Core i9-14900HX 32GB DDR5 1TB SSD RTX4060 8GB 16 inç 3.2K (3200×2000) 165Hz FreeDos Laptop", 0m, false, true, false, "Lenovo Thinkbook 16PG5", 79999.40m, 4.7m, 30, 1, null, null },
                    { 37, 3, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7817), "Intel Core i7-13620H 16GB RAM 500GB NVME SSD Freedos Laptop", 0m, false, true, false, "Casper Nirvana X600.1362", 22099.99m, 5m, 75, 1, null, null },
                    { 38, 6, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7820), "Intel Core i5 13420H 16GB 1TB SSD RTX4060 Freedos 15.6\" FHD 144Hz Taşınabilir Bilgisayar", 0m, false, true, false, "MSI CYBORG 15", 37999.99m, 4.9m, 60, 1, null, null },
                    { 39, 5, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7823), "AMD Ryzen 5 7520U 8gb 512GB SSD Freedos 15.6\" Fhd Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo V15 G4", 13299.99m, 4.3m, 95, 1, null, null },
                    { 40, 5, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7826), "I5-13420H 32GB 1 Tb SSD 15.6 Fhd Windows 11 Pro", 0m, false, true, false, "Lenovo V15 G4", 27749.00m, 5m, 70, 1, null, null },
                    { 41, 1, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7829), "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Gece Yarısı", 0m, false, true, false, "Apple MacBook Air M4", 49999.99m, 5m, 45, 1, null, null },
                    { 42, 3, 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7832), "Intel Core i5 12450H 16GB 500GB SSD RTX2050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1245", 27499.99m, 4.4m, 80, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "EntityId", "EntityType", "IsDeleted", "Path", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7947), 1, 1, false, "img/ProductsPicture/Telephones/TelephoneOne/resimbir.jpg", null, null },
                    { 2, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7950), 1, 1, false, "img/ProductsPicture/Telephones/TelephoneOne/resimiki.jpg", null, null },
                    { 3, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7952), 1, 1, false, "img/ProductsPicture/Telephones/TelephoneOne/resimuc.jpg", null, null },
                    { 4, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7954), 1, 1, false, "img/ProductsPicture/Telephones/TelephoneOne/resimdort.jpg", null, null },
                    { 5, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7955), 2, 1, false, "img/ProductsPicture/Telephones/TelephoneTwo/resimbir.jpg", null, null },
                    { 6, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7958), 2, 1, false, "img/ProductsPicture/Telephones/TelephoneTwo/resimiki.jpg", null, null },
                    { 7, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7959), 2, 1, false, "img/ProductsPicture/Telephones/TelephoneTwo/resimuc.jpg", null, null },
                    { 8, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7961), 2, 1, false, "img/ProductsPicture/Telephones/TelephoneTwo/resimdort.jpg", null, null },
                    { 9, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7963), 3, 1, false, "img/ProductsPicture/Telephones/TelephoneThree/resimbir.jpg", null, null },
                    { 10, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7965), 3, 1, false, "img/ProductsPicture/Telephones/TelephoneThree/resimiki.jpg", null, null },
                    { 11, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7967), 3, 1, false, "img/ProductsPicture/Telephones/TelephoneThree/resimuc.jpg", null, null },
                    { 12, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7969), 3, 1, false, "img/ProductsPicture/Telephones/TelephoneThree/resimdort.jpg", null, null },
                    { 13, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7971), 4, 1, false, "img/ProductsPicture/Telephones/TelephoneFour/resimbir.jpg", null, null },
                    { 14, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7974), 4, 1, false, "img/ProductsPicture/Telephones/TelephoneFour/resimiki.jpg", null, null },
                    { 15, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7976), 4, 1, false, "img/ProductsPicture/Telephones/TelephoneFour/resimuc.jpg", null, null },
                    { 16, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7978), 4, 1, false, "img/ProductsPicture/Telephones/TelephoneFour/resimdort.jpg", null, null },
                    { 17, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7980), 5, 1, false, "img/ProductsPicture/Telephones/TelephoneFive/resimbir.jpg", null, null },
                    { 18, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7982), 5, 1, false, "img/ProductsPicture/Telephones/TelephoneFive/resimiki.jpg", null, null },
                    { 19, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7984), 5, 1, false, "img/ProductsPicture/Telephones/TelephoneFive/resimuc.jpg", null, null },
                    { 20, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7985), 5, 1, false, "img/ProductsPicture/Telephones/TelephoneFive/resimdort.jpg", null, null },
                    { 21, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7988), 6, 1, false, "img/ProductsPicture/Telephones/TelephoneSix/resimbir.jpg", null, null },
                    { 22, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7990), 6, 1, false, "img/ProductsPicture/Telephones/TelephoneSix/resimiki.jpg", null, null },
                    { 23, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7991), 6, 1, false, "img/ProductsPicture/Telephones/TelephoneSix/resimuc.jpg", null, null },
                    { 24, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7994), 6, 1, false, "img/ProductsPicture/Telephones/TelephoneSix/resimdort.jpg", null, null },
                    { 25, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7995), 7, 1, false, "img/ProductsPicture/Telephones/TelephoneSeven/resimbir.jpg", null, null },
                    { 26, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(7997), 7, 1, false, "img/ProductsPicture/Telephones/TelephoneSeven/resimiki.jpg", null, null },
                    { 27, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8000), 7, 1, false, "img/ProductsPicture/Telephones/TelephoneSeven/resimuc.jpg", null, null },
                    { 28, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8001), 7, 1, false, "img/ProductsPicture/Telephones/TelephoneSeven/resimdort.jpg", null, null },
                    { 29, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8003), 8, 1, false, "img/ProductsPicture/Telephones/TelephoneEight/resimbir.jpg", null, null },
                    { 30, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8005), 8, 1, false, "img/ProductsPicture/Telephones/TelephoneEight/resimiki.jpg", null, null },
                    { 31, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8006), 8, 1, false, "img/ProductsPicture/Telephones/TelephoneEight/resimuc.jpg", null, null },
                    { 32, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8008), 8, 1, false, "img/ProductsPicture/Telephones/TelephoneEight/resimdort.jpg", null, null },
                    { 33, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8009), 9, 1, false, "img/ProductsPicture/Telephones/TelephoneNine/resimbir.jpg", null, null },
                    { 34, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8012), 9, 1, false, "img/ProductsPicture/Telephones/TelephoneNine/resimiki.jpg", null, null },
                    { 35, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8013), 9, 1, false, "img/ProductsPicture/Telephones/TelephoneNine/resimuc.jpg", null, null },
                    { 36, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8015), 9, 1, false, "img/ProductsPicture/Telephones/TelephoneNine/resimdort.jpg", null, null },
                    { 37, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8017), 10, 1, false, "img/ProductsPicture/Telephones/TelephoneTen/resimbir.jpg", null, null },
                    { 38, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8018), 10, 1, false, "img/ProductsPicture/Telephones/TelephoneTen/resimiki.jpg", null, null },
                    { 39, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8020), 10, 1, false, "img/ProductsPicture/Telephones/TelephoneTen/resimuc.jpg", null, null },
                    { 40, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8021), 10, 1, false, "img/ProductsPicture/Telephones/TelephoneTen/resimdort.jpg", null, null },
                    { 41, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8023), 11, 1, false, "img/ProductsPicture/Pc/PcOne/resimbir.jpg", null, null },
                    { 42, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8025), 11, 1, false, "img/ProductsPicture/Pc/PcOne/resimiki.jpg", null, null },
                    { 43, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8026), 11, 1, false, "img/ProductsPicture/Pc/PcOne/resimuc.jpg", null, null },
                    { 44, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8028), 11, 1, false, "img/ProductsPicture/Pc/PcOne/resimdort.jpg", null, null },
                    { 45, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8029), 12, 1, false, "img/Products/Laptops/Casper_G870.1270.jpg", null, null },
                    { 46, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8031), 13, 1, false, "img/Products/Laptops/MSI_15.6.jpg", null, null },
                    { 47, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8033), 14, 1, false, "img/Products/Laptops/Casper_S100.1362.jpg", null, null },
                    { 48, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8035), 15, 1, false, "img/Products/Laptops/Casper_G870.1362.jpg", null, null },
                    { 49, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8037), 16, 1, false, "img/Products/Laptops/HP_15.6.jpg", null, null },
                    { 50, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8038), 17, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 51, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8040), 18, 1, false, "img/Products/Laptops/Lenovo_model.jpg", null, null },
                    { 52, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8042), 19, 1, false, "img/Products/Laptops/MSI_model.jpg", null, null },
                    { 53, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8043), 20, 1, false, "img/Products/Laptops/Casper_C550.1255.jpg", null, null },
                    { 54, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8045), 21, 1, false, "img/Products/Laptops/Lenovo_3.2.jpg", null, null },
                    { 55, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8046), 22, 1, false, "img/Products/Laptops/Casper_G770.1245.jpg", null, null },
                    { 56, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8048), 23, 1, false, "img/Products/Laptops/Casper_X600.7430.jpg", null, null },
                    { 57, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8050), 24, 1, false, "img/Products/Laptops/Acer_15.6.jpg", null, null },
                    { 58, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8051), 25, 1, false, "img/Products/Laptops/Casper_X600.1270.jpg", null, null },
                    { 59, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8059), 26, 1, false, "img/Products/Laptops/Casper_G870.1342.jpg", null, null },
                    { 60, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8061), 27, 1, false, "img/Products/Laptops/Casper_G870.1270.jpg", null, null },
                    { 61, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8109), 28, 1, false, "img/Products/Laptops/HP_15.6.jpg", null, null },
                    { 62, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8111), 29, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 63, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8112), 30, 1, false, "img/Products/Laptops/Asus_15.6.jpg", null, null },
                    { 64, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8114), 31, 1, false, "img/Products/Laptops/Apple_model.jpg", null, null },
                    { 65, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8116), 32, 1, false, "img/Products/Laptops/Casper_G870.1342.jpg", null, null },
                    { 66, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8118), 33, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 67, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8120), 34, 1, false, "img/Products/Laptops/Asus_model.jpg", null, null },
                    { 68, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8122), 35, 1, false, "img/Products/Laptops/Casper_X600.1342.jpg", null, null },
                    { 69, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8123), 36, 1, false, "img/Products/Laptops/Lenovo_3.2.jpg", null, null },
                    { 70, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8125), 37, 1, false, "img/Products/Laptops/Casper_X600.1362.jpg", null, null },
                    { 71, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8127), 38, 1, false, "img/Products/Laptops/MSI_15.6.jpg", null, null },
                    { 72, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8128), 39, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 73, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8130), 40, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 74, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8132), 41, 1, false, "img/Products/Laptops/Apple_model.jpg", null, null },
                    { 75, null, new DateTime(2025, 3, 28, 20, 22, 21, 323, DateTimeKind.Local).AddTicks(8133), 42, 1, false, "img/Products/Laptops/Casper_G870.1245.jpg", null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductProperties",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "ProductId", "PropertyTypeId", "PropertyValueId", "Stock", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 81, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4225), true, false, 1, 1, 1, 50, null, null },
                    { 82, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4229), true, false, 1, 1, 2, 50, null, null },
                    { 83, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4230), true, false, 1, 1, 3, 50, null, null },
                    { 84, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4231), true, false, 1, 1, 4, 50, null, null },
                    { 85, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4233), true, false, 1, 3, 11, 75, null, null },
                    { 86, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4236), true, false, 1, 3, 12, 75, null, null },
                    { 87, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4237), true, false, 1, 3, 13, 75, null, null },
                    { 88, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4237), true, false, 1, 3, 14, 75, null, null },
                    { 89, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4238), true, false, 2, 1, 1, 50, null, null },
                    { 90, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4240), true, false, 2, 1, 2, 50, null, null },
                    { 91, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4241), true, false, 2, 1, 3, 50, null, null },
                    { 92, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4241), true, false, 2, 1, 4, 50, null, null },
                    { 93, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4242), true, false, 2, 3, 11, 75, null, null },
                    { 94, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4243), true, false, 2, 3, 12, 75, null, null },
                    { 95, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4243), true, false, 2, 3, 13, 75, null, null },
                    { 96, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4244), true, false, 2, 3, 14, 75, null, null },
                    { 97, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4245), true, false, 3, 1, 1, 50, null, null },
                    { 98, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4247), true, false, 3, 1, 2, 50, null, null },
                    { 99, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4247), true, false, 3, 1, 3, 50, null, null },
                    { 100, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4248), true, false, 3, 1, 4, 50, null, null },
                    { 101, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4249), true, false, 3, 3, 11, 75, null, null },
                    { 102, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4249), true, false, 3, 3, 12, 75, null, null },
                    { 103, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4250), true, false, 3, 3, 13, 75, null, null },
                    { 104, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4251), true, false, 3, 3, 14, 75, null, null },
                    { 105, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4251), true, false, 4, 1, 1, 50, null, null },
                    { 106, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4252), true, false, 4, 1, 2, 50, null, null },
                    { 107, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4253), true, false, 4, 1, 3, 50, null, null },
                    { 108, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4253), true, false, 4, 1, 4, 50, null, null },
                    { 109, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4254), true, false, 4, 3, 11, 75, null, null },
                    { 110, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4255), true, false, 4, 3, 12, 75, null, null },
                    { 111, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4256), true, false, 4, 3, 13, 75, null, null },
                    { 112, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4256), true, false, 4, 3, 14, 75, null, null },
                    { 113, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4292), true, false, 5, 1, 1, 50, null, null },
                    { 114, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4293), true, false, 5, 1, 2, 50, null, null },
                    { 115, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4295), true, false, 5, 1, 3, 50, null, null },
                    { 116, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4295), true, false, 5, 1, 4, 50, null, null },
                    { 117, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4296), true, false, 5, 3, 11, 75, null, null },
                    { 118, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4297), true, false, 5, 3, 12, 75, null, null },
                    { 119, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4297), true, false, 5, 3, 13, 75, null, null },
                    { 120, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4298), true, false, 5, 3, 14, 75, null, null },
                    { 121, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4299), true, false, 6, 1, 1, 50, null, null },
                    { 122, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4300), true, false, 6, 1, 2, 50, null, null },
                    { 123, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4300), true, false, 6, 1, 3, 50, null, null },
                    { 124, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4301), true, false, 6, 1, 4, 50, null, null },
                    { 125, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4302), true, false, 6, 3, 11, 75, null, null },
                    { 126, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4302), true, false, 6, 3, 12, 75, null, null },
                    { 127, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4303), true, false, 6, 3, 13, 75, null, null },
                    { 128, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4304), true, false, 6, 3, 14, 75, null, null },
                    { 129, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4304), true, false, 7, 1, 1, 50, null, null },
                    { 130, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4305), true, false, 7, 1, 2, 50, null, null },
                    { 131, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4306), true, false, 7, 1, 3, 50, null, null },
                    { 132, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4306), true, false, 7, 1, 4, 50, null, null },
                    { 133, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4307), true, false, 7, 3, 11, 75, null, null },
                    { 134, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4308), true, false, 7, 3, 12, 75, null, null },
                    { 135, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4308), true, false, 7, 3, 13, 75, null, null },
                    { 136, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4309), true, false, 7, 3, 14, 75, null, null },
                    { 137, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4310), true, false, 8, 1, 1, 50, null, null },
                    { 138, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4310), true, false, 8, 1, 2, 50, null, null },
                    { 139, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4311), true, false, 8, 1, 3, 50, null, null },
                    { 140, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4312), true, false, 8, 1, 4, 50, null, null },
                    { 141, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4313), true, false, 8, 3, 11, 75, null, null },
                    { 142, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4313), true, false, 8, 3, 12, 75, null, null },
                    { 143, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4314), true, false, 8, 3, 13, 75, null, null },
                    { 144, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4315), true, false, 8, 3, 14, 75, null, null },
                    { 145, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4315), true, false, 9, 1, 1, 50, null, null },
                    { 146, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4317), true, false, 9, 1, 2, 50, null, null },
                    { 147, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4317), true, false, 9, 1, 3, 50, null, null },
                    { 148, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4318), true, false, 9, 1, 4, 50, null, null },
                    { 149, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4319), true, false, 9, 3, 11, 75, null, null },
                    { 150, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4319), true, false, 9, 3, 12, 75, null, null },
                    { 151, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4320), true, false, 9, 3, 13, 75, null, null },
                    { 152, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4321), true, false, 9, 3, 14, 75, null, null },
                    { 153, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4321), true, false, 10, 1, 1, 50, null, null },
                    { 154, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4322), true, false, 10, 1, 2, 50, null, null },
                    { 155, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4323), true, false, 10, 1, 3, 50, null, null },
                    { 156, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4323), true, false, 10, 1, 4, 50, null, null },
                    { 157, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4324), true, false, 10, 3, 11, 75, null, null },
                    { 158, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4325), true, false, 10, 3, 12, 75, null, null },
                    { 159, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4325), true, false, 10, 3, 13, 75, null, null },
                    { 160, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4326), true, false, 10, 3, 14, 75, null, null },
                    { 161, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4363), true, false, 11, 1, 1, 50, null, null },
                    { 162, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4365), true, false, 11, 1, 2, 50, null, null },
                    { 163, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4366), true, false, 11, 1, 3, 50, null, null },
                    { 164, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4366), true, false, 11, 1, 4, 50, null, null },
                    { 165, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4368), true, false, 11, 3, 11, 75, null, null },
                    { 166, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4370), true, false, 11, 3, 12, 75, null, null },
                    { 167, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4370), true, false, 11, 3, 13, 75, null, null },
                    { 168, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4371), true, false, 11, 3, 14, 75, null, null },
                    { 169, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4373), true, false, 11, 4, 15, 50, null, null },
                    { 170, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4376), true, false, 11, 5, 23, 50, null, null },
                    { 171, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4378), true, false, 11, 6, 27, 50, null, null },
                    { 172, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4381), true, false, 11, 7, 30, 50, null, null },
                    { 173, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4382), true, false, 12, 1, 1, 50, null, null },
                    { 174, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4383), true, false, 12, 1, 2, 50, null, null },
                    { 175, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4384), true, false, 12, 1, 3, 50, null, null },
                    { 176, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4385), true, false, 12, 1, 4, 50, null, null },
                    { 177, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4385), true, false, 12, 3, 11, 75, null, null },
                    { 178, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4386), true, false, 12, 3, 12, 75, null, null },
                    { 179, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4387), true, false, 12, 3, 13, 75, null, null },
                    { 180, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4387), true, false, 12, 3, 14, 75, null, null },
                    { 181, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4389), true, false, 12, 4, 15, 50, null, null },
                    { 182, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4390), true, false, 12, 5, 24, 50, null, null },
                    { 183, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4391), true, false, 12, 6, 28, 50, null, null },
                    { 184, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4392), true, false, 12, 7, 30, 50, null, null },
                    { 185, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4392), true, false, 13, 1, 1, 50, null, null },
                    { 186, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4393), true, false, 13, 1, 2, 50, null, null },
                    { 187, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4394), true, false, 13, 1, 3, 50, null, null },
                    { 188, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4394), true, false, 13, 1, 4, 50, null, null },
                    { 189, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4395), true, false, 13, 3, 11, 75, null, null },
                    { 190, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4396), true, false, 13, 3, 12, 75, null, null },
                    { 191, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4396), true, false, 13, 3, 13, 75, null, null },
                    { 192, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4397), true, false, 13, 3, 14, 75, null, null },
                    { 193, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4398), true, false, 13, 4, 16, 50, null, null },
                    { 194, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4399), true, false, 13, 5, 23, 50, null, null },
                    { 195, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4400), true, false, 13, 6, 27, 50, null, null },
                    { 196, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4401), true, false, 13, 7, 29, 50, null, null },
                    { 197, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4402), true, false, 14, 1, 1, 50, null, null },
                    { 198, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4402), true, false, 14, 1, 2, 50, null, null },
                    { 199, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4403), true, false, 14, 1, 3, 50, null, null },
                    { 200, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4404), true, false, 14, 1, 4, 50, null, null },
                    { 201, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4404), true, false, 14, 3, 11, 75, null, null },
                    { 202, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4405), true, false, 14, 3, 12, 75, null, null },
                    { 203, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4406), true, false, 14, 3, 13, 75, null, null },
                    { 204, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4406), true, false, 14, 3, 14, 75, null, null },
                    { 205, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4407), true, false, 14, 4, 17, 50, null, null },
                    { 206, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4408), true, false, 14, 5, 24, 50, null, null },
                    { 207, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4409), true, false, 14, 6, 28, 50, null, null },
                    { 208, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4410), true, false, 14, 7, 31, 50, null, null },
                    { 209, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4410), true, false, 15, 1, 1, 50, null, null },
                    { 210, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4443), true, false, 15, 1, 2, 50, null, null },
                    { 211, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4444), true, false, 15, 1, 3, 50, null, null },
                    { 212, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4444), true, false, 15, 1, 4, 50, null, null },
                    { 213, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4445), true, false, 15, 3, 11, 75, null, null },
                    { 214, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4446), true, false, 15, 3, 12, 75, null, null },
                    { 215, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4447), true, false, 15, 3, 13, 75, null, null },
                    { 216, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4448), true, false, 15, 3, 14, 75, null, null },
                    { 217, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4449), true, false, 15, 4, 17, 50, null, null },
                    { 218, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4450), true, false, 15, 5, 24, 50, null, null },
                    { 219, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4451), true, false, 15, 6, 28, 50, null, null },
                    { 220, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4452), true, false, 15, 7, 30, 50, null, null },
                    { 221, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4452), true, false, 16, 1, 1, 50, null, null },
                    { 222, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4453), true, false, 16, 1, 2, 50, null, null },
                    { 223, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4453), true, false, 16, 1, 3, 50, null, null },
                    { 224, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4454), true, false, 16, 1, 4, 50, null, null },
                    { 225, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4455), true, false, 16, 3, 11, 75, null, null },
                    { 226, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4455), true, false, 16, 3, 12, 75, null, null },
                    { 227, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4456), true, false, 16, 3, 13, 75, null, null },
                    { 228, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4457), true, false, 16, 3, 14, 75, null, null },
                    { 229, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4458), true, false, 16, 4, 18, 50, null, null },
                    { 230, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4459), true, false, 16, 5, 23, 50, null, null },
                    { 231, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4459), true, false, 16, 6, 27, 50, null, null },
                    { 232, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4460), true, false, 16, 7, 30, 50, null, null },
                    { 233, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4461), true, false, 17, 1, 1, 50, null, null },
                    { 234, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4461), true, false, 17, 1, 2, 50, null, null },
                    { 235, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4462), true, false, 17, 1, 3, 50, null, null },
                    { 236, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4463), true, false, 17, 1, 4, 50, null, null },
                    { 237, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4463), true, false, 17, 3, 11, 75, null, null },
                    { 238, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4464), true, false, 17, 3, 12, 75, null, null },
                    { 239, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4465), true, false, 17, 3, 13, 75, null, null },
                    { 240, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4465), true, false, 17, 3, 14, 75, null, null },
                    { 241, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4466), true, false, 17, 4, 19, 50, null, null },
                    { 242, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4467), true, false, 17, 5, 23, 50, null, null },
                    { 243, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4468), true, false, 17, 6, 27, 50, null, null },
                    { 244, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4469), true, false, 17, 7, 31, 50, null, null },
                    { 245, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4469), true, false, 18, 1, 1, 50, null, null },
                    { 246, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4470), true, false, 18, 1, 2, 50, null, null },
                    { 247, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4471), true, false, 18, 1, 3, 50, null, null },
                    { 248, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4471), true, false, 18, 1, 4, 50, null, null },
                    { 249, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4472), true, false, 18, 3, 11, 75, null, null },
                    { 250, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4473), true, false, 18, 3, 12, 75, null, null },
                    { 251, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4473), true, false, 18, 3, 13, 75, null, null },
                    { 252, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4474), true, false, 18, 3, 14, 75, null, null },
                    { 253, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4475), true, false, 18, 4, 20, 50, null, null },
                    { 254, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4476), true, false, 18, 5, 23, 50, null, null },
                    { 255, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4477), true, false, 18, 6, 27, 50, null, null },
                    { 256, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4478), true, false, 18, 7, 30, 50, null, null },
                    { 257, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4479), true, false, 19, 1, 1, 50, null, null },
                    { 258, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4479), true, false, 19, 1, 2, 50, null, null },
                    { 259, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4480), true, false, 19, 1, 3, 50, null, null },
                    { 260, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4481), true, false, 19, 1, 4, 50, null, null },
                    { 261, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4481), true, false, 19, 3, 11, 75, null, null },
                    { 262, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4482), true, false, 19, 3, 12, 75, null, null },
                    { 263, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4483), true, false, 19, 3, 13, 75, null, null },
                    { 264, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4483), true, false, 19, 3, 14, 75, null, null },
                    { 265, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4484), true, false, 19, 4, 21, 50, null, null },
                    { 266, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4485), true, false, 19, 5, 22, 50, null, null },
                    { 267, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4506), true, false, 19, 6, 27, 50, null, null },
                    { 268, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4507), true, false, 19, 7, 30, 50, null, null },
                    { 269, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4508), true, false, 20, 1, 1, 50, null, null },
                    { 270, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4509), true, false, 20, 1, 2, 50, null, null },
                    { 271, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4510), true, false, 20, 1, 3, 50, null, null },
                    { 272, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4510), true, false, 20, 1, 4, 50, null, null },
                    { 273, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4511), true, false, 20, 3, 11, 75, null, null },
                    { 274, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4512), true, false, 20, 3, 12, 75, null, null },
                    { 275, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4513), true, false, 20, 3, 13, 75, null, null },
                    { 276, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4514), true, false, 20, 3, 14, 75, null, null },
                    { 277, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4515), true, false, 20, 4, 16, 50, null, null },
                    { 278, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4516), true, false, 20, 5, 23, 50, null, null },
                    { 279, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4517), true, false, 20, 6, 26, 50, null, null },
                    { 280, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4518), true, false, 20, 7, 30, 50, null, null },
                    { 281, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4519), true, false, 21, 1, 1, 50, null, null },
                    { 282, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4520), true, false, 21, 1, 2, 50, null, null },
                    { 283, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4520), true, false, 21, 1, 3, 50, null, null },
                    { 284, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4521), true, false, 21, 1, 4, 50, null, null },
                    { 285, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4522), true, false, 21, 3, 11, 75, null, null },
                    { 286, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4523), true, false, 21, 3, 12, 75, null, null },
                    { 287, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4524), true, false, 21, 3, 13, 75, null, null },
                    { 288, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4524), true, false, 21, 3, 14, 75, null, null },
                    { 289, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4526), true, false, 21, 4, 32, 50, null, null },
                    { 290, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4527), true, false, 21, 5, 24, 50, null, null },
                    { 291, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4527), true, false, 21, 6, 28, 50, null, null },
                    { 292, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4528), true, false, 21, 7, 30, 50, null, null },
                    { 293, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4529), true, false, 22, 1, 1, 50, null, null },
                    { 294, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4530), true, false, 22, 1, 2, 50, null, null },
                    { 295, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4530), true, false, 22, 1, 3, 50, null, null },
                    { 296, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4531), true, false, 22, 1, 4, 50, null, null },
                    { 297, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4532), true, false, 22, 3, 11, 75, null, null },
                    { 298, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4533), true, false, 22, 3, 12, 75, null, null },
                    { 299, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4533), true, false, 22, 3, 13, 75, null, null },
                    { 300, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4534), true, false, 22, 3, 14, 75, null, null },
                    { 301, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4535), true, false, 22, 4, 21, 50, null, null },
                    { 302, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4536), true, false, 22, 5, 24, 50, null, null },
                    { 303, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4537), true, false, 22, 6, 26, 50, null, null },
                    { 304, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4538), true, false, 22, 7, 30, 50, null, null },
                    { 305, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4538), true, false, 23, 1, 1, 50, null, null },
                    { 306, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4539), true, false, 23, 1, 2, 50, null, null },
                    { 307, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4540), true, false, 23, 1, 3, 50, null, null },
                    { 308, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4540), true, false, 23, 1, 4, 50, null, null },
                    { 309, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4541), true, false, 23, 3, 11, 75, null, null },
                    { 310, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4542), true, false, 23, 3, 12, 75, null, null },
                    { 311, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4542), true, false, 23, 3, 13, 75, null, null },
                    { 312, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4543), true, false, 23, 3, 14, 75, null, null },
                    { 313, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4544), true, false, 23, 4, 36, 50, null, null },
                    { 314, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4545), true, false, 23, 5, 23, 50, null, null },
                    { 315, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4546), true, false, 23, 6, 26, 50, null, null },
                    { 316, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4547), true, false, 23, 7, 30, 50, null, null },
                    { 317, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4548), true, false, 24, 1, 1, 50, null, null },
                    { 318, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4548), true, false, 24, 1, 2, 50, null, null },
                    { 319, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4549), true, false, 24, 1, 3, 50, null, null },
                    { 320, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4550), true, false, 24, 1, 4, 50, null, null },
                    { 321, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4550), true, false, 24, 3, 11, 75, null, null },
                    { 322, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4551), true, false, 24, 3, 12, 75, null, null },
                    { 323, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4552), true, false, 24, 3, 13, 75, null, null },
                    { 324, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4552), true, false, 24, 3, 14, 75, null, null },
                    { 325, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4597), true, false, 24, 4, 16, 50, null, null },
                    { 326, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4598), true, false, 24, 5, 23, 50, null, null },
                    { 327, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4599), true, false, 24, 6, 27, 50, null, null },
                    { 328, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4600), true, false, 24, 7, 30, 50, null, null },
                    { 329, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4601), true, false, 25, 1, 1, 50, null, null },
                    { 330, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4601), true, false, 25, 1, 2, 50, null, null },
                    { 331, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4602), true, false, 25, 1, 3, 50, null, null },
                    { 332, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4603), true, false, 25, 1, 4, 50, null, null },
                    { 333, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4604), true, false, 25, 3, 11, 75, null, null },
                    { 334, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4604), true, false, 25, 3, 12, 75, null, null },
                    { 335, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4605), true, false, 25, 3, 13, 75, null, null },
                    { 336, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4606), true, false, 25, 3, 14, 75, null, null },
                    { 337, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4607), true, false, 25, 4, 15, 50, null, null },
                    { 338, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4610), true, false, 25, 5, 24, 50, null, null },
                    { 339, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4611), true, false, 25, 6, 28, 50, null, null },
                    { 340, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4612), true, false, 25, 7, 30, 50, null, null },
                    { 341, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4613), true, false, 26, 1, 1, 50, null, null },
                    { 342, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4614), true, false, 26, 1, 2, 50, null, null },
                    { 343, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4614), true, false, 26, 1, 3, 50, null, null },
                    { 344, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4615), true, false, 26, 1, 4, 50, null, null },
                    { 345, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4616), true, false, 26, 3, 11, 75, null, null },
                    { 346, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4617), true, false, 26, 3, 12, 75, null, null },
                    { 347, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4617), true, false, 26, 3, 13, 75, null, null },
                    { 348, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4618), true, false, 26, 3, 14, 75, null, null },
                    { 349, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4619), true, false, 26, 4, 19, 50, null, null },
                    { 350, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4620), true, false, 26, 5, 24, 50, null, null },
                    { 351, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4621), true, false, 26, 6, 26, 50, null, null },
                    { 352, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4622), true, false, 26, 7, 30, 50, null, null },
                    { 353, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4622), true, false, 27, 1, 1, 50, null, null },
                    { 354, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4623), true, false, 27, 1, 2, 50, null, null },
                    { 355, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4667), true, false, 27, 1, 3, 50, null, null },
                    { 356, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4667), true, false, 27, 1, 4, 50, null, null },
                    { 357, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4668), true, false, 27, 3, 11, 75, null, null },
                    { 358, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4669), true, false, 27, 3, 12, 75, null, null },
                    { 359, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4669), true, false, 27, 3, 13, 75, null, null },
                    { 360, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4670), true, false, 27, 3, 14, 75, null, null },
                    { 361, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4671), true, false, 27, 4, 15, 50, null, null },
                    { 362, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4672), true, false, 27, 5, 24, 50, null, null },
                    { 363, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4673), true, false, 27, 6, 28, 50, null, null },
                    { 364, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4674), true, false, 27, 7, 30, 50, null, null },
                    { 365, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4674), true, false, 28, 1, 1, 50, null, null },
                    { 366, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4675), true, false, 28, 1, 2, 50, null, null },
                    { 367, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4676), true, false, 28, 1, 3, 50, null, null },
                    { 368, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4677), true, false, 28, 1, 4, 50, null, null },
                    { 369, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4677), true, false, 28, 3, 11, 75, null, null },
                    { 370, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4678), true, false, 28, 3, 12, 75, null, null },
                    { 371, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4679), true, false, 28, 3, 13, 75, null, null },
                    { 372, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4679), true, false, 28, 3, 14, 75, null, null },
                    { 373, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4680), true, false, 28, 4, 33, 50, null, null },
                    { 374, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4681), true, false, 28, 5, 23, 50, null, null },
                    { 375, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4682), true, false, 28, 6, 27, 50, null, null },
                    { 376, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4683), true, false, 28, 7, 30, 50, null, null },
                    { 377, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4684), true, false, 29, 1, 1, 50, null, null },
                    { 378, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4684), true, false, 29, 1, 2, 50, null, null },
                    { 379, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4685), true, false, 29, 1, 3, 50, null, null },
                    { 380, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4685), true, false, 29, 1, 4, 50, null, null },
                    { 381, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4686), true, false, 29, 3, 11, 75, null, null },
                    { 382, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4687), true, false, 29, 3, 12, 75, null, null },
                    { 383, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4687), true, false, 29, 3, 13, 75, null, null },
                    { 384, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4688), true, false, 29, 3, 14, 75, null, null },
                    { 385, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4689), true, false, 29, 4, 21, 50, null, null },
                    { 386, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4690), true, false, 29, 5, 22, 50, null, null },
                    { 387, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4691), true, false, 29, 6, 27, 50, null, null },
                    { 388, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4692), true, false, 29, 7, 30, 50, null, null },
                    { 389, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4692), true, false, 30, 1, 1, 50, null, null },
                    { 390, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4693), true, false, 30, 1, 2, 50, null, null },
                    { 391, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4693), true, false, 30, 1, 3, 50, null, null },
                    { 392, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4694), true, false, 30, 1, 4, 50, null, null },
                    { 393, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4695), true, false, 30, 3, 11, 75, null, null },
                    { 394, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4696), true, false, 30, 3, 12, 75, null, null },
                    { 395, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4696), true, false, 30, 3, 13, 75, null, null },
                    { 396, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4697), true, false, 30, 3, 14, 75, null, null },
                    { 397, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4698), true, false, 30, 4, 21, 50, null, null },
                    { 398, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4699), true, false, 30, 5, 22, 50, null, null },
                    { 399, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4699), true, false, 30, 6, 27, 50, null, null },
                    { 400, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4700), true, false, 30, 7, 30, 50, null, null },
                    { 401, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4701), true, false, 31, 1, 1, 50, null, null },
                    { 402, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4702), true, false, 31, 1, 2, 50, null, null },
                    { 403, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4702), true, false, 31, 1, 3, 50, null, null },
                    { 404, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4703), true, false, 31, 1, 4, 50, null, null },
                    { 405, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4704), true, false, 31, 3, 11, 75, null, null },
                    { 406, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4704), true, false, 31, 3, 12, 75, null, null },
                    { 407, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4705), true, false, 31, 3, 13, 75, null, null },
                    { 408, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4706), true, false, 31, 3, 14, 75, null, null },
                    { 409, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4707), true, false, 31, 4, 16, 50, null, null },
                    { 410, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4708), true, false, 31, 5, 23, 50, null, null },
                    { 411, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4708), true, false, 31, 6, 12, 50, null, null },
                    { 412, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4709), true, false, 31, 7, 29, 50, null, null },
                    { 413, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4710), true, false, 32, 1, 1, 50, null, null },
                    { 414, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4710), true, false, 32, 1, 2, 50, null, null },
                    { 415, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4743), true, false, 32, 1, 3, 50, null, null },
                    { 416, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4743), true, false, 32, 1, 4, 50, null, null },
                    { 417, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4744), true, false, 32, 3, 11, 75, null, null },
                    { 418, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4744), true, false, 32, 3, 12, 75, null, null },
                    { 419, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4745), true, false, 32, 3, 13, 75, null, null },
                    { 420, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4746), true, false, 32, 3, 14, 75, null, null },
                    { 421, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4747), true, false, 32, 4, 19, 50, null, null },
                    { 422, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4748), true, false, 32, 5, 23, 50, null, null },
                    { 423, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4749), true, false, 32, 6, 28, 50, null, null },
                    { 424, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4750), true, false, 32, 7, 30, 50, null, null },
                    { 425, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4750), true, false, 33, 1, 1, 50, null, null },
                    { 426, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4751), true, false, 33, 1, 2, 50, null, null },
                    { 427, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4752), true, false, 33, 1, 3, 50, null, null },
                    { 428, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4752), true, false, 33, 1, 4, 50, null, null },
                    { 429, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4753), true, false, 33, 3, 11, 75, null, null },
                    { 430, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4754), true, false, 33, 3, 12, 75, null, null },
                    { 431, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4754), true, false, 33, 3, 13, 75, null, null },
                    { 432, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4755), true, false, 33, 3, 14, 75, null, null },
                    { 433, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4756), true, false, 33, 4, 19, 50, null, null },
                    { 434, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4757), true, false, 33, 5, 23, 50, null, null },
                    { 435, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4758), true, false, 33, 6, 27, 50, null, null },
                    { 436, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4758), true, false, 33, 7, 29, 50, null, null },
                    { 437, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4759), true, false, 34, 1, 1, 50, null, null },
                    { 438, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4760), true, false, 34, 1, 2, 50, null, null },
                    { 439, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4760), true, false, 34, 1, 3, 50, null, null },
                    { 440, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4761), true, false, 34, 1, 4, 50, null, null },
                    { 441, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4762), true, false, 34, 3, 11, 75, null, null },
                    { 442, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4762), true, false, 34, 3, 12, 75, null, null },
                    { 443, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4763), true, false, 34, 3, 13, 75, null, null },
                    { 444, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4764), true, false, 34, 3, 14, 75, null, null },
                    { 445, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4765), true, false, 34, 4, 35, 50, null, null },
                    { 446, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4766), true, false, 34, 5, 24, 50, null, null },
                    { 447, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4766), true, false, 34, 6, 28, 50, null, null },
                    { 448, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4767), true, false, 34, 7, 31, 50, null, null },
                    { 449, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4768), true, false, 35, 1, 1, 50, null, null },
                    { 450, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4768), true, false, 35, 1, 2, 50, null, null },
                    { 451, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4769), true, false, 35, 1, 3, 50, null, null },
                    { 452, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4770), true, false, 35, 1, 4, 50, null, null },
                    { 453, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4771), true, false, 35, 3, 11, 75, null, null },
                    { 454, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4771), true, false, 35, 3, 12, 75, null, null },
                    { 455, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4772), true, false, 35, 3, 13, 75, null, null },
                    { 456, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4773), true, false, 35, 3, 14, 75, null, null },
                    { 457, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4774), true, false, 35, 4, 19, 50, null, null },
                    { 458, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4775), true, false, 35, 5, 24, 50, null, null },
                    { 459, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4775), true, false, 35, 6, 26, 50, null, null },
                    { 460, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4776), true, false, 35, 7, 30, 50, null, null },
                    { 461, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4777), true, false, 36, 1, 1, 50, null, null },
                    { 462, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4778), true, false, 36, 1, 2, 50, null, null },
                    { 463, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4778), true, false, 36, 1, 3, 50, null, null },
                    { 464, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4779), true, false, 36, 1, 4, 50, null, null },
                    { 465, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4780), true, false, 36, 3, 11, 75, null, null },
                    { 466, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4780), true, false, 36, 3, 12, 75, null, null },
                    { 467, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4781), true, false, 36, 3, 13, 75, null, null },
                    { 468, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4782), true, false, 36, 3, 14, 75, null, null },
                    { 469, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4783), true, false, 36, 4, 34, 50, null, null },
                    { 470, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4784), true, false, 36, 5, 24, 50, null, null },
                    { 471, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4784), true, false, 36, 6, 28, 50, null, null },
                    { 472, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4785), true, false, 36, 7, 31, 50, null, null },
                    { 473, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4786), true, false, 37, 1, 1, 50, null, null },
                    { 474, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4786), true, false, 37, 1, 2, 50, null, null },
                    { 475, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4787), true, false, 37, 1, 3, 50, null, null },
                    { 476, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4819), true, false, 37, 1, 4, 50, null, null },
                    { 477, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4820), true, false, 37, 3, 11, 75, null, null },
                    { 478, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4821), true, false, 37, 3, 12, 75, null, null },
                    { 479, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4821), true, false, 37, 3, 13, 75, null, null },
                    { 480, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4822), true, false, 37, 3, 14, 75, null, null },
                    { 481, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4823), true, false, 37, 4, 17, 50, null, null },
                    { 482, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4824), true, false, 37, 5, 23, 50, null, null },
                    { 483, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4825), true, false, 37, 6, 26, 50, null, null },
                    { 484, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4826), true, false, 37, 7, 30, 50, null, null },
                    { 485, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4827), true, false, 38, 1, 1, 50, null, null },
                    { 486, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4827), true, false, 38, 1, 2, 50, null, null },
                    { 487, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4828), true, false, 38, 1, 3, 50, null, null },
                    { 488, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4829), true, false, 38, 1, 4, 50, null, null },
                    { 489, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4829), true, false, 38, 3, 11, 75, null, null },
                    { 490, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4830), true, false, 38, 3, 12, 75, null, null },
                    { 491, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4831), true, false, 38, 3, 13, 75, null, null },
                    { 492, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4831), true, false, 38, 3, 14, 75, null, null },
                    { 493, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4832), true, false, 38, 4, 19, 50, null, null },
                    { 494, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4833), true, false, 38, 5, 23, 50, null, null },
                    { 495, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4834), true, false, 38, 6, 28, 50, null, null },
                    { 496, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4835), true, false, 38, 7, 30, 50, null, null },
                    { 497, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4835), true, false, 39, 1, 1, 50, null, null },
                    { 498, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4836), true, false, 39, 1, 2, 50, null, null },
                    { 499, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4836), true, false, 39, 1, 3, 50, null, null },
                    { 500, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4837), true, false, 39, 1, 4, 50, null, null },
                    { 501, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4838), true, false, 39, 3, 11, 75, null, null },
                    { 502, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4838), true, false, 39, 3, 12, 75, null, null },
                    { 503, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4839), true, false, 39, 3, 13, 75, null, null },
                    { 504, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4840), true, false, 39, 3, 14, 75, null, null },
                    { 505, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4840), true, false, 39, 4, 36, 50, null, null },
                    { 506, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4841), true, false, 39, 5, 22, 50, null, null },
                    { 507, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4842), true, false, 39, 6, 27, 50, null, null },
                    { 508, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4843), true, false, 39, 7, 30, 50, null, null },
                    { 509, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4843), true, false, 40, 1, 1, 50, null, null },
                    { 510, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4844), true, false, 40, 1, 2, 50, null, null },
                    { 511, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4845), true, false, 40, 1, 3, 50, null, null },
                    { 512, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4846), true, false, 40, 1, 4, 50, null, null },
                    { 513, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4846), true, false, 40, 3, 11, 75, null, null },
                    { 514, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4847), true, false, 40, 3, 12, 75, null, null },
                    { 515, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4847), true, false, 40, 3, 13, 75, null, null },
                    { 516, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4848), true, false, 40, 3, 14, 75, null, null },
                    { 517, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4849), true, false, 40, 4, 19, 50, null, null },
                    { 518, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4850), true, false, 40, 5, 24, 50, null, null },
                    { 519, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4851), true, false, 40, 6, 28, 50, null, null },
                    { 520, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4851), true, false, 40, 7, 30, 50, null, null },
                    { 521, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4852), true, false, 41, 1, 1, 50, null, null },
                    { 522, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4853), true, false, 41, 1, 2, 50, null, null },
                    { 523, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4853), true, false, 41, 1, 3, 50, null, null },
                    { 524, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4854), true, false, 41, 1, 4, 50, null, null },
                    { 525, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4855), true, false, 41, 3, 11, 75, null, null },
                    { 526, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4855), true, false, 41, 3, 12, 75, null, null },
                    { 527, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4856), true, false, 41, 3, 13, 75, null, null },
                    { 528, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4857), true, false, 41, 3, 14, 75, null, null },
                    { 529, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4858), true, false, 41, 4, 16, 50, null, null },
                    { 530, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4858), true, false, 41, 5, 23, 50, null, null },
                    { 531, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4859), true, false, 41, 6, 12, 50, null, null },
                    { 532, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4860), true, false, 41, 7, 29, 50, null, null },
                    { 533, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4861), true, false, 42, 1, 1, 50, null, null },
                    { 534, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4862), true, false, 42, 1, 2, 50, null, null },
                    { 535, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4862), true, false, 42, 1, 3, 50, null, null },
                    { 536, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4895), true, false, 42, 1, 4, 50, null, null },
                    { 537, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4895), true, false, 42, 3, 11, 75, null, null },
                    { 538, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4896), true, false, 42, 3, 12, 75, null, null },
                    { 539, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4897), true, false, 42, 3, 13, 75, null, null },
                    { 540, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4897), true, false, 42, 3, 14, 75, null, null },
                    { 541, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4898), true, false, 42, 4, 21, 50, null, null },
                    { 542, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4899), true, false, 42, 5, 23, 50, null, null },
                    { 543, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4900), true, false, 42, 6, 26, 50, null, null },
                    { 544, null, new DateTime(2025, 3, 28, 20, 22, 21, 324, DateTimeKind.Local).AddTicks(4901), true, false, 42, 7, 30, 50, null, null }
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
