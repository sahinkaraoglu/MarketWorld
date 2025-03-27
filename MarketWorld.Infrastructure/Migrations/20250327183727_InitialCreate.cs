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
                    { 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5021), false, "Apple", null, null, null },
                    { 2, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5023), false, "Asus", null, null, null },
                    { 3, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5024), false, "Casper", null, null, null },
                    { 4, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5025), false, "HP", null, null, null },
                    { 5, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5026), false, "Lenovo", null, null, null },
                    { 6, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5028), false, "MSI", null, null, null },
                    { 7, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5029), false, "Acer", null, null, null },
                    { 8, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5029), false, "Xiaomi", null, null, null },
                    { 9, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5030), false, "Samsung", null, null, null },
                    { 10, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5060), false, "Huawei", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4783), "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar", false, "Elektronik", "elektronik", null, null },
                    { 2, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4797), "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları", false, "Giyim & Aksesuar", "giyim-aksesuar", null, null },
                    { 3, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4798), "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili", false, "Ev & Yaşam", "ev-yasam", null, null },
                    { 4, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4800), "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri", false, "Kozmetik & Kişisel Bakım", "kozmetik-kisisel-bakim", null, null },
                    { 5, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4801), "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri", false, "Spor & Outdoor", "spor-outdoor", null, null }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsActive", "IsDeleted", "Name", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9032), "Ürün Renk Seçenekleri", true, false, "Renk", null, null },
                    { 2, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9038), "Beden Seçenekleri", true, false, "Beden", null, null },
                    { 3, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9072), "Dahili Hafıza", true, false, "Hafıza", null, null },
                    { 4, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9073), "Bilgisayar İşlemci Seçenekleri", true, false, "İşlemci", null, null },
                    { 5, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9074), "Bellek Kapasitesi", true, false, "RAM", null, null },
                    { 6, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9076), "SSD Kapasitesi", true, false, "SSD", null, null },
                    { 7, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9078), "Ekran Boyutu", true, false, "Ekran", null, null }
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
                    { 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9105), true, false, 1, null, null, "Uzay Siyahı" },
                    { 2, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9107), true, false, 1, null, null, "Altın" },
                    { 3, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9108), true, false, 1, null, null, "Gümüş" },
                    { 4, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9109), true, false, 1, null, null, "Mor" },
                    { 5, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9110), true, false, 2, null, null, "XS" },
                    { 6, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9112), true, false, 2, null, null, "S" },
                    { 7, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9113), true, false, 2, null, null, "M" },
                    { 8, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9114), true, false, 2, null, null, "L" },
                    { 9, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9115), true, false, 2, null, null, "XL" },
                    { 10, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9116), true, false, 2, null, null, "XXL" },
                    { 11, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9117), true, false, 3, null, null, "128GB" },
                    { 12, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9118), true, false, 3, null, null, "256GB" },
                    { 13, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9120), true, false, 3, null, null, "512GB" },
                    { 14, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9120), true, false, 3, null, null, "1TB" },
                    { 15, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9122), true, false, 4, null, null, "Intel Core i7 12700H" },
                    { 16, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9123), true, false, 4, null, null, "Intel Core i7 1255U" },
                    { 17, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9123), true, false, 4, null, null, "Intel Core i7 13620H" },
                    { 18, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9125), true, false, 4, null, null, "Intel Core i5 1334U" },
                    { 19, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9126), true, false, 4, null, null, "Intel Core i5 13420H" },
                    { 20, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9127), true, false, 4, null, null, "AMD Ryzen 7 5700U" },
                    { 21, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9128), true, false, 4, null, null, "Intel Core i5 12450H" },
                    { 22, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9129), true, false, 5, null, null, "8GB" },
                    { 23, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9130), true, false, 5, null, null, "16GB" },
                    { 24, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9131), true, false, 5, null, null, "32GB" },
                    { 25, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9132), true, false, 6, null, null, "256GB" },
                    { 26, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9134), true, false, 6, null, null, "500GB" },
                    { 27, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9135), true, false, 6, null, null, "512GB" },
                    { 28, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9136), true, false, 6, null, null, "1TB" },
                    { 29, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9137), true, false, 7, null, null, "14\"" },
                    { 30, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9138), true, false, 7, null, null, "15.6\"" },
                    { 31, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9139), true, false, 7, null, null, "16\"" },
                    { 32, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9140), true, false, 4, null, null, "Intel Core i7 13650HX" },
                    { 33, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9140), true, false, 4, null, null, "Intel Core i5 13500H" },
                    { 34, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9142), true, false, 4, null, null, "Intel Core i9-14900HX" },
                    { 35, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9143), true, false, 4, null, null, "Intel Core Ultra 7 255HX" },
                    { 36, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9144), true, false, 4, null, null, "AMD Ryzen 5 7520U" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedDate", "Description", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4953), "Dizüstü, masaüstü bilgisayarlar ve tabletler", false, "Bilgisayarlar & Tabletler", "bilgisayarlar-tabletler", null, null },
                    { 2, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4954), "Yazıcılar, tarayıcılar ve projeksiyon cihazları", false, "Yazıcılar & Projeksiyon", "yazicilar-projeksiyon", null, null },
                    { 3, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4956), "Akıllı telefonlar ve aksesuarları", false, "Telefonlar", "telefonlar", null, null },
                    { 4, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4959), "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar", false, "Beyaz Eşya", "beyaz-esya", null, null },
                    { 5, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4960), "Klimalar, ısıtıcılar ve hava temizleyiciler", false, "Klima ve Isıtıcılar", "klima-isitici", null, null },
                    { 6, 2, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4961), "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar", false, "Ayakkabı & Çanta", "ayakkabi-canta", null, null },
                    { 7, 2, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4962), "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim", false, "Kadın Giyim", "kadin-giyim", null, null },
                    { 8, 2, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4963), "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim", false, "Erkek Giyim", "erkek-giyim", null, null },
                    { 9, 2, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4965), "Kız ve erkek çocuk giyim ürünleri", false, "Çocuk Giyim", "cocuk-giyim", null, null },
                    { 10, 3, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4966), "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları", false, "Mobilya", "mobilya", null, null },
                    { 11, 3, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4967), "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri", false, "Ev Tekstili", "ev-tekstili", null, null },
                    { 12, 3, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4968), "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri", false, "Dekorasyon & Aydınlatma", "dekorasyon-aydinlatma", null, null },
                    { 13, 3, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4970), "Pişirme, servis ve saklama ürünleri, mutfak aletleri", false, "Mutfak Gereçleri", "mutfak-gerecleri", null, null },
                    { 14, 3, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4971), "Banyo aksesuarları, temizlik ve düzenleme ürünleri", false, "Banyo & Ev Gereçleri", "banyo-ev-gerecleri", null, null },
                    { 15, 3, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4972), "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri", false, "Kırtasiye & Ofis", "kirtasiye-ve-ofis", null, null },
                    { 16, 4, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4973), "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri", false, "Parfüm & Deodorant", "parfum-deodorant", null, null },
                    { 17, 4, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4974), "Saç bakım ve şekillendirme ürünleri", false, "Saç Şekillendirme", "sac-sekillendirme", null, null },
                    { 18, 4, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4978), "Yüz ve vücut bakım ürünleri, kremler ve serumlar", false, "Cilt Bakımı", "cilt-bakimi", null, null },
                    { 19, 4, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4979), "Renkli kozmetik ve makyaj malzemeleri", false, "Makyaj", "makyaj", null, null },
                    { 20, 4, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4981), "Vitamin, takviye gıdalar ve medikal ürünler", false, "Sağlık & Medikal Ürünler", "saglik-medikal-urunler", null, null },
                    { 21, 4, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4982), "Diş bakım ürünleri ve ağız bakım ürünleri", false, "Ağız & Diş Bakımı", "agiz-dis-bakimi", null, null },
                    { 22, 5, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4983), "Fitness ekipmanları, kondisyon aletleri ve aksesuarları", false, "Fitness & Kondisyon", "fitness-kondisyon", null, null },
                    { 23, 5, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4984), "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar", false, "Spor Giyim & Ayakkabı", "spor-giyim-ayakkabi", null, null },
                    { 24, 5, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4985), "Kamp malzemeleri, outdoor giyim ve ekipmanlar", false, "Outdoor & Kamp", "outdoor-kamp", null, null },
                    { 25, 5, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4987), "Kayak ekipmanları ve kış sporları malzemeleri", false, "Kış Sporları", "kis-sporlari", null, null },
                    { 26, 5, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(4988), "Yüzme ve su sporları ekipmanları", false, "Su Sporları", "su-sporlari", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedById", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "Password", "PhoneNumber", "UpdatedById", "UpdatedDate", "UserRoleId", "Username" },
                values: new object[,]
                {
                    { 1, null, "admin@admin.com", "Şahin", true, false, null, "123", null, null, null, 1, "admin" },
                    { 2, null, "ali@example.com", "Ali", true, false, null, "456", null, null, null, 2, "aliuzun" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedById", "CreatedDate", "Description", "DiscountPrice", "HasDiscount", "IsActive", "IsDeleted", "Name", "Price", "Rating", "Stock", "SubCategoryId", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5105), "Apple iPhone 14 Pro 256 GB", 54999.99m, true, true, false, "iPhone 14 Pro", 56999.99m, 5m, 100, 3, null, null },
                    { 2, 9, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5109), "Samsung Galaxy S23 Ultra 256 GB", 65999.99m, true, true, false, "Samsung Galaxy S23 Ultra", 75999.99m, 5m, 150, 3, null, null },
                    { 3, 1, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5112), "Apple iPhone 15 128 GB Mavi", 39999.99m, true, true, false, "iPhone 15 128 GB", 49999.99m, 4m, 150, 3, null, null },
                    { 4, 8, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5115), "Xiaomi 13T Pro 512 GB", 37999.99m, true, true, false, "Xiaomi 13T Pro", 39999.99m, 3m, 75, 3, null, null },
                    { 5, 10, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5117), "Huawei P60 Pro 256 GB", 0m, false, true, false, "Huawei P60 Pro", 44999.99m, 4m, 60, 3, null, null },
                    { 6, 9, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5121), "Samsung Galaxy Z Fold5 512 GB", 84999.99m, true, true, false, "Samsung Galaxy Z Fold5", 89999.99m, 4.9m, 40, 3, null, null },
                    { 7, 1, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5123), "Apple iPhone 15 Pro Max 512 GB", 0m, false, true, false, "iPhone 15 Pro Max", 92999.99m, 3m, 25, 3, null, null },
                    { 8, 8, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5126), "Xiaomi Redmi Note 13 Pro+ 256 GB", 27999.99m, true, true, false, "Xiaomi Redmi Note 13 Pro+", 29999.99m, 4.2m, 200, 3, null, null },
                    { 9, 9, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5129), "Samsung Galaxy A54 128 GB", 18499.99m, true, true, false, "Samsung Galaxy A54", 19999.99m, 4.1m, 300, 3, null, null },
                    { 10, 10, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5132), "Huawei Nova 11 Pro 256 GB", 0m, false, true, false, "Huawei Nova 11 Pro", 34999.99m, 5m, 85, 3, null, null },
                    { 11, 1, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5134), "13inc Taşınabilir Bilgisayar Uzay Grisi MC7U4TU/A", 0m, false, true, false, "MacBook Air M2 16GB 256GB SSD", 41599.99m, 5m, 85, 1, null, null },
                    { 12, 3, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5136), "Intel Core i7 12700H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1270", 39999.99m, 4.5m, 100, 1, null, null },
                    { 13, 6, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5138), "Intel Core i7 1255U 16GB 512GB SSD Freedos 14\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "MSI Modern 14 C12MO", 21799.99m, 4.5m, 75, 1, null, null },
                    { 14, 3, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5142), "Core i7-13620H 32GB DDR5 RAM 1TB NVME SSD 16\" Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana S100", 27299.99m, 5m, 50, 1, null, null },
                    { 15, 3, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5145), "Intel Core i7 13620H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1362", 50199.99m, 4.5m, 60, 1, null, null },
                    { 16, 4, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5147), "Intel Core i5 1334U 16GB 512GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "HP 250 G10", 14999.99m, 4.7m, 100, 1, null, null },
                    { 17, 5, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5149), "Intel Core i5 13420H 16GB Ddr5 Ram 512 GB SSD 16'' WUXGA IPS Panel Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad Slim 3", 19799.99m, 4.9m, 80, 1, null, null },
                    { 18, 5, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5152), "AMD Ryzen 7 5700U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad 1", 15999.99m, 4.6m, 90, 1, null, null },
                    { 19, 6, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5154), "Intel Core i5 12450H 8GB 512GB SSD RTX2050 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "MSI Thin 15", 24799.99m, 4.5m, 70, 1, null, null },
                    { 20, 3, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5156), "Intel Core i7 1255U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana C550", 18999.99m, 4.5m, 85, 1, null, null },
                    { 21, 5, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5159), "Intel Core i7 13650HX 32GB 1TB SSD RTX 4060 8GB (115W) 15.6\" FHD 144Hz IPS Panel Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo LOQ 15IRX9", 59999.99m, 5m, 45, 1, null, null },
                    { 22, 3, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5161), "Intel Core i5-12450H 32GB RAM 500GB SSD GEN4 RTX3050 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G770", 31299.99m, 4.6m, 65, 1, null, null },
                    { 23, 3, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5163), "AMD Ryzen 5 7430U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana X600", 16999.99m, 5m, 80, 1, null, null },
                    { 24, 7, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5165), "Intel Core i7 1255U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Acer Aspire 3", 24000.00m, 5m, 70, 1, null, null },
                    { 25, 3, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5167), "Intel Core i7 12700H 32GB 1TB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana X600.1270", 22999.99m, 4.5m, 85, 1, null, null },
                    { 26, 3, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5169), "Intel Core i5-13420H 32GB RAM 500GB NVME SSD GEN4 6GB RTX4050 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G870.1342", 38499.99m, 4.1m, 55, 1, null, null },
                    { 27, 3, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5171), "Intel Core i7 12700H 32GB 1TB SSD RTX4070 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1270", 50899.99m, 4m, 40, 1, null, null },
                    { 28, 4, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5174), "Intel Core i5 13500H 16GB 512GB SSD RTX4050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "HP Victus Gaming 15", 33999.99m, 4.6m, 90, 1, null, null },
                    { 29, 5, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5195), "Intel Core i5 12450H 8GB 512GB SSD 15.6\" FHD Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo IdeaPad Slim 3", 15359.04m, 4.7m, 100, 1, null, null },
                    { 30, 2, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5197), "Intel Core i5 12500H 8GB 512GB SSD RTX3050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Asus TUF Gaming F15", 29898.66m, 4.7m, 75, 1, null, null },
                    { 31, 1, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5199), "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Uzay Grisi", 0m, false, true, false, "Apple MacBook Air M1", 39250.00m, 4.9m, 60, 1, null, null },
                    { 32, 3, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5201), "Intel Core i5-13420H 16GB RAM 1TB NVME SSD 8GB RTX4060 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G870.1342", 42299.99m, 4.3m, 50, 1, null, null },
                    { 33, 5, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5203), "Intel Core i5 13420H 16GB 512GB SSD Freedos 14\" WUXGA Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad 5", 29999.99m, 5m, 70, 1, null, null },
                    { 34, 2, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5206), "Intel Core Ultra 7 255HX 32GB 1TB SSD RTX5070Ti Freedos 16\" Taşınabilir Bilgisayar", 0m, false, true, false, "Asus ROG Strix G16", 107999.99m, 5m, 25, 1, null, null },
                    { 35, 3, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5214), "Intel Core i5-13420H 32GB RAM 500GB NVME SSD Freedos", 0m, false, true, false, "Casper Nirvana X600.1342", 19999.99m, 5m, 85, 1, null, null },
                    { 36, 5, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5216), "Intel Core i9-14900HX 32GB DDR5 1TB SSD RTX4060 8GB 16 inç 3.2K (3200×2000) 165Hz FreeDos Laptop", 0m, false, true, false, "Lenovo Thinkbook 16PG5", 79999.40m, 4.7m, 30, 1, null, null },
                    { 37, 3, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5218), "Intel Core i7-13620H 16GB RAM 500GB NVME SSD Freedos Laptop", 0m, false, true, false, "Casper Nirvana X600.1362", 22099.99m, 5m, 75, 1, null, null },
                    { 38, 6, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5220), "Intel Core i5 13420H 16GB 1TB SSD RTX4060 Freedos 15.6\" FHD 144Hz Taşınabilir Bilgisayar", 0m, false, true, false, "MSI CYBORG 15", 37999.99m, 4.9m, 60, 1, null, null },
                    { 39, 5, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5222), "AMD Ryzen 5 7520U 8gb 512GB SSD Freedos 15.6\" Fhd Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo V15 G4", 13299.99m, 4.3m, 95, 1, null, null },
                    { 40, 5, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5224), "I5-13420H 32GB 1 Tb SSD 15.6 Fhd Windows 11 Pro", 0m, false, true, false, "Lenovo V15 G4", 27749.00m, 5m, 70, 1, null, null },
                    { 41, 1, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5227), "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Gece Yarısı", 0m, false, true, false, "Apple MacBook Air M4", 49999.99m, 5m, 45, 1, null, null },
                    { 42, 3, 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5232), "Intel Core i5 12450H 16GB 500GB SSD RTX2050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1245", 27499.99m, 4.4m, 80, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "EntityId", "EntityType", "IsDeleted", "Path", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5273), 1, 1, false, "img/ProductsPicture/Telephones/TelephoneOne/resimbir.jpg", null, null },
                    { 2, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5275), 1, 1, false, "img/ProductsPicture/Telephones/TelephoneOne/resimiki.jpg", null, null },
                    { 3, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5276), 1, 1, false, "img/ProductsPicture/Telephones/TelephoneOne/resimuc.jpg", null, null },
                    { 4, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5277), 1, 1, false, "img/ProductsPicture/Telephones/TelephoneOne/resimdort.jpg", null, null },
                    { 5, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5278), 2, 1, false, "img/ProductsPicture/Telephones/TelephoneTwo/resimbir.jpg", null, null },
                    { 6, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5280), 2, 1, false, "img/ProductsPicture/Telephones/TelephoneTwo/resimiki.jpg", null, null },
                    { 7, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5282), 2, 1, false, "img/ProductsPicture/Telephones/TelephoneTwo/resimuc.jpg", null, null },
                    { 8, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5283), 2, 1, false, "img/ProductsPicture/Telephones/TelephoneTwo/resimdort.jpg", null, null },
                    { 9, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5284), 3, 1, false, "img/ProductsPicture/Telephones/TelephoneThree/resimbir.jpg", null, null },
                    { 10, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5285), 3, 1, false, "img/ProductsPicture/Telephones/TelephoneThree/resimiki.jpg", null, null },
                    { 11, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5287), 3, 1, false, "img/ProductsPicture/Telephones/TelephoneThree/resimuc.jpg", null, null },
                    { 12, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5288), 3, 1, false, "img/ProductsPicture/Telephones/TelephoneThree/resimdort.jpg", null, null },
                    { 13, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5289), 4, 1, false, "img/ProductsPicture/Telephones/TelephoneFour/resimbir.jpg", null, null },
                    { 14, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5290), 4, 1, false, "img/ProductsPicture/Telephones/TelephoneFour/resimiki.jpg", null, null },
                    { 15, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5291), 4, 1, false, "img/ProductsPicture/Telephones/TelephoneFour/resimuc.jpg", null, null },
                    { 16, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5292), 4, 1, false, "img/ProductsPicture/Telephones/TelephoneFour/resimdort.jpg", null, null },
                    { 17, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5293), 5, 1, false, "img/ProductsPicture/Telephones/TelephoneFive/resimbir.jpg", null, null },
                    { 18, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5295), 5, 1, false, "img/ProductsPicture/Telephones/TelephoneFive/resimiki.jpg", null, null },
                    { 19, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5296), 5, 1, false, "img/ProductsPicture/Telephones/TelephoneFive/resimuc.jpg", null, null },
                    { 20, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5297), 5, 1, false, "img/ProductsPicture/Telephones/TelephoneFive/resimdort.jpg", null, null },
                    { 21, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5298), 6, 1, false, "img/ProductsPicture/Telephones/TelephoneSix/resimbir.jpg", null, null },
                    { 22, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5335), 6, 1, false, "img/ProductsPicture/Telephones/TelephoneSix/resimiki.jpg", null, null },
                    { 23, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5336), 6, 1, false, "img/ProductsPicture/Telephones/TelephoneSix/resimuc.jpg", null, null },
                    { 24, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5338), 6, 1, false, "img/ProductsPicture/Telephones/TelephoneSix/resimdort.jpg", null, null },
                    { 25, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5339), 7, 1, false, "img/ProductsPicture/Telephones/TelephoneSeven/resimbir.jpg", null, null },
                    { 26, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5340), 7, 1, false, "img/ProductsPicture/Telephones/TelephoneSeven/resimiki.jpg", null, null },
                    { 27, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5342), 7, 1, false, "img/ProductsPicture/Telephones/TelephoneSeven/resimuc.jpg", null, null },
                    { 28, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5343), 7, 1, false, "img/ProductsPicture/Telephones/TelephoneSeven/resimdort.jpg", null, null },
                    { 29, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5344), 8, 1, false, "img/ProductsPicture/Telephones/TelephoneEight/resimbir.jpg", null, null },
                    { 30, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5346), 8, 1, false, "img/ProductsPicture/Telephones/TelephoneEight/resimiki.jpg", null, null },
                    { 31, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5347), 8, 1, false, "img/ProductsPicture/Telephones/TelephoneEight/resimuc.jpg", null, null },
                    { 32, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5348), 8, 1, false, "img/ProductsPicture/Telephones/TelephoneEight/resimdort.jpg", null, null },
                    { 33, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5349), 9, 1, false, "img/ProductsPicture/Telephones/TelephoneNine/resimbir.jpg", null, null },
                    { 34, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5351), 9, 1, false, "img/ProductsPicture/Telephones/TelephoneNine/resimiki.jpg", null, null },
                    { 35, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5352), 9, 1, false, "img/ProductsPicture/Telephones/TelephoneNine/resimuc.jpg", null, null },
                    { 36, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5353), 9, 1, false, "img/ProductsPicture/Telephones/TelephoneNine/resimdort.jpg", null, null },
                    { 37, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5355), 10, 1, false, "img/ProductsPicture/Telephones/TelephoneTen/resimbir.jpg", null, null },
                    { 38, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5356), 10, 1, false, "img/ProductsPicture/Telephones/TelephoneTen/resimiki.jpg", null, null },
                    { 39, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5357), 10, 1, false, "img/ProductsPicture/Telephones/TelephoneTen/resimuc.jpg", null, null },
                    { 40, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5358), 10, 1, false, "img/ProductsPicture/Telephones/TelephoneTen/resimdort.jpg", null, null },
                    { 41, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5359), 11, 1, false, "img/ProductsPicture/Pc/PcOne/resimbir.jpg", null, null },
                    { 42, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5360), 11, 1, false, "img/ProductsPicture/Pc/PcOne/resimiki.jpg", null, null },
                    { 43, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5361), 11, 1, false, "img/ProductsPicture/Pc/PcOne/resimuc.jpg", null, null },
                    { 44, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5363), 11, 1, false, "img/ProductsPicture/Pc/PcOne/resimdort.jpg", null, null },
                    { 45, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5364), 12, 1, false, "img/Products/Laptops/Casper_G870.1270.jpg", null, null },
                    { 46, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5366), 13, 1, false, "img/Products/Laptops/MSI_15.6.jpg", null, null },
                    { 47, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5367), 14, 1, false, "img/Products/Laptops/Casper_S100.1362.jpg", null, null },
                    { 48, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5368), 15, 1, false, "img/Products/Laptops/Casper_G870.1362.jpg", null, null },
                    { 49, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5369), 16, 1, false, "img/Products/Laptops/HP_15.6.jpg", null, null },
                    { 50, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5370), 17, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 51, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5371), 18, 1, false, "img/Products/Laptops/Lenovo_model.jpg", null, null },
                    { 52, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5372), 19, 1, false, "img/Products/Laptops/MSI_model.jpg", null, null },
                    { 53, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5373), 20, 1, false, "img/Products/Laptops/Casper_C550.1255.jpg", null, null },
                    { 54, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5374), 21, 1, false, "img/Products/Laptops/Lenovo_3.2.jpg", null, null },
                    { 55, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5376), 22, 1, false, "img/Products/Laptops/Casper_G770.1245.jpg", null, null },
                    { 56, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5377), 23, 1, false, "img/Products/Laptops/Casper_X600.7430.jpg", null, null },
                    { 57, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5378), 24, 1, false, "img/Products/Laptops/Acer_15.6.jpg", null, null },
                    { 58, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5379), 25, 1, false, "img/Products/Laptops/Casper_X600.1270.jpg", null, null },
                    { 59, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5380), 26, 1, false, "img/Products/Laptops/Casper_G870.1342.jpg", null, null },
                    { 60, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5381), 27, 1, false, "img/Products/Laptops/Casper_G870.1270.jpg", null, null },
                    { 61, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5382), 28, 1, false, "img/Products/Laptops/HP_15.6.jpg", null, null },
                    { 62, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5383), 29, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 63, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5384), 30, 1, false, "img/Products/Laptops/Asus_15.6.jpg", null, null },
                    { 64, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5385), 31, 1, false, "img/Products/Laptops/Apple_model.jpg", null, null },
                    { 65, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5387), 32, 1, false, "img/Products/Laptops/Casper_G870.1342.jpg", null, null },
                    { 66, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5389), 33, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 67, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5390), 34, 1, false, "img/Products/Laptops/Asus_model.jpg", null, null },
                    { 68, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5391), 35, 1, false, "img/Products/Laptops/Casper_X600.1342.jpg", null, null },
                    { 69, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5392), 36, 1, false, "img/Products/Laptops/Lenovo_3.2.jpg", null, null },
                    { 70, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5393), 37, 1, false, "img/Products/Laptops/Casper_X600.1362.jpg", null, null },
                    { 71, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5394), 38, 1, false, "img/Products/Laptops/MSI_15.6.jpg", null, null },
                    { 72, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5395), 39, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 73, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5396), 40, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 74, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5397), 41, 1, false, "img/Products/Laptops/Apple_model.jpg", null, null },
                    { 75, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(5399), 42, 1, false, "img/Products/Laptops/Casper_G870.1245.jpg", null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductProperties",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "ProductId", "PropertyTypeId", "PropertyValueId", "Stock", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 81, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9174), true, false, 1, 1, 1, 50, null, null },
                    { 82, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9181), true, false, 1, 1, 2, 50, null, null },
                    { 83, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9211), true, false, 1, 1, 3, 50, null, null },
                    { 84, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9212), true, false, 1, 1, 4, 50, null, null },
                    { 85, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9214), true, false, 1, 3, 11, 75, null, null },
                    { 86, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9215), true, false, 1, 3, 12, 75, null, null },
                    { 87, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9216), true, false, 1, 3, 13, 75, null, null },
                    { 88, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9216), true, false, 1, 3, 14, 75, null, null },
                    { 89, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9217), true, false, 2, 1, 1, 50, null, null },
                    { 90, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9218), true, false, 2, 1, 2, 50, null, null },
                    { 91, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9219), true, false, 2, 1, 3, 50, null, null },
                    { 92, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9219), true, false, 2, 1, 4, 50, null, null },
                    { 93, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9219), true, false, 2, 3, 11, 75, null, null },
                    { 94, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9220), true, false, 2, 3, 12, 75, null, null },
                    { 95, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9220), true, false, 2, 3, 13, 75, null, null },
                    { 96, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9221), true, false, 2, 3, 14, 75, null, null },
                    { 97, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9221), true, false, 3, 1, 1, 50, null, null },
                    { 98, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9222), true, false, 3, 1, 2, 50, null, null },
                    { 99, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9223), true, false, 3, 1, 3, 50, null, null },
                    { 100, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9223), true, false, 3, 1, 4, 50, null, null },
                    { 101, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9224), true, false, 3, 3, 11, 75, null, null },
                    { 102, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9224), true, false, 3, 3, 12, 75, null, null },
                    { 103, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9225), true, false, 3, 3, 13, 75, null, null },
                    { 104, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9225), true, false, 3, 3, 14, 75, null, null },
                    { 105, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9226), true, false, 4, 1, 1, 50, null, null },
                    { 106, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9226), true, false, 4, 1, 2, 50, null, null },
                    { 107, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9227), true, false, 4, 1, 3, 50, null, null },
                    { 108, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9227), true, false, 4, 1, 4, 50, null, null },
                    { 109, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9227), true, false, 4, 3, 11, 75, null, null },
                    { 110, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9228), true, false, 4, 3, 12, 75, null, null },
                    { 111, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9228), true, false, 4, 3, 13, 75, null, null },
                    { 112, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9229), true, false, 4, 3, 14, 75, null, null },
                    { 113, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9229), true, false, 5, 1, 1, 50, null, null },
                    { 114, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9230), true, false, 5, 1, 2, 50, null, null },
                    { 115, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9231), true, false, 5, 1, 3, 50, null, null },
                    { 116, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9231), true, false, 5, 1, 4, 50, null, null },
                    { 117, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9231), true, false, 5, 3, 11, 75, null, null },
                    { 118, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9232), true, false, 5, 3, 12, 75, null, null },
                    { 119, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9232), true, false, 5, 3, 13, 75, null, null },
                    { 120, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9233), true, false, 5, 3, 14, 75, null, null },
                    { 121, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9233), true, false, 6, 1, 1, 50, null, null },
                    { 122, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9234), true, false, 6, 1, 2, 50, null, null },
                    { 123, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9234), true, false, 6, 1, 3, 50, null, null },
                    { 124, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9235), true, false, 6, 1, 4, 50, null, null },
                    { 125, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9235), true, false, 6, 3, 11, 75, null, null },
                    { 126, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9235), true, false, 6, 3, 12, 75, null, null },
                    { 127, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9236), true, false, 6, 3, 13, 75, null, null },
                    { 128, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9236), true, false, 6, 3, 14, 75, null, null },
                    { 129, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9237), true, false, 7, 1, 1, 50, null, null },
                    { 130, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9237), true, false, 7, 1, 2, 50, null, null },
                    { 131, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9238), true, false, 7, 1, 3, 50, null, null },
                    { 132, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9238), true, false, 7, 1, 4, 50, null, null },
                    { 133, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9239), true, false, 7, 3, 11, 75, null, null },
                    { 134, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9239), true, false, 7, 3, 12, 75, null, null },
                    { 135, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9268), true, false, 7, 3, 13, 75, null, null },
                    { 136, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9269), true, false, 7, 3, 14, 75, null, null },
                    { 137, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9269), true, false, 8, 1, 1, 50, null, null },
                    { 138, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9270), true, false, 8, 1, 2, 50, null, null },
                    { 139, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9270), true, false, 8, 1, 3, 50, null, null },
                    { 140, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9271), true, false, 8, 1, 4, 50, null, null },
                    { 141, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9271), true, false, 8, 3, 11, 75, null, null },
                    { 142, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9271), true, false, 8, 3, 12, 75, null, null },
                    { 143, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9272), true, false, 8, 3, 13, 75, null, null },
                    { 144, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9273), true, false, 8, 3, 14, 75, null, null },
                    { 145, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9273), true, false, 9, 1, 1, 50, null, null },
                    { 146, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9274), true, false, 9, 1, 2, 50, null, null },
                    { 147, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9275), true, false, 9, 1, 3, 50, null, null },
                    { 148, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9275), true, false, 9, 1, 4, 50, null, null },
                    { 149, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9276), true, false, 9, 3, 11, 75, null, null },
                    { 150, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9276), true, false, 9, 3, 12, 75, null, null },
                    { 151, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9277), true, false, 9, 3, 13, 75, null, null },
                    { 152, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9277), true, false, 9, 3, 14, 75, null, null },
                    { 153, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9278), true, false, 10, 1, 1, 50, null, null },
                    { 154, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9278), true, false, 10, 1, 2, 50, null, null },
                    { 155, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9278), true, false, 10, 1, 3, 50, null, null },
                    { 156, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9279), true, false, 10, 1, 4, 50, null, null },
                    { 157, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9279), true, false, 10, 3, 11, 75, null, null },
                    { 158, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9280), true, false, 10, 3, 12, 75, null, null },
                    { 159, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9280), true, false, 10, 3, 13, 75, null, null },
                    { 160, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9281), true, false, 10, 3, 14, 75, null, null },
                    { 161, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9283), true, false, 12, 4, 15, 50, null, null },
                    { 162, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9285), true, false, 12, 5, 24, 50, null, null },
                    { 163, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9288), true, false, 12, 6, 28, 50, null, null },
                    { 164, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9290), true, false, 12, 7, 30, 50, null, null },
                    { 165, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9291), true, false, 13, 4, 16, 50, null, null },
                    { 166, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9292), true, false, 13, 5, 23, 50, null, null },
                    { 167, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9293), true, false, 13, 6, 27, 50, null, null },
                    { 168, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9294), true, false, 13, 7, 29, 50, null, null },
                    { 169, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9294), true, false, 14, 4, 17, 50, null, null },
                    { 170, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9295), true, false, 14, 5, 24, 50, null, null },
                    { 171, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9296), true, false, 14, 6, 28, 50, null, null },
                    { 172, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9296), true, false, 14, 7, 31, 50, null, null },
                    { 173, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9297), true, false, 15, 4, 17, 50, null, null },
                    { 174, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9297), true, false, 15, 5, 24, 50, null, null },
                    { 175, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9298), true, false, 15, 6, 28, 50, null, null },
                    { 176, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9299), true, false, 15, 7, 30, 50, null, null },
                    { 177, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9299), true, false, 16, 4, 18, 50, null, null },
                    { 178, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9300), true, false, 16, 5, 23, 50, null, null },
                    { 179, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9300), true, false, 16, 6, 27, 50, null, null },
                    { 180, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9301), true, false, 16, 7, 30, 50, null, null },
                    { 181, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9301), true, false, 17, 4, 19, 50, null, null },
                    { 182, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9302), true, false, 17, 5, 23, 50, null, null },
                    { 183, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9302), true, false, 17, 6, 27, 50, null, null },
                    { 184, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9303), true, false, 17, 7, 31, 50, null, null },
                    { 185, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9303), true, false, 18, 4, 20, 50, null, null },
                    { 186, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9304), true, false, 18, 5, 23, 50, null, null },
                    { 187, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9304), true, false, 18, 6, 27, 50, null, null },
                    { 188, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9330), true, false, 18, 7, 30, 50, null, null },
                    { 189, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9331), true, false, 19, 4, 21, 50, null, null },
                    { 190, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9331), true, false, 19, 5, 22, 50, null, null },
                    { 191, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9332), true, false, 19, 6, 27, 50, null, null },
                    { 192, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9333), true, false, 19, 7, 30, 50, null, null },
                    { 193, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9333), true, false, 20, 4, 16, 50, null, null },
                    { 194, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9334), true, false, 20, 5, 23, 50, null, null },
                    { 195, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9334), true, false, 20, 6, 26, 50, null, null },
                    { 196, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9335), true, false, 20, 7, 30, 50, null, null },
                    { 197, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9337), true, false, 21, 4, 32, 50, null, null },
                    { 198, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9338), true, false, 21, 5, 24, 50, null, null },
                    { 199, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9340), true, false, 21, 6, 28, 50, null, null },
                    { 200, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9341), true, false, 21, 7, 30, 50, null, null },
                    { 201, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9342), true, false, 22, 4, 21, 50, null, null },
                    { 202, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9343), true, false, 22, 5, 24, 50, null, null },
                    { 203, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9343), true, false, 22, 6, 26, 50, null, null },
                    { 204, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9344), true, false, 22, 7, 30, 50, null, null },
                    { 205, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9344), true, false, 23, 4, 36, 50, null, null },
                    { 206, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9345), true, false, 23, 5, 23, 50, null, null },
                    { 207, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9345), true, false, 23, 6, 26, 50, null, null },
                    { 208, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9346), true, false, 23, 7, 30, 50, null, null },
                    { 209, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9346), true, false, 24, 4, 16, 50, null, null },
                    { 210, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9348), true, false, 24, 5, 23, 50, null, null },
                    { 211, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9349), true, false, 24, 6, 27, 50, null, null },
                    { 212, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9349), true, false, 24, 7, 30, 50, null, null },
                    { 213, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9350), true, false, 25, 4, 15, 50, null, null },
                    { 214, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9350), true, false, 25, 5, 24, 50, null, null },
                    { 215, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9351), true, false, 25, 6, 28, 50, null, null },
                    { 216, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9351), true, false, 25, 7, 30, 50, null, null },
                    { 217, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9352), true, false, 26, 4, 19, 50, null, null },
                    { 218, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9352), true, false, 26, 5, 24, 50, null, null },
                    { 219, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9353), true, false, 26, 6, 26, 50, null, null },
                    { 220, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9354), true, false, 26, 7, 30, 50, null, null },
                    { 221, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9354), true, false, 27, 4, 15, 50, null, null },
                    { 222, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9355), true, false, 27, 5, 24, 50, null, null },
                    { 223, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9355), true, false, 27, 6, 28, 50, null, null },
                    { 224, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9356), true, false, 27, 7, 30, 50, null, null },
                    { 225, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9356), true, false, 28, 4, 33, 50, null, null },
                    { 226, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9357), true, false, 28, 5, 23, 50, null, null },
                    { 227, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9357), true, false, 28, 6, 27, 50, null, null },
                    { 228, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9358), true, false, 28, 7, 30, 50, null, null },
                    { 229, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9358), true, false, 29, 4, 21, 50, null, null },
                    { 230, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9359), true, false, 29, 5, 22, 50, null, null },
                    { 231, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9359), true, false, 29, 6, 27, 50, null, null },
                    { 232, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9360), true, false, 29, 7, 30, 50, null, null },
                    { 233, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9386), true, false, 30, 4, 21, 50, null, null },
                    { 234, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9386), true, false, 30, 5, 22, 50, null, null },
                    { 235, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9387), true, false, 30, 6, 27, 50, null, null },
                    { 236, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9388), true, false, 30, 7, 30, 50, null, null },
                    { 237, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9388), true, false, 31, 4, 16, 50, null, null },
                    { 238, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9389), true, false, 31, 5, 23, 50, null, null },
                    { 239, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9389), true, false, 31, 6, 12, 50, null, null },
                    { 240, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9390), true, false, 31, 7, 29, 50, null, null },
                    { 241, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9391), true, false, 32, 4, 19, 50, null, null },
                    { 242, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9391), true, false, 32, 5, 23, 50, null, null },
                    { 243, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9392), true, false, 32, 6, 28, 50, null, null },
                    { 244, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9392), true, false, 32, 7, 30, 50, null, null },
                    { 245, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9393), true, false, 33, 4, 19, 50, null, null },
                    { 246, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9394), true, false, 33, 5, 23, 50, null, null },
                    { 247, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9394), true, false, 33, 6, 27, 50, null, null },
                    { 248, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9395), true, false, 33, 7, 29, 50, null, null },
                    { 249, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9395), true, false, 34, 4, 35, 50, null, null },
                    { 250, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9396), true, false, 34, 5, 24, 50, null, null },
                    { 251, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9396), true, false, 34, 6, 28, 50, null, null },
                    { 252, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9397), true, false, 34, 7, 31, 50, null, null },
                    { 253, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9397), true, false, 35, 4, 19, 50, null, null },
                    { 254, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9398), true, false, 35, 5, 24, 50, null, null },
                    { 255, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9398), true, false, 35, 6, 26, 50, null, null },
                    { 256, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9399), true, false, 35, 7, 30, 50, null, null },
                    { 257, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9399), true, false, 36, 4, 34, 50, null, null },
                    { 258, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9400), true, false, 36, 5, 24, 50, null, null },
                    { 259, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9400), true, false, 36, 6, 28, 50, null, null },
                    { 260, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9401), true, false, 36, 7, 31, 50, null, null },
                    { 261, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9401), true, false, 37, 4, 17, 50, null, null },
                    { 262, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9402), true, false, 37, 5, 23, 50, null, null },
                    { 263, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9403), true, false, 37, 6, 26, 50, null, null },
                    { 264, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9403), true, false, 37, 7, 30, 50, null, null },
                    { 265, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9404), true, false, 38, 4, 19, 50, null, null },
                    { 266, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9404), true, false, 38, 5, 23, 50, null, null },
                    { 267, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9405), true, false, 38, 6, 28, 50, null, null },
                    { 268, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9405), true, false, 38, 7, 30, 50, null, null },
                    { 269, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9406), true, false, 39, 4, 36, 50, null, null },
                    { 270, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9406), true, false, 39, 5, 22, 50, null, null },
                    { 271, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9407), true, false, 39, 6, 27, 50, null, null },
                    { 272, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9407), true, false, 39, 7, 30, 50, null, null },
                    { 273, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9408), true, false, 40, 4, 19, 50, null, null },
                    { 274, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9408), true, false, 40, 5, 24, 50, null, null },
                    { 275, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9409), true, false, 40, 6, 28, 50, null, null },
                    { 276, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9409), true, false, 40, 7, 30, 50, null, null },
                    { 277, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9410), true, false, 41, 4, 16, 50, null, null },
                    { 278, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9410), true, false, 41, 5, 23, 50, null, null },
                    { 279, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9411), true, false, 41, 6, 12, 50, null, null },
                    { 280, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9411), true, false, 41, 7, 29, 50, null, null },
                    { 281, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9412), true, false, 42, 4, 21, 50, null, null },
                    { 282, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9412), true, false, 42, 5, 23, 50, null, null },
                    { 283, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9413), true, false, 42, 6, 26, 50, null, null },
                    { 284, null, new DateTime(2025, 3, 27, 21, 37, 26, 788, DateTimeKind.Local).AddTicks(9413), true, false, 42, 7, 30, 50, null, null }
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
