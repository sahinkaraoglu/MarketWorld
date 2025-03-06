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
                    HasDiscount = table.Column<bool>(type: "bit", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
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
                table: "Brands",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsDeleted", "Name", "SubCategoryId", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1116), false, "Apple", null, null, null },
                    { 2, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1120), false, "Samsung", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsDeleted", "Name", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(829), "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar", false, "Elektronik", null, null },
                    { 2, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(847), "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları", false, "Giyim & Aksesuar", null, null },
                    { 3, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(849), "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili", false, "Ev & Yaşam", null, null },
                    { 4, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(850), "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri", false, "Kozmetik & Kişisel Bakım", null, null },
                    { 5, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(851), "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri", false, "Spor & Outdoor", null, null }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsActive", "IsDeleted", "Name", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 6, 14, 58, 59, 878, DateTimeKind.Local).AddTicks(1464), "Ürün renk seçenekleri", true, false, "Renk", null, null },
                    { 2, null, new DateTime(2025, 3, 6, 14, 58, 59, 878, DateTimeKind.Local).AddTicks(1471), "Ürün beden seçenekleri", true, false, "Beden", null, null }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedDate", "Description", "IsDeleted", "Name", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1023), "Dizüstü, masaüstü bilgisayarlar ve tabletler", false, "Bilgisayarlar & Tabletler", null, null },
                    { 2, 1, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1025), "Yazıcılar, tarayıcılar ve projeksiyon cihazları", false, "Yazıcılar & Projeksiyon", null, null },
                    { 3, 1, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1028), "Akıllı telefonlar ve aksesuarları", false, "Telefonlar", null, null },
                    { 4, 1, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1029), "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar", false, "Beyaz Eşya", null, null },
                    { 5, 1, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1031), "Klimalar, ısıtıcılar ve hava temizleyiciler", false, "Klima ve Isıtıcılar", null, null },
                    { 6, 2, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1033), "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar", false, "Ayakkabı & Çanta", null, null },
                    { 7, 2, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1034), "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim", false, "Kadın Giyim", null, null },
                    { 8, 2, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1037), "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim", false, "Erkek Giyim", null, null },
                    { 9, 2, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1038), "Kız ve erkek çocuk giyim ürünleri", false, "Çocuk Giyim", null, null },
                    { 10, 3, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1040), "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları", false, "Mobilya", null, null },
                    { 11, 3, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1041), "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri", false, "Ev Tekstili", null, null },
                    { 12, 3, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1043), "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri", false, "Dekorasyon & Aydınlatma", null, null },
                    { 13, 3, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1044), "Pişirme, servis ve saklama ürünleri, mutfak aletleri", false, "Mutfak Gereçleri", null, null },
                    { 14, 3, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1046), "Banyo aksesuarları, temizlik ve düzenleme ürünleri", false, "Banyo & Ev Gereçleri", null, null },
                    { 15, 3, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1047), "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri", false, "Kırtasiye & Ofis", null, null },
                    { 16, 4, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1049), "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri", false, "Parfüm & Deodorant", null, null },
                    { 17, 4, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1050), "Saç bakım ve şekillendirme ürünleri", false, "Saç Şekillendirme", null, null },
                    { 18, 4, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1052), "Yüz ve vücut bakım ürünleri, kremler ve serumlar", false, "Cilt Bakımı", null, null },
                    { 19, 4, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1053), "Renkli kozmetik ve makyaj malzemeleri", false, "Makyaj", null, null },
                    { 20, 4, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1055), "Vitamin, takviye gıdalar ve medikal ürünler", false, "Sağlık & Medikal Ürünler", null, null },
                    { 21, 4, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1056), "Diş bakım ürünleri ve ağız bakım ürünleri", false, "Ağız & Diş Bakımı", null, null },
                    { 22, 5, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1057), "Fitness ekipmanları, kondisyon aletleri ve aksesuarları", false, "Fitness & Kondisyon", null, null },
                    { 23, 5, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1059), "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar", false, "Spor Giyim & Ayakkabı", null, null },
                    { 24, 5, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1061), "Kamp malzemeleri, outdoor giyim ve ekipmanlar", false, "Outdoor & Kamp", null, null },
                    { 25, 5, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1062), "Kayak ekipmanları ve kış sporları malzemeleri", false, "Kış Sporları", null, null },
                    { 26, 5, null, new DateTime(2025, 3, 6, 14, 58, 59, 877, DateTimeKind.Local).AddTicks(1064), "Yüzme ve su sporları ekipmanları", false, "Su Sporları", null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedById", "CreatedDate", "Description", "DiscountPrice", "HasDiscount", "IsActive", "IsDeleted", "Name", "Price", "Stock", "SubCategoryId", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, null, new DateTime(2025, 3, 6, 14, 58, 59, 878, DateTimeKind.Local).AddTicks(4550), "Apple iPhone 14 Pro 256 GB Uzay Siyahı Cep Telefonu", 54999.99m, true, true, false, "iPhone 14 Pro", 56999.99m, 100, 3, null, null },
                    { 2, 2, null, null, new DateTime(2025, 3, 6, 14, 58, 59, 878, DateTimeKind.Local).AddTicks(4559), "Samsung Galaxy S23 Ultra 256 GB Krem Cep Telefonu", 39999.99m, true, true, false, "Samsung Galaxy S23", 41999.99m, 150, 3, null, null },
                    { 3, 1, null, null, new DateTime(2025, 3, 6, 14, 58, 59, 878, DateTimeKind.Local).AddTicks(4562), "Apple iPhone 15 128 GB Mavi", 39999.99m, true, true, false, "Apple iPhone 15 128 GB Mavi", 49999.99m, 150, 3, null, null }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "EntityId", "EntityType", "IsDeleted", "Path", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 6, 14, 58, 59, 878, DateTimeKind.Local).AddTicks(4606), 1, 1, false, "img/ProducsPicture/Telephones/TelephoneOne/resimbir.jpg", null, null },
                    { 2, null, new DateTime(2025, 3, 6, 14, 58, 59, 878, DateTimeKind.Local).AddTicks(4645), 2, 1, false, "img/ProducsPicture/Telephones/TelephoneTwo/resimbir.jpg", null, null },
                    { 3, null, new DateTime(2025, 3, 6, 14, 58, 59, 878, DateTimeKind.Local).AddTicks(4648), 3, 1, false, "img/ProducsPicture/Telephones/TelephoneThree/resimbir.jpg", null, null }
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
