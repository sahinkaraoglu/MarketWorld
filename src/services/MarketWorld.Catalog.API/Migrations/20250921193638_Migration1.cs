using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketWorld.Catalog.API.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortenedEntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    AddressType = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                        name: "FK_Addresses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
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
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShippingAddressId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_ShippingAddressId",
                        column: x => x.ShippingAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                name: "CreditCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardHolderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cvv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditCards_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CreditCards_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
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
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductCode = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "Name", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6503), true, false, "Apple", null, null },
                    { 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6505), true, false, "Asus", null, null },
                    { 3, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6507), true, false, "Casper", null, null },
                    { 4, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6508), true, false, "HP", null, null },
                    { 5, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6509), true, false, "Lenovo", null, null },
                    { 6, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6511), true, false, "MSI", null, null },
                    { 7, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6512), true, false, "Acer", null, null },
                    { 8, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6513), true, false, "Xiaomi", null, null },
                    { 9, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6514), true, false, "Samsung", null, null },
                    { 10, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6516), true, false, "Huawei", null, null },
                    { 11, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6517), true, false, "Canon", null, null },
                    { 12, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6518), true, false, "Epson", null, null },
                    { 13, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6519), true, false, "Honor", null, null },
                    { 14, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6520), true, false, "Nothing", null, null },
                    { 15, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6521), true, false, "Infinix", null, null },
                    { 16, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6522), true, false, "Redmi", null, null },
                    { 17, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6523), true, false, "POCO", null, null },
                    { 18, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6525), true, false, "Oppo", null, null },
                    { 19, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6526), true, false, "Panasonic", null, null },
                    { 20, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6527), true, false, "Reeder", null, null },
                    { 21, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6528), true, false, "Tecno", null, null },
                    { 22, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6529), true, false, "Arçelik", null, null },
                    { 23, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6530), true, false, "Kumtel", null, null },
                    { 24, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6531), true, false, "Regal", null, null },
                    { 25, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6532), true, false, "Profilo", null, null },
                    { 26, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6533), true, false, "Altus", null, null },
                    { 27, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6534), true, false, "Hoover", null, null },
                    { 28, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6535), true, false, "Uğur", null, null },
                    { 29, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6537), true, false, "Arnell", null, null },
                    { 30, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6539), true, false, "Evora", null, null },
                    { 31, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6540), true, false, "Albergio", null, null },
                    { 32, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6541), true, false, "Kiwi", null, null },
                    { 33, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6542), true, false, "Vestel", null, null },
                    { 34, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6543), true, false, "Airfel", null, null },
                    { 35, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6545), true, false, "Regal", null, null },
                    { 36, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6546), true, false, "Kumtel", null, null },
                    { 37, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6547), true, false, "Bosch", null, null },
                    { 38, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6548), true, false, "Kaira", null, null },
                    { 39, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6549), true, false, "Xiaomi", null, null },
                    { 40, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6550), true, false, "Mirkraft", null, null },
                    { 41, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6551), true, false, "Samsung", null, null },
                    { 42, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6552), true, false, "Arnell", null, null },
                    { 43, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6553), true, false, "Zeeful", null, null },
                    { 44, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6554), true, false, "Beko", null, null },
                    { 45, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6555), true, false, "Arçelik", null, null },
                    { 46, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6556), true, false, "Baymak", null, null },
                    { 47, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6558), true, false, "FujiPlus", null, null },
                    { 48, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6559), true, false, "UFO", null, null },
                    { 49, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6560), true, false, "Abbruch", null, null },
                    { 50, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6630), true, false, "Sinbo", null, null },
                    { 51, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6631), true, false, "Magiceham", null, null },
                    { 52, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6632), true, false, "Demirdöküm", null, null },
                    { 53, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6633), true, false, "Tekdal", null, null },
                    { 54, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6634), true, false, "Raks", null, null },
                    { 55, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6635), true, false, "Hubstein", null, null },
                    { 56, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6636), true, false, "Mitsubishi", null, null },
                    { 57, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6637), true, false, "Goldsun", null, null },
                    { 58, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6638), true, false, "Multiteknik", null, null },
                    { 59, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6639), true, false, "Bayırtech", null, null },
                    { 60, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6640), true, false, "Harlem", null, null },
                    { 61, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6641), true, false, "Veito", null, null },
                    { 62, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6642), true, false, "Torima", null, null },
                    { 63, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6643), true, false, "Kiwi", null, null },
                    { 64, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6644), true, false, "Xnews", null, null },
                    { 65, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6645), true, false, "Hotic", null, null },
                    { 66, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6647), true, false, "Derilax", null, null },
                    { 67, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6648), true, false, "Ispartalılar", null, null },
                    { 68, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6649), true, false, "Selin Soylu", null, null },
                    { 69, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6650), true, false, "Sebago", null, null },
                    { 70, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6651), true, false, "Lumberjack", null, null },
                    { 71, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6652), true, false, "Dakirs", null, null },
                    { 72, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6653), true, false, "Letoon", null, null },
                    { 73, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6654), true, false, "Avva", null, null },
                    { 74, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6655), true, false, "Rmk", null, null },
                    { 75, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6656), true, false, "Tamer Tanca", null, null },
                    { 76, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6657), true, false, "Black Vein", null, null },
                    { 77, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6658), true, false, "Cabani", null, null },
                    { 78, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6659), true, false, "Dockers", null, null },
                    { 79, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6660), true, false, "Dgn", null, null },
                    { 80, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6661), true, false, "Hons", null, null },
                    { 81, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6662), true, false, "Daxtors", null, null },
                    { 82, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6663), true, false, "Tonny Black", null, null },
                    { 83, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6664), true, false, "Ayakkabıx", null, null },
                    { 84, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6665), true, false, "Hammer Jack", null, null },
                    { 85, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6666), true, false, "Kaptan Junior", null, null },
                    { 86, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6667), true, false, "Calvin Klein", null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsActive", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6106), "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar", true, false, "Elektronik", "elektronik", null, null },
                    { 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6123), "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları", true, false, "Giyim & Aksesuar", "giyim-aksesuar", null, null },
                    { 3, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6125), "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili", true, false, "Ev & Yaşam", "ev-yasam", null, null },
                    { 4, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6126), "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri", true, false, "Kozmetik & Kişisel Bakım", "kozmetik-kisisel-bakim", null, null },
                    { 5, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6128), "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri", true, false, "Spor & Outdoor", "spor-outdoor", null, null }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsActive", "IsDeleted", "Name", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2238), "Ürün Renk Seçenekleri", true, false, "Renk", null, null },
                    { 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2243), "Beden Seçenekleri", true, false, "Beden", null, null },
                    { 3, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2245), "Dahili Hafıza", true, false, "Hafıza", null, null },
                    { 4, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2246), "Bilgisayar İşlemci Seçenekleri", true, false, "İşlemci", null, null },
                    { 5, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2247), "Bellek Kapasitesi", true, false, "RAM", null, null },
                    { 6, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2250), "SSD Kapasitesi", true, false, "SSD", null, null },
                    { 7, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2251), "Ekran Boyutu", true, false, "Ekran", null, null },
                    { 8, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2253), "Yazıcı Teknolojisi", true, false, "Yazıcı Tipi", null, null },
                    { 9, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2254), "Mürekkep/Kartuş Sistemi", true, false, "Mürekkep Sistemi", null, null },
                    { 10, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2256), "Desteklenen Kağıt Boyutları", true, false, "Kağıt Boyutu", null, null },
                    { 11, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2257), "Yazıcı Fonksiyonları", true, false, "Fonksiyonlar", null, null }
                });

            migrationBuilder.InsertData(
                table: "PropertyValues",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "PropertyTypeId", "UpdatedById", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2291), true, false, 1, null, null, "Uzay Siyahı" },
                    { 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2294), true, false, 1, null, null, "Altın" },
                    { 3, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2295), true, false, 1, null, null, "Gümüş" },
                    { 4, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2296), true, false, 1, null, null, "Mor" },
                    { 5, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2297), true, false, 2, null, null, "XS" },
                    { 6, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2299), true, false, 2, null, null, "S" },
                    { 7, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2300), true, false, 2, null, null, "M" },
                    { 8, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2301), true, false, 2, null, null, "L" },
                    { 9, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2302), true, false, 2, null, null, "XL" },
                    { 10, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2304), true, false, 2, null, null, "XXL" },
                    { 11, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2305), true, false, 3, null, null, "128GB" },
                    { 12, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2306), true, false, 3, null, null, "256GB" },
                    { 13, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2307), true, false, 3, null, null, "512GB" },
                    { 14, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2309), true, false, 3, null, null, "1TB" },
                    { 15, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2310), true, false, 4, null, null, "Intel Core i7 12700H" },
                    { 16, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2311), true, false, 4, null, null, "Intel Core i7 1255U" },
                    { 17, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2312), true, false, 4, null, null, "Intel Core i7 13620H" },
                    { 18, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2314), true, false, 4, null, null, "Intel Core i5 1334U" },
                    { 19, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2315), true, false, 4, null, null, "Intel Core i5 13420H" },
                    { 20, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2316), true, false, 4, null, null, "AMD Ryzen 7 5700U" },
                    { 21, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2318), true, false, 4, null, null, "Intel Core i5 12450H" },
                    { 22, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2319), true, false, 5, null, null, "8GB" },
                    { 23, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2320), true, false, 5, null, null, "16GB" },
                    { 24, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2322), true, false, 5, null, null, "32GB" },
                    { 25, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2324), true, false, 6, null, null, "256GB" },
                    { 26, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2325), true, false, 6, null, null, "500GB" },
                    { 27, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2326), true, false, 6, null, null, "512GB" },
                    { 28, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2328), true, false, 6, null, null, "1TB" },
                    { 29, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2329), true, false, 7, null, null, "14\"" },
                    { 30, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2330), true, false, 7, null, null, "15.6\"" },
                    { 31, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2331), true, false, 7, null, null, "16\"" },
                    { 32, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2332), true, false, 4, null, null, "Intel Core i7 13650HX" },
                    { 33, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2333), true, false, 4, null, null, "Intel Core i5 13500H" },
                    { 34, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2335), true, false, 4, null, null, "Intel Core i9-14900HX" },
                    { 35, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2336), true, false, 4, null, null, "Intel Core Ultra 7 255HX" },
                    { 36, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2338), true, false, 4, null, null, "AMD Ryzen 5 7520U" },
                    { 37, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2339), true, false, 8, null, null, "Mürekkep Püskürtmeli" },
                    { 38, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2340), true, false, 8, null, null, "Lazer" },
                    { 39, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2368), true, false, 8, null, null, "Süblimasyon" },
                    { 40, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2369), true, false, 9, null, null, "Kartuşlu" },
                    { 41, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2371), true, false, 9, null, null, "Tanklı" },
                    { 42, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2372), true, false, 9, null, null, "Dolum Üniteli" },
                    { 43, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2373), true, false, 10, null, null, "A4" },
                    { 44, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2374), true, false, 10, null, null, "A3" },
                    { 45, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2377), true, false, 10, null, null, "A4/A3" },
                    { 46, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2378), true, false, 11, null, null, "Yazdırma" },
                    { 47, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2379), true, false, 11, null, null, "Tarama" },
                    { 48, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2380), true, false, 11, null, null, "Fotokopi" },
                    { 49, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2381), true, false, 11, null, null, "Faks" },
                    { 50, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2382), true, false, 11, null, null, "Wi-Fi" },
                    { 51, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2383), true, false, 11, null, null, "AirPrint" },
                    { 52, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2385), true, false, 1, null, null, "Siyah" },
                    { 53, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2386), true, false, 1, null, null, "Beyaz" },
                    { 54, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2387), true, false, 1, null, null, "Gri" },
                    { 55, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2388), true, false, 1, null, null, "Açık Mavi" },
                    { 56, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2389), true, false, 1, null, null, "Lacivert" },
                    { 57, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2390), true, false, 1, null, null, "Mavi" },
                    { 58, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2391), true, false, 1, null, null, "Mor" },
                    { 59, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2392), true, false, 1, null, null, "Altın" },
                    { 60, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2394), true, false, 1, null, null, "Nane Yeşili" },
                    { 61, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2395), true, false, 1, null, null, "Zümrüt Yeşili" },
                    { 62, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2396), true, false, 1, null, null, "Lacivert Taş" },
                    { 63, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2397), true, false, 1, null, null, "Natürel Titanyum" },
                    { 64, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2398), true, false, 1, null, null, "Grafit" },
                    { 65, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2399), true, false, 1, null, null, "Antrasit" },
                    { 66, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2401), true, false, 1, null, null, "Inox" },
                    { 67, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2402), true, false, 1, null, null, "Kırmızı" },
                    { 68, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2403), true, false, 1, null, null, "Turkuaz" },
                    { 69, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2405), true, false, 1, null, null, "Pembe" },
                    { 70, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2406), true, false, 1, null, null, "Turuncu" },
                    { 71, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2407), true, false, 1, null, null, "Sarı" },
                    { 72, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2408), true, false, 1, null, null, "Kahverengi" },
                    { 73, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(2409), true, false, 1, null, null, "Bej" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedDate", "Description", "IsActive", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6387), "Dizüstü, masaüstü bilgisayarlar ve tabletler", null, false, "Bilgisayarlar & Tabletler", "bilgisayarlar-tabletler", null, null },
                    { 2, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6389), "Yazıcılar, tarayıcılar ve projeksiyon cihazları", null, false, "Yazıcılar & Projeksiyon", "yazicilar-projeksiyon", null, null },
                    { 3, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6393), "Akıllı telefonlar ve aksesuarları", null, false, "Telefonlar", "telefonlar", null, null },
                    { 4, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6395), "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar", null, false, "Beyaz Eşya", "beyaz-esya", null, null },
                    { 5, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6396), "Klimalar, ısıtıcılar ve hava temizleyiciler", null, false, "Klima ve Isıtıcılar", "klima-isitici", null, null },
                    { 6, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6398), "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar", null, false, "Ayakkabı & Çanta", "ayakkabi-canta", null, null },
                    { 7, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6399), "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim", null, false, "Kadın Giyim", "kadin-giyim", null, null },
                    { 8, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6400), "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim", null, false, "Erkek Giyim", "erkek-giyim", null, null },
                    { 9, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6402), "Kız ve erkek çocuk giyim ürünleri", null, false, "Çocuk Giyim", "cocuk-giyim", null, null },
                    { 10, 3, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6403), "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları", null, false, "Mobilya", "mobilya", null, null },
                    { 11, 3, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6404), "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri", null, false, "Ev Tekstili", "ev-tekstili", null, null },
                    { 12, 3, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6406), "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri", null, false, "Dekorasyon & Aydınlatma", "dekorasyon-aydinlatma", null, null },
                    { 13, 3, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6407), "Pişirme, servis ve saklama ürünleri, mutfak aletleri", null, false, "Mutfak Gereçleri", "mutfak-gerecleri", null, null },
                    { 14, 3, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6409), "Banyo aksesuarları, temizlik ve düzenleme ürünleri", null, false, "Banyo & Ev Gereçleri", "banyo-ev-gerecleri", null, null },
                    { 15, 3, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6410), "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri", null, false, "Kırtasiye & Ofis", "kirtasiye-ve-ofis", null, null },
                    { 16, 4, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6411), "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri", null, false, "Parfüm & Deodorant", "parfum-deodorant", null, null },
                    { 17, 4, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6413), "Saç bakım ve şekillendirme ürünleri", null, false, "Saç Şekillendirme", "sac-sekillendirme", null, null },
                    { 18, 4, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6414), "Yüz ve vücut bakım ürünleri, kremler ve serumlar", null, false, "Cilt Bakımı", "cilt-bakimi", null, null },
                    { 19, 4, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6416), "Renkli kozmetik ve makyaj malzemeleri", null, false, "Makyaj", "makyaj", null, null },
                    { 20, 4, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6417), "Vitamin, takviye gıdalar ve medikal ürünler", null, false, "Sağlık & Medikal Ürünler", "saglik-medikal-urunler", null, null },
                    { 21, 4, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6459), "Diş bakım ürünleri ve ağız bakım ürünleri", null, false, "Ağız & Diş Bakımı", "agiz-dis-bakimi", null, null },
                    { 22, 5, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6460), "Fitness ekipmanları, kondisyon aletleri ve aksesuarları", null, false, "Fitness & Kondisyon", "fitness-kondisyon", null, null },
                    { 23, 5, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6462), "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar", null, false, "Spor Giyim & Ayakkabı", "spor-giyim-ayakkabi", null, null },
                    { 24, 5, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6463), "Kamp malzemeleri, outdoor giyim ve ekipmanlar", null, false, "Outdoor & Kamp", "outdoor-kamp", null, null },
                    { 25, 5, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6465), "Kayak ekipmanları ve kış sporları malzemeleri", null, false, "Kış Sporları", "kis-sporlari", null, null },
                    { 26, 5, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6466), "Yüzme ve su sporları ekipmanları", null, false, "Su Sporları", "su-sporlari", null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedById", "CreatedDate", "Description", "DiscountPrice", "HasDiscount", "IsActive", "IsDeleted", "Name", "Price", "ProductCode", "Rating", "SubCategoryId", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 3, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6753), "Intel Core i7 12700H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1270", 39999.99m, 101069, 4.5m, 1, null, null },
                    { 2, 6, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6758), "Intel Core i7 1255U 16GB 512GB SSD Freedos 14\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "MSI Modern 14 C12MO", 21799.99m, 777944, 4.5m, 1, null, null },
                    { 3, 3, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6792), "Core i7-13620H 32GB DDR5 RAM 1TB NVME SSD 16\" Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana S100", 27299.99m, 186512, 5m, 1, null, null },
                    { 4, 3, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6798), "Intel Core i7 13620H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1362", 50199.99m, 754734, 4.5m, 1, null, null },
                    { 5, 4, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6801), "Intel Core i5 1334U 16GB 512GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "HP 250 G10", 14999.99m, 149134, 4.7m, 1, null, null },
                    { 6, 5, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6804), "Intel Core i5 13420H 16GB Ddr5 Ram 512 GB SSD 16'' WUXGA IPS Panel Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad Slim 3", 19799.99m, 129194, 4.9m, 1, null, null },
                    { 7, 5, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6807), "AMD Ryzen 7 5700U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad 1", 15999.99m, 784236, 4.6m, 1, null, null },
                    { 8, 6, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6811), "Intel Core i5 12450H 8GB 512GB SSD RTX2050 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "MSI Thin 15", 24799.99m, 479665, 4.5m, 1, null, null },
                    { 9, 3, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6816), "Intel Core i7 1255U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana C550", 18999.99m, 202999, 4.5m, 1, null, null },
                    { 10, 5, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6819), "Intel Core i7 13650HX 32GB 1TB SSD RTX 4060 8GB (115W) 15.6\" FHD 144Hz IPS Panel Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo LOQ 15IRX9", 59999.99m, 923482, 5m, 1, null, null },
                    { 11, 3, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6821), "Intel Core i5-12450H 32GB RAM 500GB SSD GEN4 RTX3050 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G770", 31299.99m, 665679, 4.6m, 1, null, null },
                    { 12, 3, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6824), "AMD Ryzen 5 7430U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana X600", 16999.99m, 225371, 5m, 1, null, null },
                    { 13, 7, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6826), "Intel Core i7 1255U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Acer Aspire 3", 24000.00m, 305732, 5m, 1, null, null },
                    { 14, 3, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6832), "Intel Core i7 12700H 32GB 1TB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana X600.1270", 22999.99m, 623030, 4.5m, 1, null, null },
                    { 15, 3, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6834), "Intel Core i5-13420H 32GB RAM 500GB NVME SSD GEN4 6GB RTX4050 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G870.1342", 38499.99m, 941712, 4.1m, 1, null, null },
                    { 16, 3, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6836), "Intel Core i7 12700H 32GB 1TB SSD RTX4070 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1270", 50899.99m, 242912, 4m, 1, null, null },
                    { 17, 4, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6839), "Intel Core i5 13500H 16GB 512GB SSD RTX4050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "HP Victus Gaming 15", 33999.99m, 789075, 4.6m, 1, null, null },
                    { 18, 5, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6842), "Intel Core i5 12450H 8GB 512GB SSD 15.6\" FHD Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo IdeaPad Slim 3", 15359.04m, 252429, 4.7m, 1, null, null },
                    { 19, 2, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6846), "Intel Core i5 12500H 8GB 512GB SSD RTX3050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Asus TUF Gaming F15", 29898.66m, 873071, 4.7m, 1, null, null },
                    { 20, 1, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6849), "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Uzay Grisi", 0m, false, true, false, "Apple MacBook Air M1", 39250.00m, 601365, 4.9m, 1, null, null },
                    { 21, 3, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6852), "Intel Core i5-13420H 16GB RAM 1TB NVME SSD 8GB RTX4060 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G870.1342", 42299.99m, 176246, 4.3m, 1, null, null },
                    { 22, 5, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6856), "Intel Core i5 13420H 16GB 512GB SSD Freedos 14\" WUXGA Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad 5", 29999.99m, 763391, 5m, 1, null, null },
                    { 23, 2, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6859), "Intel Core Ultra 7 255HX 32GB 1TB SSD RTX5070Ti Freedos 16\" Taşınabilir Bilgisayar", 0m, false, true, false, "Asus ROG Strix G16", 107999.99m, 358233, 5m, 1, null, null },
                    { 24, 3, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6861), "Intel Core i5-13420H 32GB RAM 500GB NVME SSD Freedos", 0m, false, true, false, "Casper Nirvana X600.1342", 19999.99m, 535681, 5m, 1, null, null },
                    { 25, 5, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6863), "Intel Core i9-14900HX 32GB DDR5 1TB SSD RTX4060 8GB 16 inç 3.2K (3200×2000) 165Hz FreeDos Laptop", 0m, false, true, false, "Lenovo Thinkbook 16PG5", 79999.40m, 527039, 4.7m, 1, null, null },
                    { 26, 3, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6866), "Intel Core i7-13620H 16GB RAM 500GB NVME SSD Freedos Laptop", 0m, false, true, false, "Casper Nirvana X600.1362", 22099.99m, 412111, 5m, 1, null, null },
                    { 27, 6, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6870), "Intel Core i5 13420H 16GB 1TB SSD RTX4060 Freedos 15.6\" FHD 144Hz Taşınabilir Bilgisayar", 0m, false, true, false, "MSI CYBORG 15", 37999.99m, 956956, 4.9m, 1, null, null },
                    { 28, 5, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6875), "AMD Ryzen 5 7520U 8gb 512GB SSD Freedos 15.6\" Fhd Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo V15 G4", 13299.99m, 734965, 4.3m, 1, null, null },
                    { 29, 5, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6878), "I5-13420H 32GB 1 Tb SSD 15.6 Fhd Windows 11 Pro", 0m, false, true, false, "Lenovo V15 G4", 27749.00m, 976439, 5m, 1, null, null },
                    { 30, 1, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6881), "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Gece Yarısı", 0m, false, true, false, "Apple MacBook Air M4", 49999.99m, 943772, 5m, 1, null, null },
                    { 31, 3, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6886), "Intel Core i5 12450H 16GB 500GB SSD RTX2050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1245", 27499.99m, 955647, 4.4m, 1, null, null },
                    { 32, 4, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6889), "HP Deskjet Ink Advantage 2878 All-In-One Yazıcı", 0m, false, true, false, "HP Deskjet Ink Advantage 2878 All-In-One Yazıcı", 2799.00m, 265943, 4.1m, 2, null, null },
                    { 33, 11, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6894), "Canon Dolan Kartuşlu E414 Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Canon Dolan Kartuşlu E414 Yazıcı", 2299.08m, 508342, 4.4m, 2, null, null },
                    { 34, 11, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6924), "Canon Pixma TR4650 Tarayıcı + Fotokopi + Wi-Fi + Faks + Çok Fonksiyonlu Yazıcı", 0m, false, true, false, "Canon Pixma TR4650", 3379.00m, 513706, 4.2m, 2, null, null },
                    { 35, 11, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6930), "Canon Pixma E3640 Wi-Fi Tarayıcı - Fotokopi Çok Fonksiyonlu Mürekkep Püskürtmeli Yazıcı", 0m, false, true, false, "Canon Pixma E3640 Wi-Fi", 3399.00m, 972979, 4.6m, 2, null, null },
                    { 36, 12, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6934), "Epson L5290 Wi-Fi Renk Tanklı Yazıcı", 0m, false, true, false, "Epson L5290 Wi-Fi Renk Tanklı Yazıcı", 11983.51m, 784742, 4.4m, 2, null, null },
                    { 37, 12, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6938), "Epson Tanklı L3150 Photoink Muadil Mürekkepli Tanklı Yazıcı", 0m, false, true, false, "Epson Tanklı L3150 Photoink", 6033.86m, 296517, 4.6m, 2, null, null },
                    { 38, 4, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6941), "HP Officejet Pro 7720 Fotokopi + Faks + Tarayıcı + Wi-Fi + Airprint + A3 Yazıcı", 0m, false, true, false, "HP Officejet Pro 7720", 11138.06m, 174847, 4.6m, 2, null, null },
                    { 39, 11, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6945), "Canon E3640 Wifi Yazıcı ve Tıpalı Kartuş Sistemi", 0m, false, true, false, "Canon E3640 Wifi Yazıcı", 3306.56m, 760259, 4.3m, 2, null, null },
                    { 40, 12, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6952), "Epson L3151 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L3151 Tanklı Yazıcı", 4999.00m, 846755, 4.5m, 2, null, null },
                    { 41, 4, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6955), "HP LaserJet Pro M428f MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428f", 7999.00m, 225505, 4.3m, 2, null, null },
                    { 42, 11, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6958), "Canon PIXMA G3110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G3110", 3999.00m, 333764, 4.4m, 2, null, null },
                    { 43, 12, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6960), "Epson L3250 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L3250 Tanklı Yazıcı", 4499.00m, 699813, 4.6m, 2, null, null },
                    { 44, 4, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6965), "HP LaserJet Pro M428dw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428dw", 8999.00m, 650062, 4.5m, 2, null, null },
                    { 45, 11, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6970), "Canon PIXMA G4110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G4110", 4499.00m, 495755, 4.3m, 2, null, null },
                    { 46, 12, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6975), "Epson L4260 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4260 Tanklı Yazıcı", 5499.00m, 631331, 4.7m, 2, null, null },
                    { 47, 4, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6978), "HP LaserJet Pro M428fnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fnw", 9999.00m, 362066, 4.4m, 2, null, null },
                    { 48, 11, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6982), "Canon PIXMA G5110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G5110", 4999.00m, 852254, 4.5m, 2, null, null },
                    { 49, 12, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6984), "Epson L4266 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4266 Tanklı Yazıcı", 5999.00m, 181209, 4.6m, 2, null, null },
                    { 50, 4, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6987), "HP LaserJet Pro M428fdw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdw", 10999.00m, 421399, 4.5m, 2, null, null },
                    { 51, 11, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6990), "Canon PIXMA G6110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G6110", 5499.00m, 882441, 4.4m, 2, null, null },
                    { 52, 12, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6993), "Epson L4268 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4268 Tanklı Yazıcı", 6499.00m, 783924, 4.7m, 2, null, null },
                    { 53, 4, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6997), "HP LaserJet Pro M428fdn MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdn", 11999.00m, 818166, 4.6m, 2, null, null },
                    { 54, 11, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(6999), "Canon PIXMA G7110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G7110", 5999.00m, 140469, 4.5m, 2, null, null },
                    { 55, 12, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7002), "Epson L4269 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4269 Tanklı Yazıcı", 6999.00m, 461730, 4.8m, 2, null, null },
                    { 56, 4, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7005), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 12999.00m, 371615, 4.7m, 2, null, null },
                    { 57, 11, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7007), "Canon PIXMA G8110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G8110", 6499.00m, 777551, 4.6m, 2, null, null },
                    { 58, 12, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7010), "Epson L4267 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4267 Tanklı Yazıcı", 7499.00m, 892213, 4.9m, 2, null, null },
                    { 59, 4, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7013), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 13999.00m, 692636, 4.8m, 2, null, null },
                    { 60, 11, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7016), "Canon PIXMA G9110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G9110", 6999.00m, 544609, 4.7m, 2, null, null },
                    { 61, 12, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7018), "Epson L4265 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4265 Tanklı Yazıcı", 7999.00m, 232303, 4.8m, 2, null, null },
                    { 62, 4, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7022), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 14999.00m, 605578, 4.9m, 2, null, null },
                    { 63, 11, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7025), "Canon PIXMA G1010 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1010", 7499.00m, 330034, 4.8m, 2, null, null },
                    { 64, 12, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7027), "Epson L4264 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4264 Tanklı Yazıcı", 8499.00m, 499179, 4.9m, 2, null, null },
                    { 65, 4, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7059), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 15999.00m, 717919, 5.0m, 2, null, null },
                    { 66, 11, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7063), "Canon PIXMA G1110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1110", 7999.00m, 968565, 4.9m, 2, null, null },
                    { 67, 12, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7068), "Epson L4263 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4263 Tanklı Yazıcı", 8999.00m, 397887, 5.0m, 2, null, null },
                    { 68, 4, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7072), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 16999.00m, 466141, 5.0m, 2, null, null },
                    { 69, 11, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7076), "Canon PIXMA G1210 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1210", 8499.00m, 800842, 5.0m, 2, null, null },
                    { 70, 12, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7078), "Epson L4262 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4262 Tanklı Yazıcı", 9499.00m, 718027, 5.0m, 2, null, null },
                    { 71, 4, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7081), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 17999.00m, 976530, 5.0m, 2, null, null },
                    { 72, 11, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7087), "Canon PIXMA G1310 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1310", 8999.00m, 921267, 5.0m, 2, null, null },
                    { 73, 12, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7090), "Epson L4261 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4261 Tanklı Yazıcı", 9999.00m, 658008, 5.0m, 2, null, null },
                    { 74, 1, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7095), "Apple iPhone 13 128 GB Beyaz", 0m, false, true, false, "Apple iPhone 13 128 GB Beyaz", 100149m, 611368, 4.5m, 3, null, null },
                    { 75, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7098), "Samsung Galaxy A06 128 GB 4 GB RAM Siyah", 0m, false, true, false, "Samsung Galaxy A06 128 GB 4 GB RAM Siyah", 100149m, 265163, 4.0m, 3, null, null },
                    { 76, 1, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7105), "Apple iPhone 13 128 GB Siyah", 0m, false, true, false, "Apple iPhone 13 128 GB Siyah", 33699m, 785098, 4.5m, 3, null, null },
                    { 77, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7111), "Samsung Galaxy A16 128 GB 6 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A16 128 GB 6 GB Ram Siyah", 8789m, 697139, 4.2m, 3, null, null },
                    { 78, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7115), "Samsung Galaxy A35 256 GB 8 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A35 256 GB 8 GB Ram Siyah", 14449m, 402236, 4.3m, 3, null, null },
                    { 79, 13, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7118), "HONOR Magic 7 Lite 256 GB 8 GB Ram Mor", 0m, false, true, false, "HONOR Magic 7 Lite 256 GB 8 GB Ram Mor", 15999m, 242781, 4.4m, 3, null, null },
                    { 80, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7125), "Samsung Galaxy A06 128 GB 4 GB Ram Açık Mavi", 0m, false, true, false, "Samsung Galaxy A06 128 GB 4 GB Ram Açık Mavi", 6303m, 156343, 4.0m, 3, null, null },
                    { 81, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7127), "Samsung Galaxy S24+ 256 GB 12 GB Ram Gri", 0m, false, true, false, "Samsung Galaxy S24+ 256 GB 12 GB Ram Gri", 41599m, 967625, 4.8m, 3, null, null },
                    { 82, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7130), "Samsung Galaxy A16 128 GB 6 GB Ram Gri", 0m, false, true, false, "Samsung Galaxy A16 128 GB 6 GB Ram Gri", 8789m, 835685, 4.2m, 3, null, null },
                    { 83, 13, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7134), "HONOR Magic 7 Lite 256 GB 8 GB Ram Siyah", 0m, false, true, false, "HONOR Magic 7 Lite 256 GB 8 GB Ram Siyah", 15999m, 203712, 4.4m, 3, null, null },
                    { 84, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7137), "Samsung Galaxy S24 FE 128 GB 8 GB Ram Gri", 0m, false, true, false, "Samsung Galaxy S24 FE 128 GB 8 GB Ram Gri", 23849m, 661955, 4.6m, 3, null, null },
                    { 85, 14, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7141), "Nothing Phone 1 256 GB 8 GB Ram Siyah", 0m, false, true, false, "Nothing Phone 1 256 GB 8 GB Ram Siyah", 13999m, 341603, 4.3m, 3, null, null },
                    { 86, 14, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7144), "Nothing Phone (2a) 256 GB 12 GB Ram Beyaz", 0m, false, true, false, "Nothing Phone (2a) 256 GB 12 GB Ram Beyaz", 18999m, 751969, 4.5m, 3, null, null },
                    { 87, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7146), "Samsung Galaxy A35 128 GB 8 GB Ram Açık Mavi", 0m, false, true, false, "Samsung Galaxy A35 128 GB 8 GB Ram Açık Mavi", 13701m, 462688, 4.3m, 3, null, null },
                    { 88, 15, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7150), "Infinix Smart 9 128 GB 4 GB Ram Nane Yeşili", 0m, false, true, false, "Infinix Smart 9 128 GB 4 GB Ram Nane Yeşili", 5499m, 911691, 4.0m, 3, null, null },
                    { 89, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7152), "Samsung Galaxy A55 128 GB 8 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A55 128 GB 8 GB Ram Siyah", 16170m, 278260, 4.4m, 3, null, null },
                    { 90, 14, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7156), "Nothing Phone 2A Plus 256 GB 12 GB Ram Gri", 0m, false, true, false, "Nothing Phone 2A Plus 256 GB 12 GB Ram Gri", 22999m, 276027, 4.5m, 3, null, null },
                    { 91, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7159), "Samsung Galaxy S24 Fe 256 GB 8 GB Ram Grafit", 0m, false, true, false, "Samsung Galaxy S24 Fe 256 GB 8 GB Ram Grafit", 26299m, 397492, 4.6m, 3, null, null },
                    { 92, 1, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7161), "Apple iPhone 16e 128GB Beyaz", 0m, false, true, false, "Apple iPhone 16e 128GB Beyaz", 44799m, 496818, 4.7m, 3, null, null },
                    { 93, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7191), "Samsung Galaxy S24 FE 128 GB 8 GB Ram Mavi", 0m, false, true, false, "Samsung Galaxy S24 FE 128 GB 8 GB Ram Mavi", 23849m, 305016, 4.6m, 3, null, null },
                    { 94, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7197), "Samsung Galaxy S25+ 256 GB 12 GB Ram Lacivert", 0m, false, true, false, "Samsung Galaxy S25+ 256 GB 12 GB Ram Lacivert", 54799m, 856675, 4.8m, 3, null, null },
                    { 95, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7200), "Samsung B310 Dual Sim Lacivert", 0m, false, true, false, "Samsung B310 Dual Sim Lacivert", 1149m, 443225, 3.5m, 3, null, null },
                    { 96, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7205), "Samsung Galaxy S23 Ultra 512 GB 12 GB Ram Altın", 0m, false, true, false, "Samsung Galaxy S23 Ultra 512 GB 12 GB Ram Altın", 48899m, 289599, 4.9m, 3, null, null },
                    { 97, 16, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7208), "Redmi Note 14 Pro 12GB 512GB", 0m, false, true, false, "Redmi Note 14 Pro 12GB 512GB", 18999m, 325254, 4.4m, 3, null, null },
                    { 98, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7210), "Samsung B310E Dual Sim Kamerasız Cep Telefonu Beyaz", 0m, false, true, false, "Samsung B310E Dual Sim Kamerasız Cep Telefonu Beyaz", 1149m, 518048, 3.5m, 3, null, null },
                    { 99, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7213), "Samsung Galaxy A55 128 GB 8 GB Ram Açık Mavi", 0m, false, true, false, "Samsung Galaxy A55 128 GB 8 GB Ram Açık Mavi", 16507m, 973818, 4.4m, 3, null, null },
                    { 100, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7216), "Samsung Galaxy A35 128 GB 8 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A35 128 GB 8 GB Ram Siyah", 13559m, 626629, 4.3m, 3, null, null },
                    { 101, 16, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7220), "Redmi Note 14 Pro 8GB 256GB", 0m, false, true, false, "Redmi Note 14 Pro 8GB 256GB", 16599m, 247028, 4.4m, 3, null, null },
                    { 102, 1, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7223), "Apple iPhone 15 256 GB Mavi", 0m, false, true, false, "Apple iPhone 15 256 GB Mavi", 55999m, 454423, 4.8m, 3, null, null },
                    { 103, 1, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7226), "Apple iPhone 16 Pro 256GB Beyaz", 0m, false, true, false, "Apple iPhone 16 Pro 256GB Beyaz", 84599m, 726789, 4.9m, 3, null, null },
                    { 104, 8, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7229), "Xiaomi 14T Pro 12GB 512GB", 0m, false, true, false, "Xiaomi 14T Pro 12GB 512GB", 41000m, 270722, 4.5m, 3, null, null },
                    { 105, 1, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7234), "Apple iPhone 16 Pro 128GB Beyaz", 0m, false, true, false, "Apple iPhone 16 Pro 128GB Beyaz", 78499m, 239640, 4.8m, 3, null, null },
                    { 106, 13, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7237), "HONOR 200 512 GB 12 GB Ram Zümrüt Yeşili", 0m, false, true, false, "HONOR 200 512 GB 12 GB Ram Zümrüt Yeşili", 23999m, 982005, 0m, 3, null, null },
                    { 107, 1, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7240), "Apple iPhone 16 Pro 256GB Siyah", 0m, false, true, false, "Apple iPhone 16 Pro 256GB Siyah", 88825m, 182074, 0m, 3, null, null },
                    { 108, 16, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7243), "Xiaomi Redmi Note 13 Pro 256GB 8gb Ram Mor", 0m, false, true, false, "Xiaomi Redmi Note 13 Pro 256GB 8gb Ram Mor", 15999m, 649431, 0m, 3, null, null },
                    { 109, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7245), "Samsung Galaxy S25 128 GB 12 GB Ram Lacivert", 0m, false, true, false, "Samsung Galaxy S25 128 GB 12 GB Ram Lacivert", 45999m, 712016, 0m, 3, null, null },
                    { 110, 1, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7247), "Apple iPhone 16 256GB Lacivert Taş", 0m, false, true, false, "Apple iPhone 16 256GB Lacivert Taş", 66999m, 885744, 0m, 3, null, null },
                    { 111, 16, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7253), "Xiaomi Redmi Note 14 Pro Plus 5g 512 GB 12 GB Ram", 0m, false, true, false, "Xiaomi Redmi Note 14 Pro Plus 5g 512 GB 12 GB Ram", 27250m, 370912, 0m, 3, null, null },
                    { 112, 1, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7257), "Apple iPhone 16 Pro Max 512GB Natürel Titanyum", 0m, false, true, false, "Apple iPhone 16 Pro Max 512GB Natürel Titanyum", 101939m, 416382, 0m, 3, null, null },
                    { 113, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7259), "Samsung Galaxy A04S 64 GB Siyah", 0m, false, true, false, "Samsung Galaxy A04S 64 GB Siyah", 6839m, 219191, 0m, 3, null, null },
                    { 114, 16, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7261), "Redmi Note 14 Pro 5G 12GB 512GB", 0m, false, true, false, "Redmi Note 14 Pro 5G 12GB 512GB", 22500m, 486095, 0m, 3, null, null },
                    { 115, 14, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7264), "Nothing Phone 1 128 GB 8 GB Ram Siyah", 0m, false, true, false, "Nothing Phone 1 128 GB 8 GB Ram Siyah", 12999m, 878907, 0m, 3, null, null },
                    { 116, 16, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7268), "Xiaomi Redmi Note 13 Pro 512GB 12GB Siyah", 0m, false, true, false, "Xiaomi Redmi Note 13 Pro 512GB 12GB Siyah", 18999m, 373899, 0m, 3, null, null },
                    { 117, 16, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7270), "Xiaomi Redmi 12 128 GB 8 GB Ram Siyah", 0m, false, true, false, "Xiaomi Redmi 12 128 GB 8 GB Ram Siyah", 8190m, 391554, 0m, 3, null, null },
                    { 118, 13, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7273), "HONOR Magic V3 512 GB 12 GB Ram Yeşil", 0m, false, true, false, "HONOR Magic V3 512 GB 12 GB Ram Yeşil", 79999m, 805556, 0m, 3, null, null },
                    { 119, 21, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7276), "Tecno Spark 30 256 GB 8 GB Ram", 0m, false, true, false, "Tecno Spark 30 256 GB 8 GB Ram", 9199m, 295089, 0m, 3, null, null },
                    { 120, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7278), "Samsung Galaxy S25 Ultra 1 Tb 12 GB Ram", 0m, false, true, false, "Samsung Galaxy S25 Ultra 1 Tb 12 GB Ram", 88999m, 829837, 0m, 3, null, null },
                    { 121, 1, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7281), "Apple iPhone 16 Pro 128GB Siyah", 0m, false, true, false, "Apple iPhone 16 Pro 128GB Siyah", 79324m, 283073, 0m, 3, null, null },
                    { 122, 20, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7284), "Reeder P13 Blue Max L 2022 64 GB Beyaz", 0m, false, true, false, "Reeder P13 Blue Max L 2022 64 GB Beyaz", 3399m, 665368, 0m, 3, null, null },
                    { 123, 17, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7286), "POCO X7 12GB 512GB", 0m, false, true, false, "POCO X7 12GB 512GB", 17499m, 784876, 0m, 3, null, null },
                    { 124, 18, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7289), "Oppo A60 8GB 256GB Mavi", 0m, false, true, false, "Oppo A60 8GB 256GB Mavi", 10199m, 360098, 0m, 3, null, null },
                    { 125, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7292), "Samsung Galaxy A25 5G 256 GB 8 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A25 5G 256 GB 8 GB Ram Siyah", 13250m, 642343, 0m, 3, null, null },
                    { 126, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7295), "Samsung Galaxy S25 256 GB Lacivert", 0m, false, true, false, "Samsung Galaxy S25 256 GB Lacivert", 47670m, 271118, 0m, 3, null, null },
                    { 127, 19, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7318), "Panasonic KX-TU550EXB Katlanabilir Renkli Ekran 4g Tuşlu Cep Telefonu Siyah", 0m, false, true, false, "Panasonic KX-TU550EXB Katlanabilir Renkli Ekran 4g Tuşlu Cep Telefonu Siyah", 4269m, 357497, 0m, 3, null, null },
                    { 128, 20, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7321), "Reeder S19 Max Pro 256 GB 6 GB Ram Siyah", 0m, false, true, false, "Reeder S19 Max Pro 256 GB 6 GB Ram Siyah", 4799m, 646367, 0m, 3, null, null },
                    { 129, 9, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7324), "Samsung B310E Cep Telefonu Beyaz", 0m, false, true, false, "Samsung B310E Cep Telefonu Beyaz", 1149m, 301468, 3.5m, 3, null, null },
                    { 130, 22, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7328), "Arçelik 6167 6 Programlı Beyaz Bulaşık Makinesi", 0m, false, true, false, "Arçelik 6167 6 Programlı Beyaz Bulaşık Makinesi", 25739.01m, 155932, 4.5m, 4, null, null },
                    { 131, 23, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7331), "Kumtel Beyaz Cam Digital / Dokunmatik Ankastre Set - 8 Programlı (KO-40 TAHDF Ocak B66-Sf2 Ddt Fırın DA6-835 Davlumbaz)", 0m, false, true, false, "Kumtel Beyaz Cam Digital / Dokunmatik Ankastre Set", 11299m, 845622, 4.1m, 4, null, null },
                    { 132, 24, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7337), "Regal Bm 310 3 Programlı Bulaşık Makinesi", 0m, false, true, false, "Regal Bm 310 3 Programlı Bulaşık Makinesi", 11549m, 231061, 4.6m, 4, null, null },
                    { 133, 25, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7340), "Profilo BM6320MA D Enerji Sınıfı 6 Programlı Bulaşık Makinesi", 0m, false, true, false, "Profilo BM6320MA D Enerji Sınıfı 6 Programlı Bulaşık Makinesi", 15999m, 434271, 4.7m, 4, null, null },
                    { 134, 26, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7344), "Altus AL 7103 MD 1000 Devir 7 kg Çamaşır Makinesi", 0m, false, true, false, "Altus AL 7103 MD 1000 Devir 7 kg Çamaşır Makinesi", 12479m, 250457, 4.6m, 4, null, null },
                    { 135, 26, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7350), "Altus AL 10123 D C Enerji 10 Kg Çamaşır Makinesi", 0m, false, true, false, "Altus AL 10123 D C Enerji 10 Kg Çamaşır Makinesi", 17028m, 363739, 4.7m, 4, null, null },
                    { 136, 27, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7353), "Hoover NDEH 10A2TSBE-17 10 kg Wi-Fi + Bluetooth Bağlantılı Isı Pompalı Kurutma Makinesi", 0m, false, true, false, "Hoover NDEH 10A2TSBE-17 10 kg Isı Pompalı Kurutma Makinesi", 14999m, 621346, 4.5m, 4, null, null },
                    { 137, 22, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7356), "Arçelik 7103 D 7 Kg 1000 Devir Çamaşır Makinesi", 0m, false, true, false, "Arçelik 7103 D 7 Kg 1000 Devir Çamaşır Makinesi", 14999m, 781775, 4.5m, 4, null, null },
                    { 138, 28, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7359), "Uğur UES 507 D/S 3 Kapılı No-Frost Buzdolabı", 0m, false, true, false, "Uğur UES 507 D/S 3 Kapılı No-Frost Buzdolabı", 29999m, 462244, 4.3m, 4, null, null },
                    { 139, 33, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7362), "Vestel NF480 EX A++ Siyah 453 Lt No-Frost Buzdolabı", 0m, false, true, false, "Vestel NF480 EX Siyah No-Frost Buzdolabı", 23599m, 410856, 4.4m, 4, null, null },
                    { 140, 24, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7365), "Regal 90 LT A+ Mini Buzdolabı", 0m, false, true, false, "Regal 90 LT A+ Mini Buzdolabı", 6499m, 140609, 4.6m, 4, null, null },
                    { 141, 29, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7369), "Arnell Ankastre Set (8665 MDOC Ankastre Fırın + 1140-CSBDF 4 Gözlü Ocak + DS3490EC / EC3490 Davlumbaz)", 0m, false, true, false, "Arnell Ankastre Set", 13499m, 929688, 4.2m, 4, null, null },
                    { 142, 30, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7372), "Evora 3'lü Siyah Cam Ankastre Set (EAF-6056 Fırın + EAO-8505 Ocak + EAD-9263 Davlumbaz)", 0m, false, true, false, "Evora Siyah Cam Set", 10990m, 136989, 4.1m, 4, null, null },
                    { 143, 31, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7378), "Albergio AL-FO-005-E Ankastre Fırın", 0m, false, true, false, "Albergio AL-FO-005-E Ankastre Fırın", 5499m, 177199, 4.0m, 4, null, null },
                    { 144, 32, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7380), "Kiwi KSW-4215 Beyaz Soğuk Su Sebili", 0m, false, true, false, "Kiwi KSW-4215 Beyaz Soğuk Su Sebili", 1299m, 418796, 3.9m, 4, null, null },
                    { 145, 33, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7383), "Vestel SP 100 Beyaz Soğuk Su Sebili", 0m, false, true, false, "Vestel SP 100 Beyaz Soğuk Su Sebili", 1499m, 229491, 4.0m, 4, null, null },
                    { 146, 22, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7386), "Arçelik 1100 S Beyaz Su Sebili", 0m, false, true, false, "Arçelik 1100 S Beyaz Su Sebili", 1999m, 821830, 4.2m, 4, null, null },
                    { 147, 25, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7389), "Profilo SP 100 Sıcak/Soğuk Su Sebili", 0m, false, true, false, "Profilo SP 100 Sıcak/Soğuk Su Sebili", 2299m, 898087, 4.3m, 4, null, null },
                    { 148, 22, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7393), "Arçelik 5500 BT Mini Fırın - 15 Litre", 0m, false, true, false, "Arçelik 5500 BT Mini Fırın", 4999m, 371705, 4.5m, 4, null, null },
                    { 149, 23, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7396), "Kumtel KF3150 Mini Fırın - 36 Litre Beyaz", 0m, false, true, false, "Kumtel KF3150 Mini Fırın", 2699m, 246265, 4.3m, 4, null, null },
                    { 150, 33, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7435), "Vestel R8080 Retro Buzdolabı - Kırmızı", 0m, false, true, false, "Vestel R8080 Retro Buzdolabı", 28900m, 517601, 4.7m, 4, null, null },
                    { 151, 22, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7438), "Arçelik 9144 YI Ultra Hijyen 9 Kg 1400 Devir Çamaşır Makinesi", 0m, false, true, false, "Arçelik 9144 YI Ultra Hijyen 9 Kg Çamaşır Makinesi", 21950m, 189273, 4.8m, 4, null, null },
                    { 152, 25, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7441), "Profilo CGA242X1TR A++ 9 Kg 1200 Devir Çamaşır Makinesi", 0m, false, true, false, "Profilo CGA242X1TR A++ 9 Kg Çamaşır Makinesi", 18999m, 358758, 4.5m, 4, null, null },
                    { 153, 24, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7445), "Regal Pratik 2000 Toz Torbasız Elektrikli Süpürge", 0m, false, true, false, "Regal Pratik 2000 Elektrikli Süpürge", 2999m, 495374, 4.2m, 4, null, null },
                    { 154, 33, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7448), "Vestel BM 5201 X EKO PLUS Bulaşık Makinesi", 0m, false, true, false, "Vestel EKO PLUS Bulaşık Makinesi", 12999m, 566554, 4.3m, 4, null, null },
                    { 155, 22, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7451), "Arçelik K 3290 Telve Otomatik Türk Kahve Makinesi - Siyah", 0m, false, true, false, "Arçelik K 3290 Telve Türk Kahve Makinesi", 3299m, 296867, 4.9m, 4, null, null },
                    { 156, 26, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7453), "Altus AL 413 E 4 Programlı Bulaşık Makinesi", 0m, false, true, false, "Altus AL 413 E 4 Programlı Bulaşık Makinesi", 13499m, 721246, 4.1m, 4, null, null },
                    { 157, 27, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7456), "Hoover HLWOQ 59B-S 9 Kg Çamaşır Kurutma Makinesi", 0m, false, true, false, "Hoover HLWOQ 59B-S Çamaşır Kurutma Makinesi", 17999m, 995547, 4.4m, 4, null, null },
                    { 158, 33, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7460), "Vestel MAYA 10100 ST 10 Kg 1000 Devir Çamaşır Makinesi", 0m, false, true, false, "Vestel MAYA 10100 ST Çamaşır Makinesi", 14599m, 674943, 4.5m, 4, null, null },
                    { 159, 34, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7464), "Airfel LTXM35N 12000 BTU R32 Inverter Duvar Tipi Klima", 0m, false, true, false, "Airfel LTXM35N 12000 BTU R32 Inverter Duvar Tipi Klima", 25541.01m, 205896, 4.6m, 5, null, null },
                    { 160, 35, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7470), "Regal Luna A++ 15000 BTU Inverter Duvar Tipi Klima", 0m, false, true, false, "Regal Luna A++ 15000 BTU Inverter Duvar Tipi Klima", 26499m, 545989, 4.6m, 5, null, null },
                    { 161, 36, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7473), "Kumtel Bej Fanlı Isıtıcı 2000 W LX - 6331", 0m, false, true, false, "Kumtel Bej Fanlı Isıtıcı 2000 W LX - 6331", 509m, 806623, 4.2m, 5, null, null },
                    { 162, 37, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7475), "Bosch Climate CL2000U W 35 E A++ 12000 BTU Duvar Tipi Klima", 0m, false, true, false, "Bosch Climate CL2000U W 35 E A++ 12000 BTU Duvar Tipi Klima", 26999m, 920422, 4.4m, 5, null, null },
                    { 163, 38, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7478), "Kaira DTXR35E A++ 12000 BTU Wifi Inverter Duvar Tipi Klima (Montaj Dahil)", 0m, false, true, false, "Kaira DTXR35E A++ 12000 BTU Wifi Inverter Duvar Tipi Klima", 25840m, 444517, 4.4m, 5, null, null },
                    { 164, 36, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7482), "Kumtel Juniper Portatif Taşınabilir Klima Kmpac-7", 0m, false, true, false, "Kumtel Juniper Portatif Taşınabilir Klima Kmpac-7", 9999m, 197264, 4.3m, 5, null, null },
                    { 165, 33, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7484), "Vestel Flora Doğa 124 A++ Wifi 12000 BTU Inverter Duvar Tipi Klima", 0m, false, true, false, "Vestel Flora Doğa 124 A++ Wifi 12000 BTU Inverter Duvar Tipi Klima", 26235m, 998527, 4.6m, 5, null, null },
                    { 166, 39, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7487), "Xiaomi ZMYDFS01DM Şarj Edilebilir Mini Fan", 0m, false, true, false, "Xiaomi ZMYDFS01DM Şarj Edilebilir Mini Fan", 1889m, 806018, 5m, 5, null, null },
                    { 167, 36, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7491), "Kumtel LX-2832 Siyah 1500 Watt Isıtıcı", 0m, false, true, false, "Kumtel LX-2832 Siyah 1500 Watt Isıtıcı", 549m, 462559, 4.5m, 5, null, null },
                    { 168, 40, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7494), "Mirkraft Future 2500 Watt Elektrikli Isıtıcı - IP24 - LCD Ekran - Uzaktan Kumandalı - 4 Isı Ayarı", 0m, false, true, false, "Mirkraft Future 2500 Watt Elektrikli Isıtıcı", 5559.66m, 581718, 5m, 5, null, null },
                    { 169, 41, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7497), "Samsung Premium AR18TSHZHWK A++ 18000 BTU Inverter Duvar Tipi Klima", 0m, false, true, false, "Samsung Premium AR18TSHZHWK A++ 18000 BTU Inverter Duvar Tipi Klima", 38599m, 323093, 4.4m, 5, null, null },
                    { 170, 42, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7501), "Arnell Elektrikli Isıtıcı Quartz Ev Ve Ofis Oda Tipi 3+1 Çubuklu Güvenli Elektrikli Soba - 2600 Watt", 0m, false, true, false, "Arnell Elektrikli Isıtıcı Quartz", 2218.63m, 826827, 3m, 5, null, null },
                    { 171, 36, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7505), "Kumtel Ks-2760 Quartz Isıtıcı Siyah", 0m, false, true, false, "Kumtel Ks-2760 Quartz Isıtıcı Siyah", 999m, 401368, 4.1m, 5, null, null },
                    { 172, 43, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7507), "Zeeful Süper Güç Üfleyici Mini Turbo Jet Fan 130000RPM 52+M/s 4000MAH (Yurt Dışından)", 0m, false, true, false, "Zeeful Süper Güç Üfleyici Mini Turbo Jet Fan", 1750.32m, 538470, 4.5m, 5, null, null },
                    { 173, 44, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7510), "Beko 31225 Ekolojik A++ 12000 BTU Duvar Tipi Klima", 0m, false, true, false, "Beko 31225 Ekolojik A++ 12000 BTU Duvar Tipi Klima", 27754.65m, 276829, 4.6m, 5, null, null },
                    { 174, 33, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7514), "Vestel Flora Doğa 244 A++ 24000 BTU Wifi Inverter Duvar Tipi Klima", 0m, false, true, false, "Vestel Flora Doğa 244 A++ 24000 BTU Wifi Inverter Duvar Tipi Klima", 42362.10m, 115043, 4.4m, 5, null, null },
                    { 175, 45, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7516), "Arçelik Ekolojik 18325 A++ 18000 BTU Inverter Duvar Tipi Klima", 0m, false, true, false, "Arçelik Ekolojik 18325 A++ 18000 BTU Inverter Duvar Tipi Klima", 39897m, 532781, 4.4m, 5, null, null },
                    { 176, 42, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7519), "Arnell Elektrikli Isıtıcı Duvar Tip Soba 3000 Watt", 0m, false, true, false, "Arnell Elektrikli Isıtıcı Duvar Tip Soba", 1431.06m, 691691, 4.8m, 5, null, null },
                    { 177, 46, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7522), "Baymak Elegant Plus UV 18 A++ (Montaj Dahil) 18000 BTU Duvar Tipi Klima", 0m, false, true, false, "Baymak Elegant Plus UV 18 A++ 18000 BTU Duvar Tipi Klima", 44989m, 154614, 4.4m, 5, null, null },
                    { 178, 47, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7524), "FujiPlus Fujiplus Sakura 12000 Btu Inverter Duvar Tipi Klima", 0m, false, true, false, "FujiPlus Sakura 12000 Btu Inverter Duvar Tipi Klima", 22777.03m, 127761, 3.9m, 5, null, null },
                    { 179, 46, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7527), "Baymak Aqua Konfor 65 Litre Termosifon", 0m, false, true, false, "Baymak Aqua Konfor 65 Litre Termosifon", 8439m, 344437, 4.5m, 5, null, null },
                    { 180, 36, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7529), "Kumtel Ecoray Ex-25 2500 Watt Duvar Tipi Infrared Isıtıcı", 0m, false, true, false, "Kumtel Ecoray Ex-25 2500 Watt Duvar Tipi Infrared Isıtıcı", 886.05m, 748968, 4.3m, 5, null, null },
                    { 181, 48, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7532), "UFO Ufo Star 2400 W Duvar Tipi Isıtıcı - Termostatlı", 0m, false, true, false, "UFO Ufo Star 2400 W Duvar Tipi Isıtıcı", 4190m, 575675, 4.5m, 5, null, null },
                    { 182, 49, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7537), "Abbruch Şarj Edilebilir Taşınabilir Ipli Mini El Fanı Üç Kademe Hızlı Güçlü Soğutucu Pervane Vantilatör", 0m, false, true, false, "Abbruch Şarj Edilebilir Taşınabilir Mini El Fanı", 289.90m, 836374, 4.5m, 5, null, null },
                    { 183, 50, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7574), "Sinbo SF-6783 Vantilatör", 0m, false, true, false, "Sinbo SF-6783 Vantilatör", 1200m, 224648, 3.4m, 5, null, null },
                    { 184, 44, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7577), "Beko 31650 Vantilatör uzaktan kumandalı", 0m, false, true, false, "Beko 31650 Vantilatör", 3259m, 525874, 4.6m, 5, null, null },
                    { 185, 48, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7581), "UFO Ufo Micatronic 1900 W Kule Tipi Isıtıcı", 0m, false, true, false, "UFO Ufo Micatronic 1900 W Kule Tipi Isıtıcı", 4390m, 203142, 4.4m, 5, null, null },
                    { 186, 48, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7584), "UFO Omri 1200 W Termostatlı Hem Yatay Hem Dikey Isıtıcı", 0m, false, true, false, "UFO Omri 1200 W Termostatlı Isıtıcı", 3400m, 993412, 3.9m, 5, null, null },
                    { 187, 38, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7586), "Kaira DTXR71E A++ 24000 BTU Inverter Duvar Tipi Klima (Montaj Dahil)", 0m, false, true, false, "Kaira DTXR71E A++ 24000 BTU Inverter Duvar Tipi Klima", 45250.40m, 509001, 4m, 5, null, null },
                    { 188, 46, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7589), "Baymak Duo Tec Compact Premix 24 kw Yoğuşmalı Kombi (Baca Dahil)", 0m, false, true, false, "Baymak Duo Tec Compact Premix 24 kw Yoğuşmalı Kombi", 27400m, 437754, 4.6m, 5, null, null },
                    { 189, 48, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7594), "UFO ISITICI STAR S/19 1900 W", 0m, false, true, false, "UFO ISITICI STAR S/19 1900 W", 3690m, 204154, 4.4m, 5, null, null },
                    { 190, 51, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7597), "Magiceham Lilo Stitch Peluş Sıcak Su Isıtıcısı - Lacivert (Yurt Dışından)", 0m, false, true, false, "Magiceham Lilo Stitch Peluş Sıcak Su Isıtıcısı", 528.45m, 638598, 4.6m, 5, null, null },
                    { 191, 64, 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7600), "Xnews A Üstü USB Fan Soğutucu Vantilatör Klima USB Girişli Metal Serinlci Fan Mini Vantilatör Fan Klima Fan", 0m, false, true, false, "Xnews A Üstü USB Fan Soğutucu", 269.90m, 451923, 5m, 5, null, null },
                    { 192, 65, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7602), "Lacoste Sport Court-Master Pro Erkek Siyah Sneaker 744SMA0084 02H", 0m, false, true, false, "Lacoste Sport Court-Master Pro Erkek Siyah Sneaker 744SMA0084 02H", 3239.10m, 386031, 4.9m, 6, null, null },
                    { 193, 66, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7606), "Letoon 2104 Günlük Unisex Spor Ayakkabı", 0m, false, true, false, "Letoon 2104 Günlük Unisex Spor Ayakkabı", 564m, 826640, 4.2m, 6, null, null },
                    { 194, 67, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7608), "Derilax Hakiki Deri Tam Ortopedik Erkek Ayakkabı", 0m, false, true, false, "Derilax Hakiki Deri Tam Ortopedik Erkek Ayakkabı", 1200m, 854010, 4.6m, 6, null, null },
                    { 195, 68, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7611), "Hotiç Hakiki Deri Siyah Erkek Günlük Ayakkabı", 0m, false, true, false, "Hotiç Hakiki Deri Siyah Erkek Günlük Ayakkabı", 1679.40m, 582212, 4.1m, 6, null, null },
                    { 196, 69, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7613), "Ispartalılar 7575 Ortopedik Taban Yumuşak Hakiki Deri Mevsimlik Kışlık Erkek Ayakkabı", 0m, false, true, false, "Ispartalılar 7575 Ortopedik Taban Yumuşak Hakiki Deri Mevsimlik Kışlık Erkek Ayakkabı", 670.65m, 995556, 4m, 6, null, null },
                    { 197, 70, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7616), "Under Armour Çocuk Ua Bgs Charged Rogue 4 Koşu Ayakkabısı 3027106-400", 0m, false, true, false, "Under Armour Çocuk Ua Bgs Charged Rogue 4 Koşu Ayakkabısı 3027106-400", 2090m, 938499, 5m, 6, null, null },
                    { 198, 69, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7619), "Ispartalılar 502 Ortopedik Topuk Masajlı Hakiki Deri Kışlık Erkek Ayakkabı Bağcıklı", 0m, false, true, false, "Ispartalılar 502 Ortopedik Topuk Masajlı Hakiki Deri Kışlık Erkek Ayakkabı Bağcıklı", 679.15m, 903274, 4m, 6, null, null },
                    { 199, 71, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7622), "Muggo Samuel Garantili Günlük Klasik Deri Casual Rahat Ortopedik Kalın Taban Erkek Ayakkabı", 0m, false, true, false, "Muggo Samuel Garantili Günlük Klasik Deri Casual Rahat Ortopedik Kalın Taban Erkek Ayakkabı", 899.90m, 513705, 4.5m, 6, null, null },
                    { 200, 72, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7625), "Tomiross Erkek Atlanta Günlük Kullanım Sneaker Ayakkabı ATLNT-5025", 0m, false, true, false, "Tomiross Erkek Atlanta Günlük Kullanım Sneaker Ayakkabı ATLNT-5025", 699.90m, 372662, 4.5m, 6, null, null },
                    { 201, 73, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7631), "Yaya By Hotic 02ayy296160a100 Siyah Erkek Ayakkabı", 0m, false, true, false, "Yaya By Hotic 02ayy296160a100 Siyah Erkek Ayakkabı", 899.90m, 914951, 4.5m, 6, null, null },
                    { 202, 74, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7634), "Hotic Hakiki Deri Lacivert Erkek Günlük Ayakkabı", 0m, false, true, false, "Hotic Hakiki Deri Lacivert Erkek Günlük Ayakkabı", 799.90m, 316972, 4.5m, 6, null, null },
                    { 203, 75, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7637), "Derilax Deri Tam Ortopedik Erkek Ayakkabı", 0m, false, true, false, "Derilax Deri Tam Ortopedik Erkek Ayakkabı", 699.90m, 720862, 4.5m, 6, null, null },
                    { 204, 76, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7639), "Ispartalılar 909 Tam Ortopedik Taban Hakiki Deri Erkek Ayakkabı", 0m, false, true, false, "Ispartalılar 909 Tam Ortopedik Taban Hakiki Deri Erkek Ayakkabı", 599.90m, 131704, 4.5m, 6, null, null },
                    { 205, 77, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7642), "Selin Soylu Hakiki Deri Erkek Ayakkabı Kışlık Günlük Ayakkabı", 0m, false, true, false, "Selin Soylu Hakiki Deri Erkek Ayakkabı Kışlık Günlük Ayakkabı", 499.90m, 567226, 4.5m, 6, null, null },
                    { 206, 78, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7644), "Sebago Nubuk Koyu Kahve Siyah Erkek Günlük Ayakkabı 7111m5w", 0m, false, true, false, "Sebago Nubuk Koyu Kahve Siyah Erkek Günlük Ayakkabı 7111m5w", 399.90m, 170885, 4.5m, 6, null, null },
                    { 207, 79, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7647), "Lumberjack 4m Navigator 4fx", 0m, false, true, false, "Lumberjack 4m Navigator 4fx", 299.90m, 479232, 4.5m, 6, null, null },
                    { 208, 78, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7650), "Sebago Deri Lacivert Erkek Günlük Ayakkabı 70004z0", 0m, false, true, false, "Sebago Deri Lacivert Erkek Günlük Ayakkabı 70004z0", 199.90m, 530595, 4.5m, 6, null, null },
                    { 209, 80, 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(7847), "Dakirs Yazlık Erkek Keten Günlük Rahat Hafif Bağcıklı Spor Ayakkabı 40-44", 0m, false, true, false, "Dakirs Yazlık Erkek Keten Günlük Rahat Hafif Bağcıklı Spor Ayakkabı 40-44", 99.90m, 693345, 4.5m, 6, null, null }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "EntityId", "EntityType", "IsDeleted", "Path", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8147), 1, 1, false, "img/Products/Laptops/Casper_G870.1270.jpg", null, null },
                    { 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8150), 2, 1, false, "img/Products/Laptops/MSI_15.6.jpg", null, null },
                    { 3, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8151), 3, 1, false, "img/Products/Laptops/Casper_S100.1362.jpg", null, null },
                    { 4, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8153), 4, 1, false, "img/Products/Laptops/Casper_G870.1362.jpg", null, null },
                    { 5, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8154), 5, 1, false, "img/Products/Laptops/HP_15.6.jpg", null, null },
                    { 6, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8156), 6, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 7, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8157), 7, 1, false, "img/Products/Laptops/Lenovo_model.jpg", null, null },
                    { 8, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8159), 8, 1, false, "img/Products/Laptops/MSI_model.jpg", null, null },
                    { 9, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8160), 9, 1, false, "img/Products/Laptops/Casper_C550.1255.jpg", null, null },
                    { 10, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8162), 10, 1, false, "img/Products/Laptops/Lenovo_3.2.jpg", null, null },
                    { 11, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8163), 11, 1, false, "img/Products/Laptops/Casper_G770.1245.jpg", null, null },
                    { 12, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8164), 12, 1, false, "img/Products/Laptops/Casper_X600.7430.jpg", null, null },
                    { 13, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8165), 13, 1, false, "img/Products/Laptops/Acer_15.6.jpg", null, null },
                    { 14, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8167), 14, 1, false, "img/Products/Laptops/Casper_X600.1270.jpg", null, null },
                    { 15, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8168), 15, 1, false, "img/Products/Laptops/Casper_G870.1342.jpg", null, null },
                    { 16, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8169), 16, 1, false, "img/Products/Laptops/Casper_G870.1270.jpg", null, null },
                    { 17, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8170), 17, 1, false, "img/Products/Laptops/HP_15.6.jpg", null, null },
                    { 18, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8174), 18, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 19, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8176), 19, 1, false, "img/Products/Laptops/Asus_15.6.jpg", null, null },
                    { 20, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8177), 20, 1, false, "img/Products/Laptops/Apple_model.jpg", null, null },
                    { 21, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8178), 21, 1, false, "img/Products/Laptops/Casper_G870.1342.jpg", null, null },
                    { 22, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8179), 22, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 23, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8180), 23, 1, false, "img/Products/Laptops/Asus_model.jpg", null, null },
                    { 24, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8181), 24, 1, false, "img/Products/Laptops/Casper_X600.1342.jpg", null, null },
                    { 25, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8183), 25, 1, false, "img/Products/Laptops/Lenovo_3.2.jpg", null, null },
                    { 26, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8184), 26, 1, false, "img/Products/Laptops/Casper_X600.1362.jpg", null, null },
                    { 27, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8185), 27, 1, false, "img/Products/Laptops/MSI_15.6.jpg", null, null },
                    { 28, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8186), 28, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 29, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8187), 29, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 30, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8189), 30, 1, false, "img/Products/Laptops/Apple_model.jpg", null, null },
                    { 31, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8190), 31, 1, false, "img/Products/Laptops/Casper_G870.1245.jpg", null, null },
                    { 32, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8191), 32, 1, false, "img/Products/PrintersandScanner/hp_hp_deskjet_ink_advantage_2878_allinone_yazc.jpg", null, null },
                    { 33, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8192), 33, 1, false, "img/Products/PrintersandScanner/canon_dolan_kartulu_e414_yazc_tarayc_fotokopi.jpg", null, null },
                    { 34, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8194), 34, 1, false, "img/Products/PrintersandScanner/canon_pixma_tr4650_tarayc_fotokopi_wifi_faks_ok_fonksiyonlu_yazc_canon_eurasia_garantili.jpg", null, null },
                    { 35, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8196), 35, 1, false, "img/Products/PrintersandScanner/canon_pixma_e3640_wifi_tarayc_fotokopi_ok_fonksiyonlu_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 36, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8197), 36, 1, false, "img/Products/PrintersandScanner/epson_l5290_wifi_renk_tankl_yazc.jpg", null, null },
                    { 37, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8198), 37, 1, false, "img/Products/PrintersandScanner/epson_tankl_l3150_photoink_muadil_mrekkepli_tankl_yazc_1_siyah_mrekkep_ve_fotoraf_kad_hediyeli.jpg", null, null },
                    { 38, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8200), 38, 1, false, "img/Products/PrintersandScanner/hp_officejet_pro_7720_fotokopi_faks_tarayc_wifi_airprint_a3_yazc_y0s18a.jpg", null, null },
                    { 39, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8201), 39, 1, false, "img/Products/PrintersandScanner/canon_e3640_wifi_yazc_ve_tpal_kartu_sistemi.jpg", null, null },
                    { 40, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8202), 40, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_l3250_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 41, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8203), 41, 1, false, "img/Products/PrintersandScanner/enp_canon_mf264dw_lazer_yazc_tarayc_fotokopi_wifi_lan_duplex.jpg", null, null },
                    { 42, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8232), 42, 1, false, "img/Products/PrintersandScanner/canon_pxma_g3430_renkli_mrekkep_mega_tankl_yazc_tarayc_fotokopi_wifi_1_ie_orijinal_siyah_mrekkep_hed.jpg", null, null },
                    { 43, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8233), 43, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_l3250_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 44, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8234), 44, 1, false, "img/Products/PrintersandScanner/canon_isensys_mf453dw_wf_ok_fonksiyonlu_lazer_yazc.jpg", null, null },
                    { 45, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8236), 45, 1, false, "img/Products/PrintersandScanner/canon_pixma_e3440_dolabilen_kartu_sistemli_yazc.jpg", null, null },
                    { 46, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8237), 46, 1, false, "img/Products/PrintersandScanner/epson_l6550_color_tankl_wifi_a4_yazc_fotokopi_tarayc_fax.jpg", null, null },
                    { 47, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8238), 47, 1, false, "img/Products/PrintersandScanner/hp_deskjet_2632_wifi_tarayc_fotokopi_renkli_ok_fonksiyonlu_mrekkep_pskrtmeli_yazc_v1n05b.jpg", null, null },
                    { 48, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8240), 48, 1, false, "img/Products/PrintersandScanner/canon_pixma_e514_fotokopi_tarayc_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 49, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8241), 49, 1, false, "img/Products/PrintersandScanner/epson_epson_ecotank_l11050_a3_tek_fonk_yazici.jpg", null, null },
                    { 50, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8242), 50, 1, false, "img/Products/PrintersandScanner/hp_hp_6uu47a_smart_tank_750_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 51, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8243), 51, 1, false, "img/Products/PrintersandScanner/canon_gx6040_yazctaraycfotokopi_renkli_mrekkep_tankl_yazc_wifi_ethernet.jpg", null, null },
                    { 52, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8246), 52, 1, false, "img/Products/PrintersandScanner/epson_surecolor_sc_f100_mrekkep_pskrtme_sblimasyon_yazc.jpg", null, null },
                    { 53, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8247), 53, 1, false, "img/Products/PrintersandScanner/hp_deskjet_1516_fotokopi_tarayc_yazc_b2l60c.jpg", null, null },
                    { 54, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8248), 54, 1, false, "img/Products/PrintersandScanner/canon_ix6850_renkli_inkjet_a3_fotoraf_yazcswifi_canon_eurasia_garantili.jpg", null, null },
                    { 55, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8249), 55, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 56, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8251), 56, 1, false, "img/Products/PrintersandScanner/hp_officejet_j4500_wifi_faxl_ok_fonksiyonlu_renkli_yazc_cn547a.jpg", null, null },
                    { 57, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8252), 57, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 58, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8253), 58, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_m1170_yazc_a4.jpg", null, null },
                    { 59, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8254), 59, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_wifi_ok_fonksiyonlu_yazc_bitmeyen_kartu_siyah_depo.jpg", null, null },
                    { 60, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8256), 60, 1, false, "img/Products/PrintersandScanner/canon_pixma_mg3050bk_wifi_fotokopi_tarayc_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 61, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8257), 61, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 62, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8258), 62, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 63, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8259), 63, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 64, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8260), 64, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 65, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8262), 65, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 66, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8263), 66, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 67, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8265), 67, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 68, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8266), 68, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 69, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8268), 69, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 70, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8269), 70, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 71, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8270), 71, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 72, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8272), 72, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 73, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8273), 73, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 74, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8274), 74, 1, false, "img/Products/Phones/apple_iphone_13_128_gb_beyaz.jpg", null, null },
                    { 75, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8275), 75, 1, false, "img/Products/Phones/samsung_galaxy_a06_128_gb_4_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 76, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8277), 76, 1, false, "img/Products/Phones/apple_iphone_13_128_gb_siyah.jpg", null, null },
                    { 77, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8278), 77, 1, false, "img/Products/Phones/samsung_galaxy_a16_128_gb_6_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 78, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8279), 78, 1, false, "img/Products/Phones/samsung_galaxy_a35_256_gb_8_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 79, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8280), 79, 1, false, "img/Products/Phones/honor_magic_7_lite_256_gb_8_gb_ram_honor_trkiye_garantili_mor.jpg", null, null },
                    { 80, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8281), 80, 1, false, "img/Products/Phones/samsung_galaxy_a06_128_gb_4_gb_ram_samsung_trkiye_garantili_ak_mavi.jpg", null, null },
                    { 81, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8283), 81, 1, false, "img/Products/Phones/samsung_galaxy_s24_256_gb_12_gb_ram_samsung_trkiye_garantili_gri.jpg", null, null },
                    { 82, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8284), 82, 1, false, "img/Products/Phones/samsung_galaxy_a16_128_gb_6_gb_ram_samsung_trkiye_garantili_gri.jpg", null, null },
                    { 83, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8285), 83, 1, false, "img/Products/Phones/honor_magic_7_lite_256_gb_8_gb_ram_honor_trkiye_garantili_siyah.jpg", null, null },
                    { 84, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8286), 84, 1, false, "img/Products/Phones/samsung_galaxy_s24_fe_128_gb_8_gb_ram_samsung_trkiye_garantili_gri.jpg", null, null },
                    { 85, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8288), 85, 1, false, "img/Products/Phones/nothing_phone_1_256_gb_8_gb_ram_nothing_trkiye_garantili_siyah.jpg", null, null },
                    { 86, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8290), 86, 1, false, "img/Products/Phones/nothing_phone_2a_256_gb_12_gb_ram_nothing_trkiye_garantili_beyaz.jpg", null, null },
                    { 87, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8291), 87, 1, false, "img/Products/Phones/samsung_galaxy_a35_128_gb_8_gb_ram_samsung_trkiye_garantili_ak_mavi.jpg", null, null },
                    { 88, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8292), 88, 1, false, "img/Products/Phones/infinix_infnx_smart_9_128_gb_4_gb_ram_infnx_trkiye_garantili_nane_yeili.jpg", null, null },
                    { 89, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8293), 89, 1, false, "img/Products/Phones/samsung_galaxy_a55_128_gb_8_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 90, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8296), 90, 1, false, "img/Products/Phones/nothing_phone_2a_plus_256_gb_12_gb_ram_nothing_trkiye_garantili_gri.jpg", null, null },
                    { 91, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8297), 91, 1, false, "img/Products/Phones/samsung_galaxy_s24_fe_256_gb_8_gb_ram_samsung_trkiye_garantili_grafit.jpg", null, null },
                    { 92, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8298), 92, 1, false, "img/Products/Phones/apple_iphone_16e_128gb_beyaz.jpg", null, null },
                    { 93, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8299), 93, 1, false, "img/Products/Phones/samsung_galaxy_s24_fe_128_gb_8_gb_ram_samsung_trkiye_garantili_mavi.jpg", null, null },
                    { 94, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8301), 94, 1, false, "img/Products/Phones/samsung_galaxy_s25_256_gb_12_gb_ram_samsung_trkiye_garantili_lacivert.jpg", null, null },
                    { 95, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8302), 95, 1, false, "img/Products/Phones/samsung_b310_dual_sim_lacivert.jpg", null, null },
                    { 96, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8303), 96, 1, false, "img/Products/Phones/samsung_galaxy_s23_ultra_512_gb_12_gb_ram_samsung_trkiye_garantili_altn.jpg", null, null },
                    { 97, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8304), 97, 1, false, "img/Products/Phones/redmi_note_14_pro_12gb_512gb_xiaomi_trkiye_garantili.jpg", null, null },
                    { 98, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8306), 98, 1, false, "img/Products/Phones/samsung_b310_e_dual_sim_kamerasz_cep_telefonu_beyaz.jpg", null, null },
                    { 99, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8307), 99, 1, false, "img/Products/Phones/samsung_galaxy_a55_128_gb_8_gb_ram_samsung_trkiye_garantili_ak_mavi.jpg", null, null },
                    { 100, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8308), 100, 1, false, "img/Products/Phones/samsung_galaxy_a35_128_gb_8_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 101, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8309), 101, 1, false, "img/Products/Phones/redmi_note_14_pro_8gb_256gb_xiaomi_trkiye_garantili.jpg", null, null },
                    { 102, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8310), 102, 1, false, "img/Products/Phones/apple_iphone_15_256_gb_mavi.jpg", null, null },
                    { 103, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8313), 103, 1, false, "img/Products/Phones/apple_iphone_16_pro_256gb_beyaz.jpg", null, null },
                    { 104, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8314), 104, 1, false, "img/Products/Phones/xiaomi_14t_pro_12gb_512gb.jpg", null, null },
                    { 105, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8315), 105, 1, false, "img/Products/Phones/apple_iphone_16_pro_128gb_beyaz.jpg", null, null },
                    { 106, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8316), 106, 1, false, "img/Products/Phones/honor_200_512_gb_12_gb_ram_honor_trkiye_garantili_zmrt_yeili.jpg", null, null },
                    { 107, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8317), 107, 1, false, "img/Products/Phones/apple_iphone_16_pro_256gb_siyah.jpg", null, null },
                    { 108, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8319), 108, 1, false, "img/Products/Phones/xiaomi_redmi_note_13_pro_256gb_8gb_ram_xiaomi_trkiye_garantili_mor.jpg", null, null },
                    { 109, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8320), 109, 1, false, "img/Products/Phones/samsung_galaxy_s25_128_gb_12_gb_ram_samsung_trkiye_garantili_lacivert.jpg", null, null },
                    { 110, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8321), 110, 1, false, "img/Products/Phones/apple_iphone_16_256gb_lacivert_ta.jpg", null, null },
                    { 111, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8348), 111, 1, false, "img/Products/Phones/xiaomi_redmi_note_14_pro_plus_5g_512_gb_12_gb_ram_xiaomi_trkiye_garantili.jpg", null, null },
                    { 112, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8349), 112, 1, false, "img/Products/Phones/apple_iphone_16_pro_max_512gb_natrel_titanyum.jpg", null, null },
                    { 113, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8351), 113, 1, false, "img/Products/Phones/samsung_galaxy_a04s_64_gb_samsung_trkiye_garantili_siyah_64_gb_siyah.jpg", null, null },
                    { 114, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8352), 114, 1, false, "img/Products/Phones/redmi_note_14_pro_5g_12gb_512gb_xiaomi_trkiye_garantili.jpg", null, null },
                    { 115, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8353), 115, 1, false, "img/Products/Phones/nothing_phone_1_128_gb_8_gb_ram_nothing_trkiye_garantili_siyah.jpg", null, null },
                    { 116, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8355), 116, 1, false, "img/Products/Phones/xiaomi_redmi_note_13_pro_512gb_12gb_xiaomi_trkiye_garantili_siyah.jpg", null, null },
                    { 117, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8356), 117, 1, false, "img/Products/Phones/xiaomi_redmi_12_128_gb_8_gb_ram_xiaomi_trkiye_garantili_siyah.jpg", null, null },
                    { 118, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8357), 118, 1, false, "img/Products/Phones/honor_magic_v3_512_gb_12_gb_ram_honor_trkiye_garantili_yeil.jpg", null, null },
                    { 119, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8359), 119, 1, false, "img/Products/Phones/tecno_spark_30_256_gb_8_gb_ram.jpg", null, null },
                    { 120, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8361), 120, 1, false, "img/Products/Phones/samsung_galaxy_s25_ultra_1_tb_12_gb_ram_samsung_trkiye_garantili.jpg", null, null },
                    { 121, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8362), 121, 1, false, "img/Products/Phones/apple_iphone_16_pro_128gb_siyah.jpg", null, null },
                    { 122, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8363), 122, 1, false, "img/Products/Phones/reeder_p13_blue_max_l_2022_64_gb_reeder_trkiye_garantili_beyaz.jpg", null, null },
                    { 123, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8364), 123, 1, false, "img/Products/Phones/poco_poco_x7_12gb_512gb_xiaomi_trkiye_garantili.jpg", null, null },
                    { 124, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8366), 124, 1, false, "img/Products/Phones/oppo_a60_8gb_256gb_oppo_trkiye_garantili_mavi.jpg", null, null },
                    { 125, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8367), 125, 1, false, "img/Products/Phones/samsung_galaxy_a25_5g_256_gb_8_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 126, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8368), 126, 1, false, "img/Products/Phones/samsung_galaxy_s25_256_gb_lacivert.jpg", null, null },
                    { 127, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8369), 127, 1, false, "img/Products/Phones/panasonic_kx-tu550exb_katlanabilir_renkli_ekran_4g_tulu_cep_telefonu_siyah_2_yl_trkiye_distribtr_garantili_siyah.jpg", null, null },
                    { 128, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8370), 128, 1, false, "img/Products/Phones/reeder_s19_max_pro_256_gb_6_gb_ram_reeder_trkiye_garantili_siyah.jpg", null, null },
                    { 129, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8372), 129, 1, false, "img/Products/Phones/samsung_b310e_cep_telefonu_resmi_btk_kaytl2g_ve_3g_hatlar_n_beyaz.jpg", null, null },
                    { 130, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8374), 130, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 131, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8375), 131, 1, false, "img/Products/WhiteGoods/kumtel_kumtel_93l_beyaz_bro_tipi_buzdolab_hmb-110.jpg", null, null },
                    { 132, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8376), 132, 1, false, "img/Products/WhiteGoods/regal_bm_310_3_programl_bulak_makinesi.jpg", null, null },
                    { 133, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8377), 133, 1, false, "img/Products/WhiteGoods/arelik_ade_606_2b_yatk_davlumbaz_karbon_filtre_165732003.jpg", null, null },
                    { 134, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8378), 134, 1, false, "img/Products/WhiteGoods/altus_al_7103_md_1000_devir_7_kg_amar_makinesi.jpg", null, null },
                    { 135, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8380), 135, 1, false, "img/Products/WhiteGoods/altus_al_10123_d_c_enerji_10_kg_amar_makinesi.jpg", null, null },
                    { 136, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8384), 136, 1, false, "img/Products/WhiteGoods/hoover_ndeh_10a2tsbe-17_10_kg_wi-fi_bluetooth_balantl_is_pompal_kurutma_makinesi.jpg", null, null },
                    { 137, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8385), 137, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 138, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8386), 138, 1, false, "img/Products/WhiteGoods/samsung_ww11bga046aeah_11_kg_1400_devir_amar_makinesi.jpg", null, null },
                    { 139, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8387), 139, 1, false, "img/Products/WhiteGoods/vestel_sp_202-a_su_sebili.jpg", null, null },
                    { 140, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8389), 140, 1, false, "img/Products/WhiteGoods/regal_st_30010_242_lt_statik_buzdolab.jpg", null, null },
                    { 141, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8390), 141, 1, false, "img/Products/WhiteGoods/arelik_yeni_model_gri_buhar_destekli_cam_ankastre_set.jpg", null, null },
                    { 142, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8391), 142, 1, false, "img/Products/WhiteGoods/evora_sanayi_tipi_100_lt_soutmal_artmal_paslanmaz_endstriyel_su_sebili.jpg", null, null },
                    { 143, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8392), 143, 1, false, "img/Products/WhiteGoods/albergio_cam_damacana_kapakl_su_sebil_15_lt_tm_sebillere_uyumlu.jpg", null, null },
                    { 144, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8393), 144, 1, false, "img/Products/WhiteGoods/kiwi_kwp_8520_standl_su_pompas-beyaz.jpg", null, null },
                    { 145, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8395), 145, 1, false, "img/Products/WhiteGoods/vestel_sp_202-a_su_sebili.jpg", null, null },
                    { 146, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8396), 146, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 147, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8397), 147, 1, false, "img/Products/WhiteGoods/samsung_ww11bb534dabah_11_kg_1400_devir_bespoke_amar_makinesi_spacemax_ai_kontrol_paneli.jpg", null, null },
                    { 148, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8398), 148, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 149, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8399), 149, 1, false, "img/Products/WhiteGoods/kumtel_kumtel_93l_beyaz_bro_tipi_buzdolab_hmb-110.jpg", null, null },
                    { 150, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8401), 150, 1, false, "img/Products/WhiteGoods/vestel_sp_202-a_su_sebili.jpg", null, null },
                    { 151, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8402), 151, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 152, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8403), 152, 1, false, "img/Products/WhiteGoods/samsung_ww11bb534dabah_11_kg_1400_devir_bespoke_amar_makinesi_spacemax_ai_kontrol_paneli.jpg", null, null },
                    { 153, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8405), 153, 1, false, "img/Products/WhiteGoods/regal_bm_310_3_programl_bulak_makinesi.jpg", null, null },
                    { 154, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8407), 154, 1, false, "img/Products/WhiteGoods/vestel_sp_202-a_su_sebili.jpg", null, null },
                    { 155, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8408), 155, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 156, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8409), 156, 1, false, "img/Products/WhiteGoods/altus_al_7103_md_1000_devir_7_kg_amar_makinesi.jpg", null, null },
                    { 157, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8410), 157, 1, false, "img/Products/WhiteGoods/altus_al_7103_md_1000_devir_7_kg_amar_makinesi.jpg", null, null },
                    { 158, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8411), 158, 1, false, "img/Products/WhiteGoods/altus_al_7103_md_1000_devir_7_kg_amar_makinesi.jpg", null, null },
                    { 159, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8412), 159, 1, false, "img/Products/AirConditionerandHeater/airfel_ltxm35n_12000_btu_r32_inverter_duvar_tipi_klima.jpg", null, null },
                    { 160, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8414), 160, 1, false, "img/Products/AirConditionerandHeater/regal_luna_a_15000_btu_inverte_duvar_tipi_klima.jpg", null, null },
                    { 161, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8415), 161, 1, false, "img/Products/AirConditionerandHeater/kumtel_bej_fanl_istc_2000_w_lx_-_6331.jpg", null, null },
                    { 162, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8416), 162, 1, false, "img/Products/AirConditionerandHeater/bosch_climate_cl2000u_w_35_e_a_12000_btu_duvar_tipi_klima.jpg", null, null },
                    { 163, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8417), 163, 1, false, "img/Products/AirConditionerandHeater/kaira_dtxr35e_a_12000_btu_wifi_inverter_duvar_tipi_klima_montaj_dahil.jpg", null, null },
                    { 164, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8418), 164, 1, false, "img/Products/AirConditionerandHeater/kumtel_juniper_portatif_tanabilir_klima_kmpac-7.jpg", null, null },
                    { 165, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8420), 165, 1, false, "img/Products/AirConditionerandHeater/vestel_flora_doa_124_a_wifi_12000_btu_inverter_duvar_tipi_klima.jpg", null, null },
                    { 166, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8421), 166, 1, false, "img/Products/AirConditionerandHeater/xiaomi_zmydfs01dm_arj_edilebilir_mini_fan.jpg", null, null },
                    { 167, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8422), 167, 1, false, "img/Products/AirConditionerandHeater/kumtel_lx-2832_siyah_1500_watt_istc.jpg", null, null },
                    { 168, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8423), 168, 1, false, "img/Products/AirConditionerandHeater/mirkraft_future_2500_watt_elektrikli_istc_-_ip24_-_lcd_ekran_-_uzaktan_kumandal_-_4_is_ayar.jpg", null, null },
                    { 169, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8455), 169, 1, false, "img/Products/AirConditionerandHeater/samsung_premium_ar18tshzhwk_a_18000_btu_inverter_duvar_tipi_klima.jpg", null, null },
                    { 170, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8458), 170, 1, false, "img/Products/AirConditionerandHeater/arnell_elektrikli_istc_quartz_ev_ve_ofis_oda_tipi_31_ubuklu_gvenli_elektrikli_soba_-_2600_watt.jpg", null, null },
                    { 171, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8459), 171, 1, false, "img/Products/AirConditionerandHeater/kumtel_ks-2760_quartz_istc_siyah.jpg", null, null },
                    { 172, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8461), 172, 1, false, "img/Products/AirConditionerandHeater/zeeful_sper_g_fleyici_mini_turbo_jet_fan_130000rpm_52ms_4000mah_yurt_dndan.jpg", null, null },
                    { 173, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8462), 173, 1, false, "img/Products/AirConditionerandHeater/beko_31225_ekolojik_a_12000_btu_duvar_tipi_klima.jpg", null, null },
                    { 174, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8463), 174, 1, false, "img/Products/AirConditionerandHeater/vestel_flora_doa_244_a_24000_btu_wifi_inverter_duvar_tipi_klima.jpg", null, null },
                    { 175, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8464), 175, 1, false, "img/Products/AirConditionerandHeater/arelik_ekolojik_18325_a_18000_btu_inverter_duvar_tipi_klima.jpg", null, null },
                    { 176, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8466), 176, 1, false, "img/Products/AirConditionerandHeater/arnell_elektrikli_istc_duvar_tip_soba_3000_watt.jpg", null, null },
                    { 177, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8467), 177, 1, false, "img/Products/AirConditionerandHeater/baymak_elegant_plus_uv_18_a_montaj_dahil_18000_btu_duvar_tipi_klima.jpg", null, null },
                    { 178, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8468), 178, 1, false, "img/Products/AirConditionerandHeater/fujiplus_fujiplus_sakura_12000_btu_inverter_duvar_tipi_klima.jpg", null, null },
                    { 179, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8469), 179, 1, false, "img/Products/AirConditionerandHeater/baymak_aqua_konfor_65_litre_termosifon.jpg", null, null },
                    { 180, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8470), 180, 1, false, "img/Products/AirConditionerandHeater/kumtel_ecoray_ex-25_2500_watt_duvar_tipi_infrared_istc.jpg", null, null },
                    { 181, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8471), 181, 1, false, "img/Products/AirConditionerandHeater/ufo_ufo_star_2400_w_duvar_tipi_istc_-_termostatl.jpg", null, null },
                    { 182, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8473), 182, 1, false, "img/Products/AirConditionerandHeater/abbruch_arj_edilebilir_tanabilir_ipli_mini_el_fan_kademe_hzl_gl_soutucu_pervane_vantilatr.jpg", null, null },
                    { 183, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8475), 183, 1, false, "img/Products/AirConditionerandHeater/sinbo_sf-6783_vantilatr.jpg", null, null },
                    { 184, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8476), 184, 1, false, "img/Products/AirConditionerandHeater/beko_31650_vantilatr_uzaktan_kumandal.jpg", null, null },
                    { 185, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8477), 185, 1, false, "img/Products/AirConditionerandHeater/ufo_ufo_micatronic_1900_w_kule_tipi_istc.jpg", null, null },
                    { 186, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8479), 186, 1, false, "img/Products/AirConditionerandHeater/ufo_omri_1200_w_termostatl_hem_yatay_hem_dikey_istc.jpg", null, null },
                    { 187, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8480), 187, 1, false, "img/Products/AirConditionerandHeater/kaira_dtxr71e_a_24000_btu_inverter_duvar_tipi_klima_montaj_dahil.jpg", null, null },
                    { 188, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8481), 188, 1, false, "img/Products/AirConditionerandHeater/baymak_duo_tec_compact_premix_24_kw_youmal_kombi_baca_dahil.jpg", null, null },
                    { 189, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8482), 189, 1, false, "img/Products/AirConditionerandHeater/ufo_isitici_star_s19_1900_w.jpg", null, null },
                    { 190, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8483), 190, 1, false, "img/Products/AirConditionerandHeater/magiceham_lilo_stitch_pelu_scak_su_istcs_-_lacivert_yurt_dndan.jpg", null, null },
                    { 191, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8484), 191, 1, false, "img/Products/AirConditionerandHeater/airfel_maestro_optimum_2024_kw_17000_kcal_tam_youmal_kombi.jpg", null, null },
                    { 192, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8486), 192, 1, false, "img/Products/ShoesandBag/lacoste_sport_court-master_pro_erkek_siyah_sneaker_744sma0084_02h.jpg", null, null },
                    { 193, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8487), 193, 1, false, "img/Products/ShoesandBag/letoon_2104_gnlk_unisex_spor_ayakkab.jpg", null, null },
                    { 194, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8488), 194, 1, false, "img/Products/ShoesandBag/derilax_hakiki_deri_tam_ortopedik_erkek_ayakkab.jpg", null, null },
                    { 195, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8489), 195, 1, false, "img/Products/ShoesandBag/hoti_hakiki_deri_siyah_erkek_gnlk_ayakkab.jpg", null, null },
                    { 196, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8490), 196, 1, false, "img/Products/ShoesandBag/ispartallar_7575_ortopedik_taban_yumuak_hakiki_deri_mevsimlik_klk_erkek_ayakkab.jpg", null, null },
                    { 197, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8492), 197, 1, false, "img/Products/ShoesandBag/under_armour_ocuk_ua_bgs_charged_rogue_4_kou_ayakkabs_3027106-400.jpg", null, null },
                    { 198, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8493), 198, 1, false, "img/Products/ShoesandBag/ispartallar_502_ortopedik_topuk_masajl_hakiki_deri_klk_erkek_ayakkab_backl.jpg", null, null },
                    { 199, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8494), 199, 1, false, "img/Products/ShoesandBag/muggo_samuel_garantili_gnlk_klasik_deri_casual_rahat_ortopedik_kaln_taban_erkek_ayakkab.jpg", null, null },
                    { 200, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8495), 200, 1, false, "img/Products/ShoesandBag/tomiross_erkek_atlanta_gnlk_kullanm_sneaker_ayakkab_atlnt-5025.jpg", null, null },
                    { 201, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8496), 201, 1, false, "img/Products/ShoesandBag/yaya_by_hoti_02ayy296160a100_siyah_erkek_ayakkab.jpg", null, null },
                    { 202, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8498), 202, 1, false, "img/Products/ShoesandBag/hoti_hakiki_deri_lacivert_erkek_gnlk_ayakkab.jpg", null, null },
                    { 203, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8499), 203, 1, false, "img/Products/ShoesandBag/derilax_deri_tam_ortopedik_erkek_ayakkab.jpg", null, null },
                    { 204, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8500), 204, 1, false, "img/Products/ShoesandBag/ispartallar_909_tam_ortopedik_taban_hakiki_deri_erkek_ayakkab_kadn_ayakkab_kaymaz_taban_unisex_ayakkab_lastikli_back.jpg", null, null },
                    { 205, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8501), 205, 1, false, "img/Products/ShoesandBag/selin_soylu_seln_soylu_hakiki_deri_erkek_ayakkab_klk_gnlk_ayakkab.jpg", null, null },
                    { 206, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8503), 206, 1, false, "img/Products/ShoesandBag/sebago_nubuk_koyu_kahve_-_siyah_erkek_gnlk_ayakkab_7111m5w.jpg", null, null },
                    { 207, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8504), 207, 1, false, "img/Products/ShoesandBag/lumberjack_4m_navgator_4fx.jpg", null, null },
                    { 208, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8505), 208, 1, false, "img/Products/ShoesandBag/sebago_deri_lacivert_erkek_gnlk_ayakkab_70004z0.jpg", null, null },
                    { 209, null, new DateTime(2025, 9, 21, 22, 36, 37, 357, DateTimeKind.Local).AddTicks(8506), 209, 1, false, "img/Products/ShoesandBag/dakrs_yazlk_erkek_keten_gnlk_rahat_hafif_backl_spor_ayakkab_40-44.jpg", null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductProperties",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "ProductId", "PropertyTypeId", "PropertyValueId", "Stock", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(3447), true, false, 1, 1, 1, 50, null, null },
                    { 2, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(3450), true, false, 1, 1, 2, 50, null, null },
                    { 3, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(3451), true, false, 1, 1, 3, 50, null, null },
                    { 4, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(3452), true, false, 1, 1, 4, 50, null, null },
                    { 5, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(3455), true, false, 1, 4, 15, 50, null, null },
                    { 6, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(3458), true, false, 1, 5, 24, 50, null, null },
                    { 7, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(3461), true, false, 1, 6, 28, 50, null, null },
                    { 8, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(3463), true, false, 1, 7, 30, 50, null, null },
                    { 9, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(4195), true, false, 2, 1, 1, 50, null, null },
                    { 10, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(4196), true, false, 2, 1, 2, 50, null, null },
                    { 11, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(4197), true, false, 2, 1, 3, 50, null, null },
                    { 12, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(4197), true, false, 2, 1, 4, 50, null, null },
                    { 13, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(4199), true, false, 2, 4, 16, 50, null, null },
                    { 14, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(4201), true, false, 2, 5, 23, 50, null, null },
                    { 15, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(4202), true, false, 2, 6, 27, 50, null, null },
                    { 16, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(4228), true, false, 2, 7, 29, 50, null, null },
                    { 17, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(4844), true, false, 3, 1, 1, 50, null, null },
                    { 18, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(4845), true, false, 3, 1, 2, 50, null, null },
                    { 19, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(4846), true, false, 3, 1, 3, 50, null, null },
                    { 20, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(4847), true, false, 3, 1, 4, 50, null, null },
                    { 21, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(4873), true, false, 3, 4, 17, 50, null, null },
                    { 22, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(4874), true, false, 3, 5, 24, 50, null, null },
                    { 23, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(4875), true, false, 3, 6, 28, 50, null, null },
                    { 24, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(4876), true, false, 3, 7, 31, 50, null, null },
                    { 25, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(5454), true, false, 4, 1, 1, 50, null, null },
                    { 26, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(5455), true, false, 4, 1, 2, 50, null, null },
                    { 27, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(5455), true, false, 4, 1, 3, 50, null, null },
                    { 28, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(5483), true, false, 4, 1, 4, 50, null, null },
                    { 29, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(5484), true, false, 4, 4, 17, 50, null, null },
                    { 30, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(5485), true, false, 4, 5, 24, 50, null, null },
                    { 31, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(5486), true, false, 4, 6, 28, 50, null, null },
                    { 32, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(5487), true, false, 4, 7, 30, 50, null, null },
                    { 33, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(6164), true, false, 5, 1, 1, 50, null, null },
                    { 34, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(6165), true, false, 5, 1, 2, 50, null, null },
                    { 35, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(6166), true, false, 5, 1, 3, 50, null, null },
                    { 36, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(6166), true, false, 5, 1, 4, 50, null, null },
                    { 37, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(6168), true, false, 5, 4, 18, 50, null, null },
                    { 38, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(6169), true, false, 5, 5, 23, 50, null, null },
                    { 39, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(6170), true, false, 5, 6, 27, 50, null, null },
                    { 40, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(6171), true, false, 5, 7, 30, 50, null, null },
                    { 41, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(6764), true, false, 6, 1, 1, 50, null, null },
                    { 42, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(6765), true, false, 6, 1, 2, 50, null, null },
                    { 43, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(6765), true, false, 6, 1, 3, 50, null, null },
                    { 44, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(6766), true, false, 6, 1, 4, 50, null, null },
                    { 45, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(6767), true, false, 6, 4, 19, 50, null, null },
                    { 46, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(6768), true, false, 6, 5, 23, 50, null, null },
                    { 47, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(6769), true, false, 6, 6, 27, 50, null, null },
                    { 48, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(6770), true, false, 6, 7, 31, 50, null, null },
                    { 49, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(7346), true, false, 7, 1, 1, 50, null, null },
                    { 50, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(7346), true, false, 7, 1, 2, 50, null, null },
                    { 51, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(7347), true, false, 7, 1, 3, 50, null, null },
                    { 52, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(7347), true, false, 7, 1, 4, 50, null, null },
                    { 53, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(7349), true, false, 7, 4, 20, 50, null, null },
                    { 54, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(7350), true, false, 7, 5, 23, 50, null, null },
                    { 55, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(7351), true, false, 7, 6, 27, 50, null, null },
                    { 56, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(7352), true, false, 7, 7, 30, 50, null, null },
                    { 57, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(8177), true, false, 8, 1, 1, 50, null, null },
                    { 58, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(8178), true, false, 8, 1, 2, 50, null, null },
                    { 59, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(8178), true, false, 8, 1, 3, 50, null, null },
                    { 60, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(8179), true, false, 8, 1, 4, 50, null, null },
                    { 61, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(8181), true, false, 8, 4, 21, 50, null, null },
                    { 62, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(8183), true, false, 8, 5, 22, 50, null, null },
                    { 63, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(8185), true, false, 8, 6, 27, 50, null, null },
                    { 64, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(8188), true, false, 8, 7, 30, 50, null, null },
                    { 65, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(9025), true, false, 9, 1, 1, 50, null, null },
                    { 66, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(9026), true, false, 9, 1, 2, 50, null, null },
                    { 67, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(9026), true, false, 9, 1, 3, 50, null, null },
                    { 68, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(9027), true, false, 9, 1, 4, 50, null, null },
                    { 69, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(9028), true, false, 9, 4, 16, 50, null, null },
                    { 70, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(9029), true, false, 9, 5, 23, 50, null, null },
                    { 71, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(9030), true, false, 9, 6, 26, 50, null, null },
                    { 72, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(9032), true, false, 9, 7, 30, 50, null, null },
                    { 73, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(9671), true, false, 10, 1, 1, 50, null, null },
                    { 74, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(9672), true, false, 10, 1, 2, 50, null, null },
                    { 75, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(9672), true, false, 10, 1, 3, 50, null, null },
                    { 76, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(9673), true, false, 10, 1, 4, 50, null, null },
                    { 77, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(9674), true, false, 10, 4, 32, 50, null, null },
                    { 78, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(9675), true, false, 10, 5, 24, 50, null, null },
                    { 79, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(9676), true, false, 10, 6, 28, 50, null, null },
                    { 80, null, new DateTime(2025, 9, 21, 22, 36, 37, 358, DateTimeKind.Local).AddTicks(9677), true, false, 10, 7, 30, 50, null, null },
                    { 81, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(279), true, false, 11, 1, 1, 50, null, null },
                    { 82, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(280), true, false, 11, 1, 2, 50, null, null },
                    { 83, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(280), true, false, 11, 1, 3, 50, null, null },
                    { 84, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(281), true, false, 11, 1, 4, 50, null, null },
                    { 85, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(282), true, false, 11, 4, 21, 50, null, null },
                    { 86, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(283), true, false, 11, 5, 24, 50, null, null },
                    { 87, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(283), true, false, 11, 6, 26, 50, null, null },
                    { 88, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(284), true, false, 11, 7, 30, 50, null, null },
                    { 89, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(832), true, false, 12, 1, 1, 50, null, null },
                    { 90, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(833), true, false, 12, 1, 2, 50, null, null },
                    { 91, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(833), true, false, 12, 1, 3, 50, null, null },
                    { 92, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(834), true, false, 12, 1, 4, 50, null, null },
                    { 93, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(835), true, false, 12, 4, 36, 50, null, null },
                    { 94, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(836), true, false, 12, 5, 23, 50, null, null },
                    { 95, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(837), true, false, 12, 6, 26, 50, null, null },
                    { 96, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(838), true, false, 12, 7, 30, 50, null, null },
                    { 97, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(1369), true, false, 13, 1, 1, 50, null, null },
                    { 98, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(1370), true, false, 13, 1, 2, 50, null, null },
                    { 99, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(1370), true, false, 13, 1, 3, 50, null, null },
                    { 100, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(1371), true, false, 13, 1, 4, 50, null, null },
                    { 101, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(1372), true, false, 13, 4, 16, 50, null, null },
                    { 102, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(1373), true, false, 13, 5, 23, 50, null, null },
                    { 103, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(1374), true, false, 13, 6, 27, 50, null, null },
                    { 104, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(1375), true, false, 13, 7, 30, 50, null, null },
                    { 105, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(1891), true, false, 14, 1, 1, 50, null, null },
                    { 106, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(1892), true, false, 14, 1, 2, 50, null, null },
                    { 107, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(1892), true, false, 14, 1, 3, 50, null, null },
                    { 108, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(1893), true, false, 14, 1, 4, 50, null, null },
                    { 109, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(1894), true, false, 14, 4, 15, 50, null, null },
                    { 110, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(1895), true, false, 14, 5, 24, 50, null, null },
                    { 111, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(1896), true, false, 14, 6, 28, 50, null, null },
                    { 112, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(1897), true, false, 14, 7, 30, 50, null, null },
                    { 113, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(2509), true, false, 15, 1, 1, 50, null, null },
                    { 114, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(2510), true, false, 15, 1, 2, 50, null, null },
                    { 115, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(2511), true, false, 15, 1, 3, 50, null, null },
                    { 116, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(2511), true, false, 15, 1, 4, 50, null, null },
                    { 117, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(2513), true, false, 15, 4, 19, 50, null, null },
                    { 118, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(2514), true, false, 15, 5, 24, 50, null, null },
                    { 119, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(2515), true, false, 15, 6, 26, 50, null, null },
                    { 120, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(2516), true, false, 15, 7, 30, 50, null, null },
                    { 121, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(3099), true, false, 16, 1, 1, 50, null, null },
                    { 122, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(3100), true, false, 16, 1, 2, 50, null, null },
                    { 123, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(3100), true, false, 16, 1, 3, 50, null, null },
                    { 124, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(3101), true, false, 16, 1, 4, 50, null, null },
                    { 125, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(3101), true, false, 16, 4, 15, 50, null, null },
                    { 126, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(3102), true, false, 16, 5, 24, 50, null, null },
                    { 127, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(3103), true, false, 16, 6, 28, 50, null, null },
                    { 128, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(3104), true, false, 16, 7, 30, 50, null, null },
                    { 129, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(3604), true, false, 17, 1, 1, 50, null, null },
                    { 130, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(3608), true, false, 17, 1, 2, 50, null, null },
                    { 131, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(3609), true, false, 17, 1, 3, 50, null, null },
                    { 132, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(3609), true, false, 17, 1, 4, 50, null, null },
                    { 133, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(3610), true, false, 17, 4, 33, 50, null, null },
                    { 134, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(3611), true, false, 17, 5, 24, 50, null, null },
                    { 135, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(3612), true, false, 17, 6, 28, 50, null, null },
                    { 136, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(3647), true, false, 17, 7, 30, 50, null, null },
                    { 137, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(4153), true, false, 18, 1, 1, 50, null, null },
                    { 138, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(4154), true, false, 18, 1, 2, 50, null, null },
                    { 139, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(4154), true, false, 18, 1, 3, 50, null, null },
                    { 140, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(4155), true, false, 18, 1, 4, 50, null, null },
                    { 141, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(4156), true, false, 18, 4, 21, 50, null, null },
                    { 142, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(4190), true, false, 18, 5, 23, 50, null, null },
                    { 143, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(4191), true, false, 18, 6, 28, 50, null, null },
                    { 144, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(4192), true, false, 18, 7, 30, 50, null, null },
                    { 145, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(4680), true, false, 19, 1, 1, 50, null, null },
                    { 146, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(4680), true, false, 19, 1, 2, 50, null, null },
                    { 147, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(4681), true, false, 19, 1, 3, 50, null, null },
                    { 148, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(4681), true, false, 19, 1, 4, 50, null, null },
                    { 149, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(4712), true, false, 19, 4, 21, 50, null, null },
                    { 150, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(4713), true, false, 19, 5, 22, 50, null, null },
                    { 151, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(4714), true, false, 19, 6, 27, 50, null, null },
                    { 152, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(4715), true, false, 19, 7, 30, 50, null, null },
                    { 153, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(5189), true, false, 20, 1, 1, 50, null, null },
                    { 154, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(5190), true, false, 20, 1, 2, 50, null, null },
                    { 155, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(5190), true, false, 20, 1, 3, 50, null, null },
                    { 156, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(5191), true, false, 20, 1, 4, 50, null, null },
                    { 157, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(5192), true, false, 20, 4, 16, 50, null, null },
                    { 158, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(5195), true, false, 20, 5, 22, 50, null, null },
                    { 159, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(5196), true, false, 20, 6, 27, 50, null, null },
                    { 160, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(5197), true, false, 20, 7, 30, 50, null, null },
                    { 161, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(5723), true, false, 21, 1, 1, 50, null, null },
                    { 162, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(5723), true, false, 21, 1, 2, 50, null, null },
                    { 163, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(5748), true, false, 21, 1, 3, 50, null, null },
                    { 164, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(5749), true, false, 21, 1, 4, 50, null, null },
                    { 165, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(5750), true, false, 21, 4, 19, 50, null, null },
                    { 166, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(5751), true, false, 21, 5, 23, 50, null, null },
                    { 167, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(5752), true, false, 21, 6, 12, 50, null, null },
                    { 168, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(5753), true, false, 21, 7, 29, 50, null, null },
                    { 169, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(6261), true, false, 22, 1, 1, 50, null, null },
                    { 170, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(6262), true, false, 22, 1, 2, 50, null, null },
                    { 171, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(6262), true, false, 22, 1, 3, 50, null, null },
                    { 172, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(6263), true, false, 22, 1, 4, 50, null, null },
                    { 173, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(6264), true, false, 22, 4, 19, 50, null, null },
                    { 174, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(6265), true, false, 22, 5, 23, 50, null, null },
                    { 175, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(6266), true, false, 22, 6, 28, 50, null, null },
                    { 176, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(6267), true, false, 22, 7, 30, 50, null, null },
                    { 177, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(6783), true, false, 23, 1, 1, 50, null, null },
                    { 178, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(6783), true, false, 23, 1, 2, 50, null, null },
                    { 179, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(6783), true, false, 23, 1, 3, 50, null, null },
                    { 180, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(6784), true, false, 23, 1, 4, 50, null, null },
                    { 181, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(6785), true, false, 23, 4, 35, 50, null, null },
                    { 182, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(6786), true, false, 23, 5, 23, 50, null, null },
                    { 183, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(6787), true, false, 23, 6, 27, 50, null, null },
                    { 184, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(6788), true, false, 23, 7, 29, 50, null, null },
                    { 185, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(7293), true, false, 24, 1, 1, 50, null, null },
                    { 186, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(7293), true, false, 24, 1, 2, 50, null, null },
                    { 187, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(7294), true, false, 24, 1, 3, 50, null, null },
                    { 188, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(7294), true, false, 24, 1, 4, 50, null, null },
                    { 189, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(7295), true, false, 24, 4, 19, 50, null, null },
                    { 190, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(7296), true, false, 24, 5, 24, 50, null, null },
                    { 191, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(7297), true, false, 24, 6, 28, 50, null, null },
                    { 192, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(7298), true, false, 24, 7, 31, 50, null, null },
                    { 193, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(8198), true, false, 25, 1, 1, 50, null, null },
                    { 194, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(8199), true, false, 25, 1, 2, 50, null, null },
                    { 195, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(8199), true, false, 25, 1, 3, 50, null, null },
                    { 196, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(8200), true, false, 25, 1, 4, 50, null, null },
                    { 197, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(8202), true, false, 25, 4, 34, 50, null, null },
                    { 198, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(8204), true, false, 25, 5, 24, 50, null, null },
                    { 199, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(8206), true, false, 25, 6, 26, 50, null, null },
                    { 200, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(8209), true, false, 25, 7, 30, 50, null, null },
                    { 201, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(9119), true, false, 26, 1, 1, 50, null, null },
                    { 202, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(9120), true, false, 26, 1, 2, 50, null, null },
                    { 203, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(9120), true, false, 26, 1, 3, 50, null, null },
                    { 204, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(9121), true, false, 26, 1, 4, 50, null, null },
                    { 205, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(9122), true, false, 26, 4, 17, 50, null, null },
                    { 206, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(9123), true, false, 26, 5, 24, 50, null, null },
                    { 207, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(9124), true, false, 26, 6, 28, 50, null, null },
                    { 208, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(9126), true, false, 26, 7, 31, 50, null, null },
                    { 209, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(9748), true, false, 27, 1, 1, 50, null, null },
                    { 210, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(9749), true, false, 27, 1, 2, 50, null, null },
                    { 211, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(9749), true, false, 27, 1, 3, 50, null, null },
                    { 212, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(9750), true, false, 27, 1, 4, 50, null, null },
                    { 213, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(9751), true, false, 27, 4, 19, 50, null, null },
                    { 214, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(9752), true, false, 27, 5, 23, 50, null, null },
                    { 215, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(9753), true, false, 27, 6, 26, 50, null, null },
                    { 216, null, new DateTime(2025, 9, 21, 22, 36, 37, 359, DateTimeKind.Local).AddTicks(9754), true, false, 27, 7, 30, 50, null, null },
                    { 217, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(303), true, false, 28, 1, 1, 50, null, null },
                    { 218, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(304), true, false, 28, 1, 2, 50, null, null },
                    { 219, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(304), true, false, 28, 1, 3, 50, null, null },
                    { 220, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(305), true, false, 28, 1, 4, 50, null, null },
                    { 221, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(306), true, false, 28, 4, 36, 50, null, null },
                    { 222, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(307), true, false, 28, 5, 23, 50, null, null },
                    { 223, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(308), true, false, 28, 6, 28, 50, null, null },
                    { 224, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(309), true, false, 28, 7, 30, 50, null, null },
                    { 225, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(866), true, false, 29, 1, 1, 50, null, null },
                    { 226, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(866), true, false, 29, 1, 2, 50, null, null },
                    { 227, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(867), true, false, 29, 1, 3, 50, null, null },
                    { 228, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(867), true, false, 29, 1, 4, 50, null, null },
                    { 229, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(869), true, false, 29, 4, 19, 50, null, null },
                    { 230, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(870), true, false, 29, 5, 22, 50, null, null },
                    { 231, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(871), true, false, 29, 6, 27, 50, null, null },
                    { 232, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(871), true, false, 29, 7, 30, 50, null, null },
                    { 233, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(1403), true, false, 30, 1, 1, 50, null, null },
                    { 234, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(1404), true, false, 30, 1, 2, 50, null, null },
                    { 235, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(1404), true, false, 30, 1, 3, 50, null, null },
                    { 236, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(1405), true, false, 30, 1, 4, 50, null, null },
                    { 237, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(1406), true, false, 30, 4, 16, 50, null, null },
                    { 238, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(1407), true, false, 30, 5, 24, 50, null, null },
                    { 239, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(1408), true, false, 30, 6, 28, 50, null, null },
                    { 240, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(1409), true, false, 30, 7, 30, 50, null, null },
                    { 241, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(1901), true, false, 31, 1, 1, 50, null, null },
                    { 242, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(1901), true, false, 31, 1, 2, 50, null, null },
                    { 243, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(1902), true, false, 31, 1, 3, 50, null, null },
                    { 244, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(1902), true, false, 31, 1, 4, 50, null, null },
                    { 245, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(1903), true, false, 31, 4, 21, 50, null, null },
                    { 246, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(1904), true, false, 31, 5, 23, 50, null, null },
                    { 247, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(1905), true, false, 31, 6, 12, 50, null, null },
                    { 248, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(1906), true, false, 31, 7, 29, 50, null, null },
                    { 249, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2400), true, false, 32, 1, 52, 50, null, null },
                    { 250, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2401), true, false, 32, 1, 53, 50, null, null },
                    { 251, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2401), true, false, 32, 1, 54, 50, null, null },
                    { 252, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2403), true, false, 32, 8, 37, 50, null, null },
                    { 253, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2404), true, false, 32, 9, 40, 50, null, null },
                    { 254, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2406), true, false, 32, 10, 43, 50, null, null },
                    { 255, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2424), true, false, 32, 11, 46, 50, null, null },
                    { 256, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2425), true, false, 32, 11, 47, 50, null, null },
                    { 257, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2426), true, false, 32, 11, 48, 50, null, null },
                    { 258, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2432), true, false, 32, 11, 50, 50, null, null },
                    { 259, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2432), true, false, 32, 11, 51, 50, null, null },
                    { 260, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2975), true, false, 33, 1, 52, 50, null, null },
                    { 261, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2976), true, false, 33, 1, 53, 50, null, null },
                    { 262, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2976), true, false, 33, 1, 54, 50, null, null },
                    { 263, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2977), true, false, 33, 8, 37, 50, null, null },
                    { 264, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2978), true, false, 33, 9, 40, 50, null, null },
                    { 265, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2979), true, false, 33, 10, 43, 50, null, null },
                    { 266, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2981), true, false, 33, 11, 46, 50, null, null },
                    { 267, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2982), true, false, 33, 11, 47, 50, null, null },
                    { 268, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2983), true, false, 33, 11, 48, 50, null, null },
                    { 269, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2983), true, false, 33, 11, 50, 50, null, null },
                    { 270, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(2984), true, false, 33, 11, 51, 50, null, null },
                    { 271, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(3492), true, false, 34, 1, 52, 50, null, null },
                    { 272, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(3492), true, false, 34, 1, 53, 50, null, null },
                    { 273, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(3493), true, false, 34, 1, 54, 50, null, null },
                    { 274, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(3494), true, false, 34, 8, 37, 50, null, null },
                    { 275, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(3495), true, false, 34, 9, 40, 50, null, null },
                    { 276, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(3495), true, false, 34, 10, 43, 50, null, null },
                    { 277, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(3497), true, false, 34, 11, 46, 50, null, null },
                    { 278, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(3524), true, false, 34, 11, 47, 50, null, null },
                    { 279, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(3525), true, false, 34, 11, 48, 50, null, null },
                    { 280, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(3525), true, false, 34, 11, 50, 50, null, null },
                    { 281, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(3526), true, false, 34, 11, 51, 50, null, null },
                    { 282, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4002), true, false, 35, 1, 52, 50, null, null },
                    { 283, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4003), true, false, 35, 1, 53, 50, null, null },
                    { 284, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4003), true, false, 35, 1, 54, 50, null, null },
                    { 285, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4038), true, false, 35, 8, 37, 50, null, null },
                    { 286, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4039), true, false, 35, 9, 40, 50, null, null },
                    { 287, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4039), true, false, 35, 10, 43, 50, null, null },
                    { 288, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4041), true, false, 35, 11, 46, 50, null, null },
                    { 289, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4041), true, false, 35, 11, 47, 50, null, null },
                    { 290, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4042), true, false, 35, 11, 48, 50, null, null },
                    { 291, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4042), true, false, 35, 11, 50, 50, null, null },
                    { 292, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4043), true, false, 35, 11, 51, 50, null, null },
                    { 293, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4514), true, false, 36, 1, 52, 50, null, null },
                    { 294, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4515), true, false, 36, 1, 53, 50, null, null },
                    { 295, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4516), true, false, 36, 1, 54, 50, null, null },
                    { 296, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4516), true, false, 36, 8, 37, 50, null, null },
                    { 297, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4517), true, false, 36, 9, 40, 50, null, null },
                    { 298, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4517), true, false, 36, 10, 43, 50, null, null },
                    { 299, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4519), true, false, 36, 11, 46, 50, null, null },
                    { 300, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4519), true, false, 36, 11, 47, 50, null, null },
                    { 301, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4520), true, false, 36, 11, 48, 50, null, null },
                    { 302, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4520), true, false, 36, 11, 50, 50, null, null },
                    { 303, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4521), true, false, 36, 11, 51, 50, null, null },
                    { 304, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4998), true, false, 37, 1, 52, 50, null, null },
                    { 305, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4999), true, false, 37, 1, 53, 50, null, null },
                    { 306, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(4999), true, false, 37, 1, 54, 50, null, null },
                    { 307, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5000), true, false, 37, 8, 37, 50, null, null },
                    { 308, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5000), true, false, 37, 9, 40, 50, null, null },
                    { 309, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5001), true, false, 37, 10, 43, 50, null, null },
                    { 310, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5003), true, false, 37, 11, 46, 50, null, null },
                    { 311, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5003), true, false, 37, 11, 47, 50, null, null },
                    { 312, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5004), true, false, 37, 11, 48, 50, null, null },
                    { 313, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5004), true, false, 37, 11, 50, 50, null, null },
                    { 314, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5005), true, false, 37, 11, 51, 50, null, null },
                    { 315, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5503), true, false, 38, 1, 52, 50, null, null },
                    { 316, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5504), true, false, 38, 1, 53, 50, null, null },
                    { 317, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5505), true, false, 38, 1, 54, 50, null, null },
                    { 318, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5505), true, false, 38, 8, 37, 50, null, null },
                    { 319, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5506), true, false, 38, 9, 40, 50, null, null },
                    { 320, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5507), true, false, 38, 10, 43, 50, null, null },
                    { 321, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5508), true, false, 38, 11, 46, 50, null, null },
                    { 322, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5509), true, false, 38, 11, 47, 50, null, null },
                    { 323, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5509), true, false, 38, 11, 48, 50, null, null },
                    { 324, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5510), true, false, 38, 11, 50, 50, null, null },
                    { 325, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(5510), true, false, 38, 11, 51, 50, null, null },
                    { 326, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6004), true, false, 39, 1, 52, 50, null, null },
                    { 327, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6004), true, false, 39, 1, 53, 50, null, null },
                    { 328, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6005), true, false, 39, 1, 54, 50, null, null },
                    { 329, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6006), true, false, 39, 8, 37, 50, null, null },
                    { 330, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6007), true, false, 39, 9, 40, 50, null, null },
                    { 331, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6007), true, false, 39, 10, 43, 50, null, null },
                    { 332, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6009), true, false, 39, 11, 46, 50, null, null },
                    { 333, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6009), true, false, 39, 11, 47, 50, null, null },
                    { 334, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6010), true, false, 39, 11, 48, 50, null, null },
                    { 335, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6010), true, false, 39, 11, 50, 50, null, null },
                    { 336, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6011), true, false, 39, 11, 51, 50, null, null },
                    { 337, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6524), true, false, 40, 1, 52, 50, null, null },
                    { 338, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6524), true, false, 40, 1, 53, 50, null, null },
                    { 339, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6525), true, false, 40, 1, 54, 50, null, null },
                    { 340, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6525), true, false, 40, 8, 37, 50, null, null },
                    { 341, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6526), true, false, 40, 9, 40, 50, null, null },
                    { 342, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6526), true, false, 40, 10, 43, 50, null, null },
                    { 343, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6528), true, false, 40, 11, 46, 50, null, null },
                    { 344, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6529), true, false, 40, 11, 47, 50, null, null },
                    { 345, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6530), true, false, 40, 11, 48, 50, null, null },
                    { 346, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6530), true, false, 40, 11, 50, 50, null, null },
                    { 347, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(6530), true, false, 40, 11, 51, 50, null, null },
                    { 348, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7003), true, false, 41, 1, 52, 50, null, null },
                    { 349, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7004), true, false, 41, 1, 53, 50, null, null },
                    { 350, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7004), true, false, 41, 1, 54, 50, null, null },
                    { 351, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7005), true, false, 41, 8, 37, 50, null, null },
                    { 352, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7005), true, false, 41, 9, 40, 50, null, null },
                    { 353, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7006), true, false, 41, 10, 43, 50, null, null },
                    { 354, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7007), true, false, 41, 11, 46, 50, null, null },
                    { 355, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7008), true, false, 41, 11, 47, 50, null, null },
                    { 356, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7008), true, false, 41, 11, 48, 50, null, null },
                    { 357, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7009), true, false, 41, 11, 50, 50, null, null },
                    { 358, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7009), true, false, 41, 11, 51, 50, null, null },
                    { 359, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7553), true, false, 42, 1, 52, 50, null, null },
                    { 360, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7554), true, false, 42, 1, 53, 50, null, null },
                    { 361, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7554), true, false, 42, 1, 54, 50, null, null },
                    { 362, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7555), true, false, 42, 8, 37, 50, null, null },
                    { 363, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7555), true, false, 42, 9, 40, 50, null, null },
                    { 364, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7556), true, false, 42, 10, 43, 50, null, null },
                    { 365, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7557), true, false, 42, 11, 46, 50, null, null },
                    { 366, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7558), true, false, 42, 11, 47, 50, null, null },
                    { 367, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7558), true, false, 42, 11, 48, 50, null, null },
                    { 368, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7559), true, false, 42, 11, 50, 50, null, null },
                    { 369, null, new DateTime(2025, 9, 21, 22, 36, 37, 360, DateTimeKind.Local).AddTicks(7559), true, false, 42, 11, 51, 50, null, null },
                    { 370, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(629), true, false, 43, 1, 52, 50, null, null },
                    { 371, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(631), true, false, 43, 1, 53, 50, null, null },
                    { 372, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(632), true, false, 43, 1, 54, 50, null, null },
                    { 373, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(634), true, false, 43, 8, 37, 50, null, null },
                    { 374, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(636), true, false, 43, 9, 40, 50, null, null },
                    { 375, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(638), true, false, 43, 10, 43, 50, null, null },
                    { 376, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(651), true, false, 43, 11, 46, 50, null, null },
                    { 377, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(652), true, false, 43, 11, 47, 50, null, null },
                    { 378, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(653), true, false, 43, 11, 48, 50, null, null },
                    { 379, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(653), true, false, 43, 11, 50, 50, null, null },
                    { 380, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(654), true, false, 43, 11, 51, 50, null, null },
                    { 381, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(1483), true, false, 44, 1, 52, 50, null, null },
                    { 382, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(1483), true, false, 44, 1, 53, 50, null, null },
                    { 383, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(1484), true, false, 44, 1, 54, 50, null, null },
                    { 384, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(1485), true, false, 44, 8, 37, 50, null, null },
                    { 385, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(1486), true, false, 44, 9, 40, 50, null, null },
                    { 386, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(1486), true, false, 44, 10, 43, 50, null, null },
                    { 387, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(1488), true, false, 44, 11, 46, 50, null, null },
                    { 388, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(1489), true, false, 44, 11, 47, 50, null, null },
                    { 389, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(1490), true, false, 44, 11, 48, 50, null, null },
                    { 390, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(1490), true, false, 44, 11, 50, 50, null, null },
                    { 391, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(1491), true, false, 44, 11, 51, 50, null, null },
                    { 392, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2121), true, false, 45, 1, 52, 50, null, null },
                    { 393, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2122), true, false, 45, 1, 53, 50, null, null },
                    { 394, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2123), true, false, 45, 1, 54, 50, null, null },
                    { 395, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2124), true, false, 45, 8, 37, 50, null, null },
                    { 396, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2125), true, false, 45, 9, 40, 50, null, null },
                    { 397, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2126), true, false, 45, 10, 43, 50, null, null },
                    { 398, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2127), true, false, 45, 11, 46, 50, null, null },
                    { 399, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2128), true, false, 45, 11, 47, 50, null, null },
                    { 400, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2128), true, false, 45, 11, 48, 50, null, null },
                    { 401, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2129), true, false, 45, 11, 50, 50, null, null },
                    { 402, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2130), true, false, 45, 11, 51, 50, null, null },
                    { 403, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2735), true, false, 46, 1, 52, 50, null, null },
                    { 404, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2735), true, false, 46, 1, 53, 50, null, null },
                    { 405, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2736), true, false, 46, 1, 54, 50, null, null },
                    { 406, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2736), true, false, 46, 8, 37, 50, null, null },
                    { 407, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2737), true, false, 46, 9, 40, 50, null, null },
                    { 408, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2738), true, false, 46, 10, 43, 50, null, null },
                    { 409, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2740), true, false, 46, 11, 46, 50, null, null },
                    { 410, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2740), true, false, 46, 11, 47, 50, null, null },
                    { 411, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2770), true, false, 46, 11, 48, 50, null, null },
                    { 412, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2771), true, false, 46, 11, 50, 50, null, null },
                    { 413, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(2771), true, false, 46, 11, 51, 50, null, null },
                    { 414, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(3464), true, false, 47, 1, 52, 50, null, null },
                    { 415, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(3465), true, false, 47, 1, 53, 50, null, null },
                    { 416, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(3465), true, false, 47, 1, 54, 50, null, null },
                    { 417, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(3466), true, false, 47, 8, 37, 50, null, null },
                    { 418, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(3497), true, false, 47, 9, 40, 50, null, null },
                    { 419, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(3498), true, false, 47, 10, 43, 50, null, null },
                    { 420, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(3500), true, false, 47, 11, 46, 50, null, null },
                    { 421, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(3501), true, false, 47, 11, 47, 50, null, null },
                    { 422, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(3501), true, false, 47, 11, 48, 50, null, null },
                    { 423, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(3502), true, false, 47, 11, 50, 50, null, null },
                    { 424, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(3503), true, false, 47, 11, 51, 50, null, null },
                    { 425, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4081), true, false, 48, 1, 52, 50, null, null },
                    { 426, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4081), true, false, 48, 1, 53, 50, null, null },
                    { 427, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4082), true, false, 48, 1, 54, 50, null, null },
                    { 428, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4082), true, false, 48, 8, 37, 50, null, null },
                    { 429, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4083), true, false, 48, 9, 40, 50, null, null },
                    { 430, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4084), true, false, 48, 10, 43, 50, null, null },
                    { 431, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4085), true, false, 48, 11, 46, 50, null, null },
                    { 432, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4086), true, false, 48, 11, 47, 50, null, null },
                    { 433, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4086), true, false, 48, 11, 48, 50, null, null },
                    { 434, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4087), true, false, 48, 11, 50, 50, null, null },
                    { 435, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4088), true, false, 48, 11, 51, 50, null, null },
                    { 436, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4673), true, false, 49, 1, 52, 50, null, null },
                    { 437, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4673), true, false, 49, 1, 53, 50, null, null },
                    { 438, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4674), true, false, 49, 1, 54, 50, null, null },
                    { 439, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4674), true, false, 49, 8, 37, 50, null, null },
                    { 440, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4675), true, false, 49, 9, 40, 50, null, null },
                    { 441, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4676), true, false, 49, 10, 43, 50, null, null },
                    { 442, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4678), true, false, 49, 11, 46, 50, null, null },
                    { 443, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4679), true, false, 49, 11, 47, 50, null, null },
                    { 444, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4680), true, false, 49, 11, 48, 50, null, null },
                    { 445, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4680), true, false, 49, 11, 50, 50, null, null },
                    { 446, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(4681), true, false, 49, 11, 51, 50, null, null },
                    { 447, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5248), true, false, 50, 1, 52, 50, null, null },
                    { 448, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5248), true, false, 50, 1, 53, 50, null, null },
                    { 449, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5249), true, false, 50, 1, 54, 50, null, null },
                    { 450, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5249), true, false, 50, 8, 37, 50, null, null },
                    { 451, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5250), true, false, 50, 9, 40, 50, null, null },
                    { 452, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5250), true, false, 50, 10, 43, 50, null, null },
                    { 453, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5252), true, false, 50, 11, 46, 50, null, null },
                    { 454, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5253), true, false, 50, 11, 47, 50, null, null },
                    { 455, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5253), true, false, 50, 11, 48, 50, null, null },
                    { 456, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5254), true, false, 50, 11, 50, 50, null, null },
                    { 457, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5254), true, false, 50, 11, 51, 50, null, null },
                    { 458, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5877), true, false, 51, 1, 52, 50, null, null },
                    { 459, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5878), true, false, 51, 1, 53, 50, null, null },
                    { 460, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5878), true, false, 51, 1, 54, 50, null, null },
                    { 461, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5879), true, false, 51, 8, 37, 50, null, null },
                    { 462, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5880), true, false, 51, 9, 40, 50, null, null },
                    { 463, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5880), true, false, 51, 10, 43, 50, null, null },
                    { 464, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5882), true, false, 51, 11, 46, 50, null, null },
                    { 465, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5883), true, false, 51, 11, 47, 50, null, null },
                    { 466, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5883), true, false, 51, 11, 48, 50, null, null },
                    { 467, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5884), true, false, 51, 11, 50, 50, null, null },
                    { 468, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(5884), true, false, 51, 11, 51, 50, null, null },
                    { 469, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6414), true, false, 52, 1, 52, 50, null, null },
                    { 470, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6414), true, false, 52, 1, 53, 50, null, null },
                    { 471, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6415), true, false, 52, 1, 54, 50, null, null },
                    { 472, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6415), true, false, 52, 8, 37, 50, null, null },
                    { 473, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6416), true, false, 52, 9, 40, 50, null, null },
                    { 474, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6417), true, false, 52, 10, 43, 50, null, null },
                    { 475, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6418), true, false, 52, 11, 46, 50, null, null },
                    { 476, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6419), true, false, 52, 11, 47, 50, null, null },
                    { 477, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6419), true, false, 52, 11, 48, 50, null, null },
                    { 478, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6420), true, false, 52, 11, 50, 50, null, null },
                    { 479, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6420), true, false, 52, 11, 51, 50, null, null },
                    { 480, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6953), true, false, 53, 1, 52, 50, null, null },
                    { 481, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6954), true, false, 53, 1, 53, 50, null, null },
                    { 482, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6955), true, false, 53, 1, 54, 50, null, null },
                    { 483, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6955), true, false, 53, 8, 37, 50, null, null },
                    { 484, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6956), true, false, 53, 9, 40, 50, null, null },
                    { 485, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6956), true, false, 53, 10, 43, 50, null, null },
                    { 486, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6958), true, false, 53, 11, 46, 50, null, null },
                    { 487, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6958), true, false, 53, 11, 47, 50, null, null },
                    { 488, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6959), true, false, 53, 11, 48, 50, null, null },
                    { 489, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6959), true, false, 53, 11, 50, 50, null, null },
                    { 490, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(6960), true, false, 53, 11, 51, 50, null, null },
                    { 491, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(7507), true, false, 54, 1, 52, 50, null, null },
                    { 492, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(7507), true, false, 54, 1, 53, 50, null, null },
                    { 493, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(7508), true, false, 54, 1, 54, 50, null, null },
                    { 494, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(7509), true, false, 54, 8, 37, 50, null, null },
                    { 495, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(7509), true, false, 54, 9, 40, 50, null, null },
                    { 496, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(7510), true, false, 54, 10, 43, 50, null, null },
                    { 497, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(7512), true, false, 54, 11, 46, 50, null, null },
                    { 498, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(7512), true, false, 54, 11, 47, 50, null, null },
                    { 499, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(7513), true, false, 54, 11, 48, 50, null, null },
                    { 500, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(7513), true, false, 54, 11, 50, 50, null, null },
                    { 501, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(7514), true, false, 54, 11, 51, 50, null, null },
                    { 502, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8054), true, false, 55, 1, 52, 50, null, null },
                    { 503, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8054), true, false, 55, 1, 53, 50, null, null },
                    { 504, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8055), true, false, 55, 1, 54, 50, null, null },
                    { 505, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8056), true, false, 55, 8, 37, 50, null, null },
                    { 506, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8056), true, false, 55, 9, 40, 50, null, null },
                    { 507, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8057), true, false, 55, 10, 43, 50, null, null },
                    { 508, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8058), true, false, 55, 11, 46, 50, null, null },
                    { 509, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8059), true, false, 55, 11, 47, 50, null, null },
                    { 510, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8060), true, false, 55, 11, 48, 50, null, null },
                    { 511, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8060), true, false, 55, 11, 50, 50, null, null },
                    { 512, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8061), true, false, 55, 11, 51, 50, null, null },
                    { 513, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8692), true, false, 56, 1, 52, 50, null, null },
                    { 514, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8727), true, false, 56, 1, 53, 50, null, null },
                    { 515, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8728), true, false, 56, 1, 54, 50, null, null },
                    { 516, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8729), true, false, 56, 8, 37, 50, null, null },
                    { 517, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8730), true, false, 56, 9, 40, 50, null, null },
                    { 518, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8731), true, false, 56, 10, 43, 50, null, null },
                    { 519, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8732), true, false, 56, 11, 46, 50, null, null },
                    { 520, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8733), true, false, 56, 11, 47, 50, null, null },
                    { 521, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8733), true, false, 56, 11, 48, 50, null, null },
                    { 522, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8734), true, false, 56, 11, 50, 50, null, null },
                    { 523, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(8734), true, false, 56, 11, 51, 50, null, null },
                    { 524, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9283), true, false, 57, 1, 52, 50, null, null },
                    { 525, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9284), true, false, 57, 1, 53, 50, null, null },
                    { 526, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9284), true, false, 57, 1, 54, 50, null, null },
                    { 527, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9285), true, false, 57, 8, 37, 50, null, null },
                    { 528, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9285), true, false, 57, 9, 40, 50, null, null },
                    { 529, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9286), true, false, 57, 10, 43, 50, null, null },
                    { 530, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9288), true, false, 57, 11, 46, 50, null, null },
                    { 531, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9289), true, false, 57, 11, 47, 50, null, null },
                    { 532, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9289), true, false, 57, 11, 48, 50, null, null },
                    { 533, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9290), true, false, 57, 11, 50, 50, null, null },
                    { 534, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9291), true, false, 57, 11, 51, 50, null, null },
                    { 535, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9890), true, false, 58, 1, 52, 50, null, null },
                    { 536, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9891), true, false, 58, 1, 53, 50, null, null },
                    { 537, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9891), true, false, 58, 1, 54, 50, null, null },
                    { 538, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9892), true, false, 58, 8, 37, 50, null, null },
                    { 539, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9893), true, false, 58, 9, 40, 50, null, null },
                    { 540, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9894), true, false, 58, 10, 43, 50, null, null },
                    { 541, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9896), true, false, 58, 11, 46, 50, null, null },
                    { 542, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9896), true, false, 58, 11, 47, 50, null, null },
                    { 543, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9926), true, false, 58, 11, 48, 50, null, null },
                    { 544, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9927), true, false, 58, 11, 50, 50, null, null },
                    { 545, null, new DateTime(2025, 9, 21, 22, 36, 37, 361, DateTimeKind.Local).AddTicks(9928), true, false, 58, 11, 51, 50, null, null },
                    { 546, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(490), true, false, 59, 1, 52, 50, null, null },
                    { 547, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(491), true, false, 59, 1, 53, 50, null, null },
                    { 548, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(491), true, false, 59, 1, 54, 50, null, null },
                    { 549, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(492), true, false, 59, 8, 37, 50, null, null },
                    { 550, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(526), true, false, 59, 9, 40, 50, null, null },
                    { 551, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(527), true, false, 59, 10, 43, 50, null, null },
                    { 552, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(528), true, false, 59, 11, 46, 50, null, null },
                    { 553, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(529), true, false, 59, 11, 47, 50, null, null },
                    { 554, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(530), true, false, 59, 11, 48, 50, null, null },
                    { 555, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(530), true, false, 59, 11, 50, 50, null, null },
                    { 556, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(531), true, false, 59, 11, 51, 50, null, null },
                    { 557, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1108), true, false, 60, 1, 52, 50, null, null },
                    { 558, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1108), true, false, 60, 1, 53, 50, null, null },
                    { 559, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1109), true, false, 60, 1, 54, 50, null, null },
                    { 560, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1109), true, false, 60, 8, 37, 50, null, null },
                    { 561, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1110), true, false, 60, 9, 40, 50, null, null },
                    { 562, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1111), true, false, 60, 10, 43, 50, null, null },
                    { 563, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1113), true, false, 60, 11, 46, 50, null, null },
                    { 564, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1113), true, false, 60, 11, 47, 50, null, null },
                    { 565, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1114), true, false, 60, 11, 48, 50, null, null },
                    { 566, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1114), true, false, 60, 11, 50, 50, null, null },
                    { 567, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1115), true, false, 60, 11, 51, 50, null, null },
                    { 568, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1667), true, false, 61, 1, 52, 50, null, null },
                    { 569, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1667), true, false, 61, 1, 53, 50, null, null },
                    { 570, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1668), true, false, 61, 1, 54, 50, null, null },
                    { 571, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1669), true, false, 61, 8, 37, 50, null, null },
                    { 572, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1670), true, false, 61, 9, 40, 50, null, null },
                    { 573, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1670), true, false, 61, 10, 43, 50, null, null },
                    { 574, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1672), true, false, 61, 11, 46, 50, null, null },
                    { 575, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1673), true, false, 61, 11, 47, 50, null, null },
                    { 576, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1673), true, false, 61, 11, 48, 50, null, null },
                    { 577, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1674), true, false, 61, 11, 50, 50, null, null },
                    { 578, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(1675), true, false, 61, 11, 51, 50, null, null },
                    { 579, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2243), true, false, 62, 1, 52, 50, null, null },
                    { 580, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2244), true, false, 62, 1, 53, 50, null, null },
                    { 581, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2245), true, false, 62, 1, 54, 50, null, null },
                    { 582, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2245), true, false, 62, 8, 37, 50, null, null },
                    { 583, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2246), true, false, 62, 9, 40, 50, null, null },
                    { 584, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2247), true, false, 62, 10, 43, 50, null, null },
                    { 585, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2248), true, false, 62, 11, 46, 50, null, null },
                    { 586, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2249), true, false, 62, 11, 47, 50, null, null },
                    { 587, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2250), true, false, 62, 11, 48, 50, null, null },
                    { 588, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2250), true, false, 62, 11, 50, 50, null, null },
                    { 589, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2251), true, false, 62, 11, 51, 50, null, null },
                    { 590, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2844), true, false, 63, 1, 52, 50, null, null },
                    { 591, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2844), true, false, 63, 1, 53, 50, null, null },
                    { 592, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2845), true, false, 63, 1, 54, 50, null, null },
                    { 593, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2845), true, false, 63, 8, 37, 50, null, null },
                    { 594, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2846), true, false, 63, 9, 40, 50, null, null },
                    { 595, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2847), true, false, 63, 10, 43, 50, null, null },
                    { 596, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2848), true, false, 63, 11, 46, 50, null, null },
                    { 597, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2849), true, false, 63, 11, 47, 50, null, null },
                    { 598, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2849), true, false, 63, 11, 48, 50, null, null },
                    { 599, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2850), true, false, 63, 11, 50, 50, null, null },
                    { 600, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(2850), true, false, 63, 11, 51, 50, null, null },
                    { 601, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3376), true, false, 64, 1, 52, 50, null, null },
                    { 602, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3376), true, false, 64, 1, 53, 50, null, null },
                    { 603, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3377), true, false, 64, 1, 54, 50, null, null },
                    { 604, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3377), true, false, 64, 8, 37, 50, null, null },
                    { 605, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3378), true, false, 64, 9, 40, 50, null, null },
                    { 606, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3378), true, false, 64, 10, 43, 50, null, null },
                    { 607, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3380), true, false, 64, 11, 46, 50, null, null },
                    { 608, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3381), true, false, 64, 11, 47, 50, null, null },
                    { 609, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3381), true, false, 64, 11, 48, 50, null, null },
                    { 610, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3382), true, false, 64, 11, 50, 50, null, null },
                    { 611, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3382), true, false, 64, 11, 51, 50, null, null },
                    { 612, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3876), true, false, 65, 1, 52, 50, null, null },
                    { 613, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3876), true, false, 65, 1, 53, 50, null, null },
                    { 614, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3919), true, false, 65, 1, 54, 50, null, null },
                    { 615, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3920), true, false, 65, 8, 37, 50, null, null },
                    { 616, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3920), true, false, 65, 9, 40, 50, null, null },
                    { 617, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3921), true, false, 65, 10, 43, 50, null, null },
                    { 618, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3922), true, false, 65, 11, 46, 50, null, null },
                    { 619, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3923), true, false, 65, 11, 47, 50, null, null },
                    { 620, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3923), true, false, 65, 11, 48, 50, null, null },
                    { 621, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3924), true, false, 65, 11, 50, 50, null, null },
                    { 622, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(3925), true, false, 65, 11, 51, 50, null, null },
                    { 623, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(4509), true, false, 66, 1, 52, 50, null, null },
                    { 624, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(4510), true, false, 66, 1, 53, 50, null, null },
                    { 625, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(4511), true, false, 66, 1, 54, 50, null, null },
                    { 626, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(4512), true, false, 66, 8, 37, 50, null, null },
                    { 627, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(4512), true, false, 66, 9, 40, 50, null, null },
                    { 628, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(4513), true, false, 66, 10, 43, 50, null, null },
                    { 629, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(4515), true, false, 66, 11, 46, 50, null, null },
                    { 630, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(4515), true, false, 66, 11, 47, 50, null, null },
                    { 631, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(4516), true, false, 66, 11, 48, 50, null, null },
                    { 632, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(4516), true, false, 66, 11, 50, 50, null, null },
                    { 633, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(4517), true, false, 66, 11, 51, 50, null, null },
                    { 634, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5088), true, false, 67, 1, 52, 50, null, null },
                    { 635, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5088), true, false, 67, 1, 53, 50, null, null },
                    { 636, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5089), true, false, 67, 1, 54, 50, null, null },
                    { 637, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5089), true, false, 67, 8, 37, 50, null, null },
                    { 638, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5090), true, false, 67, 9, 40, 50, null, null },
                    { 639, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5091), true, false, 67, 10, 43, 50, null, null },
                    { 640, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5092), true, false, 67, 11, 46, 50, null, null },
                    { 641, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5093), true, false, 67, 11, 47, 50, null, null },
                    { 642, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5093), true, false, 67, 11, 48, 50, null, null },
                    { 643, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5094), true, false, 67, 11, 50, 50, null, null },
                    { 644, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5094), true, false, 67, 11, 51, 50, null, null },
                    { 645, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5742), true, false, 68, 1, 52, 50, null, null },
                    { 646, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5742), true, false, 68, 1, 53, 50, null, null },
                    { 647, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5743), true, false, 68, 1, 54, 50, null, null },
                    { 648, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5744), true, false, 68, 8, 37, 50, null, null },
                    { 649, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5744), true, false, 68, 9, 40, 50, null, null },
                    { 650, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5745), true, false, 68, 10, 43, 50, null, null },
                    { 651, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5747), true, false, 68, 11, 46, 50, null, null },
                    { 652, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5747), true, false, 68, 11, 47, 50, null, null },
                    { 653, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5748), true, false, 68, 11, 48, 50, null, null },
                    { 654, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5748), true, false, 68, 11, 50, 50, null, null },
                    { 655, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(5748), true, false, 68, 11, 51, 50, null, null },
                    { 656, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6266), true, false, 69, 1, 52, 50, null, null },
                    { 657, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6267), true, false, 69, 1, 53, 50, null, null },
                    { 658, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6267), true, false, 69, 1, 54, 50, null, null },
                    { 659, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6268), true, false, 69, 8, 37, 50, null, null },
                    { 660, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6268), true, false, 69, 9, 40, 50, null, null },
                    { 661, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6269), true, false, 69, 10, 43, 50, null, null },
                    { 662, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6271), true, false, 69, 11, 46, 50, null, null },
                    { 663, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6271), true, false, 69, 11, 47, 50, null, null },
                    { 664, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6272), true, false, 69, 11, 48, 50, null, null },
                    { 665, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6272), true, false, 69, 11, 50, 50, null, null },
                    { 666, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6273), true, false, 69, 11, 51, 50, null, null },
                    { 667, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6787), true, false, 70, 1, 52, 50, null, null },
                    { 668, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6788), true, false, 70, 1, 53, 50, null, null },
                    { 669, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6788), true, false, 70, 1, 54, 50, null, null },
                    { 670, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6789), true, false, 70, 8, 37, 50, null, null },
                    { 671, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6790), true, false, 70, 9, 40, 50, null, null },
                    { 672, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6790), true, false, 70, 10, 43, 50, null, null },
                    { 673, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6792), true, false, 70, 11, 46, 50, null, null },
                    { 674, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6823), true, false, 70, 11, 47, 50, null, null },
                    { 675, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6823), true, false, 70, 11, 48, 50, null, null },
                    { 676, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6824), true, false, 70, 11, 50, 50, null, null },
                    { 677, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(6825), true, false, 70, 11, 51, 50, null, null },
                    { 678, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(7752), true, false, 71, 1, 52, 50, null, null },
                    { 679, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(7753), true, false, 71, 1, 53, 50, null, null },
                    { 680, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(7753), true, false, 71, 1, 54, 50, null, null },
                    { 681, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(7755), true, false, 71, 8, 37, 50, null, null },
                    { 682, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(7777), true, false, 71, 9, 40, 50, null, null },
                    { 683, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(7780), true, false, 71, 10, 43, 50, null, null },
                    { 684, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(7786), true, false, 71, 11, 46, 50, null, null },
                    { 685, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(7787), true, false, 71, 11, 47, 50, null, null },
                    { 686, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(7788), true, false, 71, 11, 48, 50, null, null },
                    { 687, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(7789), true, false, 71, 11, 50, 50, null, null },
                    { 688, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(7789), true, false, 71, 11, 51, 50, null, null },
                    { 689, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(8510), true, false, 72, 1, 52, 50, null, null },
                    { 690, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(8511), true, false, 72, 1, 53, 50, null, null },
                    { 691, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(8511), true, false, 72, 1, 54, 50, null, null },
                    { 692, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(8512), true, false, 72, 8, 37, 50, null, null },
                    { 693, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(8513), true, false, 72, 9, 40, 50, null, null },
                    { 694, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(8514), true, false, 72, 10, 43, 50, null, null },
                    { 695, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(8517), true, false, 72, 11, 46, 50, null, null },
                    { 696, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(8518), true, false, 72, 11, 47, 50, null, null },
                    { 697, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(8518), true, false, 72, 11, 48, 50, null, null },
                    { 698, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(8519), true, false, 72, 11, 50, 50, null, null },
                    { 699, null, new DateTime(2025, 9, 21, 22, 36, 37, 362, DateTimeKind.Local).AddTicks(8519), true, false, 72, 11, 51, 50, null, null },
                    { 700, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(688), true, false, 73, 1, 52, 50, null, null },
                    { 701, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(692), true, false, 73, 1, 53, 50, null, null },
                    { 702, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(693), true, false, 73, 1, 54, 50, null, null },
                    { 703, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(696), true, false, 73, 8, 37, 50, null, null },
                    { 704, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(697), true, false, 73, 9, 40, 50, null, null },
                    { 705, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(699), true, false, 73, 10, 43, 50, null, null },
                    { 706, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(710), true, false, 73, 11, 46, 50, null, null },
                    { 707, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(711), true, false, 73, 11, 47, 50, null, null },
                    { 708, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(712), true, false, 73, 11, 48, 50, null, null },
                    { 709, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(712), true, false, 73, 11, 50, 50, null, null },
                    { 710, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(713), true, false, 73, 11, 51, 50, null, null },
                    { 711, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(1957), true, false, 74, 1, 53, 50, null, null },
                    { 712, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(1962), true, false, 74, 3, 11, 50, null, null },
                    { 713, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(2787), true, false, 75, 1, 52, 50, null, null },
                    { 714, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(2788), true, false, 75, 3, 11, 50, null, null },
                    { 715, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(3450), true, false, 76, 1, 52, 50, null, null },
                    { 716, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(3452), true, false, 76, 3, 11, 50, null, null },
                    { 717, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(3999), true, false, 77, 1, 52, 50, null, null },
                    { 718, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(4000), true, false, 77, 3, 11, 50, null, null },
                    { 719, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(4612), true, false, 78, 1, 52, 50, null, null },
                    { 720, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(4613), true, false, 78, 3, 14, 50, null, null },
                    { 721, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(5329), true, false, 79, 1, 58, 50, null, null },
                    { 722, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(5330), true, false, 79, 3, 14, 50, null, null },
                    { 723, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(5942), true, false, 80, 1, 55, 50, null, null },
                    { 724, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(5943), true, false, 80, 3, 11, 50, null, null },
                    { 725, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(6645), true, false, 81, 1, 54, 50, null, null },
                    { 726, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(6646), true, false, 81, 3, 14, 50, null, null },
                    { 727, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(7242), true, false, 82, 1, 54, 50, null, null },
                    { 728, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(7243), true, false, 82, 3, 11, 50, null, null },
                    { 729, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(7823), true, false, 83, 1, 52, 50, null, null },
                    { 730, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(7824), true, false, 83, 3, 14, 50, null, null },
                    { 731, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(8396), true, false, 84, 1, 54, 50, null, null },
                    { 732, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(8397), true, false, 84, 3, 11, 50, null, null },
                    { 733, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(9058), true, false, 85, 1, 52, 50, null, null },
                    { 734, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(9058), true, false, 85, 3, 14, 50, null, null },
                    { 735, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(9648), true, false, 86, 1, 53, 50, null, null },
                    { 736, null, new DateTime(2025, 9, 21, 22, 36, 37, 363, DateTimeKind.Local).AddTicks(9651), true, false, 86, 3, 14, 50, null, null },
                    { 737, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(269), true, false, 87, 1, 55, 50, null, null },
                    { 738, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(270), true, false, 87, 3, 11, 50, null, null },
                    { 739, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(1113), true, false, 88, 1, 60, 50, null, null },
                    { 740, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(1116), true, false, 88, 3, 11, 50, null, null },
                    { 741, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(2191), true, false, 89, 1, 52, 50, null, null },
                    { 742, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(2192), true, false, 89, 3, 11, 50, null, null },
                    { 743, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(3076), true, false, 90, 1, 54, 50, null, null },
                    { 744, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(3077), true, false, 90, 3, 14, 50, null, null },
                    { 745, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(3741), true, false, 91, 1, 64, 50, null, null },
                    { 746, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(3741), true, false, 91, 3, 14, 50, null, null },
                    { 747, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(4811), true, false, 92, 1, 53, 50, null, null },
                    { 748, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(4813), true, false, 92, 3, 11, 50, null, null },
                    { 749, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(6435), true, false, 93, 1, 57, 50, null, null },
                    { 750, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(6438), true, false, 93, 3, 11, 50, null, null },
                    { 751, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(8267), true, false, 94, 1, 56, 50, null, null },
                    { 752, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(8270), true, false, 94, 3, 14, 50, null, null },
                    { 753, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(9439), true, false, 95, 1, 56, 50, null, null },
                    { 754, null, new DateTime(2025, 9, 21, 22, 36, 37, 364, DateTimeKind.Local).AddTicks(9441), true, false, 95, 3, 11, 50, null, null },
                    { 755, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(420), true, false, 96, 1, 59, 50, null, null },
                    { 756, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(422), true, false, 96, 3, 14, 50, null, null },
                    { 757, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(1445), true, false, 97, 1, 52, 50, null, null },
                    { 758, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(1447), true, false, 97, 3, 14, 50, null, null },
                    { 759, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(2132), true, false, 98, 1, 53, 50, null, null },
                    { 760, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(2133), true, false, 98, 3, 11, 50, null, null },
                    { 761, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(2670), true, false, 99, 1, 55, 50, null, null },
                    { 762, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(2670), true, false, 99, 3, 11, 50, null, null },
                    { 763, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(3177), true, false, 100, 1, 52, 50, null, null },
                    { 764, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(3177), true, false, 100, 3, 11, 50, null, null },
                    { 765, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(3694), true, false, 101, 1, 52, 50, null, null },
                    { 766, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(3695), true, false, 101, 3, 14, 50, null, null },
                    { 767, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(4174), true, false, 102, 1, 57, 50, null, null },
                    { 768, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(4174), true, false, 102, 3, 14, 50, null, null },
                    { 769, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(4733), true, false, 103, 1, 53, 50, null, null },
                    { 770, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(4733), true, false, 103, 3, 14, 50, null, null },
                    { 771, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(5243), true, false, 104, 1, 52, 50, null, null },
                    { 772, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(5243), true, false, 104, 3, 14, 50, null, null },
                    { 773, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(5810), true, false, 105, 1, 53, 50, null, null },
                    { 774, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(5811), true, false, 105, 3, 11, 50, null, null },
                    { 775, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(6340), true, false, 106, 1, 61, 50, null, null },
                    { 776, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(6341), true, false, 106, 3, 14, 50, null, null },
                    { 777, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(6891), true, false, 107, 1, 52, 50, null, null },
                    { 778, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(6892), true, false, 107, 3, 14, 50, null, null },
                    { 779, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(7445), true, false, 108, 1, 58, 50, null, null },
                    { 780, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(7446), true, false, 108, 3, 14, 50, null, null },
                    { 781, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(8087), true, false, 109, 1, 56, 50, null, null },
                    { 782, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(8088), true, false, 109, 3, 11, 50, null, null },
                    { 783, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(8667), true, false, 110, 1, 62, 50, null, null },
                    { 784, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(8668), true, false, 110, 3, 14, 50, null, null },
                    { 785, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(9280), true, false, 111, 1, 52, 50, null, null },
                    { 786, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(9281), true, false, 111, 3, 14, 50, null, null },
                    { 787, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(9869), true, false, 112, 1, 63, 50, null, null },
                    { 788, null, new DateTime(2025, 9, 21, 22, 36, 37, 365, DateTimeKind.Local).AddTicks(9870), true, false, 112, 3, 14, 50, null, null },
                    { 789, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(933), true, false, 113, 1, 52, 50, null, null },
                    { 790, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(936), true, false, 113, 3, 11, 50, null, null },
                    { 791, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(1547), true, false, 114, 1, 52, 50, null, null },
                    { 792, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(1548), true, false, 114, 3, 14, 50, null, null },
                    { 793, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(2085), true, false, 115, 1, 52, 50, null, null },
                    { 794, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(2086), true, false, 115, 3, 11, 50, null, null },
                    { 795, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(2703), true, false, 116, 1, 52, 50, null, null },
                    { 796, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(2704), true, false, 116, 3, 14, 50, null, null },
                    { 797, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(3246), true, false, 117, 1, 52, 50, null, null },
                    { 798, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(3247), true, false, 117, 3, 11, 50, null, null },
                    { 799, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(4270), true, false, 118, 1, 61, 50, null, null },
                    { 800, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(4274), true, false, 118, 3, 14, 50, null, null },
                    { 801, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(5236), true, false, 119, 1, 52, 50, null, null },
                    { 802, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(5237), true, false, 119, 3, 14, 50, null, null },
                    { 803, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(5912), true, false, 120, 1, 52, 50, null, null },
                    { 804, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(5913), true, false, 120, 3, 14, 50, null, null },
                    { 805, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(6580), true, false, 121, 1, 52, 50, null, null },
                    { 806, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(6581), true, false, 121, 3, 11, 50, null, null },
                    { 807, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(7210), true, false, 122, 1, 53, 50, null, null },
                    { 808, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(7211), true, false, 122, 3, 11, 50, null, null },
                    { 809, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(7863), true, false, 123, 1, 52, 50, null, null },
                    { 810, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(7864), true, false, 123, 3, 14, 50, null, null },
                    { 811, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(8427), true, false, 124, 1, 57, 50, null, null },
                    { 812, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(8428), true, false, 124, 3, 14, 50, null, null },
                    { 813, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(9014), true, false, 125, 1, 52, 50, null, null },
                    { 814, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(9015), true, false, 125, 3, 14, 50, null, null },
                    { 815, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(9569), true, false, 126, 1, 56, 50, null, null },
                    { 816, null, new DateTime(2025, 9, 21, 22, 36, 37, 366, DateTimeKind.Local).AddTicks(9570), true, false, 126, 3, 14, 50, null, null },
                    { 817, null, new DateTime(2025, 9, 21, 22, 36, 37, 367, DateTimeKind.Local).AddTicks(151), true, false, 127, 1, 52, 50, null, null },
                    { 818, null, new DateTime(2025, 9, 21, 22, 36, 37, 367, DateTimeKind.Local).AddTicks(152), true, false, 127, 3, 11, 50, null, null },
                    { 819, null, new DateTime(2025, 9, 21, 22, 36, 37, 367, DateTimeKind.Local).AddTicks(1004), true, false, 128, 1, 52, 50, null, null },
                    { 820, null, new DateTime(2025, 9, 21, 22, 36, 37, 367, DateTimeKind.Local).AddTicks(1006), true, false, 128, 3, 14, 50, null, null },
                    { 821, null, new DateTime(2025, 9, 21, 22, 36, 37, 367, DateTimeKind.Local).AddTicks(1944), true, false, 129, 1, 53, 50, null, null },
                    { 822, null, new DateTime(2025, 9, 21, 22, 36, 37, 367, DateTimeKind.Local).AddTicks(1945), true, false, 129, 3, 11, 50, null, null },
                    { 823, null, new DateTime(2025, 9, 21, 22, 36, 37, 367, DateTimeKind.Local).AddTicks(2618), true, false, 130, 1, 53, 50, null, null },
                    { 824, null, new DateTime(2025, 9, 21, 22, 36, 37, 367, DateTimeKind.Local).AddTicks(3201), true, false, 131, 1, 53, 50, null, null },
                    { 825, null, new DateTime(2025, 9, 21, 22, 36, 37, 367, DateTimeKind.Local).AddTicks(4503), true, false, 132, 1, 53, 50, null, null },
                    { 826, null, new DateTime(2025, 9, 21, 22, 36, 37, 367, DateTimeKind.Local).AddTicks(5651), true, false, 133, 1, 53, 50, null, null },
                    { 827, null, new DateTime(2025, 9, 21, 22, 36, 37, 367, DateTimeKind.Local).AddTicks(6373), true, false, 134, 1, 53, 50, null, null },
                    { 828, null, new DateTime(2025, 9, 21, 22, 36, 37, 367, DateTimeKind.Local).AddTicks(6954), true, false, 135, 1, 53, 50, null, null },
                    { 829, null, new DateTime(2025, 9, 21, 22, 36, 37, 367, DateTimeKind.Local).AddTicks(7493), true, false, 136, 1, 53, 50, null, null },
                    { 830, null, new DateTime(2025, 9, 21, 22, 36, 37, 367, DateTimeKind.Local).AddTicks(8011), true, false, 137, 1, 53, 50, null, null },
                    { 831, null, new DateTime(2025, 9, 21, 22, 36, 37, 367, DateTimeKind.Local).AddTicks(8591), true, false, 138, 1, 53, 50, null, null },
                    { 832, null, new DateTime(2025, 9, 21, 22, 36, 37, 367, DateTimeKind.Local).AddTicks(9099), true, false, 139, 1, 53, 50, null, null },
                    { 833, null, new DateTime(2025, 9, 21, 22, 36, 37, 367, DateTimeKind.Local).AddTicks(9665), true, false, 140, 1, 53, 50, null, null },
                    { 834, null, new DateTime(2025, 9, 21, 22, 36, 37, 368, DateTimeKind.Local).AddTicks(6252), true, false, 141, 1, 65, 50, null, null },
                    { 835, null, new DateTime(2025, 9, 21, 22, 36, 37, 368, DateTimeKind.Local).AddTicks(6770), true, false, 142, 1, 65, 50, null, null },
                    { 836, null, new DateTime(2025, 9, 21, 22, 36, 37, 368, DateTimeKind.Local).AddTicks(7270), true, false, 143, 1, 65, 50, null, null },
                    { 837, null, new DateTime(2025, 9, 21, 22, 36, 37, 368, DateTimeKind.Local).AddTicks(7782), true, false, 144, 1, 65, 50, null, null },
                    { 838, null, new DateTime(2025, 9, 21, 22, 36, 37, 368, DateTimeKind.Local).AddTicks(8278), true, false, 145, 1, 65, 50, null, null },
                    { 839, null, new DateTime(2025, 9, 21, 22, 36, 37, 368, DateTimeKind.Local).AddTicks(8769), true, false, 146, 1, 66, 50, null, null },
                    { 840, null, new DateTime(2025, 9, 21, 22, 36, 37, 368, DateTimeKind.Local).AddTicks(9296), true, false, 147, 1, 66, 50, null, null },
                    { 841, null, new DateTime(2025, 9, 21, 22, 36, 37, 368, DateTimeKind.Local).AddTicks(9800), true, false, 148, 1, 66, 50, null, null },
                    { 842, null, new DateTime(2025, 9, 21, 22, 36, 37, 369, DateTimeKind.Local).AddTicks(291), true, false, 149, 1, 66, 50, null, null },
                    { 843, null, new DateTime(2025, 9, 21, 22, 36, 37, 369, DateTimeKind.Local).AddTicks(810), true, false, 150, 1, 66, 50, null, null },
                    { 844, null, new DateTime(2025, 9, 21, 22, 36, 37, 369, DateTimeKind.Local).AddTicks(1288), true, false, 151, 1, 53, 50, null, null },
                    { 845, null, new DateTime(2025, 9, 21, 22, 36, 37, 369, DateTimeKind.Local).AddTicks(1789), true, false, 152, 1, 53, 50, null, null },
                    { 846, null, new DateTime(2025, 9, 21, 22, 36, 37, 369, DateTimeKind.Local).AddTicks(2429), true, false, 153, 1, 53, 50, null, null },
                    { 847, null, new DateTime(2025, 9, 21, 22, 36, 37, 369, DateTimeKind.Local).AddTicks(3311), true, false, 154, 1, 53, 50, null, null },
                    { 848, null, new DateTime(2025, 9, 21, 22, 36, 37, 369, DateTimeKind.Local).AddTicks(3907), true, false, 155, 1, 53, 50, null, null },
                    { 849, null, new DateTime(2025, 9, 21, 22, 36, 37, 369, DateTimeKind.Local).AddTicks(4447), true, false, 156, 1, 53, 50, null, null },
                    { 850, null, new DateTime(2025, 9, 21, 22, 36, 37, 369, DateTimeKind.Local).AddTicks(4968), true, false, 157, 1, 53, 50, null, null },
                    { 851, null, new DateTime(2025, 9, 21, 22, 36, 37, 369, DateTimeKind.Local).AddTicks(5499), true, false, 158, 1, 53, 50, null, null },
                    { 852, null, new DateTime(2025, 9, 21, 22, 36, 37, 369, DateTimeKind.Local).AddTicks(5989), true, false, 159, 1, 53, 50, null, null },
                    { 853, null, new DateTime(2025, 9, 21, 22, 36, 37, 369, DateTimeKind.Local).AddTicks(6510), true, false, 160, 1, 53, 50, null, null },
                    { 854, null, new DateTime(2025, 9, 21, 22, 36, 37, 369, DateTimeKind.Local).AddTicks(6970), true, false, 161, 1, 65, 50, null, null },
                    { 855, null, new DateTime(2025, 9, 21, 22, 36, 37, 369, DateTimeKind.Local).AddTicks(8112), true, false, 162, 1, 65, 50, null, null },
                    { 856, null, new DateTime(2025, 9, 21, 22, 36, 37, 369, DateTimeKind.Local).AddTicks(8756), true, false, 163, 1, 65, 50, null, null },
                    { 857, null, new DateTime(2025, 9, 21, 22, 36, 37, 369, DateTimeKind.Local).AddTicks(9268), true, false, 164, 1, 65, 50, null, null },
                    { 858, null, new DateTime(2025, 9, 21, 22, 36, 37, 369, DateTimeKind.Local).AddTicks(9782), true, false, 165, 1, 65, 50, null, null },
                    { 859, null, new DateTime(2025, 9, 21, 22, 36, 37, 370, DateTimeKind.Local).AddTicks(278), true, false, 166, 1, 66, 50, null, null },
                    { 860, null, new DateTime(2025, 9, 21, 22, 36, 37, 370, DateTimeKind.Local).AddTicks(775), true, false, 167, 1, 66, 50, null, null },
                    { 861, null, new DateTime(2025, 9, 21, 22, 36, 37, 370, DateTimeKind.Local).AddTicks(1294), true, false, 168, 1, 66, 50, null, null },
                    { 862, null, new DateTime(2025, 9, 21, 22, 36, 37, 370, DateTimeKind.Local).AddTicks(1789), true, false, 169, 1, 66, 50, null, null },
                    { 863, null, new DateTime(2025, 9, 21, 22, 36, 37, 370, DateTimeKind.Local).AddTicks(2552), true, false, 170, 1, 66, 50, null, null },
                    { 864, null, new DateTime(2025, 9, 21, 22, 36, 37, 370, DateTimeKind.Local).AddTicks(3316), true, false, 171, 1, 53, 50, null, null },
                    { 865, null, new DateTime(2025, 9, 21, 22, 36, 37, 370, DateTimeKind.Local).AddTicks(4618), true, false, 172, 1, 53, 50, null, null },
                    { 866, null, new DateTime(2025, 9, 21, 22, 36, 37, 370, DateTimeKind.Local).AddTicks(5835), true, false, 173, 1, 53, 50, null, null },
                    { 867, null, new DateTime(2025, 9, 21, 22, 36, 37, 370, DateTimeKind.Local).AddTicks(6555), true, false, 174, 1, 53, 50, null, null },
                    { 868, null, new DateTime(2025, 9, 21, 22, 36, 37, 370, DateTimeKind.Local).AddTicks(7141), true, false, 175, 1, 53, 50, null, null },
                    { 869, null, new DateTime(2025, 9, 21, 22, 36, 37, 370, DateTimeKind.Local).AddTicks(7645), true, false, 176, 1, 53, 50, null, null },
                    { 870, null, new DateTime(2025, 9, 21, 22, 36, 37, 370, DateTimeKind.Local).AddTicks(8135), true, false, 177, 1, 53, 50, null, null },
                    { 871, null, new DateTime(2025, 9, 21, 22, 36, 37, 370, DateTimeKind.Local).AddTicks(8629), true, false, 178, 1, 53, 50, null, null },
                    { 872, null, new DateTime(2025, 9, 21, 22, 36, 37, 370, DateTimeKind.Local).AddTicks(9144), true, false, 179, 1, 53, 50, null, null },
                    { 873, null, new DateTime(2025, 9, 21, 22, 36, 37, 370, DateTimeKind.Local).AddTicks(9619), true, false, 180, 1, 53, 50, null, null },
                    { 874, null, new DateTime(2025, 9, 21, 22, 36, 37, 371, DateTimeKind.Local).AddTicks(83), true, false, 181, 1, 65, 50, null, null },
                    { 875, null, new DateTime(2025, 9, 21, 22, 36, 37, 371, DateTimeKind.Local).AddTicks(562), true, false, 182, 1, 65, 50, null, null },
                    { 876, null, new DateTime(2025, 9, 21, 22, 36, 37, 371, DateTimeKind.Local).AddTicks(1037), true, false, 183, 1, 65, 50, null, null },
                    { 877, null, new DateTime(2025, 9, 21, 22, 36, 37, 371, DateTimeKind.Local).AddTicks(1535), true, false, 184, 1, 65, 50, null, null },
                    { 878, null, new DateTime(2025, 9, 21, 22, 36, 37, 371, DateTimeKind.Local).AddTicks(1988), true, false, 185, 1, 65, 50, null, null },
                    { 879, null, new DateTime(2025, 9, 21, 22, 36, 37, 371, DateTimeKind.Local).AddTicks(2459), true, false, 186, 1, 66, 50, null, null },
                    { 880, null, new DateTime(2025, 9, 21, 22, 36, 37, 371, DateTimeKind.Local).AddTicks(2946), true, false, 187, 1, 66, 50, null, null },
                    { 881, null, new DateTime(2025, 9, 21, 22, 36, 37, 371, DateTimeKind.Local).AddTicks(5851), true, false, 188, 1, 66, 50, null, null },
                    { 882, null, new DateTime(2025, 9, 21, 22, 36, 37, 371, DateTimeKind.Local).AddTicks(6797), true, false, 189, 1, 66, 50, null, null },
                    { 883, null, new DateTime(2025, 9, 21, 22, 36, 37, 371, DateTimeKind.Local).AddTicks(7637), true, false, 190, 1, 66, 50, null, null },
                    { 884, null, new DateTime(2025, 9, 21, 22, 36, 37, 371, DateTimeKind.Local).AddTicks(8500), true, false, 191, 1, 65, 50, null, null },
                    { 885, null, new DateTime(2025, 9, 21, 22, 36, 37, 371, DateTimeKind.Local).AddTicks(9284), true, false, 192, 1, 65, 50, null, null },
                    { 886, null, new DateTime(2025, 9, 21, 22, 36, 37, 372, DateTimeKind.Local).AddTicks(91), true, false, 193, 1, 65, 50, null, null },
                    { 887, null, new DateTime(2025, 9, 21, 22, 36, 37, 372, DateTimeKind.Local).AddTicks(901), true, false, 194, 1, 65, 50, null, null },
                    { 888, null, new DateTime(2025, 9, 21, 22, 36, 37, 372, DateTimeKind.Local).AddTicks(1705), true, false, 195, 1, 65, 50, null, null },
                    { 889, null, new DateTime(2025, 9, 21, 22, 36, 37, 372, DateTimeKind.Local).AddTicks(2505), true, false, 196, 1, 66, 50, null, null },
                    { 890, null, new DateTime(2025, 9, 21, 22, 36, 37, 372, DateTimeKind.Local).AddTicks(3300), true, false, 197, 1, 66, 50, null, null },
                    { 891, null, new DateTime(2025, 9, 21, 22, 36, 37, 372, DateTimeKind.Local).AddTicks(4146), true, false, 198, 1, 66, 50, null, null },
                    { 892, null, new DateTime(2025, 9, 21, 22, 36, 37, 372, DateTimeKind.Local).AddTicks(4988), true, false, 199, 1, 66, 50, null, null },
                    { 893, null, new DateTime(2025, 9, 21, 22, 36, 37, 372, DateTimeKind.Local).AddTicks(5866), true, false, 200, 1, 66, 50, null, null },
                    { 894, null, new DateTime(2025, 9, 21, 22, 36, 37, 372, DateTimeKind.Local).AddTicks(6954), true, false, 192, 1, 52, 50, null, null },
                    { 895, null, new DateTime(2025, 9, 21, 22, 36, 37, 372, DateTimeKind.Local).AddTicks(7651), true, false, 193, 1, 52, 50, null, null },
                    { 896, null, new DateTime(2025, 9, 21, 22, 36, 37, 372, DateTimeKind.Local).AddTicks(8178), true, false, 194, 1, 52, 50, null, null },
                    { 897, null, new DateTime(2025, 9, 21, 22, 36, 37, 372, DateTimeKind.Local).AddTicks(8676), true, false, 195, 1, 52, 50, null, null },
                    { 898, null, new DateTime(2025, 9, 21, 22, 36, 37, 372, DateTimeKind.Local).AddTicks(9164), true, false, 196, 1, 52, 50, null, null },
                    { 899, null, new DateTime(2025, 9, 21, 22, 36, 37, 372, DateTimeKind.Local).AddTicks(9650), true, false, 197, 1, 67, 50, null, null },
                    { 900, null, new DateTime(2025, 9, 21, 22, 36, 37, 373, DateTimeKind.Local).AddTicks(166), true, false, 198, 1, 52, 50, null, null },
                    { 901, null, new DateTime(2025, 9, 21, 22, 36, 37, 373, DateTimeKind.Local).AddTicks(634), true, false, 199, 1, 52, 50, null, null },
                    { 902, null, new DateTime(2025, 9, 21, 22, 36, 37, 373, DateTimeKind.Local).AddTicks(1130), true, false, 200, 1, 52, 50, null, null },
                    { 903, null, new DateTime(2025, 9, 21, 22, 36, 37, 373, DateTimeKind.Local).AddTicks(1610), true, false, 201, 1, 52, 50, null, null },
                    { 904, null, new DateTime(2025, 9, 21, 22, 36, 37, 373, DateTimeKind.Local).AddTicks(2082), true, false, 202, 1, 56, 50, null, null },
                    { 905, null, new DateTime(2025, 9, 21, 22, 36, 37, 373, DateTimeKind.Local).AddTicks(2541), true, false, 203, 1, 52, 50, null, null },
                    { 906, null, new DateTime(2025, 9, 21, 22, 36, 37, 373, DateTimeKind.Local).AddTicks(2997), true, false, 204, 1, 52, 50, null, null },
                    { 907, null, new DateTime(2025, 9, 21, 22, 36, 37, 373, DateTimeKind.Local).AddTicks(3529), true, false, 205, 1, 52, 50, null, null },
                    { 908, null, new DateTime(2025, 9, 21, 22, 36, 37, 373, DateTimeKind.Local).AddTicks(4012), true, false, 206, 1, 72, 50, null, null },
                    { 909, null, new DateTime(2025, 9, 21, 22, 36, 37, 373, DateTimeKind.Local).AddTicks(6995), true, false, 207, 1, 52, 50, null, null },
                    { 910, null, new DateTime(2025, 9, 21, 22, 36, 37, 373, DateTimeKind.Local).AddTicks(7683), true, false, 208, 1, 56, 50, null, null },
                    { 911, null, new DateTime(2025, 9, 21, 22, 36, 37, 373, DateTimeKind.Local).AddTicks(8289), true, false, 209, 1, 73, 50, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditCards_OrderId",
                table: "CreditCards",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditCards_UserId",
                table: "CreditCards",
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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "CreditCards");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "ProductProperties");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

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
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "PropertyTypes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
