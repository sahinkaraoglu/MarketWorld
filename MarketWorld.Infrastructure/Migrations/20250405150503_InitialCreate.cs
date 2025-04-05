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
                    { 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9202), false, "Apple", null, null, null },
                    { 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9204), false, "Asus", null, null, null },
                    { 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9205), false, "Casper", null, null, null },
                    { 4, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9206), false, "HP", null, null, null },
                    { 5, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9207), false, "Lenovo", null, null, null },
                    { 6, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9209), false, "MSI", null, null, null },
                    { 7, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9210), false, "Acer", null, null, null },
                    { 8, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9211), false, "Xiaomi", null, null, null },
                    { 9, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9212), false, "Samsung", null, null, null },
                    { 10, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9213), false, "Huawei", null, null, null },
                    { 11, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9214), false, "Canon", null, null, null },
                    { 12, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9215), false, "Epson", null, null, null },
                    { 13, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9216), false, "Honor", null, null, null },
                    { 14, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9217), false, "Nothing", null, null, null },
                    { 15, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9218), false, "Infinix", null, null, null },
                    { 16, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9219), false, "Redmi", null, null, null },
                    { 17, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9220), false, "POCO", null, null, null },
                    { 18, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9243), false, "Oppo", null, null, null },
                    { 19, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9244), false, "Panasonic", null, null, null },
                    { 20, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9245), false, "Reeder", null, null, null },
                    { 21, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9246), false, "Tecno", null, null, null },
                    { 22, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9247), false, "Arçelik", null, null, null },
                    { 23, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9248), false, "Kumtel", null, null, null },
                    { 24, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9249), false, "Regal", null, null, null },
                    { 25, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9250), false, "Profilo", null, null, null },
                    { 26, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9251), false, "Altus", null, null, null },
                    { 27, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9252), false, "Hoover", null, null, null },
                    { 28, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9253), false, "Uğur", null, null, null },
                    { 29, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9254), false, "Arnell", null, null, null },
                    { 30, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9255), false, "Evora", null, null, null },
                    { 31, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9255), false, "Albergio", null, null, null },
                    { 32, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9256), false, "Kiwi", null, null, null },
                    { 33, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9257), false, "Vestel", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(8988), "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar", false, "Elektronik", "elektronik", null, null },
                    { 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9005), "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları", false, "Giyim & Aksesuar", "giyim-aksesuar", null, null },
                    { 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9006), "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili", false, "Ev & Yaşam", "ev-yasam", null, null },
                    { 4, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9007), "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri", false, "Kozmetik & Kişisel Bakım", "kozmetik-kisisel-bakim", null, null },
                    { 5, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9008), "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri", false, "Spor & Outdoor", "spor-outdoor", null, null }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsActive", "IsDeleted", "Name", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(3948), "Ürün Renk Seçenekleri", true, false, "Renk", null, null },
                    { 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(3956), "Beden Seçenekleri", true, false, "Beden", null, null },
                    { 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(3957), "Dahili Hafıza", true, false, "Hafıza", null, null },
                    { 4, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(3958), "Bilgisayar İşlemci Seçenekleri", true, false, "İşlemci", null, null },
                    { 5, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(3960), "Bellek Kapasitesi", true, false, "RAM", null, null },
                    { 6, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(3962), "SSD Kapasitesi", true, false, "SSD", null, null },
                    { 7, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(3963), "Ekran Boyutu", true, false, "Ekran", null, null },
                    { 8, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(3964), "Yazıcı Teknolojisi", true, false, "Yazıcı Tipi", null, null },
                    { 9, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(3966), "Mürekkep/Kartuş Sistemi", true, false, "Mürekkep Sistemi", null, null },
                    { 10, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(3967), "Desteklenen Kağıt Boyutları", true, false, "Kağıt Boyutu", null, null },
                    { 11, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(3968), "Yazıcı Fonksiyonları", true, false, "Fonksiyonlar", null, null }
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
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedById", "CreatedDate", "Description", "DiscountPrice", "HasDiscount", "IsActive", "IsDeleted", "Name", "Price", "Rating", "Stock", "SubCategoryId", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 106, 13, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9666), "HONOR 200 512 GB 12 GB Ram Zümrüt Yeşili", 0m, false, true, false, "HONOR 200 512 GB 12 GB Ram Zümrüt Yeşili", 23999m, 0m, 0, null, null, null },
                    { 107, 1, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9668), "Apple iPhone 16 Pro 256GB Siyah", 0m, false, true, false, "Apple iPhone 16 Pro 256GB Siyah", 88825m, 0m, 0, null, null, null },
                    { 108, 16, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9669), "Xiaomi Redmi Note 13 Pro 256GB 8gb Ram Mor", 0m, false, true, false, "Xiaomi Redmi Note 13 Pro 256GB 8gb Ram Mor", 15999m, 0m, 0, null, null, null },
                    { 109, 9, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9671), "Samsung Galaxy S25 128 GB 12 GB Ram Lacivert", 0m, false, true, false, "Samsung Galaxy S25 128 GB 12 GB Ram Lacivert", 45999m, 0m, 0, null, null, null },
                    { 110, 1, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9672), "Apple iPhone 16 256GB Lacivert Taş", 0m, false, true, false, "Apple iPhone 16 256GB Lacivert Taş", 66999m, 0m, 0, null, null, null },
                    { 111, 16, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9674), "Xiaomi Redmi Note 14 Pro Plus 5g 512 GB 12 GB Ram", 0m, false, true, false, "Xiaomi Redmi Note 14 Pro Plus 5g 512 GB 12 GB Ram", 27250m, 0m, 0, null, null, null },
                    { 112, 1, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9700), "Apple iPhone 16 Pro Max 512GB Natürel Titanyum", 0m, false, true, false, "Apple iPhone 16 Pro Max 512GB Natürel Titanyum", 101939m, 0m, 0, null, null, null },
                    { 113, 9, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9702), "Samsung Galaxy A04S 64 GB Siyah", 0m, false, true, false, "Samsung Galaxy A04S 64 GB Siyah", 6839m, 0m, 0, null, null, null },
                    { 114, 16, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9704), "Redmi Note 14 Pro 5G 12GB 512GB", 0m, false, true, false, "Redmi Note 14 Pro 5G 12GB 512GB", 22500m, 0m, 0, null, null, null },
                    { 115, 14, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9706), "Nothing Phone 1 128 GB 8 GB Ram Siyah", 0m, false, true, false, "Nothing Phone 1 128 GB 8 GB Ram Siyah", 12999m, 0m, 0, null, null, null },
                    { 116, 16, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9707), "Xiaomi Redmi Note 13 Pro 512GB 12GB Siyah", 0m, false, true, false, "Xiaomi Redmi Note 13 Pro 512GB 12GB Siyah", 18999m, 0m, 0, null, null, null },
                    { 117, 16, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9709), "Xiaomi Redmi 12 128 GB 8 GB Ram Siyah", 0m, false, true, false, "Xiaomi Redmi 12 128 GB 8 GB Ram Siyah", 8190m, 0m, 0, null, null, null },
                    { 118, 13, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9710), "HONOR Magic V3 512 GB 12 GB Ram Yeşil", 0m, false, true, false, "HONOR Magic V3 512 GB 12 GB Ram Yeşil", 79999m, 0m, 0, null, null, null },
                    { 119, 21, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9712), "Tecno Spark 30 256 GB 8 GB Ram", 0m, false, true, false, "Tecno Spark 30 256 GB 8 GB Ram", 9199m, 0m, 0, null, null, null },
                    { 120, 9, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9714), "Samsung Galaxy S25 Ultra 1 Tb 12 GB Ram", 0m, false, true, false, "Samsung Galaxy S25 Ultra 1 Tb 12 GB Ram", 88999m, 0m, 0, null, null, null },
                    { 121, 1, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9715), "Apple iPhone 16 Pro 128GB Siyah", 0m, false, true, false, "Apple iPhone 16 Pro 128GB Siyah", 79324m, 0m, 0, null, null, null },
                    { 122, 20, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9717), "Reeder P13 Blue Max L 2022 64 GB Beyaz", 0m, false, true, false, "Reeder P13 Blue Max L 2022 64 GB Beyaz", 3399m, 0m, 0, null, null, null },
                    { 123, 17, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9718), "POCO X7 12GB 512GB", 0m, false, true, false, "POCO X7 12GB 512GB", 17499m, 0m, 0, null, null, null },
                    { 124, 18, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9721), "Oppo A60 8GB 256GB Mavi", 0m, false, true, false, "Oppo A60 8GB 256GB Mavi", 10199m, 0m, 0, null, null, null },
                    { 125, 9, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9723), "Samsung Galaxy A25 5G 256 GB 8 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A25 5G 256 GB 8 GB Ram Siyah", 13250m, 0m, 0, null, null, null },
                    { 126, 9, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9724), "Samsung Galaxy S25 256 GB Lacivert", 0m, false, true, false, "Samsung Galaxy S25 256 GB Lacivert", 47670m, 0m, 0, null, null, null },
                    { 127, 19, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9726), "Panasonic KX-TU550EXB Katlanabilir Renkli Ekran 4g Tuşlu Cep Telefonu Siyah", 0m, false, true, false, "Panasonic KX-TU550EXB Katlanabilir Renkli Ekran 4g Tuşlu Cep Telefonu Siyah", 4269m, 0m, 0, null, null, null },
                    { 128, 20, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9727), "Reeder S19 Max Pro 256 GB 6 GB Ram Siyah", 0m, false, true, false, "Reeder S19 Max Pro 256 GB 6 GB Ram Siyah", 4799m, 0m, 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "PropertyValues",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "PropertyTypeId", "UpdatedById", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(3997), true, false, 1, null, null, "Uzay Siyahı" },
                    { 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4002), true, false, 1, null, null, "Altın" },
                    { 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4003), true, false, 1, null, null, "Gümüş" },
                    { 4, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4004), true, false, 1, null, null, "Mor" },
                    { 5, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4005), true, false, 2, null, null, "XS" },
                    { 6, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4007), true, false, 2, null, null, "S" },
                    { 7, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4008), true, false, 2, null, null, "M" },
                    { 8, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4009), true, false, 2, null, null, "L" },
                    { 9, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4011), true, false, 2, null, null, "XL" },
                    { 10, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4012), true, false, 2, null, null, "XXL" },
                    { 11, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4013), true, false, 3, null, null, "128GB" },
                    { 12, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4015), true, false, 3, null, null, "256GB" },
                    { 13, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4016), true, false, 3, null, null, "512GB" },
                    { 14, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4020), true, false, 3, null, null, "1TB" },
                    { 15, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4021), true, false, 4, null, null, "Intel Core i7 12700H" },
                    { 16, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4022), true, false, 4, null, null, "Intel Core i7 1255U" },
                    { 17, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4023), true, false, 4, null, null, "Intel Core i7 13620H" },
                    { 18, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4025), true, false, 4, null, null, "Intel Core i5 1334U" },
                    { 19, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4026), true, false, 4, null, null, "Intel Core i5 13420H" },
                    { 20, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4027), true, false, 4, null, null, "AMD Ryzen 7 5700U" },
                    { 21, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4028), true, false, 4, null, null, "Intel Core i5 12450H" },
                    { 22, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4028), true, false, 5, null, null, "8GB" },
                    { 23, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4030), true, false, 5, null, null, "16GB" },
                    { 24, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4032), true, false, 5, null, null, "32GB" },
                    { 25, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4033), true, false, 6, null, null, "256GB" },
                    { 26, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4034), true, false, 6, null, null, "500GB" },
                    { 27, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4035), true, false, 6, null, null, "512GB" },
                    { 28, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4036), true, false, 6, null, null, "1TB" },
                    { 29, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4037), true, false, 7, null, null, "14\"" },
                    { 30, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4038), true, false, 7, null, null, "15.6\"" },
                    { 31, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4039), true, false, 7, null, null, "16\"" },
                    { 32, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4039), true, false, 4, null, null, "Intel Core i7 13650HX" },
                    { 33, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4041), true, false, 4, null, null, "Intel Core i5 13500H" },
                    { 34, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4043), true, false, 4, null, null, "Intel Core i9-14900HX" },
                    { 35, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4044), true, false, 4, null, null, "Intel Core Ultra 7 255HX" },
                    { 36, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4045), true, false, 4, null, null, "AMD Ryzen 5 7520U" },
                    { 37, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4071), true, false, 8, null, null, "Mürekkep Püskürtmeli" },
                    { 38, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4072), true, false, 8, null, null, "Lazer" },
                    { 39, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4073), true, false, 8, null, null, "Süblimasyon" },
                    { 40, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4074), true, false, 9, null, null, "Kartuşlu" },
                    { 41, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4075), true, false, 9, null, null, "Tanklı" },
                    { 42, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4076), true, false, 9, null, null, "Dolum Üniteli" },
                    { 43, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4077), true, false, 10, null, null, "A4" },
                    { 44, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4078), true, false, 10, null, null, "A3" },
                    { 45, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4079), true, false, 10, null, null, "A4/A3" },
                    { 46, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4080), true, false, 11, null, null, "Yazdırma" },
                    { 47, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4081), true, false, 11, null, null, "Tarama" },
                    { 48, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4082), true, false, 11, null, null, "Fotokopi" },
                    { 49, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4083), true, false, 11, null, null, "Faks" },
                    { 50, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4084), true, false, 11, null, null, "Wi-Fi" },
                    { 51, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4086), true, false, 11, null, null, "AirPrint" },
                    { 52, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4087), true, false, 1, null, null, "Siyah" },
                    { 53, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4088), true, false, 1, null, null, "Beyaz" },
                    { 54, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4089), true, false, 1, null, null, "Gri" },
                    { 55, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4090), true, false, 1, null, null, "Açık Mavi" },
                    { 56, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4091), true, false, 1, null, null, "Lacivert" },
                    { 57, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4092), true, false, 1, null, null, "Mavi" },
                    { 58, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4099), true, false, 1, null, null, "Mor" },
                    { 59, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4101), true, false, 1, null, null, "Altın" },
                    { 60, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4103), true, false, 1, null, null, "Nane Yeşili" },
                    { 61, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4104), true, false, 1, null, null, "Zümrüt Yeşili" },
                    { 62, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4105), true, false, 1, null, null, "Lacivert Taş" },
                    { 63, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4106), true, false, 1, null, null, "Natürel Titanyum" },
                    { 64, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4107), true, false, 1, null, null, "Grafit" },
                    { 65, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4108), true, false, 1, null, null, "Antrasit" },
                    { 66, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4110), true, false, 1, null, null, "Inox" },
                    { 67, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4111), true, false, 1, null, null, "Kırmızı" },
                    { 68, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4112), true, false, 1, null, null, "Turkuaz" },
                    { 69, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4113), true, false, 1, null, null, "Pembe" },
                    { 70, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4114), true, false, 1, null, null, "Turuncu" },
                    { 71, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4115), true, false, 1, null, null, "Sarı" },
                    { 72, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4116), true, false, 1, null, null, "Kahverengi" },
                    { 73, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4117), true, false, 1, null, null, "Bej" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedDate", "Description", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9138), "Dizüstü, masaüstü bilgisayarlar ve tabletler", false, "Bilgisayarlar & Tabletler", "bilgisayarlar-tabletler", null, null },
                    { 2, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9140), "Yazıcılar, tarayıcılar ve projeksiyon cihazları", false, "Yazıcılar & Projeksiyon", "yazicilar-projeksiyon", null, null },
                    { 3, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9141), "Akıllı telefonlar ve aksesuarları", false, "Telefonlar", "telefonlar", null, null },
                    { 4, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9142), "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar", false, "Beyaz Eşya", "beyaz-esya", null, null },
                    { 5, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9143), "Klimalar, ısıtıcılar ve hava temizleyiciler", false, "Klima ve Isıtıcılar", "klima-isitici", null, null },
                    { 6, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9145), "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar", false, "Ayakkabı & Çanta", "ayakkabi-canta", null, null },
                    { 7, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9146), "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim", false, "Kadın Giyim", "kadin-giyim", null, null },
                    { 8, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9147), "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim", false, "Erkek Giyim", "erkek-giyim", null, null },
                    { 9, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9148), "Kız ve erkek çocuk giyim ürünleri", false, "Çocuk Giyim", "cocuk-giyim", null, null },
                    { 10, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9150), "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları", false, "Mobilya", "mobilya", null, null },
                    { 11, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9151), "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri", false, "Ev Tekstili", "ev-tekstili", null, null },
                    { 12, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9152), "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri", false, "Dekorasyon & Aydınlatma", "dekorasyon-aydinlatma", null, null },
                    { 13, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9153), "Pişirme, servis ve saklama ürünleri, mutfak aletleri", false, "Mutfak Gereçleri", "mutfak-gerecleri", null, null },
                    { 14, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9155), "Banyo aksesuarları, temizlik ve düzenleme ürünleri", false, "Banyo & Ev Gereçleri", "banyo-ev-gerecleri", null, null },
                    { 15, 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9156), "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri", false, "Kırtasiye & Ofis", "kirtasiye-ve-ofis", null, null },
                    { 16, 4, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9157), "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri", false, "Parfüm & Deodorant", "parfum-deodorant", null, null },
                    { 17, 4, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9158), "Saç bakım ve şekillendirme ürünleri", false, "Saç Şekillendirme", "sac-sekillendirme", null, null },
                    { 18, 4, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9159), "Yüz ve vücut bakım ürünleri, kremler ve serumlar", false, "Cilt Bakımı", "cilt-bakimi", null, null },
                    { 19, 4, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9160), "Renkli kozmetik ve makyaj malzemeleri", false, "Makyaj", "makyaj", null, null },
                    { 20, 4, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9161), "Vitamin, takviye gıdalar ve medikal ürünler", false, "Sağlık & Medikal Ürünler", "saglik-medikal-urunler", null, null },
                    { 21, 4, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9164), "Diş bakım ürünleri ve ağız bakım ürünleri", false, "Ağız & Diş Bakımı", "agiz-dis-bakimi", null, null },
                    { 22, 5, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9165), "Fitness ekipmanları, kondisyon aletleri ve aksesuarları", false, "Fitness & Kondisyon", "fitness-kondisyon", null, null },
                    { 23, 5, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9166), "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar", false, "Spor Giyim & Ayakkabı", "spor-giyim-ayakkabi", null, null },
                    { 24, 5, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9167), "Kamp malzemeleri, outdoor giyim ve ekipmanlar", false, "Outdoor & Kamp", "outdoor-kamp", null, null },
                    { 25, 5, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9168), "Kayak ekipmanları ve kış sporları malzemeleri", false, "Kış Sporları", "kis-sporlari", null, null },
                    { 26, 5, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9169), "Yüzme ve su sporları ekipmanları", false, "Su Sporları", "su-sporlari", null, null }
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
                table: "Images",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "EntityId", "EntityType", "IsDeleted", "Path", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 106, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(127), 106, 1, false, "img/Products/Phones/honor_200_512_gb_12_gb_ram_honor_trkiye_garantili_zmrt_yeili.jpg", null, null },
                    { 107, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(128), 107, 1, false, "img/Products/Phones/apple_iphone_16_pro_256gb_siyah.jpg", null, null },
                    { 108, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(129), 108, 1, false, "img/Products/Phones/xiaomi_redmi_note_13_pro_256gb_8gb_ram_xiaomi_trkiye_garantili_mor.jpg", null, null },
                    { 109, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(130), 109, 1, false, "img/Products/Phones/samsung_galaxy_s25_128_gb_12_gb_ram_samsung_trkiye_garantili_lacivert.jpg", null, null },
                    { 110, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(131), 110, 1, false, "img/Products/Phones/apple_iphone_16_256gb_lacivert_ta.jpg", null, null },
                    { 111, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(132), 111, 1, false, "img/Products/Phones/xiaomi_redmi_note_14_pro_plus_5g_512_gb_12_gb_ram_xiaomi_trkiye_garantili.jpg", null, null },
                    { 112, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(133), 112, 1, false, "img/Products/Phones/apple_iphone_16_pro_max_512gb_natrel_titanyum.jpg", null, null },
                    { 113, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(135), 113, 1, false, "img/Products/Phones/samsung_galaxy_a04s_64_gb_samsung_trkiye_garantili_siyah_64_gb_siyah.jpg", null, null },
                    { 114, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(136), 114, 1, false, "img/Products/Phones/redmi_note_14_pro_5g_12gb_512gb_xiaomi_trkiye_garantili.jpg", null, null },
                    { 115, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(137), 115, 1, false, "img/Products/Phones/nothing_phone_1_128_gb_8_gb_ram_nothing_trkiye_garantili_siyah.jpg", null, null },
                    { 116, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(138), 116, 1, false, "img/Products/Phones/xiaomi_redmi_note_13_pro_512gb_12gb_xiaomi_trkiye_garantili_siyah.jpg", null, null },
                    { 117, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(139), 117, 1, false, "img/Products/Phones/xiaomi_redmi_12_128_gb_8_gb_ram_xiaomi_trkiye_garantili_siyah.jpg", null, null },
                    { 118, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(141), 118, 1, false, "img/Products/Phones/honor_magic_v3_512_gb_12_gb_ram_honor_trkiye_garantili_yeil.jpg", null, null },
                    { 119, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(142), 119, 1, false, "img/Products/Phones/tecno_spark_30_256_gb_8_gb_ram.jpg", null, null },
                    { 120, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(143), 120, 1, false, "img/Products/Phones/samsung_galaxy_s25_ultra_1_tb_12_gb_ram_samsung_trkiye_garantili.jpg", null, null },
                    { 121, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(144), 121, 1, false, "img/Products/Phones/apple_iphone_16_pro_128gb_siyah.jpg", null, null },
                    { 122, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(145), 122, 1, false, "img/Products/Phones/reeder_p13_blue_max_l_2022_64_gb_reeder_trkiye_garantili_beyaz.jpg", null, null },
                    { 123, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(171), 123, 1, false, "img/Products/Phones/poco_poco_x7_12gb_512gb_xiaomi_trkiye_garantili.jpg", null, null },
                    { 124, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(172), 124, 1, false, "img/Products/Phones/oppo_a60_8gb_256gb_oppo_trkiye_garantili_mavi.jpg", null, null },
                    { 125, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(174), 125, 1, false, "img/Products/Phones/samsung_galaxy_a25_5g_256_gb_8_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 126, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(175), 126, 1, false, "img/Products/Phones/samsung_galaxy_s25_256_gb_lacivert.jpg", null, null },
                    { 127, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(176), 127, 1, false, "img/Products/Phones/panasonic_kx-tu550exb_katlanabilir_renkli_ekran_4g_tulu_cep_telefonu_siyah_2_yl_trkiye_distribtr_garantili_siyah.jpg", null, null },
                    { 128, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(177), 128, 1, false, "img/Products/Phones/reeder_s19_max_pro_256_gb_6_gb_ram_reeder_trkiye_garantili_siyah.jpg", null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductProperties",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "ProductId", "PropertyTypeId", "PropertyValueId", "Stock", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 775, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(7480), true, false, 106, 1, 61, 50, null, null },
                    { 776, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(7481), true, false, 106, 3, 14, 50, null, null },
                    { 777, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(7750), true, false, 107, 1, 52, 50, null, null },
                    { 778, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(7750), true, false, 107, 3, 14, 50, null, null },
                    { 779, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(8005), true, false, 108, 1, 58, 50, null, null },
                    { 780, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(8005), true, false, 108, 3, 14, 50, null, null },
                    { 781, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(8288), true, false, 109, 1, 56, 50, null, null },
                    { 782, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(8289), true, false, 109, 3, 11, 50, null, null },
                    { 783, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(8541), true, false, 110, 1, 62, 50, null, null },
                    { 784, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(8542), true, false, 110, 3, 14, 50, null, null },
                    { 785, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(8798), true, false, 111, 1, 52, 50, null, null },
                    { 786, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(8799), true, false, 111, 3, 14, 50, null, null },
                    { 787, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(9211), true, false, 112, 1, 63, 50, null, null },
                    { 788, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(9212), true, false, 112, 3, 14, 50, null, null },
                    { 789, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(9573), true, false, 113, 1, 52, 50, null, null },
                    { 790, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(9603), true, false, 113, 3, 11, 50, null, null },
                    { 791, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(9877), true, false, 114, 1, 52, 50, null, null },
                    { 792, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(9878), true, false, 114, 3, 14, 50, null, null },
                    { 793, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(138), true, false, 115, 1, 52, 50, null, null },
                    { 794, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(139), true, false, 115, 3, 11, 50, null, null },
                    { 795, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(404), true, false, 116, 1, 52, 50, null, null },
                    { 796, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(404), true, false, 116, 3, 14, 50, null, null },
                    { 797, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(682), true, false, 117, 1, 52, 50, null, null },
                    { 798, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(683), true, false, 117, 3, 11, 50, null, null },
                    { 799, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(961), true, false, 118, 1, 61, 50, null, null },
                    { 800, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(961), true, false, 118, 3, 14, 50, null, null },
                    { 801, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(1223), true, false, 119, 1, 52, 50, null, null },
                    { 802, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(1224), true, false, 119, 3, 14, 50, null, null },
                    { 803, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(1473), true, false, 120, 1, 52, 50, null, null },
                    { 804, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(1473), true, false, 120, 3, 14, 50, null, null },
                    { 805, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(1723), true, false, 121, 1, 52, 50, null, null },
                    { 806, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(1724), true, false, 121, 3, 11, 50, null, null },
                    { 807, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(2002), true, false, 122, 1, 53, 50, null, null },
                    { 808, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(2004), true, false, 122, 3, 11, 50, null, null },
                    { 809, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(2364), true, false, 123, 1, 52, 50, null, null },
                    { 810, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(2364), true, false, 123, 3, 14, 50, null, null },
                    { 811, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(2794), true, false, 124, 1, 57, 50, null, null },
                    { 812, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(2794), true, false, 124, 3, 14, 50, null, null },
                    { 813, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(3188), true, false, 125, 1, 52, 50, null, null },
                    { 814, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(3189), true, false, 125, 3, 14, 50, null, null },
                    { 815, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(3484), true, false, 126, 1, 56, 50, null, null },
                    { 816, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(3485), true, false, 126, 3, 14, 50, null, null },
                    { 817, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(3751), true, false, 127, 1, 52, 50, null, null },
                    { 818, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(3752), true, false, 127, 3, 11, 50, null, null },
                    { 819, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(4037), true, false, 128, 1, 52, 50, null, null },
                    { 820, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(4038), true, false, 128, 3, 14, 50, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedById", "CreatedDate", "Description", "DiscountPrice", "HasDiscount", "IsActive", "IsDeleted", "Name", "Price", "Rating", "Stock", "SubCategoryId", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 3, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9304), "Intel Core i7 12700H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1270", 39999.99m, 4.5m, 100, 1, null, null },
                    { 2, 6, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9313), "Intel Core i7 1255U 16GB 512GB SSD Freedos 14\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "MSI Modern 14 C12MO", 21799.99m, 4.5m, 75, 1, null, null },
                    { 3, 3, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9317), "Core i7-13620H 32GB DDR5 RAM 1TB NVME SSD 16\" Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana S100", 27299.99m, 5m, 50, 1, null, null },
                    { 4, 3, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9319), "Intel Core i7 13620H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1362", 50199.99m, 4.5m, 60, 1, null, null },
                    { 5, 4, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9321), "Intel Core i5 1334U 16GB 512GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "HP 250 G10", 14999.99m, 4.7m, 100, 1, null, null },
                    { 6, 5, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9324), "Intel Core i5 13420H 16GB Ddr5 Ram 512 GB SSD 16'' WUXGA IPS Panel Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad Slim 3", 19799.99m, 4.9m, 80, 1, null, null },
                    { 7, 5, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9326), "AMD Ryzen 7 5700U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad 1", 15999.99m, 4.6m, 90, 1, null, null },
                    { 8, 6, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9328), "Intel Core i5 12450H 8GB 512GB SSD RTX2050 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "MSI Thin 15", 24799.99m, 4.5m, 70, 1, null, null },
                    { 9, 3, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9331), "Intel Core i7 1255U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana C550", 18999.99m, 4.5m, 85, 1, null, null },
                    { 10, 5, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9334), "Intel Core i7 13650HX 32GB 1TB SSD RTX 4060 8GB (115W) 15.6\" FHD 144Hz IPS Panel Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo LOQ 15IRX9", 59999.99m, 5m, 45, 1, null, null },
                    { 11, 3, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9336), "Intel Core i5-12450H 32GB RAM 500GB SSD GEN4 RTX3050 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G770", 31299.99m, 4.6m, 65, 1, null, null },
                    { 12, 3, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9338), "AMD Ryzen 5 7430U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana X600", 16999.99m, 5m, 80, 1, null, null },
                    { 13, 7, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9340), "Intel Core i7 1255U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Acer Aspire 3", 24000.00m, 5m, 70, 1, null, null },
                    { 14, 3, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9342), "Intel Core i7 12700H 32GB 1TB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana X600.1270", 22999.99m, 4.5m, 85, 1, null, null },
                    { 15, 3, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9344), "Intel Core i5-13420H 32GB RAM 500GB NVME SSD GEN4 6GB RTX4050 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G870.1342", 38499.99m, 4.1m, 55, 1, null, null },
                    { 16, 3, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9349), "Intel Core i7 12700H 32GB 1TB SSD RTX4070 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1270", 50899.99m, 4m, 40, 1, null, null },
                    { 17, 4, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9351), "Intel Core i5 13500H 16GB 512GB SSD RTX4050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "HP Victus Gaming 15", 33999.99m, 4.6m, 90, 1, null, null },
                    { 18, 5, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9380), "Intel Core i5 12450H 8GB 512GB SSD 15.6\" FHD Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo IdeaPad Slim 3", 15359.04m, 4.7m, 100, 1, null, null },
                    { 19, 2, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9382), "Intel Core i5 12500H 8GB 512GB SSD RTX3050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Asus TUF Gaming F15", 29898.66m, 4.7m, 75, 1, null, null },
                    { 20, 1, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9384), "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Uzay Grisi", 0m, false, true, false, "Apple MacBook Air M1", 39250.00m, 4.9m, 60, 1, null, null },
                    { 21, 3, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9386), "Intel Core i5-13420H 16GB RAM 1TB NVME SSD 8GB RTX4060 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G870.1342", 42299.99m, 4.3m, 50, 1, null, null },
                    { 22, 5, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9388), "Intel Core i5 13420H 16GB 512GB SSD Freedos 14\" WUXGA Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad 5", 29999.99m, 5m, 70, 1, null, null },
                    { 23, 2, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9392), "Intel Core Ultra 7 255HX 32GB 1TB SSD RTX5070Ti Freedos 16\" Taşınabilir Bilgisayar", 0m, false, true, false, "Asus ROG Strix G16", 107999.99m, 5m, 25, 1, null, null },
                    { 24, 3, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9394), "Intel Core i5-13420H 32GB RAM 500GB NVME SSD Freedos", 0m, false, true, false, "Casper Nirvana X600.1342", 19999.99m, 5m, 85, 1, null, null },
                    { 25, 5, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9396), "Intel Core i9-14900HX 32GB DDR5 1TB SSD RTX4060 8GB 16 inç 3.2K (3200×2000) 165Hz FreeDos Laptop", 0m, false, true, false, "Lenovo Thinkbook 16PG5", 79999.40m, 4.7m, 30, 1, null, null },
                    { 26, 3, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9398), "Intel Core i7-13620H 16GB RAM 500GB NVME SSD Freedos Laptop", 0m, false, true, false, "Casper Nirvana X600.1362", 22099.99m, 5m, 75, 1, null, null },
                    { 27, 6, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9400), "Intel Core i5 13420H 16GB 1TB SSD RTX4060 Freedos 15.6\" FHD 144Hz Taşınabilir Bilgisayar", 0m, false, true, false, "MSI CYBORG 15", 37999.99m, 4.9m, 60, 1, null, null },
                    { 28, 5, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9402), "AMD Ryzen 5 7520U 8gb 512GB SSD Freedos 15.6\" Fhd Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo V15 G4", 13299.99m, 4.3m, 95, 1, null, null },
                    { 29, 5, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9404), "I5-13420H 32GB 1 Tb SSD 15.6 Fhd Windows 11 Pro", 0m, false, true, false, "Lenovo V15 G4", 27749.00m, 5m, 70, 1, null, null },
                    { 30, 1, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9409), "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Gece Yarısı", 0m, false, true, false, "Apple MacBook Air M4", 49999.99m, 5m, 45, 1, null, null },
                    { 31, 3, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9411), "Intel Core i5 12450H 16GB 500GB SSD RTX2050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1245", 27499.99m, 4.4m, 80, 1, null, null },
                    { 32, 4, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9413), "HP Deskjet Ink Advantage 2878 All-In-One Yazıcı", 0m, false, true, false, "HP Deskjet Ink Advantage 2878 All-In-One Yazıcı", 2799.00m, 4.1m, 100, 2, null, null },
                    { 33, 11, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9415), "Canon Dolan Kartuşlu E414 Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Canon Dolan Kartuşlu E414 Yazıcı", 2299.08m, 4.4m, 150, 2, null, null },
                    { 34, 11, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9418), "Canon Pixma TR4650 Tarayıcı + Fotokopi + Wi-Fi + Faks + Çok Fonksiyonlu Yazıcı", 0m, false, true, false, "Canon Pixma TR4650", 3379.00m, 4.2m, 75, 2, null, null },
                    { 35, 11, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9420), "Canon Pixma E3640 Wi-Fi Tarayıcı - Fotokopi Çok Fonksiyonlu Mürekkep Püskürtmeli Yazıcı", 0m, false, true, false, "Canon Pixma E3640 Wi-Fi", 3399.00m, 4.6m, 120, 2, null, null },
                    { 36, 12, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9427), "Epson L5290 Wi-Fi Renk Tanklı Yazıcı", 0m, false, true, false, "Epson L5290 Wi-Fi Renk Tanklı Yazıcı", 11983.51m, 4.4m, 60, 2, null, null },
                    { 37, 12, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9429), "Epson Tanklı L3150 Photoink Muadil Mürekkepli Tanklı Yazıcı", 0m, false, true, false, "Epson Tanklı L3150 Photoink", 6033.86m, 4.6m, 90, 2, null, null },
                    { 38, 4, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9431), "HP Officejet Pro 7720 Fotokopi + Faks + Tarayıcı + Wi-Fi + Airprint + A3 Yazıcı", 0m, false, true, false, "HP Officejet Pro 7720", 11138.06m, 4.6m, 45, 2, null, null },
                    { 39, 11, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9433), "Canon E3640 Wifi Yazıcı ve Tıpalı Kartuş Sistemi", 0m, false, true, false, "Canon E3640 Wifi Yazıcı", 3306.56m, 4.3m, 100, 2, null, null },
                    { 40, 12, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9435), "Epson L3151 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L3151 Tanklı Yazıcı", 4999.00m, 4.5m, 120, 2, null, null },
                    { 41, 4, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9437), "HP LaserJet Pro M428f MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428f", 7999.00m, 4.3m, 80, 2, null, null },
                    { 42, 11, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9440), "Canon PIXMA G3110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G3110", 3999.00m, 4.4m, 150, 2, null, null },
                    { 43, 12, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9443), "Epson L3250 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L3250 Tanklı Yazıcı", 4499.00m, 4.6m, 100, 2, null, null },
                    { 44, 4, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9447), "HP LaserJet Pro M428dw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428dw", 8999.00m, 4.5m, 60, 2, null, null },
                    { 45, 11, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9449), "Canon PIXMA G4110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G4110", 4499.00m, 4.3m, 90, 2, null, null },
                    { 46, 12, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9451), "Epson L4260 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4260 Tanklı Yazıcı", 5499.00m, 4.7m, 75, 2, null, null },
                    { 47, 4, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9453), "HP LaserJet Pro M428fnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fnw", 9999.00m, 4.4m, 50, 2, null, null },
                    { 48, 11, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9477), "Canon PIXMA G5110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G5110", 4999.00m, 4.5m, 110, 2, null, null },
                    { 49, 12, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9479), "Epson L4266 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4266 Tanklı Yazıcı", 5999.00m, 4.6m, 85, 2, null, null },
                    { 50, 4, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9481), "HP LaserJet Pro M428fdw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdw", 10999.00m, 4.5m, 45, 2, null, null },
                    { 51, 11, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9484), "Canon PIXMA G6110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G6110", 5499.00m, 4.4m, 95, 2, null, null },
                    { 52, 12, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9486), "Epson L4268 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4268 Tanklı Yazıcı", 6499.00m, 4.7m, 70, 2, null, null },
                    { 53, 4, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9488), "HP LaserJet Pro M428fdn MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdn", 11999.00m, 4.6m, 40, 2, null, null },
                    { 54, 11, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9490), "Canon PIXMA G7110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G7110", 5999.00m, 4.5m, 80, 2, null, null },
                    { 55, 12, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9493), "Epson L4269 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4269 Tanklı Yazıcı", 6999.00m, 4.8m, 60, 2, null, null },
                    { 56, 4, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9496), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 12999.00m, 4.7m, 35, 2, null, null },
                    { 57, 11, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9498), "Canon PIXMA G8110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G8110", 6499.00m, 4.6m, 70, 2, null, null },
                    { 58, 12, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9500), "Epson L4267 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4267 Tanklı Yazıcı", 7499.00m, 4.9m, 50, 2, null, null },
                    { 59, 4, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9502), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 13999.00m, 4.8m, 30, 2, null, null },
                    { 60, 11, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9505), "Canon PIXMA G9110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G9110", 6999.00m, 4.7m, 60, 2, null, null },
                    { 61, 12, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9507), "Epson L4265 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4265 Tanklı Yazıcı", 7999.00m, 4.8m, 45, 2, null, null },
                    { 62, 4, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9509), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 14999.00m, 4.9m, 25, 2, null, null },
                    { 63, 11, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9513), "Canon PIXMA G1010 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1010", 7499.00m, 4.8m, 50, 2, null, null },
                    { 64, 12, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9515), "Epson L4264 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4264 Tanklı Yazıcı", 8499.00m, 4.9m, 40, 2, null, null },
                    { 65, 4, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9517), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 15999.00m, 5.0m, 20, 2, null, null },
                    { 66, 11, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9520), "Canon PIXMA G1110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1110", 7999.00m, 4.9m, 45, 2, null, null },
                    { 67, 12, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9522), "Epson L4263 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4263 Tanklı Yazıcı", 8999.00m, 5.0m, 35, 2, null, null },
                    { 68, 4, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9525), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 16999.00m, 5.0m, 15, 2, null, null },
                    { 69, 11, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9527), "Canon PIXMA G1210 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1210", 8499.00m, 5.0m, 40, 2, null, null },
                    { 70, 12, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9529), "Epson L4262 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4262 Tanklı Yazıcı", 9499.00m, 5.0m, 30, 2, null, null },
                    { 71, 4, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9531), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 17999.00m, 5.0m, 10, 2, null, null },
                    { 72, 11, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9533), "Canon PIXMA G1310 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1310", 8999.00m, 5.0m, 35, 2, null, null },
                    { 73, 12, 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9535), "Epson L4261 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4261 Tanklı Yazıcı", 9999.00m, 5.0m, 25, 2, null, null },
                    { 74, 1, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9537), "Apple iPhone 13 128 GB Beyaz", 0m, false, true, false, "Apple iPhone 13 128 GB Beyaz", 1149m, 4.5m, 50, 3, null, null },
                    { 75, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9539), "Samsung Galaxy A06 128 GB 4 GB RAM Siyah", 0m, false, true, false, "Samsung Galaxy A06 128 GB 4 GB RAM Siyah", 1149m, 4.0m, 50, 3, null, null },
                    { 76, 1, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9544), "Apple iPhone 13 128 GB Siyah", 0m, false, true, false, "Apple iPhone 13 128 GB Siyah", 33699m, 4.5m, 50, 3, null, null },
                    { 77, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9549), "Samsung Galaxy A16 128 GB 6 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A16 128 GB 6 GB Ram Siyah", 8789m, 4.2m, 50, 3, null, null },
                    { 78, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9576), "Samsung Galaxy A35 256 GB 8 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A35 256 GB 8 GB Ram Siyah", 14449m, 4.3m, 50, 3, null, null },
                    { 79, 13, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9578), "HONOR Magic 7 Lite 256 GB 8 GB Ram Mor", 0m, false, true, false, "HONOR Magic 7 Lite 256 GB 8 GB Ram Mor", 15999m, 4.4m, 50, 3, null, null },
                    { 80, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9581), "Samsung Galaxy A06 128 GB 4 GB Ram Açık Mavi", 0m, false, true, false, "Samsung Galaxy A06 128 GB 4 GB Ram Açık Mavi", 6303m, 4.0m, 50, 3, null, null },
                    { 81, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9586), "Samsung Galaxy S24+ 256 GB 12 GB Ram Gri", 0m, false, true, false, "Samsung Galaxy S24+ 256 GB 12 GB Ram Gri", 41599m, 4.8m, 50, 3, null, null },
                    { 82, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9588), "Samsung Galaxy A16 128 GB 6 GB Ram Gri", 0m, false, true, false, "Samsung Galaxy A16 128 GB 6 GB Ram Gri", 8789m, 4.2m, 50, 3, null, null },
                    { 83, 13, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9592), "HONOR Magic 7 Lite 256 GB 8 GB Ram Siyah", 0m, false, true, false, "HONOR Magic 7 Lite 256 GB 8 GB Ram Siyah", 15999m, 4.4m, 50, 3, null, null },
                    { 84, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9598), "Samsung Galaxy S24 FE 128 GB 8 GB Ram Gri", 0m, false, true, false, "Samsung Galaxy S24 FE 128 GB 8 GB Ram Gri", 23849m, 4.6m, 50, 3, null, null },
                    { 85, 14, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9610), "Nothing Phone 1 256 GB 8 GB Ram Siyah", 0m, false, true, false, "Nothing Phone 1 256 GB 8 GB Ram Siyah", 13999m, 4.3m, 50, 3, null, null },
                    { 86, 14, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9613), "Nothing Phone (2a) 256 GB 12 GB Ram Beyaz", 0m, false, true, false, "Nothing Phone (2a) 256 GB 12 GB Ram Beyaz", 18999m, 4.5m, 50, 3, null, null },
                    { 87, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9617), "Samsung Galaxy A35 128 GB 8 GB Ram Açık Mavi", 0m, false, true, false, "Samsung Galaxy A35 128 GB 8 GB Ram Açık Mavi", 13701m, 4.3m, 50, 3, null, null },
                    { 88, 15, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9619), "Infinix Smart 9 128 GB 4 GB Ram Nane Yeşili", 0m, false, true, false, "Infinix Smart 9 128 GB 4 GB Ram Nane Yeşili", 5499m, 4.0m, 50, 3, null, null },
                    { 89, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9621), "Samsung Galaxy A55 128 GB 8 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A55 128 GB 8 GB Ram Siyah", 16170m, 4.4m, 50, 3, null, null },
                    { 90, 14, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9624), "Nothing Phone 2A Plus 256 GB 12 GB Ram Gri", 0m, false, true, false, "Nothing Phone 2A Plus 256 GB 12 GB Ram Gri", 22999m, 4.5m, 50, 3, null, null },
                    { 91, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9626), "Samsung Galaxy S24 Fe 256 GB 8 GB Ram Grafit", 0m, false, true, false, "Samsung Galaxy S24 Fe 256 GB 8 GB Ram Grafit", 26299m, 4.6m, 50, 3, null, null },
                    { 92, 1, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9628), "Apple iPhone 16e 128GB Beyaz", 0m, false, true, false, "Apple iPhone 16e 128GB Beyaz", 44799m, 4.7m, 50, 3, null, null },
                    { 93, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9632), "Samsung Galaxy S24 FE 128 GB 8 GB Ram Mavi", 0m, false, true, false, "Samsung Galaxy S24 FE 128 GB 8 GB Ram Mavi", 23849m, 4.6m, 50, 3, null, null },
                    { 94, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9635), "Samsung Galaxy S25+ 256 GB 12 GB Ram Lacivert", 0m, false, true, false, "Samsung Galaxy S25+ 256 GB 12 GB Ram Lacivert", 54799m, 4.8m, 50, 3, null, null },
                    { 95, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9637), "Samsung B310 Dual Sim Lacivert", 0m, false, true, false, "Samsung B310 Dual Sim Lacivert", 1149m, 3.5m, 50, 3, null, null },
                    { 96, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9645), "Samsung Galaxy S23 Ultra 512 GB 12 GB Ram Altın", 0m, false, true, false, "Samsung Galaxy S23 Ultra 512 GB 12 GB Ram Altın", 48899m, 4.9m, 50, 3, null, null },
                    { 97, 16, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9647), "Redmi Note 14 Pro 12GB 512GB", 0m, false, true, false, "Redmi Note 14 Pro 12GB 512GB", 18999m, 4.4m, 50, 3, null, null },
                    { 98, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9649), "Samsung B310E Dual Sim Kamerasız Cep Telefonu Beyaz", 0m, false, true, false, "Samsung B310E Dual Sim Kamerasız Cep Telefonu Beyaz", 1149m, 3.5m, 50, 3, null, null },
                    { 99, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9651), "Samsung Galaxy A55 128 GB 8 GB Ram Açık Mavi", 0m, false, true, false, "Samsung Galaxy A55 128 GB 8 GB Ram Açık Mavi", 16507m, 4.4m, 50, 3, null, null },
                    { 100, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9654), "Samsung Galaxy A35 128 GB 8 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A35 128 GB 8 GB Ram Siyah", 13559m, 4.3m, 50, 3, null, null },
                    { 101, 16, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9656), "Redmi Note 14 Pro 8GB 256GB", 0m, false, true, false, "Redmi Note 14 Pro 8GB 256GB", 16599m, 4.4m, 50, 3, null, null },
                    { 102, 1, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9658), "Apple iPhone 15 256 GB Mavi", 0m, false, true, false, "Apple iPhone 15 256 GB Mavi", 55999m, 4.8m, 50, 3, null, null },
                    { 103, 1, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9660), "Apple iPhone 16 Pro 256GB Beyaz", 0m, false, true, false, "Apple iPhone 16 Pro 256GB Beyaz", 84599m, 4.9m, 50, 3, null, null },
                    { 104, 8, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9663), "Xiaomi 14T Pro 12GB 512GB", 0m, false, true, false, "Xiaomi 14T Pro 12GB 512GB", 41000m, 4.5m, 50, 3, null, null },
                    { 105, 1, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9665), "Apple iPhone 16 Pro 128GB Beyaz", 0m, false, true, false, "Apple iPhone 16 Pro 128GB Beyaz", 78499m, 4.8m, 50, 3, null, null },
                    { 129, 9, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9729), "Samsung B310E Cep Telefonu Beyaz", 0m, false, true, false, "Samsung B310E Cep Telefonu Beyaz", 1149m, 3.5m, 50, 3, null, null },
                    { 130, 22, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9732), "Arçelik 6167 6 Programlı Beyaz Bulaşık Makinesi", 0m, false, true, false, "Arçelik 6167 6 Programlı Beyaz Bulaşık Makinesi", 25739.01m, 4.5m, 50, 4, null, null },
                    { 131, 23, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9734), "Kumtel Beyaz Cam Digital / Dokunmatik Ankastre Set - 8 Programlı (KO-40 TAHDF Ocak B66-Sf2 Ddt Fırın DA6-835 Davlumbaz)", 0m, false, true, false, "Kumtel Beyaz Cam Digital / Dokunmatik Ankastre Set", 11299m, 4.1m, 50, 4, null, null },
                    { 132, 24, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9740), "Regal Bm 310 3 Programlı Bulaşık Makinesi", 0m, false, true, false, "Regal Bm 310 3 Programlı Bulaşık Makinesi", 11549m, 4.6m, 50, 4, null, null },
                    { 133, 25, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9742), "Profilo BM6320MA D Enerji Sınıfı 6 Programlı Bulaşık Makinesi", 0m, false, true, false, "Profilo BM6320MA D Enerji Sınıfı 6 Programlı Bulaşık Makinesi", 15999m, 4.7m, 50, 4, null, null },
                    { 134, 26, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9744), "Altus AL 7103 MD 1000 Devir 7 kg Çamaşır Makinesi", 0m, false, true, false, "Altus AL 7103 MD 1000 Devir 7 kg Çamaşır Makinesi", 12479m, 4.6m, 50, 4, null, null },
                    { 135, 26, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9746), "Altus AL 10123 D C Enerji 10 Kg Çamaşır Makinesi", 0m, false, true, false, "Altus AL 10123 D C Enerji 10 Kg Çamaşır Makinesi", 17028m, 4.7m, 50, 4, null, null },
                    { 136, 27, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9748), "Hoover NDEH 10A2TSBE-17 10 kg Wi-Fi + Bluetooth Bağlantılı Isı Pompalı Kurutma Makinesi", 0m, false, true, false, "Hoover NDEH 10A2TSBE-17 10 kg Isı Pompalı Kurutma Makinesi", 14999m, 4.5m, 50, 4, null, null },
                    { 137, 22, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9750), "Arçelik 7103 D 7 Kg 1000 Devir Çamaşır Makinesi", 0m, false, true, false, "Arçelik 7103 D 7 Kg 1000 Devir Çamaşır Makinesi", 14999m, 4.5m, 50, 4, null, null },
                    { 138, 28, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9772), "Uğur UES 507 D/S 3 Kapılı No-Frost Buzdolabı", 0m, false, true, false, "Uğur UES 507 D/S 3 Kapılı No-Frost Buzdolabı", 29999m, 4.3m, 50, 4, null, null },
                    { 139, 33, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9779), "Vestel NF480 EX A++ Siyah 453 Lt No-Frost Buzdolabı", 0m, false, true, false, "Vestel NF480 EX Siyah No-Frost Buzdolabı", 23599m, 4.4m, 50, 4, null, null },
                    { 140, 24, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9782), "Regal 90 LT A+ Mini Buzdolabı", 0m, false, true, false, "Regal 90 LT A+ Mini Buzdolabı", 6499m, 4.6m, 50, 4, null, null },
                    { 141, 29, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9784), "Arnell Ankastre Set (8665 MDOC Ankastre Fırın + 1140-CSBDF 4 Gözlü Ocak + DS3490EC / EC3490 Davlumbaz)", 0m, false, true, false, "Arnell Ankastre Set", 13499m, 4.2m, 50, 4, null, null },
                    { 142, 30, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9786), "Evora 3'lü Siyah Cam Ankastre Set (EAF-6056 Fırın + EAO-8505 Ocak + EAD-9263 Davlumbaz)", 0m, false, true, false, "Evora Siyah Cam Set", 10990m, 4.1m, 50, 4, null, null },
                    { 143, 31, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9788), "Albergio AL-FO-005-E Ankastre Fırın", 0m, false, true, false, "Albergio AL-FO-005-E Ankastre Fırın", 5499m, 4.0m, 50, 4, null, null },
                    { 144, 32, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9792), "Kiwi KSW-4215 Beyaz Soğuk Su Sebili", 0m, false, true, false, "Kiwi KSW-4215 Beyaz Soğuk Su Sebili", 1299m, 3.9m, 50, 4, null, null },
                    { 145, 33, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9802), "Vestel SP 100 Beyaz Soğuk Su Sebili", 0m, false, true, false, "Vestel SP 100 Beyaz Soğuk Su Sebili", 1499m, 4.0m, 50, 4, null, null },
                    { 146, 22, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9804), "Arçelik 1100 S Beyaz Su Sebili", 0m, false, true, false, "Arçelik 1100 S Beyaz Su Sebili", 1999m, 4.2m, 50, 4, null, null },
                    { 147, 25, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9806), "Profilo SP 100 Sıcak/Soğuk Su Sebili", 0m, false, true, false, "Profilo SP 100 Sıcak/Soğuk Su Sebili", 2299m, 4.3m, 50, 4, null, null },
                    { 148, 22, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9808), "Arçelik 5500 BT Mini Fırın - 15 Litre", 0m, false, true, false, "Arçelik 5500 BT Mini Fırın", 4999m, 4.5m, 50, 4, null, null },
                    { 149, 23, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9810), "Kumtel KF3150 Mini Fırın - 36 Litre Beyaz", 0m, false, true, false, "Kumtel KF3150 Mini Fırın", 2699m, 4.3m, 50, 4, null, null },
                    { 150, 33, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9812), "Vestel R8080 Retro Buzdolabı - Kırmızı", 0m, false, true, false, "Vestel R8080 Retro Buzdolabı", 28900m, 4.7m, 50, 4, null, null },
                    { 151, 22, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9814), "Arçelik 9144 YI Ultra Hijyen 9 Kg 1400 Devir Çamaşır Makinesi", 0m, false, true, false, "Arçelik 9144 YI Ultra Hijyen 9 Kg Çamaşır Makinesi", 21950m, 4.8m, 50, 4, null, null },
                    { 152, 25, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9816), "Profilo CGA242X1TR A++ 9 Kg 1200 Devir Çamaşır Makinesi", 0m, false, true, false, "Profilo CGA242X1TR A++ 9 Kg Çamaşır Makinesi", 18999m, 4.5m, 50, 4, null, null },
                    { 153, 24, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9820), "Regal Pratik 2000 Toz Torbasız Elektrikli Süpürge", 0m, false, true, false, "Regal Pratik 2000 Elektrikli Süpürge", 2999m, 4.2m, 50, 4, null, null },
                    { 154, 33, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9822), "Vestel BM 5201 X EKO PLUS Bulaşık Makinesi", 0m, false, true, false, "Vestel EKO PLUS Bulaşık Makinesi", 12999m, 4.3m, 50, 4, null, null },
                    { 155, 22, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9824), "Arçelik K 3290 Telve Otomatik Türk Kahve Makinesi - Siyah", 0m, false, true, false, "Arçelik K 3290 Telve Türk Kahve Makinesi", 3299m, 4.9m, 50, 4, null, null },
                    { 156, 26, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9826), "Altus AL 413 E 4 Programlı Bulaşık Makinesi", 0m, false, true, false, "Altus AL 413 E 4 Programlı Bulaşık Makinesi", 13499m, 4.1m, 50, 4, null, null },
                    { 157, 27, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9828), "Hoover HLWOQ 59B-S 9 Kg Çamaşır Kurutma Makinesi", 0m, false, true, false, "Hoover HLWOQ 59B-S Çamaşır Kurutma Makinesi", 17999m, 4.4m, 50, 4, null, null },
                    { 158, 33, 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9830), "Vestel MAYA 10100 ST 10 Kg 1000 Devir Çamaşır Makinesi", 0m, false, true, false, "Vestel MAYA 10100 ST Çamaşır Makinesi", 14599m, 4.5m, 50, 4, null, null }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "EntityId", "EntityType", "IsDeleted", "Path", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9950), 1, 1, false, "img/Products/Laptops/Casper_G870.1270.jpg", null, null },
                    { 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9955), 2, 1, false, "img/Products/Laptops/MSI_15.6.jpg", null, null },
                    { 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9957), 3, 1, false, "img/Products/Laptops/Casper_S100.1362.jpg", null, null },
                    { 4, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9958), 4, 1, false, "img/Products/Laptops/Casper_G870.1362.jpg", null, null },
                    { 5, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9959), 5, 1, false, "img/Products/Laptops/HP_15.6.jpg", null, null },
                    { 6, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9961), 6, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 7, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9962), 7, 1, false, "img/Products/Laptops/Lenovo_model.jpg", null, null },
                    { 8, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9963), 8, 1, false, "img/Products/Laptops/MSI_model.jpg", null, null },
                    { 9, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9964), 9, 1, false, "img/Products/Laptops/Casper_C550.1255.jpg", null, null },
                    { 10, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9966), 10, 1, false, "img/Products/Laptops/Lenovo_3.2.jpg", null, null },
                    { 11, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9967), 11, 1, false, "img/Products/Laptops/Casper_G770.1245.jpg", null, null },
                    { 12, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9968), 12, 1, false, "img/Products/Laptops/Casper_X600.7430.jpg", null, null },
                    { 13, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9969), 13, 1, false, "img/Products/Laptops/Acer_15.6.jpg", null, null },
                    { 14, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9970), 14, 1, false, "img/Products/Laptops/Casper_X600.1270.jpg", null, null },
                    { 15, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9971), 15, 1, false, "img/Products/Laptops/Casper_G870.1342.jpg", null, null },
                    { 16, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9972), 16, 1, false, "img/Products/Laptops/Casper_G870.1270.jpg", null, null },
                    { 17, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9975), 17, 1, false, "img/Products/Laptops/HP_15.6.jpg", null, null },
                    { 18, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9977), 18, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 19, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9978), 19, 1, false, "img/Products/Laptops/Asus_15.6.jpg", null, null },
                    { 20, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9979), 20, 1, false, "img/Products/Laptops/Apple_model.jpg", null, null },
                    { 21, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9980), 21, 1, false, "img/Products/Laptops/Casper_G870.1342.jpg", null, null },
                    { 22, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9982), 22, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 23, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9984), 23, 1, false, "img/Products/Laptops/Asus_model.jpg", null, null },
                    { 24, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9985), 24, 1, false, "img/Products/Laptops/Casper_X600.1342.jpg", null, null },
                    { 25, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9987), 25, 1, false, "img/Products/Laptops/Lenovo_3.2.jpg", null, null },
                    { 26, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9988), 26, 1, false, "img/Products/Laptops/Casper_X600.1362.jpg", null, null },
                    { 27, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9990), 27, 1, false, "img/Products/Laptops/MSI_15.6.jpg", null, null },
                    { 28, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9994), 28, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 29, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9996), 29, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 30, null, new DateTime(2025, 4, 5, 18, 5, 3, 51, DateTimeKind.Local).AddTicks(9999), 30, 1, false, "img/Products/Laptops/Apple_model.jpg", null, null },
                    { 31, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(1), 31, 1, false, "img/Products/Laptops/Casper_G870.1245.jpg", null, null },
                    { 32, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(2), 32, 1, false, "img/Products/PrintersandScanner/hp_hp_deskjet_ink_advantage_2878_allinone_yazc.jpg", null, null },
                    { 33, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(3), 33, 1, false, "img/Products/PrintersandScanner/canon_dolan_kartulu_e414_yazc_tarayc_fotokopi.jpg", null, null },
                    { 34, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5), 34, 1, false, "img/Products/PrintersandScanner/canon_pixma_tr4650_tarayc_fotokopi_wifi_faks_ok_fonksiyonlu_yazc_canon_eurasia_garantili.jpg", null, null },
                    { 35, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6), 35, 1, false, "img/Products/PrintersandScanner/canon_pixma_e3640_wifi_tarayc_fotokopi_ok_fonksiyonlu_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 36, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7), 36, 1, false, "img/Products/PrintersandScanner/epson_l5290_wifi_renk_tankl_yazc.jpg", null, null },
                    { 37, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8), 37, 1, false, "img/Products/PrintersandScanner/epson_tankl_l3150_photoink_muadil_mrekkepli_tankl_yazc_1_siyah_mrekkep_ve_fotoraf_kad_hediyeli.jpg", null, null },
                    { 38, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(10), 38, 1, false, "img/Products/PrintersandScanner/hp_officejet_pro_7720_fotokopi_faks_tarayc_wifi_airprint_a3_yazc_y0s18a.jpg", null, null },
                    { 39, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(14), 39, 1, false, "img/Products/PrintersandScanner/canon_e3640_wifi_yazc_ve_tpal_kartu_sistemi.jpg", null, null },
                    { 40, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(15), 40, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_l3250_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 41, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(16), 41, 1, false, "img/Products/PrintersandScanner/enp_canon_mf264dw_lazer_yazc_tarayc_fotokopi_wifi_lan_duplex.jpg", null, null },
                    { 42, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(17), 42, 1, false, "img/Products/PrintersandScanner/canon_pxma_g3430_renkli_mrekkep_mega_tankl_yazc_tarayc_fotokopi_wifi_1_ie_orijinal_siyah_mrekkep_hed.jpg", null, null },
                    { 43, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(18), 43, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_l3250_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 44, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(19), 44, 1, false, "img/Products/PrintersandScanner/canon_isensys_mf453dw_wf_ok_fonksiyonlu_lazer_yazc.jpg", null, null },
                    { 45, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(20), 45, 1, false, "img/Products/PrintersandScanner/canon_pixma_e3440_dolabilen_kartu_sistemli_yazc.jpg", null, null },
                    { 46, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(21), 46, 1, false, "img/Products/PrintersandScanner/epson_l6550_color_tankl_wifi_a4_yazc_fotokopi_tarayc_fax.jpg", null, null },
                    { 47, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(22), 47, 1, false, "img/Products/PrintersandScanner/hp_deskjet_2632_wifi_tarayc_fotokopi_renkli_ok_fonksiyonlu_mrekkep_pskrtmeli_yazc_v1n05b.jpg", null, null },
                    { 48, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(24), 48, 1, false, "img/Products/PrintersandScanner/canon_pixma_e514_fotokopi_tarayc_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 49, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(25), 49, 1, false, "img/Products/PrintersandScanner/epson_epson_ecotank_l11050_a3_tek_fonk_yazici.jpg", null, null },
                    { 50, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(26), 50, 1, false, "img/Products/PrintersandScanner/hp_hp_6uu47a_smart_tank_750_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 51, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(28), 51, 1, false, "img/Products/PrintersandScanner/canon_gx6040_yazctaraycfotokopi_renkli_mrekkep_tankl_yazc_wifi_ethernet.jpg", null, null },
                    { 52, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(29), 52, 1, false, "img/Products/PrintersandScanner/epson_surecolor_sc_f100_mrekkep_pskrtme_sblimasyon_yazc.jpg", null, null },
                    { 53, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(30), 53, 1, false, "img/Products/PrintersandScanner/hp_deskjet_1516_fotokopi_tarayc_yazc_b2l60c.jpg", null, null },
                    { 54, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(62), 54, 1, false, "img/Products/PrintersandScanner/canon_ix6850_renkli_inkjet_a3_fotoraf_yazcswifi_canon_eurasia_garantili.jpg", null, null },
                    { 55, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(64), 55, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 56, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(66), 56, 1, false, "img/Products/PrintersandScanner/hp_officejet_j4500_wifi_faxl_ok_fonksiyonlu_renkli_yazc_cn547a.jpg", null, null },
                    { 57, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(67), 57, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 58, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(68), 58, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_m1170_yazc_a4.jpg", null, null },
                    { 59, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(70), 59, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_wifi_ok_fonksiyonlu_yazc_bitmeyen_kartu_siyah_depo.jpg", null, null },
                    { 60, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(72), 60, 1, false, "img/Products/PrintersandScanner/canon_pixma_mg3050bk_wifi_fotokopi_tarayc_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 61, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(74), 61, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 62, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(75), 62, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 63, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(76), 63, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 64, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(77), 64, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 65, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(78), 65, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 66, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(80), 66, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 67, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(82), 67, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 68, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(83), 68, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 69, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(84), 69, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 70, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(85), 70, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 71, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(86), 71, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 72, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(88), 72, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 73, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(89), 73, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 74, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(90), 74, 1, false, "img/Products/Phones/apple_iphone_13_128_gb_beyaz.jpg", null, null },
                    { 75, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(91), 75, 1, false, "img/Products/Phones/samsung_galaxy_a06_128_gb_4_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 76, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(92), 76, 1, false, "img/Products/Phones/apple_iphone_13_128_gb_siyah.jpg", null, null },
                    { 77, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(93), 77, 1, false, "img/Products/Phones/samsung_galaxy_a16_128_gb_6_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 78, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(94), 78, 1, false, "img/Products/Phones/samsung_galaxy_a35_256_gb_8_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 79, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(95), 79, 1, false, "img/Products/Phones/honor_magic_7_lite_256_gb_8_gb_ram_honor_trkiye_garantili_mor.jpg", null, null },
                    { 80, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(96), 80, 1, false, "img/Products/Phones/samsung_galaxy_a06_128_gb_4_gb_ram_samsung_trkiye_garantili_ak_mavi.jpg", null, null },
                    { 81, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(97), 81, 1, false, "img/Products/Phones/samsung_galaxy_s24_256_gb_12_gb_ram_samsung_trkiye_garantili_gri.jpg", null, null },
                    { 82, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(98), 82, 1, false, "img/Products/Phones/samsung_galaxy_a16_128_gb_6_gb_ram_samsung_trkiye_garantili_gri.jpg", null, null },
                    { 83, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(99), 83, 1, false, "img/Products/Phones/honor_magic_7_lite_256_gb_8_gb_ram_honor_trkiye_garantili_siyah.jpg", null, null },
                    { 84, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(102), 84, 1, false, "img/Products/Phones/samsung_galaxy_s24_fe_128_gb_8_gb_ram_samsung_trkiye_garantili_gri.jpg", null, null },
                    { 85, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(103), 85, 1, false, "img/Products/Phones/nothing_phone_1_256_gb_8_gb_ram_nothing_trkiye_garantili_siyah.jpg", null, null },
                    { 86, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(104), 86, 1, false, "img/Products/Phones/nothing_phone_2a_256_gb_12_gb_ram_nothing_trkiye_garantili_beyaz.jpg", null, null },
                    { 87, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(105), 87, 1, false, "img/Products/Phones/samsung_galaxy_a35_128_gb_8_gb_ram_samsung_trkiye_garantili_ak_mavi.jpg", null, null },
                    { 88, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(106), 88, 1, false, "img/Products/Phones/infinix_infnx_smart_9_128_gb_4_gb_ram_infnx_trkiye_garantili_nane_yeili.jpg", null, null },
                    { 89, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(107), 89, 1, false, "img/Products/Phones/samsung_galaxy_a55_128_gb_8_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 90, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(108), 90, 1, false, "img/Products/Phones/nothing_phone_2a_plus_256_gb_12_gb_ram_nothing_trkiye_garantili_gri.jpg", null, null },
                    { 91, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(109), 91, 1, false, "img/Products/Phones/samsung_galaxy_s24_fe_256_gb_8_gb_ram_samsung_trkiye_garantili_grafit.jpg", null, null },
                    { 92, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(110), 92, 1, false, "img/Products/Phones/apple_iphone_16e_128gb_beyaz.jpg", null, null },
                    { 93, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(111), 93, 1, false, "img/Products/Phones/samsung_galaxy_s24_fe_128_gb_8_gb_ram_samsung_trkiye_garantili_mavi.jpg", null, null },
                    { 94, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(112), 94, 1, false, "img/Products/Phones/samsung_galaxy_s25_256_gb_12_gb_ram_samsung_trkiye_garantili_lacivert.jpg", null, null },
                    { 95, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(113), 95, 1, false, "img/Products/Phones/samsung_b310_dual_sim_lacivert.jpg", null, null },
                    { 96, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(114), 96, 1, false, "img/Products/Phones/samsung_galaxy_s23_ultra_512_gb_12_gb_ram_samsung_trkiye_garantili_altn.jpg", null, null },
                    { 97, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(115), 97, 1, false, "img/Products/Phones/redmi_note_14_pro_12gb_512gb_xiaomi_trkiye_garantili.jpg", null, null },
                    { 98, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(117), 98, 1, false, "img/Products/Phones/samsung_b310_e_dual_sim_kamerasz_cep_telefonu_beyaz.jpg", null, null },
                    { 99, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(118), 99, 1, false, "img/Products/Phones/samsung_galaxy_a55_128_gb_8_gb_ram_samsung_trkiye_garantili_ak_mavi.jpg", null, null },
                    { 100, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(120), 100, 1, false, "img/Products/Phones/samsung_galaxy_a35_128_gb_8_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 101, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(121), 101, 1, false, "img/Products/Phones/redmi_note_14_pro_8gb_256gb_xiaomi_trkiye_garantili.jpg", null, null },
                    { 102, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(122), 102, 1, false, "img/Products/Phones/apple_iphone_15_256_gb_mavi.jpg", null, null },
                    { 103, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(124), 103, 1, false, "img/Products/Phones/apple_iphone_16_pro_256gb_beyaz.jpg", null, null },
                    { 104, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(125), 104, 1, false, "img/Products/Phones/xiaomi_14t_pro_12gb_512gb.jpg", null, null },
                    { 105, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(126), 105, 1, false, "img/Products/Phones/apple_iphone_16_pro_128gb_beyaz.jpg", null, null },
                    { 129, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(178), 129, 1, false, "img/Products/Phones/samsung_b310e_cep_telefonu_resmi_btk_kaytl2g_ve_3g_hatlar_n_beyaz.jpg", null, null },
                    { 130, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(180), 130, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 131, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(181), 131, 1, false, "img/Products/WhiteGoods/kumtel_kumtel_93l_beyaz_bro_tipi_buzdolab_hmb-110.jpg", null, null },
                    { 132, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(182), 132, 1, false, "img/Products/WhiteGoods/regal_bm_310_3_programl_bulak_makinesi.jpg", null, null },
                    { 133, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(183), 133, 1, false, "img/Products/WhiteGoods/arelik_ade_606_2b_yatk_davlumbaz_karbon_filtre_165732003.jpg", null, null },
                    { 134, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(184), 134, 1, false, "img/Products/WhiteGoods/altus_al_7103_md_1000_devir_7_kg_amar_makinesi.jpg", null, null },
                    { 135, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(189), 135, 1, false, "img/Products/WhiteGoods/altus_al_10123_d_c_enerji_10_kg_amar_makinesi.jpg", null, null },
                    { 136, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(190), 136, 1, false, "img/Products/WhiteGoods/hoover_ndeh_10a2tsbe-17_10_kg_wi-fi_bluetooth_balantl_is_pompal_kurutma_makinesi.jpg", null, null },
                    { 137, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(191), 137, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 138, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(192), 138, 1, false, "img/Products/WhiteGoods/samsung_ww11bga046aeah_11_kg_1400_devir_amar_makinesi.jpg", null, null },
                    { 139, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(194), 139, 1, false, "img/Products/WhiteGoods/vestel_sp_202-a_su_sebili.jpg", null, null },
                    { 140, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(195), 140, 1, false, "img/Products/WhiteGoods/regal_st_30010_242_lt_statik_buzdolab.jpg", null, null },
                    { 141, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(196), 141, 1, false, "img/Products/WhiteGoods/arelik_yeni_model_gri_buhar_destekli_cam_ankastre_set.jpg", null, null },
                    { 142, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(197), 142, 1, false, "img/Products/WhiteGoods/evora_sanayi_tipi_100_lt_soutmal_artmal_paslanmaz_endstriyel_su_sebili.jpg", null, null },
                    { 143, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(198), 143, 1, false, "img/Products/WhiteGoods/albergio_cam_damacana_kapakl_su_sebil_15_lt_tm_sebillere_uyumlu.jpg", null, null },
                    { 144, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(200), 144, 1, false, "img/Products/WhiteGoods/kiwi_kwp_8520_standl_su_pompas-beyaz.jpg", null, null },
                    { 145, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(202), 145, 1, false, "img/Products/WhiteGoods/vestel_sp_202-a_su_sebili.jpg", null, null },
                    { 146, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(204), 146, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 147, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(209), 147, 1, false, "img/Products/WhiteGoods/samsung_ww11bb534dabah_11_kg_1400_devir_bespoke_amar_makinesi_spacemax_ai_kontrol_paneli.jpg", null, null },
                    { 148, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(211), 148, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 149, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(212), 149, 1, false, "img/Products/WhiteGoods/kumtel_kumtel_93l_beyaz_bro_tipi_buzdolab_hmb-110.jpg", null, null },
                    { 150, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(214), 150, 1, false, "img/Products/WhiteGoods/vestel_sp_202-a_su_sebili.jpg", null, null },
                    { 151, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(215), 151, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 152, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(216), 152, 1, false, "img/Products/WhiteGoods/samsung_ww11bb534dabah_11_kg_1400_devir_bespoke_amar_makinesi_spacemax_ai_kontrol_paneli.jpg", null, null },
                    { 153, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(217), 153, 1, false, "img/Products/WhiteGoods/regal_bm_310_3_programl_bulak_makinesi.jpg", null, null },
                    { 154, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(218), 154, 1, false, "img/Products/WhiteGoods/vestel_sp_202-a_su_sebili.jpg", null, null },
                    { 155, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(219), 155, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 156, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(220), 156, 1, false, "img/Products/WhiteGoods/altus_al_7103_md_1000_devir_7_kg_amar_makinesi.jpg", null, null },
                    { 157, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(222), 157, 1, false, "img/Products/WhiteGoods/altus_al_7103_md_1000_devir_7_kg_amar_makinesi.jpg", null, null },
                    { 158, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(223), 158, 1, false, "img/Products/WhiteGoods/altus_al_7103_md_1000_devir_7_kg_amar_makinesi.jpg", null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductProperties",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "ProductId", "PropertyTypeId", "PropertyValueId", "Stock", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4832), true, false, 1, 1, 1, 50, null, null },
                    { 2, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4836), true, false, 1, 1, 2, 50, null, null },
                    { 3, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4836), true, false, 1, 1, 3, 50, null, null },
                    { 4, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4837), true, false, 1, 1, 4, 50, null, null },
                    { 5, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4841), true, false, 1, 4, 15, 50, null, null },
                    { 6, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4845), true, false, 1, 5, 24, 50, null, null },
                    { 7, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4847), true, false, 1, 6, 28, 50, null, null },
                    { 8, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(4849), true, false, 1, 7, 30, 50, null, null },
                    { 9, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5322), true, false, 2, 1, 1, 50, null, null },
                    { 10, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5323), true, false, 2, 1, 2, 50, null, null },
                    { 11, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5324), true, false, 2, 1, 3, 50, null, null },
                    { 12, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5324), true, false, 2, 1, 4, 50, null, null },
                    { 13, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5325), true, false, 2, 4, 16, 50, null, null },
                    { 14, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5326), true, false, 2, 5, 23, 50, null, null },
                    { 15, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5327), true, false, 2, 6, 27, 50, null, null },
                    { 16, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5328), true, false, 2, 7, 29, 50, null, null },
                    { 17, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5611), true, false, 3, 1, 1, 50, null, null },
                    { 18, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5612), true, false, 3, 1, 2, 50, null, null },
                    { 19, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5613), true, false, 3, 1, 3, 50, null, null },
                    { 20, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5613), true, false, 3, 1, 4, 50, null, null },
                    { 21, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5614), true, false, 3, 4, 17, 50, null, null },
                    { 22, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5615), true, false, 3, 5, 24, 50, null, null },
                    { 23, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5615), true, false, 3, 6, 28, 50, null, null },
                    { 24, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5616), true, false, 3, 7, 31, 50, null, null },
                    { 25, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5994), true, false, 4, 1, 1, 50, null, null },
                    { 26, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5995), true, false, 4, 1, 2, 50, null, null },
                    { 27, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5995), true, false, 4, 1, 3, 50, null, null },
                    { 28, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5996), true, false, 4, 1, 4, 50, null, null },
                    { 29, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5996), true, false, 4, 4, 17, 50, null, null },
                    { 30, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5997), true, false, 4, 5, 24, 50, null, null },
                    { 31, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5997), true, false, 4, 6, 28, 50, null, null },
                    { 32, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(5998), true, false, 4, 7, 30, 50, null, null },
                    { 33, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6334), true, false, 5, 1, 1, 50, null, null },
                    { 34, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6335), true, false, 5, 1, 2, 50, null, null },
                    { 35, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6336), true, false, 5, 1, 3, 50, null, null },
                    { 36, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6336), true, false, 5, 1, 4, 50, null, null },
                    { 37, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6337), true, false, 5, 4, 18, 50, null, null },
                    { 38, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6337), true, false, 5, 5, 23, 50, null, null },
                    { 39, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6338), true, false, 5, 6, 27, 50, null, null },
                    { 40, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6338), true, false, 5, 7, 30, 50, null, null },
                    { 41, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6583), true, false, 6, 1, 1, 50, null, null },
                    { 42, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6584), true, false, 6, 1, 2, 50, null, null },
                    { 43, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6584), true, false, 6, 1, 3, 50, null, null },
                    { 44, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6585), true, false, 6, 1, 4, 50, null, null },
                    { 45, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6585), true, false, 6, 4, 19, 50, null, null },
                    { 46, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6586), true, false, 6, 5, 23, 50, null, null },
                    { 47, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6587), true, false, 6, 6, 27, 50, null, null },
                    { 48, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6588), true, false, 6, 7, 31, 50, null, null },
                    { 49, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6867), true, false, 7, 1, 1, 50, null, null },
                    { 50, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6868), true, false, 7, 1, 2, 50, null, null },
                    { 51, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6868), true, false, 7, 1, 3, 50, null, null },
                    { 52, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6869), true, false, 7, 1, 4, 50, null, null },
                    { 53, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6870), true, false, 7, 4, 20, 50, null, null },
                    { 54, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6870), true, false, 7, 5, 23, 50, null, null },
                    { 55, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6871), true, false, 7, 6, 27, 50, null, null },
                    { 56, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(6872), true, false, 7, 7, 30, 50, null, null },
                    { 57, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7111), true, false, 8, 1, 1, 50, null, null },
                    { 58, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7112), true, false, 8, 1, 2, 50, null, null },
                    { 59, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7112), true, false, 8, 1, 3, 50, null, null },
                    { 60, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7113), true, false, 8, 1, 4, 50, null, null },
                    { 61, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7114), true, false, 8, 4, 21, 50, null, null },
                    { 62, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7114), true, false, 8, 5, 22, 50, null, null },
                    { 63, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7115), true, false, 8, 6, 27, 50, null, null },
                    { 64, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7115), true, false, 8, 7, 30, 50, null, null },
                    { 65, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7364), true, false, 9, 1, 1, 50, null, null },
                    { 66, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7365), true, false, 9, 1, 2, 50, null, null },
                    { 67, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7366), true, false, 9, 1, 3, 50, null, null },
                    { 68, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7366), true, false, 9, 1, 4, 50, null, null },
                    { 69, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7367), true, false, 9, 4, 16, 50, null, null },
                    { 70, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7368), true, false, 9, 5, 23, 50, null, null },
                    { 71, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7383), true, false, 9, 6, 26, 50, null, null },
                    { 72, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7384), true, false, 9, 7, 30, 50, null, null },
                    { 73, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7643), true, false, 10, 1, 1, 50, null, null },
                    { 74, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7644), true, false, 10, 1, 2, 50, null, null },
                    { 75, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7644), true, false, 10, 1, 3, 50, null, null },
                    { 76, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7645), true, false, 10, 1, 4, 50, null, null },
                    { 77, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7646), true, false, 10, 4, 32, 50, null, null },
                    { 78, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7646), true, false, 10, 5, 24, 50, null, null },
                    { 79, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7647), true, false, 10, 6, 28, 50, null, null },
                    { 80, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7648), true, false, 10, 7, 30, 50, null, null },
                    { 81, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7895), true, false, 11, 1, 1, 50, null, null },
                    { 82, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7895), true, false, 11, 1, 2, 50, null, null },
                    { 83, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7896), true, false, 11, 1, 3, 50, null, null },
                    { 84, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7896), true, false, 11, 1, 4, 50, null, null },
                    { 85, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7897), true, false, 11, 4, 21, 50, null, null },
                    { 86, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7898), true, false, 11, 5, 24, 50, null, null },
                    { 87, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7898), true, false, 11, 6, 26, 50, null, null },
                    { 88, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(7899), true, false, 11, 7, 30, 50, null, null },
                    { 89, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8137), true, false, 12, 1, 1, 50, null, null },
                    { 90, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8137), true, false, 12, 1, 2, 50, null, null },
                    { 91, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8138), true, false, 12, 1, 3, 50, null, null },
                    { 92, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8138), true, false, 12, 1, 4, 50, null, null },
                    { 93, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8139), true, false, 12, 4, 36, 50, null, null },
                    { 94, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8140), true, false, 12, 5, 23, 50, null, null },
                    { 95, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8140), true, false, 12, 6, 26, 50, null, null },
                    { 96, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8141), true, false, 12, 7, 30, 50, null, null },
                    { 97, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8403), true, false, 13, 1, 1, 50, null, null },
                    { 98, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8404), true, false, 13, 1, 2, 50, null, null },
                    { 99, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8404), true, false, 13, 1, 3, 50, null, null },
                    { 100, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8405), true, false, 13, 1, 4, 50, null, null },
                    { 101, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8406), true, false, 13, 4, 16, 50, null, null },
                    { 102, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8406), true, false, 13, 5, 23, 50, null, null },
                    { 103, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8407), true, false, 13, 6, 27, 50, null, null },
                    { 104, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8407), true, false, 13, 7, 30, 50, null, null },
                    { 105, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8656), true, false, 14, 1, 1, 50, null, null },
                    { 106, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8656), true, false, 14, 1, 2, 50, null, null },
                    { 107, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8657), true, false, 14, 1, 3, 50, null, null },
                    { 108, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8657), true, false, 14, 1, 4, 50, null, null },
                    { 109, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8658), true, false, 14, 4, 15, 50, null, null },
                    { 110, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8659), true, false, 14, 5, 24, 50, null, null },
                    { 111, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8659), true, false, 14, 6, 28, 50, null, null },
                    { 112, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8660), true, false, 14, 7, 30, 50, null, null },
                    { 113, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8898), true, false, 15, 1, 1, 50, null, null },
                    { 114, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8898), true, false, 15, 1, 2, 50, null, null },
                    { 115, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8899), true, false, 15, 1, 3, 50, null, null },
                    { 116, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8899), true, false, 15, 1, 4, 50, null, null },
                    { 117, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8900), true, false, 15, 4, 19, 50, null, null },
                    { 118, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8901), true, false, 15, 5, 24, 50, null, null },
                    { 119, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8901), true, false, 15, 6, 26, 50, null, null },
                    { 120, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(8902), true, false, 15, 7, 30, 50, null, null },
                    { 121, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9165), true, false, 16, 1, 1, 50, null, null },
                    { 122, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9165), true, false, 16, 1, 2, 50, null, null },
                    { 123, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9166), true, false, 16, 1, 3, 50, null, null },
                    { 124, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9167), true, false, 16, 1, 4, 50, null, null },
                    { 125, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9167), true, false, 16, 4, 15, 50, null, null },
                    { 126, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9168), true, false, 16, 5, 24, 50, null, null },
                    { 127, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9169), true, false, 16, 6, 28, 50, null, null },
                    { 128, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9169), true, false, 16, 7, 30, 50, null, null },
                    { 129, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9418), true, false, 17, 1, 1, 50, null, null },
                    { 130, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9419), true, false, 17, 1, 2, 50, null, null },
                    { 131, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9419), true, false, 17, 1, 3, 50, null, null },
                    { 132, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9420), true, false, 17, 1, 4, 50, null, null },
                    { 133, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9420), true, false, 17, 4, 33, 50, null, null },
                    { 134, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9421), true, false, 17, 5, 24, 50, null, null },
                    { 135, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9422), true, false, 17, 6, 28, 50, null, null },
                    { 136, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9422), true, false, 17, 7, 30, 50, null, null },
                    { 137, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9663), true, false, 18, 1, 1, 50, null, null },
                    { 138, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9663), true, false, 18, 1, 2, 50, null, null },
                    { 139, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9664), true, false, 18, 1, 3, 50, null, null },
                    { 140, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9664), true, false, 18, 1, 4, 50, null, null },
                    { 141, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9681), true, false, 18, 4, 21, 50, null, null },
                    { 142, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9682), true, false, 18, 5, 23, 50, null, null },
                    { 143, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9682), true, false, 18, 6, 28, 50, null, null },
                    { 144, null, new DateTime(2025, 4, 5, 18, 5, 3, 52, DateTimeKind.Local).AddTicks(9683), true, false, 18, 7, 30, 50, null, null },
                    { 145, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(24), true, false, 19, 1, 1, 50, null, null },
                    { 146, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(25), true, false, 19, 1, 2, 50, null, null },
                    { 147, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(25), true, false, 19, 1, 3, 50, null, null },
                    { 148, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(26), true, false, 19, 1, 4, 50, null, null },
                    { 149, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(27), true, false, 19, 4, 21, 50, null, null },
                    { 150, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(27), true, false, 19, 5, 22, 50, null, null },
                    { 151, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(28), true, false, 19, 6, 27, 50, null, null },
                    { 152, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(28), true, false, 19, 7, 30, 50, null, null },
                    { 153, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(379), true, false, 20, 1, 1, 50, null, null },
                    { 154, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(380), true, false, 20, 1, 2, 50, null, null },
                    { 155, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(380), true, false, 20, 1, 3, 50, null, null },
                    { 156, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(381), true, false, 20, 1, 4, 50, null, null },
                    { 157, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(381), true, false, 20, 4, 16, 50, null, null },
                    { 158, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(382), true, false, 20, 5, 22, 50, null, null },
                    { 159, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(383), true, false, 20, 6, 27, 50, null, null },
                    { 160, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(383), true, false, 20, 7, 30, 50, null, null },
                    { 161, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(918), true, false, 21, 1, 1, 50, null, null },
                    { 162, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(918), true, false, 21, 1, 2, 50, null, null },
                    { 163, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(919), true, false, 21, 1, 3, 50, null, null },
                    { 164, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(919), true, false, 21, 1, 4, 50, null, null },
                    { 165, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(921), true, false, 21, 4, 19, 50, null, null },
                    { 166, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(922), true, false, 21, 5, 23, 50, null, null },
                    { 167, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(924), true, false, 21, 6, 12, 50, null, null },
                    { 168, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(925), true, false, 21, 7, 29, 50, null, null },
                    { 169, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(1313), true, false, 22, 1, 1, 50, null, null },
                    { 170, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(1313), true, false, 22, 1, 2, 50, null, null },
                    { 171, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(1314), true, false, 22, 1, 3, 50, null, null },
                    { 172, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(1315), true, false, 22, 1, 4, 50, null, null },
                    { 173, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(1316), true, false, 22, 4, 19, 50, null, null },
                    { 174, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(1317), true, false, 22, 5, 23, 50, null, null },
                    { 175, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(1319), true, false, 22, 6, 28, 50, null, null },
                    { 176, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(1320), true, false, 22, 7, 30, 50, null, null },
                    { 177, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(1748), true, false, 23, 1, 1, 50, null, null },
                    { 178, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(1749), true, false, 23, 1, 2, 50, null, null },
                    { 179, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(1749), true, false, 23, 1, 3, 50, null, null },
                    { 180, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(1750), true, false, 23, 1, 4, 50, null, null },
                    { 181, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(1750), true, false, 23, 4, 35, 50, null, null },
                    { 182, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(1751), true, false, 23, 5, 23, 50, null, null },
                    { 183, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(1752), true, false, 23, 6, 27, 50, null, null },
                    { 184, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(1752), true, false, 23, 7, 29, 50, null, null },
                    { 185, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2020), true, false, 24, 1, 1, 50, null, null },
                    { 186, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2021), true, false, 24, 1, 2, 50, null, null },
                    { 187, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2021), true, false, 24, 1, 3, 50, null, null },
                    { 188, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2022), true, false, 24, 1, 4, 50, null, null },
                    { 189, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2022), true, false, 24, 4, 19, 50, null, null },
                    { 190, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2023), true, false, 24, 5, 24, 50, null, null },
                    { 191, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2024), true, false, 24, 6, 28, 50, null, null },
                    { 192, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2024), true, false, 24, 7, 31, 50, null, null },
                    { 193, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2321), true, false, 25, 1, 1, 50, null, null },
                    { 194, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2321), true, false, 25, 1, 2, 50, null, null },
                    { 195, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2322), true, false, 25, 1, 3, 50, null, null },
                    { 196, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2322), true, false, 25, 1, 4, 50, null, null },
                    { 197, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2323), true, false, 25, 4, 34, 50, null, null },
                    { 198, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2324), true, false, 25, 5, 24, 50, null, null },
                    { 199, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2324), true, false, 25, 6, 26, 50, null, null },
                    { 200, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2325), true, false, 25, 7, 30, 50, null, null },
                    { 201, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2623), true, false, 26, 1, 1, 50, null, null },
                    { 202, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2623), true, false, 26, 1, 2, 50, null, null },
                    { 203, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2624), true, false, 26, 1, 3, 50, null, null },
                    { 204, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2624), true, false, 26, 1, 4, 50, null, null },
                    { 205, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2625), true, false, 26, 4, 17, 50, null, null },
                    { 206, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2626), true, false, 26, 5, 24, 50, null, null },
                    { 207, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2627), true, false, 26, 6, 28, 50, null, null },
                    { 208, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2627), true, false, 26, 7, 31, 50, null, null },
                    { 209, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2886), true, false, 27, 1, 1, 50, null, null },
                    { 210, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2887), true, false, 27, 1, 2, 50, null, null },
                    { 211, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2887), true, false, 27, 1, 3, 50, null, null },
                    { 212, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2888), true, false, 27, 1, 4, 50, null, null },
                    { 213, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2889), true, false, 27, 4, 19, 50, null, null },
                    { 214, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2890), true, false, 27, 5, 23, 50, null, null },
                    { 215, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2890), true, false, 27, 6, 26, 50, null, null },
                    { 216, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(2891), true, false, 27, 7, 30, 50, null, null },
                    { 217, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3229), true, false, 28, 1, 1, 50, null, null },
                    { 218, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3229), true, false, 28, 1, 2, 50, null, null },
                    { 219, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3230), true, false, 28, 1, 3, 50, null, null },
                    { 220, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3230), true, false, 28, 1, 4, 50, null, null },
                    { 221, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3231), true, false, 28, 4, 36, 50, null, null },
                    { 222, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3231), true, false, 28, 5, 23, 50, null, null },
                    { 223, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3232), true, false, 28, 6, 28, 50, null, null },
                    { 224, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3233), true, false, 28, 7, 30, 50, null, null },
                    { 225, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3494), true, false, 29, 1, 1, 50, null, null },
                    { 226, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3495), true, false, 29, 1, 2, 50, null, null },
                    { 227, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3495), true, false, 29, 1, 3, 50, null, null },
                    { 228, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3496), true, false, 29, 1, 4, 50, null, null },
                    { 229, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3497), true, false, 29, 4, 19, 50, null, null },
                    { 230, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3497), true, false, 29, 5, 22, 50, null, null },
                    { 231, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3498), true, false, 29, 6, 27, 50, null, null },
                    { 232, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3499), true, false, 29, 7, 30, 50, null, null },
                    { 233, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3745), true, false, 30, 1, 1, 50, null, null },
                    { 234, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3745), true, false, 30, 1, 2, 50, null, null },
                    { 235, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3746), true, false, 30, 1, 3, 50, null, null },
                    { 236, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3746), true, false, 30, 1, 4, 50, null, null },
                    { 237, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3747), true, false, 30, 4, 16, 50, null, null },
                    { 238, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3748), true, false, 30, 5, 24, 50, null, null },
                    { 239, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3748), true, false, 30, 6, 28, 50, null, null },
                    { 240, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(3749), true, false, 30, 7, 30, 50, null, null },
                    { 241, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4018), true, false, 31, 1, 1, 50, null, null },
                    { 242, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4018), true, false, 31, 1, 2, 50, null, null },
                    { 243, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4019), true, false, 31, 1, 3, 50, null, null },
                    { 244, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4020), true, false, 31, 1, 4, 50, null, null },
                    { 245, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4020), true, false, 31, 4, 21, 50, null, null },
                    { 246, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4021), true, false, 31, 5, 23, 50, null, null },
                    { 247, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4022), true, false, 31, 6, 12, 50, null, null },
                    { 248, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4022), true, false, 31, 7, 29, 50, null, null },
                    { 249, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4285), true, false, 32, 1, 52, 50, null, null },
                    { 250, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4286), true, false, 32, 1, 53, 50, null, null },
                    { 251, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4286), true, false, 32, 1, 54, 50, null, null },
                    { 252, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4288), true, false, 32, 8, 37, 50, null, null },
                    { 253, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4289), true, false, 32, 9, 40, 50, null, null },
                    { 254, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4291), true, false, 32, 10, 43, 50, null, null },
                    { 255, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4308), true, false, 32, 11, 46, 50, null, null },
                    { 256, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4308), true, false, 32, 11, 47, 50, null, null },
                    { 257, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4309), true, false, 32, 11, 48, 50, null, null },
                    { 258, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4311), true, false, 32, 11, 50, 50, null, null },
                    { 259, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4333), true, false, 32, 11, 51, 50, null, null },
                    { 260, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4581), true, false, 33, 1, 52, 50, null, null },
                    { 261, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4581), true, false, 33, 1, 53, 50, null, null },
                    { 262, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4582), true, false, 33, 1, 54, 50, null, null },
                    { 263, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4582), true, false, 33, 8, 37, 50, null, null },
                    { 264, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4583), true, false, 33, 9, 40, 50, null, null },
                    { 265, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4583), true, false, 33, 10, 43, 50, null, null },
                    { 266, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4585), true, false, 33, 11, 46, 50, null, null },
                    { 267, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4585), true, false, 33, 11, 47, 50, null, null },
                    { 268, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4586), true, false, 33, 11, 48, 50, null, null },
                    { 269, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4586), true, false, 33, 11, 50, 50, null, null },
                    { 270, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4587), true, false, 33, 11, 51, 50, null, null },
                    { 271, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4840), true, false, 34, 1, 52, 50, null, null },
                    { 272, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4840), true, false, 34, 1, 53, 50, null, null },
                    { 273, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4841), true, false, 34, 1, 54, 50, null, null },
                    { 274, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4841), true, false, 34, 8, 37, 50, null, null },
                    { 275, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4842), true, false, 34, 9, 40, 50, null, null },
                    { 276, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4842), true, false, 34, 10, 43, 50, null, null },
                    { 277, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4843), true, false, 34, 11, 46, 50, null, null },
                    { 278, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4844), true, false, 34, 11, 47, 50, null, null },
                    { 279, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4844), true, false, 34, 11, 48, 50, null, null },
                    { 280, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4845), true, false, 34, 11, 50, 50, null, null },
                    { 281, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(4845), true, false, 34, 11, 51, 50, null, null },
                    { 282, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5090), true, false, 35, 1, 52, 50, null, null },
                    { 283, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5091), true, false, 35, 1, 53, 50, null, null },
                    { 284, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5091), true, false, 35, 1, 54, 50, null, null },
                    { 285, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5105), true, false, 35, 8, 37, 50, null, null },
                    { 286, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5106), true, false, 35, 9, 40, 50, null, null },
                    { 287, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5106), true, false, 35, 10, 43, 50, null, null },
                    { 288, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5107), true, false, 35, 11, 46, 50, null, null },
                    { 289, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5108), true, false, 35, 11, 47, 50, null, null },
                    { 290, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5108), true, false, 35, 11, 48, 50, null, null },
                    { 291, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5109), true, false, 35, 11, 50, 50, null, null },
                    { 292, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5109), true, false, 35, 11, 51, 50, null, null },
                    { 293, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5359), true, false, 36, 1, 52, 50, null, null },
                    { 294, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5360), true, false, 36, 1, 53, 50, null, null },
                    { 295, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5360), true, false, 36, 1, 54, 50, null, null },
                    { 296, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5361), true, false, 36, 8, 37, 50, null, null },
                    { 297, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5362), true, false, 36, 9, 40, 50, null, null },
                    { 298, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5363), true, false, 36, 10, 43, 50, null, null },
                    { 299, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5364), true, false, 36, 11, 46, 50, null, null },
                    { 300, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5365), true, false, 36, 11, 47, 50, null, null },
                    { 301, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5365), true, false, 36, 11, 48, 50, null, null },
                    { 302, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5365), true, false, 36, 11, 50, 50, null, null },
                    { 303, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5366), true, false, 36, 11, 51, 50, null, null },
                    { 304, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5614), true, false, 37, 1, 52, 50, null, null },
                    { 305, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5614), true, false, 37, 1, 53, 50, null, null },
                    { 306, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5615), true, false, 37, 1, 54, 50, null, null },
                    { 307, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5615), true, false, 37, 8, 37, 50, null, null },
                    { 308, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5616), true, false, 37, 9, 40, 50, null, null },
                    { 309, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5617), true, false, 37, 10, 43, 50, null, null },
                    { 310, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5618), true, false, 37, 11, 46, 50, null, null },
                    { 311, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5618), true, false, 37, 11, 47, 50, null, null },
                    { 312, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5618), true, false, 37, 11, 48, 50, null, null },
                    { 313, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5619), true, false, 37, 11, 50, 50, null, null },
                    { 314, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5619), true, false, 37, 11, 51, 50, null, null },
                    { 315, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5930), true, false, 38, 1, 52, 50, null, null },
                    { 316, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5931), true, false, 38, 1, 53, 50, null, null },
                    { 317, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5932), true, false, 38, 1, 54, 50, null, null },
                    { 318, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5933), true, false, 38, 8, 37, 50, null, null },
                    { 319, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5934), true, false, 38, 9, 40, 50, null, null },
                    { 320, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5935), true, false, 38, 10, 43, 50, null, null },
                    { 321, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5940), true, false, 38, 11, 46, 50, null, null },
                    { 322, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5940), true, false, 38, 11, 47, 50, null, null },
                    { 323, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5941), true, false, 38, 11, 48, 50, null, null },
                    { 324, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5942), true, false, 38, 11, 50, 50, null, null },
                    { 325, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(5942), true, false, 38, 11, 51, 50, null, null },
                    { 326, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6399), true, false, 39, 1, 52, 50, null, null },
                    { 327, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6399), true, false, 39, 1, 53, 50, null, null },
                    { 328, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6400), true, false, 39, 1, 54, 50, null, null },
                    { 329, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6400), true, false, 39, 8, 37, 50, null, null },
                    { 330, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6401), true, false, 39, 9, 40, 50, null, null },
                    { 331, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6401), true, false, 39, 10, 43, 50, null, null },
                    { 332, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6403), true, false, 39, 11, 46, 50, null, null },
                    { 333, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6403), true, false, 39, 11, 47, 50, null, null },
                    { 334, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6404), true, false, 39, 11, 48, 50, null, null },
                    { 335, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6404), true, false, 39, 11, 50, 50, null, null },
                    { 336, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6405), true, false, 39, 11, 51, 50, null, null },
                    { 337, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6697), true, false, 40, 1, 52, 50, null, null },
                    { 338, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6697), true, false, 40, 1, 53, 50, null, null },
                    { 339, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6697), true, false, 40, 1, 54, 50, null, null },
                    { 340, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6698), true, false, 40, 8, 37, 50, null, null },
                    { 341, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6698), true, false, 40, 9, 40, 50, null, null },
                    { 342, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6699), true, false, 40, 10, 43, 50, null, null },
                    { 343, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6700), true, false, 40, 11, 46, 50, null, null },
                    { 344, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6725), true, false, 40, 11, 47, 50, null, null },
                    { 345, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6725), true, false, 40, 11, 48, 50, null, null },
                    { 346, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6726), true, false, 40, 11, 50, 50, null, null },
                    { 347, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6726), true, false, 40, 11, 51, 50, null, null },
                    { 348, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6966), true, false, 41, 1, 52, 50, null, null },
                    { 349, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6967), true, false, 41, 1, 53, 50, null, null },
                    { 350, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6968), true, false, 41, 1, 54, 50, null, null },
                    { 351, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6968), true, false, 41, 8, 37, 50, null, null },
                    { 352, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6969), true, false, 41, 9, 40, 50, null, null },
                    { 353, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6969), true, false, 41, 10, 43, 50, null, null },
                    { 354, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6970), true, false, 41, 11, 46, 50, null, null },
                    { 355, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6971), true, false, 41, 11, 47, 50, null, null },
                    { 356, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6971), true, false, 41, 11, 48, 50, null, null },
                    { 357, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6972), true, false, 41, 11, 50, 50, null, null },
                    { 358, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(6972), true, false, 41, 11, 51, 50, null, null },
                    { 359, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7223), true, false, 42, 1, 52, 50, null, null },
                    { 360, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7224), true, false, 42, 1, 53, 50, null, null },
                    { 361, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7224), true, false, 42, 1, 54, 50, null, null },
                    { 362, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7225), true, false, 42, 8, 37, 50, null, null },
                    { 363, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7225), true, false, 42, 9, 40, 50, null, null },
                    { 364, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7226), true, false, 42, 10, 43, 50, null, null },
                    { 365, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7227), true, false, 42, 11, 46, 50, null, null },
                    { 366, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7227), true, false, 42, 11, 47, 50, null, null },
                    { 367, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7227), true, false, 42, 11, 48, 50, null, null },
                    { 368, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7228), true, false, 42, 11, 50, 50, null, null },
                    { 369, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7228), true, false, 42, 11, 51, 50, null, null },
                    { 370, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7547), true, false, 43, 1, 52, 50, null, null },
                    { 371, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7575), true, false, 43, 1, 53, 50, null, null },
                    { 372, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7576), true, false, 43, 1, 54, 50, null, null },
                    { 373, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7577), true, false, 43, 8, 37, 50, null, null },
                    { 374, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7577), true, false, 43, 9, 40, 50, null, null },
                    { 375, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7577), true, false, 43, 10, 43, 50, null, null },
                    { 376, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7578), true, false, 43, 11, 46, 50, null, null },
                    { 377, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7579), true, false, 43, 11, 47, 50, null, null },
                    { 378, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7579), true, false, 43, 11, 48, 50, null, null },
                    { 379, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7580), true, false, 43, 11, 50, 50, null, null },
                    { 380, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7580), true, false, 43, 11, 51, 50, null, null },
                    { 381, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7840), true, false, 44, 1, 52, 50, null, null },
                    { 382, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7841), true, false, 44, 1, 53, 50, null, null },
                    { 383, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7841), true, false, 44, 1, 54, 50, null, null },
                    { 384, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7842), true, false, 44, 8, 37, 50, null, null },
                    { 385, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7842), true, false, 44, 9, 40, 50, null, null },
                    { 386, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7843), true, false, 44, 10, 43, 50, null, null },
                    { 387, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7844), true, false, 44, 11, 46, 50, null, null },
                    { 388, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7844), true, false, 44, 11, 47, 50, null, null },
                    { 389, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7845), true, false, 44, 11, 48, 50, null, null },
                    { 390, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7845), true, false, 44, 11, 50, 50, null, null },
                    { 391, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(7845), true, false, 44, 11, 51, 50, null, null },
                    { 392, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8156), true, false, 45, 1, 52, 50, null, null },
                    { 393, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8157), true, false, 45, 1, 53, 50, null, null },
                    { 394, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8157), true, false, 45, 1, 54, 50, null, null },
                    { 395, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8158), true, false, 45, 8, 37, 50, null, null },
                    { 396, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8158), true, false, 45, 9, 40, 50, null, null },
                    { 397, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8159), true, false, 45, 10, 43, 50, null, null },
                    { 398, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8160), true, false, 45, 11, 46, 50, null, null },
                    { 399, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8160), true, false, 45, 11, 47, 50, null, null },
                    { 400, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8161), true, false, 45, 11, 48, 50, null, null },
                    { 401, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8161), true, false, 45, 11, 50, 50, null, null },
                    { 402, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8162), true, false, 45, 11, 51, 50, null, null },
                    { 403, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8462), true, false, 46, 1, 52, 50, null, null },
                    { 404, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8462), true, false, 46, 1, 53, 50, null, null },
                    { 405, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8463), true, false, 46, 1, 54, 50, null, null },
                    { 406, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8463), true, false, 46, 8, 37, 50, null, null },
                    { 407, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8464), true, false, 46, 9, 40, 50, null, null },
                    { 408, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8464), true, false, 46, 10, 43, 50, null, null },
                    { 409, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8465), true, false, 46, 11, 46, 50, null, null },
                    { 410, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8466), true, false, 46, 11, 47, 50, null, null },
                    { 411, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8466), true, false, 46, 11, 48, 50, null, null },
                    { 412, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8467), true, false, 46, 11, 50, 50, null, null },
                    { 413, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8467), true, false, 46, 11, 51, 50, null, null },
                    { 414, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8709), true, false, 47, 1, 52, 50, null, null },
                    { 415, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8709), true, false, 47, 1, 53, 50, null, null },
                    { 416, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8710), true, false, 47, 1, 54, 50, null, null },
                    { 417, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8710), true, false, 47, 8, 37, 50, null, null },
                    { 418, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8711), true, false, 47, 9, 40, 50, null, null },
                    { 419, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8711), true, false, 47, 10, 43, 50, null, null },
                    { 420, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8712), true, false, 47, 11, 46, 50, null, null },
                    { 421, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8713), true, false, 47, 11, 47, 50, null, null },
                    { 422, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8713), true, false, 47, 11, 48, 50, null, null },
                    { 423, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8714), true, false, 47, 11, 50, 50, null, null },
                    { 424, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8714), true, false, 47, 11, 51, 50, null, null },
                    { 425, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8963), true, false, 48, 1, 52, 50, null, null },
                    { 426, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8964), true, false, 48, 1, 53, 50, null, null },
                    { 427, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8964), true, false, 48, 1, 54, 50, null, null },
                    { 428, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8965), true, false, 48, 8, 37, 50, null, null },
                    { 429, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8965), true, false, 48, 9, 40, 50, null, null },
                    { 430, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8966), true, false, 48, 10, 43, 50, null, null },
                    { 431, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(8967), true, false, 48, 11, 46, 50, null, null },
                    { 432, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9000), true, false, 48, 11, 47, 50, null, null },
                    { 433, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9001), true, false, 48, 11, 48, 50, null, null },
                    { 434, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9001), true, false, 48, 11, 50, 50, null, null },
                    { 435, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9001), true, false, 48, 11, 51, 50, null, null },
                    { 436, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9254), true, false, 49, 1, 52, 50, null, null },
                    { 437, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9255), true, false, 49, 1, 53, 50, null, null },
                    { 438, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9255), true, false, 49, 1, 54, 50, null, null },
                    { 439, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9256), true, false, 49, 8, 37, 50, null, null },
                    { 440, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9256), true, false, 49, 9, 40, 50, null, null },
                    { 441, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9257), true, false, 49, 10, 43, 50, null, null },
                    { 442, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9257), true, false, 49, 11, 46, 50, null, null },
                    { 443, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9258), true, false, 49, 11, 47, 50, null, null },
                    { 444, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9259), true, false, 49, 11, 48, 50, null, null },
                    { 445, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9259), true, false, 49, 11, 50, 50, null, null },
                    { 446, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9259), true, false, 49, 11, 51, 50, null, null },
                    { 447, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9505), true, false, 50, 1, 52, 50, null, null },
                    { 448, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9506), true, false, 50, 1, 53, 50, null, null },
                    { 449, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9506), true, false, 50, 1, 54, 50, null, null },
                    { 450, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9507), true, false, 50, 8, 37, 50, null, null },
                    { 451, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9507), true, false, 50, 9, 40, 50, null, null },
                    { 452, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9508), true, false, 50, 10, 43, 50, null, null },
                    { 453, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9509), true, false, 50, 11, 46, 50, null, null },
                    { 454, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9510), true, false, 50, 11, 47, 50, null, null },
                    { 455, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9510), true, false, 50, 11, 48, 50, null, null },
                    { 456, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9511), true, false, 50, 11, 50, 50, null, null },
                    { 457, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9511), true, false, 50, 11, 51, 50, null, null },
                    { 458, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9854), true, false, 51, 1, 52, 50, null, null },
                    { 459, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9955), true, false, 51, 1, 53, 50, null, null },
                    { 460, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9956), true, false, 51, 1, 54, 50, null, null },
                    { 461, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9957), true, false, 51, 8, 37, 50, null, null },
                    { 462, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9957), true, false, 51, 9, 40, 50, null, null },
                    { 463, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9958), true, false, 51, 10, 43, 50, null, null },
                    { 464, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9959), true, false, 51, 11, 46, 50, null, null },
                    { 465, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9959), true, false, 51, 11, 47, 50, null, null },
                    { 466, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9960), true, false, 51, 11, 48, 50, null, null },
                    { 467, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9960), true, false, 51, 11, 50, 50, null, null },
                    { 468, null, new DateTime(2025, 4, 5, 18, 5, 3, 53, DateTimeKind.Local).AddTicks(9960), true, false, 51, 11, 51, 50, null, null },
                    { 469, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(300), true, false, 52, 1, 52, 50, null, null },
                    { 470, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(301), true, false, 52, 1, 53, 50, null, null },
                    { 471, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(301), true, false, 52, 1, 54, 50, null, null },
                    { 472, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(301), true, false, 52, 8, 37, 50, null, null },
                    { 473, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(302), true, false, 52, 9, 40, 50, null, null },
                    { 474, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(303), true, false, 52, 10, 43, 50, null, null },
                    { 475, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(303), true, false, 52, 11, 46, 50, null, null },
                    { 476, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(304), true, false, 52, 11, 47, 50, null, null },
                    { 477, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(304), true, false, 52, 11, 48, 50, null, null },
                    { 478, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(305), true, false, 52, 11, 50, 50, null, null },
                    { 479, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(305), true, false, 52, 11, 51, 50, null, null },
                    { 480, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(561), true, false, 53, 1, 52, 50, null, null },
                    { 481, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(561), true, false, 53, 1, 53, 50, null, null },
                    { 482, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(561), true, false, 53, 1, 54, 50, null, null },
                    { 483, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(562), true, false, 53, 8, 37, 50, null, null },
                    { 484, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(562), true, false, 53, 9, 40, 50, null, null },
                    { 485, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(563), true, false, 53, 10, 43, 50, null, null },
                    { 486, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(564), true, false, 53, 11, 46, 50, null, null },
                    { 487, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(564), true, false, 53, 11, 47, 50, null, null },
                    { 488, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(565), true, false, 53, 11, 48, 50, null, null },
                    { 489, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(565), true, false, 53, 11, 50, 50, null, null },
                    { 490, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(566), true, false, 53, 11, 51, 50, null, null },
                    { 491, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(849), true, false, 54, 1, 52, 50, null, null },
                    { 492, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(850), true, false, 54, 1, 53, 50, null, null },
                    { 493, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(850), true, false, 54, 1, 54, 50, null, null },
                    { 494, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(850), true, false, 54, 8, 37, 50, null, null },
                    { 495, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(851), true, false, 54, 9, 40, 50, null, null },
                    { 496, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(851), true, false, 54, 10, 43, 50, null, null },
                    { 497, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(852), true, false, 54, 11, 46, 50, null, null },
                    { 498, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(853), true, false, 54, 11, 47, 50, null, null },
                    { 499, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(853), true, false, 54, 11, 48, 50, null, null },
                    { 500, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(854), true, false, 54, 11, 50, 50, null, null },
                    { 501, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(854), true, false, 54, 11, 51, 50, null, null },
                    { 502, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1109), true, false, 55, 1, 52, 50, null, null },
                    { 503, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1110), true, false, 55, 1, 53, 50, null, null },
                    { 504, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1110), true, false, 55, 1, 54, 50, null, null },
                    { 505, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1111), true, false, 55, 8, 37, 50, null, null },
                    { 506, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1111), true, false, 55, 9, 40, 50, null, null },
                    { 507, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1112), true, false, 55, 10, 43, 50, null, null },
                    { 508, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1112), true, false, 55, 11, 46, 50, null, null },
                    { 509, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1113), true, false, 55, 11, 47, 50, null, null },
                    { 510, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1113), true, false, 55, 11, 48, 50, null, null },
                    { 511, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1114), true, false, 55, 11, 50, 50, null, null },
                    { 512, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1114), true, false, 55, 11, 51, 50, null, null },
                    { 513, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1356), true, false, 56, 1, 52, 50, null, null },
                    { 514, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1384), true, false, 56, 1, 53, 50, null, null },
                    { 515, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1385), true, false, 56, 1, 54, 50, null, null },
                    { 516, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1386), true, false, 56, 8, 37, 50, null, null },
                    { 517, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1386), true, false, 56, 9, 40, 50, null, null },
                    { 518, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1387), true, false, 56, 10, 43, 50, null, null },
                    { 519, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1409), true, false, 56, 11, 46, 50, null, null },
                    { 520, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1410), true, false, 56, 11, 47, 50, null, null },
                    { 521, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1410), true, false, 56, 11, 48, 50, null, null },
                    { 522, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1411), true, false, 56, 11, 50, 50, null, null },
                    { 523, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1411), true, false, 56, 11, 51, 50, null, null },
                    { 524, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1856), true, false, 57, 1, 52, 50, null, null },
                    { 525, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1857), true, false, 57, 1, 53, 50, null, null },
                    { 526, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1857), true, false, 57, 1, 54, 50, null, null },
                    { 527, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1858), true, false, 57, 8, 37, 50, null, null },
                    { 528, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1860), true, false, 57, 9, 40, 50, null, null },
                    { 529, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1861), true, false, 57, 10, 43, 50, null, null },
                    { 530, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1866), true, false, 57, 11, 46, 50, null, null },
                    { 531, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1866), true, false, 57, 11, 47, 50, null, null },
                    { 532, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1867), true, false, 57, 11, 48, 50, null, null },
                    { 533, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1867), true, false, 57, 11, 50, 50, null, null },
                    { 534, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(1868), true, false, 57, 11, 51, 50, null, null },
                    { 535, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2206), true, false, 58, 1, 52, 50, null, null },
                    { 536, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2206), true, false, 58, 1, 53, 50, null, null },
                    { 537, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2207), true, false, 58, 1, 54, 50, null, null },
                    { 538, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2207), true, false, 58, 8, 37, 50, null, null },
                    { 539, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2208), true, false, 58, 9, 40, 50, null, null },
                    { 540, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2208), true, false, 58, 10, 43, 50, null, null },
                    { 541, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2210), true, false, 58, 11, 46, 50, null, null },
                    { 542, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2211), true, false, 58, 11, 47, 50, null, null },
                    { 543, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2211), true, false, 58, 11, 48, 50, null, null },
                    { 544, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2212), true, false, 58, 11, 50, 50, null, null },
                    { 545, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2212), true, false, 58, 11, 51, 50, null, null },
                    { 546, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2488), true, false, 59, 1, 52, 50, null, null },
                    { 547, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2489), true, false, 59, 1, 53, 50, null, null },
                    { 548, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2489), true, false, 59, 1, 54, 50, null, null },
                    { 549, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2490), true, false, 59, 8, 37, 50, null, null },
                    { 550, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2490), true, false, 59, 9, 40, 50, null, null },
                    { 551, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2491), true, false, 59, 10, 43, 50, null, null },
                    { 552, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2492), true, false, 59, 11, 46, 50, null, null },
                    { 553, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2492), true, false, 59, 11, 47, 50, null, null },
                    { 554, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2493), true, false, 59, 11, 48, 50, null, null },
                    { 555, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2493), true, false, 59, 11, 50, 50, null, null },
                    { 556, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2493), true, false, 59, 11, 51, 50, null, null },
                    { 557, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2754), true, false, 60, 1, 52, 50, null, null },
                    { 558, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2755), true, false, 60, 1, 53, 50, null, null },
                    { 559, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2755), true, false, 60, 1, 54, 50, null, null },
                    { 560, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2755), true, false, 60, 8, 37, 50, null, null },
                    { 561, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2756), true, false, 60, 9, 40, 50, null, null },
                    { 562, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2756), true, false, 60, 10, 43, 50, null, null },
                    { 563, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2757), true, false, 60, 11, 46, 50, null, null },
                    { 564, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2758), true, false, 60, 11, 47, 50, null, null },
                    { 565, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2758), true, false, 60, 11, 48, 50, null, null },
                    { 566, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2758), true, false, 60, 11, 50, 50, null, null },
                    { 567, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2759), true, false, 60, 11, 51, 50, null, null },
                    { 568, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2997), true, false, 61, 1, 52, 50, null, null },
                    { 569, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2997), true, false, 61, 1, 53, 50, null, null },
                    { 570, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2998), true, false, 61, 1, 54, 50, null, null },
                    { 571, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2998), true, false, 61, 8, 37, 50, null, null },
                    { 572, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2998), true, false, 61, 9, 40, 50, null, null },
                    { 573, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(2999), true, false, 61, 10, 43, 50, null, null },
                    { 574, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3000), true, false, 61, 11, 46, 50, null, null },
                    { 575, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3000), true, false, 61, 11, 47, 50, null, null },
                    { 576, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3001), true, false, 61, 11, 48, 50, null, null },
                    { 577, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3001), true, false, 61, 11, 50, 50, null, null },
                    { 578, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3002), true, false, 61, 11, 51, 50, null, null },
                    { 579, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3276), true, false, 62, 1, 52, 50, null, null },
                    { 580, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3276), true, false, 62, 1, 53, 50, null, null },
                    { 581, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3277), true, false, 62, 1, 54, 50, null, null },
                    { 582, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3277), true, false, 62, 8, 37, 50, null, null },
                    { 583, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3277), true, false, 62, 9, 40, 50, null, null },
                    { 584, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3278), true, false, 62, 10, 43, 50, null, null },
                    { 585, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3279), true, false, 62, 11, 46, 50, null, null },
                    { 586, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3279), true, false, 62, 11, 47, 50, null, null },
                    { 587, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3280), true, false, 62, 11, 48, 50, null, null },
                    { 588, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3280), true, false, 62, 11, 50, 50, null, null },
                    { 589, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3281), true, false, 62, 11, 51, 50, null, null },
                    { 590, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3527), true, false, 63, 1, 52, 50, null, null },
                    { 591, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3528), true, false, 63, 1, 53, 50, null, null },
                    { 592, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3528), true, false, 63, 1, 54, 50, null, null },
                    { 593, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3529), true, false, 63, 8, 37, 50, null, null },
                    { 594, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3529), true, false, 63, 9, 40, 50, null, null },
                    { 595, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3530), true, false, 63, 10, 43, 50, null, null },
                    { 596, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3531), true, false, 63, 11, 46, 50, null, null },
                    { 597, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3531), true, false, 63, 11, 47, 50, null, null },
                    { 598, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3531), true, false, 63, 11, 48, 50, null, null },
                    { 599, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3532), true, false, 63, 11, 50, 50, null, null },
                    { 600, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3532), true, false, 63, 11, 51, 50, null, null },
                    { 601, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3764), true, false, 64, 1, 52, 50, null, null },
                    { 602, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3765), true, false, 64, 1, 53, 50, null, null },
                    { 603, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3765), true, false, 64, 1, 54, 50, null, null },
                    { 604, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3765), true, false, 64, 8, 37, 50, null, null },
                    { 605, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3801), true, false, 64, 9, 40, 50, null, null },
                    { 606, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3801), true, false, 64, 10, 43, 50, null, null },
                    { 607, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3803), true, false, 64, 11, 46, 50, null, null },
                    { 608, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3803), true, false, 64, 11, 47, 50, null, null },
                    { 609, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3803), true, false, 64, 11, 48, 50, null, null },
                    { 610, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3804), true, false, 64, 11, 50, 50, null, null },
                    { 611, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(3804), true, false, 64, 11, 51, 50, null, null },
                    { 612, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4060), true, false, 65, 1, 52, 50, null, null },
                    { 613, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4060), true, false, 65, 1, 53, 50, null, null },
                    { 614, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4061), true, false, 65, 1, 54, 50, null, null },
                    { 615, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4061), true, false, 65, 8, 37, 50, null, null },
                    { 616, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4062), true, false, 65, 9, 40, 50, null, null },
                    { 617, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4062), true, false, 65, 10, 43, 50, null, null },
                    { 618, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4063), true, false, 65, 11, 46, 50, null, null },
                    { 619, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4063), true, false, 65, 11, 47, 50, null, null },
                    { 620, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4064), true, false, 65, 11, 48, 50, null, null },
                    { 621, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4064), true, false, 65, 11, 50, 50, null, null },
                    { 622, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4065), true, false, 65, 11, 51, 50, null, null },
                    { 623, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4350), true, false, 66, 1, 52, 50, null, null },
                    { 624, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4351), true, false, 66, 1, 53, 50, null, null },
                    { 625, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4352), true, false, 66, 1, 54, 50, null, null },
                    { 626, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4352), true, false, 66, 8, 37, 50, null, null },
                    { 627, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4352), true, false, 66, 9, 40, 50, null, null },
                    { 628, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4353), true, false, 66, 10, 43, 50, null, null },
                    { 629, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4354), true, false, 66, 11, 46, 50, null, null },
                    { 630, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4354), true, false, 66, 11, 47, 50, null, null },
                    { 631, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4355), true, false, 66, 11, 48, 50, null, null },
                    { 632, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4355), true, false, 66, 11, 50, 50, null, null },
                    { 633, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4356), true, false, 66, 11, 51, 50, null, null },
                    { 634, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4621), true, false, 67, 1, 52, 50, null, null },
                    { 635, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4622), true, false, 67, 1, 53, 50, null, null },
                    { 636, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4622), true, false, 67, 1, 54, 50, null, null },
                    { 637, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4623), true, false, 67, 8, 37, 50, null, null },
                    { 638, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4623), true, false, 67, 9, 40, 50, null, null },
                    { 639, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4624), true, false, 67, 10, 43, 50, null, null },
                    { 640, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4625), true, false, 67, 11, 46, 50, null, null },
                    { 641, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4625), true, false, 67, 11, 47, 50, null, null },
                    { 642, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4626), true, false, 67, 11, 48, 50, null, null },
                    { 643, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4626), true, false, 67, 11, 50, 50, null, null },
                    { 644, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4627), true, false, 67, 11, 51, 50, null, null },
                    { 645, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4897), true, false, 68, 1, 52, 50, null, null },
                    { 646, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4898), true, false, 68, 1, 53, 50, null, null },
                    { 647, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4898), true, false, 68, 1, 54, 50, null, null },
                    { 648, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4899), true, false, 68, 8, 37, 50, null, null },
                    { 649, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4899), true, false, 68, 9, 40, 50, null, null },
                    { 650, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4900), true, false, 68, 10, 43, 50, null, null },
                    { 651, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4901), true, false, 68, 11, 46, 50, null, null },
                    { 652, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4901), true, false, 68, 11, 47, 50, null, null },
                    { 653, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4902), true, false, 68, 11, 48, 50, null, null },
                    { 654, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4902), true, false, 68, 11, 50, 50, null, null },
                    { 655, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(4902), true, false, 68, 11, 51, 50, null, null },
                    { 656, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5155), true, false, 69, 1, 52, 50, null, null },
                    { 657, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5155), true, false, 69, 1, 53, 50, null, null },
                    { 658, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5156), true, false, 69, 1, 54, 50, null, null },
                    { 659, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5156), true, false, 69, 8, 37, 50, null, null },
                    { 660, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5157), true, false, 69, 9, 40, 50, null, null },
                    { 661, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5157), true, false, 69, 10, 43, 50, null, null },
                    { 662, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5158), true, false, 69, 11, 46, 50, null, null },
                    { 663, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5159), true, false, 69, 11, 47, 50, null, null },
                    { 664, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5159), true, false, 69, 11, 48, 50, null, null },
                    { 665, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5159), true, false, 69, 11, 50, 50, null, null },
                    { 666, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5179), true, false, 69, 11, 51, 50, null, null },
                    { 667, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5434), true, false, 70, 1, 52, 50, null, null },
                    { 668, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5434), true, false, 70, 1, 53, 50, null, null },
                    { 669, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5435), true, false, 70, 1, 54, 50, null, null },
                    { 670, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5435), true, false, 70, 8, 37, 50, null, null },
                    { 671, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5435), true, false, 70, 9, 40, 50, null, null },
                    { 672, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5436), true, false, 70, 10, 43, 50, null, null },
                    { 673, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5437), true, false, 70, 11, 46, 50, null, null },
                    { 674, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5437), true, false, 70, 11, 47, 50, null, null },
                    { 675, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5438), true, false, 70, 11, 48, 50, null, null },
                    { 676, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5438), true, false, 70, 11, 50, 50, null, null },
                    { 677, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5438), true, false, 70, 11, 51, 50, null, null },
                    { 678, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5689), true, false, 71, 1, 52, 50, null, null },
                    { 679, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5690), true, false, 71, 1, 53, 50, null, null },
                    { 680, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5690), true, false, 71, 1, 54, 50, null, null },
                    { 681, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5690), true, false, 71, 8, 37, 50, null, null },
                    { 682, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5691), true, false, 71, 9, 40, 50, null, null },
                    { 683, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5691), true, false, 71, 10, 43, 50, null, null },
                    { 684, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5692), true, false, 71, 11, 46, 50, null, null },
                    { 685, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5693), true, false, 71, 11, 47, 50, null, null },
                    { 686, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5693), true, false, 71, 11, 48, 50, null, null },
                    { 687, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5694), true, false, 71, 11, 50, 50, null, null },
                    { 688, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5694), true, false, 71, 11, 51, 50, null, null },
                    { 689, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5950), true, false, 72, 1, 52, 50, null, null },
                    { 690, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5951), true, false, 72, 1, 53, 50, null, null },
                    { 691, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5979), true, false, 72, 1, 54, 50, null, null },
                    { 692, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5979), true, false, 72, 8, 37, 50, null, null },
                    { 693, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5980), true, false, 72, 9, 40, 50, null, null },
                    { 694, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5980), true, false, 72, 10, 43, 50, null, null },
                    { 695, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5981), true, false, 72, 11, 46, 50, null, null },
                    { 696, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5982), true, false, 72, 11, 47, 50, null, null },
                    { 697, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5982), true, false, 72, 11, 48, 50, null, null },
                    { 698, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5983), true, false, 72, 11, 50, 50, null, null },
                    { 699, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(5983), true, false, 72, 11, 51, 50, null, null },
                    { 700, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(6255), true, false, 73, 1, 52, 50, null, null },
                    { 701, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(6255), true, false, 73, 1, 53, 50, null, null },
                    { 702, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(6256), true, false, 73, 1, 54, 50, null, null },
                    { 703, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(6256), true, false, 73, 8, 37, 50, null, null },
                    { 704, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(6257), true, false, 73, 9, 40, 50, null, null },
                    { 705, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(6257), true, false, 73, 10, 43, 50, null, null },
                    { 706, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(6258), true, false, 73, 11, 46, 50, null, null },
                    { 707, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(6258), true, false, 73, 11, 47, 50, null, null },
                    { 708, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(6259), true, false, 73, 11, 48, 50, null, null },
                    { 709, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(6259), true, false, 73, 11, 50, 50, null, null },
                    { 710, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(6260), true, false, 73, 11, 51, 50, null, null },
                    { 711, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(6523), true, false, 74, 1, 53, 50, null, null },
                    { 712, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(6526), true, false, 74, 3, 11, 50, null, null },
                    { 713, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(6782), true, false, 75, 1, 52, 50, null, null },
                    { 714, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(6783), true, false, 75, 3, 11, 50, null, null },
                    { 715, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(7339), true, false, 76, 1, 52, 50, null, null },
                    { 716, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(7340), true, false, 76, 3, 11, 50, null, null },
                    { 717, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(7642), true, false, 77, 1, 52, 50, null, null },
                    { 718, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(7643), true, false, 77, 3, 11, 50, null, null },
                    { 719, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(7898), true, false, 78, 1, 52, 50, null, null },
                    { 720, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(7898), true, false, 78, 3, 14, 50, null, null },
                    { 721, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(8140), true, false, 79, 1, 58, 50, null, null },
                    { 722, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(8141), true, false, 79, 3, 14, 50, null, null },
                    { 723, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(8392), true, false, 80, 1, 55, 50, null, null },
                    { 724, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(8415), true, false, 80, 3, 11, 50, null, null },
                    { 725, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(8663), true, false, 81, 1, 54, 50, null, null },
                    { 726, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(8664), true, false, 81, 3, 14, 50, null, null },
                    { 727, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(8922), true, false, 82, 1, 54, 50, null, null },
                    { 728, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(8923), true, false, 82, 3, 11, 50, null, null },
                    { 729, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(9207), true, false, 83, 1, 52, 50, null, null },
                    { 730, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(9208), true, false, 83, 3, 14, 50, null, null },
                    { 731, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(9461), true, false, 84, 1, 54, 50, null, null },
                    { 732, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(9462), true, false, 84, 3, 11, 50, null, null },
                    { 733, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(9742), true, false, 85, 1, 52, 50, null, null },
                    { 734, null, new DateTime(2025, 4, 5, 18, 5, 3, 54, DateTimeKind.Local).AddTicks(9743), true, false, 85, 3, 14, 50, null, null },
                    { 735, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(39), true, false, 86, 1, 53, 50, null, null },
                    { 736, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(40), true, false, 86, 3, 14, 50, null, null },
                    { 737, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(332), true, false, 87, 1, 55, 50, null, null },
                    { 738, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(333), true, false, 87, 3, 11, 50, null, null },
                    { 739, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(578), true, false, 88, 1, 60, 50, null, null },
                    { 740, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(579), true, false, 88, 3, 11, 50, null, null },
                    { 741, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(918), true, false, 89, 1, 52, 50, null, null },
                    { 742, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(919), true, false, 89, 3, 11, 50, null, null },
                    { 743, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(2705), true, false, 90, 1, 54, 50, null, null },
                    { 744, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(2709), true, false, 90, 3, 14, 50, null, null },
                    { 745, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(3204), true, false, 91, 1, 64, 50, null, null },
                    { 746, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(3205), true, false, 91, 3, 14, 50, null, null },
                    { 747, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(3490), true, false, 92, 1, 53, 50, null, null },
                    { 748, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(3491), true, false, 92, 3, 11, 50, null, null },
                    { 749, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(3918), true, false, 93, 1, 57, 50, null, null },
                    { 750, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(3920), true, false, 93, 3, 11, 50, null, null },
                    { 751, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(4315), true, false, 94, 1, 56, 50, null, null },
                    { 752, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(4316), true, false, 94, 3, 14, 50, null, null },
                    { 753, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(4596), true, false, 95, 1, 56, 50, null, null },
                    { 754, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(4596), true, false, 95, 3, 11, 50, null, null },
                    { 755, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(4834), true, false, 96, 1, 59, 50, null, null },
                    { 756, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(4835), true, false, 96, 3, 14, 50, null, null },
                    { 757, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(5085), true, false, 97, 1, 52, 50, null, null },
                    { 758, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(5086), true, false, 97, 3, 14, 50, null, null },
                    { 759, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(5341), true, false, 98, 1, 53, 50, null, null },
                    { 760, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(5342), true, false, 98, 3, 11, 50, null, null },
                    { 761, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(5599), true, false, 99, 1, 55, 50, null, null },
                    { 762, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(5599), true, false, 99, 3, 11, 50, null, null },
                    { 763, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(5873), true, false, 100, 1, 52, 50, null, null },
                    { 764, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(5873), true, false, 100, 3, 11, 50, null, null },
                    { 765, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(6126), true, false, 101, 1, 52, 50, null, null },
                    { 766, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(6127), true, false, 101, 3, 14, 50, null, null },
                    { 767, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(6378), true, false, 102, 1, 57, 50, null, null },
                    { 768, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(6378), true, false, 102, 3, 14, 50, null, null },
                    { 769, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(6632), true, false, 103, 1, 53, 50, null, null },
                    { 770, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(6633), true, false, 103, 3, 14, 50, null, null },
                    { 771, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(6897), true, false, 104, 1, 52, 50, null, null },
                    { 772, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(6898), true, false, 104, 3, 14, 50, null, null },
                    { 773, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(7156), true, false, 105, 1, 53, 50, null, null },
                    { 774, null, new DateTime(2025, 4, 5, 18, 5, 3, 55, DateTimeKind.Local).AddTicks(7157), true, false, 105, 3, 11, 50, null, null },
                    { 821, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(4299), true, false, 129, 1, 53, 50, null, null },
                    { 822, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(4300), true, false, 129, 3, 11, 50, null, null },
                    { 823, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(4697), true, false, 130, 1, 53, 50, null, null },
                    { 824, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(5237), true, false, 131, 1, 53, 50, null, null },
                    { 825, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(5601), true, false, 132, 1, 53, 50, null, null },
                    { 826, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(5889), true, false, 133, 1, 53, 50, null, null },
                    { 827, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(6135), true, false, 134, 1, 53, 50, null, null },
                    { 828, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(6441), true, false, 135, 1, 53, 50, null, null },
                    { 829, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(6689), true, false, 136, 1, 53, 50, null, null },
                    { 830, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(6929), true, false, 137, 1, 53, 50, null, null },
                    { 831, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(7277), true, false, 138, 1, 53, 50, null, null },
                    { 832, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(7643), true, false, 139, 1, 53, 50, null, null },
                    { 833, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(7892), true, false, 140, 1, 53, 50, null, null },
                    { 834, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(8147), true, false, 141, 1, 65, 50, null, null },
                    { 835, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(8393), true, false, 142, 1, 65, 50, null, null },
                    { 836, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(8653), true, false, 143, 1, 65, 50, null, null },
                    { 837, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(8908), true, false, 144, 1, 65, 50, null, null },
                    { 838, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(9170), true, false, 145, 1, 65, 50, null, null },
                    { 839, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(9410), true, false, 146, 1, 66, 50, null, null },
                    { 840, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(9664), true, false, 147, 1, 66, 50, null, null },
                    { 841, null, new DateTime(2025, 4, 5, 18, 5, 3, 56, DateTimeKind.Local).AddTicks(9940), true, false, 148, 1, 66, 50, null, null },
                    { 842, null, new DateTime(2025, 4, 5, 18, 5, 3, 57, DateTimeKind.Local).AddTicks(467), true, false, 149, 1, 66, 50, null, null },
                    { 843, null, new DateTime(2025, 4, 5, 18, 5, 3, 57, DateTimeKind.Local).AddTicks(793), true, false, 150, 1, 66, 50, null, null },
                    { 844, null, new DateTime(2025, 4, 5, 18, 5, 3, 57, DateTimeKind.Local).AddTicks(1060), true, false, 151, 1, 53, 50, null, null },
                    { 845, null, new DateTime(2025, 4, 5, 18, 5, 3, 57, DateTimeKind.Local).AddTicks(1326), true, false, 152, 1, 53, 50, null, null },
                    { 846, null, new DateTime(2025, 4, 5, 18, 5, 3, 57, DateTimeKind.Local).AddTicks(1594), true, false, 153, 1, 53, 50, null, null },
                    { 847, null, new DateTime(2025, 4, 5, 18, 5, 3, 57, DateTimeKind.Local).AddTicks(1862), true, false, 154, 1, 53, 50, null, null },
                    { 848, null, new DateTime(2025, 4, 5, 18, 5, 3, 57, DateTimeKind.Local).AddTicks(2200), true, false, 155, 1, 53, 50, null, null },
                    { 849, null, new DateTime(2025, 4, 5, 18, 5, 3, 57, DateTimeKind.Local).AddTicks(2547), true, false, 156, 1, 53, 50, null, null },
                    { 850, null, new DateTime(2025, 4, 5, 18, 5, 3, 57, DateTimeKind.Local).AddTicks(2821), true, false, 157, 1, 53, 50, null, null },
                    { 851, null, new DateTime(2025, 4, 5, 18, 5, 3, 57, DateTimeKind.Local).AddTicks(3098), true, false, 158, 1, 53, 50, null, null }
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
