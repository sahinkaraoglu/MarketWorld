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
                    { 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(835), false, "Apple", null, null, null },
                    { 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(838), false, "Asus", null, null, null },
                    { 3, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(839), false, "Casper", null, null, null },
                    { 4, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(840), false, "HP", null, null, null },
                    { 5, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(841), false, "Lenovo", null, null, null },
                    { 6, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(843), false, "MSI", null, null, null },
                    { 7, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(844), false, "Acer", null, null, null },
                    { 8, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(845), false, "Xiaomi", null, null, null },
                    { 9, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(846), false, "Samsung", null, null, null },
                    { 10, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(848), false, "Huawei", null, null, null },
                    { 11, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(849), false, "Canon", null, null, null },
                    { 12, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(850), false, "Epson", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(521), "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar", false, "Elektronik", "elektronik", null, null },
                    { 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(535), "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları", false, "Giyim & Aksesuar", "giyim-aksesuar", null, null },
                    { 3, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(537), "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili", false, "Ev & Yaşam", "ev-yasam", null, null },
                    { 4, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(538), "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri", false, "Kozmetik & Kişisel Bakım", "kozmetik-kisisel-bakim", null, null },
                    { 5, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(540), "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri", false, "Spor & Outdoor", "spor-outdoor", null, null }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsActive", "IsDeleted", "Name", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5770), "Ürün Renk Seçenekleri", true, false, "Renk", null, null },
                    { 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5777), "Beden Seçenekleri", true, false, "Beden", null, null },
                    { 3, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5779), "Dahili Hafıza", true, false, "Hafıza", null, null },
                    { 4, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5780), "Bilgisayar İşlemci Seçenekleri", true, false, "İşlemci", null, null },
                    { 5, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5781), "Bellek Kapasitesi", true, false, "RAM", null, null },
                    { 6, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5784), "SSD Kapasitesi", true, false, "SSD", null, null },
                    { 7, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5785), "Ekran Boyutu", true, false, "Ekran", null, null },
                    { 8, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5786), "Yazıcı Teknolojisi", true, false, "Yazıcı Tipi", null, null },
                    { 9, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5787), "Mürekkep/Kartuş Sistemi", true, false, "Mürekkep Sistemi", null, null },
                    { 10, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5789), "Desteklenen Kağıt Boyutları", true, false, "Kağıt Boyutu", null, null },
                    { 11, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5791), "Yazıcı Fonksiyonları", true, false, "Fonksiyonlar", null, null }
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
                    { 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5823), true, false, 1, null, null, "Uzay Siyahı" },
                    { 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5862), true, false, 1, null, null, "Altın" },
                    { 3, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5864), true, false, 1, null, null, "Gümüş" },
                    { 4, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5865), true, false, 1, null, null, "Mor" },
                    { 5, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5866), true, false, 2, null, null, "XS" },
                    { 6, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5868), true, false, 2, null, null, "S" },
                    { 7, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5869), true, false, 2, null, null, "M" },
                    { 8, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5870), true, false, 2, null, null, "L" },
                    { 9, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5871), true, false, 2, null, null, "XL" },
                    { 10, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5873), true, false, 2, null, null, "XXL" },
                    { 11, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5874), true, false, 3, null, null, "128GB" },
                    { 12, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5875), true, false, 3, null, null, "256GB" },
                    { 13, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5877), true, false, 3, null, null, "512GB" },
                    { 14, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5879), true, false, 3, null, null, "1TB" },
                    { 15, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5882), true, false, 4, null, null, "Intel Core i7 12700H" },
                    { 16, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5885), true, false, 4, null, null, "Intel Core i7 1255U" },
                    { 17, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5887), true, false, 4, null, null, "Intel Core i7 13620H" },
                    { 18, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5890), true, false, 4, null, null, "Intel Core i5 1334U" },
                    { 19, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5891), true, false, 4, null, null, "Intel Core i5 13420H" },
                    { 20, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5892), true, false, 4, null, null, "AMD Ryzen 7 5700U" },
                    { 21, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5893), true, false, 4, null, null, "Intel Core i5 12450H" },
                    { 22, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5895), true, false, 5, null, null, "8GB" },
                    { 23, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5896), true, false, 5, null, null, "16GB" },
                    { 24, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5897), true, false, 5, null, null, "32GB" },
                    { 25, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5898), true, false, 6, null, null, "256GB" },
                    { 26, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5899), true, false, 6, null, null, "500GB" },
                    { 27, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5900), true, false, 6, null, null, "512GB" },
                    { 28, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5901), true, false, 6, null, null, "1TB" },
                    { 29, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5902), true, false, 7, null, null, "14\"" },
                    { 30, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5903), true, false, 7, null, null, "15.6\"" },
                    { 31, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5904), true, false, 7, null, null, "16\"" },
                    { 32, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5905), true, false, 4, null, null, "Intel Core i7 13650HX" },
                    { 33, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5906), true, false, 4, null, null, "Intel Core i5 13500H" },
                    { 34, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5908), true, false, 4, null, null, "Intel Core i9-14900HX" },
                    { 35, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5909), true, false, 4, null, null, "Intel Core Ultra 7 255HX" },
                    { 36, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5911), true, false, 4, null, null, "AMD Ryzen 5 7520U" },
                    { 37, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5912), true, false, 8, null, null, "Mürekkep Püskürtmeli" },
                    { 38, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5913), true, false, 8, null, null, "Lazer" },
                    { 39, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5914), true, false, 8, null, null, "Süblimasyon" },
                    { 40, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5916), true, false, 9, null, null, "Kartuşlu" },
                    { 41, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5917), true, false, 9, null, null, "Tanklı" },
                    { 42, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5918), true, false, 9, null, null, "Dolum Üniteli" },
                    { 43, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5919), true, false, 10, null, null, "A4" },
                    { 44, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5921), true, false, 10, null, null, "A3" },
                    { 45, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5922), true, false, 10, null, null, "A4/A3" },
                    { 46, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5923), true, false, 11, null, null, "Yazdırma" },
                    { 47, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5924), true, false, 11, null, null, "Tarama" },
                    { 48, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5925), true, false, 11, null, null, "Fotokopi" },
                    { 49, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5926), true, false, 11, null, null, "Faks" },
                    { 50, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5927), true, false, 11, null, null, "Wi-Fi" },
                    { 51, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5928), true, false, 11, null, null, "AirPrint" },
                    { 52, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5929), true, false, 1, null, null, "Siyah" },
                    { 53, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5930), true, false, 1, null, null, "Beyaz" },
                    { 54, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(5932), true, false, 1, null, null, "Gri" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedDate", "Description", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(735), "Dizüstü, masaüstü bilgisayarlar ve tabletler", false, "Bilgisayarlar & Tabletler", "bilgisayarlar-tabletler", null, null },
                    { 2, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(737), "Yazıcılar, tarayıcılar ve projeksiyon cihazları", false, "Yazıcılar & Projeksiyon", "yazicilar-projeksiyon", null, null },
                    { 3, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(739), "Akıllı telefonlar ve aksesuarları", false, "Telefonlar", "telefonlar", null, null },
                    { 4, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(740), "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar", false, "Beyaz Eşya", "beyaz-esya", null, null },
                    { 5, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(741), "Klimalar, ısıtıcılar ve hava temizleyiciler", false, "Klima ve Isıtıcılar", "klima-isitici", null, null },
                    { 6, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(743), "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar", false, "Ayakkabı & Çanta", "ayakkabi-canta", null, null },
                    { 7, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(771), "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim", false, "Kadın Giyim", "kadin-giyim", null, null },
                    { 8, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(773), "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim", false, "Erkek Giyim", "erkek-giyim", null, null },
                    { 9, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(774), "Kız ve erkek çocuk giyim ürünleri", false, "Çocuk Giyim", "cocuk-giyim", null, null },
                    { 10, 3, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(776), "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları", false, "Mobilya", "mobilya", null, null },
                    { 11, 3, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(777), "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri", false, "Ev Tekstili", "ev-tekstili", null, null },
                    { 12, 3, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(778), "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri", false, "Dekorasyon & Aydınlatma", "dekorasyon-aydinlatma", null, null },
                    { 13, 3, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(780), "Pişirme, servis ve saklama ürünleri, mutfak aletleri", false, "Mutfak Gereçleri", "mutfak-gerecleri", null, null },
                    { 14, 3, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(781), "Banyo aksesuarları, temizlik ve düzenleme ürünleri", false, "Banyo & Ev Gereçleri", "banyo-ev-gerecleri", null, null },
                    { 15, 3, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(782), "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri", false, "Kırtasiye & Ofis", "kirtasiye-ve-ofis", null, null },
                    { 16, 4, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(783), "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri", false, "Parfüm & Deodorant", "parfum-deodorant", null, null },
                    { 17, 4, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(785), "Saç bakım ve şekillendirme ürünleri", false, "Saç Şekillendirme", "sac-sekillendirme", null, null },
                    { 18, 4, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(786), "Yüz ve vücut bakım ürünleri, kremler ve serumlar", false, "Cilt Bakımı", "cilt-bakimi", null, null },
                    { 19, 4, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(787), "Renkli kozmetik ve makyaj malzemeleri", false, "Makyaj", "makyaj", null, null },
                    { 20, 4, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(789), "Vitamin, takviye gıdalar ve medikal ürünler", false, "Sağlık & Medikal Ürünler", "saglik-medikal-urunler", null, null },
                    { 21, 4, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(791), "Diş bakım ürünleri ve ağız bakım ürünleri", false, "Ağız & Diş Bakımı", "agiz-dis-bakimi", null, null },
                    { 22, 5, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(793), "Fitness ekipmanları, kondisyon aletleri ve aksesuarları", false, "Fitness & Kondisyon", "fitness-kondisyon", null, null },
                    { 23, 5, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(794), "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar", false, "Spor Giyim & Ayakkabı", "spor-giyim-ayakkabi", null, null },
                    { 24, 5, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(795), "Kamp malzemeleri, outdoor giyim ve ekipmanlar", false, "Outdoor & Kamp", "outdoor-kamp", null, null },
                    { 25, 5, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(796), "Kayak ekipmanları ve kış sporları malzemeleri", false, "Kış Sporları", "kis-sporlari", null, null },
                    { 26, 5, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(798), "Yüzme ve su sporları ekipmanları", false, "Su Sporları", "su-sporlari", null, null }
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
                    { 1, 3, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(885), "Intel Core i7 12700H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1270", 39999.99m, 4.5m, 100, 1, null, null },
                    { 2, 6, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(889), "Intel Core i7 1255U 16GB 512GB SSD Freedos 14\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "MSI Modern 14 C12MO", 21799.99m, 4.5m, 75, 1, null, null },
                    { 3, 3, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(894), "Core i7-13620H 32GB DDR5 RAM 1TB NVME SSD 16\" Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana S100", 27299.99m, 5m, 50, 1, null, null },
                    { 4, 3, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(897), "Intel Core i7 13620H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1362", 50199.99m, 4.5m, 60, 1, null, null },
                    { 5, 4, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(899), "Intel Core i5 1334U 16GB 512GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "HP 250 G10", 14999.99m, 4.7m, 100, 1, null, null },
                    { 6, 5, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(902), "Intel Core i5 13420H 16GB Ddr5 Ram 512 GB SSD 16'' WUXGA IPS Panel Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad Slim 3", 19799.99m, 4.9m, 80, 1, null, null },
                    { 7, 5, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(905), "AMD Ryzen 7 5700U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad 1", 15999.99m, 4.6m, 90, 1, null, null },
                    { 8, 6, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(907), "Intel Core i5 12450H 8GB 512GB SSD RTX2050 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "MSI Thin 15", 24799.99m, 4.5m, 70, 1, null, null },
                    { 9, 3, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(955), "Intel Core i7 1255U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana C550", 18999.99m, 4.5m, 85, 1, null, null },
                    { 10, 5, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(958), "Intel Core i7 13650HX 32GB 1TB SSD RTX 4060 8GB (115W) 15.6\" FHD 144Hz IPS Panel Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo LOQ 15IRX9", 59999.99m, 5m, 45, 1, null, null },
                    { 11, 3, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(961), "Intel Core i5-12450H 32GB RAM 500GB SSD GEN4 RTX3050 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G770", 31299.99m, 4.6m, 65, 1, null, null },
                    { 12, 3, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(963), "AMD Ryzen 5 7430U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana X600", 16999.99m, 5m, 80, 1, null, null },
                    { 13, 7, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(965), "Intel Core i7 1255U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Acer Aspire 3", 24000.00m, 5m, 70, 1, null, null },
                    { 14, 3, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(968), "Intel Core i7 12700H 32GB 1TB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana X600.1270", 22999.99m, 4.5m, 85, 1, null, null },
                    { 15, 3, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(970), "Intel Core i5-13420H 32GB RAM 500GB NVME SSD GEN4 6GB RTX4050 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G870.1342", 38499.99m, 4.1m, 55, 1, null, null },
                    { 16, 3, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(974), "Intel Core i7 12700H 32GB 1TB SSD RTX4070 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1270", 50899.99m, 4m, 40, 1, null, null },
                    { 17, 4, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(976), "Intel Core i5 13500H 16GB 512GB SSD RTX4050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "HP Victus Gaming 15", 33999.99m, 4.6m, 90, 1, null, null },
                    { 18, 5, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(979), "Intel Core i5 12450H 8GB 512GB SSD 15.6\" FHD Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo IdeaPad Slim 3", 15359.04m, 4.7m, 100, 1, null, null },
                    { 19, 2, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(982), "Intel Core i5 12500H 8GB 512GB SSD RTX3050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Asus TUF Gaming F15", 29898.66m, 4.7m, 75, 1, null, null },
                    { 20, 1, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(984), "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Uzay Grisi", 0m, false, true, false, "Apple MacBook Air M1", 39250.00m, 4.9m, 60, 1, null, null },
                    { 21, 3, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(986), "Intel Core i5-13420H 16GB RAM 1TB NVME SSD 8GB RTX4060 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G870.1342", 42299.99m, 4.3m, 50, 1, null, null },
                    { 22, 5, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(989), "Intel Core i5 13420H 16GB 512GB SSD Freedos 14\" WUXGA Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad 5", 29999.99m, 5m, 70, 1, null, null },
                    { 23, 2, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(992), "Intel Core Ultra 7 255HX 32GB 1TB SSD RTX5070Ti Freedos 16\" Taşınabilir Bilgisayar", 0m, false, true, false, "Asus ROG Strix G16", 107999.99m, 5m, 25, 1, null, null },
                    { 24, 3, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(994), "Intel Core i5-13420H 32GB RAM 500GB NVME SSD Freedos", 0m, false, true, false, "Casper Nirvana X600.1342", 19999.99m, 5m, 85, 1, null, null },
                    { 25, 5, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(996), "Intel Core i9-14900HX 32GB DDR5 1TB SSD RTX4060 8GB 16 inç 3.2K (3200×2000) 165Hz FreeDos Laptop", 0m, false, true, false, "Lenovo Thinkbook 16PG5", 79999.40m, 4.7m, 30, 1, null, null },
                    { 26, 3, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(999), "Intel Core i7-13620H 16GB RAM 500GB NVME SSD Freedos Laptop", 0m, false, true, false, "Casper Nirvana X600.1362", 22099.99m, 5m, 75, 1, null, null },
                    { 27, 6, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1001), "Intel Core i5 13420H 16GB 1TB SSD RTX4060 Freedos 15.6\" FHD 144Hz Taşınabilir Bilgisayar", 0m, false, true, false, "MSI CYBORG 15", 37999.99m, 4.9m, 60, 1, null, null },
                    { 28, 5, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1003), "AMD Ryzen 5 7520U 8gb 512GB SSD Freedos 15.6\" Fhd Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo V15 G4", 13299.99m, 4.3m, 95, 1, null, null },
                    { 29, 5, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1006), "I5-13420H 32GB 1 Tb SSD 15.6 Fhd Windows 11 Pro", 0m, false, true, false, "Lenovo V15 G4", 27749.00m, 5m, 70, 1, null, null },
                    { 30, 1, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1009), "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Gece Yarısı", 0m, false, true, false, "Apple MacBook Air M4", 49999.99m, 5m, 45, 1, null, null },
                    { 31, 3, 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1011), "Intel Core i5 12450H 16GB 500GB SSD RTX2050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1245", 27499.99m, 4.4m, 80, 1, null, null },
                    { 32, 4, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1014), "HP Deskjet Ink Advantage 2878 All-In-One Yazıcı", 0m, false, true, false, "HP Deskjet Ink Advantage 2878 All-In-One Yazıcı", 2799.00m, 4.1m, 100, 2, null, null },
                    { 33, 11, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1016), "Canon Dolan Kartuşlu E414 Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Canon Dolan Kartuşlu E414 Yazıcı", 2299.08m, 4.4m, 150, 2, null, null },
                    { 34, 11, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1019), "Canon Pixma TR4650 Tarayıcı + Fotokopi + Wi-Fi + Faks + Çok Fonksiyonlu Yazıcı", 0m, false, true, false, "Canon Pixma TR4650", 3379.00m, 4.2m, 75, 2, null, null },
                    { 35, 11, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1021), "Canon Pixma E3640 Wi-Fi Tarayıcı - Fotokopi Çok Fonksiyonlu Mürekkep Püskürtmeli Yazıcı", 0m, false, true, false, "Canon Pixma E3640 Wi-Fi", 3399.00m, 4.6m, 120, 2, null, null },
                    { 36, 12, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1025), "Epson L5290 Wi-Fi Renk Tanklı Yazıcı", 0m, false, true, false, "Epson L5290 Wi-Fi Renk Tanklı Yazıcı", 11983.51m, 4.4m, 60, 2, null, null },
                    { 37, 12, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1027), "Epson Tanklı L3150 Photoink Muadil Mürekkepli Tanklı Yazıcı", 0m, false, true, false, "Epson Tanklı L3150 Photoink", 6033.86m, 4.6m, 90, 2, null, null },
                    { 38, 4, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1029), "HP Officejet Pro 7720 Fotokopi + Faks + Tarayıcı + Wi-Fi + Airprint + A3 Yazıcı", 0m, false, true, false, "HP Officejet Pro 7720", 11138.06m, 4.6m, 45, 2, null, null },
                    { 39, 11, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1074), "Canon E3640 Wifi Yazıcı ve Tıpalı Kartuş Sistemi", 0m, false, true, false, "Canon E3640 Wifi Yazıcı", 3306.56m, 4.3m, 100, 2, null, null },
                    { 40, 12, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1077), "Epson L3151 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L3151 Tanklı Yazıcı", 4999.00m, 4.5m, 120, 2, null, null },
                    { 41, 4, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1080), "HP LaserJet Pro M428f MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428f", 7999.00m, 4.3m, 80, 2, null, null },
                    { 42, 11, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1082), "Canon PIXMA G3110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G3110", 3999.00m, 4.4m, 150, 2, null, null },
                    { 43, 12, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1086), "Epson L3250 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L3250 Tanklı Yazıcı", 4499.00m, 4.6m, 100, 2, null, null },
                    { 44, 4, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1088), "HP LaserJet Pro M428dw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428dw", 8999.00m, 4.5m, 60, 2, null, null },
                    { 45, 11, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1090), "Canon PIXMA G4110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G4110", 4499.00m, 4.3m, 90, 2, null, null },
                    { 46, 12, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1093), "Epson L4260 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4260 Tanklı Yazıcı", 5499.00m, 4.7m, 75, 2, null, null },
                    { 47, 4, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1095), "HP LaserJet Pro M428fnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fnw", 9999.00m, 4.4m, 50, 2, null, null },
                    { 48, 11, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1098), "Canon PIXMA G5110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G5110", 4999.00m, 4.5m, 110, 2, null, null },
                    { 49, 12, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1101), "Epson L4266 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4266 Tanklı Yazıcı", 5999.00m, 4.6m, 85, 2, null, null },
                    { 50, 4, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1104), "HP LaserJet Pro M428fdw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdw", 10999.00m, 4.5m, 45, 2, null, null },
                    { 51, 11, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1107), "Canon PIXMA G6110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G6110", 5499.00m, 4.4m, 95, 2, null, null },
                    { 52, 12, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1109), "Epson L4268 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4268 Tanklı Yazıcı", 6499.00m, 4.7m, 70, 2, null, null },
                    { 53, 4, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1112), "HP LaserJet Pro M428fdn MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdn", 11999.00m, 4.6m, 40, 2, null, null },
                    { 54, 11, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1115), "Canon PIXMA G7110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G7110", 5999.00m, 4.5m, 80, 2, null, null },
                    { 55, 12, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1118), "Epson L4269 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4269 Tanklı Yazıcı", 6999.00m, 4.8m, 60, 2, null, null },
                    { 56, 4, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1120), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 12999.00m, 4.7m, 35, 2, null, null },
                    { 57, 11, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1122), "Canon PIXMA G8110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G8110", 6499.00m, 4.6m, 70, 2, null, null },
                    { 58, 12, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1124), "Epson L4267 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4267 Tanklı Yazıcı", 7499.00m, 4.9m, 50, 2, null, null },
                    { 59, 4, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1127), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 13999.00m, 4.8m, 30, 2, null, null },
                    { 60, 11, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1129), "Canon PIXMA G9110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G9110", 6999.00m, 4.7m, 60, 2, null, null },
                    { 61, 12, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1131), "Epson L4265 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4265 Tanklı Yazıcı", 7999.00m, 4.8m, 45, 2, null, null },
                    { 62, 4, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1134), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 14999.00m, 4.9m, 25, 2, null, null },
                    { 63, 11, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1137), "Canon PIXMA G1010 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1010", 7499.00m, 4.8m, 50, 2, null, null },
                    { 64, 12, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1139), "Epson L4264 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4264 Tanklı Yazıcı", 8499.00m, 4.9m, 40, 2, null, null },
                    { 65, 4, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1141), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 15999.00m, 5.0m, 20, 2, null, null },
                    { 66, 11, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1144), "Canon PIXMA G1110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1110", 7999.00m, 4.9m, 45, 2, null, null },
                    { 67, 12, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1147), "Epson L4263 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4263 Tanklı Yazıcı", 8999.00m, 5.0m, 35, 2, null, null },
                    { 68, 4, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1149), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 16999.00m, 5.0m, 15, 2, null, null },
                    { 69, 11, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1205), "Canon PIXMA G1210 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1210", 8499.00m, 5.0m, 40, 2, null, null },
                    { 70, 12, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1208), "Epson L4262 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4262 Tanklı Yazıcı", 9499.00m, 5.0m, 30, 2, null, null },
                    { 71, 4, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1210), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 17999.00m, 5.0m, 10, 2, null, null },
                    { 72, 11, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1213), "Canon PIXMA G1310 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1310", 8999.00m, 5.0m, 35, 2, null, null },
                    { 73, 12, 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1215), "Epson L4261 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4261 Tanklı Yazıcı", 9999.00m, 5.0m, 25, 2, null, null }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "EntityId", "EntityType", "IsDeleted", "Path", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1277), 1, 1, false, "img/Products/Laptops/Casper_G870.1270.jpg", null, null },
                    { 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1280), 2, 1, false, "img/Products/Laptops/MSI_15.6.jpg", null, null },
                    { 3, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1282), 3, 1, false, "img/Products/Laptops/Casper_S100.1362.jpg", null, null },
                    { 4, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1283), 4, 1, false, "img/Products/Laptops/Casper_G870.1362.jpg", null, null },
                    { 5, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1284), 5, 1, false, "img/Products/Laptops/HP_15.6.jpg", null, null },
                    { 6, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1286), 6, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 7, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1288), 7, 1, false, "img/Products/Laptops/Lenovo_model.jpg", null, null },
                    { 8, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1289), 8, 1, false, "img/Products/Laptops/MSI_model.jpg", null, null },
                    { 9, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1290), 9, 1, false, "img/Products/Laptops/Casper_C550.1255.jpg", null, null },
                    { 10, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1292), 10, 1, false, "img/Products/Laptops/Lenovo_3.2.jpg", null, null },
                    { 11, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1293), 11, 1, false, "img/Products/Laptops/Casper_G770.1245.jpg", null, null },
                    { 12, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1295), 12, 1, false, "img/Products/Laptops/Casper_X600.7430.jpg", null, null },
                    { 13, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1296), 13, 1, false, "img/Products/Laptops/Acer_15.6.jpg", null, null },
                    { 14, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1297), 14, 1, false, "img/Products/Laptops/Casper_X600.1270.jpg", null, null },
                    { 15, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1298), 15, 1, false, "img/Products/Laptops/Casper_G870.1342.jpg", null, null },
                    { 16, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1299), 16, 1, false, "img/Products/Laptops/Casper_G870.1270.jpg", null, null },
                    { 17, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1301), 17, 1, false, "img/Products/Laptops/HP_15.6.jpg", null, null },
                    { 18, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1303), 18, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 19, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1304), 19, 1, false, "img/Products/Laptops/Asus_15.6.jpg", null, null },
                    { 20, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1305), 20, 1, false, "img/Products/Laptops/Apple_model.jpg", null, null },
                    { 21, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1307), 21, 1, false, "img/Products/Laptops/Casper_G870.1342.jpg", null, null },
                    { 22, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1309), 22, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 23, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1312), 23, 1, false, "img/Products/Laptops/Asus_model.jpg", null, null },
                    { 24, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1313), 24, 1, false, "img/Products/Laptops/Casper_X600.1342.jpg", null, null },
                    { 25, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1316), 25, 1, false, "img/Products/Laptops/Lenovo_3.2.jpg", null, null },
                    { 26, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1317), 26, 1, false, "img/Products/Laptops/Casper_X600.1362.jpg", null, null },
                    { 27, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1318), 27, 1, false, "img/Products/Laptops/MSI_15.6.jpg", null, null },
                    { 28, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1319), 28, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 29, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1321), 29, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 30, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1322), 30, 1, false, "img/Products/Laptops/Apple_model.jpg", null, null },
                    { 31, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1323), 31, 1, false, "img/Products/Laptops/Casper_G870.1245.jpg", null, null },
                    { 32, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1324), 32, 1, false, "img/Products/PrintersandScanner/hp_hp_deskjet_ink_advantage_2878_allinone_yazc.jpg", null, null },
                    { 33, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1330), 33, 1, false, "img/Products/PrintersandScanner/canon_dolan_kartulu_e414_yazc_tarayc_fotokopi.jpg", null, null },
                    { 34, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1332), 34, 1, false, "img/Products/PrintersandScanner/canon_pixma_tr4650_tarayc_fotokopi_wifi_faks_ok_fonksiyonlu_yazc_canon_eurasia_garantili.jpg", null, null },
                    { 35, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1363), 35, 1, false, "img/Products/PrintersandScanner/canon_pixma_e3640_wifi_tarayc_fotokopi_ok_fonksiyonlu_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 36, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1365), 36, 1, false, "img/Products/PrintersandScanner/epson_l5290_wifi_renk_tankl_yazc.jpg", null, null },
                    { 37, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1366), 37, 1, false, "img/Products/PrintersandScanner/epson_tankl_l3150_photoink_muadil_mrekkepli_tankl_yazc_1_siyah_mrekkep_ve_fotoraf_kad_hediyeli.jpg", null, null },
                    { 38, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1368), 38, 1, false, "img/Products/PrintersandScanner/hp_officejet_pro_7720_fotokopi_faks_tarayc_wifi_airprint_a3_yazc_y0s18a.jpg", null, null },
                    { 39, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1371), 39, 1, false, "img/Products/PrintersandScanner/canon_e3640_wifi_yazc_ve_tpal_kartu_sistemi.jpg", null, null },
                    { 40, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1374), 40, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_l3250_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 41, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1377), 41, 1, false, "img/Products/PrintersandScanner/enp_canon_mf264dw_lazer_yazc_tarayc_fotokopi_wifi_lan_duplex.jpg", null, null },
                    { 42, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1380), 42, 1, false, "img/Products/PrintersandScanner/canon_pxma_g3430_renkli_mrekkep_mega_tankl_yazc_tarayc_fotokopi_wifi_1_ie_orijinal_siyah_mrekkep_hed.jpg", null, null },
                    { 43, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1382), 43, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_l3250_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 44, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1384), 44, 1, false, "img/Products/PrintersandScanner/canon_isensys_mf453dw_wf_ok_fonksiyonlu_lazer_yazc.jpg", null, null },
                    { 45, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1385), 45, 1, false, "img/Products/PrintersandScanner/canon_pixma_e3440_dolabilen_kartu_sistemli_yazc.jpg", null, null },
                    { 46, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1388), 46, 1, false, "img/Products/PrintersandScanner/epson_l6550_color_tankl_wifi_a4_yazc_fotokopi_tarayc_fax.jpg", null, null },
                    { 47, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1390), 47, 1, false, "img/Products/PrintersandScanner/hp_deskjet_2632_wifi_tarayc_fotokopi_renkli_ok_fonksiyonlu_mrekkep_pskrtmeli_yazc_v1n05b.jpg", null, null },
                    { 48, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1391), 48, 1, false, "img/Products/PrintersandScanner/canon_pixma_e514_fotokopi_tarayc_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 49, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1392), 49, 1, false, "img/Products/PrintersandScanner/epson_epson_ecotank_l11050_a3_tek_fonk_yazici.jpg", null, null },
                    { 50, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1394), 50, 1, false, "img/Products/PrintersandScanner/hp_hp_6uu47a_smart_tank_750_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 51, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1395), 51, 1, false, "img/Products/PrintersandScanner/canon_gx6040_yazctaraycfotokopi_renkli_mrekkep_tankl_yazc_wifi_ethernet.jpg", null, null },
                    { 52, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1396), 52, 1, false, "img/Products/PrintersandScanner/epson_surecolor_sc_f100_mrekkep_pskrtme_sblimasyon_yazc.jpg", null, null },
                    { 53, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1397), 53, 1, false, "img/Products/PrintersandScanner/hp_deskjet_1516_fotokopi_tarayc_yazc_b2l60c.jpg", null, null },
                    { 54, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1398), 54, 1, false, "img/Products/PrintersandScanner/canon_ix6850_renkli_inkjet_a3_fotoraf_yazcswifi_canon_eurasia_garantili.jpg", null, null },
                    { 55, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1403), 55, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 56, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1404), 56, 1, false, "img/Products/PrintersandScanner/hp_officejet_j4500_wifi_faxl_ok_fonksiyonlu_renkli_yazc_cn547a.jpg", null, null },
                    { 57, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1405), 57, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 58, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1406), 58, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_m1170_yazc_a4.jpg", null, null },
                    { 59, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1408), 59, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_wifi_ok_fonksiyonlu_yazc_bitmeyen_kartu_siyah_depo.jpg", null, null },
                    { 60, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1410), 60, 1, false, "img/Products/PrintersandScanner/canon_pixma_mg3050bk_wifi_fotokopi_tarayc_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 61, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1411), 61, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 62, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1413), 62, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 63, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1416), 63, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 64, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1417), 64, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 65, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1418), 65, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 66, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1421), 66, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 67, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1422), 67, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 68, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1425), 68, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 69, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1427), 69, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 70, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1428), 70, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 71, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1429), 71, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 72, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1431), 72, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 73, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(1432), 73, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductProperties",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "ProductId", "PropertyTypeId", "PropertyValueId", "Stock", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6034), true, false, 1, 1, 1, 50, null, null },
                    { 2, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6037), true, false, 1, 1, 2, 50, null, null },
                    { 3, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6037), true, false, 1, 1, 3, 50, null, null },
                    { 4, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6038), true, false, 1, 1, 4, 50, null, null },
                    { 5, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6040), true, false, 1, 4, 15, 50, null, null },
                    { 6, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6043), true, false, 1, 5, 24, 50, null, null },
                    { 7, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6046), true, false, 1, 6, 28, 50, null, null },
                    { 8, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6049), true, false, 1, 7, 30, 50, null, null },
                    { 9, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6050), true, false, 2, 1, 1, 50, null, null },
                    { 10, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6051), true, false, 2, 1, 2, 50, null, null },
                    { 11, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6052), true, false, 2, 1, 3, 50, null, null },
                    { 12, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6052), true, false, 2, 1, 4, 50, null, null },
                    { 13, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6053), true, false, 2, 4, 16, 50, null, null },
                    { 14, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6053), true, false, 2, 5, 23, 50, null, null },
                    { 15, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6054), true, false, 2, 6, 27, 50, null, null },
                    { 16, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6055), true, false, 2, 7, 29, 50, null, null },
                    { 17, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6056), true, false, 3, 1, 1, 50, null, null },
                    { 18, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6057), true, false, 3, 1, 2, 50, null, null },
                    { 19, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6057), true, false, 3, 1, 3, 50, null, null },
                    { 20, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6058), true, false, 3, 1, 4, 50, null, null },
                    { 21, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6058), true, false, 3, 4, 17, 50, null, null },
                    { 22, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6059), true, false, 3, 5, 24, 50, null, null },
                    { 23, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6060), true, false, 3, 6, 28, 50, null, null },
                    { 24, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6060), true, false, 3, 7, 31, 50, null, null },
                    { 25, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6061), true, false, 4, 1, 1, 50, null, null },
                    { 26, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6061), true, false, 4, 1, 2, 50, null, null },
                    { 27, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6062), true, false, 4, 1, 3, 50, null, null },
                    { 28, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6062), true, false, 4, 1, 4, 50, null, null },
                    { 29, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6063), true, false, 4, 4, 17, 50, null, null },
                    { 30, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6064), true, false, 4, 5, 24, 50, null, null },
                    { 31, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6064), true, false, 4, 6, 28, 50, null, null },
                    { 32, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6065), true, false, 4, 7, 30, 50, null, null },
                    { 33, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6065), true, false, 5, 1, 1, 50, null, null },
                    { 34, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6067), true, false, 5, 1, 2, 50, null, null },
                    { 35, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6067), true, false, 5, 1, 3, 50, null, null },
                    { 36, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6067), true, false, 5, 1, 4, 50, null, null },
                    { 37, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6068), true, false, 5, 4, 18, 50, null, null },
                    { 38, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6069), true, false, 5, 5, 23, 50, null, null },
                    { 39, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6069), true, false, 5, 6, 27, 50, null, null },
                    { 40, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6070), true, false, 5, 7, 30, 50, null, null },
                    { 41, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6070), true, false, 6, 1, 1, 50, null, null },
                    { 42, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6071), true, false, 6, 1, 2, 50, null, null },
                    { 43, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6071), true, false, 6, 1, 3, 50, null, null },
                    { 44, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6072), true, false, 6, 1, 4, 50, null, null },
                    { 45, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6072), true, false, 6, 4, 19, 50, null, null },
                    { 46, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6073), true, false, 6, 5, 23, 50, null, null },
                    { 47, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6074), true, false, 6, 6, 27, 50, null, null },
                    { 48, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6096), true, false, 6, 7, 31, 50, null, null },
                    { 49, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6096), true, false, 7, 1, 1, 50, null, null },
                    { 50, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6097), true, false, 7, 1, 2, 50, null, null },
                    { 51, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6097), true, false, 7, 1, 3, 50, null, null },
                    { 52, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6098), true, false, 7, 1, 4, 50, null, null },
                    { 53, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6099), true, false, 7, 4, 20, 50, null, null },
                    { 54, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6100), true, false, 7, 5, 23, 50, null, null },
                    { 55, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6100), true, false, 7, 6, 27, 50, null, null },
                    { 56, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6101), true, false, 7, 7, 30, 50, null, null },
                    { 57, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6102), true, false, 8, 1, 1, 50, null, null },
                    { 58, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6102), true, false, 8, 1, 2, 50, null, null },
                    { 59, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6103), true, false, 8, 1, 3, 50, null, null },
                    { 60, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6103), true, false, 8, 1, 4, 50, null, null },
                    { 61, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6104), true, false, 8, 4, 21, 50, null, null },
                    { 62, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6105), true, false, 8, 5, 22, 50, null, null },
                    { 63, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6105), true, false, 8, 6, 27, 50, null, null },
                    { 64, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6106), true, false, 8, 7, 30, 50, null, null },
                    { 65, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6107), true, false, 9, 1, 1, 50, null, null },
                    { 66, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6108), true, false, 9, 1, 2, 50, null, null },
                    { 67, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6108), true, false, 9, 1, 3, 50, null, null },
                    { 68, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6109), true, false, 9, 1, 4, 50, null, null },
                    { 69, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6109), true, false, 9, 4, 16, 50, null, null },
                    { 70, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6110), true, false, 9, 5, 23, 50, null, null },
                    { 71, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6111), true, false, 9, 6, 26, 50, null, null },
                    { 72, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6111), true, false, 9, 7, 30, 50, null, null },
                    { 73, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6112), true, false, 10, 1, 1, 50, null, null },
                    { 74, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6112), true, false, 10, 1, 2, 50, null, null },
                    { 75, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6112), true, false, 10, 1, 3, 50, null, null },
                    { 76, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6113), true, false, 10, 1, 4, 50, null, null },
                    { 77, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6114), true, false, 10, 4, 32, 50, null, null },
                    { 78, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6114), true, false, 10, 5, 24, 50, null, null },
                    { 79, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6115), true, false, 10, 6, 28, 50, null, null },
                    { 80, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6115), true, false, 10, 7, 30, 50, null, null },
                    { 81, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6116), true, false, 11, 1, 1, 50, null, null },
                    { 82, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6116), true, false, 11, 1, 2, 50, null, null },
                    { 83, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6117), true, false, 11, 1, 3, 50, null, null },
                    { 84, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6117), true, false, 11, 1, 4, 50, null, null },
                    { 85, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6118), true, false, 11, 4, 21, 50, null, null },
                    { 86, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6119), true, false, 11, 5, 24, 50, null, null },
                    { 87, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6119), true, false, 11, 6, 26, 50, null, null },
                    { 88, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6120), true, false, 11, 7, 30, 50, null, null },
                    { 89, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6120), true, false, 12, 1, 1, 50, null, null },
                    { 90, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6121), true, false, 12, 1, 2, 50, null, null },
                    { 91, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6121), true, false, 12, 1, 3, 50, null, null },
                    { 92, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6122), true, false, 12, 1, 4, 50, null, null },
                    { 93, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6122), true, false, 12, 4, 36, 50, null, null },
                    { 94, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6123), true, false, 12, 5, 23, 50, null, null },
                    { 95, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6124), true, false, 12, 6, 26, 50, null, null },
                    { 96, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6124), true, false, 12, 7, 30, 50, null, null },
                    { 97, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6125), true, false, 13, 1, 1, 50, null, null },
                    { 98, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6125), true, false, 13, 1, 2, 50, null, null },
                    { 99, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6170), true, false, 13, 1, 3, 50, null, null },
                    { 100, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6172), true, false, 13, 1, 4, 50, null, null },
                    { 101, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6173), true, false, 13, 4, 16, 50, null, null },
                    { 102, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6174), true, false, 13, 5, 23, 50, null, null },
                    { 103, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6174), true, false, 13, 6, 27, 50, null, null },
                    { 104, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6175), true, false, 13, 7, 30, 50, null, null },
                    { 105, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6176), true, false, 14, 1, 1, 50, null, null },
                    { 106, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6176), true, false, 14, 1, 2, 50, null, null },
                    { 107, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6176), true, false, 14, 1, 3, 50, null, null },
                    { 108, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6177), true, false, 14, 1, 4, 50, null, null },
                    { 109, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6178), true, false, 14, 4, 15, 50, null, null },
                    { 110, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6178), true, false, 14, 5, 24, 50, null, null },
                    { 111, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6179), true, false, 14, 6, 28, 50, null, null },
                    { 112, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6180), true, false, 14, 7, 30, 50, null, null },
                    { 113, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6180), true, false, 15, 1, 1, 50, null, null },
                    { 114, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6181), true, false, 15, 1, 2, 50, null, null },
                    { 115, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6181), true, false, 15, 1, 3, 50, null, null },
                    { 116, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6182), true, false, 15, 1, 4, 50, null, null },
                    { 117, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6182), true, false, 15, 4, 19, 50, null, null },
                    { 118, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6183), true, false, 15, 5, 24, 50, null, null },
                    { 119, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6184), true, false, 15, 6, 26, 50, null, null },
                    { 120, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6184), true, false, 15, 7, 30, 50, null, null },
                    { 121, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6185), true, false, 16, 1, 1, 50, null, null },
                    { 122, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6185), true, false, 16, 1, 2, 50, null, null },
                    { 123, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6186), true, false, 16, 1, 3, 50, null, null },
                    { 124, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6186), true, false, 16, 1, 4, 50, null, null },
                    { 125, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6187), true, false, 16, 4, 15, 50, null, null },
                    { 126, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6187), true, false, 16, 5, 24, 50, null, null },
                    { 127, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6188), true, false, 16, 6, 28, 50, null, null },
                    { 128, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6189), true, false, 16, 7, 30, 50, null, null },
                    { 129, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6189), true, false, 17, 1, 1, 50, null, null },
                    { 130, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6190), true, false, 17, 1, 2, 50, null, null },
                    { 131, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6191), true, false, 17, 1, 3, 50, null, null },
                    { 132, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6191), true, false, 17, 1, 4, 50, null, null },
                    { 133, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6192), true, false, 17, 4, 33, 50, null, null },
                    { 134, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6193), true, false, 17, 5, 24, 50, null, null },
                    { 135, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6193), true, false, 17, 6, 28, 50, null, null },
                    { 136, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6194), true, false, 17, 7, 30, 50, null, null },
                    { 137, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6194), true, false, 18, 1, 1, 50, null, null },
                    { 138, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6195), true, false, 18, 1, 2, 50, null, null },
                    { 139, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6195), true, false, 18, 1, 3, 50, null, null },
                    { 140, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6196), true, false, 18, 1, 4, 50, null, null },
                    { 141, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6197), true, false, 18, 4, 21, 50, null, null },
                    { 142, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6197), true, false, 18, 5, 23, 50, null, null },
                    { 143, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6198), true, false, 18, 6, 28, 50, null, null },
                    { 144, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6240), true, false, 18, 7, 30, 50, null, null },
                    { 145, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6240), true, false, 19, 1, 1, 50, null, null },
                    { 146, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6241), true, false, 19, 1, 2, 50, null, null },
                    { 147, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6241), true, false, 19, 1, 3, 50, null, null },
                    { 148, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6242), true, false, 19, 1, 4, 50, null, null },
                    { 149, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6243), true, false, 19, 4, 21, 50, null, null },
                    { 150, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6243), true, false, 19, 5, 22, 50, null, null },
                    { 151, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6244), true, false, 19, 6, 27, 50, null, null },
                    { 152, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6245), true, false, 19, 7, 30, 50, null, null },
                    { 153, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6245), true, false, 20, 1, 1, 50, null, null },
                    { 154, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6246), true, false, 20, 1, 2, 50, null, null },
                    { 155, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6246), true, false, 20, 1, 3, 50, null, null },
                    { 156, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6247), true, false, 20, 1, 4, 50, null, null },
                    { 157, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6247), true, false, 20, 4, 16, 50, null, null },
                    { 158, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6248), true, false, 20, 5, 22, 50, null, null },
                    { 159, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6249), true, false, 20, 6, 27, 50, null, null },
                    { 160, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6249), true, false, 20, 7, 30, 50, null, null },
                    { 161, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6250), true, false, 21, 1, 1, 50, null, null },
                    { 162, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6250), true, false, 21, 1, 2, 50, null, null },
                    { 163, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6251), true, false, 21, 1, 3, 50, null, null },
                    { 164, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6251), true, false, 21, 1, 4, 50, null, null },
                    { 165, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6252), true, false, 21, 4, 19, 50, null, null },
                    { 166, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6252), true, false, 21, 5, 23, 50, null, null },
                    { 167, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6253), true, false, 21, 6, 12, 50, null, null },
                    { 168, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6254), true, false, 21, 7, 29, 50, null, null },
                    { 169, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6254), true, false, 22, 1, 1, 50, null, null },
                    { 170, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6255), true, false, 22, 1, 2, 50, null, null },
                    { 171, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6255), true, false, 22, 1, 3, 50, null, null },
                    { 172, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6256), true, false, 22, 1, 4, 50, null, null },
                    { 173, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6256), true, false, 22, 4, 19, 50, null, null },
                    { 174, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6257), true, false, 22, 5, 23, 50, null, null },
                    { 175, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6258), true, false, 22, 6, 28, 50, null, null },
                    { 176, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6258), true, false, 22, 7, 30, 50, null, null },
                    { 177, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6259), true, false, 23, 1, 1, 50, null, null },
                    { 178, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6259), true, false, 23, 1, 2, 50, null, null },
                    { 179, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6260), true, false, 23, 1, 3, 50, null, null },
                    { 180, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6260), true, false, 23, 1, 4, 50, null, null },
                    { 181, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6261), true, false, 23, 4, 35, 50, null, null },
                    { 182, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6261), true, false, 23, 5, 23, 50, null, null },
                    { 183, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6262), true, false, 23, 6, 27, 50, null, null },
                    { 184, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6262), true, false, 23, 7, 29, 50, null, null },
                    { 185, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6263), true, false, 24, 1, 1, 50, null, null },
                    { 186, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6263), true, false, 24, 1, 2, 50, null, null },
                    { 187, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6264), true, false, 24, 1, 3, 50, null, null },
                    { 188, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6264), true, false, 24, 1, 4, 50, null, null },
                    { 189, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6265), true, false, 24, 4, 19, 50, null, null },
                    { 190, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6266), true, false, 24, 5, 24, 50, null, null },
                    { 191, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6266), true, false, 24, 6, 28, 50, null, null },
                    { 192, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6267), true, false, 24, 7, 31, 50, null, null },
                    { 193, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6267), true, false, 25, 1, 1, 50, null, null },
                    { 194, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6268), true, false, 25, 1, 2, 50, null, null },
                    { 195, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6268), true, false, 25, 1, 3, 50, null, null },
                    { 196, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6269), true, false, 25, 1, 4, 50, null, null },
                    { 197, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6270), true, false, 25, 4, 34, 50, null, null },
                    { 198, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6270), true, false, 25, 5, 24, 50, null, null },
                    { 199, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6271), true, false, 25, 6, 26, 50, null, null },
                    { 200, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6271), true, false, 25, 7, 30, 50, null, null },
                    { 201, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6272), true, false, 26, 1, 1, 50, null, null },
                    { 202, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6272), true, false, 26, 1, 2, 50, null, null },
                    { 203, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6273), true, false, 26, 1, 3, 50, null, null },
                    { 204, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6305), true, false, 26, 1, 4, 50, null, null },
                    { 205, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6306), true, false, 26, 4, 17, 50, null, null },
                    { 206, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6307), true, false, 26, 5, 24, 50, null, null },
                    { 207, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6308), true, false, 26, 6, 28, 50, null, null },
                    { 208, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6308), true, false, 26, 7, 31, 50, null, null },
                    { 209, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6309), true, false, 27, 1, 1, 50, null, null },
                    { 210, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6310), true, false, 27, 1, 2, 50, null, null },
                    { 211, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6310), true, false, 27, 1, 3, 50, null, null },
                    { 212, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6311), true, false, 27, 1, 4, 50, null, null },
                    { 213, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6312), true, false, 27, 4, 19, 50, null, null },
                    { 214, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6312), true, false, 27, 5, 23, 50, null, null },
                    { 215, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6313), true, false, 27, 6, 26, 50, null, null },
                    { 216, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6313), true, false, 27, 7, 30, 50, null, null },
                    { 217, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6314), true, false, 28, 1, 1, 50, null, null },
                    { 218, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6314), true, false, 28, 1, 2, 50, null, null },
                    { 219, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6315), true, false, 28, 1, 3, 50, null, null },
                    { 220, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6315), true, false, 28, 1, 4, 50, null, null },
                    { 221, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6316), true, false, 28, 4, 36, 50, null, null },
                    { 222, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6317), true, false, 28, 5, 23, 50, null, null },
                    { 223, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6317), true, false, 28, 6, 28, 50, null, null },
                    { 224, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6318), true, false, 28, 7, 30, 50, null, null },
                    { 225, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6318), true, false, 29, 1, 1, 50, null, null },
                    { 226, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6319), true, false, 29, 1, 2, 50, null, null },
                    { 227, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6319), true, false, 29, 1, 3, 50, null, null },
                    { 228, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6320), true, false, 29, 1, 4, 50, null, null },
                    { 229, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6320), true, false, 29, 4, 19, 50, null, null },
                    { 230, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6321), true, false, 29, 5, 22, 50, null, null },
                    { 231, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6322), true, false, 29, 6, 27, 50, null, null },
                    { 232, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6322), true, false, 29, 7, 30, 50, null, null },
                    { 233, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6323), true, false, 30, 1, 1, 50, null, null },
                    { 234, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6323), true, false, 30, 1, 2, 50, null, null },
                    { 235, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6324), true, false, 30, 1, 3, 50, null, null },
                    { 236, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6324), true, false, 30, 1, 4, 50, null, null },
                    { 237, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6325), true, false, 30, 4, 16, 50, null, null },
                    { 238, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6325), true, false, 30, 5, 24, 50, null, null },
                    { 239, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6326), true, false, 30, 6, 28, 50, null, null },
                    { 240, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6327), true, false, 30, 7, 30, 50, null, null },
                    { 241, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6327), true, false, 31, 1, 1, 50, null, null },
                    { 242, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6327), true, false, 31, 1, 2, 50, null, null },
                    { 243, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6328), true, false, 31, 1, 3, 50, null, null },
                    { 244, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6328), true, false, 31, 1, 4, 50, null, null },
                    { 245, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6329), true, false, 31, 4, 21, 50, null, null },
                    { 246, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6330), true, false, 31, 5, 23, 50, null, null },
                    { 247, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6331), true, false, 31, 6, 12, 50, null, null },
                    { 248, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6331), true, false, 31, 7, 29, 50, null, null },
                    { 249, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6334), true, false, 32, 1, 52, 50, null, null },
                    { 250, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6335), true, false, 32, 1, 53, 50, null, null },
                    { 251, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6335), true, false, 32, 1, 54, 50, null, null },
                    { 252, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6337), true, false, 32, 8, 37, 50, null, null },
                    { 253, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6338), true, false, 32, 9, 40, 50, null, null },
                    { 254, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6340), true, false, 32, 10, 43, 50, null, null },
                    { 255, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6359), true, false, 32, 11, 46, 50, null, null },
                    { 256, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6360), true, false, 32, 11, 47, 50, null, null },
                    { 257, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6361), true, false, 32, 11, 48, 50, null, null },
                    { 258, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6394), true, false, 32, 11, 50, 50, null, null },
                    { 259, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6395), true, false, 32, 11, 51, 50, null, null },
                    { 260, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6396), true, false, 33, 1, 52, 50, null, null },
                    { 261, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6397), true, false, 33, 1, 53, 50, null, null },
                    { 262, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6397), true, false, 33, 1, 54, 50, null, null },
                    { 263, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6398), true, false, 33, 8, 37, 50, null, null },
                    { 264, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6399), true, false, 33, 9, 40, 50, null, null },
                    { 265, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6399), true, false, 33, 10, 43, 50, null, null },
                    { 266, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6401), true, false, 33, 11, 46, 50, null, null },
                    { 267, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6401), true, false, 33, 11, 47, 50, null, null },
                    { 268, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6402), true, false, 33, 11, 48, 50, null, null },
                    { 269, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6402), true, false, 33, 11, 50, 50, null, null },
                    { 270, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6403), true, false, 33, 11, 51, 50, null, null },
                    { 271, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6403), true, false, 34, 1, 52, 50, null, null },
                    { 272, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6404), true, false, 34, 1, 53, 50, null, null },
                    { 273, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6404), true, false, 34, 1, 54, 50, null, null },
                    { 274, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6405), true, false, 34, 8, 37, 50, null, null },
                    { 275, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6405), true, false, 34, 9, 40, 50, null, null },
                    { 276, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6406), true, false, 34, 10, 43, 50, null, null },
                    { 277, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6407), true, false, 34, 11, 46, 50, null, null },
                    { 278, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6407), true, false, 34, 11, 47, 50, null, null },
                    { 279, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6408), true, false, 34, 11, 48, 50, null, null },
                    { 280, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6408), true, false, 34, 11, 50, 50, null, null },
                    { 281, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6409), true, false, 34, 11, 51, 50, null, null },
                    { 282, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6409), true, false, 35, 1, 52, 50, null, null },
                    { 283, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6410), true, false, 35, 1, 53, 50, null, null },
                    { 284, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6410), true, false, 35, 1, 54, 50, null, null },
                    { 285, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6411), true, false, 35, 8, 37, 50, null, null },
                    { 286, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6411), true, false, 35, 9, 40, 50, null, null },
                    { 287, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6412), true, false, 35, 10, 43, 50, null, null },
                    { 288, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6413), true, false, 35, 11, 46, 50, null, null },
                    { 289, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6413), true, false, 35, 11, 47, 50, null, null },
                    { 290, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6414), true, false, 35, 11, 48, 50, null, null },
                    { 291, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6441), true, false, 35, 11, 50, 50, null, null },
                    { 292, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6442), true, false, 35, 11, 51, 50, null, null },
                    { 293, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6443), true, false, 36, 1, 52, 50, null, null },
                    { 294, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6443), true, false, 36, 1, 53, 50, null, null },
                    { 295, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6444), true, false, 36, 1, 54, 50, null, null },
                    { 296, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6444), true, false, 36, 8, 37, 50, null, null },
                    { 297, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6445), true, false, 36, 9, 40, 50, null, null },
                    { 298, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6445), true, false, 36, 10, 43, 50, null, null },
                    { 299, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6446), true, false, 36, 11, 46, 50, null, null },
                    { 300, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6447), true, false, 36, 11, 47, 50, null, null },
                    { 301, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6447), true, false, 36, 11, 48, 50, null, null },
                    { 302, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6448), true, false, 36, 11, 50, 50, null, null },
                    { 303, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6448), true, false, 36, 11, 51, 50, null, null },
                    { 304, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6449), true, false, 37, 1, 52, 50, null, null },
                    { 305, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6449), true, false, 37, 1, 53, 50, null, null },
                    { 306, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6450), true, false, 37, 1, 54, 50, null, null },
                    { 307, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6450), true, false, 37, 8, 37, 50, null, null },
                    { 308, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6451), true, false, 37, 9, 40, 50, null, null },
                    { 309, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6451), true, false, 37, 10, 43, 50, null, null },
                    { 310, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6452), true, false, 37, 11, 46, 50, null, null },
                    { 311, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6453), true, false, 37, 11, 47, 50, null, null },
                    { 312, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6453), true, false, 37, 11, 48, 50, null, null },
                    { 313, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6454), true, false, 37, 11, 50, 50, null, null },
                    { 314, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6454), true, false, 37, 11, 51, 50, null, null },
                    { 315, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6455), true, false, 38, 1, 52, 50, null, null },
                    { 316, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6455), true, false, 38, 1, 53, 50, null, null },
                    { 317, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6456), true, false, 38, 1, 54, 50, null, null },
                    { 318, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6456), true, false, 38, 8, 37, 50, null, null },
                    { 319, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6457), true, false, 38, 9, 40, 50, null, null },
                    { 320, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6457), true, false, 38, 10, 43, 50, null, null },
                    { 321, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6458), true, false, 38, 11, 46, 50, null, null },
                    { 322, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6458), true, false, 38, 11, 47, 50, null, null },
                    { 323, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6459), true, false, 38, 11, 48, 50, null, null },
                    { 324, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6459), true, false, 38, 11, 50, 50, null, null },
                    { 325, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6460), true, false, 38, 11, 51, 50, null, null },
                    { 326, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6460), true, false, 39, 1, 52, 50, null, null },
                    { 327, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6461), true, false, 39, 1, 53, 50, null, null },
                    { 328, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6461), true, false, 39, 1, 54, 50, null, null },
                    { 329, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6462), true, false, 39, 8, 37, 50, null, null },
                    { 330, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6462), true, false, 39, 9, 40, 50, null, null },
                    { 331, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6463), true, false, 39, 10, 43, 50, null, null },
                    { 332, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6464), true, false, 39, 11, 46, 50, null, null },
                    { 333, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6464), true, false, 39, 11, 47, 50, null, null },
                    { 334, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6465), true, false, 39, 11, 48, 50, null, null },
                    { 335, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6465), true, false, 39, 11, 50, 50, null, null },
                    { 336, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6466), true, false, 39, 11, 51, 50, null, null },
                    { 337, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6466), true, false, 40, 1, 52, 50, null, null },
                    { 338, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6467), true, false, 40, 1, 53, 50, null, null },
                    { 339, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6467), true, false, 40, 1, 54, 50, null, null },
                    { 340, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6467), true, false, 40, 8, 37, 50, null, null },
                    { 341, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6468), true, false, 40, 9, 40, 50, null, null },
                    { 342, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6468), true, false, 40, 10, 43, 50, null, null },
                    { 343, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6469), true, false, 40, 11, 46, 50, null, null },
                    { 344, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6470), true, false, 40, 11, 47, 50, null, null },
                    { 345, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6470), true, false, 40, 11, 48, 50, null, null },
                    { 346, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6471), true, false, 40, 11, 50, 50, null, null },
                    { 347, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6498), true, false, 40, 11, 51, 50, null, null },
                    { 348, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6498), true, false, 41, 1, 52, 50, null, null },
                    { 349, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6499), true, false, 41, 1, 53, 50, null, null },
                    { 350, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6499), true, false, 41, 1, 54, 50, null, null },
                    { 351, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6500), true, false, 41, 8, 37, 50, null, null },
                    { 352, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6500), true, false, 41, 9, 40, 50, null, null },
                    { 353, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6501), true, false, 41, 10, 43, 50, null, null },
                    { 354, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6502), true, false, 41, 11, 46, 50, null, null },
                    { 355, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6503), true, false, 41, 11, 47, 50, null, null },
                    { 356, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6503), true, false, 41, 11, 48, 50, null, null },
                    { 357, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6504), true, false, 41, 11, 50, 50, null, null },
                    { 358, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6504), true, false, 41, 11, 51, 50, null, null },
                    { 359, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6505), true, false, 42, 1, 52, 50, null, null },
                    { 360, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6505), true, false, 42, 1, 53, 50, null, null },
                    { 361, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6506), true, false, 42, 1, 54, 50, null, null },
                    { 362, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6506), true, false, 42, 8, 37, 50, null, null },
                    { 363, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6507), true, false, 42, 9, 40, 50, null, null },
                    { 364, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6507), true, false, 42, 10, 43, 50, null, null },
                    { 365, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6508), true, false, 42, 11, 46, 50, null, null },
                    { 366, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6508), true, false, 42, 11, 47, 50, null, null },
                    { 367, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6509), true, false, 42, 11, 48, 50, null, null },
                    { 368, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6509), true, false, 42, 11, 50, 50, null, null },
                    { 369, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6510), true, false, 42, 11, 51, 50, null, null },
                    { 370, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6510), true, false, 43, 1, 52, 50, null, null },
                    { 371, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6511), true, false, 43, 1, 53, 50, null, null },
                    { 372, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6511), true, false, 43, 1, 54, 50, null, null },
                    { 373, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6512), true, false, 43, 8, 37, 50, null, null },
                    { 374, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6512), true, false, 43, 9, 40, 50, null, null },
                    { 375, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6513), true, false, 43, 10, 43, 50, null, null },
                    { 376, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6514), true, false, 43, 11, 46, 50, null, null },
                    { 377, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6514), true, false, 43, 11, 47, 50, null, null },
                    { 378, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6515), true, false, 43, 11, 48, 50, null, null },
                    { 379, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6515), true, false, 43, 11, 50, 50, null, null },
                    { 380, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6515), true, false, 43, 11, 51, 50, null, null },
                    { 381, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6516), true, false, 44, 1, 52, 50, null, null },
                    { 382, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6516), true, false, 44, 1, 53, 50, null, null },
                    { 383, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6517), true, false, 44, 1, 54, 50, null, null },
                    { 384, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6517), true, false, 44, 8, 37, 50, null, null },
                    { 385, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6518), true, false, 44, 9, 40, 50, null, null },
                    { 386, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6519), true, false, 44, 10, 43, 50, null, null },
                    { 387, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6519), true, false, 44, 11, 46, 50, null, null },
                    { 388, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6520), true, false, 44, 11, 47, 50, null, null },
                    { 389, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6520), true, false, 44, 11, 48, 50, null, null },
                    { 390, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6521), true, false, 44, 11, 50, 50, null, null },
                    { 391, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6521), true, false, 44, 11, 51, 50, null, null },
                    { 392, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6522), true, false, 45, 1, 52, 50, null, null },
                    { 393, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6522), true, false, 45, 1, 53, 50, null, null },
                    { 394, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6523), true, false, 45, 1, 54, 50, null, null },
                    { 395, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6523), true, false, 45, 8, 37, 50, null, null },
                    { 396, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6524), true, false, 45, 9, 40, 50, null, null },
                    { 397, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6524), true, false, 45, 10, 43, 50, null, null },
                    { 398, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6525), true, false, 45, 11, 46, 50, null, null },
                    { 399, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6525), true, false, 45, 11, 47, 50, null, null },
                    { 400, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6526), true, false, 45, 11, 48, 50, null, null },
                    { 401, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6526), true, false, 45, 11, 50, 50, null, null },
                    { 402, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6556), true, false, 45, 11, 51, 50, null, null },
                    { 403, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6556), true, false, 46, 1, 52, 50, null, null },
                    { 404, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6557), true, false, 46, 1, 53, 50, null, null },
                    { 405, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6557), true, false, 46, 1, 54, 50, null, null },
                    { 406, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6558), true, false, 46, 8, 37, 50, null, null },
                    { 407, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6558), true, false, 46, 9, 40, 50, null, null },
                    { 408, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6559), true, false, 46, 10, 43, 50, null, null },
                    { 409, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6560), true, false, 46, 11, 46, 50, null, null },
                    { 410, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6560), true, false, 46, 11, 47, 50, null, null },
                    { 411, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6561), true, false, 46, 11, 48, 50, null, null },
                    { 412, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6561), true, false, 46, 11, 50, 50, null, null },
                    { 413, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6562), true, false, 46, 11, 51, 50, null, null },
                    { 414, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6562), true, false, 47, 1, 52, 50, null, null },
                    { 415, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6563), true, false, 47, 1, 53, 50, null, null },
                    { 416, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6563), true, false, 47, 1, 54, 50, null, null },
                    { 417, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6564), true, false, 47, 8, 37, 50, null, null },
                    { 418, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6564), true, false, 47, 9, 40, 50, null, null },
                    { 419, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6564), true, false, 47, 10, 43, 50, null, null },
                    { 420, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6565), true, false, 47, 11, 46, 50, null, null },
                    { 421, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6566), true, false, 47, 11, 47, 50, null, null },
                    { 422, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6566), true, false, 47, 11, 48, 50, null, null },
                    { 423, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6567), true, false, 47, 11, 50, 50, null, null },
                    { 424, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6567), true, false, 47, 11, 51, 50, null, null },
                    { 425, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6568), true, false, 48, 1, 52, 50, null, null },
                    { 426, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6568), true, false, 48, 1, 53, 50, null, null },
                    { 427, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6569), true, false, 48, 1, 54, 50, null, null },
                    { 428, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6569), true, false, 48, 8, 37, 50, null, null },
                    { 429, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6570), true, false, 48, 9, 40, 50, null, null },
                    { 430, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6570), true, false, 48, 10, 43, 50, null, null },
                    { 431, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6571), true, false, 48, 11, 46, 50, null, null },
                    { 432, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6572), true, false, 48, 11, 47, 50, null, null },
                    { 433, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6572), true, false, 48, 11, 48, 50, null, null },
                    { 434, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6573), true, false, 48, 11, 50, 50, null, null },
                    { 435, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6573), true, false, 48, 11, 51, 50, null, null },
                    { 436, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6574), true, false, 49, 1, 52, 50, null, null },
                    { 437, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6574), true, false, 49, 1, 53, 50, null, null },
                    { 438, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6575), true, false, 49, 1, 54, 50, null, null },
                    { 439, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6575), true, false, 49, 8, 37, 50, null, null },
                    { 440, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6575), true, false, 49, 9, 40, 50, null, null },
                    { 441, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6576), true, false, 49, 10, 43, 50, null, null },
                    { 442, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6577), true, false, 49, 11, 46, 50, null, null },
                    { 443, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6577), true, false, 49, 11, 47, 50, null, null },
                    { 444, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6578), true, false, 49, 11, 48, 50, null, null },
                    { 445, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6578), true, false, 49, 11, 50, 50, null, null },
                    { 446, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6579), true, false, 49, 11, 51, 50, null, null },
                    { 447, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6579), true, false, 50, 1, 52, 50, null, null },
                    { 448, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6580), true, false, 50, 1, 53, 50, null, null },
                    { 449, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6580), true, false, 50, 1, 54, 50, null, null },
                    { 450, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6581), true, false, 50, 8, 37, 50, null, null },
                    { 451, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6581), true, false, 50, 9, 40, 50, null, null },
                    { 452, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6582), true, false, 50, 10, 43, 50, null, null },
                    { 453, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6583), true, false, 50, 11, 46, 50, null, null },
                    { 454, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6583), true, false, 50, 11, 47, 50, null, null },
                    { 455, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6583), true, false, 50, 11, 48, 50, null, null },
                    { 456, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6584), true, false, 50, 11, 50, 50, null, null },
                    { 457, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6584), true, false, 50, 11, 51, 50, null, null },
                    { 458, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6603), true, false, 51, 1, 52, 50, null, null },
                    { 459, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6604), true, false, 51, 1, 53, 50, null, null },
                    { 460, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6604), true, false, 51, 1, 54, 50, null, null },
                    { 461, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6605), true, false, 51, 8, 37, 50, null, null },
                    { 462, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6605), true, false, 51, 9, 40, 50, null, null },
                    { 463, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6606), true, false, 51, 10, 43, 50, null, null },
                    { 464, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6607), true, false, 51, 11, 46, 50, null, null },
                    { 465, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6607), true, false, 51, 11, 47, 50, null, null },
                    { 466, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6608), true, false, 51, 11, 48, 50, null, null },
                    { 467, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6608), true, false, 51, 11, 50, 50, null, null },
                    { 468, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6609), true, false, 51, 11, 51, 50, null, null },
                    { 469, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6609), true, false, 52, 1, 52, 50, null, null },
                    { 470, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6610), true, false, 52, 1, 53, 50, null, null },
                    { 471, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6611), true, false, 52, 1, 54, 50, null, null },
                    { 472, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6611), true, false, 52, 8, 37, 50, null, null },
                    { 473, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6612), true, false, 52, 9, 40, 50, null, null },
                    { 474, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6612), true, false, 52, 10, 43, 50, null, null },
                    { 475, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6613), true, false, 52, 11, 46, 50, null, null },
                    { 476, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6613), true, false, 52, 11, 47, 50, null, null },
                    { 477, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6614), true, false, 52, 11, 48, 50, null, null },
                    { 478, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6614), true, false, 52, 11, 50, 50, null, null },
                    { 479, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6615), true, false, 52, 11, 51, 50, null, null },
                    { 480, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6615), true, false, 53, 1, 52, 50, null, null },
                    { 481, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6616), true, false, 53, 1, 53, 50, null, null },
                    { 482, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6616), true, false, 53, 1, 54, 50, null, null },
                    { 483, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6617), true, false, 53, 8, 37, 50, null, null },
                    { 484, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6618), true, false, 53, 9, 40, 50, null, null },
                    { 485, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6618), true, false, 53, 10, 43, 50, null, null },
                    { 486, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6619), true, false, 53, 11, 46, 50, null, null },
                    { 487, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6619), true, false, 53, 11, 47, 50, null, null },
                    { 488, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6620), true, false, 53, 11, 48, 50, null, null },
                    { 489, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6620), true, false, 53, 11, 50, 50, null, null },
                    { 490, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6621), true, false, 53, 11, 51, 50, null, null },
                    { 491, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6622), true, false, 54, 1, 52, 50, null, null },
                    { 492, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6622), true, false, 54, 1, 53, 50, null, null },
                    { 493, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6622), true, false, 54, 1, 54, 50, null, null },
                    { 494, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6623), true, false, 54, 8, 37, 50, null, null },
                    { 495, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6623), true, false, 54, 9, 40, 50, null, null },
                    { 496, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6624), true, false, 54, 10, 43, 50, null, null },
                    { 497, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6625), true, false, 54, 11, 46, 50, null, null },
                    { 498, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6625), true, false, 54, 11, 47, 50, null, null },
                    { 499, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6626), true, false, 54, 11, 48, 50, null, null },
                    { 500, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6626), true, false, 54, 11, 50, 50, null, null },
                    { 501, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6627), true, false, 54, 11, 51, 50, null, null },
                    { 502, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6627), true, false, 55, 1, 52, 50, null, null },
                    { 503, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6628), true, false, 55, 1, 53, 50, null, null },
                    { 504, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6628), true, false, 55, 1, 54, 50, null, null },
                    { 505, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6629), true, false, 55, 8, 37, 50, null, null },
                    { 506, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6629), true, false, 55, 9, 40, 50, null, null },
                    { 507, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6630), true, false, 55, 10, 43, 50, null, null },
                    { 508, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6631), true, false, 55, 11, 46, 50, null, null },
                    { 509, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6631), true, false, 55, 11, 47, 50, null, null },
                    { 510, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6632), true, false, 55, 11, 48, 50, null, null },
                    { 511, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6691), true, false, 55, 11, 50, 50, null, null },
                    { 512, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6693), true, false, 55, 11, 51, 50, null, null },
                    { 513, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6693), true, false, 56, 1, 52, 50, null, null },
                    { 514, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6738), true, false, 56, 1, 53, 50, null, null },
                    { 515, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6738), true, false, 56, 1, 54, 50, null, null },
                    { 516, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6739), true, false, 56, 8, 37, 50, null, null },
                    { 517, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6740), true, false, 56, 9, 40, 50, null, null },
                    { 518, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6740), true, false, 56, 10, 43, 50, null, null },
                    { 519, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6741), true, false, 56, 11, 46, 50, null, null },
                    { 520, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6742), true, false, 56, 11, 47, 50, null, null },
                    { 521, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6742), true, false, 56, 11, 48, 50, null, null },
                    { 522, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6743), true, false, 56, 11, 50, 50, null, null },
                    { 523, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6743), true, false, 56, 11, 51, 50, null, null },
                    { 524, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6744), true, false, 57, 1, 52, 50, null, null },
                    { 525, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6744), true, false, 57, 1, 53, 50, null, null },
                    { 526, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6745), true, false, 57, 1, 54, 50, null, null },
                    { 527, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6745), true, false, 57, 8, 37, 50, null, null },
                    { 528, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6746), true, false, 57, 9, 40, 50, null, null },
                    { 529, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6746), true, false, 57, 10, 43, 50, null, null },
                    { 530, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6747), true, false, 57, 11, 46, 50, null, null },
                    { 531, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6748), true, false, 57, 11, 47, 50, null, null },
                    { 532, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6748), true, false, 57, 11, 48, 50, null, null },
                    { 533, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6748), true, false, 57, 11, 50, 50, null, null },
                    { 534, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6749), true, false, 57, 11, 51, 50, null, null },
                    { 535, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6749), true, false, 58, 1, 52, 50, null, null },
                    { 536, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6750), true, false, 58, 1, 53, 50, null, null },
                    { 537, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6750), true, false, 58, 1, 54, 50, null, null },
                    { 538, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6751), true, false, 58, 8, 37, 50, null, null },
                    { 539, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6751), true, false, 58, 9, 40, 50, null, null },
                    { 540, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6752), true, false, 58, 10, 43, 50, null, null },
                    { 541, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6753), true, false, 58, 11, 46, 50, null, null },
                    { 542, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6753), true, false, 58, 11, 47, 50, null, null },
                    { 543, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6754), true, false, 58, 11, 48, 50, null, null },
                    { 544, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6754), true, false, 58, 11, 50, 50, null, null },
                    { 545, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6755), true, false, 58, 11, 51, 50, null, null },
                    { 546, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6755), true, false, 59, 1, 52, 50, null, null },
                    { 547, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6756), true, false, 59, 1, 53, 50, null, null },
                    { 548, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6756), true, false, 59, 1, 54, 50, null, null },
                    { 549, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6757), true, false, 59, 8, 37, 50, null, null },
                    { 550, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6757), true, false, 59, 9, 40, 50, null, null },
                    { 551, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6758), true, false, 59, 10, 43, 50, null, null },
                    { 552, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6759), true, false, 59, 11, 46, 50, null, null },
                    { 553, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6759), true, false, 59, 11, 47, 50, null, null },
                    { 554, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6760), true, false, 59, 11, 48, 50, null, null },
                    { 555, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6760), true, false, 59, 11, 50, 50, null, null },
                    { 556, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6761), true, false, 59, 11, 51, 50, null, null },
                    { 557, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6761), true, false, 60, 1, 52, 50, null, null },
                    { 558, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6762), true, false, 60, 1, 53, 50, null, null },
                    { 559, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6762), true, false, 60, 1, 54, 50, null, null },
                    { 560, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6763), true, false, 60, 8, 37, 50, null, null },
                    { 561, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6763), true, false, 60, 9, 40, 50, null, null },
                    { 562, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6764), true, false, 60, 10, 43, 50, null, null },
                    { 563, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6764), true, false, 60, 11, 46, 50, null, null },
                    { 564, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6765), true, false, 60, 11, 47, 50, null, null },
                    { 565, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6765), true, false, 60, 11, 48, 50, null, null },
                    { 566, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6766), true, false, 60, 11, 50, 50, null, null },
                    { 567, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6796), true, false, 60, 11, 51, 50, null, null },
                    { 568, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6797), true, false, 61, 1, 52, 50, null, null },
                    { 569, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6797), true, false, 61, 1, 53, 50, null, null },
                    { 570, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6798), true, false, 61, 1, 54, 50, null, null },
                    { 571, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6798), true, false, 61, 8, 37, 50, null, null },
                    { 572, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6798), true, false, 61, 9, 40, 50, null, null },
                    { 573, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6799), true, false, 61, 10, 43, 50, null, null },
                    { 574, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6800), true, false, 61, 11, 46, 50, null, null },
                    { 575, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6800), true, false, 61, 11, 47, 50, null, null },
                    { 576, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6801), true, false, 61, 11, 48, 50, null, null },
                    { 577, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6801), true, false, 61, 11, 50, 50, null, null },
                    { 578, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6802), true, false, 61, 11, 51, 50, null, null },
                    { 579, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6802), true, false, 62, 1, 52, 50, null, null },
                    { 580, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6803), true, false, 62, 1, 53, 50, null, null },
                    { 581, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6803), true, false, 62, 1, 54, 50, null, null },
                    { 582, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6804), true, false, 62, 8, 37, 50, null, null },
                    { 583, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6804), true, false, 62, 9, 40, 50, null, null },
                    { 584, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6805), true, false, 62, 10, 43, 50, null, null },
                    { 585, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6806), true, false, 62, 11, 46, 50, null, null },
                    { 586, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6806), true, false, 62, 11, 47, 50, null, null },
                    { 587, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6807), true, false, 62, 11, 48, 50, null, null },
                    { 588, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6807), true, false, 62, 11, 50, 50, null, null },
                    { 589, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6808), true, false, 62, 11, 51, 50, null, null },
                    { 590, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6808), true, false, 63, 1, 52, 50, null, null },
                    { 591, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6809), true, false, 63, 1, 53, 50, null, null },
                    { 592, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6809), true, false, 63, 1, 54, 50, null, null },
                    { 593, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6809), true, false, 63, 8, 37, 50, null, null },
                    { 594, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6810), true, false, 63, 9, 40, 50, null, null },
                    { 595, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6810), true, false, 63, 10, 43, 50, null, null },
                    { 596, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6811), true, false, 63, 11, 46, 50, null, null },
                    { 597, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6812), true, false, 63, 11, 47, 50, null, null },
                    { 598, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6812), true, false, 63, 11, 48, 50, null, null },
                    { 599, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6813), true, false, 63, 11, 50, 50, null, null },
                    { 600, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6813), true, false, 63, 11, 51, 50, null, null },
                    { 601, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6814), true, false, 64, 1, 52, 50, null, null },
                    { 602, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6814), true, false, 64, 1, 53, 50, null, null },
                    { 603, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6815), true, false, 64, 1, 54, 50, null, null },
                    { 604, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6815), true, false, 64, 8, 37, 50, null, null },
                    { 605, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6816), true, false, 64, 9, 40, 50, null, null },
                    { 606, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6816), true, false, 64, 10, 43, 50, null, null },
                    { 607, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6817), true, false, 64, 11, 46, 50, null, null },
                    { 608, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6818), true, false, 64, 11, 47, 50, null, null },
                    { 609, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6818), true, false, 64, 11, 48, 50, null, null },
                    { 610, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6819), true, false, 64, 11, 50, 50, null, null },
                    { 611, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6819), true, false, 64, 11, 51, 50, null, null },
                    { 612, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6820), true, false, 65, 1, 52, 50, null, null },
                    { 613, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6820), true, false, 65, 1, 53, 50, null, null },
                    { 614, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6821), true, false, 65, 1, 54, 50, null, null },
                    { 615, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6821), true, false, 65, 8, 37, 50, null, null },
                    { 616, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6822), true, false, 65, 9, 40, 50, null, null },
                    { 617, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6822), true, false, 65, 10, 43, 50, null, null },
                    { 618, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6823), true, false, 65, 11, 46, 50, null, null },
                    { 619, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6824), true, false, 65, 11, 47, 50, null, null },
                    { 620, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6824), true, false, 65, 11, 48, 50, null, null },
                    { 621, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6824), true, false, 65, 11, 50, 50, null, null },
                    { 622, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6825), true, false, 65, 11, 51, 50, null, null },
                    { 623, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6858), true, false, 66, 1, 52, 50, null, null },
                    { 624, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6859), true, false, 66, 1, 53, 50, null, null },
                    { 625, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6859), true, false, 66, 1, 54, 50, null, null },
                    { 626, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6860), true, false, 66, 8, 37, 50, null, null },
                    { 627, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6860), true, false, 66, 9, 40, 50, null, null },
                    { 628, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6861), true, false, 66, 10, 43, 50, null, null },
                    { 629, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6862), true, false, 66, 11, 46, 50, null, null },
                    { 630, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6862), true, false, 66, 11, 47, 50, null, null },
                    { 631, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6862), true, false, 66, 11, 48, 50, null, null },
                    { 632, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6863), true, false, 66, 11, 50, 50, null, null },
                    { 633, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6864), true, false, 66, 11, 51, 50, null, null },
                    { 634, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6864), true, false, 67, 1, 52, 50, null, null },
                    { 635, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6865), true, false, 67, 1, 53, 50, null, null },
                    { 636, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6865), true, false, 67, 1, 54, 50, null, null },
                    { 637, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6866), true, false, 67, 8, 37, 50, null, null },
                    { 638, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6866), true, false, 67, 9, 40, 50, null, null },
                    { 639, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6867), true, false, 67, 10, 43, 50, null, null },
                    { 640, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6868), true, false, 67, 11, 46, 50, null, null },
                    { 641, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6868), true, false, 67, 11, 47, 50, null, null },
                    { 642, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6869), true, false, 67, 11, 48, 50, null, null },
                    { 643, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6869), true, false, 67, 11, 50, 50, null, null },
                    { 644, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6870), true, false, 67, 11, 51, 50, null, null },
                    { 645, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6870), true, false, 68, 1, 52, 50, null, null },
                    { 646, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6871), true, false, 68, 1, 53, 50, null, null },
                    { 647, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6871), true, false, 68, 1, 54, 50, null, null },
                    { 648, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6872), true, false, 68, 8, 37, 50, null, null },
                    { 649, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6872), true, false, 68, 9, 40, 50, null, null },
                    { 650, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6873), true, false, 68, 10, 43, 50, null, null },
                    { 651, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6874), true, false, 68, 11, 46, 50, null, null },
                    { 652, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6874), true, false, 68, 11, 47, 50, null, null },
                    { 653, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6875), true, false, 68, 11, 48, 50, null, null },
                    { 654, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6875), true, false, 68, 11, 50, 50, null, null },
                    { 655, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6876), true, false, 68, 11, 51, 50, null, null },
                    { 656, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6876), true, false, 69, 1, 52, 50, null, null },
                    { 657, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6877), true, false, 69, 1, 53, 50, null, null },
                    { 658, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6877), true, false, 69, 1, 54, 50, null, null },
                    { 659, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6877), true, false, 69, 8, 37, 50, null, null },
                    { 660, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6878), true, false, 69, 9, 40, 50, null, null },
                    { 661, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6878), true, false, 69, 10, 43, 50, null, null },
                    { 662, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6879), true, false, 69, 11, 46, 50, null, null },
                    { 663, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6880), true, false, 69, 11, 47, 50, null, null },
                    { 664, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6880), true, false, 69, 11, 48, 50, null, null },
                    { 665, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6881), true, false, 69, 11, 50, 50, null, null },
                    { 666, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6881), true, false, 69, 11, 51, 50, null, null },
                    { 667, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6882), true, false, 70, 1, 52, 50, null, null },
                    { 668, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6882), true, false, 70, 1, 53, 50, null, null },
                    { 669, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6883), true, false, 70, 1, 54, 50, null, null },
                    { 670, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6883), true, false, 70, 8, 37, 50, null, null },
                    { 671, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6884), true, false, 70, 9, 40, 50, null, null },
                    { 672, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6884), true, false, 70, 10, 43, 50, null, null },
                    { 673, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6885), true, false, 70, 11, 46, 50, null, null },
                    { 674, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6885), true, false, 70, 11, 47, 50, null, null },
                    { 675, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6886), true, false, 70, 11, 48, 50, null, null },
                    { 676, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6886), true, false, 70, 11, 50, 50, null, null },
                    { 677, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6887), true, false, 70, 11, 51, 50, null, null },
                    { 678, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6936), true, false, 71, 1, 52, 50, null, null },
                    { 679, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6936), true, false, 71, 1, 53, 50, null, null },
                    { 680, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6937), true, false, 71, 1, 54, 50, null, null },
                    { 681, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6937), true, false, 71, 8, 37, 50, null, null },
                    { 682, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6938), true, false, 71, 9, 40, 50, null, null },
                    { 683, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6938), true, false, 71, 10, 43, 50, null, null },
                    { 684, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6939), true, false, 71, 11, 46, 50, null, null },
                    { 685, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6940), true, false, 71, 11, 47, 50, null, null },
                    { 686, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6940), true, false, 71, 11, 48, 50, null, null },
                    { 687, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6941), true, false, 71, 11, 50, 50, null, null },
                    { 688, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6941), true, false, 71, 11, 51, 50, null, null },
                    { 689, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6942), true, false, 72, 1, 52, 50, null, null },
                    { 690, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6942), true, false, 72, 1, 53, 50, null, null },
                    { 691, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6943), true, false, 72, 1, 54, 50, null, null },
                    { 692, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6944), true, false, 72, 8, 37, 50, null, null },
                    { 693, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6944), true, false, 72, 9, 40, 50, null, null },
                    { 694, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6945), true, false, 72, 10, 43, 50, null, null },
                    { 695, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6946), true, false, 72, 11, 46, 50, null, null },
                    { 696, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6946), true, false, 72, 11, 47, 50, null, null },
                    { 697, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6946), true, false, 72, 11, 48, 50, null, null },
                    { 698, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6947), true, false, 72, 11, 50, 50, null, null },
                    { 699, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6947), true, false, 72, 11, 51, 50, null, null },
                    { 700, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6948), true, false, 73, 1, 52, 50, null, null },
                    { 701, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6948), true, false, 73, 1, 53, 50, null, null },
                    { 702, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6949), true, false, 73, 1, 54, 50, null, null },
                    { 703, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6950), true, false, 73, 8, 37, 50, null, null },
                    { 704, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6950), true, false, 73, 9, 40, 50, null, null },
                    { 705, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6951), true, false, 73, 10, 43, 50, null, null },
                    { 706, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6952), true, false, 73, 11, 46, 50, null, null },
                    { 707, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6952), true, false, 73, 11, 47, 50, null, null },
                    { 708, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6953), true, false, 73, 11, 48, 50, null, null },
                    { 709, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6953), true, false, 73, 11, 50, 50, null, null },
                    { 710, null, new DateTime(2025, 3, 29, 22, 42, 38, 327, DateTimeKind.Local).AddTicks(6954), true, false, 73, 11, 51, 50, null, null }
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
