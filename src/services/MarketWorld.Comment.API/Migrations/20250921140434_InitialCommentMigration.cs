using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketWorld.Comment.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommentMigration : Migration
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
                    { 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6746), true, false, "Apple", null, null },
                    { 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6756), true, false, "Asus", null, null },
                    { 3, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6757), true, false, "Casper", null, null },
                    { 4, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6759), true, false, "HP", null, null },
                    { 5, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6760), true, false, "Lenovo", null, null },
                    { 6, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6763), true, false, "MSI", null, null },
                    { 7, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6764), true, false, "Acer", null, null },
                    { 8, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6765), true, false, "Xiaomi", null, null },
                    { 9, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6767), true, false, "Samsung", null, null },
                    { 10, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6769), true, false, "Huawei", null, null },
                    { 11, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6770), true, false, "Canon", null, null },
                    { 12, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6772), true, false, "Epson", null, null },
                    { 13, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6773), true, false, "Honor", null, null },
                    { 14, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6774), true, false, "Nothing", null, null },
                    { 15, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6776), true, false, "Infinix", null, null },
                    { 16, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6785), true, false, "Redmi", null, null },
                    { 17, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6786), true, false, "POCO", null, null },
                    { 18, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6789), true, false, "Oppo", null, null },
                    { 19, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6790), true, false, "Panasonic", null, null },
                    { 20, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6792), true, false, "Reeder", null, null },
                    { 21, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6793), true, false, "Tecno", null, null },
                    { 22, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6794), true, false, "Arçelik", null, null },
                    { 23, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6795), true, false, "Kumtel", null, null },
                    { 24, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6797), true, false, "Regal", null, null },
                    { 25, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6849), true, false, "Profilo", null, null },
                    { 26, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6850), true, false, "Altus", null, null },
                    { 27, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6852), true, false, "Hoover", null, null },
                    { 28, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6853), true, false, "Uğur", null, null },
                    { 29, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6855), true, false, "Arnell", null, null },
                    { 30, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6856), true, false, "Evora", null, null },
                    { 31, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6857), true, false, "Albergio", null, null },
                    { 32, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6859), true, false, "Kiwi", null, null },
                    { 33, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6860), true, false, "Vestel", null, null },
                    { 34, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6862), true, false, "Airfel", null, null },
                    { 35, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6863), true, false, "Regal", null, null },
                    { 36, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6864), true, false, "Kumtel", null, null },
                    { 37, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6871), true, false, "Bosch", null, null },
                    { 38, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6872), true, false, "Kaira", null, null },
                    { 39, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6874), true, false, "Xiaomi", null, null },
                    { 40, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6875), true, false, "Mirkraft", null, null },
                    { 41, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6876), true, false, "Samsung", null, null },
                    { 42, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6880), true, false, "Arnell", null, null },
                    { 43, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6882), true, false, "Zeeful", null, null },
                    { 44, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6883), true, false, "Beko", null, null },
                    { 45, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6884), true, false, "Arçelik", null, null },
                    { 46, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6886), true, false, "Baymak", null, null },
                    { 47, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6887), true, false, "FujiPlus", null, null },
                    { 48, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6888), true, false, "UFO", null, null },
                    { 49, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6889), true, false, "Abbruch", null, null },
                    { 50, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6891), true, false, "Sinbo", null, null },
                    { 51, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6892), true, false, "Magiceham", null, null },
                    { 52, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6893), true, false, "Demirdöküm", null, null },
                    { 53, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6895), true, false, "Tekdal", null, null },
                    { 54, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6896), true, false, "Raks", null, null },
                    { 55, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6898), true, false, "Hubstein", null, null },
                    { 56, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6899), true, false, "Mitsubishi", null, null },
                    { 57, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6904), true, false, "Goldsun", null, null },
                    { 58, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6905), true, false, "Multiteknik", null, null },
                    { 59, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6907), true, false, "Bayırtech", null, null },
                    { 60, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6908), true, false, "Harlem", null, null },
                    { 61, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6909), true, false, "Veito", null, null },
                    { 62, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6911), true, false, "Torima", null, null },
                    { 63, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6913), true, false, "Kiwi", null, null },
                    { 64, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6914), true, false, "Xnews", null, null },
                    { 65, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6915), true, false, "Hotic", null, null },
                    { 66, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6918), true, false, "Derilax", null, null },
                    { 67, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6919), true, false, "Ispartalılar", null, null },
                    { 68, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6920), true, false, "Selin Soylu", null, null },
                    { 69, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6922), true, false, "Sebago", null, null },
                    { 70, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6923), true, false, "Lumberjack", null, null },
                    { 71, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6924), true, false, "Dakirs", null, null },
                    { 72, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6925), true, false, "Letoon", null, null },
                    { 73, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6927), true, false, "Avva", null, null },
                    { 74, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6934), true, false, "Rmk", null, null },
                    { 75, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6935), true, false, "Tamer Tanca", null, null },
                    { 76, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6936), true, false, "Black Vein", null, null },
                    { 77, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6938), true, false, "Cabani", null, null },
                    { 78, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6939), true, false, "Dockers", null, null },
                    { 79, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6940), true, false, "Dgn", null, null },
                    { 80, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6943), true, false, "Hons", null, null },
                    { 81, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6945), true, false, "Daxtors", null, null },
                    { 82, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6946), true, false, "Tonny Black", null, null },
                    { 83, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6948), true, false, "Ayakkabıx", null, null },
                    { 84, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6991), true, false, "Hammer Jack", null, null },
                    { 85, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6993), true, false, "Kaptan Junior", null, null },
                    { 86, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6994), true, false, "Calvin Klein", null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsActive", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(5142), "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar", true, false, "Elektronik", "elektronik", null, null },
                    { 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(5271), "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları", true, false, "Giyim & Aksesuar", "giyim-aksesuar", null, null },
                    { 3, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(5272), "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili", true, false, "Ev & Yaşam", "ev-yasam", null, null },
                    { 4, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(5274), "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri", true, false, "Kozmetik & Kişisel Bakım", "kozmetik-kisisel-bakim", null, null },
                    { 5, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(5276), "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri", true, false, "Spor & Outdoor", "spor-outdoor", null, null }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsActive", "IsDeleted", "Name", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(1980), "Ürün Renk Seçenekleri", true, false, "Renk", null, null },
                    { 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(1985), "Beden Seçenekleri", true, false, "Beden", null, null },
                    { 3, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(1987), "Dahili Hafıza", true, false, "Hafıza", null, null },
                    { 4, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(1989), "Bilgisayar İşlemci Seçenekleri", true, false, "İşlemci", null, null },
                    { 5, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(1991), "Bellek Kapasitesi", true, false, "RAM", null, null },
                    { 6, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(1994), "SSD Kapasitesi", true, false, "SSD", null, null },
                    { 7, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(1996), "Ekran Boyutu", true, false, "Ekran", null, null },
                    { 8, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(1998), "Yazıcı Teknolojisi", true, false, "Yazıcı Tipi", null, null },
                    { 9, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2000), "Mürekkep/Kartuş Sistemi", true, false, "Mürekkep Sistemi", null, null },
                    { 10, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2003), "Desteklenen Kağıt Boyutları", true, false, "Kağıt Boyutu", null, null },
                    { 11, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2005), "Yazıcı Fonksiyonları", true, false, "Fonksiyonlar", null, null }
                });

            migrationBuilder.InsertData(
                table: "PropertyValues",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "PropertyTypeId", "UpdatedById", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2047), true, false, 1, null, null, "Uzay Siyahı" },
                    { 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2051), true, false, 1, null, null, "Altın" },
                    { 3, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2053), true, false, 1, null, null, "Gümüş" },
                    { 4, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2054), true, false, 1, null, null, "Mor" },
                    { 5, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2056), true, false, 2, null, null, "XS" },
                    { 6, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2059), true, false, 2, null, null, "S" },
                    { 7, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2061), true, false, 2, null, null, "M" },
                    { 8, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2062), true, false, 2, null, null, "L" },
                    { 9, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2064), true, false, 2, null, null, "XL" },
                    { 10, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2067), true, false, 2, null, null, "XXL" },
                    { 11, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2069), true, false, 3, null, null, "128GB" },
                    { 12, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2071), true, false, 3, null, null, "256GB" },
                    { 13, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2072), true, false, 3, null, null, "512GB" },
                    { 14, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2126), true, false, 3, null, null, "1TB" },
                    { 15, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2129), true, false, 4, null, null, "Intel Core i7 12700H" },
                    { 16, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2130), true, false, 4, null, null, "Intel Core i7 1255U" },
                    { 17, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2132), true, false, 4, null, null, "Intel Core i7 13620H" },
                    { 18, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2135), true, false, 4, null, null, "Intel Core i5 1334U" },
                    { 19, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2136), true, false, 4, null, null, "Intel Core i5 13420H" },
                    { 20, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2138), true, false, 4, null, null, "AMD Ryzen 7 5700U" },
                    { 21, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2140), true, false, 4, null, null, "Intel Core i5 12450H" },
                    { 22, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2141), true, false, 5, null, null, "8GB" },
                    { 23, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2143), true, false, 5, null, null, "16GB" },
                    { 24, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2144), true, false, 5, null, null, "32GB" },
                    { 25, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2146), true, false, 6, null, null, "256GB" },
                    { 26, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2148), true, false, 6, null, null, "500GB" },
                    { 27, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2149), true, false, 6, null, null, "512GB" },
                    { 28, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2151), true, false, 6, null, null, "1TB" },
                    { 29, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2152), true, false, 7, null, null, "14\"" },
                    { 30, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2154), true, false, 7, null, null, "15.6\"" },
                    { 31, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2156), true, false, 7, null, null, "16\"" },
                    { 32, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2157), true, false, 4, null, null, "Intel Core i7 13650HX" },
                    { 33, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2159), true, false, 4, null, null, "Intel Core i5 13500H" },
                    { 34, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2161), true, false, 4, null, null, "Intel Core i9-14900HX" },
                    { 35, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2164), true, false, 4, null, null, "Intel Core Ultra 7 255HX" },
                    { 36, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2165), true, false, 4, null, null, "AMD Ryzen 5 7520U" },
                    { 37, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2167), true, false, 8, null, null, "Mürekkep Püskürtmeli" },
                    { 38, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2168), true, false, 8, null, null, "Lazer" },
                    { 39, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2170), true, false, 8, null, null, "Süblimasyon" },
                    { 40, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2171), true, false, 9, null, null, "Kartuşlu" },
                    { 41, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2173), true, false, 9, null, null, "Tanklı" },
                    { 42, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2174), true, false, 9, null, null, "Dolum Üniteli" },
                    { 43, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2176), true, false, 10, null, null, "A4" },
                    { 44, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2177), true, false, 10, null, null, "A3" },
                    { 45, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2179), true, false, 10, null, null, "A4/A3" },
                    { 46, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2181), true, false, 11, null, null, "Yazdırma" },
                    { 47, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2182), true, false, 11, null, null, "Tarama" },
                    { 48, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2184), true, false, 11, null, null, "Fotokopi" },
                    { 49, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2185), true, false, 11, null, null, "Faks" },
                    { 50, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2187), true, false, 11, null, null, "Wi-Fi" },
                    { 51, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2188), true, false, 11, null, null, "AirPrint" },
                    { 52, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2190), true, false, 1, null, null, "Siyah" },
                    { 53, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2193), true, false, 1, null, null, "Beyaz" },
                    { 54, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2194), true, false, 1, null, null, "Gri" },
                    { 55, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2196), true, false, 1, null, null, "Açık Mavi" },
                    { 56, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2197), true, false, 1, null, null, "Lacivert" },
                    { 57, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2199), true, false, 1, null, null, "Mavi" },
                    { 58, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2200), true, false, 1, null, null, "Mor" },
                    { 59, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2202), true, false, 1, null, null, "Altın" },
                    { 60, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2203), true, false, 1, null, null, "Nane Yeşili" },
                    { 61, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2205), true, false, 1, null, null, "Zümrüt Yeşili" },
                    { 62, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2207), true, false, 1, null, null, "Lacivert Taş" },
                    { 63, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2208), true, false, 1, null, null, "Natürel Titanyum" },
                    { 64, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2210), true, false, 1, null, null, "Grafit" },
                    { 65, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2211), true, false, 1, null, null, "Antrasit" },
                    { 66, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2214), true, false, 1, null, null, "Inox" },
                    { 67, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2262), true, false, 1, null, null, "Kırmızı" },
                    { 68, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2264), true, false, 1, null, null, "Turkuaz" },
                    { 69, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2266), true, false, 1, null, null, "Pembe" },
                    { 70, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2267), true, false, 1, null, null, "Turuncu" },
                    { 71, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2269), true, false, 1, null, null, "Sarı" },
                    { 72, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2270), true, false, 1, null, null, "Kahverengi" },
                    { 73, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(2272), true, false, 1, null, null, "Bej" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedDate", "Description", "IsActive", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6582), "Dizüstü, masaüstü bilgisayarlar ve tabletler", null, false, "Bilgisayarlar & Tabletler", "bilgisayarlar-tabletler", null, null },
                    { 2, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6585), "Yazıcılar, tarayıcılar ve projeksiyon cihazları", null, false, "Yazıcılar & Projeksiyon", "yazicilar-projeksiyon", null, null },
                    { 3, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6586), "Akıllı telefonlar ve aksesuarları", null, false, "Telefonlar", "telefonlar", null, null },
                    { 4, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6588), "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar", null, false, "Beyaz Eşya", "beyaz-esya", null, null },
                    { 5, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6590), "Klimalar, ısıtıcılar ve hava temizleyiciler", null, false, "Klima ve Isıtıcılar", "klima-isitici", null, null },
                    { 6, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6592), "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar", null, false, "Ayakkabı & Çanta", "ayakkabi-canta", null, null },
                    { 7, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6594), "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim", null, false, "Kadın Giyim", "kadin-giyim", null, null },
                    { 8, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6596), "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim", null, false, "Erkek Giyim", "erkek-giyim", null, null },
                    { 9, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6599), "Kız ve erkek çocuk giyim ürünleri", null, false, "Çocuk Giyim", "cocuk-giyim", null, null },
                    { 10, 3, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6604), "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları", null, false, "Mobilya", "mobilya", null, null },
                    { 11, 3, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6606), "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri", null, false, "Ev Tekstili", "ev-tekstili", null, null },
                    { 12, 3, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6608), "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri", null, false, "Dekorasyon & Aydınlatma", "dekorasyon-aydinlatma", null, null },
                    { 13, 3, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6612), "Pişirme, servis ve saklama ürünleri, mutfak aletleri", null, false, "Mutfak Gereçleri", "mutfak-gerecleri", null, null },
                    { 14, 3, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6614), "Banyo aksesuarları, temizlik ve düzenleme ürünleri", null, false, "Banyo & Ev Gereçleri", "banyo-ev-gerecleri", null, null },
                    { 15, 3, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6616), "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri", null, false, "Kırtasiye & Ofis", "kirtasiye-ve-ofis", null, null },
                    { 16, 4, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6617), "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri", null, false, "Parfüm & Deodorant", "parfum-deodorant", null, null },
                    { 17, 4, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6626), "Saç bakım ve şekillendirme ürünleri", null, false, "Saç Şekillendirme", "sac-sekillendirme", null, null },
                    { 18, 4, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6628), "Yüz ve vücut bakım ürünleri, kremler ve serumlar", null, false, "Cilt Bakımı", "cilt-bakimi", null, null },
                    { 19, 4, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6629), "Renkli kozmetik ve makyaj malzemeleri", null, false, "Makyaj", "makyaj", null, null },
                    { 20, 4, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6631), "Vitamin, takviye gıdalar ve medikal ürünler", null, false, "Sağlık & Medikal Ürünler", "saglik-medikal-urunler", null, null },
                    { 21, 4, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6633), "Diş bakım ürünleri ve ağız bakım ürünleri", null, false, "Ağız & Diş Bakımı", "agiz-dis-bakimi", null, null },
                    { 22, 5, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6635), "Fitness ekipmanları, kondisyon aletleri ve aksesuarları", null, false, "Fitness & Kondisyon", "fitness-kondisyon", null, null },
                    { 23, 5, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6636), "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar", null, false, "Spor Giyim & Ayakkabı", "spor-giyim-ayakkabi", null, null },
                    { 24, 5, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6642), "Kamp malzemeleri, outdoor giyim ve ekipmanlar", null, false, "Outdoor & Kamp", "outdoor-kamp", null, null },
                    { 25, 5, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6644), "Kayak ekipmanları ve kış sporları malzemeleri", null, false, "Kış Sporları", "kis-sporlari", null, null },
                    { 26, 5, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(6645), "Yüzme ve su sporları ekipmanları", null, false, "Su Sporları", "su-sporlari", null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedById", "CreatedDate", "Description", "DiscountPrice", "HasDiscount", "IsActive", "IsDeleted", "Name", "Price", "ProductCode", "Rating", "SubCategoryId", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 3, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7355), "Intel Core i7 12700H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1270", 39999.99m, 808868, 4.5m, 1, null, null },
                    { 2, 6, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7378), "Intel Core i7 1255U 16GB 512GB SSD Freedos 14\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "MSI Modern 14 C12MO", 21799.99m, 805814, 4.5m, 1, null, null },
                    { 3, 3, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7408), "Core i7-13620H 32GB DDR5 RAM 1TB NVME SSD 16\" Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana S100", 27299.99m, 346732, 5m, 1, null, null },
                    { 4, 3, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7415), "Intel Core i7 13620H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1362", 50199.99m, 109978, 4.5m, 1, null, null },
                    { 5, 4, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7454), "Intel Core i5 1334U 16GB 512GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "HP 250 G10", 14999.99m, 973166, 4.7m, 1, null, null },
                    { 6, 5, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7475), "Intel Core i5 13420H 16GB Ddr5 Ram 512 GB SSD 16'' WUXGA IPS Panel Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad Slim 3", 19799.99m, 259468, 4.9m, 1, null, null },
                    { 7, 5, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7485), "AMD Ryzen 7 5700U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad 1", 15999.99m, 432103, 4.6m, 1, null, null },
                    { 8, 6, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7490), "Intel Core i5 12450H 8GB 512GB SSD RTX2050 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "MSI Thin 15", 24799.99m, 978341, 4.5m, 1, null, null },
                    { 9, 3, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7510), "Intel Core i7 1255U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana C550", 18999.99m, 108693, 4.5m, 1, null, null },
                    { 10, 5, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7541), "Intel Core i7 13650HX 32GB 1TB SSD RTX 4060 8GB (115W) 15.6\" FHD 144Hz IPS Panel Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo LOQ 15IRX9", 59999.99m, 389720, 5m, 1, null, null },
                    { 11, 3, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7548), "Intel Core i5-12450H 32GB RAM 500GB SSD GEN4 RTX3050 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G770", 31299.99m, 969074, 4.6m, 1, null, null },
                    { 12, 3, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7567), "AMD Ryzen 5 7430U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana X600", 16999.99m, 246687, 5m, 1, null, null },
                    { 13, 7, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7595), "Intel Core i7 1255U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Acer Aspire 3", 24000.00m, 977490, 5m, 1, null, null },
                    { 14, 3, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7608), "Intel Core i7 12700H 32GB 1TB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana X600.1270", 22999.99m, 709039, 4.5m, 1, null, null },
                    { 15, 3, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7611), "Intel Core i5-13420H 32GB RAM 500GB NVME SSD GEN4 6GB RTX4050 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G870.1342", 38499.99m, 128453, 4.1m, 1, null, null },
                    { 16, 3, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7623), "Intel Core i7 12700H 32GB 1TB SSD RTX4070 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1270", 50899.99m, 205178, 4m, 1, null, null },
                    { 17, 4, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7632), "Intel Core i5 13500H 16GB 512GB SSD RTX4050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "HP Victus Gaming 15", 33999.99m, 384620, 4.6m, 1, null, null },
                    { 18, 5, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7648), "Intel Core i5 12450H 8GB 512GB SSD 15.6\" FHD Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo IdeaPad Slim 3", 15359.04m, 444507, 4.7m, 1, null, null },
                    { 19, 2, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7665), "Intel Core i5 12500H 8GB 512GB SSD RTX3050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Asus TUF Gaming F15", 29898.66m, 561228, 4.7m, 1, null, null },
                    { 20, 1, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7737), "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Uzay Grisi", 0m, false, true, false, "Apple MacBook Air M1", 39250.00m, 882155, 4.9m, 1, null, null },
                    { 21, 3, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7745), "Intel Core i5-13420H 16GB RAM 1TB NVME SSD 8GB RTX4060 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G870.1342", 42299.99m, 969570, 4.3m, 1, null, null },
                    { 22, 5, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7764), "Intel Core i5 13420H 16GB 512GB SSD Freedos 14\" WUXGA Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad 5", 29999.99m, 759204, 5m, 1, null, null },
                    { 23, 2, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7786), "Intel Core Ultra 7 255HX 32GB 1TB SSD RTX5070Ti Freedos 16\" Taşınabilir Bilgisayar", 0m, false, true, false, "Asus ROG Strix G16", 107999.99m, 905090, 5m, 1, null, null },
                    { 24, 3, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7806), "Intel Core i5-13420H 32GB RAM 500GB NVME SSD Freedos", 0m, false, true, false, "Casper Nirvana X600.1342", 19999.99m, 315189, 5m, 1, null, null },
                    { 25, 5, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7817), "Intel Core i9-14900HX 32GB DDR5 1TB SSD RTX4060 8GB 16 inç 3.2K (3200×2000) 165Hz FreeDos Laptop", 0m, false, true, false, "Lenovo Thinkbook 16PG5", 79999.40m, 989843, 4.7m, 1, null, null },
                    { 26, 3, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7876), "Intel Core i7-13620H 16GB RAM 500GB NVME SSD Freedos Laptop", 0m, false, true, false, "Casper Nirvana X600.1362", 22099.99m, 796507, 5m, 1, null, null },
                    { 27, 6, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7883), "Intel Core i5 13420H 16GB 1TB SSD RTX4060 Freedos 15.6\" FHD 144Hz Taşınabilir Bilgisayar", 0m, false, true, false, "MSI CYBORG 15", 37999.99m, 663138, 4.9m, 1, null, null },
                    { 28, 5, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7895), "AMD Ryzen 5 7520U 8gb 512GB SSD Freedos 15.6\" Fhd Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo V15 G4", 13299.99m, 559467, 4.3m, 1, null, null },
                    { 29, 5, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7911), "I5-13420H 32GB 1 Tb SSD 15.6 Fhd Windows 11 Pro", 0m, false, true, false, "Lenovo V15 G4", 27749.00m, 437612, 5m, 1, null, null },
                    { 30, 1, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7916), "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Gece Yarısı", 0m, false, true, false, "Apple MacBook Air M4", 49999.99m, 198538, 5m, 1, null, null },
                    { 31, 3, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7935), "Intel Core i5 12450H 16GB 500GB SSD RTX2050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1245", 27499.99m, 727068, 4.4m, 1, null, null },
                    { 32, 4, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7944), "HP Deskjet Ink Advantage 2878 All-In-One Yazıcı", 0m, false, true, false, "HP Deskjet Ink Advantage 2878 All-In-One Yazıcı", 2799.00m, 303657, 4.1m, 2, null, null },
                    { 33, 11, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7955), "Canon Dolan Kartuşlu E414 Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Canon Dolan Kartuşlu E414 Yazıcı", 2299.08m, 409452, 4.4m, 2, null, null },
                    { 34, 11, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7963), "Canon Pixma TR4650 Tarayıcı + Fotokopi + Wi-Fi + Faks + Çok Fonksiyonlu Yazıcı", 0m, false, true, false, "Canon Pixma TR4650", 3379.00m, 969282, 4.2m, 2, null, null },
                    { 35, 11, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7968), "Canon Pixma E3640 Wi-Fi Tarayıcı - Fotokopi Çok Fonksiyonlu Mürekkep Püskürtmeli Yazıcı", 0m, false, true, false, "Canon Pixma E3640 Wi-Fi", 3399.00m, 799393, 4.6m, 2, null, null },
                    { 36, 12, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(7991), "Epson L5290 Wi-Fi Renk Tanklı Yazıcı", 0m, false, true, false, "Epson L5290 Wi-Fi Renk Tanklı Yazıcı", 11983.51m, 538255, 4.4m, 2, null, null },
                    { 37, 12, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8007), "Epson Tanklı L3150 Photoink Muadil Mürekkepli Tanklı Yazıcı", 0m, false, true, false, "Epson Tanklı L3150 Photoink", 6033.86m, 262182, 4.6m, 2, null, null },
                    { 38, 4, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8013), "HP Officejet Pro 7720 Fotokopi + Faks + Tarayıcı + Wi-Fi + Airprint + A3 Yazıcı", 0m, false, true, false, "HP Officejet Pro 7720", 11138.06m, 424615, 4.6m, 2, null, null },
                    { 39, 11, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8021), "Canon E3640 Wifi Yazıcı ve Tıpalı Kartuş Sistemi", 0m, false, true, false, "Canon E3640 Wifi Yazıcı", 3306.56m, 426810, 4.3m, 2, null, null },
                    { 40, 12, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8031), "Epson L3151 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L3151 Tanklı Yazıcı", 4999.00m, 948675, 4.5m, 2, null, null },
                    { 41, 4, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8043), "HP LaserJet Pro M428f MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428f", 7999.00m, 101617, 4.3m, 2, null, null },
                    { 42, 11, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8049), "Canon PIXMA G3110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G3110", 3999.00m, 743966, 4.4m, 2, null, null },
                    { 43, 12, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8063), "Epson L3250 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L3250 Tanklı Yazıcı", 4499.00m, 634694, 4.6m, 2, null, null },
                    { 44, 4, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8073), "HP LaserJet Pro M428dw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428dw", 8999.00m, 250684, 4.5m, 2, null, null },
                    { 45, 11, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8083), "Canon PIXMA G4110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G4110", 4499.00m, 331557, 4.3m, 2, null, null },
                    { 46, 12, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8086), "Epson L4260 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4260 Tanklı Yazıcı", 5499.00m, 465506, 4.7m, 2, null, null },
                    { 47, 4, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8091), "HP LaserJet Pro M428fnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fnw", 9999.00m, 163519, 4.4m, 2, null, null },
                    { 48, 11, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8116), "Canon PIXMA G5110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G5110", 4999.00m, 183444, 4.5m, 2, null, null },
                    { 49, 12, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8129), "Epson L4266 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4266 Tanklı Yazıcı", 5999.00m, 665239, 4.6m, 2, null, null },
                    { 50, 4, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8137), "HP LaserJet Pro M428fdw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdw", 10999.00m, 340649, 4.5m, 2, null, null },
                    { 51, 11, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8180), "Canon PIXMA G6110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G6110", 5499.00m, 719326, 4.4m, 2, null, null },
                    { 52, 12, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8198), "Epson L4268 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4268 Tanklı Yazıcı", 6499.00m, 766717, 4.7m, 2, null, null },
                    { 53, 4, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8209), "HP LaserJet Pro M428fdn MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdn", 11999.00m, 574373, 4.6m, 2, null, null },
                    { 54, 11, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8216), "Canon PIXMA G7110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G7110", 5999.00m, 270727, 4.5m, 2, null, null },
                    { 55, 12, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8237), "Epson L4269 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4269 Tanklı Yazıcı", 6999.00m, 576278, 4.8m, 2, null, null },
                    { 56, 4, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8246), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 12999.00m, 618945, 4.7m, 2, null, null },
                    { 57, 11, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8258), "Canon PIXMA G8110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G8110", 6499.00m, 613949, 4.6m, 2, null, null },
                    { 58, 12, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8276), "Epson L4267 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4267 Tanklı Yazıcı", 7499.00m, 853520, 4.9m, 2, null, null },
                    { 59, 4, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8285), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 13999.00m, 993633, 4.8m, 2, null, null },
                    { 60, 11, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8295), "Canon PIXMA G9110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G9110", 6999.00m, 432116, 4.7m, 2, null, null },
                    { 61, 12, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8304), "Epson L4265 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4265 Tanklı Yazıcı", 7999.00m, 425266, 4.8m, 2, null, null },
                    { 62, 4, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8310), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 14999.00m, 687560, 4.9m, 2, null, null },
                    { 63, 11, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8321), "Canon PIXMA G1010 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1010", 7499.00m, 268374, 4.8m, 2, null, null },
                    { 64, 12, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8324), "Epson L4264 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4264 Tanklı Yazıcı", 8499.00m, 787522, 4.9m, 2, null, null },
                    { 65, 4, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8330), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 15999.00m, 926291, 5.0m, 2, null, null },
                    { 66, 11, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8362), "Canon PIXMA G1110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1110", 7999.00m, 864163, 4.9m, 2, null, null },
                    { 67, 12, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8374), "Epson L4263 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4263 Tanklı Yazıcı", 8999.00m, 267920, 5.0m, 2, null, null },
                    { 68, 4, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8381), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 16999.00m, 873506, 5.0m, 2, null, null },
                    { 69, 11, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8388), "Canon PIXMA G1210 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1210", 8499.00m, 200299, 5.0m, 2, null, null },
                    { 70, 12, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8394), "Epson L4262 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4262 Tanklı Yazıcı", 9499.00m, 218585, 5.0m, 2, null, null },
                    { 71, 4, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8410), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 17999.00m, 510576, 5.0m, 2, null, null },
                    { 72, 11, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8435), "Canon PIXMA G1310 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1310", 8999.00m, 209884, 5.0m, 2, null, null },
                    { 73, 12, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8458), "Epson L4261 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4261 Tanklı Yazıcı", 9999.00m, 534364, 5.0m, 2, null, null },
                    { 74, 1, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8465), "Apple iPhone 13 128 GB Beyaz", 0m, false, true, false, "Apple iPhone 13 128 GB Beyaz", 100149m, 767581, 4.5m, 3, null, null },
                    { 75, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8473), "Samsung Galaxy A06 128 GB 4 GB RAM Siyah", 0m, false, true, false, "Samsung Galaxy A06 128 GB 4 GB RAM Siyah", 100149m, 296514, 4.0m, 3, null, null },
                    { 76, 1, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8479), "Apple iPhone 13 128 GB Siyah", 0m, false, true, false, "Apple iPhone 13 128 GB Siyah", 33699m, 879122, 4.5m, 3, null, null },
                    { 77, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8500), "Samsung Galaxy A16 128 GB 6 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A16 128 GB 6 GB Ram Siyah", 8789m, 450180, 4.2m, 3, null, null },
                    { 78, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8522), "Samsung Galaxy A35 256 GB 8 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A35 256 GB 8 GB Ram Siyah", 14449m, 855211, 4.3m, 3, null, null },
                    { 79, 13, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8758), "HONOR Magic 7 Lite 256 GB 8 GB Ram Mor", 0m, false, true, false, "HONOR Magic 7 Lite 256 GB 8 GB Ram Mor", 15999m, 386815, 4.4m, 3, null, null },
                    { 80, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8784), "Samsung Galaxy A06 128 GB 4 GB Ram Açık Mavi", 0m, false, true, false, "Samsung Galaxy A06 128 GB 4 GB Ram Açık Mavi", 6303m, 320772, 4.0m, 3, null, null },
                    { 81, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8793), "Samsung Galaxy S24+ 256 GB 12 GB Ram Gri", 0m, false, true, false, "Samsung Galaxy S24+ 256 GB 12 GB Ram Gri", 41599m, 829534, 4.8m, 3, null, null },
                    { 82, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8803), "Samsung Galaxy A16 128 GB 6 GB Ram Gri", 0m, false, true, false, "Samsung Galaxy A16 128 GB 6 GB Ram Gri", 8789m, 729004, 4.2m, 3, null, null },
                    { 83, 13, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8827), "HONOR Magic 7 Lite 256 GB 8 GB Ram Siyah", 0m, false, true, false, "HONOR Magic 7 Lite 256 GB 8 GB Ram Siyah", 15999m, 833259, 4.4m, 3, null, null },
                    { 84, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8834), "Samsung Galaxy S24 FE 128 GB 8 GB Ram Gri", 0m, false, true, false, "Samsung Galaxy S24 FE 128 GB 8 GB Ram Gri", 23849m, 237907, 4.6m, 3, null, null },
                    { 85, 14, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8846), "Nothing Phone 1 256 GB 8 GB Ram Siyah", 0m, false, true, false, "Nothing Phone 1 256 GB 8 GB Ram Siyah", 13999m, 633720, 4.3m, 3, null, null },
                    { 86, 14, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8853), "Nothing Phone (2a) 256 GB 12 GB Ram Beyaz", 0m, false, true, false, "Nothing Phone (2a) 256 GB 12 GB Ram Beyaz", 18999m, 953993, 4.5m, 3, null, null },
                    { 87, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8871), "Samsung Galaxy A35 128 GB 8 GB Ram Açık Mavi", 0m, false, true, false, "Samsung Galaxy A35 128 GB 8 GB Ram Açık Mavi", 13701m, 422097, 4.3m, 3, null, null },
                    { 88, 15, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8878), "Infinix Smart 9 128 GB 4 GB Ram Nane Yeşili", 0m, false, true, false, "Infinix Smart 9 128 GB 4 GB Ram Nane Yeşili", 5499m, 513830, 4.0m, 3, null, null },
                    { 89, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8900), "Samsung Galaxy A55 128 GB 8 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A55 128 GB 8 GB Ram Siyah", 16170m, 354855, 4.4m, 3, null, null },
                    { 90, 14, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8912), "Nothing Phone 2A Plus 256 GB 12 GB Ram Gri", 0m, false, true, false, "Nothing Phone 2A Plus 256 GB 12 GB Ram Gri", 22999m, 333331, 4.5m, 3, null, null },
                    { 91, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8933), "Samsung Galaxy S24 Fe 256 GB 8 GB Ram Grafit", 0m, false, true, false, "Samsung Galaxy S24 Fe 256 GB 8 GB Ram Grafit", 26299m, 390546, 4.6m, 3, null, null },
                    { 92, 1, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8946), "Apple iPhone 16e 128GB Beyaz", 0m, false, true, false, "Apple iPhone 16e 128GB Beyaz", 44799m, 922072, 4.7m, 3, null, null },
                    { 93, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8961), "Samsung Galaxy S24 FE 128 GB 8 GB Ram Mavi", 0m, false, true, false, "Samsung Galaxy S24 FE 128 GB 8 GB Ram Mavi", 23849m, 952990, 4.6m, 3, null, null },
                    { 94, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8975), "Samsung Galaxy S25+ 256 GB 12 GB Ram Lacivert", 0m, false, true, false, "Samsung Galaxy S25+ 256 GB 12 GB Ram Lacivert", 54799m, 464432, 4.8m, 3, null, null },
                    { 95, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(8988), "Samsung B310 Dual Sim Lacivert", 0m, false, true, false, "Samsung B310 Dual Sim Lacivert", 1149m, 714156, 3.5m, 3, null, null },
                    { 96, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9010), "Samsung Galaxy S23 Ultra 512 GB 12 GB Ram Altın", 0m, false, true, false, "Samsung Galaxy S23 Ultra 512 GB 12 GB Ram Altın", 48899m, 881035, 4.9m, 3, null, null },
                    { 97, 16, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9022), "Redmi Note 14 Pro 12GB 512GB", 0m, false, true, false, "Redmi Note 14 Pro 12GB 512GB", 18999m, 283017, 4.4m, 3, null, null },
                    { 98, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9033), "Samsung B310E Dual Sim Kamerasız Cep Telefonu Beyaz", 0m, false, true, false, "Samsung B310E Dual Sim Kamerasız Cep Telefonu Beyaz", 1149m, 482001, 3.5m, 3, null, null },
                    { 99, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9051), "Samsung Galaxy A55 128 GB 8 GB Ram Açık Mavi", 0m, false, true, false, "Samsung Galaxy A55 128 GB 8 GB Ram Açık Mavi", 16507m, 954584, 4.4m, 3, null, null },
                    { 100, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9066), "Samsung Galaxy A35 128 GB 8 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A35 128 GB 8 GB Ram Siyah", 13559m, 275029, 4.3m, 3, null, null },
                    { 101, 16, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9085), "Redmi Note 14 Pro 8GB 256GB", 0m, false, true, false, "Redmi Note 14 Pro 8GB 256GB", 16599m, 383834, 4.4m, 3, null, null },
                    { 102, 1, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9101), "Apple iPhone 15 256 GB Mavi", 0m, false, true, false, "Apple iPhone 15 256 GB Mavi", 55999m, 916088, 4.8m, 3, null, null },
                    { 103, 1, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9178), "Apple iPhone 16 Pro 256GB Beyaz", 0m, false, true, false, "Apple iPhone 16 Pro 256GB Beyaz", 84599m, 360594, 4.9m, 3, null, null },
                    { 104, 8, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9191), "Xiaomi 14T Pro 12GB 512GB", 0m, false, true, false, "Xiaomi 14T Pro 12GB 512GB", 41000m, 958844, 4.5m, 3, null, null },
                    { 105, 1, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9197), "Apple iPhone 16 Pro 128GB Beyaz", 0m, false, true, false, "Apple iPhone 16 Pro 128GB Beyaz", 78499m, 206057, 4.8m, 3, null, null },
                    { 106, 13, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9207), "HONOR 200 512 GB 12 GB Ram Zümrüt Yeşili", 0m, false, true, false, "HONOR 200 512 GB 12 GB Ram Zümrüt Yeşili", 23999m, 229621, 0m, 3, null, null },
                    { 107, 1, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9223), "Apple iPhone 16 Pro 256GB Siyah", 0m, false, true, false, "Apple iPhone 16 Pro 256GB Siyah", 88825m, 907591, 0m, 3, null, null },
                    { 108, 16, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9231), "Xiaomi Redmi Note 13 Pro 256GB 8gb Ram Mor", 0m, false, true, false, "Xiaomi Redmi Note 13 Pro 256GB 8gb Ram Mor", 15999m, 420269, 0m, 3, null, null },
                    { 109, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9242), "Samsung Galaxy S25 128 GB 12 GB Ram Lacivert", 0m, false, true, false, "Samsung Galaxy S25 128 GB 12 GB Ram Lacivert", 45999m, 496713, 0m, 3, null, null },
                    { 110, 1, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9250), "Apple iPhone 16 256GB Lacivert Taş", 0m, false, true, false, "Apple iPhone 16 256GB Lacivert Taş", 66999m, 173279, 0m, 3, null, null },
                    { 111, 16, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9274), "Xiaomi Redmi Note 14 Pro Plus 5g 512 GB 12 GB Ram", 0m, false, true, false, "Xiaomi Redmi Note 14 Pro Plus 5g 512 GB 12 GB Ram", 27250m, 579489, 0m, 3, null, null },
                    { 112, 1, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9327), "Apple iPhone 16 Pro Max 512GB Natürel Titanyum", 0m, false, true, false, "Apple iPhone 16 Pro Max 512GB Natürel Titanyum", 101939m, 663498, 0m, 3, null, null },
                    { 113, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9334), "Samsung Galaxy A04S 64 GB Siyah", 0m, false, true, false, "Samsung Galaxy A04S 64 GB Siyah", 6839m, 309643, 0m, 3, null, null },
                    { 114, 16, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9337), "Redmi Note 14 Pro 5G 12GB 512GB", 0m, false, true, false, "Redmi Note 14 Pro 5G 12GB 512GB", 22500m, 373753, 0m, 3, null, null },
                    { 115, 14, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9342), "Nothing Phone 1 128 GB 8 GB Ram Siyah", 0m, false, true, false, "Nothing Phone 1 128 GB 8 GB Ram Siyah", 12999m, 777838, 0m, 3, null, null },
                    { 116, 16, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9349), "Xiaomi Redmi Note 13 Pro 512GB 12GB Siyah", 0m, false, true, false, "Xiaomi Redmi Note 13 Pro 512GB 12GB Siyah", 18999m, 227813, 0m, 3, null, null },
                    { 117, 16, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9358), "Xiaomi Redmi 12 128 GB 8 GB Ram Siyah", 0m, false, true, false, "Xiaomi Redmi 12 128 GB 8 GB Ram Siyah", 8190m, 889025, 0m, 3, null, null },
                    { 118, 13, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9363), "HONOR Magic V3 512 GB 12 GB Ram Yeşil", 0m, false, true, false, "HONOR Magic V3 512 GB 12 GB Ram Yeşil", 79999m, 731328, 0m, 3, null, null },
                    { 119, 21, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9368), "Tecno Spark 30 256 GB 8 GB Ram", 0m, false, true, false, "Tecno Spark 30 256 GB 8 GB Ram", 9199m, 889560, 0m, 3, null, null },
                    { 120, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9372), "Samsung Galaxy S25 Ultra 1 Tb 12 GB Ram", 0m, false, true, false, "Samsung Galaxy S25 Ultra 1 Tb 12 GB Ram", 88999m, 611597, 0m, 3, null, null },
                    { 121, 1, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9387), "Apple iPhone 16 Pro 128GB Siyah", 0m, false, true, false, "Apple iPhone 16 Pro 128GB Siyah", 79324m, 549060, 0m, 3, null, null },
                    { 122, 20, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9401), "Reeder P13 Blue Max L 2022 64 GB Beyaz", 0m, false, true, false, "Reeder P13 Blue Max L 2022 64 GB Beyaz", 3399m, 357928, 0m, 3, null, null },
                    { 123, 17, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9405), "POCO X7 12GB 512GB", 0m, false, true, false, "POCO X7 12GB 512GB", 17499m, 301266, 0m, 3, null, null },
                    { 124, 18, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9417), "Oppo A60 8GB 256GB Mavi", 0m, false, true, false, "Oppo A60 8GB 256GB Mavi", 10199m, 656849, 0m, 3, null, null },
                    { 125, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9420), "Samsung Galaxy A25 5G 256 GB 8 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A25 5G 256 GB 8 GB Ram Siyah", 13250m, 575286, 0m, 3, null, null },
                    { 126, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9445), "Samsung Galaxy S25 256 GB Lacivert", 0m, false, true, false, "Samsung Galaxy S25 256 GB Lacivert", 47670m, 915101, 0m, 3, null, null },
                    { 127, 19, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9448), "Panasonic KX-TU550EXB Katlanabilir Renkli Ekran 4g Tuşlu Cep Telefonu Siyah", 0m, false, true, false, "Panasonic KX-TU550EXB Katlanabilir Renkli Ekran 4g Tuşlu Cep Telefonu Siyah", 4269m, 432045, 0m, 3, null, null },
                    { 128, 20, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9458), "Reeder S19 Max Pro 256 GB 6 GB Ram Siyah", 0m, false, true, false, "Reeder S19 Max Pro 256 GB 6 GB Ram Siyah", 4799m, 192081, 0m, 3, null, null },
                    { 129, 9, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9484), "Samsung B310E Cep Telefonu Beyaz", 0m, false, true, false, "Samsung B310E Cep Telefonu Beyaz", 1149m, 372380, 3.5m, 3, null, null },
                    { 130, 22, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9529), "Arçelik 6167 6 Programlı Beyaz Bulaşık Makinesi", 0m, false, true, false, "Arçelik 6167 6 Programlı Beyaz Bulaşık Makinesi", 25739.01m, 472877, 4.5m, 4, null, null },
                    { 131, 23, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9539), "Kumtel Beyaz Cam Digital / Dokunmatik Ankastre Set - 8 Programlı (KO-40 TAHDF Ocak B66-Sf2 Ddt Fırın DA6-835 Davlumbaz)", 0m, false, true, false, "Kumtel Beyaz Cam Digital / Dokunmatik Ankastre Set", 11299m, 940236, 4.1m, 4, null, null },
                    { 132, 24, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9556), "Regal Bm 310 3 Programlı Bulaşık Makinesi", 0m, false, true, false, "Regal Bm 310 3 Programlı Bulaşık Makinesi", 11549m, 310297, 4.6m, 4, null, null },
                    { 133, 25, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9568), "Profilo BM6320MA D Enerji Sınıfı 6 Programlı Bulaşık Makinesi", 0m, false, true, false, "Profilo BM6320MA D Enerji Sınıfı 6 Programlı Bulaşık Makinesi", 15999m, 869067, 4.7m, 4, null, null },
                    { 134, 26, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9572), "Altus AL 7103 MD 1000 Devir 7 kg Çamaşır Makinesi", 0m, false, true, false, "Altus AL 7103 MD 1000 Devir 7 kg Çamaşır Makinesi", 12479m, 843147, 4.6m, 4, null, null },
                    { 135, 26, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9583), "Altus AL 10123 D C Enerji 10 Kg Çamaşır Makinesi", 0m, false, true, false, "Altus AL 10123 D C Enerji 10 Kg Çamaşır Makinesi", 17028m, 690045, 4.7m, 4, null, null },
                    { 136, 27, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9586), "Hoover NDEH 10A2TSBE-17 10 kg Wi-Fi + Bluetooth Bağlantılı Isı Pompalı Kurutma Makinesi", 0m, false, true, false, "Hoover NDEH 10A2TSBE-17 10 kg Isı Pompalı Kurutma Makinesi", 14999m, 637688, 4.5m, 4, null, null },
                    { 137, 22, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9648), "Arçelik 7103 D 7 Kg 1000 Devir Çamaşır Makinesi", 0m, false, true, false, "Arçelik 7103 D 7 Kg 1000 Devir Çamaşır Makinesi", 14999m, 678818, 4.5m, 4, null, null },
                    { 138, 28, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9652), "Uğur UES 507 D/S 3 Kapılı No-Frost Buzdolabı", 0m, false, true, false, "Uğur UES 507 D/S 3 Kapılı No-Frost Buzdolabı", 29999m, 455779, 4.3m, 4, null, null },
                    { 139, 33, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9669), "Vestel NF480 EX A++ Siyah 453 Lt No-Frost Buzdolabı", 0m, false, true, false, "Vestel NF480 EX Siyah No-Frost Buzdolabı", 23599m, 342940, 4.4m, 4, null, null },
                    { 140, 24, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9694), "Regal 90 LT A+ Mini Buzdolabı", 0m, false, true, false, "Regal 90 LT A+ Mini Buzdolabı", 6499m, 991800, 4.6m, 4, null, null },
                    { 141, 29, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9707), "Arnell Ankastre Set (8665 MDOC Ankastre Fırın + 1140-CSBDF 4 Gözlü Ocak + DS3490EC / EC3490 Davlumbaz)", 0m, false, true, false, "Arnell Ankastre Set", 13499m, 154807, 4.2m, 4, null, null },
                    { 142, 30, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9714), "Evora 3'lü Siyah Cam Ankastre Set (EAF-6056 Fırın + EAO-8505 Ocak + EAD-9263 Davlumbaz)", 0m, false, true, false, "Evora Siyah Cam Set", 10990m, 423313, 4.1m, 4, null, null },
                    { 143, 31, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9741), "Albergio AL-FO-005-E Ankastre Fırın", 0m, false, true, false, "Albergio AL-FO-005-E Ankastre Fırın", 5499m, 374694, 4.0m, 4, null, null },
                    { 144, 32, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9760), "Kiwi KSW-4215 Beyaz Soğuk Su Sebili", 0m, false, true, false, "Kiwi KSW-4215 Beyaz Soğuk Su Sebili", 1299m, 717700, 3.9m, 4, null, null },
                    { 145, 33, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9790), "Vestel SP 100 Beyaz Soğuk Su Sebili", 0m, false, true, false, "Vestel SP 100 Beyaz Soğuk Su Sebili", 1499m, 152123, 4.0m, 4, null, null },
                    { 146, 22, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9801), "Arçelik 1100 S Beyaz Su Sebili", 0m, false, true, false, "Arçelik 1100 S Beyaz Su Sebili", 1999m, 280103, 4.2m, 4, null, null },
                    { 147, 25, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9880), "Profilo SP 100 Sıcak/Soğuk Su Sebili", 0m, false, true, false, "Profilo SP 100 Sıcak/Soğuk Su Sebili", 2299m, 539784, 4.3m, 4, null, null },
                    { 148, 22, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9906), "Arçelik 5500 BT Mini Fırın - 15 Litre", 0m, false, true, false, "Arçelik 5500 BT Mini Fırın", 4999m, 473402, 4.5m, 4, null, null },
                    { 149, 23, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9917), "Kumtel KF3150 Mini Fırın - 36 Litre Beyaz", 0m, false, true, false, "Kumtel KF3150 Mini Fırın", 2699m, 619707, 4.3m, 4, null, null },
                    { 150, 33, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9942), "Vestel R8080 Retro Buzdolabı - Kırmızı", 0m, false, true, false, "Vestel R8080 Retro Buzdolabı", 28900m, 174353, 4.7m, 4, null, null },
                    { 151, 22, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9965), "Arçelik 9144 YI Ultra Hijyen 9 Kg 1400 Devir Çamaşır Makinesi", 0m, false, true, false, "Arçelik 9144 YI Ultra Hijyen 9 Kg Çamaşır Makinesi", 21950m, 660446, 4.8m, 4, null, null },
                    { 152, 25, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 770, DateTimeKind.Local).AddTicks(9993), "Profilo CGA242X1TR A++ 9 Kg 1200 Devir Çamaşır Makinesi", 0m, false, true, false, "Profilo CGA242X1TR A++ 9 Kg Çamaşır Makinesi", 18999m, 270389, 4.5m, 4, null, null },
                    { 153, 24, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(5), "Regal Pratik 2000 Toz Torbasız Elektrikli Süpürge", 0m, false, true, false, "Regal Pratik 2000 Elektrikli Süpürge", 2999m, 178915, 4.2m, 4, null, null },
                    { 154, 33, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(26), "Vestel BM 5201 X EKO PLUS Bulaşık Makinesi", 0m, false, true, false, "Vestel EKO PLUS Bulaşık Makinesi", 12999m, 152638, 4.3m, 4, null, null },
                    { 155, 22, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(40), "Arçelik K 3290 Telve Otomatik Türk Kahve Makinesi - Siyah", 0m, false, true, false, "Arçelik K 3290 Telve Türk Kahve Makinesi", 3299m, 752828, 4.9m, 4, null, null },
                    { 156, 26, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(61), "Altus AL 413 E 4 Programlı Bulaşık Makinesi", 0m, false, true, false, "Altus AL 413 E 4 Programlı Bulaşık Makinesi", 13499m, 781373, 4.1m, 4, null, null },
                    { 157, 27, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(96), "Hoover HLWOQ 59B-S 9 Kg Çamaşır Kurutma Makinesi", 0m, false, true, false, "Hoover HLWOQ 59B-S Çamaşır Kurutma Makinesi", 17999m, 803340, 4.4m, 4, null, null },
                    { 158, 33, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(102), "Vestel MAYA 10100 ST 10 Kg 1000 Devir Çamaşır Makinesi", 0m, false, true, false, "Vestel MAYA 10100 ST Çamaşır Makinesi", 14599m, 685054, 4.5m, 4, null, null },
                    { 159, 34, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(111), "Airfel LTXM35N 12000 BTU R32 Inverter Duvar Tipi Klima", 0m, false, true, false, "Airfel LTXM35N 12000 BTU R32 Inverter Duvar Tipi Klima", 25541.01m, 818084, 4.6m, 5, null, null },
                    { 160, 35, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(115), "Regal Luna A++ 15000 BTU Inverter Duvar Tipi Klima", 0m, false, true, false, "Regal Luna A++ 15000 BTU Inverter Duvar Tipi Klima", 26499m, 282282, 4.6m, 5, null, null },
                    { 161, 36, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(126), "Kumtel Bej Fanlı Isıtıcı 2000 W LX - 6331", 0m, false, true, false, "Kumtel Bej Fanlı Isıtıcı 2000 W LX - 6331", 509m, 817458, 4.2m, 5, null, null },
                    { 162, 37, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(139), "Bosch Climate CL2000U W 35 E A++ 12000 BTU Duvar Tipi Klima", 0m, false, true, false, "Bosch Climate CL2000U W 35 E A++ 12000 BTU Duvar Tipi Klima", 26999m, 662759, 4.4m, 5, null, null },
                    { 163, 38, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(169), "Kaira DTXR35E A++ 12000 BTU Wifi Inverter Duvar Tipi Klima (Montaj Dahil)", 0m, false, true, false, "Kaira DTXR35E A++ 12000 BTU Wifi Inverter Duvar Tipi Klima", 25840m, 452748, 4.4m, 5, null, null },
                    { 164, 36, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(187), "Kumtel Juniper Portatif Taşınabilir Klima Kmpac-7", 0m, false, true, false, "Kumtel Juniper Portatif Taşınabilir Klima Kmpac-7", 9999m, 111161, 4.3m, 5, null, null },
                    { 165, 33, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(214), "Vestel Flora Doğa 124 A++ Wifi 12000 BTU Inverter Duvar Tipi Klima", 0m, false, true, false, "Vestel Flora Doğa 124 A++ Wifi 12000 BTU Inverter Duvar Tipi Klima", 26235m, 378100, 4.6m, 5, null, null },
                    { 166, 39, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(227), "Xiaomi ZMYDFS01DM Şarj Edilebilir Mini Fan", 0m, false, true, false, "Xiaomi ZMYDFS01DM Şarj Edilebilir Mini Fan", 1889m, 417165, 5m, 5, null, null },
                    { 167, 36, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(248), "Kumtel LX-2832 Siyah 1500 Watt Isıtıcı", 0m, false, true, false, "Kumtel LX-2832 Siyah 1500 Watt Isıtıcı", 549m, 210873, 4.5m, 5, null, null },
                    { 168, 40, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(269), "Mirkraft Future 2500 Watt Elektrikli Isıtıcı - IP24 - LCD Ekran - Uzaktan Kumandalı - 4 Isı Ayarı", 0m, false, true, false, "Mirkraft Future 2500 Watt Elektrikli Isıtıcı", 5559.66m, 192165, 5m, 5, null, null },
                    { 169, 41, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(295), "Samsung Premium AR18TSHZHWK A++ 18000 BTU Inverter Duvar Tipi Klima", 0m, false, true, false, "Samsung Premium AR18TSHZHWK A++ 18000 BTU Inverter Duvar Tipi Klima", 38599m, 923206, 4.4m, 5, null, null },
                    { 170, 42, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(393), "Arnell Elektrikli Isıtıcı Quartz Ev Ve Ofis Oda Tipi 3+1 Çubuklu Güvenli Elektrikli Soba - 2600 Watt", 0m, false, true, false, "Arnell Elektrikli Isıtıcı Quartz", 2218.63m, 948130, 3m, 5, null, null },
                    { 171, 36, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(423), "Kumtel Ks-2760 Quartz Isıtıcı Siyah", 0m, false, true, false, "Kumtel Ks-2760 Quartz Isıtıcı Siyah", 999m, 531174, 4.1m, 5, null, null },
                    { 172, 43, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(436), "Zeeful Süper Güç Üfleyici Mini Turbo Jet Fan 130000RPM 52+M/s 4000MAH (Yurt Dışından)", 0m, false, true, false, "Zeeful Süper Güç Üfleyici Mini Turbo Jet Fan", 1750.32m, 819982, 4.5m, 5, null, null },
                    { 173, 44, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(452), "Beko 31225 Ekolojik A++ 12000 BTU Duvar Tipi Klima", 0m, false, true, false, "Beko 31225 Ekolojik A++ 12000 BTU Duvar Tipi Klima", 27754.65m, 312061, 4.6m, 5, null, null },
                    { 174, 33, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(464), "Vestel Flora Doğa 244 A++ 24000 BTU Wifi Inverter Duvar Tipi Klima", 0m, false, true, false, "Vestel Flora Doğa 244 A++ 24000 BTU Wifi Inverter Duvar Tipi Klima", 42362.10m, 495990, 4.4m, 5, null, null },
                    { 175, 45, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(479), "Arçelik Ekolojik 18325 A++ 18000 BTU Inverter Duvar Tipi Klima", 0m, false, true, false, "Arçelik Ekolojik 18325 A++ 18000 BTU Inverter Duvar Tipi Klima", 39897m, 266737, 4.4m, 5, null, null },
                    { 176, 42, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(492), "Arnell Elektrikli Isıtıcı Duvar Tip Soba 3000 Watt", 0m, false, true, false, "Arnell Elektrikli Isıtıcı Duvar Tip Soba", 1431.06m, 909621, 4.8m, 5, null, null },
                    { 177, 46, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(514), "Baymak Elegant Plus UV 18 A++ (Montaj Dahil) 18000 BTU Duvar Tipi Klima", 0m, false, true, false, "Baymak Elegant Plus UV 18 A++ 18000 BTU Duvar Tipi Klima", 44989m, 704373, 4.4m, 5, null, null },
                    { 178, 47, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(540), "FujiPlus Fujiplus Sakura 12000 Btu Inverter Duvar Tipi Klima", 0m, false, true, false, "FujiPlus Sakura 12000 Btu Inverter Duvar Tipi Klima", 22777.03m, 200825, 3.9m, 5, null, null },
                    { 179, 46, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(555), "Baymak Aqua Konfor 65 Litre Termosifon", 0m, false, true, false, "Baymak Aqua Konfor 65 Litre Termosifon", 8439m, 706507, 4.5m, 5, null, null },
                    { 180, 36, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(562), "Kumtel Ecoray Ex-25 2500 Watt Duvar Tipi Infrared Isıtıcı", 0m, false, true, false, "Kumtel Ecoray Ex-25 2500 Watt Duvar Tipi Infrared Isıtıcı", 886.05m, 662693, 4.3m, 5, null, null },
                    { 181, 48, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(579), "UFO Ufo Star 2400 W Duvar Tipi Isıtıcı - Termostatlı", 0m, false, true, false, "UFO Ufo Star 2400 W Duvar Tipi Isıtıcı", 4190m, 811627, 4.5m, 5, null, null },
                    { 182, 49, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(600), "Abbruch Şarj Edilebilir Taşınabilir Ipli Mini El Fanı Üç Kademe Hızlı Güçlü Soğutucu Pervane Vantilatör", 0m, false, true, false, "Abbruch Şarj Edilebilir Taşınabilir Mini El Fanı", 289.90m, 189897, 4.5m, 5, null, null },
                    { 183, 50, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(621), "Sinbo SF-6783 Vantilatör", 0m, false, true, false, "Sinbo SF-6783 Vantilatör", 1200m, 170790, 3.4m, 5, null, null },
                    { 184, 44, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(641), "Beko 31650 Vantilatör uzaktan kumandalı", 0m, false, true, false, "Beko 31650 Vantilatör", 3259m, 150515, 4.6m, 5, null, null },
                    { 185, 48, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(658), "UFO Ufo Micatronic 1900 W Kule Tipi Isıtıcı", 0m, false, true, false, "UFO Ufo Micatronic 1900 W Kule Tipi Isıtıcı", 4390m, 578525, 4.4m, 5, null, null },
                    { 186, 48, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(673), "UFO Omri 1200 W Termostatlı Hem Yatay Hem Dikey Isıtıcı", 0m, false, true, false, "UFO Omri 1200 W Termostatlı Isıtıcı", 3400m, 936865, 3.9m, 5, null, null },
                    { 187, 38, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(700), "Kaira DTXR71E A++ 24000 BTU Inverter Duvar Tipi Klima (Montaj Dahil)", 0m, false, true, false, "Kaira DTXR71E A++ 24000 BTU Inverter Duvar Tipi Klima", 45250.40m, 644354, 4m, 5, null, null },
                    { 188, 46, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(723), "Baymak Duo Tec Compact Premix 24 kw Yoğuşmalı Kombi (Baca Dahil)", 0m, false, true, false, "Baymak Duo Tec Compact Premix 24 kw Yoğuşmalı Kombi", 27400m, 803589, 4.6m, 5, null, null },
                    { 189, 48, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(760), "UFO ISITICI STAR S/19 1900 W", 0m, false, true, false, "UFO ISITICI STAR S/19 1900 W", 3690m, 133327, 4.4m, 5, null, null },
                    { 190, 51, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(772), "Magiceham Lilo Stitch Peluş Sıcak Su Isıtıcısı - Lacivert (Yurt Dışından)", 0m, false, true, false, "Magiceham Lilo Stitch Peluş Sıcak Su Isıtıcısı", 528.45m, 766580, 4.6m, 5, null, null },
                    { 191, 64, 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(810), "Xnews A Üstü USB Fan Soğutucu Vantilatör Klima USB Girişli Metal Serinlci Fan Mini Vantilatör Fan Klima Fan", 0m, false, true, false, "Xnews A Üstü USB Fan Soğutucu", 269.90m, 647407, 5m, 5, null, null },
                    { 192, 65, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(832), "Lacoste Sport Court-Master Pro Erkek Siyah Sneaker 744SMA0084 02H", 0m, false, true, false, "Lacoste Sport Court-Master Pro Erkek Siyah Sneaker 744SMA0084 02H", 3239.10m, 922173, 4.9m, 6, null, null },
                    { 193, 66, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(847), "Letoon 2104 Günlük Unisex Spor Ayakkabı", 0m, false, true, false, "Letoon 2104 Günlük Unisex Spor Ayakkabı", 564m, 110782, 4.2m, 6, null, null },
                    { 194, 67, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(856), "Derilax Hakiki Deri Tam Ortopedik Erkek Ayakkabı", 0m, false, true, false, "Derilax Hakiki Deri Tam Ortopedik Erkek Ayakkabı", 1200m, 304994, 4.6m, 6, null, null },
                    { 195, 68, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(866), "Hotiç Hakiki Deri Siyah Erkek Günlük Ayakkabı", 0m, false, true, false, "Hotiç Hakiki Deri Siyah Erkek Günlük Ayakkabı", 1679.40m, 687362, 4.1m, 6, null, null },
                    { 196, 69, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(889), "Ispartalılar 7575 Ortopedik Taban Yumuşak Hakiki Deri Mevsimlik Kışlık Erkek Ayakkabı", 0m, false, true, false, "Ispartalılar 7575 Ortopedik Taban Yumuşak Hakiki Deri Mevsimlik Kışlık Erkek Ayakkabı", 670.65m, 161888, 4m, 6, null, null },
                    { 197, 70, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(924), "Under Armour Çocuk Ua Bgs Charged Rogue 4 Koşu Ayakkabısı 3027106-400", 0m, false, true, false, "Under Armour Çocuk Ua Bgs Charged Rogue 4 Koşu Ayakkabısı 3027106-400", 2090m, 241314, 5m, 6, null, null },
                    { 198, 69, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(950), "Ispartalılar 502 Ortopedik Topuk Masajlı Hakiki Deri Kışlık Erkek Ayakkabı Bağcıklı", 0m, false, true, false, "Ispartalılar 502 Ortopedik Topuk Masajlı Hakiki Deri Kışlık Erkek Ayakkabı Bağcıklı", 679.15m, 967293, 4m, 6, null, null },
                    { 199, 71, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(959), "Muggo Samuel Garantili Günlük Klasik Deri Casual Rahat Ortopedik Kalın Taban Erkek Ayakkabı", 0m, false, true, false, "Muggo Samuel Garantili Günlük Klasik Deri Casual Rahat Ortopedik Kalın Taban Erkek Ayakkabı", 899.90m, 229872, 4.5m, 6, null, null },
                    { 200, 72, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(964), "Tomiross Erkek Atlanta Günlük Kullanım Sneaker Ayakkabı ATLNT-5025", 0m, false, true, false, "Tomiross Erkek Atlanta Günlük Kullanım Sneaker Ayakkabı ATLNT-5025", 699.90m, 600550, 4.5m, 6, null, null },
                    { 201, 73, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(977), "Yaya By Hotic 02ayy296160a100 Siyah Erkek Ayakkabı", 0m, false, true, false, "Yaya By Hotic 02ayy296160a100 Siyah Erkek Ayakkabı", 899.90m, 765096, 4.5m, 6, null, null },
                    { 202, 74, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(985), "Hotic Hakiki Deri Lacivert Erkek Günlük Ayakkabı", 0m, false, true, false, "Hotic Hakiki Deri Lacivert Erkek Günlük Ayakkabı", 799.90m, 183125, 4.5m, 6, null, null },
                    { 203, 75, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1062), "Derilax Deri Tam Ortopedik Erkek Ayakkabı", 0m, false, true, false, "Derilax Deri Tam Ortopedik Erkek Ayakkabı", 699.90m, 919040, 4.5m, 6, null, null },
                    { 204, 76, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1076), "Ispartalılar 909 Tam Ortopedik Taban Hakiki Deri Erkek Ayakkabı", 0m, false, true, false, "Ispartalılar 909 Tam Ortopedik Taban Hakiki Deri Erkek Ayakkabı", 599.90m, 703114, 4.5m, 6, null, null },
                    { 205, 77, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1128), "Selin Soylu Hakiki Deri Erkek Ayakkabı Kışlık Günlük Ayakkabı", 0m, false, true, false, "Selin Soylu Hakiki Deri Erkek Ayakkabı Kışlık Günlük Ayakkabı", 499.90m, 129945, 4.5m, 6, null, null },
                    { 206, 78, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1168), "Sebago Nubuk Koyu Kahve Siyah Erkek Günlük Ayakkabı 7111m5w", 0m, false, true, false, "Sebago Nubuk Koyu Kahve Siyah Erkek Günlük Ayakkabı 7111m5w", 399.90m, 594621, 4.5m, 6, null, null },
                    { 207, 79, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1172), "Lumberjack 4m Navigator 4fx", 0m, false, true, false, "Lumberjack 4m Navigator 4fx", 299.90m, 334899, 4.5m, 6, null, null },
                    { 208, 78, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1182), "Sebago Deri Lacivert Erkek Günlük Ayakkabı 70004z0", 0m, false, true, false, "Sebago Deri Lacivert Erkek Günlük Ayakkabı 70004z0", 199.90m, 179304, 4.5m, 6, null, null },
                    { 209, 80, 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1218), "Dakirs Yazlık Erkek Keten Günlük Rahat Hafif Bağcıklı Spor Ayakkabı 40-44", 0m, false, true, false, "Dakirs Yazlık Erkek Keten Günlük Rahat Hafif Bağcıklı Spor Ayakkabı 40-44", 99.90m, 240771, 4.5m, 6, null, null }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "EntityId", "EntityType", "IsDeleted", "Path", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1761), 1, 1, false, "img/Products/Laptops/Casper_G870.1270.jpg", null, null },
                    { 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1812), 2, 1, false, "img/Products/Laptops/MSI_15.6.jpg", null, null },
                    { 3, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1814), 3, 1, false, "img/Products/Laptops/Casper_S100.1362.jpg", null, null },
                    { 4, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1816), 4, 1, false, "img/Products/Laptops/Casper_G870.1362.jpg", null, null },
                    { 5, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1818), 5, 1, false, "img/Products/Laptops/HP_15.6.jpg", null, null },
                    { 6, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1822), 6, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 7, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1824), 7, 1, false, "img/Products/Laptops/Lenovo_model.jpg", null, null },
                    { 8, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1826), 8, 1, false, "img/Products/Laptops/MSI_model.jpg", null, null },
                    { 9, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1827), 9, 1, false, "img/Products/Laptops/Casper_C550.1255.jpg", null, null },
                    { 10, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1837), 10, 1, false, "img/Products/Laptops/Lenovo_3.2.jpg", null, null },
                    { 11, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1839), 11, 1, false, "img/Products/Laptops/Casper_G770.1245.jpg", null, null },
                    { 12, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1841), 12, 1, false, "img/Products/Laptops/Casper_X600.7430.jpg", null, null },
                    { 13, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1843), 13, 1, false, "img/Products/Laptops/Acer_15.6.jpg", null, null },
                    { 14, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1850), 14, 1, false, "img/Products/Laptops/Casper_X600.1270.jpg", null, null },
                    { 15, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1860), 15, 1, false, "img/Products/Laptops/Casper_G870.1342.jpg", null, null },
                    { 16, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1862), 16, 1, false, "img/Products/Laptops/Casper_G870.1270.jpg", null, null },
                    { 17, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1864), 17, 1, false, "img/Products/Laptops/HP_15.6.jpg", null, null },
                    { 18, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1948), 18, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 19, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1950), 19, 1, false, "img/Products/Laptops/Asus_15.6.jpg", null, null },
                    { 20, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1952), 20, 1, false, "img/Products/Laptops/Apple_model.jpg", null, null },
                    { 21, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1954), 21, 1, false, "img/Products/Laptops/Casper_G870.1342.jpg", null, null },
                    { 22, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1956), 22, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 23, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1957), 23, 1, false, "img/Products/Laptops/Asus_model.jpg", null, null },
                    { 24, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1959), 24, 1, false, "img/Products/Laptops/Casper_X600.1342.jpg", null, null },
                    { 25, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1965), 25, 1, false, "img/Products/Laptops/Lenovo_3.2.jpg", null, null },
                    { 26, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1978), 26, 1, false, "img/Products/Laptops/Casper_X600.1362.jpg", null, null },
                    { 27, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1980), 27, 1, false, "img/Products/Laptops/MSI_15.6.jpg", null, null },
                    { 28, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1982), 28, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 29, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1983), 29, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 30, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1985), 30, 1, false, "img/Products/Laptops/Apple_model.jpg", null, null },
                    { 31, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1987), 31, 1, false, "img/Products/Laptops/Casper_G870.1245.jpg", null, null },
                    { 32, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1990), 32, 1, false, "img/Products/PrintersandScanner/hp_hp_deskjet_ink_advantage_2878_allinone_yazc.jpg", null, null },
                    { 33, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1992), 33, 1, false, "img/Products/PrintersandScanner/canon_dolan_kartulu_e414_yazc_tarayc_fotokopi.jpg", null, null },
                    { 34, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1996), 34, 1, false, "img/Products/PrintersandScanner/canon_pixma_tr4650_tarayc_fotokopi_wifi_faks_ok_fonksiyonlu_yazc_canon_eurasia_garantili.jpg", null, null },
                    { 35, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(1998), 35, 1, false, "img/Products/PrintersandScanner/canon_pixma_e3640_wifi_tarayc_fotokopi_ok_fonksiyonlu_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 36, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2000), 36, 1, false, "img/Products/PrintersandScanner/epson_l5290_wifi_renk_tankl_yazc.jpg", null, null },
                    { 37, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2002), 37, 1, false, "img/Products/PrintersandScanner/epson_tankl_l3150_photoink_muadil_mrekkepli_tankl_yazc_1_siyah_mrekkep_ve_fotoraf_kad_hediyeli.jpg", null, null },
                    { 38, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2004), 38, 1, false, "img/Products/PrintersandScanner/hp_officejet_pro_7720_fotokopi_faks_tarayc_wifi_airprint_a3_yazc_y0s18a.jpg", null, null },
                    { 39, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2006), 39, 1, false, "img/Products/PrintersandScanner/canon_e3640_wifi_yazc_ve_tpal_kartu_sistemi.jpg", null, null },
                    { 40, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2008), 40, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_l3250_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 41, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2017), 41, 1, false, "img/Products/PrintersandScanner/enp_canon_mf264dw_lazer_yazc_tarayc_fotokopi_wifi_lan_duplex.jpg", null, null },
                    { 42, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2019), 42, 1, false, "img/Products/PrintersandScanner/canon_pxma_g3430_renkli_mrekkep_mega_tankl_yazc_tarayc_fotokopi_wifi_1_ie_orijinal_siyah_mrekkep_hed.jpg", null, null },
                    { 43, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2021), 43, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_l3250_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 44, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2023), 44, 1, false, "img/Products/PrintersandScanner/canon_isensys_mf453dw_wf_ok_fonksiyonlu_lazer_yazc.jpg", null, null },
                    { 45, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2028), 45, 1, false, "img/Products/PrintersandScanner/canon_pixma_e3440_dolabilen_kartu_sistemli_yazc.jpg", null, null },
                    { 46, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2030), 46, 1, false, "img/Products/PrintersandScanner/epson_l6550_color_tankl_wifi_a4_yazc_fotokopi_tarayc_fax.jpg", null, null },
                    { 47, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2032), 47, 1, false, "img/Products/PrintersandScanner/hp_deskjet_2632_wifi_tarayc_fotokopi_renkli_ok_fonksiyonlu_mrekkep_pskrtmeli_yazc_v1n05b.jpg", null, null },
                    { 48, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2043), 48, 1, false, "img/Products/PrintersandScanner/canon_pixma_e514_fotokopi_tarayc_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 49, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2045), 49, 1, false, "img/Products/PrintersandScanner/epson_epson_ecotank_l11050_a3_tek_fonk_yazici.jpg", null, null },
                    { 50, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2046), 50, 1, false, "img/Products/PrintersandScanner/hp_hp_6uu47a_smart_tank_750_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 51, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2048), 51, 1, false, "img/Products/PrintersandScanner/canon_gx6040_yazctaraycfotokopi_renkli_mrekkep_tankl_yazc_wifi_ethernet.jpg", null, null },
                    { 52, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2050), 52, 1, false, "img/Products/PrintersandScanner/epson_surecolor_sc_f100_mrekkep_pskrtme_sblimasyon_yazc.jpg", null, null },
                    { 53, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2052), 53, 1, false, "img/Products/PrintersandScanner/hp_deskjet_1516_fotokopi_tarayc_yazc_b2l60c.jpg", null, null },
                    { 54, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2054), 54, 1, false, "img/Products/PrintersandScanner/canon_ix6850_renkli_inkjet_a3_fotoraf_yazcswifi_canon_eurasia_garantili.jpg", null, null },
                    { 55, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2055), 55, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 56, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2065), 56, 1, false, "img/Products/PrintersandScanner/hp_officejet_j4500_wifi_faxl_ok_fonksiyonlu_renkli_yazc_cn547a.jpg", null, null },
                    { 57, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2067), 57, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 58, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2073), 58, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_m1170_yazc_a4.jpg", null, null },
                    { 59, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2077), 59, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_wifi_ok_fonksiyonlu_yazc_bitmeyen_kartu_siyah_depo.jpg", null, null },
                    { 60, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2079), 60, 1, false, "img/Products/PrintersandScanner/canon_pixma_mg3050bk_wifi_fotokopi_tarayc_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 61, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2080), 61, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 62, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2093), 62, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 63, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2095), 63, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 64, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2097), 64, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 65, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2099), 65, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 66, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2101), 66, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 67, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2104), 67, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 68, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2108), 68, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 69, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2121), 69, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 70, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2122), 70, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 71, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2124), 71, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 72, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2126), 72, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 73, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2128), 73, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 74, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2131), 74, 1, false, "img/Products/Phones/apple_iphone_13_128_gb_beyaz.jpg", null, null },
                    { 75, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2133), 75, 1, false, "img/Products/Phones/samsung_galaxy_a06_128_gb_4_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 76, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2140), 76, 1, false, "img/Products/Phones/apple_iphone_13_128_gb_siyah.jpg", null, null },
                    { 77, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2144), 77, 1, false, "img/Products/Phones/samsung_galaxy_a16_128_gb_6_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 78, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2145), 78, 1, false, "img/Products/Phones/samsung_galaxy_a35_256_gb_8_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 79, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2226), 79, 1, false, "img/Products/Phones/honor_magic_7_lite_256_gb_8_gb_ram_honor_trkiye_garantili_mor.jpg", null, null },
                    { 80, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2228), 80, 1, false, "img/Products/Phones/samsung_galaxy_a06_128_gb_4_gb_ram_samsung_trkiye_garantili_ak_mavi.jpg", null, null },
                    { 81, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2230), 81, 1, false, "img/Products/Phones/samsung_galaxy_s24_256_gb_12_gb_ram_samsung_trkiye_garantili_gri.jpg", null, null },
                    { 82, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2232), 82, 1, false, "img/Products/Phones/samsung_galaxy_a16_128_gb_6_gb_ram_samsung_trkiye_garantili_gri.jpg", null, null },
                    { 83, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2234), 83, 1, false, "img/Products/Phones/honor_magic_7_lite_256_gb_8_gb_ram_honor_trkiye_garantili_siyah.jpg", null, null },
                    { 84, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2235), 84, 1, false, "img/Products/Phones/samsung_galaxy_s24_fe_128_gb_8_gb_ram_samsung_trkiye_garantili_gri.jpg", null, null },
                    { 85, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2237), 85, 1, false, "img/Products/Phones/nothing_phone_1_256_gb_8_gb_ram_nothing_trkiye_garantili_siyah.jpg", null, null },
                    { 86, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2239), 86, 1, false, "img/Products/Phones/nothing_phone_2a_256_gb_12_gb_ram_nothing_trkiye_garantili_beyaz.jpg", null, null },
                    { 87, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2241), 87, 1, false, "img/Products/Phones/samsung_galaxy_a35_128_gb_8_gb_ram_samsung_trkiye_garantili_ak_mavi.jpg", null, null },
                    { 88, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2251), 88, 1, false, "img/Products/Phones/infinix_infnx_smart_9_128_gb_4_gb_ram_infnx_trkiye_garantili_nane_yeili.jpg", null, null },
                    { 89, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2257), 89, 1, false, "img/Products/Phones/samsung_galaxy_a55_128_gb_8_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 90, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2259), 90, 1, false, "img/Products/Phones/nothing_phone_2a_plus_256_gb_12_gb_ram_nothing_trkiye_garantili_gri.jpg", null, null },
                    { 91, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2261), 91, 1, false, "img/Products/Phones/samsung_galaxy_s24_fe_256_gb_8_gb_ram_samsung_trkiye_garantili_grafit.jpg", null, null },
                    { 92, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2263), 92, 1, false, "img/Products/Phones/apple_iphone_16e_128gb_beyaz.jpg", null, null },
                    { 93, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2265), 93, 1, false, "img/Products/Phones/samsung_galaxy_s24_fe_128_gb_8_gb_ram_samsung_trkiye_garantili_mavi.jpg", null, null },
                    { 94, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2274), 94, 1, false, "img/Products/Phones/samsung_galaxy_s25_256_gb_12_gb_ram_samsung_trkiye_garantili_lacivert.jpg", null, null },
                    { 95, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2276), 95, 1, false, "img/Products/Phones/samsung_b310_dual_sim_lacivert.jpg", null, null },
                    { 96, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2278), 96, 1, false, "img/Products/Phones/samsung_galaxy_s23_ultra_512_gb_12_gb_ram_samsung_trkiye_garantili_altn.jpg", null, null },
                    { 97, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2280), 97, 1, false, "img/Products/Phones/redmi_note_14_pro_12gb_512gb_xiaomi_trkiye_garantili.jpg", null, null },
                    { 98, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2291), 98, 1, false, "img/Products/Phones/samsung_b310_e_dual_sim_kamerasz_cep_telefonu_beyaz.jpg", null, null },
                    { 99, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2293), 99, 1, false, "img/Products/Phones/samsung_galaxy_a55_128_gb_8_gb_ram_samsung_trkiye_garantili_ak_mavi.jpg", null, null },
                    { 100, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2295), 100, 1, false, "img/Products/Phones/samsung_galaxy_a35_128_gb_8_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 101, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2297), 101, 1, false, "img/Products/Phones/redmi_note_14_pro_8gb_256gb_xiaomi_trkiye_garantili.jpg", null, null },
                    { 102, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2303), 102, 1, false, "img/Products/Phones/apple_iphone_15_256_gb_mavi.jpg", null, null },
                    { 103, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2306), 103, 1, false, "img/Products/Phones/apple_iphone_16_pro_256gb_beyaz.jpg", null, null },
                    { 104, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2308), 104, 1, false, "img/Products/Phones/xiaomi_14t_pro_12gb_512gb.jpg", null, null },
                    { 105, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2310), 105, 1, false, "img/Products/Phones/apple_iphone_16_pro_128gb_beyaz.jpg", null, null },
                    { 106, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2312), 106, 1, false, "img/Products/Phones/honor_200_512_gb_12_gb_ram_honor_trkiye_garantili_zmrt_yeili.jpg", null, null },
                    { 107, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2321), 107, 1, false, "img/Products/Phones/apple_iphone_16_pro_256gb_siyah.jpg", null, null },
                    { 108, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2323), 108, 1, false, "img/Products/Phones/xiaomi_redmi_note_13_pro_256gb_8gb_ram_xiaomi_trkiye_garantili_mor.jpg", null, null },
                    { 109, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2325), 109, 1, false, "img/Products/Phones/samsung_galaxy_s25_128_gb_12_gb_ram_samsung_trkiye_garantili_lacivert.jpg", null, null },
                    { 110, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2327), 110, 1, false, "img/Products/Phones/apple_iphone_16_256gb_lacivert_ta.jpg", null, null },
                    { 111, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2328), 111, 1, false, "img/Products/Phones/xiaomi_redmi_note_14_pro_plus_5g_512_gb_12_gb_ram_xiaomi_trkiye_garantili.jpg", null, null },
                    { 112, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2339), 112, 1, false, "img/Products/Phones/apple_iphone_16_pro_max_512gb_natrel_titanyum.jpg", null, null },
                    { 113, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2341), 113, 1, false, "img/Products/Phones/samsung_galaxy_a04s_64_gb_samsung_trkiye_garantili_siyah_64_gb_siyah.jpg", null, null },
                    { 114, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2342), 114, 1, false, "img/Products/Phones/redmi_note_14_pro_5g_12gb_512gb_xiaomi_trkiye_garantili.jpg", null, null },
                    { 115, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2344), 115, 1, false, "img/Products/Phones/nothing_phone_1_128_gb_8_gb_ram_nothing_trkiye_garantili_siyah.jpg", null, null },
                    { 116, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2346), 116, 1, false, "img/Products/Phones/xiaomi_redmi_note_13_pro_512gb_12gb_xiaomi_trkiye_garantili_siyah.jpg", null, null },
                    { 117, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2348), 117, 1, false, "img/Products/Phones/xiaomi_redmi_12_128_gb_8_gb_ram_xiaomi_trkiye_garantili_siyah.jpg", null, null },
                    { 118, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2355), 118, 1, false, "img/Products/Phones/honor_magic_v3_512_gb_12_gb_ram_honor_trkiye_garantili_yeil.jpg", null, null },
                    { 119, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2358), 119, 1, false, "img/Products/Phones/tecno_spark_30_256_gb_8_gb_ram.jpg", null, null },
                    { 120, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2360), 120, 1, false, "img/Products/Phones/samsung_galaxy_s25_ultra_1_tb_12_gb_ram_samsung_trkiye_garantili.jpg", null, null },
                    { 121, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2362), 121, 1, false, "img/Products/Phones/apple_iphone_16_pro_128gb_siyah.jpg", null, null },
                    { 122, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2363), 122, 1, false, "img/Products/Phones/reeder_p13_blue_max_l_2022_64_gb_reeder_trkiye_garantili_beyaz.jpg", null, null },
                    { 123, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2365), 123, 1, false, "img/Products/Phones/poco_poco_x7_12gb_512gb_xiaomi_trkiye_garantili.jpg", null, null },
                    { 124, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2374), 124, 1, false, "img/Products/Phones/oppo_a60_8gb_256gb_oppo_trkiye_garantili_mavi.jpg", null, null },
                    { 125, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2376), 125, 1, false, "img/Products/Phones/samsung_galaxy_a25_5g_256_gb_8_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 126, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2378), 126, 1, false, "img/Products/Phones/samsung_galaxy_s25_256_gb_lacivert.jpg", null, null },
                    { 127, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2381), 127, 1, false, "img/Products/Phones/panasonic_kx-tu550exb_katlanabilir_renkli_ekran_4g_tulu_cep_telefonu_siyah_2_yl_trkiye_distribtr_garantili_siyah.jpg", null, null },
                    { 128, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2385), 128, 1, false, "img/Products/Phones/reeder_s19_max_pro_256_gb_6_gb_ram_reeder_trkiye_garantili_siyah.jpg", null, null },
                    { 129, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2391), 129, 1, false, "img/Products/Phones/samsung_b310e_cep_telefonu_resmi_btk_kaytl2g_ve_3g_hatlar_n_beyaz.jpg", null, null },
                    { 130, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2394), 130, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 131, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2396), 131, 1, false, "img/Products/WhiteGoods/kumtel_kumtel_93l_beyaz_bro_tipi_buzdolab_hmb-110.jpg", null, null },
                    { 132, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2397), 132, 1, false, "img/Products/WhiteGoods/regal_bm_310_3_programl_bulak_makinesi.jpg", null, null },
                    { 133, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2399), 133, 1, false, "img/Products/WhiteGoods/arelik_ade_606_2b_yatk_davlumbaz_karbon_filtre_165732003.jpg", null, null },
                    { 134, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2407), 134, 1, false, "img/Products/WhiteGoods/altus_al_7103_md_1000_devir_7_kg_amar_makinesi.jpg", null, null },
                    { 135, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2411), 135, 1, false, "img/Products/WhiteGoods/altus_al_10123_d_c_enerji_10_kg_amar_makinesi.jpg", null, null },
                    { 136, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2413), 136, 1, false, "img/Products/WhiteGoods/hoover_ndeh_10a2tsbe-17_10_kg_wi-fi_bluetooth_balantl_is_pompal_kurutma_makinesi.jpg", null, null },
                    { 137, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2484), 137, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 138, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2486), 138, 1, false, "img/Products/WhiteGoods/samsung_ww11bga046aeah_11_kg_1400_devir_amar_makinesi.jpg", null, null },
                    { 139, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2488), 139, 1, false, "img/Products/WhiteGoods/vestel_sp_202-a_su_sebili.jpg", null, null },
                    { 140, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2490), 140, 1, false, "img/Products/WhiteGoods/regal_st_30010_242_lt_statik_buzdolab.jpg", null, null },
                    { 141, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2492), 141, 1, false, "img/Products/WhiteGoods/arelik_yeni_model_gri_buhar_destekli_cam_ankastre_set.jpg", null, null },
                    { 142, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2494), 142, 1, false, "img/Products/WhiteGoods/evora_sanayi_tipi_100_lt_soutmal_artmal_paslanmaz_endstriyel_su_sebili.jpg", null, null },
                    { 143, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2496), 143, 1, false, "img/Products/WhiteGoods/albergio_cam_damacana_kapakl_su_sebil_15_lt_tm_sebillere_uyumlu.jpg", null, null },
                    { 144, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2518), 144, 1, false, "img/Products/WhiteGoods/kiwi_kwp_8520_standl_su_pompas-beyaz.jpg", null, null },
                    { 145, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2520), 145, 1, false, "img/Products/WhiteGoods/vestel_sp_202-a_su_sebili.jpg", null, null },
                    { 146, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2521), 146, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 147, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2523), 147, 1, false, "img/Products/WhiteGoods/samsung_ww11bb534dabah_11_kg_1400_devir_bespoke_amar_makinesi_spacemax_ai_kontrol_paneli.jpg", null, null },
                    { 148, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2525), 148, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 149, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2527), 149, 1, false, "img/Products/WhiteGoods/kumtel_kumtel_93l_beyaz_bro_tipi_buzdolab_hmb-110.jpg", null, null },
                    { 150, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2529), 150, 1, false, "img/Products/WhiteGoods/vestel_sp_202-a_su_sebili.jpg", null, null },
                    { 151, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2531), 151, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 152, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2533), 152, 1, false, "img/Products/WhiteGoods/samsung_ww11bb534dabah_11_kg_1400_devir_bespoke_amar_makinesi_spacemax_ai_kontrol_paneli.jpg", null, null },
                    { 153, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2536), 153, 1, false, "img/Products/WhiteGoods/regal_bm_310_3_programl_bulak_makinesi.jpg", null, null },
                    { 154, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2537), 154, 1, false, "img/Products/WhiteGoods/vestel_sp_202-a_su_sebili.jpg", null, null },
                    { 155, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2540), 155, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 156, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2542), 156, 1, false, "img/Products/WhiteGoods/altus_al_7103_md_1000_devir_7_kg_amar_makinesi.jpg", null, null },
                    { 157, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2544), 157, 1, false, "img/Products/WhiteGoods/altus_al_7103_md_1000_devir_7_kg_amar_makinesi.jpg", null, null },
                    { 158, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2550), 158, 1, false, "img/Products/WhiteGoods/altus_al_7103_md_1000_devir_7_kg_amar_makinesi.jpg", null, null },
                    { 159, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2551), 159, 1, false, "img/Products/AirConditionerandHeater/airfel_ltxm35n_12000_btu_r32_inverter_duvar_tipi_klima.jpg", null, null },
                    { 160, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2562), 160, 1, false, "img/Products/AirConditionerandHeater/regal_luna_a_15000_btu_inverte_duvar_tipi_klima.jpg", null, null },
                    { 161, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2564), 161, 1, false, "img/Products/AirConditionerandHeater/kumtel_bej_fanl_istc_2000_w_lx_-_6331.jpg", null, null },
                    { 162, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2568), 162, 1, false, "img/Products/AirConditionerandHeater/bosch_climate_cl2000u_w_35_e_a_12000_btu_duvar_tipi_klima.jpg", null, null },
                    { 163, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2569), 163, 1, false, "img/Products/AirConditionerandHeater/kaira_dtxr35e_a_12000_btu_wifi_inverter_duvar_tipi_klima_montaj_dahil.jpg", null, null },
                    { 164, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2575), 164, 1, false, "img/Products/AirConditionerandHeater/kumtel_juniper_portatif_tanabilir_klima_kmpac-7.jpg", null, null },
                    { 165, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2577), 165, 1, false, "img/Products/AirConditionerandHeater/vestel_flora_doa_124_a_wifi_12000_btu_inverter_duvar_tipi_klima.jpg", null, null },
                    { 166, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2585), 166, 1, false, "img/Products/AirConditionerandHeater/xiaomi_zmydfs01dm_arj_edilebilir_mini_fan.jpg", null, null },
                    { 167, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2593), 167, 1, false, "img/Products/AirConditionerandHeater/kumtel_lx-2832_siyah_1500_watt_istc.jpg", null, null },
                    { 168, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2594), 168, 1, false, "img/Products/AirConditionerandHeater/mirkraft_future_2500_watt_elektrikli_istc_-_ip24_-_lcd_ekran_-_uzaktan_kumandal_-_4_is_ayar.jpg", null, null },
                    { 169, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2596), 169, 1, false, "img/Products/AirConditionerandHeater/samsung_premium_ar18tshzhwk_a_18000_btu_inverter_duvar_tipi_klima.jpg", null, null },
                    { 170, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2601), 170, 1, false, "img/Products/AirConditionerandHeater/arnell_elektrikli_istc_quartz_ev_ve_ofis_oda_tipi_31_ubuklu_gvenli_elektrikli_soba_-_2600_watt.jpg", null, null },
                    { 171, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2603), 171, 1, false, "img/Products/AirConditionerandHeater/kumtel_ks-2760_quartz_istc_siyah.jpg", null, null },
                    { 172, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2608), 172, 1, false, "img/Products/AirConditionerandHeater/zeeful_sper_g_fleyici_mini_turbo_jet_fan_130000rpm_52ms_4000mah_yurt_dndan.jpg", null, null },
                    { 173, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2609), 173, 1, false, "img/Products/AirConditionerandHeater/beko_31225_ekolojik_a_12000_btu_duvar_tipi_klima.jpg", null, null },
                    { 174, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2618), 174, 1, false, "img/Products/AirConditionerandHeater/vestel_flora_doa_244_a_24000_btu_wifi_inverter_duvar_tipi_klima.jpg", null, null },
                    { 175, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2620), 175, 1, false, "img/Products/AirConditionerandHeater/arelik_ekolojik_18325_a_18000_btu_inverter_duvar_tipi_klima.jpg", null, null },
                    { 176, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2622), 176, 1, false, "img/Products/AirConditionerandHeater/arnell_elektrikli_istc_duvar_tip_soba_3000_watt.jpg", null, null },
                    { 177, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2624), 177, 1, false, "img/Products/AirConditionerandHeater/baymak_elegant_plus_uv_18_a_montaj_dahil_18000_btu_duvar_tipi_klima.jpg", null, null },
                    { 178, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2630), 178, 1, false, "img/Products/AirConditionerandHeater/fujiplus_fujiplus_sakura_12000_btu_inverter_duvar_tipi_klima.jpg", null, null },
                    { 179, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2632), 179, 1, false, "img/Products/AirConditionerandHeater/baymak_aqua_konfor_65_litre_termosifon.jpg", null, null },
                    { 180, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2634), 180, 1, false, "img/Products/AirConditionerandHeater/kumtel_ecoray_ex-25_2500_watt_duvar_tipi_infrared_istc.jpg", null, null },
                    { 181, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2636), 181, 1, false, "img/Products/AirConditionerandHeater/ufo_ufo_star_2400_w_duvar_tipi_istc_-_termostatl.jpg", null, null },
                    { 182, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2637), 182, 1, false, "img/Products/AirConditionerandHeater/abbruch_arj_edilebilir_tanabilir_ipli_mini_el_fan_kademe_hzl_gl_soutucu_pervane_vantilatr.jpg", null, null },
                    { 183, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2639), 183, 1, false, "img/Products/AirConditionerandHeater/sinbo_sf-6783_vantilatr.jpg", null, null },
                    { 184, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2650), 184, 1, false, "img/Products/AirConditionerandHeater/beko_31650_vantilatr_uzaktan_kumandal.jpg", null, null },
                    { 185, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2660), 185, 1, false, "img/Products/AirConditionerandHeater/ufo_ufo_micatronic_1900_w_kule_tipi_istc.jpg", null, null },
                    { 186, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2662), 186, 1, false, "img/Products/AirConditionerandHeater/ufo_omri_1200_w_termostatl_hem_yatay_hem_dikey_istc.jpg", null, null },
                    { 187, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2664), 187, 1, false, "img/Products/AirConditionerandHeater/kaira_dtxr71e_a_24000_btu_inverter_duvar_tipi_klima_montaj_dahil.jpg", null, null },
                    { 188, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2670), 188, 1, false, "img/Products/AirConditionerandHeater/baymak_duo_tec_compact_premix_24_kw_youmal_kombi_baca_dahil.jpg", null, null },
                    { 189, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2672), 189, 1, false, "img/Products/AirConditionerandHeater/ufo_isitici_star_s19_1900_w.jpg", null, null },
                    { 190, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2674), 190, 1, false, "img/Products/AirConditionerandHeater/magiceham_lilo_stitch_pelu_scak_su_istcs_-_lacivert_yurt_dndan.jpg", null, null },
                    { 191, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2687), 191, 1, false, "img/Products/AirConditionerandHeater/airfel_maestro_optimum_2024_kw_17000_kcal_tam_youmal_kombi.jpg", null, null },
                    { 192, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2688), 192, 1, false, "img/Products/ShoesandBag/lacoste_sport_court-master_pro_erkek_siyah_sneaker_744sma0084_02h.jpg", null, null },
                    { 193, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2690), 193, 1, false, "img/Products/ShoesandBag/letoon_2104_gnlk_unisex_spor_ayakkab.jpg", null, null },
                    { 194, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2692), 194, 1, false, "img/Products/ShoesandBag/derilax_hakiki_deri_tam_ortopedik_erkek_ayakkab.jpg", null, null },
                    { 195, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2694), 195, 1, false, "img/Products/ShoesandBag/hoti_hakiki_deri_siyah_erkek_gnlk_ayakkab.jpg", null, null },
                    { 196, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2696), 196, 1, false, "img/Products/ShoesandBag/ispartallar_7575_ortopedik_taban_yumuak_hakiki_deri_mevsimlik_klk_erkek_ayakkab.jpg", null, null },
                    { 197, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2697), 197, 1, false, "img/Products/ShoesandBag/under_armour_ocuk_ua_bgs_charged_rogue_4_kou_ayakkabs_3027106-400.jpg", null, null },
                    { 198, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2707), 198, 1, false, "img/Products/ShoesandBag/ispartallar_502_ortopedik_topuk_masajl_hakiki_deri_klk_erkek_ayakkab_backl.jpg", null, null },
                    { 199, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2709), 199, 1, false, "img/Products/ShoesandBag/muggo_samuel_garantili_gnlk_klasik_deri_casual_rahat_ortopedik_kaln_taban_erkek_ayakkab.jpg", null, null },
                    { 200, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2714), 200, 1, false, "img/Products/ShoesandBag/tomiross_erkek_atlanta_gnlk_kullanm_sneaker_ayakkab_atlnt-5025.jpg", null, null },
                    { 201, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2716), 201, 1, false, "img/Products/ShoesandBag/yaya_by_hoti_02ayy296160a100_siyah_erkek_ayakkab.jpg", null, null },
                    { 202, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2718), 202, 1, false, "img/Products/ShoesandBag/hoti_hakiki_deri_lacivert_erkek_gnlk_ayakkab.jpg", null, null },
                    { 203, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2728), 203, 1, false, "img/Products/ShoesandBag/derilax_deri_tam_ortopedik_erkek_ayakkab.jpg", null, null },
                    { 204, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2730), 204, 1, false, "img/Products/ShoesandBag/ispartallar_909_tam_ortopedik_taban_hakiki_deri_erkek_ayakkab_kadn_ayakkab_kaymaz_taban_unisex_ayakkab_lastikli_back.jpg", null, null },
                    { 205, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2732), 205, 1, false, "img/Products/ShoesandBag/selin_soylu_seln_soylu_hakiki_deri_erkek_ayakkab_klk_gnlk_ayakkab.jpg", null, null },
                    { 206, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2734), 206, 1, false, "img/Products/ShoesandBag/sebago_nubuk_koyu_kahve_-_siyah_erkek_gnlk_ayakkab_7111m5w.jpg", null, null },
                    { 207, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2737), 207, 1, false, "img/Products/ShoesandBag/lumberjack_4m_navgator_4fx.jpg", null, null },
                    { 208, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2745), 208, 1, false, "img/Products/ShoesandBag/sebago_deri_lacivert_erkek_gnlk_ayakkab_70004z0.jpg", null, null },
                    { 209, null, new DateTime(2025, 9, 21, 17, 4, 33, 771, DateTimeKind.Local).AddTicks(2749), 209, 1, false, "img/Products/ShoesandBag/dakrs_yazlk_erkek_keten_gnlk_rahat_hafif_backl_spor_ayakkab_40-44.jpg", null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductProperties",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "ProductId", "PropertyTypeId", "PropertyValueId", "Stock", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(3971), true, false, 1, 1, 1, 50, null, null },
                    { 2, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(3974), true, false, 1, 1, 2, 50, null, null },
                    { 3, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(3975), true, false, 1, 1, 3, 50, null, null },
                    { 4, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(3976), true, false, 1, 1, 4, 50, null, null },
                    { 5, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(3979), true, false, 1, 4, 15, 50, null, null },
                    { 6, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(3983), true, false, 1, 5, 24, 50, null, null },
                    { 7, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(3986), true, false, 1, 6, 28, 50, null, null },
                    { 8, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(3988), true, false, 1, 7, 30, 50, null, null },
                    { 9, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(5095), true, false, 2, 1, 1, 50, null, null },
                    { 10, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(5097), true, false, 2, 1, 2, 50, null, null },
                    { 11, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(5098), true, false, 2, 1, 3, 50, null, null },
                    { 12, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(5098), true, false, 2, 1, 4, 50, null, null },
                    { 13, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(5100), true, false, 2, 4, 16, 50, null, null },
                    { 14, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(5101), true, false, 2, 5, 23, 50, null, null },
                    { 15, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(5103), true, false, 2, 6, 27, 50, null, null },
                    { 16, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(5104), true, false, 2, 7, 29, 50, null, null },
                    { 17, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(5977), true, false, 3, 1, 1, 50, null, null },
                    { 18, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(5979), true, false, 3, 1, 2, 50, null, null },
                    { 19, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(5980), true, false, 3, 1, 3, 50, null, null },
                    { 20, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(5981), true, false, 3, 1, 4, 50, null, null },
                    { 21, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(5982), true, false, 3, 4, 17, 50, null, null },
                    { 22, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(5983), true, false, 3, 5, 24, 50, null, null },
                    { 23, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(5984), true, false, 3, 6, 28, 50, null, null },
                    { 24, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(5985), true, false, 3, 7, 31, 50, null, null },
                    { 25, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(6916), true, false, 4, 1, 1, 50, null, null },
                    { 26, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(6917), true, false, 4, 1, 2, 50, null, null },
                    { 27, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(6918), true, false, 4, 1, 3, 50, null, null },
                    { 28, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(6919), true, false, 4, 1, 4, 50, null, null },
                    { 29, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(6920), true, false, 4, 4, 17, 50, null, null },
                    { 30, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(6921), true, false, 4, 5, 24, 50, null, null },
                    { 31, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(6922), true, false, 4, 6, 28, 50, null, null },
                    { 32, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(6923), true, false, 4, 7, 30, 50, null, null },
                    { 33, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(7869), true, false, 5, 1, 1, 50, null, null },
                    { 34, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(7871), true, false, 5, 1, 2, 50, null, null },
                    { 35, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(7871), true, false, 5, 1, 3, 50, null, null },
                    { 36, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(7872), true, false, 5, 1, 4, 50, null, null },
                    { 37, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(7873), true, false, 5, 4, 18, 50, null, null },
                    { 38, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(7874), true, false, 5, 5, 23, 50, null, null },
                    { 39, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(7876), true, false, 5, 6, 27, 50, null, null },
                    { 40, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(7876), true, false, 5, 7, 30, 50, null, null },
                    { 41, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(9796), true, false, 6, 1, 1, 50, null, null },
                    { 42, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(9799), true, false, 6, 1, 2, 50, null, null },
                    { 43, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(9799), true, false, 6, 1, 3, 50, null, null },
                    { 44, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(9800), true, false, 6, 1, 4, 50, null, null },
                    { 45, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(9804), true, false, 6, 4, 19, 50, null, null },
                    { 46, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(9807), true, false, 6, 5, 23, 50, null, null },
                    { 47, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(9811), true, false, 6, 6, 27, 50, null, null },
                    { 48, null, new DateTime(2025, 9, 21, 17, 4, 33, 772, DateTimeKind.Local).AddTicks(9814), true, false, 6, 7, 31, 50, null, null },
                    { 49, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(2189), true, false, 7, 1, 1, 50, null, null },
                    { 50, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(2192), true, false, 7, 1, 2, 50, null, null },
                    { 51, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(2193), true, false, 7, 1, 3, 50, null, null },
                    { 52, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(2194), true, false, 7, 1, 4, 50, null, null },
                    { 53, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(2197), true, false, 7, 4, 20, 50, null, null },
                    { 54, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(2201), true, false, 7, 5, 23, 50, null, null },
                    { 55, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(2204), true, false, 7, 6, 27, 50, null, null },
                    { 56, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(2206), true, false, 7, 7, 30, 50, null, null },
                    { 57, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(3648), true, false, 8, 1, 1, 50, null, null },
                    { 58, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(3650), true, false, 8, 1, 2, 50, null, null },
                    { 59, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(3651), true, false, 8, 1, 3, 50, null, null },
                    { 60, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(3652), true, false, 8, 1, 4, 50, null, null },
                    { 61, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(3654), true, false, 8, 4, 21, 50, null, null },
                    { 62, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(3656), true, false, 8, 5, 22, 50, null, null },
                    { 63, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(3659), true, false, 8, 6, 27, 50, null, null },
                    { 64, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(3661), true, false, 8, 7, 30, 50, null, null },
                    { 65, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(4825), true, false, 9, 1, 1, 50, null, null },
                    { 66, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(4831), true, false, 9, 1, 2, 50, null, null },
                    { 67, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(4832), true, false, 9, 1, 3, 50, null, null },
                    { 68, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(4833), true, false, 9, 1, 4, 50, null, null },
                    { 69, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(4835), true, false, 9, 4, 16, 50, null, null },
                    { 70, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(4837), true, false, 9, 5, 23, 50, null, null },
                    { 71, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(4839), true, false, 9, 6, 26, 50, null, null },
                    { 72, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(4841), true, false, 9, 7, 30, 50, null, null },
                    { 73, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(6001), true, false, 10, 1, 1, 50, null, null },
                    { 74, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(6002), true, false, 10, 1, 2, 50, null, null },
                    { 75, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(6003), true, false, 10, 1, 3, 50, null, null },
                    { 76, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(6004), true, false, 10, 1, 4, 50, null, null },
                    { 77, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(6006), true, false, 10, 4, 32, 50, null, null },
                    { 78, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(6008), true, false, 10, 5, 24, 50, null, null },
                    { 79, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(6010), true, false, 10, 6, 28, 50, null, null },
                    { 80, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(6012), true, false, 10, 7, 30, 50, null, null },
                    { 81, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(7005), true, false, 11, 1, 1, 50, null, null },
                    { 82, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(7006), true, false, 11, 1, 2, 50, null, null },
                    { 83, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(7007), true, false, 11, 1, 3, 50, null, null },
                    { 84, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(7008), true, false, 11, 1, 4, 50, null, null },
                    { 85, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(7010), true, false, 11, 4, 21, 50, null, null },
                    { 86, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(7012), true, false, 11, 5, 24, 50, null, null },
                    { 87, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(7014), true, false, 11, 6, 26, 50, null, null },
                    { 88, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(7016), true, false, 11, 7, 30, 50, null, null },
                    { 89, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(8197), true, false, 12, 1, 1, 50, null, null },
                    { 90, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(8198), true, false, 12, 1, 2, 50, null, null },
                    { 91, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(8199), true, false, 12, 1, 3, 50, null, null },
                    { 92, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(8200), true, false, 12, 1, 4, 50, null, null },
                    { 93, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(8202), true, false, 12, 4, 36, 50, null, null },
                    { 94, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(8204), true, false, 12, 5, 23, 50, null, null },
                    { 95, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(8206), true, false, 12, 6, 26, 50, null, null },
                    { 96, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(8208), true, false, 12, 7, 30, 50, null, null },
                    { 97, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(9541), true, false, 13, 1, 1, 50, null, null },
                    { 98, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(9542), true, false, 13, 1, 2, 50, null, null },
                    { 99, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(9543), true, false, 13, 1, 3, 50, null, null },
                    { 100, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(9544), true, false, 13, 1, 4, 50, null, null },
                    { 101, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(9547), true, false, 13, 4, 16, 50, null, null },
                    { 102, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(9549), true, false, 13, 5, 23, 50, null, null },
                    { 103, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(9551), true, false, 13, 6, 27, 50, null, null },
                    { 104, null, new DateTime(2025, 9, 21, 17, 4, 33, 773, DateTimeKind.Local).AddTicks(9553), true, false, 13, 7, 30, 50, null, null },
                    { 105, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(1016), true, false, 14, 1, 1, 50, null, null },
                    { 106, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(1017), true, false, 14, 1, 2, 50, null, null },
                    { 107, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(1018), true, false, 14, 1, 3, 50, null, null },
                    { 108, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(1019), true, false, 14, 1, 4, 50, null, null },
                    { 109, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(1022), true, false, 14, 4, 15, 50, null, null },
                    { 110, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(1024), true, false, 14, 5, 24, 50, null, null },
                    { 111, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(1027), true, false, 14, 6, 28, 50, null, null },
                    { 112, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(1029), true, false, 14, 7, 30, 50, null, null },
                    { 113, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(3074), true, false, 15, 1, 1, 50, null, null },
                    { 114, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(3076), true, false, 15, 1, 2, 50, null, null },
                    { 115, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(3077), true, false, 15, 1, 3, 50, null, null },
                    { 116, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(3078), true, false, 15, 1, 4, 50, null, null },
                    { 117, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(3081), true, false, 15, 4, 19, 50, null, null },
                    { 118, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(3084), true, false, 15, 5, 24, 50, null, null },
                    { 119, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(3086), true, false, 15, 6, 26, 50, null, null },
                    { 120, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(3088), true, false, 15, 7, 30, 50, null, null },
                    { 121, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(4602), true, false, 16, 1, 1, 50, null, null },
                    { 122, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(4603), true, false, 16, 1, 2, 50, null, null },
                    { 123, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(4604), true, false, 16, 1, 3, 50, null, null },
                    { 124, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(4605), true, false, 16, 1, 4, 50, null, null },
                    { 125, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(4607), true, false, 16, 4, 15, 50, null, null },
                    { 126, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(4610), true, false, 16, 5, 24, 50, null, null },
                    { 127, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(4611), true, false, 16, 6, 28, 50, null, null },
                    { 128, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(4613), true, false, 16, 7, 30, 50, null, null },
                    { 129, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(6477), true, false, 17, 1, 1, 50, null, null },
                    { 130, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(6519), true, false, 17, 1, 2, 50, null, null },
                    { 131, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(6520), true, false, 17, 1, 3, 50, null, null },
                    { 132, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(6520), true, false, 17, 1, 4, 50, null, null },
                    { 133, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(6523), true, false, 17, 4, 33, 50, null, null },
                    { 134, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(6525), true, false, 17, 5, 24, 50, null, null },
                    { 135, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(6528), true, false, 17, 6, 28, 50, null, null },
                    { 136, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(6531), true, false, 17, 7, 30, 50, null, null },
                    { 137, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(7528), true, false, 18, 1, 1, 50, null, null },
                    { 138, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(7529), true, false, 18, 1, 2, 50, null, null },
                    { 139, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(7530), true, false, 18, 1, 3, 50, null, null },
                    { 140, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(7530), true, false, 18, 1, 4, 50, null, null },
                    { 141, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(7532), true, false, 18, 4, 21, 50, null, null },
                    { 142, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(7533), true, false, 18, 5, 23, 50, null, null },
                    { 143, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(7535), true, false, 18, 6, 28, 50, null, null },
                    { 144, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(7536), true, false, 18, 7, 30, 50, null, null },
                    { 145, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(8175), true, false, 19, 1, 1, 50, null, null },
                    { 146, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(8176), true, false, 19, 1, 2, 50, null, null },
                    { 147, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(8176), true, false, 19, 1, 3, 50, null, null },
                    { 148, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(8177), true, false, 19, 1, 4, 50, null, null },
                    { 149, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(8178), true, false, 19, 4, 21, 50, null, null },
                    { 150, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(8179), true, false, 19, 5, 22, 50, null, null },
                    { 151, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(8180), true, false, 19, 6, 27, 50, null, null },
                    { 152, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(8181), true, false, 19, 7, 30, 50, null, null },
                    { 153, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(8716), true, false, 20, 1, 1, 50, null, null },
                    { 154, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(8717), true, false, 20, 1, 2, 50, null, null },
                    { 155, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(8717), true, false, 20, 1, 3, 50, null, null },
                    { 156, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(8718), true, false, 20, 1, 4, 50, null, null },
                    { 157, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(8719), true, false, 20, 4, 16, 50, null, null },
                    { 158, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(8719), true, false, 20, 5, 22, 50, null, null },
                    { 159, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(8720), true, false, 20, 6, 27, 50, null, null },
                    { 160, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(8721), true, false, 20, 7, 30, 50, null, null },
                    { 161, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(9270), true, false, 21, 1, 1, 50, null, null },
                    { 162, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(9270), true, false, 21, 1, 2, 50, null, null },
                    { 163, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(9271), true, false, 21, 1, 3, 50, null, null },
                    { 164, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(9271), true, false, 21, 1, 4, 50, null, null },
                    { 165, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(9272), true, false, 21, 4, 19, 50, null, null },
                    { 166, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(9273), true, false, 21, 5, 23, 50, null, null },
                    { 167, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(9274), true, false, 21, 6, 12, 50, null, null },
                    { 168, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(9275), true, false, 21, 7, 29, 50, null, null },
                    { 169, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(9804), true, false, 22, 1, 1, 50, null, null },
                    { 170, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(9805), true, false, 22, 1, 2, 50, null, null },
                    { 171, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(9805), true, false, 22, 1, 3, 50, null, null },
                    { 172, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(9806), true, false, 22, 1, 4, 50, null, null },
                    { 173, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(9807), true, false, 22, 4, 19, 50, null, null },
                    { 174, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(9807), true, false, 22, 5, 23, 50, null, null },
                    { 175, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(9808), true, false, 22, 6, 28, 50, null, null },
                    { 176, null, new DateTime(2025, 9, 21, 17, 4, 33, 774, DateTimeKind.Local).AddTicks(9809), true, false, 22, 7, 30, 50, null, null },
                    { 177, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(1161), true, false, 23, 1, 1, 50, null, null },
                    { 178, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(1162), true, false, 23, 1, 2, 50, null, null },
                    { 179, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(1162), true, false, 23, 1, 3, 50, null, null },
                    { 180, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(1163), true, false, 23, 1, 4, 50, null, null },
                    { 181, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(1165), true, false, 23, 4, 35, 50, null, null },
                    { 182, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(1167), true, false, 23, 5, 23, 50, null, null },
                    { 183, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(1169), true, false, 23, 6, 27, 50, null, null },
                    { 184, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(1171), true, false, 23, 7, 29, 50, null, null },
                    { 185, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(2080), true, false, 24, 1, 1, 50, null, null },
                    { 186, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(2081), true, false, 24, 1, 2, 50, null, null },
                    { 187, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(2081), true, false, 24, 1, 3, 50, null, null },
                    { 188, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(2082), true, false, 24, 1, 4, 50, null, null },
                    { 189, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(2083), true, false, 24, 4, 19, 50, null, null },
                    { 190, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(2084), true, false, 24, 5, 24, 50, null, null },
                    { 191, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(2085), true, false, 24, 6, 28, 50, null, null },
                    { 192, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(2086), true, false, 24, 7, 31, 50, null, null },
                    { 193, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(2759), true, false, 25, 1, 1, 50, null, null },
                    { 194, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(2760), true, false, 25, 1, 2, 50, null, null },
                    { 195, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(2760), true, false, 25, 1, 3, 50, null, null },
                    { 196, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(2761), true, false, 25, 1, 4, 50, null, null },
                    { 197, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(2762), true, false, 25, 4, 34, 50, null, null },
                    { 198, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(2762), true, false, 25, 5, 24, 50, null, null },
                    { 199, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(2763), true, false, 25, 6, 26, 50, null, null },
                    { 200, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(2764), true, false, 25, 7, 30, 50, null, null },
                    { 201, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(3298), true, false, 26, 1, 1, 50, null, null },
                    { 202, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(3299), true, false, 26, 1, 2, 50, null, null },
                    { 203, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(3299), true, false, 26, 1, 3, 50, null, null },
                    { 204, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(3300), true, false, 26, 1, 4, 50, null, null },
                    { 205, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(3301), true, false, 26, 4, 17, 50, null, null },
                    { 206, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(3302), true, false, 26, 5, 24, 50, null, null },
                    { 207, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(3303), true, false, 26, 6, 28, 50, null, null },
                    { 208, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(3304), true, false, 26, 7, 31, 50, null, null },
                    { 209, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(3825), true, false, 27, 1, 1, 50, null, null },
                    { 210, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(3826), true, false, 27, 1, 2, 50, null, null },
                    { 211, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(3826), true, false, 27, 1, 3, 50, null, null },
                    { 212, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(3827), true, false, 27, 1, 4, 50, null, null },
                    { 213, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(3827), true, false, 27, 4, 19, 50, null, null },
                    { 214, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(3828), true, false, 27, 5, 23, 50, null, null },
                    { 215, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(3829), true, false, 27, 6, 26, 50, null, null },
                    { 216, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(3829), true, false, 27, 7, 30, 50, null, null },
                    { 217, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(4387), true, false, 28, 1, 1, 50, null, null },
                    { 218, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(4388), true, false, 28, 1, 2, 50, null, null },
                    { 219, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(4389), true, false, 28, 1, 3, 50, null, null },
                    { 220, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(4389), true, false, 28, 1, 4, 50, null, null },
                    { 221, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(4390), true, false, 28, 4, 36, 50, null, null },
                    { 222, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(4390), true, false, 28, 5, 23, 50, null, null },
                    { 223, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(4391), true, false, 28, 6, 28, 50, null, null },
                    { 224, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(4392), true, false, 28, 7, 30, 50, null, null },
                    { 225, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(5035), true, false, 29, 1, 1, 50, null, null },
                    { 226, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(5035), true, false, 29, 1, 2, 50, null, null },
                    { 227, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(5036), true, false, 29, 1, 3, 50, null, null },
                    { 228, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(5036), true, false, 29, 1, 4, 50, null, null },
                    { 229, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(5037), true, false, 29, 4, 19, 50, null, null },
                    { 230, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(5038), true, false, 29, 5, 22, 50, null, null },
                    { 231, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(5038), true, false, 29, 6, 27, 50, null, null },
                    { 232, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(5039), true, false, 29, 7, 30, 50, null, null },
                    { 233, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(5551), true, false, 30, 1, 1, 50, null, null },
                    { 234, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(5552), true, false, 30, 1, 2, 50, null, null },
                    { 235, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(5552), true, false, 30, 1, 3, 50, null, null },
                    { 236, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(5553), true, false, 30, 1, 4, 50, null, null },
                    { 237, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(5554), true, false, 30, 4, 16, 50, null, null },
                    { 238, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(5555), true, false, 30, 5, 24, 50, null, null },
                    { 239, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(5555), true, false, 30, 6, 28, 50, null, null },
                    { 240, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(5556), true, false, 30, 7, 30, 50, null, null },
                    { 241, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6111), true, false, 31, 1, 1, 50, null, null },
                    { 242, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6112), true, false, 31, 1, 2, 50, null, null },
                    { 243, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6112), true, false, 31, 1, 3, 50, null, null },
                    { 244, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6113), true, false, 31, 1, 4, 50, null, null },
                    { 245, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6114), true, false, 31, 4, 21, 50, null, null },
                    { 246, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6114), true, false, 31, 5, 23, 50, null, null },
                    { 247, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6115), true, false, 31, 6, 12, 50, null, null },
                    { 248, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6116), true, false, 31, 7, 29, 50, null, null },
                    { 249, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6681), true, false, 32, 1, 52, 50, null, null },
                    { 250, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6683), true, false, 32, 1, 53, 50, null, null },
                    { 251, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6683), true, false, 32, 1, 54, 50, null, null },
                    { 252, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6685), true, false, 32, 8, 37, 50, null, null },
                    { 253, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6687), true, false, 32, 9, 40, 50, null, null },
                    { 254, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6688), true, false, 32, 10, 43, 50, null, null },
                    { 255, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6718), true, false, 32, 11, 46, 50, null, null },
                    { 256, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6719), true, false, 32, 11, 47, 50, null, null },
                    { 257, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6719), true, false, 32, 11, 48, 50, null, null },
                    { 258, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6787), true, false, 32, 11, 50, 50, null, null },
                    { 259, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(6788), true, false, 32, 11, 51, 50, null, null },
                    { 260, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7373), true, false, 33, 1, 52, 50, null, null },
                    { 261, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7374), true, false, 33, 1, 53, 50, null, null },
                    { 262, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7374), true, false, 33, 1, 54, 50, null, null },
                    { 263, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7375), true, false, 33, 8, 37, 50, null, null },
                    { 264, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7375), true, false, 33, 9, 40, 50, null, null },
                    { 265, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7398), true, false, 33, 10, 43, 50, null, null },
                    { 266, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7401), true, false, 33, 11, 46, 50, null, null },
                    { 267, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7401), true, false, 33, 11, 47, 50, null, null },
                    { 268, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7402), true, false, 33, 11, 48, 50, null, null },
                    { 269, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7402), true, false, 33, 11, 50, 50, null, null },
                    { 270, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7403), true, false, 33, 11, 51, 50, null, null },
                    { 271, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7910), true, false, 34, 1, 52, 50, null, null },
                    { 272, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7910), true, false, 34, 1, 53, 50, null, null },
                    { 273, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7911), true, false, 34, 1, 54, 50, null, null },
                    { 274, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7912), true, false, 34, 8, 37, 50, null, null },
                    { 275, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7912), true, false, 34, 9, 40, 50, null, null },
                    { 276, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7913), true, false, 34, 10, 43, 50, null, null },
                    { 277, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7914), true, false, 34, 11, 46, 50, null, null },
                    { 278, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7915), true, false, 34, 11, 47, 50, null, null },
                    { 279, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7915), true, false, 34, 11, 48, 50, null, null },
                    { 280, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7916), true, false, 34, 11, 50, 50, null, null },
                    { 281, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(7917), true, false, 34, 11, 51, 50, null, null },
                    { 282, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(8524), true, false, 35, 1, 52, 50, null, null },
                    { 283, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(8524), true, false, 35, 1, 53, 50, null, null },
                    { 284, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(8525), true, false, 35, 1, 54, 50, null, null },
                    { 285, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(8525), true, false, 35, 8, 37, 50, null, null },
                    { 286, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(8526), true, false, 35, 9, 40, 50, null, null },
                    { 287, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(8527), true, false, 35, 10, 43, 50, null, null },
                    { 288, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(8528), true, false, 35, 11, 46, 50, null, null },
                    { 289, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(8528), true, false, 35, 11, 47, 50, null, null },
                    { 290, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(8529), true, false, 35, 11, 48, 50, null, null },
                    { 291, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(8529), true, false, 35, 11, 50, 50, null, null },
                    { 292, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(8530), true, false, 35, 11, 51, 50, null, null },
                    { 293, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9026), true, false, 36, 1, 52, 50, null, null },
                    { 294, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9026), true, false, 36, 1, 53, 50, null, null },
                    { 295, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9027), true, false, 36, 1, 54, 50, null, null },
                    { 296, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9027), true, false, 36, 8, 37, 50, null, null },
                    { 297, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9028), true, false, 36, 9, 40, 50, null, null },
                    { 298, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9028), true, false, 36, 10, 43, 50, null, null },
                    { 299, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9030), true, false, 36, 11, 46, 50, null, null },
                    { 300, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9030), true, false, 36, 11, 47, 50, null, null },
                    { 301, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9031), true, false, 36, 11, 48, 50, null, null },
                    { 302, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9031), true, false, 36, 11, 50, 50, null, null },
                    { 303, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9032), true, false, 36, 11, 51, 50, null, null },
                    { 304, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9634), true, false, 37, 1, 52, 50, null, null },
                    { 305, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9634), true, false, 37, 1, 53, 50, null, null },
                    { 306, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9635), true, false, 37, 1, 54, 50, null, null },
                    { 307, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9635), true, false, 37, 8, 37, 50, null, null },
                    { 308, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9636), true, false, 37, 9, 40, 50, null, null },
                    { 309, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9636), true, false, 37, 10, 43, 50, null, null },
                    { 310, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9638), true, false, 37, 11, 46, 50, null, null },
                    { 311, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9639), true, false, 37, 11, 47, 50, null, null },
                    { 312, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9640), true, false, 37, 11, 48, 50, null, null },
                    { 313, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9640), true, false, 37, 11, 50, 50, null, null },
                    { 314, null, new DateTime(2025, 9, 21, 17, 4, 33, 775, DateTimeKind.Local).AddTicks(9641), true, false, 37, 11, 51, 50, null, null },
                    { 315, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(102), true, false, 38, 1, 52, 50, null, null },
                    { 316, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(103), true, false, 38, 1, 53, 50, null, null },
                    { 317, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(104), true, false, 38, 1, 54, 50, null, null },
                    { 318, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(104), true, false, 38, 8, 37, 50, null, null },
                    { 319, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(105), true, false, 38, 9, 40, 50, null, null },
                    { 320, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(105), true, false, 38, 10, 43, 50, null, null },
                    { 321, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(107), true, false, 38, 11, 46, 50, null, null },
                    { 322, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(107), true, false, 38, 11, 47, 50, null, null },
                    { 323, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(108), true, false, 38, 11, 48, 50, null, null },
                    { 324, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(109), true, false, 38, 11, 50, 50, null, null },
                    { 325, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(109), true, false, 38, 11, 51, 50, null, null },
                    { 326, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(584), true, false, 39, 1, 52, 50, null, null },
                    { 327, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(584), true, false, 39, 1, 53, 50, null, null },
                    { 328, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(585), true, false, 39, 1, 54, 50, null, null },
                    { 329, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(585), true, false, 39, 8, 37, 50, null, null },
                    { 330, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(586), true, false, 39, 9, 40, 50, null, null },
                    { 331, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(586), true, false, 39, 10, 43, 50, null, null },
                    { 332, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(588), true, false, 39, 11, 46, 50, null, null },
                    { 333, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(588), true, false, 39, 11, 47, 50, null, null },
                    { 334, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(589), true, false, 39, 11, 48, 50, null, null },
                    { 335, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(589), true, false, 39, 11, 50, 50, null, null },
                    { 336, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(590), true, false, 39, 11, 51, 50, null, null },
                    { 337, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1086), true, false, 40, 1, 52, 50, null, null },
                    { 338, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1086), true, false, 40, 1, 53, 50, null, null },
                    { 339, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1087), true, false, 40, 1, 54, 50, null, null },
                    { 340, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1087), true, false, 40, 8, 37, 50, null, null },
                    { 341, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1088), true, false, 40, 9, 40, 50, null, null },
                    { 342, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1088), true, false, 40, 10, 43, 50, null, null },
                    { 343, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1090), true, false, 40, 11, 46, 50, null, null },
                    { 344, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1090), true, false, 40, 11, 47, 50, null, null },
                    { 345, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1091), true, false, 40, 11, 48, 50, null, null },
                    { 346, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1091), true, false, 40, 11, 50, 50, null, null },
                    { 347, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1092), true, false, 40, 11, 51, 50, null, null },
                    { 348, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1563), true, false, 41, 1, 52, 50, null, null },
                    { 349, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1563), true, false, 41, 1, 53, 50, null, null },
                    { 350, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1564), true, false, 41, 1, 54, 50, null, null },
                    { 351, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1564), true, false, 41, 8, 37, 50, null, null },
                    { 352, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1565), true, false, 41, 9, 40, 50, null, null },
                    { 353, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1565), true, false, 41, 10, 43, 50, null, null },
                    { 354, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1567), true, false, 41, 11, 46, 50, null, null },
                    { 355, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1567), true, false, 41, 11, 47, 50, null, null },
                    { 356, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1568), true, false, 41, 11, 48, 50, null, null },
                    { 357, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1568), true, false, 41, 11, 50, 50, null, null },
                    { 358, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(1569), true, false, 41, 11, 51, 50, null, null },
                    { 359, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2105), true, false, 42, 1, 52, 50, null, null },
                    { 360, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2106), true, false, 42, 1, 53, 50, null, null },
                    { 361, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2106), true, false, 42, 1, 54, 50, null, null },
                    { 362, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2107), true, false, 42, 8, 37, 50, null, null },
                    { 363, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2107), true, false, 42, 9, 40, 50, null, null },
                    { 364, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2108), true, false, 42, 10, 43, 50, null, null },
                    { 365, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2109), true, false, 42, 11, 46, 50, null, null },
                    { 366, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2110), true, false, 42, 11, 47, 50, null, null },
                    { 367, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2110), true, false, 42, 11, 48, 50, null, null },
                    { 368, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2111), true, false, 42, 11, 50, 50, null, null },
                    { 369, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2111), true, false, 42, 11, 51, 50, null, null },
                    { 370, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2588), true, false, 43, 1, 52, 50, null, null },
                    { 371, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2588), true, false, 43, 1, 53, 50, null, null },
                    { 372, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2589), true, false, 43, 1, 54, 50, null, null },
                    { 373, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2589), true, false, 43, 8, 37, 50, null, null },
                    { 374, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2590), true, false, 43, 9, 40, 50, null, null },
                    { 375, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2591), true, false, 43, 10, 43, 50, null, null },
                    { 376, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2592), true, false, 43, 11, 46, 50, null, null },
                    { 377, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2593), true, false, 43, 11, 47, 50, null, null },
                    { 378, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2594), true, false, 43, 11, 48, 50, null, null },
                    { 379, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2594), true, false, 43, 11, 50, 50, null, null },
                    { 380, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(2595), true, false, 43, 11, 51, 50, null, null },
                    { 381, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3145), true, false, 44, 1, 52, 50, null, null },
                    { 382, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3146), true, false, 44, 1, 53, 50, null, null },
                    { 383, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3146), true, false, 44, 1, 54, 50, null, null },
                    { 384, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3147), true, false, 44, 8, 37, 50, null, null },
                    { 385, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3147), true, false, 44, 9, 40, 50, null, null },
                    { 386, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3148), true, false, 44, 10, 43, 50, null, null },
                    { 387, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3149), true, false, 44, 11, 46, 50, null, null },
                    { 388, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3150), true, false, 44, 11, 47, 50, null, null },
                    { 389, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3150), true, false, 44, 11, 48, 50, null, null },
                    { 390, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3178), true, false, 44, 11, 50, 50, null, null },
                    { 391, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3179), true, false, 44, 11, 51, 50, null, null },
                    { 392, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3773), true, false, 45, 1, 52, 50, null, null },
                    { 393, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3774), true, false, 45, 1, 53, 50, null, null },
                    { 394, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3775), true, false, 45, 1, 54, 50, null, null },
                    { 395, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3776), true, false, 45, 8, 37, 50, null, null },
                    { 396, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3778), true, false, 45, 9, 40, 50, null, null },
                    { 397, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3803), true, false, 45, 10, 43, 50, null, null },
                    { 398, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3808), true, false, 45, 11, 46, 50, null, null },
                    { 399, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3809), true, false, 45, 11, 47, 50, null, null },
                    { 400, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3810), true, false, 45, 11, 48, 50, null, null },
                    { 401, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3810), true, false, 45, 11, 50, 50, null, null },
                    { 402, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(3811), true, false, 45, 11, 51, 50, null, null },
                    { 403, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(4617), true, false, 46, 1, 52, 50, null, null },
                    { 404, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(4617), true, false, 46, 1, 53, 50, null, null },
                    { 405, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(4618), true, false, 46, 1, 54, 50, null, null },
                    { 406, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(4619), true, false, 46, 8, 37, 50, null, null },
                    { 407, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(4619), true, false, 46, 9, 40, 50, null, null },
                    { 408, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(4620), true, false, 46, 10, 43, 50, null, null },
                    { 409, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(4622), true, false, 46, 11, 46, 50, null, null },
                    { 410, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(4623), true, false, 46, 11, 47, 50, null, null },
                    { 411, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(4623), true, false, 46, 11, 48, 50, null, null },
                    { 412, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(4623), true, false, 46, 11, 50, 50, null, null },
                    { 413, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(4624), true, false, 46, 11, 51, 50, null, null },
                    { 414, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5174), true, false, 47, 1, 52, 50, null, null },
                    { 415, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5175), true, false, 47, 1, 53, 50, null, null },
                    { 416, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5175), true, false, 47, 1, 54, 50, null, null },
                    { 417, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5176), true, false, 47, 8, 37, 50, null, null },
                    { 418, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5176), true, false, 47, 9, 40, 50, null, null },
                    { 419, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5177), true, false, 47, 10, 43, 50, null, null },
                    { 420, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5178), true, false, 47, 11, 46, 50, null, null },
                    { 421, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5179), true, false, 47, 11, 47, 50, null, null },
                    { 422, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5179), true, false, 47, 11, 48, 50, null, null },
                    { 423, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5180), true, false, 47, 11, 50, 50, null, null },
                    { 424, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5180), true, false, 47, 11, 51, 50, null, null },
                    { 425, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5718), true, false, 48, 1, 52, 50, null, null },
                    { 426, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5718), true, false, 48, 1, 53, 50, null, null },
                    { 427, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5719), true, false, 48, 1, 54, 50, null, null },
                    { 428, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5719), true, false, 48, 8, 37, 50, null, null },
                    { 429, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5720), true, false, 48, 9, 40, 50, null, null },
                    { 430, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5720), true, false, 48, 10, 43, 50, null, null },
                    { 431, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5722), true, false, 48, 11, 46, 50, null, null },
                    { 432, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5722), true, false, 48, 11, 47, 50, null, null },
                    { 433, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5723), true, false, 48, 11, 48, 50, null, null },
                    { 434, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5724), true, false, 48, 11, 50, 50, null, null },
                    { 435, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(5724), true, false, 48, 11, 51, 50, null, null },
                    { 436, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6310), true, false, 49, 1, 52, 50, null, null },
                    { 437, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6311), true, false, 49, 1, 53, 50, null, null },
                    { 438, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6311), true, false, 49, 1, 54, 50, null, null },
                    { 439, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6312), true, false, 49, 8, 37, 50, null, null },
                    { 440, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6312), true, false, 49, 9, 40, 50, null, null },
                    { 441, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6313), true, false, 49, 10, 43, 50, null, null },
                    { 442, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6314), true, false, 49, 11, 46, 50, null, null },
                    { 443, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6315), true, false, 49, 11, 47, 50, null, null },
                    { 444, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6315), true, false, 49, 11, 48, 50, null, null },
                    { 445, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6316), true, false, 49, 11, 50, 50, null, null },
                    { 446, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6317), true, false, 49, 11, 51, 50, null, null },
                    { 447, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6885), true, false, 50, 1, 52, 50, null, null },
                    { 448, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6886), true, false, 50, 1, 53, 50, null, null },
                    { 449, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6886), true, false, 50, 1, 54, 50, null, null },
                    { 450, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6887), true, false, 50, 8, 37, 50, null, null },
                    { 451, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6887), true, false, 50, 9, 40, 50, null, null },
                    { 452, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6888), true, false, 50, 10, 43, 50, null, null },
                    { 453, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6889), true, false, 50, 11, 46, 50, null, null },
                    { 454, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6890), true, false, 50, 11, 47, 50, null, null },
                    { 455, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6890), true, false, 50, 11, 48, 50, null, null },
                    { 456, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6891), true, false, 50, 11, 50, 50, null, null },
                    { 457, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(6891), true, false, 50, 11, 51, 50, null, null },
                    { 458, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(7448), true, false, 51, 1, 52, 50, null, null },
                    { 459, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(7448), true, false, 51, 1, 53, 50, null, null },
                    { 460, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(7449), true, false, 51, 1, 54, 50, null, null },
                    { 461, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(7449), true, false, 51, 8, 37, 50, null, null },
                    { 462, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(7450), true, false, 51, 9, 40, 50, null, null },
                    { 463, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(7450), true, false, 51, 10, 43, 50, null, null },
                    { 464, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(7452), true, false, 51, 11, 46, 50, null, null },
                    { 465, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(7452), true, false, 51, 11, 47, 50, null, null },
                    { 466, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(7453), true, false, 51, 11, 48, 50, null, null },
                    { 467, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(7453), true, false, 51, 11, 50, 50, null, null },
                    { 468, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(7454), true, false, 51, 11, 51, 50, null, null },
                    { 469, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8243), true, false, 52, 1, 52, 50, null, null },
                    { 470, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8244), true, false, 52, 1, 53, 50, null, null },
                    { 471, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8245), true, false, 52, 1, 54, 50, null, null },
                    { 472, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8246), true, false, 52, 8, 37, 50, null, null },
                    { 473, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8246), true, false, 52, 9, 40, 50, null, null },
                    { 474, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8247), true, false, 52, 10, 43, 50, null, null },
                    { 475, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8249), true, false, 52, 11, 46, 50, null, null },
                    { 476, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8250), true, false, 52, 11, 47, 50, null, null },
                    { 477, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8250), true, false, 52, 11, 48, 50, null, null },
                    { 478, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8251), true, false, 52, 11, 50, 50, null, null },
                    { 479, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8251), true, false, 52, 11, 51, 50, null, null },
                    { 480, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8940), true, false, 53, 1, 52, 50, null, null },
                    { 481, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8940), true, false, 53, 1, 53, 50, null, null },
                    { 482, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8941), true, false, 53, 1, 54, 50, null, null },
                    { 483, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8941), true, false, 53, 8, 37, 50, null, null },
                    { 484, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8942), true, false, 53, 9, 40, 50, null, null },
                    { 485, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8943), true, false, 53, 10, 43, 50, null, null },
                    { 486, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8944), true, false, 53, 11, 46, 50, null, null },
                    { 487, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8945), true, false, 53, 11, 47, 50, null, null },
                    { 488, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8946), true, false, 53, 11, 48, 50, null, null },
                    { 489, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8946), true, false, 53, 11, 50, 50, null, null },
                    { 490, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(8947), true, false, 53, 11, 51, 50, null, null },
                    { 491, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(9561), true, false, 54, 1, 52, 50, null, null },
                    { 492, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(9562), true, false, 54, 1, 53, 50, null, null },
                    { 493, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(9562), true, false, 54, 1, 54, 50, null, null },
                    { 494, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(9563), true, false, 54, 8, 37, 50, null, null },
                    { 495, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(9564), true, false, 54, 9, 40, 50, null, null },
                    { 496, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(9564), true, false, 54, 10, 43, 50, null, null },
                    { 497, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(9566), true, false, 54, 11, 46, 50, null, null },
                    { 498, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(9567), true, false, 54, 11, 47, 50, null, null },
                    { 499, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(9568), true, false, 54, 11, 48, 50, null, null },
                    { 500, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(9568), true, false, 54, 11, 50, 50, null, null },
                    { 501, null, new DateTime(2025, 9, 21, 17, 4, 33, 776, DateTimeKind.Local).AddTicks(9569), true, false, 54, 11, 51, 50, null, null },
                    { 502, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(241), true, false, 55, 1, 52, 50, null, null },
                    { 503, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(241), true, false, 55, 1, 53, 50, null, null },
                    { 504, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(242), true, false, 55, 1, 54, 50, null, null },
                    { 505, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(242), true, false, 55, 8, 37, 50, null, null },
                    { 506, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(243), true, false, 55, 9, 40, 50, null, null },
                    { 507, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(243), true, false, 55, 10, 43, 50, null, null },
                    { 508, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(245), true, false, 55, 11, 46, 50, null, null },
                    { 509, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(245), true, false, 55, 11, 47, 50, null, null },
                    { 510, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(246), true, false, 55, 11, 48, 50, null, null },
                    { 511, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(247), true, false, 55, 11, 50, 50, null, null },
                    { 512, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(247), true, false, 55, 11, 51, 50, null, null },
                    { 513, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1136), true, false, 56, 1, 52, 50, null, null },
                    { 514, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1232), true, false, 56, 1, 53, 50, null, null },
                    { 515, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1233), true, false, 56, 1, 54, 50, null, null },
                    { 516, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1234), true, false, 56, 8, 37, 50, null, null },
                    { 517, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1235), true, false, 56, 9, 40, 50, null, null },
                    { 518, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1235), true, false, 56, 10, 43, 50, null, null },
                    { 519, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1237), true, false, 56, 11, 46, 50, null, null },
                    { 520, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1238), true, false, 56, 11, 47, 50, null, null },
                    { 521, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1238), true, false, 56, 11, 48, 50, null, null },
                    { 522, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1253), true, false, 56, 11, 50, 50, null, null },
                    { 523, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1254), true, false, 56, 11, 51, 50, null, null },
                    { 524, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1804), true, false, 57, 1, 52, 50, null, null },
                    { 525, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1804), true, false, 57, 1, 53, 50, null, null },
                    { 526, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1805), true, false, 57, 1, 54, 50, null, null },
                    { 527, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1805), true, false, 57, 8, 37, 50, null, null },
                    { 528, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1806), true, false, 57, 9, 40, 50, null, null },
                    { 529, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1806), true, false, 57, 10, 43, 50, null, null },
                    { 530, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1809), true, false, 57, 11, 46, 50, null, null },
                    { 531, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1810), true, false, 57, 11, 47, 50, null, null },
                    { 532, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1810), true, false, 57, 11, 48, 50, null, null },
                    { 533, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1811), true, false, 57, 11, 50, 50, null, null },
                    { 534, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(1811), true, false, 57, 11, 51, 50, null, null },
                    { 535, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(2695), true, false, 58, 1, 52, 50, null, null },
                    { 536, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(2695), true, false, 58, 1, 53, 50, null, null },
                    { 537, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(2696), true, false, 58, 1, 54, 50, null, null },
                    { 538, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(2696), true, false, 58, 8, 37, 50, null, null },
                    { 539, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(2697), true, false, 58, 9, 40, 50, null, null },
                    { 540, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(2697), true, false, 58, 10, 43, 50, null, null },
                    { 541, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(2699), true, false, 58, 11, 46, 50, null, null },
                    { 542, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(2700), true, false, 58, 11, 47, 50, null, null },
                    { 543, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(2700), true, false, 58, 11, 48, 50, null, null },
                    { 544, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(2701), true, false, 58, 11, 50, 50, null, null },
                    { 545, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(2701), true, false, 58, 11, 51, 50, null, null },
                    { 546, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(3618), true, false, 59, 1, 52, 50, null, null },
                    { 547, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(3618), true, false, 59, 1, 53, 50, null, null },
                    { 548, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(3619), true, false, 59, 1, 54, 50, null, null },
                    { 549, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(3619), true, false, 59, 8, 37, 50, null, null },
                    { 550, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(3620), true, false, 59, 9, 40, 50, null, null },
                    { 551, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(3621), true, false, 59, 10, 43, 50, null, null },
                    { 552, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(3622), true, false, 59, 11, 46, 50, null, null },
                    { 553, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(3623), true, false, 59, 11, 47, 50, null, null },
                    { 554, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(3623), true, false, 59, 11, 48, 50, null, null },
                    { 555, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(3624), true, false, 59, 11, 50, 50, null, null },
                    { 556, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(3624), true, false, 59, 11, 51, 50, null, null },
                    { 557, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(4562), true, false, 60, 1, 52, 50, null, null },
                    { 558, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(4562), true, false, 60, 1, 53, 50, null, null },
                    { 559, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(4563), true, false, 60, 1, 54, 50, null, null },
                    { 560, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(4564), true, false, 60, 8, 37, 50, null, null },
                    { 561, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(4565), true, false, 60, 9, 40, 50, null, null },
                    { 562, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(4565), true, false, 60, 10, 43, 50, null, null },
                    { 563, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(4567), true, false, 60, 11, 46, 50, null, null },
                    { 564, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(4568), true, false, 60, 11, 47, 50, null, null },
                    { 565, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(4568), true, false, 60, 11, 48, 50, null, null },
                    { 566, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(4569), true, false, 60, 11, 50, 50, null, null },
                    { 567, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(4569), true, false, 60, 11, 51, 50, null, null },
                    { 568, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(5545), true, false, 61, 1, 52, 50, null, null },
                    { 569, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(5546), true, false, 61, 1, 53, 50, null, null },
                    { 570, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(5547), true, false, 61, 1, 54, 50, null, null },
                    { 571, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(5547), true, false, 61, 8, 37, 50, null, null },
                    { 572, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(5548), true, false, 61, 9, 40, 50, null, null },
                    { 573, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(5549), true, false, 61, 10, 43, 50, null, null },
                    { 574, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(5550), true, false, 61, 11, 46, 50, null, null },
                    { 575, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(5551), true, false, 61, 11, 47, 50, null, null },
                    { 576, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(5552), true, false, 61, 11, 48, 50, null, null },
                    { 577, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(5552), true, false, 61, 11, 50, 50, null, null },
                    { 578, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(5553), true, false, 61, 11, 51, 50, null, null },
                    { 579, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(6572), true, false, 62, 1, 52, 50, null, null },
                    { 580, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(6573), true, false, 62, 1, 53, 50, null, null },
                    { 581, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(6574), true, false, 62, 1, 54, 50, null, null },
                    { 582, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(6574), true, false, 62, 8, 37, 50, null, null },
                    { 583, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(6575), true, false, 62, 9, 40, 50, null, null },
                    { 584, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(6576), true, false, 62, 10, 43, 50, null, null },
                    { 585, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(6578), true, false, 62, 11, 46, 50, null, null },
                    { 586, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(6578), true, false, 62, 11, 47, 50, null, null },
                    { 587, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(6579), true, false, 62, 11, 48, 50, null, null },
                    { 588, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(6580), true, false, 62, 11, 50, 50, null, null },
                    { 589, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(6581), true, false, 62, 11, 51, 50, null, null },
                    { 590, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(7833), true, false, 63, 1, 52, 50, null, null },
                    { 591, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(7834), true, false, 63, 1, 53, 50, null, null },
                    { 592, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(7835), true, false, 63, 1, 54, 50, null, null },
                    { 593, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(7836), true, false, 63, 8, 37, 50, null, null },
                    { 594, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(7837), true, false, 63, 9, 40, 50, null, null },
                    { 595, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(7837), true, false, 63, 10, 43, 50, null, null },
                    { 596, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(7840), true, false, 63, 11, 46, 50, null, null },
                    { 597, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(7841), true, false, 63, 11, 47, 50, null, null },
                    { 598, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(7841), true, false, 63, 11, 48, 50, null, null },
                    { 599, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(7842), true, false, 63, 11, 50, 50, null, null },
                    { 600, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(7843), true, false, 63, 11, 51, 50, null, null },
                    { 601, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(8935), true, false, 64, 1, 52, 50, null, null },
                    { 602, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(8936), true, false, 64, 1, 53, 50, null, null },
                    { 603, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(8936), true, false, 64, 1, 54, 50, null, null },
                    { 604, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(8937), true, false, 64, 8, 37, 50, null, null },
                    { 605, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(8938), true, false, 64, 9, 40, 50, null, null },
                    { 606, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(8939), true, false, 64, 10, 43, 50, null, null },
                    { 607, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(8942), true, false, 64, 11, 46, 50, null, null },
                    { 608, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(8943), true, false, 64, 11, 47, 50, null, null },
                    { 609, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(8944), true, false, 64, 11, 48, 50, null, null },
                    { 610, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(8945), true, false, 64, 11, 50, 50, null, null },
                    { 611, null, new DateTime(2025, 9, 21, 17, 4, 33, 777, DateTimeKind.Local).AddTicks(8946), true, false, 64, 11, 51, 50, null, null },
                    { 612, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(267), true, false, 65, 1, 52, 50, null, null },
                    { 613, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(268), true, false, 65, 1, 53, 50, null, null },
                    { 614, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(268), true, false, 65, 1, 54, 50, null, null },
                    { 615, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(269), true, false, 65, 8, 37, 50, null, null },
                    { 616, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(270), true, false, 65, 9, 40, 50, null, null },
                    { 617, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(270), true, false, 65, 10, 43, 50, null, null },
                    { 618, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(273), true, false, 65, 11, 46, 50, null, null },
                    { 619, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(274), true, false, 65, 11, 47, 50, null, null },
                    { 620, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(274), true, false, 65, 11, 48, 50, null, null },
                    { 621, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(275), true, false, 65, 11, 50, 50, null, null },
                    { 622, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(276), true, false, 65, 11, 51, 50, null, null },
                    { 623, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(1823), true, false, 66, 1, 52, 50, null, null },
                    { 624, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(1824), true, false, 66, 1, 53, 50, null, null },
                    { 625, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(1824), true, false, 66, 1, 54, 50, null, null },
                    { 626, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(1825), true, false, 66, 8, 37, 50, null, null },
                    { 627, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(1826), true, false, 66, 9, 40, 50, null, null },
                    { 628, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(1827), true, false, 66, 10, 43, 50, null, null },
                    { 629, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(1829), true, false, 66, 11, 46, 50, null, null },
                    { 630, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(1829), true, false, 66, 11, 47, 50, null, null },
                    { 631, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(1831), true, false, 66, 11, 48, 50, null, null },
                    { 632, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(1832), true, false, 66, 11, 50, 50, null, null },
                    { 633, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(1833), true, false, 66, 11, 51, 50, null, null },
                    { 634, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(3559), true, false, 67, 1, 52, 50, null, null },
                    { 635, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(3560), true, false, 67, 1, 53, 50, null, null },
                    { 636, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(3561), true, false, 67, 1, 54, 50, null, null },
                    { 637, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(3561), true, false, 67, 8, 37, 50, null, null },
                    { 638, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(3562), true, false, 67, 9, 40, 50, null, null },
                    { 639, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(3562), true, false, 67, 10, 43, 50, null, null },
                    { 640, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(3564), true, false, 67, 11, 46, 50, null, null },
                    { 641, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(3565), true, false, 67, 11, 47, 50, null, null },
                    { 642, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(3566), true, false, 67, 11, 48, 50, null, null },
                    { 643, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(3567), true, false, 67, 11, 50, 50, null, null },
                    { 644, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(3568), true, false, 67, 11, 51, 50, null, null },
                    { 645, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(5806), true, false, 68, 1, 52, 50, null, null },
                    { 646, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(5807), true, false, 68, 1, 53, 50, null, null },
                    { 647, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(5808), true, false, 68, 1, 54, 50, null, null },
                    { 648, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(5809), true, false, 68, 8, 37, 50, null, null },
                    { 649, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(5812), true, false, 68, 9, 40, 50, null, null },
                    { 650, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(5814), true, false, 68, 10, 43, 50, null, null },
                    { 651, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(6037), true, false, 68, 11, 46, 50, null, null },
                    { 652, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(6038), true, false, 68, 11, 47, 50, null, null },
                    { 653, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(6039), true, false, 68, 11, 48, 50, null, null },
                    { 654, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(6040), true, false, 68, 11, 50, 50, null, null },
                    { 655, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(6041), true, false, 68, 11, 51, 50, null, null },
                    { 656, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(7193), true, false, 69, 1, 52, 50, null, null },
                    { 657, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(7263), true, false, 69, 1, 53, 50, null, null },
                    { 658, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(7264), true, false, 69, 1, 54, 50, null, null },
                    { 659, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(7265), true, false, 69, 8, 37, 50, null, null },
                    { 660, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(7266), true, false, 69, 9, 40, 50, null, null },
                    { 661, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(7267), true, false, 69, 10, 43, 50, null, null },
                    { 662, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(7270), true, false, 69, 11, 46, 50, null, null },
                    { 663, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(7271), true, false, 69, 11, 47, 50, null, null },
                    { 664, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(7272), true, false, 69, 11, 48, 50, null, null },
                    { 665, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(7272), true, false, 69, 11, 50, 50, null, null },
                    { 666, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(7273), true, false, 69, 11, 51, 50, null, null },
                    { 667, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(8530), true, false, 70, 1, 52, 50, null, null },
                    { 668, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(8530), true, false, 70, 1, 53, 50, null, null },
                    { 669, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(8531), true, false, 70, 1, 54, 50, null, null },
                    { 670, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(8532), true, false, 70, 8, 37, 50, null, null },
                    { 671, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(8533), true, false, 70, 9, 40, 50, null, null },
                    { 672, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(8533), true, false, 70, 10, 43, 50, null, null },
                    { 673, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(8535), true, false, 70, 11, 46, 50, null, null },
                    { 674, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(8536), true, false, 70, 11, 47, 50, null, null },
                    { 675, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(8536), true, false, 70, 11, 48, 50, null, null },
                    { 676, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(8537), true, false, 70, 11, 50, 50, null, null },
                    { 677, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(8538), true, false, 70, 11, 51, 50, null, null },
                    { 678, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(9480), true, false, 71, 1, 52, 50, null, null },
                    { 679, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(9481), true, false, 71, 1, 53, 50, null, null },
                    { 680, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(9482), true, false, 71, 1, 54, 50, null, null },
                    { 681, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(9482), true, false, 71, 8, 37, 50, null, null },
                    { 682, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(9483), true, false, 71, 9, 40, 50, null, null },
                    { 683, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(9484), true, false, 71, 10, 43, 50, null, null },
                    { 684, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(9486), true, false, 71, 11, 46, 50, null, null },
                    { 685, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(9486), true, false, 71, 11, 47, 50, null, null },
                    { 686, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(9487), true, false, 71, 11, 48, 50, null, null },
                    { 687, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(9487), true, false, 71, 11, 50, 50, null, null },
                    { 688, null, new DateTime(2025, 9, 21, 17, 4, 33, 778, DateTimeKind.Local).AddTicks(9488), true, false, 71, 11, 51, 50, null, null },
                    { 689, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(346), true, false, 72, 1, 52, 50, null, null },
                    { 690, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(347), true, false, 72, 1, 53, 50, null, null },
                    { 691, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(347), true, false, 72, 1, 54, 50, null, null },
                    { 692, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(348), true, false, 72, 8, 37, 50, null, null },
                    { 693, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(348), true, false, 72, 9, 40, 50, null, null },
                    { 694, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(349), true, false, 72, 10, 43, 50, null, null },
                    { 695, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(350), true, false, 72, 11, 46, 50, null, null },
                    { 696, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(351), true, false, 72, 11, 47, 50, null, null },
                    { 697, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(351), true, false, 72, 11, 48, 50, null, null },
                    { 698, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(352), true, false, 72, 11, 50, 50, null, null },
                    { 699, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(352), true, false, 72, 11, 51, 50, null, null },
                    { 700, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(864), true, false, 73, 1, 52, 50, null, null },
                    { 701, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(865), true, false, 73, 1, 53, 50, null, null },
                    { 702, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(865), true, false, 73, 1, 54, 50, null, null },
                    { 703, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(866), true, false, 73, 8, 37, 50, null, null },
                    { 704, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(866), true, false, 73, 9, 40, 50, null, null },
                    { 705, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(867), true, false, 73, 10, 43, 50, null, null },
                    { 706, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(868), true, false, 73, 11, 46, 50, null, null },
                    { 707, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(869), true, false, 73, 11, 47, 50, null, null },
                    { 708, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(869), true, false, 73, 11, 48, 50, null, null },
                    { 709, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(869), true, false, 73, 11, 50, 50, null, null },
                    { 710, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(870), true, false, 73, 11, 51, 50, null, null },
                    { 711, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(1380), true, false, 74, 1, 53, 50, null, null },
                    { 712, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(1382), true, false, 74, 3, 11, 50, null, null },
                    { 713, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(1902), true, false, 75, 1, 52, 50, null, null },
                    { 714, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(1903), true, false, 75, 3, 11, 50, null, null },
                    { 715, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(2498), true, false, 76, 1, 52, 50, null, null },
                    { 716, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(2498), true, false, 76, 3, 11, 50, null, null },
                    { 717, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(3031), true, false, 77, 1, 52, 50, null, null },
                    { 718, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(3032), true, false, 77, 3, 11, 50, null, null },
                    { 719, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(3558), true, false, 78, 1, 52, 50, null, null },
                    { 720, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(3558), true, false, 78, 3, 14, 50, null, null },
                    { 721, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(4328), true, false, 79, 1, 58, 50, null, null },
                    { 722, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(4329), true, false, 79, 3, 14, 50, null, null },
                    { 723, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(7132), true, false, 80, 1, 55, 50, null, null },
                    { 724, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(7136), true, false, 80, 3, 11, 50, null, null },
                    { 725, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(7954), true, false, 81, 1, 54, 50, null, null },
                    { 726, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(7955), true, false, 81, 3, 14, 50, null, null },
                    { 727, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(8576), true, false, 82, 1, 54, 50, null, null },
                    { 728, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(8577), true, false, 82, 3, 11, 50, null, null },
                    { 729, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(9168), true, false, 83, 1, 52, 50, null, null },
                    { 730, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(9169), true, false, 83, 3, 14, 50, null, null },
                    { 731, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(9728), true, false, 84, 1, 54, 50, null, null },
                    { 732, null, new DateTime(2025, 9, 21, 17, 4, 33, 779, DateTimeKind.Local).AddTicks(9729), true, false, 84, 3, 11, 50, null, null },
                    { 733, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(285), true, false, 85, 1, 52, 50, null, null },
                    { 734, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(286), true, false, 85, 3, 14, 50, null, null },
                    { 735, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(983), true, false, 86, 1, 53, 50, null, null },
                    { 736, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(985), true, false, 86, 3, 14, 50, null, null },
                    { 737, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(1616), true, false, 87, 1, 55, 50, null, null },
                    { 738, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(1617), true, false, 87, 3, 11, 50, null, null },
                    { 739, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(2271), true, false, 88, 1, 60, 50, null, null },
                    { 740, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(2272), true, false, 88, 3, 11, 50, null, null },
                    { 741, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(3149), true, false, 89, 1, 52, 50, null, null },
                    { 742, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(3150), true, false, 89, 3, 11, 50, null, null },
                    { 743, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(3830), true, false, 90, 1, 54, 50, null, null },
                    { 744, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(3831), true, false, 90, 3, 14, 50, null, null },
                    { 745, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(4567), true, false, 91, 1, 64, 50, null, null },
                    { 746, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(4609), true, false, 91, 3, 14, 50, null, null },
                    { 747, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(5402), true, false, 92, 1, 53, 50, null, null },
                    { 748, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(5403), true, false, 92, 3, 11, 50, null, null },
                    { 749, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(6053), true, false, 93, 1, 57, 50, null, null },
                    { 750, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(6054), true, false, 93, 3, 11, 50, null, null },
                    { 751, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(6688), true, false, 94, 1, 56, 50, null, null },
                    { 752, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(6690), true, false, 94, 3, 14, 50, null, null },
                    { 753, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(7350), true, false, 95, 1, 56, 50, null, null },
                    { 754, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(7351), true, false, 95, 3, 11, 50, null, null },
                    { 755, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(8328), true, false, 96, 1, 59, 50, null, null },
                    { 756, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(8329), true, false, 96, 3, 14, 50, null, null },
                    { 757, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(8952), true, false, 97, 1, 52, 50, null, null },
                    { 758, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(8953), true, false, 97, 3, 14, 50, null, null },
                    { 759, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(9554), true, false, 98, 1, 53, 50, null, null },
                    { 760, null, new DateTime(2025, 9, 21, 17, 4, 33, 780, DateTimeKind.Local).AddTicks(9554), true, false, 98, 3, 11, 50, null, null },
                    { 761, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(145), true, false, 99, 1, 55, 50, null, null },
                    { 762, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(146), true, false, 99, 3, 11, 50, null, null },
                    { 763, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(726), true, false, 100, 1, 52, 50, null, null },
                    { 764, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(727), true, false, 100, 3, 11, 50, null, null },
                    { 765, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(1408), true, false, 101, 1, 52, 50, null, null },
                    { 766, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(1409), true, false, 101, 3, 14, 50, null, null },
                    { 767, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(1979), true, false, 102, 1, 57, 50, null, null },
                    { 768, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(1980), true, false, 102, 3, 14, 50, null, null },
                    { 769, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(2500), true, false, 103, 1, 53, 50, null, null },
                    { 770, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(2501), true, false, 103, 3, 14, 50, null, null },
                    { 771, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(3209), true, false, 104, 1, 52, 50, null, null },
                    { 772, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(3210), true, false, 104, 3, 14, 50, null, null },
                    { 773, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(3989), true, false, 105, 1, 53, 50, null, null },
                    { 774, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(3990), true, false, 105, 3, 11, 50, null, null },
                    { 775, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(4537), true, false, 106, 1, 61, 50, null, null },
                    { 776, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(4538), true, false, 106, 3, 14, 50, null, null },
                    { 777, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(5178), true, false, 107, 1, 52, 50, null, null },
                    { 778, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(5178), true, false, 107, 3, 14, 50, null, null },
                    { 779, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(6123), true, false, 108, 1, 58, 50, null, null },
                    { 780, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(6124), true, false, 108, 3, 14, 50, null, null },
                    { 781, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(7023), true, false, 109, 1, 56, 50, null, null },
                    { 782, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(7024), true, false, 109, 3, 11, 50, null, null },
                    { 783, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(7748), true, false, 110, 1, 62, 50, null, null },
                    { 784, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(7749), true, false, 110, 3, 14, 50, null, null },
                    { 785, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(8473), true, false, 111, 1, 52, 50, null, null },
                    { 786, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(8474), true, false, 111, 3, 14, 50, null, null },
                    { 787, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(9148), true, false, 112, 1, 63, 50, null, null },
                    { 788, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(9149), true, false, 112, 3, 14, 50, null, null },
                    { 789, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(9769), true, false, 113, 1, 52, 50, null, null },
                    { 790, null, new DateTime(2025, 9, 21, 17, 4, 33, 781, DateTimeKind.Local).AddTicks(9770), true, false, 113, 3, 11, 50, null, null },
                    { 791, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(500), true, false, 114, 1, 52, 50, null, null },
                    { 792, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(502), true, false, 114, 3, 14, 50, null, null },
                    { 793, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(1125), true, false, 115, 1, 52, 50, null, null },
                    { 794, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(1126), true, false, 115, 3, 11, 50, null, null },
                    { 795, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(1751), true, false, 116, 1, 52, 50, null, null },
                    { 796, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(1752), true, false, 116, 3, 14, 50, null, null },
                    { 797, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(2311), true, false, 117, 1, 52, 50, null, null },
                    { 798, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(2312), true, false, 117, 3, 11, 50, null, null },
                    { 799, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(2846), true, false, 118, 1, 61, 50, null, null },
                    { 800, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(2847), true, false, 118, 3, 14, 50, null, null },
                    { 801, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(3386), true, false, 119, 1, 52, 50, null, null },
                    { 802, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(3387), true, false, 119, 3, 14, 50, null, null },
                    { 803, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(3928), true, false, 120, 1, 52, 50, null, null },
                    { 804, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(3929), true, false, 120, 3, 14, 50, null, null },
                    { 805, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(4489), true, false, 121, 1, 52, 50, null, null },
                    { 806, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(4490), true, false, 121, 3, 11, 50, null, null },
                    { 807, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(5065), true, false, 122, 1, 53, 50, null, null },
                    { 808, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(5065), true, false, 122, 3, 11, 50, null, null },
                    { 809, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(5594), true, false, 123, 1, 52, 50, null, null },
                    { 810, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(5594), true, false, 123, 3, 14, 50, null, null },
                    { 811, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(6098), true, false, 124, 1, 57, 50, null, null },
                    { 812, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(6099), true, false, 124, 3, 14, 50, null, null },
                    { 813, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(6631), true, false, 125, 1, 52, 50, null, null },
                    { 814, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(6632), true, false, 125, 3, 14, 50, null, null },
                    { 815, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(7164), true, false, 126, 1, 56, 50, null, null },
                    { 816, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(7165), true, false, 126, 3, 14, 50, null, null },
                    { 817, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(7672), true, false, 127, 1, 52, 50, null, null },
                    { 818, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(7673), true, false, 127, 3, 11, 50, null, null },
                    { 819, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(8216), true, false, 128, 1, 52, 50, null, null },
                    { 820, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(8217), true, false, 128, 3, 14, 50, null, null },
                    { 821, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(8805), true, false, 129, 1, 53, 50, null, null },
                    { 822, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(8806), true, false, 129, 3, 11, 50, null, null },
                    { 823, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(9378), true, false, 130, 1, 53, 50, null, null },
                    { 824, null, new DateTime(2025, 9, 21, 17, 4, 33, 782, DateTimeKind.Local).AddTicks(9935), true, false, 131, 1, 53, 50, null, null },
                    { 825, null, new DateTime(2025, 9, 21, 17, 4, 33, 783, DateTimeKind.Local).AddTicks(490), true, false, 132, 1, 53, 50, null, null },
                    { 826, null, new DateTime(2025, 9, 21, 17, 4, 33, 783, DateTimeKind.Local).AddTicks(1037), true, false, 133, 1, 53, 50, null, null },
                    { 827, null, new DateTime(2025, 9, 21, 17, 4, 33, 783, DateTimeKind.Local).AddTicks(1629), true, false, 134, 1, 53, 50, null, null },
                    { 828, null, new DateTime(2025, 9, 21, 17, 4, 33, 783, DateTimeKind.Local).AddTicks(2205), true, false, 135, 1, 53, 50, null, null },
                    { 829, null, new DateTime(2025, 9, 21, 17, 4, 33, 783, DateTimeKind.Local).AddTicks(2781), true, false, 136, 1, 53, 50, null, null },
                    { 830, null, new DateTime(2025, 9, 21, 17, 4, 33, 783, DateTimeKind.Local).AddTicks(3715), true, false, 137, 1, 53, 50, null, null },
                    { 831, null, new DateTime(2025, 9, 21, 17, 4, 33, 783, DateTimeKind.Local).AddTicks(4523), true, false, 138, 1, 53, 50, null, null },
                    { 832, null, new DateTime(2025, 9, 21, 17, 4, 33, 783, DateTimeKind.Local).AddTicks(5501), true, false, 139, 1, 53, 50, null, null },
                    { 833, null, new DateTime(2025, 9, 21, 17, 4, 33, 783, DateTimeKind.Local).AddTicks(6112), true, false, 140, 1, 53, 50, null, null },
                    { 834, null, new DateTime(2025, 9, 21, 17, 4, 33, 786, DateTimeKind.Local).AddTicks(428), true, false, 141, 1, 65, 50, null, null },
                    { 835, null, new DateTime(2025, 9, 21, 17, 4, 33, 786, DateTimeKind.Local).AddTicks(1824), true, false, 142, 1, 65, 50, null, null },
                    { 836, null, new DateTime(2025, 9, 21, 17, 4, 33, 786, DateTimeKind.Local).AddTicks(2752), true, false, 143, 1, 65, 50, null, null },
                    { 837, null, new DateTime(2025, 9, 21, 17, 4, 33, 786, DateTimeKind.Local).AddTicks(3326), true, false, 144, 1, 65, 50, null, null },
                    { 838, null, new DateTime(2025, 9, 21, 17, 4, 33, 786, DateTimeKind.Local).AddTicks(3924), true, false, 145, 1, 65, 50, null, null },
                    { 839, null, new DateTime(2025, 9, 21, 17, 4, 33, 786, DateTimeKind.Local).AddTicks(5807), true, false, 146, 1, 66, 50, null, null },
                    { 840, null, new DateTime(2025, 9, 21, 17, 4, 33, 786, DateTimeKind.Local).AddTicks(6752), true, false, 147, 1, 66, 50, null, null },
                    { 841, null, new DateTime(2025, 9, 21, 17, 4, 33, 786, DateTimeKind.Local).AddTicks(7524), true, false, 148, 1, 66, 50, null, null },
                    { 842, null, new DateTime(2025, 9, 21, 17, 4, 33, 786, DateTimeKind.Local).AddTicks(8285), true, false, 149, 1, 66, 50, null, null },
                    { 843, null, new DateTime(2025, 9, 21, 17, 4, 33, 786, DateTimeKind.Local).AddTicks(9123), true, false, 150, 1, 66, 50, null, null },
                    { 844, null, new DateTime(2025, 9, 21, 17, 4, 33, 786, DateTimeKind.Local).AddTicks(9818), true, false, 151, 1, 53, 50, null, null },
                    { 845, null, new DateTime(2025, 9, 21, 17, 4, 33, 787, DateTimeKind.Local).AddTicks(405), true, false, 152, 1, 53, 50, null, null },
                    { 846, null, new DateTime(2025, 9, 21, 17, 4, 33, 787, DateTimeKind.Local).AddTicks(1178), true, false, 153, 1, 53, 50, null, null },
                    { 847, null, new DateTime(2025, 9, 21, 17, 4, 33, 787, DateTimeKind.Local).AddTicks(2012), true, false, 154, 1, 53, 50, null, null },
                    { 848, null, new DateTime(2025, 9, 21, 17, 4, 33, 787, DateTimeKind.Local).AddTicks(2613), true, false, 155, 1, 53, 50, null, null },
                    { 849, null, new DateTime(2025, 9, 21, 17, 4, 33, 787, DateTimeKind.Local).AddTicks(3231), true, false, 156, 1, 53, 50, null, null },
                    { 850, null, new DateTime(2025, 9, 21, 17, 4, 33, 787, DateTimeKind.Local).AddTicks(3904), true, false, 157, 1, 53, 50, null, null },
                    { 851, null, new DateTime(2025, 9, 21, 17, 4, 33, 787, DateTimeKind.Local).AddTicks(4472), true, false, 158, 1, 53, 50, null, null },
                    { 852, null, new DateTime(2025, 9, 21, 17, 4, 33, 787, DateTimeKind.Local).AddTicks(5008), true, false, 159, 1, 53, 50, null, null },
                    { 853, null, new DateTime(2025, 9, 21, 17, 4, 33, 787, DateTimeKind.Local).AddTicks(5807), true, false, 160, 1, 53, 50, null, null },
                    { 854, null, new DateTime(2025, 9, 21, 17, 4, 33, 787, DateTimeKind.Local).AddTicks(6477), true, false, 161, 1, 65, 50, null, null },
                    { 855, null, new DateTime(2025, 9, 21, 17, 4, 33, 787, DateTimeKind.Local).AddTicks(7554), true, false, 162, 1, 65, 50, null, null },
                    { 856, null, new DateTime(2025, 9, 21, 17, 4, 33, 787, DateTimeKind.Local).AddTicks(8277), true, false, 163, 1, 65, 50, null, null },
                    { 857, null, new DateTime(2025, 9, 21, 17, 4, 33, 787, DateTimeKind.Local).AddTicks(9242), true, false, 164, 1, 65, 50, null, null },
                    { 858, null, new DateTime(2025, 9, 21, 17, 4, 33, 788, DateTimeKind.Local).AddTicks(388), true, false, 165, 1, 65, 50, null, null },
                    { 859, null, new DateTime(2025, 9, 21, 17, 4, 33, 788, DateTimeKind.Local).AddTicks(1565), true, false, 166, 1, 66, 50, null, null },
                    { 860, null, new DateTime(2025, 9, 21, 17, 4, 33, 788, DateTimeKind.Local).AddTicks(2491), true, false, 167, 1, 66, 50, null, null },
                    { 861, null, new DateTime(2025, 9, 21, 17, 4, 33, 788, DateTimeKind.Local).AddTicks(3412), true, false, 168, 1, 66, 50, null, null },
                    { 862, null, new DateTime(2025, 9, 21, 17, 4, 33, 788, DateTimeKind.Local).AddTicks(4048), true, false, 169, 1, 66, 50, null, null },
                    { 863, null, new DateTime(2025, 9, 21, 17, 4, 33, 788, DateTimeKind.Local).AddTicks(4668), true, false, 170, 1, 66, 50, null, null },
                    { 864, null, new DateTime(2025, 9, 21, 17, 4, 33, 788, DateTimeKind.Local).AddTicks(5339), true, false, 171, 1, 53, 50, null, null },
                    { 865, null, new DateTime(2025, 9, 21, 17, 4, 33, 788, DateTimeKind.Local).AddTicks(5922), true, false, 172, 1, 53, 50, null, null },
                    { 866, null, new DateTime(2025, 9, 21, 17, 4, 33, 788, DateTimeKind.Local).AddTicks(6453), true, false, 173, 1, 53, 50, null, null },
                    { 867, null, new DateTime(2025, 9, 21, 17, 4, 33, 788, DateTimeKind.Local).AddTicks(6959), true, false, 174, 1, 53, 50, null, null },
                    { 868, null, new DateTime(2025, 9, 21, 17, 4, 33, 788, DateTimeKind.Local).AddTicks(7486), true, false, 175, 1, 53, 50, null, null },
                    { 869, null, new DateTime(2025, 9, 21, 17, 4, 33, 788, DateTimeKind.Local).AddTicks(8107), true, false, 176, 1, 53, 50, null, null },
                    { 870, null, new DateTime(2025, 9, 21, 17, 4, 33, 788, DateTimeKind.Local).AddTicks(8617), true, false, 177, 1, 53, 50, null, null },
                    { 871, null, new DateTime(2025, 9, 21, 17, 4, 33, 788, DateTimeKind.Local).AddTicks(9132), true, false, 178, 1, 53, 50, null, null },
                    { 872, null, new DateTime(2025, 9, 21, 17, 4, 33, 788, DateTimeKind.Local).AddTicks(9676), true, false, 179, 1, 53, 50, null, null },
                    { 873, null, new DateTime(2025, 9, 21, 17, 4, 33, 789, DateTimeKind.Local).AddTicks(219), true, false, 180, 1, 53, 50, null, null },
                    { 874, null, new DateTime(2025, 9, 21, 17, 4, 33, 789, DateTimeKind.Local).AddTicks(1319), true, false, 181, 1, 65, 50, null, null },
                    { 875, null, new DateTime(2025, 9, 21, 17, 4, 33, 789, DateTimeKind.Local).AddTicks(2352), true, false, 182, 1, 65, 50, null, null },
                    { 876, null, new DateTime(2025, 9, 21, 17, 4, 33, 789, DateTimeKind.Local).AddTicks(3035), true, false, 183, 1, 65, 50, null, null },
                    { 877, null, new DateTime(2025, 9, 21, 17, 4, 33, 789, DateTimeKind.Local).AddTicks(3635), true, false, 184, 1, 65, 50, null, null },
                    { 878, null, new DateTime(2025, 9, 21, 17, 4, 33, 789, DateTimeKind.Local).AddTicks(4267), true, false, 185, 1, 65, 50, null, null },
                    { 879, null, new DateTime(2025, 9, 21, 17, 4, 33, 789, DateTimeKind.Local).AddTicks(4803), true, false, 186, 1, 66, 50, null, null },
                    { 880, null, new DateTime(2025, 9, 21, 17, 4, 33, 789, DateTimeKind.Local).AddTicks(5350), true, false, 187, 1, 66, 50, null, null },
                    { 881, null, new DateTime(2025, 9, 21, 17, 4, 33, 789, DateTimeKind.Local).AddTicks(5911), true, false, 188, 1, 66, 50, null, null },
                    { 882, null, new DateTime(2025, 9, 21, 17, 4, 33, 789, DateTimeKind.Local).AddTicks(6464), true, false, 189, 1, 66, 50, null, null },
                    { 883, null, new DateTime(2025, 9, 21, 17, 4, 33, 789, DateTimeKind.Local).AddTicks(7057), true, false, 190, 1, 66, 50, null, null },
                    { 884, null, new DateTime(2025, 9, 21, 17, 4, 33, 789, DateTimeKind.Local).AddTicks(7592), true, false, 191, 1, 65, 50, null, null },
                    { 885, null, new DateTime(2025, 9, 21, 17, 4, 33, 789, DateTimeKind.Local).AddTicks(8127), true, false, 192, 1, 65, 50, null, null },
                    { 886, null, new DateTime(2025, 9, 21, 17, 4, 33, 789, DateTimeKind.Local).AddTicks(8674), true, false, 193, 1, 65, 50, null, null },
                    { 887, null, new DateTime(2025, 9, 21, 17, 4, 33, 789, DateTimeKind.Local).AddTicks(9153), true, false, 194, 1, 65, 50, null, null },
                    { 888, null, new DateTime(2025, 9, 21, 17, 4, 33, 789, DateTimeKind.Local).AddTicks(9725), true, false, 195, 1, 65, 50, null, null },
                    { 889, null, new DateTime(2025, 9, 21, 17, 4, 33, 790, DateTimeKind.Local).AddTicks(263), true, false, 196, 1, 66, 50, null, null },
                    { 890, null, new DateTime(2025, 9, 21, 17, 4, 33, 790, DateTimeKind.Local).AddTicks(785), true, false, 197, 1, 66, 50, null, null },
                    { 891, null, new DateTime(2025, 9, 21, 17, 4, 33, 790, DateTimeKind.Local).AddTicks(1264), true, false, 198, 1, 66, 50, null, null },
                    { 892, null, new DateTime(2025, 9, 21, 17, 4, 33, 790, DateTimeKind.Local).AddTicks(1799), true, false, 199, 1, 66, 50, null, null },
                    { 893, null, new DateTime(2025, 9, 21, 17, 4, 33, 790, DateTimeKind.Local).AddTicks(2328), true, false, 200, 1, 66, 50, null, null },
                    { 894, null, new DateTime(2025, 9, 21, 17, 4, 33, 790, DateTimeKind.Local).AddTicks(2829), true, false, 192, 1, 52, 50, null, null },
                    { 895, null, new DateTime(2025, 9, 21, 17, 4, 33, 790, DateTimeKind.Local).AddTicks(3424), true, false, 193, 1, 52, 50, null, null },
                    { 896, null, new DateTime(2025, 9, 21, 17, 4, 33, 790, DateTimeKind.Local).AddTicks(3959), true, false, 194, 1, 52, 50, null, null },
                    { 897, null, new DateTime(2025, 9, 21, 17, 4, 33, 790, DateTimeKind.Local).AddTicks(4516), true, false, 195, 1, 52, 50, null, null },
                    { 898, null, new DateTime(2025, 9, 21, 17, 4, 33, 790, DateTimeKind.Local).AddTicks(5081), true, false, 196, 1, 52, 50, null, null },
                    { 899, null, new DateTime(2025, 9, 21, 17, 4, 33, 790, DateTimeKind.Local).AddTicks(5667), true, false, 197, 1, 67, 50, null, null },
                    { 900, null, new DateTime(2025, 9, 21, 17, 4, 33, 790, DateTimeKind.Local).AddTicks(6446), true, false, 198, 1, 52, 50, null, null },
                    { 901, null, new DateTime(2025, 9, 21, 17, 4, 33, 790, DateTimeKind.Local).AddTicks(6993), true, false, 199, 1, 52, 50, null, null },
                    { 902, null, new DateTime(2025, 9, 21, 17, 4, 33, 790, DateTimeKind.Local).AddTicks(7642), true, false, 200, 1, 52, 50, null, null },
                    { 903, null, new DateTime(2025, 9, 21, 17, 4, 33, 790, DateTimeKind.Local).AddTicks(8261), true, false, 201, 1, 52, 50, null, null },
                    { 904, null, new DateTime(2025, 9, 21, 17, 4, 33, 790, DateTimeKind.Local).AddTicks(9011), true, false, 202, 1, 56, 50, null, null },
                    { 905, null, new DateTime(2025, 9, 21, 17, 4, 33, 790, DateTimeKind.Local).AddTicks(9590), true, false, 203, 1, 52, 50, null, null },
                    { 906, null, new DateTime(2025, 9, 21, 17, 4, 33, 791, DateTimeKind.Local).AddTicks(143), true, false, 204, 1, 52, 50, null, null },
                    { 907, null, new DateTime(2025, 9, 21, 17, 4, 33, 791, DateTimeKind.Local).AddTicks(674), true, false, 205, 1, 52, 50, null, null },
                    { 908, null, new DateTime(2025, 9, 21, 17, 4, 33, 791, DateTimeKind.Local).AddTicks(1937), true, false, 206, 1, 72, 50, null, null },
                    { 909, null, new DateTime(2025, 9, 21, 17, 4, 33, 791, DateTimeKind.Local).AddTicks(3282), true, false, 207, 1, 52, 50, null, null },
                    { 910, null, new DateTime(2025, 9, 21, 17, 4, 33, 791, DateTimeKind.Local).AddTicks(4637), true, false, 208, 1, 56, 50, null, null },
                    { 911, null, new DateTime(2025, 9, 21, 17, 4, 33, 791, DateTimeKind.Local).AddTicks(5723), true, false, 209, 1, 73, 50, null, null }
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
