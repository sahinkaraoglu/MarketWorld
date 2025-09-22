using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CatalogService.Migrations
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    { 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6005), true, false, "Apple", null, null },
                    { 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6008), true, false, "Asus", null, null },
                    { 3, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6010), true, false, "Casper", null, null },
                    { 4, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6011), true, false, "HP", null, null },
                    { 5, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6013), true, false, "Lenovo", null, null },
                    { 6, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6015), true, false, "MSI", null, null },
                    { 7, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6017), true, false, "Acer", null, null },
                    { 8, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6018), true, false, "Xiaomi", null, null },
                    { 9, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6020), true, false, "Samsung", null, null },
                    { 10, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6022), true, false, "Huawei", null, null },
                    { 11, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6023), true, false, "Canon", null, null },
                    { 12, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6025), true, false, "Epson", null, null },
                    { 13, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6026), true, false, "Honor", null, null },
                    { 14, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6027), true, false, "Nothing", null, null },
                    { 15, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6028), true, false, "Infinix", null, null },
                    { 16, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6029), true, false, "Redmi", null, null },
                    { 17, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6030), true, false, "POCO", null, null },
                    { 18, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6033), true, false, "Oppo", null, null },
                    { 19, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6034), true, false, "Panasonic", null, null },
                    { 20, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6035), true, false, "Reeder", null, null },
                    { 21, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6036), true, false, "Tecno", null, null },
                    { 22, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6037), true, false, "Arçelik", null, null },
                    { 23, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6039), true, false, "Kumtel", null, null },
                    { 24, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6040), true, false, "Regal", null, null },
                    { 25, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6041), true, false, "Profilo", null, null },
                    { 26, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6042), true, false, "Altus", null, null },
                    { 27, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6043), true, false, "Hoover", null, null },
                    { 28, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6044), true, false, "Uğur", null, null },
                    { 29, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6045), true, false, "Arnell", null, null },
                    { 30, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6047), true, false, "Evora", null, null },
                    { 31, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6049), true, false, "Albergio", null, null },
                    { 32, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6050), true, false, "Kiwi", null, null },
                    { 33, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6051), true, false, "Vestel", null, null },
                    { 34, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6053), true, false, "Airfel", null, null },
                    { 35, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6054), true, false, "Regal", null, null },
                    { 36, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6056), true, false, "Kumtel", null, null },
                    { 37, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6057), true, false, "Bosch", null, null },
                    { 38, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6058), true, false, "Kaira", null, null },
                    { 39, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6059), true, false, "Xiaomi", null, null },
                    { 40, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6060), true, false, "Mirkraft", null, null },
                    { 41, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6061), true, false, "Samsung", null, null },
                    { 42, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6062), true, false, "Arnell", null, null },
                    { 43, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6063), true, false, "Zeeful", null, null },
                    { 44, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6065), true, false, "Beko", null, null },
                    { 45, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6066), true, false, "Arçelik", null, null },
                    { 46, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6067), true, false, "Baymak", null, null },
                    { 47, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6068), true, false, "FujiPlus", null, null },
                    { 48, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6069), true, false, "UFO", null, null },
                    { 49, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6071), true, false, "Abbruch", null, null },
                    { 50, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6072), true, false, "Sinbo", null, null },
                    { 51, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6073), true, false, "Magiceham", null, null },
                    { 52, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6075), true, false, "Demirdöküm", null, null },
                    { 53, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6106), true, false, "Tekdal", null, null },
                    { 54, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6107), true, false, "Raks", null, null },
                    { 55, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6108), true, false, "Hubstein", null, null },
                    { 56, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6110), true, false, "Mitsubishi", null, null },
                    { 57, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6111), true, false, "Goldsun", null, null },
                    { 58, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6112), true, false, "Multiteknik", null, null },
                    { 59, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6113), true, false, "Bayırtech", null, null },
                    { 60, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6114), true, false, "Harlem", null, null },
                    { 61, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6116), true, false, "Veito", null, null },
                    { 62, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6117), true, false, "Torima", null, null },
                    { 63, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6118), true, false, "Kiwi", null, null },
                    { 64, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6119), true, false, "Xnews", null, null },
                    { 65, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6120), true, false, "Hotic", null, null },
                    { 66, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6123), true, false, "Derilax", null, null },
                    { 67, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6124), true, false, "Ispartalılar", null, null },
                    { 68, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6125), true, false, "Selin Soylu", null, null },
                    { 69, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6126), true, false, "Sebago", null, null },
                    { 70, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6127), true, false, "Lumberjack", null, null },
                    { 71, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6129), true, false, "Dakirs", null, null },
                    { 72, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6130), true, false, "Letoon", null, null },
                    { 73, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6131), true, false, "Avva", null, null },
                    { 74, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6132), true, false, "Rmk", null, null },
                    { 75, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6133), true, false, "Tamer Tanca", null, null },
                    { 76, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6134), true, false, "Black Vein", null, null },
                    { 77, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6135), true, false, "Cabani", null, null },
                    { 78, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6137), true, false, "Dockers", null, null },
                    { 79, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6138), true, false, "Dgn", null, null },
                    { 80, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6139), true, false, "Hons", null, null },
                    { 81, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6140), true, false, "Daxtors", null, null },
                    { 82, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6141), true, false, "Tonny Black", null, null },
                    { 83, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6143), true, false, "Ayakkabıx", null, null },
                    { 84, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6144), true, false, "Hammer Jack", null, null },
                    { 85, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6145), true, false, "Kaptan Junior", null, null },
                    { 86, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6146), true, false, "Calvin Klein", null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsActive", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5514), "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar", true, false, "Elektronik", "elektronik", null, null },
                    { 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5533), "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları", true, false, "Giyim & Aksesuar", "giyim-aksesuar", null, null },
                    { 3, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5534), "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili", true, false, "Ev & Yaşam", "ev-yasam", null, null },
                    { 4, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5536), "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri", true, false, "Kozmetik & Kişisel Bakım", "kozmetik-kisisel-bakim", null, null },
                    { 5, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5538), "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri", true, false, "Spor & Outdoor", "spor-outdoor", null, null }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsActive", "IsDeleted", "Name", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4824), "Ürün Renk Seçenekleri", true, false, "Renk", null, null },
                    { 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4836), "Beden Seçenekleri", true, false, "Beden", null, null },
                    { 3, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4837), "Dahili Hafıza", true, false, "Hafıza", null, null },
                    { 4, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4839), "Bilgisayar İşlemci Seçenekleri", true, false, "İşlemci", null, null },
                    { 5, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4840), "Bellek Kapasitesi", true, false, "RAM", null, null },
                    { 6, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4843), "SSD Kapasitesi", true, false, "SSD", null, null },
                    { 7, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4844), "Ekran Boyutu", true, false, "Ekran", null, null },
                    { 8, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4845), "Yazıcı Teknolojisi", true, false, "Yazıcı Tipi", null, null },
                    { 9, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4847), "Mürekkep/Kartuş Sistemi", true, false, "Mürekkep Sistemi", null, null },
                    { 10, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4849), "Desteklenen Kağıt Boyutları", true, false, "Kağıt Boyutu", null, null },
                    { 11, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4850), "Yazıcı Fonksiyonları", true, false, "Fonksiyonlar", null, null }
                });

            migrationBuilder.InsertData(
                table: "PropertyValues",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "PropertyTypeId", "UpdatedById", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4897), true, false, 1, null, null, "Uzay Siyahı" },
                    { 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4903), true, false, 1, null, null, "Altın" },
                    { 3, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4904), true, false, 1, null, null, "Gümüş" },
                    { 4, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4905), true, false, 1, null, null, "Mor" },
                    { 5, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4906), true, false, 2, null, null, "XS" },
                    { 6, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4908), true, false, 2, null, null, "S" },
                    { 7, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4909), true, false, 2, null, null, "M" },
                    { 8, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4911), true, false, 2, null, null, "L" },
                    { 9, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4912), true, false, 2, null, null, "XL" },
                    { 10, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4914), true, false, 2, null, null, "XXL" },
                    { 11, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4915), true, false, 3, null, null, "128GB" },
                    { 12, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4917), true, false, 3, null, null, "256GB" },
                    { 13, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4919), true, false, 3, null, null, "512GB" },
                    { 14, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4920), true, false, 3, null, null, "1TB" },
                    { 15, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4921), true, false, 4, null, null, "Intel Core i7 12700H" },
                    { 16, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4922), true, false, 4, null, null, "Intel Core i7 1255U" },
                    { 17, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4924), true, false, 4, null, null, "Intel Core i7 13620H" },
                    { 18, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4925), true, false, 4, null, null, "Intel Core i5 1334U" },
                    { 19, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4926), true, false, 4, null, null, "Intel Core i5 13420H" },
                    { 20, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4927), true, false, 4, null, null, "AMD Ryzen 7 5700U" },
                    { 21, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4928), true, false, 4, null, null, "Intel Core i5 12450H" },
                    { 22, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4930), true, false, 5, null, null, "8GB" },
                    { 23, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4931), true, false, 5, null, null, "16GB" },
                    { 24, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4932), true, false, 5, null, null, "32GB" },
                    { 25, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4933), true, false, 6, null, null, "256GB" },
                    { 26, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4935), true, false, 6, null, null, "500GB" },
                    { 27, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4936), true, false, 6, null, null, "512GB" },
                    { 28, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4937), true, false, 6, null, null, "1TB" },
                    { 29, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4938), true, false, 7, null, null, "14\"" },
                    { 30, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4940), true, false, 7, null, null, "15.6\"" },
                    { 31, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4941), true, false, 7, null, null, "16\"" },
                    { 32, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4942), true, false, 4, null, null, "Intel Core i7 13650HX" },
                    { 33, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4943), true, false, 4, null, null, "Intel Core i5 13500H" },
                    { 34, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4945), true, false, 4, null, null, "Intel Core i9-14900HX" },
                    { 35, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4946), true, false, 4, null, null, "Intel Core Ultra 7 255HX" },
                    { 36, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4948), true, false, 4, null, null, "AMD Ryzen 5 7520U" },
                    { 37, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4949), true, false, 8, null, null, "Mürekkep Püskürtmeli" },
                    { 38, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4950), true, false, 8, null, null, "Lazer" },
                    { 39, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4951), true, false, 8, null, null, "Süblimasyon" },
                    { 40, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4952), true, false, 9, null, null, "Kartuşlu" },
                    { 41, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4978), true, false, 9, null, null, "Tanklı" },
                    { 42, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4980), true, false, 9, null, null, "Dolum Üniteli" },
                    { 43, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4982), true, false, 10, null, null, "A4" },
                    { 44, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4983), true, false, 10, null, null, "A3" },
                    { 45, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4985), true, false, 10, null, null, "A4/A3" },
                    { 46, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4986), true, false, 11, null, null, "Yazdırma" },
                    { 47, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4987), true, false, 11, null, null, "Tarama" },
                    { 48, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4988), true, false, 11, null, null, "Fotokopi" },
                    { 49, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4989), true, false, 11, null, null, "Faks" },
                    { 50, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4991), true, false, 11, null, null, "Wi-Fi" },
                    { 51, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4992), true, false, 11, null, null, "AirPrint" },
                    { 52, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4993), true, false, 1, null, null, "Siyah" },
                    { 53, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4994), true, false, 1, null, null, "Beyaz" },
                    { 54, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4995), true, false, 1, null, null, "Gri" },
                    { 55, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4996), true, false, 1, null, null, "Açık Mavi" },
                    { 56, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4997), true, false, 1, null, null, "Lacivert" },
                    { 57, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(4998), true, false, 1, null, null, "Mavi" },
                    { 58, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(5000), true, false, 1, null, null, "Mor" },
                    { 59, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(5001), true, false, 1, null, null, "Altın" },
                    { 60, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(5003), true, false, 1, null, null, "Nane Yeşili" },
                    { 61, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(5004), true, false, 1, null, null, "Zümrüt Yeşili" },
                    { 62, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(5005), true, false, 1, null, null, "Lacivert Taş" },
                    { 63, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(5006), true, false, 1, null, null, "Natürel Titanyum" },
                    { 64, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(5007), true, false, 1, null, null, "Grafit" },
                    { 65, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(5008), true, false, 1, null, null, "Antrasit" },
                    { 66, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(5010), true, false, 1, null, null, "Inox" },
                    { 67, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(5012), true, false, 1, null, null, "Kırmızı" },
                    { 68, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(5013), true, false, 1, null, null, "Turkuaz" },
                    { 69, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(5014), true, false, 1, null, null, "Pembe" },
                    { 70, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(5015), true, false, 1, null, null, "Turuncu" },
                    { 71, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(5016), true, false, 1, null, null, "Sarı" },
                    { 72, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(5017), true, false, 1, null, null, "Kahverengi" },
                    { 73, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(5018), true, false, 1, null, null, "Bej" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedDate", "Description", "IsActive", "IsDeleted", "Name", "ShortenedEntityName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5861), "Dizüstü, masaüstü bilgisayarlar ve tabletler", null, false, "Bilgisayarlar & Tabletler", "bilgisayarlar-tabletler", null, null },
                    { 2, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5864), "Yazıcılar, tarayıcılar ve projeksiyon cihazları", null, false, "Yazıcılar & Projeksiyon", "yazicilar-projeksiyon", null, null },
                    { 3, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5867), "Akıllı telefonlar ve aksesuarları", null, false, "Telefonlar", "telefonlar", null, null },
                    { 4, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5869), "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar", null, false, "Beyaz Eşya", "beyaz-esya", null, null },
                    { 5, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5870), "Klimalar, ısıtıcılar ve hava temizleyiciler", null, false, "Klima ve Isıtıcılar", "klima-isitici", null, null },
                    { 6, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5875), "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar", null, false, "Ayakkabı & Çanta", "ayakkabi-canta", null, null },
                    { 7, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5878), "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim", null, false, "Kadın Giyim", "kadin-giyim", null, null },
                    { 8, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5883), "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim", null, false, "Erkek Giyim", "erkek-giyim", null, null },
                    { 9, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5885), "Kız ve erkek çocuk giyim ürünleri", null, false, "Çocuk Giyim", "cocuk-giyim", null, null },
                    { 10, 3, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5886), "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları", null, false, "Mobilya", "mobilya", null, null },
                    { 11, 3, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5888), "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri", null, false, "Ev Tekstili", "ev-tekstili", null, null },
                    { 12, 3, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5890), "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri", null, false, "Dekorasyon & Aydınlatma", "dekorasyon-aydinlatma", null, null },
                    { 13, 3, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5891), "Pişirme, servis ve saklama ürünleri, mutfak aletleri", null, false, "Mutfak Gereçleri", "mutfak-gerecleri", null, null },
                    { 14, 3, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5893), "Banyo aksesuarları, temizlik ve düzenleme ürünleri", null, false, "Banyo & Ev Gereçleri", "banyo-ev-gerecleri", null, null },
                    { 15, 3, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5894), "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri", null, false, "Kırtasiye & Ofis", "kirtasiye-ve-ofis", null, null },
                    { 16, 4, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5895), "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri", null, false, "Parfüm & Deodorant", "parfum-deodorant", null, null },
                    { 17, 4, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5897), "Saç bakım ve şekillendirme ürünleri", null, false, "Saç Şekillendirme", "sac-sekillendirme", null, null },
                    { 18, 4, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5898), "Yüz ve vücut bakım ürünleri, kremler ve serumlar", null, false, "Cilt Bakımı", "cilt-bakimi", null, null },
                    { 19, 4, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5899), "Renkli kozmetik ve makyaj malzemeleri", null, false, "Makyaj", "makyaj", null, null },
                    { 20, 4, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5902), "Vitamin, takviye gıdalar ve medikal ürünler", null, false, "Sağlık & Medikal Ürünler", "saglik-medikal-urunler", null, null },
                    { 21, 4, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5903), "Diş bakım ürünleri ve ağız bakım ürünleri", null, false, "Ağız & Diş Bakımı", "agiz-dis-bakimi", null, null },
                    { 22, 5, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5904), "Fitness ekipmanları, kondisyon aletleri ve aksesuarları", null, false, "Fitness & Kondisyon", "fitness-kondisyon", null, null },
                    { 23, 5, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5952), "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar", null, false, "Spor Giyim & Ayakkabı", "spor-giyim-ayakkabi", null, null },
                    { 24, 5, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5954), "Kamp malzemeleri, outdoor giyim ve ekipmanlar", null, false, "Outdoor & Kamp", "outdoor-kamp", null, null },
                    { 25, 5, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5956), "Kayak ekipmanları ve kış sporları malzemeleri", null, false, "Kış Sporları", "kis-sporlari", null, null },
                    { 26, 5, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(5957), "Yüzme ve su sporları ekipmanları", null, false, "Su Sporları", "su-sporlari", null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedById", "CreatedDate", "Description", "DiscountPrice", "HasDiscount", "IsActive", "IsDeleted", "Name", "Price", "ProductCode", "Rating", "SubCategoryId", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 3, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6269), "Intel Core i7 12700H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1270", 39999.99m, 107098, 4.5m, 1, null, null },
                    { 2, 6, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6277), "Intel Core i7 1255U 16GB 512GB SSD Freedos 14\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "MSI Modern 14 C12MO", 21799.99m, 710024, 4.5m, 1, null, null },
                    { 3, 3, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6284), "Core i7-13620H 32GB DDR5 RAM 1TB NVME SSD 16\" Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana S100", 27299.99m, 952676, 5m, 1, null, null },
                    { 4, 3, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6317), "Intel Core i7 13620H 32GB 1TB SSD RTX4060 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1362", 50199.99m, 541618, 4.5m, 1, null, null },
                    { 5, 4, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6321), "Intel Core i5 1334U 16GB 512GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "HP 250 G10", 14999.99m, 903596, 4.7m, 1, null, null },
                    { 6, 5, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6326), "Intel Core i5 13420H 16GB Ddr5 Ram 512 GB SSD 16'' WUXGA IPS Panel Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad Slim 3", 19799.99m, 721862, 4.9m, 1, null, null },
                    { 7, 5, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6333), "AMD Ryzen 7 5700U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad 1", 15999.99m, 203329, 4.6m, 1, null, null },
                    { 8, 6, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6337), "Intel Core i5 12450H 8GB 512GB SSD RTX2050 Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "MSI Thin 15", 24799.99m, 630930, 4.5m, 1, null, null },
                    { 9, 3, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6343), "Intel Core i7 1255U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana C550", 18999.99m, 779471, 4.5m, 1, null, null },
                    { 10, 5, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6348), "Intel Core i7 13650HX 32GB 1TB SSD RTX 4060 8GB (115W) 15.6\" FHD 144Hz IPS Panel Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo LOQ 15IRX9", 59999.99m, 569244, 5m, 1, null, null },
                    { 11, 3, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6354), "Intel Core i5-12450H 32GB RAM 500GB SSD GEN4 RTX3050 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G770", 31299.99m, 857135, 4.6m, 1, null, null },
                    { 12, 3, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6361), "AMD Ryzen 5 7430U 16GB 500GB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana X600", 16999.99m, 165220, 5m, 1, null, null },
                    { 13, 7, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6366), "Intel Core i7 1255U 16GB 512GB SSD Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Acer Aspire 3", 24000.00m, 246301, 5m, 1, null, null },
                    { 14, 3, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6371), "Intel Core i7 12700H 32GB 1TB SSD Freedos 15.6\" Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Nirvana X600.1270", 22999.99m, 276686, 4.5m, 1, null, null },
                    { 15, 3, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6377), "Intel Core i5-13420H 32GB RAM 500GB NVME SSD GEN4 6GB RTX4050 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G870.1342", 38499.99m, 152293, 4.1m, 1, null, null },
                    { 16, 3, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6384), "Intel Core i7 12700H 32GB 1TB SSD RTX4070 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1270", 50899.99m, 799396, 4m, 1, null, null },
                    { 17, 4, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6387), "Intel Core i5 13500H 16GB 512GB SSD RTX4050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "HP Victus Gaming 15", 33999.99m, 343887, 4.6m, 1, null, null },
                    { 18, 5, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6393), "Intel Core i5 12450H 8GB 512GB SSD 15.6\" FHD Freedos Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo IdeaPad Slim 3", 15359.04m, 481871, 4.7m, 1, null, null },
                    { 19, 2, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6396), "Intel Core i5 12500H 8GB 512GB SSD RTX3050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Asus TUF Gaming F15", 29898.66m, 737169, 4.7m, 1, null, null },
                    { 20, 1, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6400), "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Uzay Grisi", 0m, false, true, false, "Apple MacBook Air M1", 39250.00m, 505862, 4.9m, 1, null, null },
                    { 21, 3, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6404), "Intel Core i5-13420H 16GB RAM 1TB NVME SSD 8GB RTX4060 Freedos Gaming Laptop", 0m, false, true, false, "Casper Excalibur G870.1342", 42299.99m, 803371, 4.3m, 1, null, null },
                    { 22, 5, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6409), "Intel Core i5 13420H 16GB 512GB SSD Freedos 14\" WUXGA Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo Ideapad 5", 29999.99m, 314136, 5m, 1, null, null },
                    { 23, 2, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6413), "Intel Core Ultra 7 255HX 32GB 1TB SSD RTX5070Ti Freedos 16\" Taşınabilir Bilgisayar", 0m, false, true, false, "Asus ROG Strix G16", 107999.99m, 416484, 5m, 1, null, null },
                    { 24, 3, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6418), "Intel Core i5-13420H 32GB RAM 500GB NVME SSD Freedos", 0m, false, true, false, "Casper Nirvana X600.1342", 19999.99m, 337126, 5m, 1, null, null },
                    { 25, 5, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6423), "Intel Core i9-14900HX 32GB DDR5 1TB SSD RTX4060 8GB 16 inç 3.2K (3200×2000) 165Hz FreeDos Laptop", 0m, false, true, false, "Lenovo Thinkbook 16PG5", 79999.40m, 572067, 4.7m, 1, null, null },
                    { 26, 3, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6429), "Intel Core i7-13620H 16GB RAM 500GB NVME SSD Freedos Laptop", 0m, false, true, false, "Casper Nirvana X600.1362", 22099.99m, 652126, 5m, 1, null, null },
                    { 27, 6, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6432), "Intel Core i5 13420H 16GB 1TB SSD RTX4060 Freedos 15.6\" FHD 144Hz Taşınabilir Bilgisayar", 0m, false, true, false, "MSI CYBORG 15", 37999.99m, 892249, 4.9m, 1, null, null },
                    { 28, 5, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6439), "AMD Ryzen 5 7520U 8gb 512GB SSD Freedos 15.6\" Fhd Taşınabilir Bilgisayar", 0m, false, true, false, "Lenovo V15 G4", 13299.99m, 200292, 4.3m, 1, null, null },
                    { 29, 5, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6444), "I5-13420H 32GB 1 Tb SSD 15.6 Fhd Windows 11 Pro", 0m, false, true, false, "Lenovo V15 G4", 27749.00m, 186028, 5m, 1, null, null },
                    { 30, 1, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6449), "16GB 256GB SSD macOS 13\" Taşınabilir Bilgisayar Gece Yarısı", 0m, false, true, false, "Apple MacBook Air M4", 49999.99m, 261646, 5m, 1, null, null },
                    { 31, 3, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6454), "Intel Core i5 12450H 16GB 500GB SSD RTX2050 Freedos 15.6\" FHD Taşınabilir Bilgisayar", 0m, false, true, false, "Casper Excalibur G870.1245", 27499.99m, 212698, 4.4m, 1, null, null },
                    { 32, 4, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6464), "HP Deskjet Ink Advantage 2878 All-In-One Yazıcı", 0m, false, true, false, "HP Deskjet Ink Advantage 2878 All-In-One Yazıcı", 2799.00m, 947411, 4.1m, 2, null, null },
                    { 33, 11, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6469), "Canon Dolan Kartuşlu E414 Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Canon Dolan Kartuşlu E414 Yazıcı", 2299.08m, 408460, 4.4m, 2, null, null },
                    { 34, 11, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6529), "Canon Pixma TR4650 Tarayıcı + Fotokopi + Wi-Fi + Faks + Çok Fonksiyonlu Yazıcı", 0m, false, true, false, "Canon Pixma TR4650", 3379.00m, 230208, 4.2m, 2, null, null },
                    { 35, 11, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6536), "Canon Pixma E3640 Wi-Fi Tarayıcı - Fotokopi Çok Fonksiyonlu Mürekkep Püskürtmeli Yazıcı", 0m, false, true, false, "Canon Pixma E3640 Wi-Fi", 3399.00m, 506949, 4.6m, 2, null, null },
                    { 36, 12, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6541), "Epson L5290 Wi-Fi Renk Tanklı Yazıcı", 0m, false, true, false, "Epson L5290 Wi-Fi Renk Tanklı Yazıcı", 11983.51m, 187460, 4.4m, 2, null, null },
                    { 37, 12, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6549), "Epson Tanklı L3150 Photoink Muadil Mürekkepli Tanklı Yazıcı", 0m, false, true, false, "Epson Tanklı L3150 Photoink", 6033.86m, 607854, 4.6m, 2, null, null },
                    { 38, 4, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6553), "HP Officejet Pro 7720 Fotokopi + Faks + Tarayıcı + Wi-Fi + Airprint + A3 Yazıcı", 0m, false, true, false, "HP Officejet Pro 7720", 11138.06m, 884253, 4.6m, 2, null, null },
                    { 39, 11, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6558), "Canon E3640 Wifi Yazıcı ve Tıpalı Kartuş Sistemi", 0m, false, true, false, "Canon E3640 Wifi Yazıcı", 3306.56m, 953157, 4.3m, 2, null, null },
                    { 40, 12, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6562), "Epson L3151 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L3151 Tanklı Yazıcı", 4999.00m, 513647, 4.5m, 2, null, null },
                    { 41, 4, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6567), "HP LaserJet Pro M428f MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428f", 7999.00m, 482616, 4.3m, 2, null, null },
                    { 42, 11, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6574), "Canon PIXMA G3110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G3110", 3999.00m, 642588, 4.4m, 2, null, null },
                    { 43, 12, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6581), "Epson L3250 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L3250 Tanklı Yazıcı", 4499.00m, 351125, 4.6m, 2, null, null },
                    { 44, 4, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6585), "HP LaserJet Pro M428dw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428dw", 8999.00m, 867826, 4.5m, 2, null, null },
                    { 45, 11, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6598), "Canon PIXMA G4110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G4110", 4499.00m, 978691, 4.3m, 2, null, null },
                    { 46, 12, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6602), "Epson L4260 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4260 Tanklı Yazıcı", 5499.00m, 808045, 4.7m, 2, null, null },
                    { 47, 4, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6607), "HP LaserJet Pro M428fnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fnw", 9999.00m, 659038, 4.4m, 2, null, null },
                    { 48, 11, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6610), "Canon PIXMA G5110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G5110", 4999.00m, 758753, 4.5m, 2, null, null },
                    { 49, 12, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6617), "Epson L4266 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4266 Tanklı Yazıcı", 5999.00m, 469013, 4.6m, 2, null, null },
                    { 50, 4, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6622), "HP LaserJet Pro M428fdw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdw", 10999.00m, 613320, 4.5m, 2, null, null },
                    { 51, 11, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6627), "Canon PIXMA G6110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G6110", 5499.00m, 543115, 4.4m, 2, null, null },
                    { 52, 12, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6632), "Epson L4268 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4268 Tanklı Yazıcı", 6499.00m, 128769, 4.7m, 2, null, null },
                    { 53, 4, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6636), "HP LaserJet Pro M428fdn MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdn", 11999.00m, 718552, 4.6m, 2, null, null },
                    { 54, 11, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6640), "Canon PIXMA G7110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G7110", 5999.00m, 354814, 4.5m, 2, null, null },
                    { 55, 12, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6645), "Epson L4269 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4269 Tanklı Yazıcı", 6999.00m, 774177, 4.8m, 2, null, null },
                    { 56, 4, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6649), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 12999.00m, 346001, 4.7m, 2, null, null },
                    { 57, 11, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6654), "Canon PIXMA G8110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G8110", 6499.00m, 285849, 4.6m, 2, null, null },
                    { 58, 12, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6660), "Epson L4267 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4267 Tanklı Yazıcı", 7499.00m, 832663, 4.9m, 2, null, null },
                    { 59, 4, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6665), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 13999.00m, 243185, 4.8m, 2, null, null },
                    { 60, 11, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6668), "Canon PIXMA G9110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G9110", 6999.00m, 397863, 4.7m, 2, null, null },
                    { 61, 12, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6672), "Epson L4265 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4265 Tanklı Yazıcı", 7999.00m, 613322, 4.8m, 2, null, null },
                    { 62, 4, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6676), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 14999.00m, 716000, 4.9m, 2, null, null },
                    { 63, 11, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6679), "Canon PIXMA G1010 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1010", 7499.00m, 201239, 4.8m, 2, null, null },
                    { 64, 12, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6683), "Epson L4264 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4264 Tanklı Yazıcı", 8499.00m, 249019, 4.9m, 2, null, null },
                    { 65, 4, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6685), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 15999.00m, 497702, 5.0m, 2, null, null },
                    { 66, 11, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6726), "Canon PIXMA G1110 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1110", 7999.00m, 743384, 4.9m, 2, null, null },
                    { 67, 12, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6731), "Epson L4263 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4263 Tanklı Yazıcı", 8999.00m, 501609, 5.0m, 2, null, null },
                    { 68, 4, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6736), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 16999.00m, 992605, 5.0m, 2, null, null },
                    { 69, 11, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6739), "Canon PIXMA G1210 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1210", 8499.00m, 258758, 5.0m, 2, null, null },
                    { 70, 12, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6743), "Epson L4262 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4262 Tanklı Yazıcı", 9499.00m, 557902, 5.0m, 2, null, null },
                    { 71, 4, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6747), "HP LaserJet Pro M428fdnw MFP Siyah Beyaz Lazer Yazıcı", 0m, false, true, false, "HP LaserJet Pro M428fdnw", 17999.00m, 811575, 5.0m, 2, null, null },
                    { 72, 11, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6754), "Canon PIXMA G1310 Tanklı Yazıcı", 0m, false, true, false, "Canon PIXMA G1310", 8999.00m, 131228, 5.0m, 2, null, null },
                    { 73, 12, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6759), "Epson L4261 Tanklı Yazıcı / Tarayıcı / Fotokopi", 0m, false, true, false, "Epson L4261 Tanklı Yazıcı", 9999.00m, 489661, 5.0m, 2, null, null },
                    { 74, 1, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6762), "Apple iPhone 13 128 GB Beyaz", 0m, false, true, false, "Apple iPhone 13 128 GB Beyaz", 100149m, 810296, 4.5m, 3, null, null },
                    { 75, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6766), "Samsung Galaxy A06 128 GB 4 GB RAM Siyah", 0m, false, true, false, "Samsung Galaxy A06 128 GB 4 GB RAM Siyah", 100149m, 490586, 4.0m, 3, null, null },
                    { 76, 1, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6770), "Apple iPhone 13 128 GB Siyah", 0m, false, true, false, "Apple iPhone 13 128 GB Siyah", 33699m, 771127, 4.5m, 3, null, null },
                    { 77, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6777), "Samsung Galaxy A16 128 GB 6 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A16 128 GB 6 GB Ram Siyah", 8789m, 109027, 4.2m, 3, null, null },
                    { 78, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6783), "Samsung Galaxy A35 256 GB 8 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A35 256 GB 8 GB Ram Siyah", 14449m, 505670, 4.3m, 3, null, null },
                    { 79, 13, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6787), "HONOR Magic 7 Lite 256 GB 8 GB Ram Mor", 0m, false, true, false, "HONOR Magic 7 Lite 256 GB 8 GB Ram Mor", 15999m, 851768, 4.4m, 3, null, null },
                    { 80, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6791), "Samsung Galaxy A06 128 GB 4 GB Ram Açık Mavi", 0m, false, true, false, "Samsung Galaxy A06 128 GB 4 GB Ram Açık Mavi", 6303m, 722742, 4.0m, 3, null, null },
                    { 81, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6795), "Samsung Galaxy S24+ 256 GB 12 GB Ram Gri", 0m, false, true, false, "Samsung Galaxy S24+ 256 GB 12 GB Ram Gri", 41599m, 873826, 4.8m, 3, null, null },
                    { 82, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6799), "Samsung Galaxy A16 128 GB 6 GB Ram Gri", 0m, false, true, false, "Samsung Galaxy A16 128 GB 6 GB Ram Gri", 8789m, 714277, 4.2m, 3, null, null },
                    { 83, 13, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6804), "HONOR Magic 7 Lite 256 GB 8 GB Ram Siyah", 0m, false, true, false, "HONOR Magic 7 Lite 256 GB 8 GB Ram Siyah", 15999m, 647026, 4.4m, 3, null, null },
                    { 84, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6809), "Samsung Galaxy S24 FE 128 GB 8 GB Ram Gri", 0m, false, true, false, "Samsung Galaxy S24 FE 128 GB 8 GB Ram Gri", 23849m, 702324, 4.6m, 3, null, null },
                    { 85, 14, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6813), "Nothing Phone 1 256 GB 8 GB Ram Siyah", 0m, false, true, false, "Nothing Phone 1 256 GB 8 GB Ram Siyah", 13999m, 816461, 4.3m, 3, null, null },
                    { 86, 14, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6816), "Nothing Phone (2a) 256 GB 12 GB Ram Beyaz", 0m, false, true, false, "Nothing Phone (2a) 256 GB 12 GB Ram Beyaz", 18999m, 315461, 4.5m, 3, null, null },
                    { 87, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6820), "Samsung Galaxy A35 128 GB 8 GB Ram Açık Mavi", 0m, false, true, false, "Samsung Galaxy A35 128 GB 8 GB Ram Açık Mavi", 13701m, 796113, 4.3m, 3, null, null },
                    { 88, 15, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6824), "Infinix Smart 9 128 GB 4 GB Ram Nane Yeşili", 0m, false, true, false, "Infinix Smart 9 128 GB 4 GB Ram Nane Yeşili", 5499m, 306954, 4.0m, 3, null, null },
                    { 89, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6829), "Samsung Galaxy A55 128 GB 8 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A55 128 GB 8 GB Ram Siyah", 16170m, 399201, 4.4m, 3, null, null },
                    { 90, 14, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6832), "Nothing Phone 2A Plus 256 GB 12 GB Ram Gri", 0m, false, true, false, "Nothing Phone 2A Plus 256 GB 12 GB Ram Gri", 22999m, 481915, 4.5m, 3, null, null },
                    { 91, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6838), "Samsung Galaxy S24 Fe 256 GB 8 GB Ram Grafit", 0m, false, true, false, "Samsung Galaxy S24 Fe 256 GB 8 GB Ram Grafit", 26299m, 411730, 4.6m, 3, null, null },
                    { 92, 1, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6841), "Apple iPhone 16e 128GB Beyaz", 0m, false, true, false, "Apple iPhone 16e 128GB Beyaz", 44799m, 374702, 4.7m, 3, null, null },
                    { 93, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6847), "Samsung Galaxy S24 FE 128 GB 8 GB Ram Mavi", 0m, false, true, false, "Samsung Galaxy S24 FE 128 GB 8 GB Ram Mavi", 23849m, 493386, 4.6m, 3, null, null },
                    { 94, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6853), "Samsung Galaxy S25+ 256 GB 12 GB Ram Lacivert", 0m, false, true, false, "Samsung Galaxy S25+ 256 GB 12 GB Ram Lacivert", 54799m, 752171, 4.8m, 3, null, null },
                    { 95, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6892), "Samsung B310 Dual Sim Lacivert", 0m, false, true, false, "Samsung B310 Dual Sim Lacivert", 1149m, 207283, 3.5m, 3, null, null },
                    { 96, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6897), "Samsung Galaxy S23 Ultra 512 GB 12 GB Ram Altın", 0m, false, true, false, "Samsung Galaxy S23 Ultra 512 GB 12 GB Ram Altın", 48899m, 178192, 4.9m, 3, null, null },
                    { 97, 16, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6903), "Redmi Note 14 Pro 12GB 512GB", 0m, false, true, false, "Redmi Note 14 Pro 12GB 512GB", 18999m, 944989, 4.4m, 3, null, null },
                    { 98, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6906), "Samsung B310E Dual Sim Kamerasız Cep Telefonu Beyaz", 0m, false, true, false, "Samsung B310E Dual Sim Kamerasız Cep Telefonu Beyaz", 1149m, 891465, 3.5m, 3, null, null },
                    { 99, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6912), "Samsung Galaxy A55 128 GB 8 GB Ram Açık Mavi", 0m, false, true, false, "Samsung Galaxy A55 128 GB 8 GB Ram Açık Mavi", 16507m, 662790, 4.4m, 3, null, null },
                    { 100, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6917), "Samsung Galaxy A35 128 GB 8 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A35 128 GB 8 GB Ram Siyah", 13559m, 870208, 4.3m, 3, null, null },
                    { 101, 16, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6922), "Redmi Note 14 Pro 8GB 256GB", 0m, false, true, false, "Redmi Note 14 Pro 8GB 256GB", 16599m, 391954, 4.4m, 3, null, null },
                    { 102, 1, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6927), "Apple iPhone 15 256 GB Mavi", 0m, false, true, false, "Apple iPhone 15 256 GB Mavi", 55999m, 103335, 4.8m, 3, null, null },
                    { 103, 1, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6938), "Apple iPhone 16 Pro 256GB Beyaz", 0m, false, true, false, "Apple iPhone 16 Pro 256GB Beyaz", 84599m, 364042, 4.9m, 3, null, null },
                    { 104, 8, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6944), "Xiaomi 14T Pro 12GB 512GB", 0m, false, true, false, "Xiaomi 14T Pro 12GB 512GB", 41000m, 879563, 4.5m, 3, null, null },
                    { 105, 1, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6950), "Apple iPhone 16 Pro 128GB Beyaz", 0m, false, true, false, "Apple iPhone 16 Pro 128GB Beyaz", 78499m, 980314, 4.8m, 3, null, null },
                    { 106, 13, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6956), "HONOR 200 512 GB 12 GB Ram Zümrüt Yeşili", 0m, false, true, false, "HONOR 200 512 GB 12 GB Ram Zümrüt Yeşili", 23999m, 685352, 0m, 3, null, null },
                    { 107, 1, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6963), "Apple iPhone 16 Pro 256GB Siyah", 0m, false, true, false, "Apple iPhone 16 Pro 256GB Siyah", 88825m, 197893, 0m, 3, null, null },
                    { 108, 16, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6969), "Xiaomi Redmi Note 13 Pro 256GB 8gb Ram Mor", 0m, false, true, false, "Xiaomi Redmi Note 13 Pro 256GB 8gb Ram Mor", 15999m, 370043, 0m, 3, null, null },
                    { 109, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6972), "Samsung Galaxy S25 128 GB 12 GB Ram Lacivert", 0m, false, true, false, "Samsung Galaxy S25 128 GB 12 GB Ram Lacivert", 45999m, 116702, 0m, 3, null, null },
                    { 110, 1, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6975), "Apple iPhone 16 256GB Lacivert Taş", 0m, false, true, false, "Apple iPhone 16 256GB Lacivert Taş", 66999m, 541559, 0m, 3, null, null },
                    { 111, 16, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6979), "Xiaomi Redmi Note 14 Pro Plus 5g 512 GB 12 GB Ram", 0m, false, true, false, "Xiaomi Redmi Note 14 Pro Plus 5g 512 GB 12 GB Ram", 27250m, 788108, 0m, 3, null, null },
                    { 112, 1, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6983), "Apple iPhone 16 Pro Max 512GB Natürel Titanyum", 0m, false, true, false, "Apple iPhone 16 Pro Max 512GB Natürel Titanyum", 101939m, 472589, 0m, 3, null, null },
                    { 113, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6990), "Samsung Galaxy A04S 64 GB Siyah", 0m, false, true, false, "Samsung Galaxy A04S 64 GB Siyah", 6839m, 575270, 0m, 3, null, null },
                    { 114, 16, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6994), "Redmi Note 14 Pro 5G 12GB 512GB", 0m, false, true, false, "Redmi Note 14 Pro 5G 12GB 512GB", 22500m, 601268, 0m, 3, null, null },
                    { 115, 14, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(6998), "Nothing Phone 1 128 GB 8 GB Ram Siyah", 0m, false, true, false, "Nothing Phone 1 128 GB 8 GB Ram Siyah", 12999m, 535735, 0m, 3, null, null },
                    { 116, 16, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7004), "Xiaomi Redmi Note 13 Pro 512GB 12GB Siyah", 0m, false, true, false, "Xiaomi Redmi Note 13 Pro 512GB 12GB Siyah", 18999m, 106175, 0m, 3, null, null },
                    { 117, 16, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7013), "Xiaomi Redmi 12 128 GB 8 GB Ram Siyah", 0m, false, true, false, "Xiaomi Redmi 12 128 GB 8 GB Ram Siyah", 8190m, 115307, 0m, 3, null, null },
                    { 118, 13, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7016), "HONOR Magic V3 512 GB 12 GB Ram Yeşil", 0m, false, true, false, "HONOR Magic V3 512 GB 12 GB Ram Yeşil", 79999m, 284926, 0m, 3, null, null },
                    { 119, 21, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7020), "Tecno Spark 30 256 GB 8 GB Ram", 0m, false, true, false, "Tecno Spark 30 256 GB 8 GB Ram", 9199m, 968474, 0m, 3, null, null },
                    { 120, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7026), "Samsung Galaxy S25 Ultra 1 Tb 12 GB Ram", 0m, false, true, false, "Samsung Galaxy S25 Ultra 1 Tb 12 GB Ram", 88999m, 141510, 0m, 3, null, null },
                    { 121, 1, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7033), "Apple iPhone 16 Pro 128GB Siyah", 0m, false, true, false, "Apple iPhone 16 Pro 128GB Siyah", 79324m, 889669, 0m, 3, null, null },
                    { 122, 20, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7037), "Reeder P13 Blue Max L 2022 64 GB Beyaz", 0m, false, true, false, "Reeder P13 Blue Max L 2022 64 GB Beyaz", 3399m, 790943, 0m, 3, null, null },
                    { 123, 17, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7040), "POCO X7 12GB 512GB", 0m, false, true, false, "POCO X7 12GB 512GB", 17499m, 576218, 0m, 3, null, null },
                    { 124, 18, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7045), "Oppo A60 8GB 256GB Mavi", 0m, false, true, false, "Oppo A60 8GB 256GB Mavi", 10199m, 419039, 0m, 3, null, null },
                    { 125, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7050), "Samsung Galaxy A25 5G 256 GB 8 GB Ram Siyah", 0m, false, true, false, "Samsung Galaxy A25 5G 256 GB 8 GB Ram Siyah", 13250m, 947463, 0m, 3, null, null },
                    { 126, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7056), "Samsung Galaxy S25 256 GB Lacivert", 0m, false, true, false, "Samsung Galaxy S25 256 GB Lacivert", 47670m, 905928, 0m, 3, null, null },
                    { 127, 19, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7059), "Panasonic KX-TU550EXB Katlanabilir Renkli Ekran 4g Tuşlu Cep Telefonu Siyah", 0m, false, true, false, "Panasonic KX-TU550EXB Katlanabilir Renkli Ekran 4g Tuşlu Cep Telefonu Siyah", 4269m, 988561, 0m, 3, null, null },
                    { 128, 20, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7089), "Reeder S19 Max Pro 256 GB 6 GB Ram Siyah", 0m, false, true, false, "Reeder S19 Max Pro 256 GB 6 GB Ram Siyah", 4799m, 265990, 0m, 3, null, null },
                    { 129, 9, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7094), "Samsung B310E Cep Telefonu Beyaz", 0m, false, true, false, "Samsung B310E Cep Telefonu Beyaz", 1149m, 672987, 3.5m, 3, null, null },
                    { 130, 22, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7099), "Arçelik 6167 6 Programlı Beyaz Bulaşık Makinesi", 0m, false, true, false, "Arçelik 6167 6 Programlı Beyaz Bulaşık Makinesi", 25739.01m, 625229, 4.5m, 4, null, null },
                    { 131, 23, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7104), "Kumtel Beyaz Cam Digital / Dokunmatik Ankastre Set - 8 Programlı (KO-40 TAHDF Ocak B66-Sf2 Ddt Fırın DA6-835 Davlumbaz)", 0m, false, true, false, "Kumtel Beyaz Cam Digital / Dokunmatik Ankastre Set", 11299m, 203383, 4.1m, 4, null, null },
                    { 132, 24, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7113), "Regal Bm 310 3 Programlı Bulaşık Makinesi", 0m, false, true, false, "Regal Bm 310 3 Programlı Bulaşık Makinesi", 11549m, 452793, 4.6m, 4, null, null },
                    { 133, 25, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7120), "Profilo BM6320MA D Enerji Sınıfı 6 Programlı Bulaşık Makinesi", 0m, false, true, false, "Profilo BM6320MA D Enerji Sınıfı 6 Programlı Bulaşık Makinesi", 15999m, 121976, 4.7m, 4, null, null },
                    { 134, 26, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7124), "Altus AL 7103 MD 1000 Devir 7 kg Çamaşır Makinesi", 0m, false, true, false, "Altus AL 7103 MD 1000 Devir 7 kg Çamaşır Makinesi", 12479m, 303183, 4.6m, 4, null, null },
                    { 135, 26, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7128), "Altus AL 10123 D C Enerji 10 Kg Çamaşır Makinesi", 0m, false, true, false, "Altus AL 10123 D C Enerji 10 Kg Çamaşır Makinesi", 17028m, 279796, 4.7m, 4, null, null },
                    { 136, 27, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7135), "Hoover NDEH 10A2TSBE-17 10 kg Wi-Fi + Bluetooth Bağlantılı Isı Pompalı Kurutma Makinesi", 0m, false, true, false, "Hoover NDEH 10A2TSBE-17 10 kg Isı Pompalı Kurutma Makinesi", 14999m, 832469, 4.5m, 4, null, null },
                    { 137, 22, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7139), "Arçelik 7103 D 7 Kg 1000 Devir Çamaşır Makinesi", 0m, false, true, false, "Arçelik 7103 D 7 Kg 1000 Devir Çamaşır Makinesi", 14999m, 614838, 4.5m, 4, null, null },
                    { 138, 28, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7143), "Uğur UES 507 D/S 3 Kapılı No-Frost Buzdolabı", 0m, false, true, false, "Uğur UES 507 D/S 3 Kapılı No-Frost Buzdolabı", 29999m, 569044, 4.3m, 4, null, null },
                    { 139, 33, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7148), "Vestel NF480 EX A++ Siyah 453 Lt No-Frost Buzdolabı", 0m, false, true, false, "Vestel NF480 EX Siyah No-Frost Buzdolabı", 23599m, 743508, 4.4m, 4, null, null },
                    { 140, 24, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7153), "Regal 90 LT A+ Mini Buzdolabı", 0m, false, true, false, "Regal 90 LT A+ Mini Buzdolabı", 6499m, 934057, 4.6m, 4, null, null },
                    { 141, 29, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7158), "Arnell Ankastre Set (8665 MDOC Ankastre Fırın + 1140-CSBDF 4 Gözlü Ocak + DS3490EC / EC3490 Davlumbaz)", 0m, false, true, false, "Arnell Ankastre Set", 13499m, 109153, 4.2m, 4, null, null },
                    { 142, 30, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7162), "Evora 3'lü Siyah Cam Ankastre Set (EAF-6056 Fırın + EAO-8505 Ocak + EAD-9263 Davlumbaz)", 0m, false, true, false, "Evora Siyah Cam Set", 10990m, 221369, 4.1m, 4, null, null },
                    { 143, 31, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7167), "Albergio AL-FO-005-E Ankastre Fırın", 0m, false, true, false, "Albergio AL-FO-005-E Ankastre Fırın", 5499m, 922929, 4.0m, 4, null, null },
                    { 144, 32, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7170), "Kiwi KSW-4215 Beyaz Soğuk Su Sebili", 0m, false, true, false, "Kiwi KSW-4215 Beyaz Soğuk Su Sebili", 1299m, 959367, 3.9m, 4, null, null },
                    { 145, 33, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7175), "Vestel SP 100 Beyaz Soğuk Su Sebili", 0m, false, true, false, "Vestel SP 100 Beyaz Soğuk Su Sebili", 1499m, 255256, 4.0m, 4, null, null },
                    { 146, 22, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7179), "Arçelik 1100 S Beyaz Su Sebili", 0m, false, true, false, "Arçelik 1100 S Beyaz Su Sebili", 1999m, 598638, 4.2m, 4, null, null },
                    { 147, 25, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7183), "Profilo SP 100 Sıcak/Soğuk Su Sebili", 0m, false, true, false, "Profilo SP 100 Sıcak/Soğuk Su Sebili", 2299m, 402339, 4.3m, 4, null, null },
                    { 148, 22, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7186), "Arçelik 5500 BT Mini Fırın - 15 Litre", 0m, false, true, false, "Arçelik 5500 BT Mini Fırın", 4999m, 217869, 4.5m, 4, null, null },
                    { 149, 23, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7191), "Kumtel KF3150 Mini Fırın - 36 Litre Beyaz", 0m, false, true, false, "Kumtel KF3150 Mini Fırın", 2699m, 290573, 4.3m, 4, null, null },
                    { 150, 33, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7196), "Vestel R8080 Retro Buzdolabı - Kırmızı", 0m, false, true, false, "Vestel R8080 Retro Buzdolabı", 28900m, 999865, 4.7m, 4, null, null },
                    { 151, 22, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7253), "Arçelik 9144 YI Ultra Hijyen 9 Kg 1400 Devir Çamaşır Makinesi", 0m, false, true, false, "Arçelik 9144 YI Ultra Hijyen 9 Kg Çamaşır Makinesi", 21950m, 910478, 4.8m, 4, null, null },
                    { 152, 25, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7258), "Profilo CGA242X1TR A++ 9 Kg 1200 Devir Çamaşır Makinesi", 0m, false, true, false, "Profilo CGA242X1TR A++ 9 Kg Çamaşır Makinesi", 18999m, 703109, 4.5m, 4, null, null },
                    { 153, 24, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7264), "Regal Pratik 2000 Toz Torbasız Elektrikli Süpürge", 0m, false, true, false, "Regal Pratik 2000 Elektrikli Süpürge", 2999m, 592748, 4.2m, 4, null, null },
                    { 154, 33, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7268), "Vestel BM 5201 X EKO PLUS Bulaşık Makinesi", 0m, false, true, false, "Vestel EKO PLUS Bulaşık Makinesi", 12999m, 973698, 4.3m, 4, null, null },
                    { 155, 22, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7274), "Arçelik K 3290 Telve Otomatik Türk Kahve Makinesi - Siyah", 0m, false, true, false, "Arçelik K 3290 Telve Türk Kahve Makinesi", 3299m, 346401, 4.9m, 4, null, null },
                    { 156, 26, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7279), "Altus AL 413 E 4 Programlı Bulaşık Makinesi", 0m, false, true, false, "Altus AL 413 E 4 Programlı Bulaşık Makinesi", 13499m, 649208, 4.1m, 4, null, null },
                    { 157, 27, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7282), "Hoover HLWOQ 59B-S 9 Kg Çamaşır Kurutma Makinesi", 0m, false, true, false, "Hoover HLWOQ 59B-S Çamaşır Kurutma Makinesi", 17999m, 564926, 4.4m, 4, null, null },
                    { 158, 33, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7285), "Vestel MAYA 10100 ST 10 Kg 1000 Devir Çamaşır Makinesi", 0m, false, true, false, "Vestel MAYA 10100 ST Çamaşır Makinesi", 14599m, 451838, 4.5m, 4, null, null },
                    { 159, 34, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7291), "Airfel LTXM35N 12000 BTU R32 Inverter Duvar Tipi Klima", 0m, false, true, false, "Airfel LTXM35N 12000 BTU R32 Inverter Duvar Tipi Klima", 25541.01m, 539172, 4.6m, 5, null, null },
                    { 160, 35, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7296), "Regal Luna A++ 15000 BTU Inverter Duvar Tipi Klima", 0m, false, true, false, "Regal Luna A++ 15000 BTU Inverter Duvar Tipi Klima", 26499m, 509337, 4.6m, 5, null, null },
                    { 161, 36, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7299), "Kumtel Bej Fanlı Isıtıcı 2000 W LX - 6331", 0m, false, true, false, "Kumtel Bej Fanlı Isıtıcı 2000 W LX - 6331", 509m, 276274, 4.2m, 5, null, null },
                    { 162, 37, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7303), "Bosch Climate CL2000U W 35 E A++ 12000 BTU Duvar Tipi Klima", 0m, false, true, false, "Bosch Climate CL2000U W 35 E A++ 12000 BTU Duvar Tipi Klima", 26999m, 648952, 4.4m, 5, null, null },
                    { 163, 38, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7307), "Kaira DTXR35E A++ 12000 BTU Wifi Inverter Duvar Tipi Klima (Montaj Dahil)", 0m, false, true, false, "Kaira DTXR35E A++ 12000 BTU Wifi Inverter Duvar Tipi Klima", 25840m, 889381, 4.4m, 5, null, null },
                    { 164, 36, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7311), "Kumtel Juniper Portatif Taşınabilir Klima Kmpac-7", 0m, false, true, false, "Kumtel Juniper Portatif Taşınabilir Klima Kmpac-7", 9999m, 366432, 4.3m, 5, null, null },
                    { 165, 33, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7315), "Vestel Flora Doğa 124 A++ Wifi 12000 BTU Inverter Duvar Tipi Klima", 0m, false, true, false, "Vestel Flora Doğa 124 A++ Wifi 12000 BTU Inverter Duvar Tipi Klima", 26235m, 604804, 4.6m, 5, null, null },
                    { 166, 39, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7321), "Xiaomi ZMYDFS01DM Şarj Edilebilir Mini Fan", 0m, false, true, false, "Xiaomi ZMYDFS01DM Şarj Edilebilir Mini Fan", 1889m, 884622, 5m, 5, null, null },
                    { 167, 36, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7325), "Kumtel LX-2832 Siyah 1500 Watt Isıtıcı", 0m, false, true, false, "Kumtel LX-2832 Siyah 1500 Watt Isıtıcı", 549m, 627871, 4.5m, 5, null, null },
                    { 168, 40, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7329), "Mirkraft Future 2500 Watt Elektrikli Isıtıcı - IP24 - LCD Ekran - Uzaktan Kumandalı - 4 Isı Ayarı", 0m, false, true, false, "Mirkraft Future 2500 Watt Elektrikli Isıtıcı", 5559.66m, 403354, 5m, 5, null, null },
                    { 169, 41, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7333), "Samsung Premium AR18TSHZHWK A++ 18000 BTU Inverter Duvar Tipi Klima", 0m, false, true, false, "Samsung Premium AR18TSHZHWK A++ 18000 BTU Inverter Duvar Tipi Klima", 38599m, 788080, 4.4m, 5, null, null },
                    { 170, 42, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7339), "Arnell Elektrikli Isıtıcı Quartz Ev Ve Ofis Oda Tipi 3+1 Çubuklu Güvenli Elektrikli Soba - 2600 Watt", 0m, false, true, false, "Arnell Elektrikli Isıtıcı Quartz", 2218.63m, 683995, 3m, 5, null, null },
                    { 171, 36, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7344), "Kumtel Ks-2760 Quartz Isıtıcı Siyah", 0m, false, true, false, "Kumtel Ks-2760 Quartz Isıtıcı Siyah", 999m, 392946, 4.1m, 5, null, null },
                    { 172, 43, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7350), "Zeeful Süper Güç Üfleyici Mini Turbo Jet Fan 130000RPM 52+M/s 4000MAH (Yurt Dışından)", 0m, false, true, false, "Zeeful Süper Güç Üfleyici Mini Turbo Jet Fan", 1750.32m, 374785, 4.5m, 5, null, null },
                    { 173, 44, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7355), "Beko 31225 Ekolojik A++ 12000 BTU Duvar Tipi Klima", 0m, false, true, false, "Beko 31225 Ekolojik A++ 12000 BTU Duvar Tipi Klima", 27754.65m, 309938, 4.6m, 5, null, null },
                    { 174, 33, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7359), "Vestel Flora Doğa 244 A++ 24000 BTU Wifi Inverter Duvar Tipi Klima", 0m, false, true, false, "Vestel Flora Doğa 244 A++ 24000 BTU Wifi Inverter Duvar Tipi Klima", 42362.10m, 917519, 4.4m, 5, null, null },
                    { 175, 45, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7365), "Arçelik Ekolojik 18325 A++ 18000 BTU Inverter Duvar Tipi Klima", 0m, false, true, false, "Arçelik Ekolojik 18325 A++ 18000 BTU Inverter Duvar Tipi Klima", 39897m, 433920, 4.4m, 5, null, null },
                    { 176, 42, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7368), "Arnell Elektrikli Isıtıcı Duvar Tip Soba 3000 Watt", 0m, false, true, false, "Arnell Elektrikli Isıtıcı Duvar Tip Soba", 1431.06m, 410127, 4.8m, 5, null, null },
                    { 177, 46, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7372), "Baymak Elegant Plus UV 18 A++ (Montaj Dahil) 18000 BTU Duvar Tipi Klima", 0m, false, true, false, "Baymak Elegant Plus UV 18 A++ 18000 BTU Duvar Tipi Klima", 44989m, 990025, 4.4m, 5, null, null },
                    { 178, 47, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7377), "FujiPlus Fujiplus Sakura 12000 Btu Inverter Duvar Tipi Klima", 0m, false, true, false, "FujiPlus Sakura 12000 Btu Inverter Duvar Tipi Klima", 22777.03m, 918662, 3.9m, 5, null, null },
                    { 179, 46, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7381), "Baymak Aqua Konfor 65 Litre Termosifon", 0m, false, true, false, "Baymak Aqua Konfor 65 Litre Termosifon", 8439m, 766314, 4.5m, 5, null, null },
                    { 180, 36, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7389), "Kumtel Ecoray Ex-25 2500 Watt Duvar Tipi Infrared Isıtıcı", 0m, false, true, false, "Kumtel Ecoray Ex-25 2500 Watt Duvar Tipi Infrared Isıtıcı", 886.05m, 135662, 4.3m, 5, null, null },
                    { 181, 48, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7392), "UFO Ufo Star 2400 W Duvar Tipi Isıtıcı - Termostatlı", 0m, false, true, false, "UFO Ufo Star 2400 W Duvar Tipi Isıtıcı", 4190m, 580985, 4.5m, 5, null, null },
                    { 182, 49, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7397), "Abbruch Şarj Edilebilir Taşınabilir Ipli Mini El Fanı Üç Kademe Hızlı Güçlü Soğutucu Pervane Vantilatör", 0m, false, true, false, "Abbruch Şarj Edilebilir Taşınabilir Mini El Fanı", 289.90m, 715144, 4.5m, 5, null, null },
                    { 183, 50, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7401), "Sinbo SF-6783 Vantilatör", 0m, false, true, false, "Sinbo SF-6783 Vantilatör", 1200m, 797604, 3.4m, 5, null, null },
                    { 184, 44, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7406), "Beko 31650 Vantilatör uzaktan kumandalı", 0m, false, true, false, "Beko 31650 Vantilatör", 3259m, 724962, 4.6m, 5, null, null },
                    { 185, 48, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7491), "UFO Ufo Micatronic 1900 W Kule Tipi Isıtıcı", 0m, false, true, false, "UFO Ufo Micatronic 1900 W Kule Tipi Isıtıcı", 4390m, 242155, 4.4m, 5, null, null },
                    { 186, 48, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7496), "UFO Omri 1200 W Termostatlı Hem Yatay Hem Dikey Isıtıcı", 0m, false, true, false, "UFO Omri 1200 W Termostatlı Isıtıcı", 3400m, 401187, 3.9m, 5, null, null },
                    { 187, 38, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7502), "Kaira DTXR71E A++ 24000 BTU Inverter Duvar Tipi Klima (Montaj Dahil)", 0m, false, true, false, "Kaira DTXR71E A++ 24000 BTU Inverter Duvar Tipi Klima", 45250.40m, 463553, 4m, 5, null, null },
                    { 188, 46, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7506), "Baymak Duo Tec Compact Premix 24 kw Yoğuşmalı Kombi (Baca Dahil)", 0m, false, true, false, "Baymak Duo Tec Compact Premix 24 kw Yoğuşmalı Kombi", 27400m, 145725, 4.6m, 5, null, null },
                    { 189, 48, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7512), "UFO ISITICI STAR S/19 1900 W", 0m, false, true, false, "UFO ISITICI STAR S/19 1900 W", 3690m, 318503, 4.4m, 5, null, null },
                    { 190, 51, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7517), "Magiceham Lilo Stitch Peluş Sıcak Su Isıtıcısı - Lacivert (Yurt Dışından)", 0m, false, true, false, "Magiceham Lilo Stitch Peluş Sıcak Su Isıtıcısı", 528.45m, 611585, 4.6m, 5, null, null },
                    { 191, 64, 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7524), "Xnews A Üstü USB Fan Soğutucu Vantilatör Klima USB Girişli Metal Serinlci Fan Mini Vantilatör Fan Klima Fan", 0m, false, true, false, "Xnews A Üstü USB Fan Soğutucu", 269.90m, 597719, 5m, 5, null, null },
                    { 192, 65, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7527), "Lacoste Sport Court-Master Pro Erkek Siyah Sneaker 744SMA0084 02H", 0m, false, true, false, "Lacoste Sport Court-Master Pro Erkek Siyah Sneaker 744SMA0084 02H", 3239.10m, 347479, 4.9m, 6, null, null },
                    { 193, 66, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7534), "Letoon 2104 Günlük Unisex Spor Ayakkabı", 0m, false, true, false, "Letoon 2104 Günlük Unisex Spor Ayakkabı", 564m, 611752, 4.2m, 6, null, null },
                    { 194, 67, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7539), "Derilax Hakiki Deri Tam Ortopedik Erkek Ayakkabı", 0m, false, true, false, "Derilax Hakiki Deri Tam Ortopedik Erkek Ayakkabı", 1200m, 341045, 4.6m, 6, null, null },
                    { 195, 68, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7543), "Hotiç Hakiki Deri Siyah Erkek Günlük Ayakkabı", 0m, false, true, false, "Hotiç Hakiki Deri Siyah Erkek Günlük Ayakkabı", 1679.40m, 821415, 4.1m, 6, null, null },
                    { 196, 69, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7548), "Ispartalılar 7575 Ortopedik Taban Yumuşak Hakiki Deri Mevsimlik Kışlık Erkek Ayakkabı", 0m, false, true, false, "Ispartalılar 7575 Ortopedik Taban Yumuşak Hakiki Deri Mevsimlik Kışlık Erkek Ayakkabı", 670.65m, 990472, 4m, 6, null, null },
                    { 197, 70, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7552), "Under Armour Çocuk Ua Bgs Charged Rogue 4 Koşu Ayakkabısı 3027106-400", 0m, false, true, false, "Under Armour Çocuk Ua Bgs Charged Rogue 4 Koşu Ayakkabısı 3027106-400", 2090m, 788476, 5m, 6, null, null },
                    { 198, 69, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7558), "Ispartalılar 502 Ortopedik Topuk Masajlı Hakiki Deri Kışlık Erkek Ayakkabı Bağcıklı", 0m, false, true, false, "Ispartalılar 502 Ortopedik Topuk Masajlı Hakiki Deri Kışlık Erkek Ayakkabı Bağcıklı", 679.15m, 912107, 4m, 6, null, null },
                    { 199, 71, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7565), "Muggo Samuel Garantili Günlük Klasik Deri Casual Rahat Ortopedik Kalın Taban Erkek Ayakkabı", 0m, false, true, false, "Muggo Samuel Garantili Günlük Klasik Deri Casual Rahat Ortopedik Kalın Taban Erkek Ayakkabı", 899.90m, 280071, 4.5m, 6, null, null },
                    { 200, 72, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7575), "Tomiross Erkek Atlanta Günlük Kullanım Sneaker Ayakkabı ATLNT-5025", 0m, false, true, false, "Tomiross Erkek Atlanta Günlük Kullanım Sneaker Ayakkabı ATLNT-5025", 699.90m, 616342, 4.5m, 6, null, null },
                    { 201, 73, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7578), "Yaya By Hotic 02ayy296160a100 Siyah Erkek Ayakkabı", 0m, false, true, false, "Yaya By Hotic 02ayy296160a100 Siyah Erkek Ayakkabı", 899.90m, 828435, 4.5m, 6, null, null },
                    { 202, 74, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7583), "Hotic Hakiki Deri Lacivert Erkek Günlük Ayakkabı", 0m, false, true, false, "Hotic Hakiki Deri Lacivert Erkek Günlük Ayakkabı", 799.90m, 147060, 4.5m, 6, null, null },
                    { 203, 75, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7593), "Derilax Deri Tam Ortopedik Erkek Ayakkabı", 0m, false, true, false, "Derilax Deri Tam Ortopedik Erkek Ayakkabı", 699.90m, 354273, 4.5m, 6, null, null },
                    { 204, 76, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7596), "Ispartalılar 909 Tam Ortopedik Taban Hakiki Deri Erkek Ayakkabı", 0m, false, true, false, "Ispartalılar 909 Tam Ortopedik Taban Hakiki Deri Erkek Ayakkabı", 599.90m, 256215, 4.5m, 6, null, null },
                    { 205, 77, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7600), "Selin Soylu Hakiki Deri Erkek Ayakkabı Kışlık Günlük Ayakkabı", 0m, false, true, false, "Selin Soylu Hakiki Deri Erkek Ayakkabı Kışlık Günlük Ayakkabı", 499.90m, 848384, 4.5m, 6, null, null },
                    { 206, 78, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7604), "Sebago Nubuk Koyu Kahve Siyah Erkek Günlük Ayakkabı 7111m5w", 0m, false, true, false, "Sebago Nubuk Koyu Kahve Siyah Erkek Günlük Ayakkabı 7111m5w", 399.90m, 194752, 4.5m, 6, null, null },
                    { 207, 79, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7609), "Lumberjack 4m Navigator 4fx", 0m, false, true, false, "Lumberjack 4m Navigator 4fx", 299.90m, 222143, 4.5m, 6, null, null },
                    { 208, 78, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7615), "Sebago Deri Lacivert Erkek Günlük Ayakkabı 70004z0", 0m, false, true, false, "Sebago Deri Lacivert Erkek Günlük Ayakkabı 70004z0", 199.90m, 590258, 4.5m, 6, null, null },
                    { 209, 80, 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7619), "Dakirs Yazlık Erkek Keten Günlük Rahat Hafif Bağcıklı Spor Ayakkabı 40-44", 0m, false, true, false, "Dakirs Yazlık Erkek Keten Günlük Rahat Hafif Bağcıklı Spor Ayakkabı 40-44", 99.90m, 548767, 4.5m, 6, null, null }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "EntityId", "EntityType", "IsDeleted", "Path", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7875), 1, 1, false, "img/Products/Laptops/Casper_G870.1270.jpg", null, null },
                    { 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7880), 2, 1, false, "img/Products/Laptops/MSI_15.6.jpg", null, null },
                    { 3, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7881), 3, 1, false, "img/Products/Laptops/Casper_S100.1362.jpg", null, null },
                    { 4, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7883), 4, 1, false, "img/Products/Laptops/Casper_G870.1362.jpg", null, null },
                    { 5, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7884), 5, 1, false, "img/Products/Laptops/HP_15.6.jpg", null, null },
                    { 6, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7886), 6, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 7, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7888), 7, 1, false, "img/Products/Laptops/Lenovo_model.jpg", null, null },
                    { 8, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7890), 8, 1, false, "img/Products/Laptops/MSI_model.jpg", null, null },
                    { 9, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7891), 9, 1, false, "img/Products/Laptops/Casper_C550.1255.jpg", null, null },
                    { 10, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7894), 10, 1, false, "img/Products/Laptops/Lenovo_3.2.jpg", null, null },
                    { 11, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7895), 11, 1, false, "img/Products/Laptops/Casper_G770.1245.jpg", null, null },
                    { 12, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7898), 12, 1, false, "img/Products/Laptops/Casper_X600.7430.jpg", null, null },
                    { 13, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7900), 13, 1, false, "img/Products/Laptops/Acer_15.6.jpg", null, null },
                    { 14, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7902), 14, 1, false, "img/Products/Laptops/Casper_X600.1270.jpg", null, null },
                    { 15, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7905), 15, 1, false, "img/Products/Laptops/Casper_G870.1342.jpg", null, null },
                    { 16, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7907), 16, 1, false, "img/Products/Laptops/Casper_G870.1270.jpg", null, null },
                    { 17, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7909), 17, 1, false, "img/Products/Laptops/HP_15.6.jpg", null, null },
                    { 18, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7912), 18, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 19, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7914), 19, 1, false, "img/Products/Laptops/Asus_15.6.jpg", null, null },
                    { 20, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7915), 20, 1, false, "img/Products/Laptops/Apple_model.jpg", null, null },
                    { 21, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7917), 21, 1, false, "img/Products/Laptops/Casper_G870.1342.jpg", null, null },
                    { 22, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7918), 22, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 23, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7920), 23, 1, false, "img/Products/Laptops/Asus_model.jpg", null, null },
                    { 24, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7922), 24, 1, false, "img/Products/Laptops/Casper_X600.1342.jpg", null, null },
                    { 25, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7924), 25, 1, false, "img/Products/Laptops/Lenovo_3.2.jpg", null, null },
                    { 26, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7925), 26, 1, false, "img/Products/Laptops/Casper_X600.1362.jpg", null, null },
                    { 27, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7927), 27, 1, false, "img/Products/Laptops/MSI_15.6.jpg", null, null },
                    { 28, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7931), 28, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 29, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7933), 29, 1, false, "img/Products/Laptops/Lenovo_15.6.jpg", null, null },
                    { 30, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7934), 30, 1, false, "img/Products/Laptops/Apple_model.jpg", null, null },
                    { 31, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7935), 31, 1, false, "img/Products/Laptops/Casper_G870.1245.jpg", null, null },
                    { 32, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7937), 32, 1, false, "img/Products/PrintersandScanner/hp_hp_deskjet_ink_advantage_2878_allinone_yazc.jpg", null, null },
                    { 33, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7938), 33, 1, false, "img/Products/PrintersandScanner/canon_dolan_kartulu_e414_yazc_tarayc_fotokopi.jpg", null, null },
                    { 34, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7941), 34, 1, false, "img/Products/PrintersandScanner/canon_pixma_tr4650_tarayc_fotokopi_wifi_faks_ok_fonksiyonlu_yazc_canon_eurasia_garantili.jpg", null, null },
                    { 35, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7943), 35, 1, false, "img/Products/PrintersandScanner/canon_pixma_e3640_wifi_tarayc_fotokopi_ok_fonksiyonlu_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 36, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7944), 36, 1, false, "img/Products/PrintersandScanner/epson_l5290_wifi_renk_tankl_yazc.jpg", null, null },
                    { 37, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7946), 37, 1, false, "img/Products/PrintersandScanner/epson_tankl_l3150_photoink_muadil_mrekkepli_tankl_yazc_1_siyah_mrekkep_ve_fotoraf_kad_hediyeli.jpg", null, null },
                    { 38, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7947), 38, 1, false, "img/Products/PrintersandScanner/hp_officejet_pro_7720_fotokopi_faks_tarayc_wifi_airprint_a3_yazc_y0s18a.jpg", null, null },
                    { 39, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7949), 39, 1, false, "img/Products/PrintersandScanner/canon_e3640_wifi_yazc_ve_tpal_kartu_sistemi.jpg", null, null },
                    { 40, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7950), 40, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_l3250_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 41, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7951), 41, 1, false, "img/Products/PrintersandScanner/enp_canon_mf264dw_lazer_yazc_tarayc_fotokopi_wifi_lan_duplex.jpg", null, null },
                    { 42, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7953), 42, 1, false, "img/Products/PrintersandScanner/canon_pxma_g3430_renkli_mrekkep_mega_tankl_yazc_tarayc_fotokopi_wifi_1_ie_orijinal_siyah_mrekkep_hed.jpg", null, null },
                    { 43, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7954), 43, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_l3250_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 44, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(7955), 44, 1, false, "img/Products/PrintersandScanner/canon_isensys_mf453dw_wf_ok_fonksiyonlu_lazer_yazc.jpg", null, null },
                    { 45, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8016), 45, 1, false, "img/Products/PrintersandScanner/canon_pixma_e3440_dolabilen_kartu_sistemli_yazc.jpg", null, null },
                    { 46, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8018), 46, 1, false, "img/Products/PrintersandScanner/epson_l6550_color_tankl_wifi_a4_yazc_fotokopi_tarayc_fax.jpg", null, null },
                    { 47, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8019), 47, 1, false, "img/Products/PrintersandScanner/hp_deskjet_2632_wifi_tarayc_fotokopi_renkli_ok_fonksiyonlu_mrekkep_pskrtmeli_yazc_v1n05b.jpg", null, null },
                    { 48, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8021), 48, 1, false, "img/Products/PrintersandScanner/canon_pixma_e514_fotokopi_tarayc_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 49, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8022), 49, 1, false, "img/Products/PrintersandScanner/epson_epson_ecotank_l11050_a3_tek_fonk_yazici.jpg", null, null },
                    { 50, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8024), 50, 1, false, "img/Products/PrintersandScanner/hp_hp_6uu47a_smart_tank_750_renkli_yaztarfot_wifi_a4.jpg", null, null },
                    { 51, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8026), 51, 1, false, "img/Products/PrintersandScanner/canon_gx6040_yazctaraycfotokopi_renkli_mrekkep_tankl_yazc_wifi_ethernet.jpg", null, null },
                    { 52, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8028), 52, 1, false, "img/Products/PrintersandScanner/epson_surecolor_sc_f100_mrekkep_pskrtme_sblimasyon_yazc.jpg", null, null },
                    { 53, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8031), 53, 1, false, "img/Products/PrintersandScanner/hp_deskjet_1516_fotokopi_tarayc_yazc_b2l60c.jpg", null, null },
                    { 54, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8033), 54, 1, false, "img/Products/PrintersandScanner/canon_ix6850_renkli_inkjet_a3_fotoraf_yazcswifi_canon_eurasia_garantili.jpg", null, null },
                    { 55, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8035), 55, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 56, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8036), 56, 1, false, "img/Products/PrintersandScanner/hp_officejet_j4500_wifi_faxl_ok_fonksiyonlu_renkli_yazc_cn547a.jpg", null, null },
                    { 57, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8038), 57, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 58, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8040), 58, 1, false, "img/Products/PrintersandScanner/berlin_shop_epson_ecotank_m1170_yazc_a4.jpg", null, null },
                    { 59, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8042), 59, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_wifi_ok_fonksiyonlu_yazc_bitmeyen_kartu_siyah_depo.jpg", null, null },
                    { 60, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8043), 60, 1, false, "img/Products/PrintersandScanner/canon_pixma_mg3050bk_wifi_fotokopi_tarayc_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 61, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8045), 61, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 62, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8047), 62, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 63, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8048), 63, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 64, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8049), 64, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 65, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8051), 65, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 66, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8053), 66, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 67, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8056), 67, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 68, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8058), 68, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 69, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8059), 69, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 70, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8061), 70, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 71, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8062), 71, 1, false, "img/Products/PrintersandScanner/hp_hp_officejet_pro_7740_geni_format_allinone_a3_yazc_1_set_orjinal_kartu_hediyeli.jpg", null, null },
                    { 72, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8063), 72, 1, false, "img/Products/PrintersandScanner/canon_pixma_ip2702_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 73, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8065), 73, 1, false, "img/Products/PrintersandScanner/epson_l100_dolum_niteli_mrekkep_pskrtmeli_yazc.jpg", null, null },
                    { 74, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8066), 74, 1, false, "img/Products/Phones/apple_iphone_13_128_gb_beyaz.jpg", null, null },
                    { 75, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8068), 75, 1, false, "img/Products/Phones/samsung_galaxy_a06_128_gb_4_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 76, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8069), 76, 1, false, "img/Products/Phones/apple_iphone_13_128_gb_siyah.jpg", null, null },
                    { 77, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8071), 77, 1, false, "img/Products/Phones/samsung_galaxy_a16_128_gb_6_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 78, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8072), 78, 1, false, "img/Products/Phones/samsung_galaxy_a35_256_gb_8_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 79, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8073), 79, 1, false, "img/Products/Phones/honor_magic_7_lite_256_gb_8_gb_ram_honor_trkiye_garantili_mor.jpg", null, null },
                    { 80, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8075), 80, 1, false, "img/Products/Phones/samsung_galaxy_a06_128_gb_4_gb_ram_samsung_trkiye_garantili_ak_mavi.jpg", null, null },
                    { 81, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8076), 81, 1, false, "img/Products/Phones/samsung_galaxy_s24_256_gb_12_gb_ram_samsung_trkiye_garantili_gri.jpg", null, null },
                    { 82, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8077), 82, 1, false, "img/Products/Phones/samsung_galaxy_a16_128_gb_6_gb_ram_samsung_trkiye_garantili_gri.jpg", null, null },
                    { 83, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8079), 83, 1, false, "img/Products/Phones/honor_magic_7_lite_256_gb_8_gb_ram_honor_trkiye_garantili_siyah.jpg", null, null },
                    { 84, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8080), 84, 1, false, "img/Products/Phones/samsung_galaxy_s24_fe_128_gb_8_gb_ram_samsung_trkiye_garantili_gri.jpg", null, null },
                    { 85, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8083), 85, 1, false, "img/Products/Phones/nothing_phone_1_256_gb_8_gb_ram_nothing_trkiye_garantili_siyah.jpg", null, null },
                    { 86, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8085), 86, 1, false, "img/Products/Phones/nothing_phone_2a_256_gb_12_gb_ram_nothing_trkiye_garantili_beyaz.jpg", null, null },
                    { 87, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8086), 87, 1, false, "img/Products/Phones/samsung_galaxy_a35_128_gb_8_gb_ram_samsung_trkiye_garantili_ak_mavi.jpg", null, null },
                    { 88, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8088), 88, 1, false, "img/Products/Phones/infinix_infnx_smart_9_128_gb_4_gb_ram_infnx_trkiye_garantili_nane_yeili.jpg", null, null },
                    { 89, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8089), 89, 1, false, "img/Products/Phones/samsung_galaxy_a55_128_gb_8_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 90, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8091), 90, 1, false, "img/Products/Phones/nothing_phone_2a_plus_256_gb_12_gb_ram_nothing_trkiye_garantili_gri.jpg", null, null },
                    { 91, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8092), 91, 1, false, "img/Products/Phones/samsung_galaxy_s24_fe_256_gb_8_gb_ram_samsung_trkiye_garantili_grafit.jpg", null, null },
                    { 92, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8093), 92, 1, false, "img/Products/Phones/apple_iphone_16e_128gb_beyaz.jpg", null, null },
                    { 93, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8094), 93, 1, false, "img/Products/Phones/samsung_galaxy_s24_fe_128_gb_8_gb_ram_samsung_trkiye_garantili_mavi.jpg", null, null },
                    { 94, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8096), 94, 1, false, "img/Products/Phones/samsung_galaxy_s25_256_gb_12_gb_ram_samsung_trkiye_garantili_lacivert.jpg", null, null },
                    { 95, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8097), 95, 1, false, "img/Products/Phones/samsung_b310_dual_sim_lacivert.jpg", null, null },
                    { 96, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8099), 96, 1, false, "img/Products/Phones/samsung_galaxy_s23_ultra_512_gb_12_gb_ram_samsung_trkiye_garantili_altn.jpg", null, null },
                    { 97, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8101), 97, 1, false, "img/Products/Phones/redmi_note_14_pro_12gb_512gb_xiaomi_trkiye_garantili.jpg", null, null },
                    { 98, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8103), 98, 1, false, "img/Products/Phones/samsung_b310_e_dual_sim_kamerasz_cep_telefonu_beyaz.jpg", null, null },
                    { 99, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8105), 99, 1, false, "img/Products/Phones/samsung_galaxy_a55_128_gb_8_gb_ram_samsung_trkiye_garantili_ak_mavi.jpg", null, null },
                    { 100, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8107), 100, 1, false, "img/Products/Phones/samsung_galaxy_a35_128_gb_8_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 101, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8108), 101, 1, false, "img/Products/Phones/redmi_note_14_pro_8gb_256gb_xiaomi_trkiye_garantili.jpg", null, null },
                    { 102, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8113), 102, 1, false, "img/Products/Phones/apple_iphone_15_256_gb_mavi.jpg", null, null },
                    { 103, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8115), 103, 1, false, "img/Products/Phones/apple_iphone_16_pro_256gb_beyaz.jpg", null, null },
                    { 104, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8116), 104, 1, false, "img/Products/Phones/xiaomi_14t_pro_12gb_512gb.jpg", null, null },
                    { 105, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8117), 105, 1, false, "img/Products/Phones/apple_iphone_16_pro_128gb_beyaz.jpg", null, null },
                    { 106, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8119), 106, 1, false, "img/Products/Phones/honor_200_512_gb_12_gb_ram_honor_trkiye_garantili_zmrt_yeili.jpg", null, null },
                    { 107, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8120), 107, 1, false, "img/Products/Phones/apple_iphone_16_pro_256gb_siyah.jpg", null, null },
                    { 108, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8122), 108, 1, false, "img/Products/Phones/xiaomi_redmi_note_13_pro_256gb_8gb_ram_xiaomi_trkiye_garantili_mor.jpg", null, null },
                    { 109, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8123), 109, 1, false, "img/Products/Phones/samsung_galaxy_s25_128_gb_12_gb_ram_samsung_trkiye_garantili_lacivert.jpg", null, null },
                    { 110, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8124), 110, 1, false, "img/Products/Phones/apple_iphone_16_256gb_lacivert_ta.jpg", null, null },
                    { 111, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8126), 111, 1, false, "img/Products/Phones/xiaomi_redmi_note_14_pro_plus_5g_512_gb_12_gb_ram_xiaomi_trkiye_garantili.jpg", null, null },
                    { 112, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8127), 112, 1, false, "img/Products/Phones/apple_iphone_16_pro_max_512gb_natrel_titanyum.jpg", null, null },
                    { 113, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8156), 113, 1, false, "img/Products/Phones/samsung_galaxy_a04s_64_gb_samsung_trkiye_garantili_siyah_64_gb_siyah.jpg", null, null },
                    { 114, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8158), 114, 1, false, "img/Products/Phones/redmi_note_14_pro_5g_12gb_512gb_xiaomi_trkiye_garantili.jpg", null, null },
                    { 115, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8160), 115, 1, false, "img/Products/Phones/nothing_phone_1_128_gb_8_gb_ram_nothing_trkiye_garantili_siyah.jpg", null, null },
                    { 116, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8161), 116, 1, false, "img/Products/Phones/xiaomi_redmi_note_13_pro_512gb_12gb_xiaomi_trkiye_garantili_siyah.jpg", null, null },
                    { 117, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8163), 117, 1, false, "img/Products/Phones/xiaomi_redmi_12_128_gb_8_gb_ram_xiaomi_trkiye_garantili_siyah.jpg", null, null },
                    { 118, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8164), 118, 1, false, "img/Products/Phones/honor_magic_v3_512_gb_12_gb_ram_honor_trkiye_garantili_yeil.jpg", null, null },
                    { 119, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8167), 119, 1, false, "img/Products/Phones/tecno_spark_30_256_gb_8_gb_ram.jpg", null, null },
                    { 120, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8168), 120, 1, false, "img/Products/Phones/samsung_galaxy_s25_ultra_1_tb_12_gb_ram_samsung_trkiye_garantili.jpg", null, null },
                    { 121, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8170), 121, 1, false, "img/Products/Phones/apple_iphone_16_pro_128gb_siyah.jpg", null, null },
                    { 122, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8171), 122, 1, false, "img/Products/Phones/reeder_p13_blue_max_l_2022_64_gb_reeder_trkiye_garantili_beyaz.jpg", null, null },
                    { 123, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8175), 123, 1, false, "img/Products/Phones/poco_poco_x7_12gb_512gb_xiaomi_trkiye_garantili.jpg", null, null },
                    { 124, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8177), 124, 1, false, "img/Products/Phones/oppo_a60_8gb_256gb_oppo_trkiye_garantili_mavi.jpg", null, null },
                    { 125, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8178), 125, 1, false, "img/Products/Phones/samsung_galaxy_a25_5g_256_gb_8_gb_ram_samsung_trkiye_garantili_siyah.jpg", null, null },
                    { 126, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8180), 126, 1, false, "img/Products/Phones/samsung_galaxy_s25_256_gb_lacivert.jpg", null, null },
                    { 127, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8181), 127, 1, false, "img/Products/Phones/panasonic_kx-tu550exb_katlanabilir_renkli_ekran_4g_tulu_cep_telefonu_siyah_2_yl_trkiye_distribtr_garantili_siyah.jpg", null, null },
                    { 128, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8182), 128, 1, false, "img/Products/Phones/reeder_s19_max_pro_256_gb_6_gb_ram_reeder_trkiye_garantili_siyah.jpg", null, null },
                    { 129, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8184), 129, 1, false, "img/Products/Phones/samsung_b310e_cep_telefonu_resmi_btk_kaytl2g_ve_3g_hatlar_n_beyaz.jpg", null, null },
                    { 130, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8187), 130, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 131, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8189), 131, 1, false, "img/Products/WhiteGoods/kumtel_kumtel_93l_beyaz_bro_tipi_buzdolab_hmb-110.jpg", null, null },
                    { 132, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8190), 132, 1, false, "img/Products/WhiteGoods/regal_bm_310_3_programl_bulak_makinesi.jpg", null, null },
                    { 133, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8192), 133, 1, false, "img/Products/WhiteGoods/arelik_ade_606_2b_yatk_davlumbaz_karbon_filtre_165732003.jpg", null, null },
                    { 134, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8194), 134, 1, false, "img/Products/WhiteGoods/altus_al_7103_md_1000_devir_7_kg_amar_makinesi.jpg", null, null },
                    { 135, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8195), 135, 1, false, "img/Products/WhiteGoods/altus_al_10123_d_c_enerji_10_kg_amar_makinesi.jpg", null, null },
                    { 136, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8202), 136, 1, false, "img/Products/WhiteGoods/hoover_ndeh_10a2tsbe-17_10_kg_wi-fi_bluetooth_balantl_is_pompal_kurutma_makinesi.jpg", null, null },
                    { 137, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8204), 137, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 138, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8207), 138, 1, false, "img/Products/WhiteGoods/samsung_ww11bga046aeah_11_kg_1400_devir_amar_makinesi.jpg", null, null },
                    { 139, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8208), 139, 1, false, "img/Products/WhiteGoods/vestel_sp_202-a_su_sebili.jpg", null, null },
                    { 140, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8210), 140, 1, false, "img/Products/WhiteGoods/regal_st_30010_242_lt_statik_buzdolab.jpg", null, null },
                    { 141, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8211), 141, 1, false, "img/Products/WhiteGoods/arelik_yeni_model_gri_buhar_destekli_cam_ankastre_set.jpg", null, null },
                    { 142, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8213), 142, 1, false, "img/Products/WhiteGoods/evora_sanayi_tipi_100_lt_soutmal_artmal_paslanmaz_endstriyel_su_sebili.jpg", null, null },
                    { 143, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8214), 143, 1, false, "img/Products/WhiteGoods/albergio_cam_damacana_kapakl_su_sebil_15_lt_tm_sebillere_uyumlu.jpg", null, null },
                    { 144, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8216), 144, 1, false, "img/Products/WhiteGoods/kiwi_kwp_8520_standl_su_pompas-beyaz.jpg", null, null },
                    { 145, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8219), 145, 1, false, "img/Products/WhiteGoods/vestel_sp_202-a_su_sebili.jpg", null, null },
                    { 146, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8220), 146, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 147, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8222), 147, 1, false, "img/Products/WhiteGoods/samsung_ww11bb534dabah_11_kg_1400_devir_bespoke_amar_makinesi_spacemax_ai_kontrol_paneli.jpg", null, null },
                    { 148, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8223), 148, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 149, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8225), 149, 1, false, "img/Products/WhiteGoods/kumtel_kumtel_93l_beyaz_bro_tipi_buzdolab_hmb-110.jpg", null, null },
                    { 150, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8226), 150, 1, false, "img/Products/WhiteGoods/vestel_sp_202-a_su_sebili.jpg", null, null },
                    { 151, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8228), 151, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 152, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8229), 152, 1, false, "img/Products/WhiteGoods/samsung_ww11bb534dabah_11_kg_1400_devir_bespoke_amar_makinesi_spacemax_ai_kontrol_paneli.jpg", null, null },
                    { 153, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8232), 153, 1, false, "img/Products/WhiteGoods/regal_bm_310_3_programl_bulak_makinesi.jpg", null, null },
                    { 154, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8233), 154, 1, false, "img/Products/WhiteGoods/vestel_sp_202-a_su_sebili.jpg", null, null },
                    { 155, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8234), 155, 1, false, "img/Products/WhiteGoods/arelik_6144_i_4_programl_bulak_makinesi.jpg", null, null },
                    { 156, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8236), 156, 1, false, "img/Products/WhiteGoods/altus_al_7103_md_1000_devir_7_kg_amar_makinesi.jpg", null, null },
                    { 157, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8238), 157, 1, false, "img/Products/WhiteGoods/altus_al_7103_md_1000_devir_7_kg_amar_makinesi.jpg", null, null },
                    { 158, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8240), 158, 1, false, "img/Products/WhiteGoods/altus_al_7103_md_1000_devir_7_kg_amar_makinesi.jpg", null, null },
                    { 159, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8241), 159, 1, false, "img/Products/AirConditionerandHeater/airfel_ltxm35n_12000_btu_r32_inverter_duvar_tipi_klima.jpg", null, null },
                    { 160, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8243), 160, 1, false, "img/Products/AirConditionerandHeater/regal_luna_a_15000_btu_inverte_duvar_tipi_klima.jpg", null, null },
                    { 161, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8244), 161, 1, false, "img/Products/AirConditionerandHeater/kumtel_bej_fanl_istc_2000_w_lx_-_6331.jpg", null, null },
                    { 162, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8246), 162, 1, false, "img/Products/AirConditionerandHeater/bosch_climate_cl2000u_w_35_e_a_12000_btu_duvar_tipi_klima.jpg", null, null },
                    { 163, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8247), 163, 1, false, "img/Products/AirConditionerandHeater/kaira_dtxr35e_a_12000_btu_wifi_inverter_duvar_tipi_klima_montaj_dahil.jpg", null, null },
                    { 164, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8248), 164, 1, false, "img/Products/AirConditionerandHeater/kumtel_juniper_portatif_tanabilir_klima_kmpac-7.jpg", null, null },
                    { 165, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8250), 165, 1, false, "img/Products/AirConditionerandHeater/vestel_flora_doa_124_a_wifi_12000_btu_inverter_duvar_tipi_klima.jpg", null, null },
                    { 166, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8251), 166, 1, false, "img/Products/AirConditionerandHeater/xiaomi_zmydfs01dm_arj_edilebilir_mini_fan.jpg", null, null },
                    { 167, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8252), 167, 1, false, "img/Products/AirConditionerandHeater/kumtel_lx-2832_siyah_1500_watt_istc.jpg", null, null },
                    { 168, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8254), 168, 1, false, "img/Products/AirConditionerandHeater/mirkraft_future_2500_watt_elektrikli_istc_-_ip24_-_lcd_ekran_-_uzaktan_kumandal_-_4_is_ayar.jpg", null, null },
                    { 169, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8255), 169, 1, false, "img/Products/AirConditionerandHeater/samsung_premium_ar18tshzhwk_a_18000_btu_inverter_duvar_tipi_klima.jpg", null, null },
                    { 170, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8258), 170, 1, false, "img/Products/AirConditionerandHeater/arnell_elektrikli_istc_quartz_ev_ve_ofis_oda_tipi_31_ubuklu_gvenli_elektrikli_soba_-_2600_watt.jpg", null, null },
                    { 171, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8259), 171, 1, false, "img/Products/AirConditionerandHeater/kumtel_ks-2760_quartz_istc_siyah.jpg", null, null },
                    { 172, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8290), 172, 1, false, "img/Products/AirConditionerandHeater/zeeful_sper_g_fleyici_mini_turbo_jet_fan_130000rpm_52ms_4000mah_yurt_dndan.jpg", null, null },
                    { 173, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8292), 173, 1, false, "img/Products/AirConditionerandHeater/beko_31225_ekolojik_a_12000_btu_duvar_tipi_klima.jpg", null, null },
                    { 174, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8293), 174, 1, false, "img/Products/AirConditionerandHeater/vestel_flora_doa_244_a_24000_btu_wifi_inverter_duvar_tipi_klima.jpg", null, null },
                    { 175, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8295), 175, 1, false, "img/Products/AirConditionerandHeater/arelik_ekolojik_18325_a_18000_btu_inverter_duvar_tipi_klima.jpg", null, null },
                    { 176, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8296), 176, 1, false, "img/Products/AirConditionerandHeater/arnell_elektrikli_istc_duvar_tip_soba_3000_watt.jpg", null, null },
                    { 177, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8298), 177, 1, false, "img/Products/AirConditionerandHeater/baymak_elegant_plus_uv_18_a_montaj_dahil_18000_btu_duvar_tipi_klima.jpg", null, null },
                    { 178, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8299), 178, 1, false, "img/Products/AirConditionerandHeater/fujiplus_fujiplus_sakura_12000_btu_inverter_duvar_tipi_klima.jpg", null, null },
                    { 179, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8300), 179, 1, false, "img/Products/AirConditionerandHeater/baymak_aqua_konfor_65_litre_termosifon.jpg", null, null },
                    { 180, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8302), 180, 1, false, "img/Products/AirConditionerandHeater/kumtel_ecoray_ex-25_2500_watt_duvar_tipi_infrared_istc.jpg", null, null },
                    { 181, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8303), 181, 1, false, "img/Products/AirConditionerandHeater/ufo_ufo_star_2400_w_duvar_tipi_istc_-_termostatl.jpg", null, null },
                    { 182, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8305), 182, 1, false, "img/Products/AirConditionerandHeater/abbruch_arj_edilebilir_tanabilir_ipli_mini_el_fan_kademe_hzl_gl_soutucu_pervane_vantilatr.jpg", null, null },
                    { 183, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8306), 183, 1, false, "img/Products/AirConditionerandHeater/sinbo_sf-6783_vantilatr.jpg", null, null },
                    { 184, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8307), 184, 1, false, "img/Products/AirConditionerandHeater/beko_31650_vantilatr_uzaktan_kumandal.jpg", null, null },
                    { 185, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8309), 185, 1, false, "img/Products/AirConditionerandHeater/ufo_ufo_micatronic_1900_w_kule_tipi_istc.jpg", null, null },
                    { 186, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8310), 186, 1, false, "img/Products/AirConditionerandHeater/ufo_omri_1200_w_termostatl_hem_yatay_hem_dikey_istc.jpg", null, null },
                    { 187, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8313), 187, 1, false, "img/Products/AirConditionerandHeater/kaira_dtxr71e_a_24000_btu_inverter_duvar_tipi_klima_montaj_dahil.jpg", null, null },
                    { 188, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8314), 188, 1, false, "img/Products/AirConditionerandHeater/baymak_duo_tec_compact_premix_24_kw_youmal_kombi_baca_dahil.jpg", null, null },
                    { 189, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8316), 189, 1, false, "img/Products/AirConditionerandHeater/ufo_isitici_star_s19_1900_w.jpg", null, null },
                    { 190, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8317), 190, 1, false, "img/Products/AirConditionerandHeater/magiceham_lilo_stitch_pelu_scak_su_istcs_-_lacivert_yurt_dndan.jpg", null, null },
                    { 191, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8319), 191, 1, false, "img/Products/AirConditionerandHeater/airfel_maestro_optimum_2024_kw_17000_kcal_tam_youmal_kombi.jpg", null, null },
                    { 192, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8320), 192, 1, false, "img/Products/ShoesandBag/lacoste_sport_court-master_pro_erkek_siyah_sneaker_744sma0084_02h.jpg", null, null },
                    { 193, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8321), 193, 1, false, "img/Products/ShoesandBag/letoon_2104_gnlk_unisex_spor_ayakkab.jpg", null, null },
                    { 194, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8323), 194, 1, false, "img/Products/ShoesandBag/derilax_hakiki_deri_tam_ortopedik_erkek_ayakkab.jpg", null, null },
                    { 195, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8324), 195, 1, false, "img/Products/ShoesandBag/hoti_hakiki_deri_siyah_erkek_gnlk_ayakkab.jpg", null, null },
                    { 196, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8325), 196, 1, false, "img/Products/ShoesandBag/ispartallar_7575_ortopedik_taban_yumuak_hakiki_deri_mevsimlik_klk_erkek_ayakkab.jpg", null, null },
                    { 197, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8327), 197, 1, false, "img/Products/ShoesandBag/under_armour_ocuk_ua_bgs_charged_rogue_4_kou_ayakkabs_3027106-400.jpg", null, null },
                    { 198, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8328), 198, 1, false, "img/Products/ShoesandBag/ispartallar_502_ortopedik_topuk_masajl_hakiki_deri_klk_erkek_ayakkab_backl.jpg", null, null },
                    { 199, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8329), 199, 1, false, "img/Products/ShoesandBag/muggo_samuel_garantili_gnlk_klasik_deri_casual_rahat_ortopedik_kaln_taban_erkek_ayakkab.jpg", null, null },
                    { 200, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8331), 200, 1, false, "img/Products/ShoesandBag/tomiross_erkek_atlanta_gnlk_kullanm_sneaker_ayakkab_atlnt-5025.jpg", null, null },
                    { 201, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8332), 201, 1, false, "img/Products/ShoesandBag/yaya_by_hoti_02ayy296160a100_siyah_erkek_ayakkab.jpg", null, null },
                    { 202, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8333), 202, 1, false, "img/Products/ShoesandBag/hoti_hakiki_deri_lacivert_erkek_gnlk_ayakkab.jpg", null, null },
                    { 203, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8335), 203, 1, false, "img/Products/ShoesandBag/derilax_deri_tam_ortopedik_erkek_ayakkab.jpg", null, null },
                    { 204, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8336), 204, 1, false, "img/Products/ShoesandBag/ispartallar_909_tam_ortopedik_taban_hakiki_deri_erkek_ayakkab_kadn_ayakkab_kaymaz_taban_unisex_ayakkab_lastikli_back.jpg", null, null },
                    { 205, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8338), 205, 1, false, "img/Products/ShoesandBag/selin_soylu_seln_soylu_hakiki_deri_erkek_ayakkab_klk_gnlk_ayakkab.jpg", null, null },
                    { 206, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8339), 206, 1, false, "img/Products/ShoesandBag/sebago_nubuk_koyu_kahve_-_siyah_erkek_gnlk_ayakkab_7111m5w.jpg", null, null },
                    { 207, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8340), 207, 1, false, "img/Products/ShoesandBag/lumberjack_4m_navgator_4fx.jpg", null, null },
                    { 208, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8342), 208, 1, false, "img/Products/ShoesandBag/sebago_deri_lacivert_erkek_gnlk_ayakkab_70004z0.jpg", null, null },
                    { 209, null, new DateTime(2025, 9, 22, 22, 15, 6, 302, DateTimeKind.Local).AddTicks(8343), 209, 1, false, "img/Products/ShoesandBag/dakrs_yazlk_erkek_keten_gnlk_rahat_hafif_backl_spor_ayakkab_40-44.jpg", null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductProperties",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "ProductId", "PropertyTypeId", "PropertyValueId", "Stock", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(6366), true, false, 1, 1, 1, 50, null, null },
                    { 2, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(6373), true, false, 1, 1, 2, 50, null, null },
                    { 3, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(6374), true, false, 1, 1, 3, 50, null, null },
                    { 4, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(6375), true, false, 1, 1, 4, 50, null, null },
                    { 5, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(6378), true, false, 1, 4, 15, 50, null, null },
                    { 6, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(6383), true, false, 1, 5, 24, 50, null, null },
                    { 7, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(6389), true, false, 1, 6, 28, 50, null, null },
                    { 8, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(6392), true, false, 1, 7, 30, 50, null, null },
                    { 9, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(7589), true, false, 2, 1, 1, 50, null, null },
                    { 10, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(7593), true, false, 2, 1, 2, 50, null, null },
                    { 11, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(7594), true, false, 2, 1, 3, 50, null, null },
                    { 12, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(7595), true, false, 2, 1, 4, 50, null, null },
                    { 13, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(7598), true, false, 2, 4, 16, 50, null, null },
                    { 14, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(7632), true, false, 2, 5, 23, 50, null, null },
                    { 15, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(7635), true, false, 2, 6, 27, 50, null, null },
                    { 16, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(7638), true, false, 2, 7, 29, 50, null, null },
                    { 17, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(8532), true, false, 3, 1, 1, 50, null, null },
                    { 18, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(8533), true, false, 3, 1, 2, 50, null, null },
                    { 19, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(8534), true, false, 3, 1, 3, 50, null, null },
                    { 20, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(8535), true, false, 3, 1, 4, 50, null, null },
                    { 21, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(8556), true, false, 3, 4, 17, 50, null, null },
                    { 22, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(8558), true, false, 3, 5, 24, 50, null, null },
                    { 23, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(8559), true, false, 3, 6, 28, 50, null, null },
                    { 24, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(8561), true, false, 3, 7, 31, 50, null, null },
                    { 25, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(9454), true, false, 4, 1, 1, 50, null, null },
                    { 26, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(9455), true, false, 4, 1, 2, 50, null, null },
                    { 27, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(9456), true, false, 4, 1, 3, 50, null, null },
                    { 28, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(9486), true, false, 4, 1, 4, 50, null, null },
                    { 29, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(9489), true, false, 4, 4, 17, 50, null, null },
                    { 30, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(9491), true, false, 4, 5, 24, 50, null, null },
                    { 31, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(9493), true, false, 4, 6, 28, 50, null, null },
                    { 32, null, new DateTime(2025, 9, 22, 22, 15, 6, 303, DateTimeKind.Local).AddTicks(9496), true, false, 4, 7, 30, 50, null, null },
                    { 33, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(598), true, false, 5, 1, 1, 50, null, null },
                    { 34, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(629), true, false, 5, 1, 2, 50, null, null },
                    { 35, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(630), true, false, 5, 1, 3, 50, null, null },
                    { 36, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(631), true, false, 5, 1, 4, 50, null, null },
                    { 37, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(633), true, false, 5, 4, 18, 50, null, null },
                    { 38, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(635), true, false, 5, 5, 23, 50, null, null },
                    { 39, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(637), true, false, 5, 6, 27, 50, null, null },
                    { 40, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(639), true, false, 5, 7, 30, 50, null, null },
                    { 41, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(1691), true, false, 6, 1, 1, 50, null, null },
                    { 42, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(1692), true, false, 6, 1, 2, 50, null, null },
                    { 43, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(1693), true, false, 6, 1, 3, 50, null, null },
                    { 44, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(1694), true, false, 6, 1, 4, 50, null, null },
                    { 45, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(1695), true, false, 6, 4, 19, 50, null, null },
                    { 46, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(1696), true, false, 6, 5, 23, 50, null, null },
                    { 47, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(1697), true, false, 6, 6, 27, 50, null, null },
                    { 48, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(1699), true, false, 6, 7, 31, 50, null, null },
                    { 49, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(2746), true, false, 7, 1, 1, 50, null, null },
                    { 50, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(2747), true, false, 7, 1, 2, 50, null, null },
                    { 51, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(2748), true, false, 7, 1, 3, 50, null, null },
                    { 52, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(2749), true, false, 7, 1, 4, 50, null, null },
                    { 53, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(2751), true, false, 7, 4, 20, 50, null, null },
                    { 54, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(2753), true, false, 7, 5, 23, 50, null, null },
                    { 55, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(2755), true, false, 7, 6, 27, 50, null, null },
                    { 56, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(2758), true, false, 7, 7, 30, 50, null, null },
                    { 57, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(3781), true, false, 8, 1, 1, 50, null, null },
                    { 58, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(3783), true, false, 8, 1, 2, 50, null, null },
                    { 59, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(3784), true, false, 8, 1, 3, 50, null, null },
                    { 60, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(3785), true, false, 8, 1, 4, 50, null, null },
                    { 61, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(3787), true, false, 8, 4, 21, 50, null, null },
                    { 62, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(3789), true, false, 8, 5, 22, 50, null, null },
                    { 63, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(3790), true, false, 8, 6, 27, 50, null, null },
                    { 64, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(3792), true, false, 8, 7, 30, 50, null, null },
                    { 65, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(4937), true, false, 9, 1, 1, 50, null, null },
                    { 66, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(4941), true, false, 9, 1, 2, 50, null, null },
                    { 67, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(4942), true, false, 9, 1, 3, 50, null, null },
                    { 68, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(4943), true, false, 9, 1, 4, 50, null, null },
                    { 69, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(4945), true, false, 9, 4, 16, 50, null, null },
                    { 70, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(4947), true, false, 9, 5, 23, 50, null, null },
                    { 71, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(4949), true, false, 9, 6, 26, 50, null, null },
                    { 72, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(4951), true, false, 9, 7, 30, 50, null, null },
                    { 73, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(6015), true, false, 10, 1, 1, 50, null, null },
                    { 74, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(6016), true, false, 10, 1, 2, 50, null, null },
                    { 75, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(6017), true, false, 10, 1, 3, 50, null, null },
                    { 76, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(6017), true, false, 10, 1, 4, 50, null, null },
                    { 77, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(6019), true, false, 10, 4, 32, 50, null, null },
                    { 78, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(6021), true, false, 10, 5, 24, 50, null, null },
                    { 79, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(6025), true, false, 10, 6, 28, 50, null, null },
                    { 80, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(6027), true, false, 10, 7, 30, 50, null, null },
                    { 81, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(9332), true, false, 11, 1, 1, 50, null, null },
                    { 82, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(9334), true, false, 11, 1, 2, 50, null, null },
                    { 83, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(9335), true, false, 11, 1, 3, 50, null, null },
                    { 84, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(9335), true, false, 11, 1, 4, 50, null, null },
                    { 85, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(9338), true, false, 11, 4, 21, 50, null, null },
                    { 86, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(9341), true, false, 11, 5, 24, 50, null, null },
                    { 87, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(9348), true, false, 11, 6, 26, 50, null, null },
                    { 88, null, new DateTime(2025, 9, 22, 22, 15, 6, 304, DateTimeKind.Local).AddTicks(9350), true, false, 11, 7, 30, 50, null, null },
                    { 89, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(644), true, false, 12, 1, 1, 50, null, null },
                    { 90, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(645), true, false, 12, 1, 2, 50, null, null },
                    { 91, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(647), true, false, 12, 1, 3, 50, null, null },
                    { 92, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(647), true, false, 12, 1, 4, 50, null, null },
                    { 93, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(649), true, false, 12, 4, 36, 50, null, null },
                    { 94, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(651), true, false, 12, 5, 23, 50, null, null },
                    { 95, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(653), true, false, 12, 6, 26, 50, null, null },
                    { 96, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(655), true, false, 12, 7, 30, 50, null, null },
                    { 97, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(1677), true, false, 13, 1, 1, 50, null, null },
                    { 98, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(1678), true, false, 13, 1, 2, 50, null, null },
                    { 99, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(1678), true, false, 13, 1, 3, 50, null, null },
                    { 100, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(1679), true, false, 13, 1, 4, 50, null, null },
                    { 101, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(1681), true, false, 13, 4, 16, 50, null, null },
                    { 102, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(1683), true, false, 13, 5, 23, 50, null, null },
                    { 103, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(1685), true, false, 13, 6, 27, 50, null, null },
                    { 104, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(1687), true, false, 13, 7, 30, 50, null, null },
                    { 105, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(2857), true, false, 14, 1, 1, 50, null, null },
                    { 106, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(2858), true, false, 14, 1, 2, 50, null, null },
                    { 107, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(2858), true, false, 14, 1, 3, 50, null, null },
                    { 108, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(2859), true, false, 14, 1, 4, 50, null, null },
                    { 109, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(2860), true, false, 14, 4, 15, 50, null, null },
                    { 110, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(2862), true, false, 14, 5, 24, 50, null, null },
                    { 111, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(2864), true, false, 14, 6, 28, 50, null, null },
                    { 112, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(2866), true, false, 14, 7, 30, 50, null, null },
                    { 113, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(4087), true, false, 15, 1, 1, 50, null, null },
                    { 114, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(4088), true, false, 15, 1, 2, 50, null, null },
                    { 115, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(4088), true, false, 15, 1, 3, 50, null, null },
                    { 116, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(4089), true, false, 15, 1, 4, 50, null, null },
                    { 117, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(4091), true, false, 15, 4, 19, 50, null, null },
                    { 118, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(4093), true, false, 15, 5, 24, 50, null, null },
                    { 119, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(4095), true, false, 15, 6, 26, 50, null, null },
                    { 120, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(4096), true, false, 15, 7, 30, 50, null, null },
                    { 121, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(5114), true, false, 16, 1, 1, 50, null, null },
                    { 122, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(5115), true, false, 16, 1, 2, 50, null, null },
                    { 123, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(5116), true, false, 16, 1, 3, 50, null, null },
                    { 124, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(5116), true, false, 16, 1, 4, 50, null, null },
                    { 125, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(5118), true, false, 16, 4, 15, 50, null, null },
                    { 126, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(5120), true, false, 16, 5, 24, 50, null, null },
                    { 127, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(5122), true, false, 16, 6, 28, 50, null, null },
                    { 128, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(5124), true, false, 16, 7, 30, 50, null, null },
                    { 129, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(5883), true, false, 17, 1, 1, 50, null, null },
                    { 130, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(5889), true, false, 17, 1, 2, 50, null, null },
                    { 131, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(5889), true, false, 17, 1, 3, 50, null, null },
                    { 132, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(5890), true, false, 17, 1, 4, 50, null, null },
                    { 133, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(5892), true, false, 17, 4, 33, 50, null, null },
                    { 134, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(5893), true, false, 17, 5, 24, 50, null, null },
                    { 135, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(5895), true, false, 17, 6, 28, 50, null, null },
                    { 136, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(5897), true, false, 17, 7, 30, 50, null, null },
                    { 137, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(6737), true, false, 18, 1, 1, 50, null, null },
                    { 138, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(6738), true, false, 18, 1, 2, 50, null, null },
                    { 139, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(6739), true, false, 18, 1, 3, 50, null, null },
                    { 140, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(6739), true, false, 18, 1, 4, 50, null, null },
                    { 141, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(6741), true, false, 18, 4, 21, 50, null, null },
                    { 142, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(6743), true, false, 18, 5, 23, 50, null, null },
                    { 143, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(6744), true, false, 18, 6, 28, 50, null, null },
                    { 144, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(6746), true, false, 18, 7, 30, 50, null, null },
                    { 145, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(7485), true, false, 19, 1, 1, 50, null, null },
                    { 146, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(7485), true, false, 19, 1, 2, 50, null, null },
                    { 147, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(7486), true, false, 19, 1, 3, 50, null, null },
                    { 148, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(7486), true, false, 19, 1, 4, 50, null, null },
                    { 149, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(7487), true, false, 19, 4, 21, 50, null, null },
                    { 150, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(7488), true, false, 19, 5, 22, 50, null, null },
                    { 151, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(7489), true, false, 19, 6, 27, 50, null, null },
                    { 152, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(7490), true, false, 19, 7, 30, 50, null, null },
                    { 153, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(8099), true, false, 20, 1, 1, 50, null, null },
                    { 154, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(8100), true, false, 20, 1, 2, 50, null, null },
                    { 155, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(8100), true, false, 20, 1, 3, 50, null, null },
                    { 156, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(8101), true, false, 20, 1, 4, 50, null, null },
                    { 157, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(8102), true, false, 20, 4, 16, 50, null, null },
                    { 158, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(8103), true, false, 20, 5, 22, 50, null, null },
                    { 159, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(8104), true, false, 20, 6, 27, 50, null, null },
                    { 160, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(8104), true, false, 20, 7, 30, 50, null, null },
                    { 161, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(8785), true, false, 21, 1, 1, 50, null, null },
                    { 162, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(8786), true, false, 21, 1, 2, 50, null, null },
                    { 163, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(8786), true, false, 21, 1, 3, 50, null, null },
                    { 164, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(8787), true, false, 21, 1, 4, 50, null, null },
                    { 165, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(8788), true, false, 21, 4, 19, 50, null, null },
                    { 166, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(8789), true, false, 21, 5, 23, 50, null, null },
                    { 167, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(8789), true, false, 21, 6, 12, 50, null, null },
                    { 168, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(8790), true, false, 21, 7, 29, 50, null, null },
                    { 169, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(9324), true, false, 22, 1, 1, 50, null, null },
                    { 170, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(9324), true, false, 22, 1, 2, 50, null, null },
                    { 171, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(9325), true, false, 22, 1, 3, 50, null, null },
                    { 172, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(9325), true, false, 22, 1, 4, 50, null, null },
                    { 173, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(9327), true, false, 22, 4, 19, 50, null, null },
                    { 174, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(9327), true, false, 22, 5, 23, 50, null, null },
                    { 175, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(9328), true, false, 22, 6, 28, 50, null, null },
                    { 176, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(9329), true, false, 22, 7, 30, 50, null, null },
                    { 177, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(9909), true, false, 23, 1, 1, 50, null, null },
                    { 178, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(9910), true, false, 23, 1, 2, 50, null, null },
                    { 179, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(9910), true, false, 23, 1, 3, 50, null, null },
                    { 180, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(9911), true, false, 23, 1, 4, 50, null, null },
                    { 181, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(9913), true, false, 23, 4, 35, 50, null, null },
                    { 182, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(9915), true, false, 23, 5, 23, 50, null, null },
                    { 183, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(9916), true, false, 23, 6, 27, 50, null, null },
                    { 184, null, new DateTime(2025, 9, 22, 22, 15, 6, 305, DateTimeKind.Local).AddTicks(9918), true, false, 23, 7, 29, 50, null, null },
                    { 185, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(860), true, false, 24, 1, 1, 50, null, null },
                    { 186, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(860), true, false, 24, 1, 2, 50, null, null },
                    { 187, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(861), true, false, 24, 1, 3, 50, null, null },
                    { 188, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(862), true, false, 24, 1, 4, 50, null, null },
                    { 189, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(863), true, false, 24, 4, 19, 50, null, null },
                    { 190, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(864), true, false, 24, 5, 24, 50, null, null },
                    { 191, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(864), true, false, 24, 6, 28, 50, null, null },
                    { 192, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(865), true, false, 24, 7, 31, 50, null, null },
                    { 193, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(1452), true, false, 25, 1, 1, 50, null, null },
                    { 194, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(1452), true, false, 25, 1, 2, 50, null, null },
                    { 195, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(1453), true, false, 25, 1, 3, 50, null, null },
                    { 196, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(1453), true, false, 25, 1, 4, 50, null, null },
                    { 197, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(1454), true, false, 25, 4, 34, 50, null, null },
                    { 198, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(1455), true, false, 25, 5, 24, 50, null, null },
                    { 199, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(1456), true, false, 25, 6, 26, 50, null, null },
                    { 200, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(1456), true, false, 25, 7, 30, 50, null, null },
                    { 201, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(2205), true, false, 26, 1, 1, 50, null, null },
                    { 202, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(2206), true, false, 26, 1, 2, 50, null, null },
                    { 203, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(2206), true, false, 26, 1, 3, 50, null, null },
                    { 204, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(2207), true, false, 26, 1, 4, 50, null, null },
                    { 205, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(2208), true, false, 26, 4, 17, 50, null, null },
                    { 206, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(2209), true, false, 26, 5, 24, 50, null, null },
                    { 207, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(2209), true, false, 26, 6, 28, 50, null, null },
                    { 208, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(2210), true, false, 26, 7, 31, 50, null, null },
                    { 209, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(2758), true, false, 27, 1, 1, 50, null, null },
                    { 210, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(2758), true, false, 27, 1, 2, 50, null, null },
                    { 211, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(2759), true, false, 27, 1, 3, 50, null, null },
                    { 212, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(2759), true, false, 27, 1, 4, 50, null, null },
                    { 213, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(2760), true, false, 27, 4, 19, 50, null, null },
                    { 214, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(2761), true, false, 27, 5, 23, 50, null, null },
                    { 215, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(2762), true, false, 27, 6, 26, 50, null, null },
                    { 216, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(2762), true, false, 27, 7, 30, 50, null, null },
                    { 217, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(3297), true, false, 28, 1, 1, 50, null, null },
                    { 218, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(3297), true, false, 28, 1, 2, 50, null, null },
                    { 219, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(3298), true, false, 28, 1, 3, 50, null, null },
                    { 220, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(3298), true, false, 28, 1, 4, 50, null, null },
                    { 221, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(3299), true, false, 28, 4, 36, 50, null, null },
                    { 222, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(3300), true, false, 28, 5, 23, 50, null, null },
                    { 223, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(3301), true, false, 28, 6, 28, 50, null, null },
                    { 224, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(3325), true, false, 28, 7, 30, 50, null, null },
                    { 225, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(3970), true, false, 29, 1, 1, 50, null, null },
                    { 226, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(3971), true, false, 29, 1, 2, 50, null, null },
                    { 227, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(3971), true, false, 29, 1, 3, 50, null, null },
                    { 228, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(3972), true, false, 29, 1, 4, 50, null, null },
                    { 229, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(3988), true, false, 29, 4, 19, 50, null, null },
                    { 230, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(3989), true, false, 29, 5, 22, 50, null, null },
                    { 231, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(3990), true, false, 29, 6, 27, 50, null, null },
                    { 232, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(3991), true, false, 29, 7, 30, 50, null, null },
                    { 233, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(4636), true, false, 30, 1, 1, 50, null, null },
                    { 234, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(4637), true, false, 30, 1, 2, 50, null, null },
                    { 235, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(4637), true, false, 30, 1, 3, 50, null, null },
                    { 236, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(4769), true, false, 30, 1, 4, 50, null, null },
                    { 237, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(4772), true, false, 30, 4, 16, 50, null, null },
                    { 238, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(4774), true, false, 30, 5, 24, 50, null, null },
                    { 239, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(4776), true, false, 30, 6, 28, 50, null, null },
                    { 240, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(4778), true, false, 30, 7, 30, 50, null, null },
                    { 241, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(5589), true, false, 31, 1, 1, 50, null, null },
                    { 242, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(5589), true, false, 31, 1, 2, 50, null, null },
                    { 243, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(5637), true, false, 31, 1, 3, 50, null, null },
                    { 244, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(5638), true, false, 31, 1, 4, 50, null, null },
                    { 245, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(5640), true, false, 31, 4, 21, 50, null, null },
                    { 246, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(5642), true, false, 31, 5, 23, 50, null, null },
                    { 247, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(5644), true, false, 31, 6, 12, 50, null, null },
                    { 248, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(5646), true, false, 31, 7, 29, 50, null, null },
                    { 249, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(6898), true, false, 32, 1, 52, 50, null, null },
                    { 250, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(6937), true, false, 32, 1, 53, 50, null, null },
                    { 251, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(6938), true, false, 32, 1, 54, 50, null, null },
                    { 252, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(6940), true, false, 32, 8, 37, 50, null, null },
                    { 253, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(6943), true, false, 32, 9, 40, 50, null, null },
                    { 254, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(6945), true, false, 32, 10, 43, 50, null, null },
                    { 255, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(6978), true, false, 32, 11, 46, 50, null, null },
                    { 256, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(6979), true, false, 32, 11, 47, 50, null, null },
                    { 257, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(6980), true, false, 32, 11, 48, 50, null, null },
                    { 258, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(6985), true, false, 32, 11, 50, 50, null, null },
                    { 259, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(6986), true, false, 32, 11, 51, 50, null, null },
                    { 260, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(7860), true, false, 33, 1, 52, 50, null, null },
                    { 261, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(7861), true, false, 33, 1, 53, 50, null, null },
                    { 262, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(7861), true, false, 33, 1, 54, 50, null, null },
                    { 263, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(7863), true, false, 33, 8, 37, 50, null, null },
                    { 264, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(7865), true, false, 33, 9, 40, 50, null, null },
                    { 265, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(7866), true, false, 33, 10, 43, 50, null, null },
                    { 266, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(7872), true, false, 33, 11, 46, 50, null, null },
                    { 267, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(7873), true, false, 33, 11, 47, 50, null, null },
                    { 268, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(7873), true, false, 33, 11, 48, 50, null, null },
                    { 269, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(7874), true, false, 33, 11, 50, 50, null, null },
                    { 270, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(7874), true, false, 33, 11, 51, 50, null, null },
                    { 271, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(8719), true, false, 34, 1, 52, 50, null, null },
                    { 272, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(8719), true, false, 34, 1, 53, 50, null, null },
                    { 273, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(8720), true, false, 34, 1, 54, 50, null, null },
                    { 274, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(8721), true, false, 34, 8, 37, 50, null, null },
                    { 275, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(8721), true, false, 34, 9, 40, 50, null, null },
                    { 276, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(8722), true, false, 34, 10, 43, 50, null, null },
                    { 277, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(8724), true, false, 34, 11, 46, 50, null, null },
                    { 278, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(8725), true, false, 34, 11, 47, 50, null, null },
                    { 279, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(8725), true, false, 34, 11, 48, 50, null, null },
                    { 280, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(8726), true, false, 34, 11, 50, 50, null, null },
                    { 281, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(8726), true, false, 34, 11, 51, 50, null, null },
                    { 282, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(9445), true, false, 35, 1, 52, 50, null, null },
                    { 283, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(9445), true, false, 35, 1, 53, 50, null, null },
                    { 284, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(9446), true, false, 35, 1, 54, 50, null, null },
                    { 285, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(9447), true, false, 35, 8, 37, 50, null, null },
                    { 286, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(9449), true, false, 35, 9, 40, 50, null, null },
                    { 287, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(9450), true, false, 35, 10, 43, 50, null, null },
                    { 288, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(9455), true, false, 35, 11, 46, 50, null, null },
                    { 289, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(9456), true, false, 35, 11, 47, 50, null, null },
                    { 290, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(9457), true, false, 35, 11, 48, 50, null, null },
                    { 291, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(9457), true, false, 35, 11, 50, 50, null, null },
                    { 292, null, new DateTime(2025, 9, 22, 22, 15, 6, 306, DateTimeKind.Local).AddTicks(9458), true, false, 35, 11, 51, 50, null, null },
                    { 293, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(254), true, false, 36, 1, 52, 50, null, null },
                    { 294, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(255), true, false, 36, 1, 53, 50, null, null },
                    { 295, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(255), true, false, 36, 1, 54, 50, null, null },
                    { 296, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(256), true, false, 36, 8, 37, 50, null, null },
                    { 297, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(256), true, false, 36, 9, 40, 50, null, null },
                    { 298, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(257), true, false, 36, 10, 43, 50, null, null },
                    { 299, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(259), true, false, 36, 11, 46, 50, null, null },
                    { 300, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(260), true, false, 36, 11, 47, 50, null, null },
                    { 301, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(445), true, false, 36, 11, 48, 50, null, null },
                    { 302, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(446), true, false, 36, 11, 50, 50, null, null },
                    { 303, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(446), true, false, 36, 11, 51, 50, null, null },
                    { 304, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1006), true, false, 37, 1, 52, 50, null, null },
                    { 305, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1007), true, false, 37, 1, 53, 50, null, null },
                    { 306, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1007), true, false, 37, 1, 54, 50, null, null },
                    { 307, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1008), true, false, 37, 8, 37, 50, null, null },
                    { 308, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1036), true, false, 37, 9, 40, 50, null, null },
                    { 309, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1037), true, false, 37, 10, 43, 50, null, null },
                    { 310, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1039), true, false, 37, 11, 46, 50, null, null },
                    { 311, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1039), true, false, 37, 11, 47, 50, null, null },
                    { 312, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1040), true, false, 37, 11, 48, 50, null, null },
                    { 313, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1040), true, false, 37, 11, 50, 50, null, null },
                    { 314, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1041), true, false, 37, 11, 51, 50, null, null },
                    { 315, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1717), true, false, 38, 1, 52, 50, null, null },
                    { 316, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1718), true, false, 38, 1, 53, 50, null, null },
                    { 317, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1718), true, false, 38, 1, 54, 50, null, null },
                    { 318, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1719), true, false, 38, 8, 37, 50, null, null },
                    { 319, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1720), true, false, 38, 9, 40, 50, null, null },
                    { 320, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1721), true, false, 38, 10, 43, 50, null, null },
                    { 321, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1722), true, false, 38, 11, 46, 50, null, null },
                    { 322, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1723), true, false, 38, 11, 47, 50, null, null },
                    { 323, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1724), true, false, 38, 11, 48, 50, null, null },
                    { 324, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1725), true, false, 38, 11, 50, 50, null, null },
                    { 325, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(1725), true, false, 38, 11, 51, 50, null, null },
                    { 326, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2238), true, false, 39, 1, 52, 50, null, null },
                    { 327, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2238), true, false, 39, 1, 53, 50, null, null },
                    { 328, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2239), true, false, 39, 1, 54, 50, null, null },
                    { 329, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2239), true, false, 39, 8, 37, 50, null, null },
                    { 330, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2240), true, false, 39, 9, 40, 50, null, null },
                    { 331, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2240), true, false, 39, 10, 43, 50, null, null },
                    { 332, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2241), true, false, 39, 11, 46, 50, null, null },
                    { 333, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2242), true, false, 39, 11, 47, 50, null, null },
                    { 334, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2243), true, false, 39, 11, 48, 50, null, null },
                    { 335, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2243), true, false, 39, 11, 50, 50, null, null },
                    { 336, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2243), true, false, 39, 11, 51, 50, null, null },
                    { 337, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2801), true, false, 40, 1, 52, 50, null, null },
                    { 338, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2802), true, false, 40, 1, 53, 50, null, null },
                    { 339, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2802), true, false, 40, 1, 54, 50, null, null },
                    { 340, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2803), true, false, 40, 8, 37, 50, null, null },
                    { 341, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2803), true, false, 40, 9, 40, 50, null, null },
                    { 342, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2804), true, false, 40, 10, 43, 50, null, null },
                    { 343, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2805), true, false, 40, 11, 46, 50, null, null },
                    { 344, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2805), true, false, 40, 11, 47, 50, null, null },
                    { 345, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2806), true, false, 40, 11, 48, 50, null, null },
                    { 346, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2807), true, false, 40, 11, 50, 50, null, null },
                    { 347, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(2807), true, false, 40, 11, 51, 50, null, null },
                    { 348, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3388), true, false, 41, 1, 52, 50, null, null },
                    { 349, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3388), true, false, 41, 1, 53, 50, null, null },
                    { 350, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3389), true, false, 41, 1, 54, 50, null, null },
                    { 351, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3389), true, false, 41, 8, 37, 50, null, null },
                    { 352, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3390), true, false, 41, 9, 40, 50, null, null },
                    { 353, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3390), true, false, 41, 10, 43, 50, null, null },
                    { 354, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3392), true, false, 41, 11, 46, 50, null, null },
                    { 355, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3393), true, false, 41, 11, 47, 50, null, null },
                    { 356, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3393), true, false, 41, 11, 48, 50, null, null },
                    { 357, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3394), true, false, 41, 11, 50, 50, null, null },
                    { 358, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3395), true, false, 41, 11, 51, 50, null, null },
                    { 359, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3905), true, false, 42, 1, 52, 50, null, null },
                    { 360, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3906), true, false, 42, 1, 53, 50, null, null },
                    { 361, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3906), true, false, 42, 1, 54, 50, null, null },
                    { 362, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3907), true, false, 42, 8, 37, 50, null, null },
                    { 363, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3907), true, false, 42, 9, 40, 50, null, null },
                    { 364, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3908), true, false, 42, 10, 43, 50, null, null },
                    { 365, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3909), true, false, 42, 11, 46, 50, null, null },
                    { 366, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3910), true, false, 42, 11, 47, 50, null, null },
                    { 367, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3910), true, false, 42, 11, 48, 50, null, null },
                    { 368, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3911), true, false, 42, 11, 50, 50, null, null },
                    { 369, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(3911), true, false, 42, 11, 51, 50, null, null },
                    { 370, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(4437), true, false, 43, 1, 52, 50, null, null },
                    { 371, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(4437), true, false, 43, 1, 53, 50, null, null },
                    { 372, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(4438), true, false, 43, 1, 54, 50, null, null },
                    { 373, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(4438), true, false, 43, 8, 37, 50, null, null },
                    { 374, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(4439), true, false, 43, 9, 40, 50, null, null },
                    { 375, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(4439), true, false, 43, 10, 43, 50, null, null },
                    { 376, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(4441), true, false, 43, 11, 46, 50, null, null },
                    { 377, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(4441), true, false, 43, 11, 47, 50, null, null },
                    { 378, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(4442), true, false, 43, 11, 48, 50, null, null },
                    { 379, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(4442), true, false, 43, 11, 50, 50, null, null },
                    { 380, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(4443), true, false, 43, 11, 51, 50, null, null },
                    { 381, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5255), true, false, 44, 1, 52, 50, null, null },
                    { 382, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5256), true, false, 44, 1, 53, 50, null, null },
                    { 383, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5256), true, false, 44, 1, 54, 50, null, null },
                    { 384, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5257), true, false, 44, 8, 37, 50, null, null },
                    { 385, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5257), true, false, 44, 9, 40, 50, null, null },
                    { 386, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5258), true, false, 44, 10, 43, 50, null, null },
                    { 387, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5259), true, false, 44, 11, 46, 50, null, null },
                    { 388, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5260), true, false, 44, 11, 47, 50, null, null },
                    { 389, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5260), true, false, 44, 11, 48, 50, null, null },
                    { 390, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5262), true, false, 44, 11, 50, 50, null, null },
                    { 391, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5262), true, false, 44, 11, 51, 50, null, null },
                    { 392, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5750), true, false, 45, 1, 52, 50, null, null },
                    { 393, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5750), true, false, 45, 1, 53, 50, null, null },
                    { 394, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5751), true, false, 45, 1, 54, 50, null, null },
                    { 395, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5751), true, false, 45, 8, 37, 50, null, null },
                    { 396, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5752), true, false, 45, 9, 40, 50, null, null },
                    { 397, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5752), true, false, 45, 10, 43, 50, null, null },
                    { 398, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5754), true, false, 45, 11, 46, 50, null, null },
                    { 399, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5755), true, false, 45, 11, 47, 50, null, null },
                    { 400, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5755), true, false, 45, 11, 48, 50, null, null },
                    { 401, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5756), true, false, 45, 11, 50, 50, null, null },
                    { 402, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(5756), true, false, 45, 11, 51, 50, null, null },
                    { 403, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6289), true, false, 46, 1, 52, 50, null, null },
                    { 404, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6289), true, false, 46, 1, 53, 50, null, null },
                    { 405, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6290), true, false, 46, 1, 54, 50, null, null },
                    { 406, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6290), true, false, 46, 8, 37, 50, null, null },
                    { 407, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6291), true, false, 46, 9, 40, 50, null, null },
                    { 408, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6291), true, false, 46, 10, 43, 50, null, null },
                    { 409, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6292), true, false, 46, 11, 46, 50, null, null },
                    { 410, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6293), true, false, 46, 11, 47, 50, null, null },
                    { 411, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6293), true, false, 46, 11, 48, 50, null, null },
                    { 412, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6294), true, false, 46, 11, 50, 50, null, null },
                    { 413, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6294), true, false, 46, 11, 51, 50, null, null },
                    { 414, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6870), true, false, 47, 1, 52, 50, null, null },
                    { 415, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6870), true, false, 47, 1, 53, 50, null, null },
                    { 416, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6871), true, false, 47, 1, 54, 50, null, null },
                    { 417, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6871), true, false, 47, 8, 37, 50, null, null },
                    { 418, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6872), true, false, 47, 9, 40, 50, null, null },
                    { 419, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6872), true, false, 47, 10, 43, 50, null, null },
                    { 420, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6874), true, false, 47, 11, 46, 50, null, null },
                    { 421, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6874), true, false, 47, 11, 47, 50, null, null },
                    { 422, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6875), true, false, 47, 11, 48, 50, null, null },
                    { 423, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6875), true, false, 47, 11, 50, 50, null, null },
                    { 424, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(6876), true, false, 47, 11, 51, 50, null, null },
                    { 425, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7357), true, false, 48, 1, 52, 50, null, null },
                    { 426, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7358), true, false, 48, 1, 53, 50, null, null },
                    { 427, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7358), true, false, 48, 1, 54, 50, null, null },
                    { 428, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7359), true, false, 48, 8, 37, 50, null, null },
                    { 429, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7359), true, false, 48, 9, 40, 50, null, null },
                    { 430, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7360), true, false, 48, 10, 43, 50, null, null },
                    { 431, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7361), true, false, 48, 11, 46, 50, null, null },
                    { 432, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7362), true, false, 48, 11, 47, 50, null, null },
                    { 433, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7362), true, false, 48, 11, 48, 50, null, null },
                    { 434, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7388), true, false, 48, 11, 50, 50, null, null },
                    { 435, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7388), true, false, 48, 11, 51, 50, null, null },
                    { 436, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7857), true, false, 49, 1, 52, 50, null, null },
                    { 437, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7857), true, false, 49, 1, 53, 50, null, null },
                    { 438, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7858), true, false, 49, 1, 54, 50, null, null },
                    { 439, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7883), true, false, 49, 8, 37, 50, null, null },
                    { 440, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7883), true, false, 49, 9, 40, 50, null, null },
                    { 441, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7884), true, false, 49, 10, 43, 50, null, null },
                    { 442, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7885), true, false, 49, 11, 46, 50, null, null },
                    { 443, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7886), true, false, 49, 11, 47, 50, null, null },
                    { 444, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7886), true, false, 49, 11, 48, 50, null, null },
                    { 445, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7887), true, false, 49, 11, 50, 50, null, null },
                    { 446, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(7887), true, false, 49, 11, 51, 50, null, null },
                    { 447, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(8397), true, false, 50, 1, 52, 50, null, null },
                    { 448, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(8398), true, false, 50, 1, 53, 50, null, null },
                    { 449, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(8398), true, false, 50, 1, 54, 50, null, null },
                    { 450, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(8399), true, false, 50, 8, 37, 50, null, null },
                    { 451, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(8400), true, false, 50, 9, 40, 50, null, null },
                    { 452, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(8400), true, false, 50, 10, 43, 50, null, null },
                    { 453, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(8402), true, false, 50, 11, 46, 50, null, null },
                    { 454, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(8402), true, false, 50, 11, 47, 50, null, null },
                    { 455, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(8403), true, false, 50, 11, 48, 50, null, null },
                    { 456, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(8403), true, false, 50, 11, 50, 50, null, null },
                    { 457, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(8404), true, false, 50, 11, 51, 50, null, null },
                    { 458, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9239), true, false, 51, 1, 52, 50, null, null },
                    { 459, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9239), true, false, 51, 1, 53, 50, null, null },
                    { 460, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9240), true, false, 51, 1, 54, 50, null, null },
                    { 461, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9241), true, false, 51, 8, 37, 50, null, null },
                    { 462, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9241), true, false, 51, 9, 40, 50, null, null },
                    { 463, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9242), true, false, 51, 10, 43, 50, null, null },
                    { 464, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9243), true, false, 51, 11, 46, 50, null, null },
                    { 465, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9244), true, false, 51, 11, 47, 50, null, null },
                    { 466, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9244), true, false, 51, 11, 48, 50, null, null },
                    { 467, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9245), true, false, 51, 11, 50, 50, null, null },
                    { 468, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9245), true, false, 51, 11, 51, 50, null, null },
                    { 469, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9922), true, false, 52, 1, 52, 50, null, null },
                    { 470, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9923), true, false, 52, 1, 53, 50, null, null },
                    { 471, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9923), true, false, 52, 1, 54, 50, null, null },
                    { 472, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9924), true, false, 52, 8, 37, 50, null, null },
                    { 473, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9924), true, false, 52, 9, 40, 50, null, null },
                    { 474, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9925), true, false, 52, 10, 43, 50, null, null },
                    { 475, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9926), true, false, 52, 11, 46, 50, null, null },
                    { 476, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9927), true, false, 52, 11, 47, 50, null, null },
                    { 477, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9927), true, false, 52, 11, 48, 50, null, null },
                    { 478, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9928), true, false, 52, 11, 50, 50, null, null },
                    { 479, null, new DateTime(2025, 9, 22, 22, 15, 6, 307, DateTimeKind.Local).AddTicks(9928), true, false, 52, 11, 51, 50, null, null },
                    { 480, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(676), true, false, 53, 1, 52, 50, null, null },
                    { 481, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(676), true, false, 53, 1, 53, 50, null, null },
                    { 482, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(677), true, false, 53, 1, 54, 50, null, null },
                    { 483, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(677), true, false, 53, 8, 37, 50, null, null },
                    { 484, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(678), true, false, 53, 9, 40, 50, null, null },
                    { 485, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(678), true, false, 53, 10, 43, 50, null, null },
                    { 486, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(680), true, false, 53, 11, 46, 50, null, null },
                    { 487, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(680), true, false, 53, 11, 47, 50, null, null },
                    { 488, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(681), true, false, 53, 11, 48, 50, null, null },
                    { 489, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(681), true, false, 53, 11, 50, 50, null, null },
                    { 490, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(682), true, false, 53, 11, 51, 50, null, null },
                    { 491, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(1256), true, false, 54, 1, 52, 50, null, null },
                    { 492, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(1257), true, false, 54, 1, 53, 50, null, null },
                    { 493, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(1257), true, false, 54, 1, 54, 50, null, null },
                    { 494, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(1258), true, false, 54, 8, 37, 50, null, null },
                    { 495, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(1258), true, false, 54, 9, 40, 50, null, null },
                    { 496, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(1259), true, false, 54, 10, 43, 50, null, null },
                    { 497, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(1260), true, false, 54, 11, 46, 50, null, null },
                    { 498, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(1261), true, false, 54, 11, 47, 50, null, null },
                    { 499, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(1261), true, false, 54, 11, 48, 50, null, null },
                    { 500, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(1262), true, false, 54, 11, 50, 50, null, null },
                    { 501, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(1262), true, false, 54, 11, 51, 50, null, null },
                    { 502, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2193), true, false, 55, 1, 52, 50, null, null },
                    { 503, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2194), true, false, 55, 1, 53, 50, null, null },
                    { 504, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2195), true, false, 55, 1, 54, 50, null, null },
                    { 505, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2196), true, false, 55, 8, 37, 50, null, null },
                    { 506, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2196), true, false, 55, 9, 40, 50, null, null },
                    { 507, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2196), true, false, 55, 10, 43, 50, null, null },
                    { 508, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2198), true, false, 55, 11, 46, 50, null, null },
                    { 509, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2198), true, false, 55, 11, 47, 50, null, null },
                    { 510, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2199), true, false, 55, 11, 48, 50, null, null },
                    { 511, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2199), true, false, 55, 11, 50, 50, null, null },
                    { 512, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2199), true, false, 55, 11, 51, 50, null, null },
                    { 513, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2798), true, false, 56, 1, 52, 50, null, null },
                    { 514, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2827), true, false, 56, 1, 53, 50, null, null },
                    { 515, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2827), true, false, 56, 1, 54, 50, null, null },
                    { 516, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2828), true, false, 56, 8, 37, 50, null, null },
                    { 517, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2828), true, false, 56, 9, 40, 50, null, null },
                    { 518, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2829), true, false, 56, 10, 43, 50, null, null },
                    { 519, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2830), true, false, 56, 11, 46, 50, null, null },
                    { 520, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2831), true, false, 56, 11, 47, 50, null, null },
                    { 521, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2831), true, false, 56, 11, 48, 50, null, null },
                    { 522, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2832), true, false, 56, 11, 50, 50, null, null },
                    { 523, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(2832), true, false, 56, 11, 51, 50, null, null },
                    { 524, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3270), true, false, 57, 1, 52, 50, null, null },
                    { 525, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3270), true, false, 57, 1, 53, 50, null, null },
                    { 526, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3271), true, false, 57, 1, 54, 50, null, null },
                    { 527, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3271), true, false, 57, 8, 37, 50, null, null },
                    { 528, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3271), true, false, 57, 9, 40, 50, null, null },
                    { 529, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3272), true, false, 57, 10, 43, 50, null, null },
                    { 530, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3273), true, false, 57, 11, 46, 50, null, null },
                    { 531, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3274), true, false, 57, 11, 47, 50, null, null },
                    { 532, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3274), true, false, 57, 11, 48, 50, null, null },
                    { 533, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3274), true, false, 57, 11, 50, 50, null, null },
                    { 534, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3275), true, false, 57, 11, 51, 50, null, null },
                    { 535, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3720), true, false, 58, 1, 52, 50, null, null },
                    { 536, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3721), true, false, 58, 1, 53, 50, null, null },
                    { 537, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3721), true, false, 58, 1, 54, 50, null, null },
                    { 538, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3722), true, false, 58, 8, 37, 50, null, null },
                    { 539, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3722), true, false, 58, 9, 40, 50, null, null },
                    { 540, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3723), true, false, 58, 10, 43, 50, null, null },
                    { 541, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3724), true, false, 58, 11, 46, 50, null, null },
                    { 542, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3724), true, false, 58, 11, 47, 50, null, null },
                    { 543, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3725), true, false, 58, 11, 48, 50, null, null },
                    { 544, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3725), true, false, 58, 11, 50, 50, null, null },
                    { 545, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(3726), true, false, 58, 11, 51, 50, null, null },
                    { 546, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4173), true, false, 59, 1, 52, 50, null, null },
                    { 547, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4173), true, false, 59, 1, 53, 50, null, null },
                    { 548, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4173), true, false, 59, 1, 54, 50, null, null },
                    { 549, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4174), true, false, 59, 8, 37, 50, null, null },
                    { 550, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4174), true, false, 59, 9, 40, 50, null, null },
                    { 551, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4175), true, false, 59, 10, 43, 50, null, null },
                    { 552, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4177), true, false, 59, 11, 46, 50, null, null },
                    { 553, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4177), true, false, 59, 11, 47, 50, null, null },
                    { 554, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4178), true, false, 59, 11, 48, 50, null, null },
                    { 555, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4178), true, false, 59, 11, 50, 50, null, null },
                    { 556, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4179), true, false, 59, 11, 51, 50, null, null },
                    { 557, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4627), true, false, 60, 1, 52, 50, null, null },
                    { 558, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4627), true, false, 60, 1, 53, 50, null, null },
                    { 559, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4628), true, false, 60, 1, 54, 50, null, null },
                    { 560, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4628), true, false, 60, 8, 37, 50, null, null },
                    { 561, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4629), true, false, 60, 9, 40, 50, null, null },
                    { 562, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4629), true, false, 60, 10, 43, 50, null, null },
                    { 563, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4658), true, false, 60, 11, 46, 50, null, null },
                    { 564, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4659), true, false, 60, 11, 47, 50, null, null },
                    { 565, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4660), true, false, 60, 11, 48, 50, null, null },
                    { 566, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4660), true, false, 60, 11, 50, 50, null, null },
                    { 567, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(4661), true, false, 60, 11, 51, 50, null, null },
                    { 568, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(5417), true, false, 61, 1, 52, 50, null, null },
                    { 569, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(5418), true, false, 61, 1, 53, 50, null, null },
                    { 570, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(5418), true, false, 61, 1, 54, 50, null, null },
                    { 571, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(5434), true, false, 61, 8, 37, 50, null, null },
                    { 572, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(5436), true, false, 61, 9, 40, 50, null, null },
                    { 573, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(5437), true, false, 61, 10, 43, 50, null, null },
                    { 574, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(5442), true, false, 61, 11, 46, 50, null, null },
                    { 575, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(5443), true, false, 61, 11, 47, 50, null, null },
                    { 576, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(5444), true, false, 61, 11, 48, 50, null, null },
                    { 577, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(5444), true, false, 61, 11, 50, 50, null, null },
                    { 578, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(5445), true, false, 61, 11, 51, 50, null, null },
                    { 579, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6326), true, false, 62, 1, 52, 50, null, null },
                    { 580, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6327), true, false, 62, 1, 53, 50, null, null },
                    { 581, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6327), true, false, 62, 1, 54, 50, null, null },
                    { 582, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6329), true, false, 62, 8, 37, 50, null, null },
                    { 583, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6331), true, false, 62, 9, 40, 50, null, null },
                    { 584, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6332), true, false, 62, 10, 43, 50, null, null },
                    { 585, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6336), true, false, 62, 11, 46, 50, null, null },
                    { 586, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6337), true, false, 62, 11, 47, 50, null, null },
                    { 587, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6338), true, false, 62, 11, 48, 50, null, null },
                    { 588, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6338), true, false, 62, 11, 50, 50, null, null },
                    { 589, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6339), true, false, 62, 11, 51, 50, null, null },
                    { 590, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6902), true, false, 63, 1, 52, 50, null, null },
                    { 591, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6903), true, false, 63, 1, 53, 50, null, null },
                    { 592, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6904), true, false, 63, 1, 54, 50, null, null },
                    { 593, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6905), true, false, 63, 8, 37, 50, null, null },
                    { 594, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6906), true, false, 63, 9, 40, 50, null, null },
                    { 595, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6907), true, false, 63, 10, 43, 50, null, null },
                    { 596, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6909), true, false, 63, 11, 46, 50, null, null },
                    { 597, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6909), true, false, 63, 11, 47, 50, null, null },
                    { 598, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6910), true, false, 63, 11, 48, 50, null, null },
                    { 599, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6910), true, false, 63, 11, 50, 50, null, null },
                    { 600, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(6911), true, false, 63, 11, 51, 50, null, null },
                    { 601, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7444), true, false, 64, 1, 52, 50, null, null },
                    { 602, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7444), true, false, 64, 1, 53, 50, null, null },
                    { 603, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7445), true, false, 64, 1, 54, 50, null, null },
                    { 604, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7445), true, false, 64, 8, 37, 50, null, null },
                    { 605, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7446), true, false, 64, 9, 40, 50, null, null },
                    { 606, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7446), true, false, 64, 10, 43, 50, null, null },
                    { 607, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7448), true, false, 64, 11, 46, 50, null, null },
                    { 608, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7448), true, false, 64, 11, 47, 50, null, null },
                    { 609, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7449), true, false, 64, 11, 48, 50, null, null },
                    { 610, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7449), true, false, 64, 11, 50, 50, null, null },
                    { 611, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7450), true, false, 64, 11, 51, 50, null, null },
                    { 612, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7973), true, false, 65, 1, 52, 50, null, null },
                    { 613, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7974), true, false, 65, 1, 53, 50, null, null },
                    { 614, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7974), true, false, 65, 1, 54, 50, null, null },
                    { 615, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7975), true, false, 65, 8, 37, 50, null, null },
                    { 616, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7975), true, false, 65, 9, 40, 50, null, null },
                    { 617, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7976), true, false, 65, 10, 43, 50, null, null },
                    { 618, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7977), true, false, 65, 11, 46, 50, null, null },
                    { 619, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7977), true, false, 65, 11, 47, 50, null, null },
                    { 620, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7978), true, false, 65, 11, 48, 50, null, null },
                    { 621, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7978), true, false, 65, 11, 50, 50, null, null },
                    { 622, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(7979), true, false, 65, 11, 51, 50, null, null },
                    { 623, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(8783), true, false, 66, 1, 52, 50, null, null },
                    { 624, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(8784), true, false, 66, 1, 53, 50, null, null },
                    { 625, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(8784), true, false, 66, 1, 54, 50, null, null },
                    { 626, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(8786), true, false, 66, 8, 37, 50, null, null },
                    { 627, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(8787), true, false, 66, 9, 40, 50, null, null },
                    { 628, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(8788), true, false, 66, 10, 43, 50, null, null },
                    { 629, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(8793), true, false, 66, 11, 46, 50, null, null },
                    { 630, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(8793), true, false, 66, 11, 47, 50, null, null },
                    { 631, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(8794), true, false, 66, 11, 48, 50, null, null },
                    { 632, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(8794), true, false, 66, 11, 50, 50, null, null },
                    { 633, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(8795), true, false, 66, 11, 51, 50, null, null },
                    { 634, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9350), true, false, 67, 1, 52, 50, null, null },
                    { 635, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9351), true, false, 67, 1, 53, 50, null, null },
                    { 636, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9351), true, false, 67, 1, 54, 50, null, null },
                    { 637, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9351), true, false, 67, 8, 37, 50, null, null },
                    { 638, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9352), true, false, 67, 9, 40, 50, null, null },
                    { 639, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9353), true, false, 67, 10, 43, 50, null, null },
                    { 640, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9355), true, false, 67, 11, 46, 50, null, null },
                    { 641, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9356), true, false, 67, 11, 47, 50, null, null },
                    { 642, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9356), true, false, 67, 11, 48, 50, null, null },
                    { 643, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9357), true, false, 67, 11, 50, 50, null, null },
                    { 644, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9357), true, false, 67, 11, 51, 50, null, null },
                    { 645, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9833), true, false, 68, 1, 52, 50, null, null },
                    { 646, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9834), true, false, 68, 1, 53, 50, null, null },
                    { 647, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9834), true, false, 68, 1, 54, 50, null, null },
                    { 648, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9835), true, false, 68, 8, 37, 50, null, null },
                    { 649, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9835), true, false, 68, 9, 40, 50, null, null },
                    { 650, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9836), true, false, 68, 10, 43, 50, null, null },
                    { 651, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9837), true, false, 68, 11, 46, 50, null, null },
                    { 652, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9838), true, false, 68, 11, 47, 50, null, null },
                    { 653, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9838), true, false, 68, 11, 48, 50, null, null },
                    { 654, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9839), true, false, 68, 11, 50, 50, null, null },
                    { 655, null, new DateTime(2025, 9, 22, 22, 15, 6, 308, DateTimeKind.Local).AddTicks(9839), true, false, 68, 11, 51, 50, null, null },
                    { 656, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(365), true, false, 69, 1, 52, 50, null, null },
                    { 657, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(365), true, false, 69, 1, 53, 50, null, null },
                    { 658, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(366), true, false, 69, 1, 54, 50, null, null },
                    { 659, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(366), true, false, 69, 8, 37, 50, null, null },
                    { 660, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(366), true, false, 69, 9, 40, 50, null, null },
                    { 661, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(367), true, false, 69, 10, 43, 50, null, null },
                    { 662, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(368), true, false, 69, 11, 46, 50, null, null },
                    { 663, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(368), true, false, 69, 11, 47, 50, null, null },
                    { 664, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(369), true, false, 69, 11, 48, 50, null, null },
                    { 665, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(369), true, false, 69, 11, 50, 50, null, null },
                    { 666, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(370), true, false, 69, 11, 51, 50, null, null },
                    { 667, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(824), true, false, 70, 1, 52, 50, null, null },
                    { 668, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(825), true, false, 70, 1, 53, 50, null, null },
                    { 669, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(825), true, false, 70, 1, 54, 50, null, null },
                    { 670, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(826), true, false, 70, 8, 37, 50, null, null },
                    { 671, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(826), true, false, 70, 9, 40, 50, null, null },
                    { 672, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(827), true, false, 70, 10, 43, 50, null, null },
                    { 673, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(828), true, false, 70, 11, 46, 50, null, null },
                    { 674, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(829), true, false, 70, 11, 47, 50, null, null },
                    { 675, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(829), true, false, 70, 11, 48, 50, null, null },
                    { 676, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(829), true, false, 70, 11, 50, 50, null, null },
                    { 677, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(830), true, false, 70, 11, 51, 50, null, null },
                    { 678, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(1668), true, false, 71, 1, 52, 50, null, null },
                    { 679, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(1669), true, false, 71, 1, 53, 50, null, null },
                    { 680, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(1670), true, false, 71, 1, 54, 50, null, null },
                    { 681, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(1671), true, false, 71, 8, 37, 50, null, null },
                    { 682, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(1673), true, false, 71, 9, 40, 50, null, null },
                    { 683, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(1674), true, false, 71, 10, 43, 50, null, null },
                    { 684, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(1678), true, false, 71, 11, 46, 50, null, null },
                    { 685, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(1679), true, false, 71, 11, 47, 50, null, null },
                    { 686, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(1679), true, false, 71, 11, 48, 50, null, null },
                    { 687, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(1680), true, false, 71, 11, 50, 50, null, null },
                    { 688, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(1680), true, false, 71, 11, 51, 50, null, null },
                    { 689, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(2644), true, false, 72, 1, 52, 50, null, null },
                    { 690, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(2645), true, false, 72, 1, 53, 50, null, null },
                    { 691, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(2646), true, false, 72, 1, 54, 50, null, null },
                    { 692, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(2647), true, false, 72, 8, 37, 50, null, null },
                    { 693, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(2648), true, false, 72, 9, 40, 50, null, null },
                    { 694, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(2649), true, false, 72, 10, 43, 50, null, null },
                    { 695, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(2652), true, false, 72, 11, 46, 50, null, null },
                    { 696, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(2653), true, false, 72, 11, 47, 50, null, null },
                    { 697, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(2653), true, false, 72, 11, 48, 50, null, null },
                    { 698, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(2676), true, false, 72, 11, 50, 50, null, null },
                    { 699, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(2677), true, false, 72, 11, 51, 50, null, null },
                    { 700, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(3405), true, false, 73, 1, 52, 50, null, null },
                    { 701, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(3406), true, false, 73, 1, 53, 50, null, null },
                    { 702, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(3406), true, false, 73, 1, 54, 50, null, null },
                    { 703, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(3407), true, false, 73, 8, 37, 50, null, null },
                    { 704, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(3409), true, false, 73, 9, 40, 50, null, null },
                    { 705, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(3453), true, false, 73, 10, 43, 50, null, null },
                    { 706, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(3456), true, false, 73, 11, 46, 50, null, null },
                    { 707, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(3457), true, false, 73, 11, 47, 50, null, null },
                    { 708, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(3457), true, false, 73, 11, 48, 50, null, null },
                    { 709, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(3458), true, false, 73, 11, 50, 50, null, null },
                    { 710, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(3458), true, false, 73, 11, 51, 50, null, null },
                    { 711, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(4249), true, false, 74, 1, 53, 50, null, null },
                    { 712, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(4253), true, false, 74, 3, 11, 50, null, null },
                    { 713, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(4976), true, false, 75, 1, 52, 50, null, null },
                    { 714, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(4978), true, false, 75, 3, 11, 50, null, null },
                    { 715, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(5556), true, false, 76, 1, 52, 50, null, null },
                    { 716, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(5557), true, false, 76, 3, 11, 50, null, null },
                    { 717, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(6058), true, false, 77, 1, 52, 50, null, null },
                    { 718, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(6059), true, false, 77, 3, 11, 50, null, null },
                    { 719, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(6505), true, false, 78, 1, 52, 50, null, null },
                    { 720, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(6505), true, false, 78, 3, 14, 50, null, null },
                    { 721, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(6930), true, false, 79, 1, 58, 50, null, null },
                    { 722, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(6932), true, false, 79, 3, 14, 50, null, null },
                    { 723, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(7586), true, false, 80, 1, 55, 50, null, null },
                    { 724, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(7586), true, false, 80, 3, 11, 50, null, null },
                    { 725, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(8362), true, false, 81, 1, 54, 50, null, null },
                    { 726, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(8364), true, false, 81, 3, 14, 50, null, null },
                    { 727, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(9167), true, false, 82, 1, 54, 50, null, null },
                    { 728, null, new DateTime(2025, 9, 22, 22, 15, 6, 309, DateTimeKind.Local).AddTicks(9169), true, false, 82, 3, 11, 50, null, null },
                    { 729, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(310), true, false, 83, 1, 52, 50, null, null },
                    { 730, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(311), true, false, 83, 3, 14, 50, null, null },
                    { 731, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(851), true, false, 84, 1, 54, 50, null, null },
                    { 732, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(852), true, false, 84, 3, 11, 50, null, null },
                    { 733, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(1299), true, false, 85, 1, 52, 50, null, null },
                    { 734, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(1300), true, false, 85, 3, 14, 50, null, null },
                    { 735, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(1762), true, false, 86, 1, 53, 50, null, null },
                    { 736, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(1783), true, false, 86, 3, 14, 50, null, null },
                    { 737, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(2189), true, false, 87, 1, 55, 50, null, null },
                    { 738, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(2190), true, false, 87, 3, 11, 50, null, null },
                    { 739, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(2627), true, false, 88, 1, 60, 50, null, null },
                    { 740, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(2628), true, false, 88, 3, 11, 50, null, null },
                    { 741, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(3252), true, false, 89, 1, 52, 50, null, null },
                    { 742, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(3254), true, false, 89, 3, 11, 50, null, null },
                    { 743, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(4156), true, false, 90, 1, 54, 50, null, null },
                    { 744, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(4159), true, false, 90, 3, 14, 50, null, null },
                    { 745, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(4954), true, false, 91, 1, 64, 50, null, null },
                    { 746, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(4956), true, false, 91, 3, 14, 50, null, null },
                    { 747, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(5795), true, false, 92, 1, 53, 50, null, null },
                    { 748, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(5796), true, false, 92, 3, 11, 50, null, null },
                    { 749, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(6458), true, false, 93, 1, 57, 50, null, null },
                    { 750, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(6460), true, false, 93, 3, 11, 50, null, null },
                    { 751, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(6977), true, false, 94, 1, 56, 50, null, null },
                    { 752, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(6978), true, false, 94, 3, 14, 50, null, null },
                    { 753, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(7544), true, false, 95, 1, 56, 50, null, null },
                    { 754, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(7545), true, false, 95, 3, 11, 50, null, null },
                    { 755, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(8282), true, false, 96, 1, 59, 50, null, null },
                    { 756, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(8283), true, false, 96, 3, 14, 50, null, null },
                    { 757, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(8779), true, false, 97, 1, 52, 50, null, null },
                    { 758, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(8779), true, false, 97, 3, 14, 50, null, null },
                    { 759, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(9222), true, false, 98, 1, 53, 50, null, null },
                    { 760, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(9222), true, false, 98, 3, 11, 50, null, null },
                    { 761, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(9743), true, false, 99, 1, 55, 50, null, null },
                    { 762, null, new DateTime(2025, 9, 22, 22, 15, 6, 310, DateTimeKind.Local).AddTicks(9743), true, false, 99, 3, 11, 50, null, null },
                    { 763, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(414), true, false, 100, 1, 52, 50, null, null },
                    { 764, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(415), true, false, 100, 3, 11, 50, null, null },
                    { 765, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(1122), true, false, 101, 1, 52, 50, null, null },
                    { 766, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(1123), true, false, 101, 3, 14, 50, null, null },
                    { 767, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(1672), true, false, 102, 1, 57, 50, null, null },
                    { 768, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(1673), true, false, 102, 3, 14, 50, null, null },
                    { 769, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(2218), true, false, 103, 1, 53, 50, null, null },
                    { 770, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(2220), true, false, 103, 3, 14, 50, null, null },
                    { 771, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(2958), true, false, 104, 1, 52, 50, null, null },
                    { 772, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(2959), true, false, 104, 3, 14, 50, null, null },
                    { 773, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(3654), true, false, 105, 1, 53, 50, null, null },
                    { 774, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(3656), true, false, 105, 3, 11, 50, null, null },
                    { 775, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(4493), true, false, 106, 1, 61, 50, null, null },
                    { 776, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(4496), true, false, 106, 3, 14, 50, null, null },
                    { 777, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(5411), true, false, 107, 1, 52, 50, null, null },
                    { 778, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(5413), true, false, 107, 3, 14, 50, null, null },
                    { 779, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(6211), true, false, 108, 1, 58, 50, null, null },
                    { 780, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(6212), true, false, 108, 3, 14, 50, null, null },
                    { 781, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(6856), true, false, 109, 1, 56, 50, null, null },
                    { 782, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(6857), true, false, 109, 3, 11, 50, null, null },
                    { 783, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(7358), true, false, 110, 1, 62, 50, null, null },
                    { 784, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(7359), true, false, 110, 3, 14, 50, null, null },
                    { 785, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(7830), true, false, 111, 1, 52, 50, null, null },
                    { 786, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(7831), true, false, 111, 3, 14, 50, null, null },
                    { 787, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(8652), true, false, 112, 1, 63, 50, null, null },
                    { 788, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(8654), true, false, 112, 3, 14, 50, null, null },
                    { 789, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(9426), true, false, 113, 1, 52, 50, null, null },
                    { 790, null, new DateTime(2025, 9, 22, 22, 15, 6, 311, DateTimeKind.Local).AddTicks(9428), true, false, 113, 3, 11, 50, null, null },
                    { 791, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(34), true, false, 114, 1, 52, 50, null, null },
                    { 792, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(35), true, false, 114, 3, 14, 50, null, null },
                    { 793, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(534), true, false, 115, 1, 52, 50, null, null },
                    { 794, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(535), true, false, 115, 3, 11, 50, null, null },
                    { 795, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(1330), true, false, 116, 1, 52, 50, null, null },
                    { 796, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(1332), true, false, 116, 3, 14, 50, null, null },
                    { 797, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(2153), true, false, 117, 1, 52, 50, null, null },
                    { 798, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(2155), true, false, 117, 3, 11, 50, null, null },
                    { 799, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(3326), true, false, 118, 1, 61, 50, null, null },
                    { 800, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(3329), true, false, 118, 3, 14, 50, null, null },
                    { 801, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(4135), true, false, 119, 1, 52, 50, null, null },
                    { 802, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(4137), true, false, 119, 3, 14, 50, null, null },
                    { 803, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(4840), true, false, 120, 1, 52, 50, null, null },
                    { 804, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(4841), true, false, 120, 3, 14, 50, null, null },
                    { 805, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(5407), true, false, 121, 1, 52, 50, null, null },
                    { 806, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(5407), true, false, 121, 3, 11, 50, null, null },
                    { 807, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(6134), true, false, 122, 1, 53, 50, null, null },
                    { 808, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(6137), true, false, 122, 3, 11, 50, null, null },
                    { 809, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(6848), true, false, 123, 1, 52, 50, null, null },
                    { 810, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(6849), true, false, 123, 3, 14, 50, null, null },
                    { 811, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(7625), true, false, 124, 1, 57, 50, null, null },
                    { 812, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(7626), true, false, 124, 3, 14, 50, null, null },
                    { 813, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(8254), true, false, 125, 1, 52, 50, null, null },
                    { 814, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(8255), true, false, 125, 3, 14, 50, null, null },
                    { 815, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(8740), true, false, 126, 1, 56, 50, null, null },
                    { 816, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(8740), true, false, 126, 3, 14, 50, null, null },
                    { 817, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(9235), true, false, 127, 1, 52, 50, null, null },
                    { 818, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(9236), true, false, 127, 3, 11, 50, null, null },
                    { 819, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(9860), true, false, 128, 1, 52, 50, null, null },
                    { 820, null, new DateTime(2025, 9, 22, 22, 15, 6, 312, DateTimeKind.Local).AddTicks(9861), true, false, 128, 3, 14, 50, null, null },
                    { 821, null, new DateTime(2025, 9, 22, 22, 15, 6, 313, DateTimeKind.Local).AddTicks(788), true, false, 129, 1, 53, 50, null, null },
                    { 822, null, new DateTime(2025, 9, 22, 22, 15, 6, 313, DateTimeKind.Local).AddTicks(793), true, false, 129, 3, 11, 50, null, null },
                    { 823, null, new DateTime(2025, 9, 22, 22, 15, 6, 313, DateTimeKind.Local).AddTicks(2001), true, false, 130, 1, 53, 50, null, null },
                    { 824, null, new DateTime(2025, 9, 22, 22, 15, 6, 313, DateTimeKind.Local).AddTicks(2871), true, false, 131, 1, 53, 50, null, null },
                    { 825, null, new DateTime(2025, 9, 22, 22, 15, 6, 313, DateTimeKind.Local).AddTicks(3896), true, false, 132, 1, 53, 50, null, null },
                    { 826, null, new DateTime(2025, 9, 22, 22, 15, 6, 313, DateTimeKind.Local).AddTicks(4775), true, false, 133, 1, 53, 50, null, null },
                    { 827, null, new DateTime(2025, 9, 22, 22, 15, 6, 313, DateTimeKind.Local).AddTicks(5555), true, false, 134, 1, 53, 50, null, null },
                    { 828, null, new DateTime(2025, 9, 22, 22, 15, 6, 313, DateTimeKind.Local).AddTicks(6145), true, false, 135, 1, 53, 50, null, null },
                    { 829, null, new DateTime(2025, 9, 22, 22, 15, 6, 313, DateTimeKind.Local).AddTicks(6626), true, false, 136, 1, 53, 50, null, null },
                    { 830, null, new DateTime(2025, 9, 22, 22, 15, 6, 313, DateTimeKind.Local).AddTicks(7218), true, false, 137, 1, 53, 50, null, null },
                    { 831, null, new DateTime(2025, 9, 22, 22, 15, 6, 313, DateTimeKind.Local).AddTicks(8029), true, false, 138, 1, 53, 50, null, null },
                    { 832, null, new DateTime(2025, 9, 22, 22, 15, 6, 313, DateTimeKind.Local).AddTicks(8738), true, false, 139, 1, 53, 50, null, null },
                    { 833, null, new DateTime(2025, 9, 22, 22, 15, 6, 313, DateTimeKind.Local).AddTicks(9325), true, false, 140, 1, 53, 50, null, null },
                    { 834, null, new DateTime(2025, 9, 22, 22, 15, 6, 314, DateTimeKind.Local).AddTicks(6249), true, false, 141, 1, 65, 50, null, null },
                    { 835, null, new DateTime(2025, 9, 22, 22, 15, 6, 314, DateTimeKind.Local).AddTicks(7217), true, false, 142, 1, 65, 50, null, null },
                    { 836, null, new DateTime(2025, 9, 22, 22, 15, 6, 314, DateTimeKind.Local).AddTicks(7997), true, false, 143, 1, 65, 50, null, null },
                    { 837, null, new DateTime(2025, 9, 22, 22, 15, 6, 314, DateTimeKind.Local).AddTicks(8451), true, false, 144, 1, 65, 50, null, null },
                    { 838, null, new DateTime(2025, 9, 22, 22, 15, 6, 314, DateTimeKind.Local).AddTicks(8900), true, false, 145, 1, 65, 50, null, null },
                    { 839, null, new DateTime(2025, 9, 22, 22, 15, 6, 314, DateTimeKind.Local).AddTicks(9567), true, false, 146, 1, 66, 50, null, null },
                    { 840, null, new DateTime(2025, 9, 22, 22, 15, 6, 315, DateTimeKind.Local).AddTicks(239), true, false, 147, 1, 66, 50, null, null },
                    { 841, null, new DateTime(2025, 9, 22, 22, 15, 6, 315, DateTimeKind.Local).AddTicks(730), true, false, 148, 1, 66, 50, null, null },
                    { 842, null, new DateTime(2025, 9, 22, 22, 15, 6, 315, DateTimeKind.Local).AddTicks(1242), true, false, 149, 1, 66, 50, null, null },
                    { 843, null, new DateTime(2025, 9, 22, 22, 15, 6, 315, DateTimeKind.Local).AddTicks(1750), true, false, 150, 1, 66, 50, null, null },
                    { 844, null, new DateTime(2025, 9, 22, 22, 15, 6, 315, DateTimeKind.Local).AddTicks(2204), true, false, 151, 1, 53, 50, null, null },
                    { 845, null, new DateTime(2025, 9, 22, 22, 15, 6, 315, DateTimeKind.Local).AddTicks(2741), true, false, 152, 1, 53, 50, null, null },
                    { 846, null, new DateTime(2025, 9, 22, 22, 15, 6, 315, DateTimeKind.Local).AddTicks(3207), true, false, 153, 1, 53, 50, null, null },
                    { 847, null, new DateTime(2025, 9, 22, 22, 15, 6, 315, DateTimeKind.Local).AddTicks(3885), true, false, 154, 1, 53, 50, null, null },
                    { 848, null, new DateTime(2025, 9, 22, 22, 15, 6, 315, DateTimeKind.Local).AddTicks(4493), true, false, 155, 1, 53, 50, null, null },
                    { 849, null, new DateTime(2025, 9, 22, 22, 15, 6, 315, DateTimeKind.Local).AddTicks(4980), true, false, 156, 1, 53, 50, null, null },
                    { 850, null, new DateTime(2025, 9, 22, 22, 15, 6, 315, DateTimeKind.Local).AddTicks(5705), true, false, 157, 1, 53, 50, null, null },
                    { 851, null, new DateTime(2025, 9, 22, 22, 15, 6, 315, DateTimeKind.Local).AddTicks(6421), true, false, 158, 1, 53, 50, null, null },
                    { 852, null, new DateTime(2025, 9, 22, 22, 15, 6, 315, DateTimeKind.Local).AddTicks(7168), true, false, 159, 1, 53, 50, null, null },
                    { 853, null, new DateTime(2025, 9, 22, 22, 15, 6, 315, DateTimeKind.Local).AddTicks(7884), true, false, 160, 1, 53, 50, null, null },
                    { 854, null, new DateTime(2025, 9, 22, 22, 15, 6, 315, DateTimeKind.Local).AddTicks(8465), true, false, 161, 1, 65, 50, null, null },
                    { 855, null, new DateTime(2025, 9, 22, 22, 15, 6, 315, DateTimeKind.Local).AddTicks(9394), true, false, 162, 1, 65, 50, null, null },
                    { 856, null, new DateTime(2025, 9, 22, 22, 15, 6, 316, DateTimeKind.Local).AddTicks(188), true, false, 163, 1, 65, 50, null, null },
                    { 857, null, new DateTime(2025, 9, 22, 22, 15, 6, 316, DateTimeKind.Local).AddTicks(960), true, false, 164, 1, 65, 50, null, null },
                    { 858, null, new DateTime(2025, 9, 22, 22, 15, 6, 316, DateTimeKind.Local).AddTicks(1511), true, false, 165, 1, 65, 50, null, null },
                    { 859, null, new DateTime(2025, 9, 22, 22, 15, 6, 316, DateTimeKind.Local).AddTicks(2180), true, false, 166, 1, 66, 50, null, null },
                    { 860, null, new DateTime(2025, 9, 22, 22, 15, 6, 316, DateTimeKind.Local).AddTicks(2988), true, false, 167, 1, 66, 50, null, null },
                    { 861, null, new DateTime(2025, 9, 22, 22, 15, 6, 316, DateTimeKind.Local).AddTicks(3646), true, false, 168, 1, 66, 50, null, null },
                    { 862, null, new DateTime(2025, 9, 22, 22, 15, 6, 316, DateTimeKind.Local).AddTicks(4156), true, false, 169, 1, 66, 50, null, null },
                    { 863, null, new DateTime(2025, 9, 22, 22, 15, 6, 316, DateTimeKind.Local).AddTicks(4642), true, false, 170, 1, 66, 50, null, null },
                    { 864, null, new DateTime(2025, 9, 22, 22, 15, 6, 316, DateTimeKind.Local).AddTicks(5111), true, false, 171, 1, 53, 50, null, null },
                    { 865, null, new DateTime(2025, 9, 22, 22, 15, 6, 316, DateTimeKind.Local).AddTicks(5681), true, false, 172, 1, 53, 50, null, null },
                    { 866, null, new DateTime(2025, 9, 22, 22, 15, 6, 316, DateTimeKind.Local).AddTicks(6149), true, false, 173, 1, 53, 50, null, null },
                    { 867, null, new DateTime(2025, 9, 22, 22, 15, 6, 316, DateTimeKind.Local).AddTicks(6671), true, false, 174, 1, 53, 50, null, null },
                    { 868, null, new DateTime(2025, 9, 22, 22, 15, 6, 316, DateTimeKind.Local).AddTicks(7196), true, false, 175, 1, 53, 50, null, null },
                    { 869, null, new DateTime(2025, 9, 22, 22, 15, 6, 316, DateTimeKind.Local).AddTicks(8088), true, false, 176, 1, 53, 50, null, null },
                    { 870, null, new DateTime(2025, 9, 22, 22, 15, 6, 316, DateTimeKind.Local).AddTicks(8921), true, false, 177, 1, 53, 50, null, null },
                    { 871, null, new DateTime(2025, 9, 22, 22, 15, 6, 316, DateTimeKind.Local).AddTicks(9862), true, false, 178, 1, 53, 50, null, null },
                    { 872, null, new DateTime(2025, 9, 22, 22, 15, 6, 317, DateTimeKind.Local).AddTicks(589), true, false, 179, 1, 53, 50, null, null },
                    { 873, null, new DateTime(2025, 9, 22, 22, 15, 6, 317, DateTimeKind.Local).AddTicks(1117), true, false, 180, 1, 53, 50, null, null },
                    { 874, null, new DateTime(2025, 9, 22, 22, 15, 6, 317, DateTimeKind.Local).AddTicks(1658), true, false, 181, 1, 65, 50, null, null },
                    { 875, null, new DateTime(2025, 9, 22, 22, 15, 6, 317, DateTimeKind.Local).AddTicks(2222), true, false, 182, 1, 65, 50, null, null },
                    { 876, null, new DateTime(2025, 9, 22, 22, 15, 6, 317, DateTimeKind.Local).AddTicks(2773), true, false, 183, 1, 65, 50, null, null },
                    { 877, null, new DateTime(2025, 9, 22, 22, 15, 6, 317, DateTimeKind.Local).AddTicks(3240), true, false, 184, 1, 65, 50, null, null },
                    { 878, null, new DateTime(2025, 9, 22, 22, 15, 6, 317, DateTimeKind.Local).AddTicks(3770), true, false, 185, 1, 65, 50, null, null },
                    { 879, null, new DateTime(2025, 9, 22, 22, 15, 6, 317, DateTimeKind.Local).AddTicks(4335), true, false, 186, 1, 66, 50, null, null },
                    { 880, null, new DateTime(2025, 9, 22, 22, 15, 6, 317, DateTimeKind.Local).AddTicks(4847), true, false, 187, 1, 66, 50, null, null },
                    { 881, null, new DateTime(2025, 9, 22, 22, 15, 6, 317, DateTimeKind.Local).AddTicks(5412), true, false, 188, 1, 66, 50, null, null },
                    { 882, null, new DateTime(2025, 9, 22, 22, 15, 6, 317, DateTimeKind.Local).AddTicks(6285), true, false, 189, 1, 66, 50, null, null },
                    { 883, null, new DateTime(2025, 9, 22, 22, 15, 6, 317, DateTimeKind.Local).AddTicks(7024), true, false, 190, 1, 66, 50, null, null },
                    { 884, null, new DateTime(2025, 9, 22, 22, 15, 6, 317, DateTimeKind.Local).AddTicks(8031), true, false, 191, 1, 65, 50, null, null },
                    { 885, null, new DateTime(2025, 9, 22, 22, 15, 6, 317, DateTimeKind.Local).AddTicks(8750), true, false, 192, 1, 65, 50, null, null },
                    { 886, null, new DateTime(2025, 9, 22, 22, 15, 6, 317, DateTimeKind.Local).AddTicks(9578), true, false, 193, 1, 65, 50, null, null },
                    { 887, null, new DateTime(2025, 9, 22, 22, 15, 6, 318, DateTimeKind.Local).AddTicks(416), true, false, 194, 1, 65, 50, null, null },
                    { 888, null, new DateTime(2025, 9, 22, 22, 15, 6, 318, DateTimeKind.Local).AddTicks(982), true, false, 195, 1, 65, 50, null, null },
                    { 889, null, new DateTime(2025, 9, 22, 22, 15, 6, 318, DateTimeKind.Local).AddTicks(1540), true, false, 196, 1, 66, 50, null, null },
                    { 890, null, new DateTime(2025, 9, 22, 22, 15, 6, 318, DateTimeKind.Local).AddTicks(2156), true, false, 197, 1, 66, 50, null, null },
                    { 891, null, new DateTime(2025, 9, 22, 22, 15, 6, 318, DateTimeKind.Local).AddTicks(2995), true, false, 198, 1, 66, 50, null, null },
                    { 892, null, new DateTime(2025, 9, 22, 22, 15, 6, 318, DateTimeKind.Local).AddTicks(3548), true, false, 199, 1, 66, 50, null, null },
                    { 893, null, new DateTime(2025, 9, 22, 22, 15, 6, 318, DateTimeKind.Local).AddTicks(4067), true, false, 200, 1, 66, 50, null, null },
                    { 894, null, new DateTime(2025, 9, 22, 22, 15, 6, 318, DateTimeKind.Local).AddTicks(4582), true, false, 192, 1, 52, 50, null, null },
                    { 895, null, new DateTime(2025, 9, 22, 22, 15, 6, 318, DateTimeKind.Local).AddTicks(5118), true, false, 193, 1, 52, 50, null, null },
                    { 896, null, new DateTime(2025, 9, 22, 22, 15, 6, 318, DateTimeKind.Local).AddTicks(5788), true, false, 194, 1, 52, 50, null, null },
                    { 897, null, new DateTime(2025, 9, 22, 22, 15, 6, 318, DateTimeKind.Local).AddTicks(6598), true, false, 195, 1, 52, 50, null, null },
                    { 898, null, new DateTime(2025, 9, 22, 22, 15, 6, 318, DateTimeKind.Local).AddTicks(7339), true, false, 196, 1, 52, 50, null, null },
                    { 899, null, new DateTime(2025, 9, 22, 22, 15, 6, 318, DateTimeKind.Local).AddTicks(7862), true, false, 197, 1, 67, 50, null, null },
                    { 900, null, new DateTime(2025, 9, 22, 22, 15, 6, 318, DateTimeKind.Local).AddTicks(8355), true, false, 198, 1, 52, 50, null, null },
                    { 901, null, new DateTime(2025, 9, 22, 22, 15, 6, 318, DateTimeKind.Local).AddTicks(8866), true, false, 199, 1, 52, 50, null, null },
                    { 902, null, new DateTime(2025, 9, 22, 22, 15, 6, 318, DateTimeKind.Local).AddTicks(9352), true, false, 200, 1, 52, 50, null, null },
                    { 903, null, new DateTime(2025, 9, 22, 22, 15, 6, 318, DateTimeKind.Local).AddTicks(9855), true, false, 201, 1, 52, 50, null, null },
                    { 904, null, new DateTime(2025, 9, 22, 22, 15, 6, 319, DateTimeKind.Local).AddTicks(330), true, false, 202, 1, 56, 50, null, null },
                    { 905, null, new DateTime(2025, 9, 22, 22, 15, 6, 319, DateTimeKind.Local).AddTicks(808), true, false, 203, 1, 52, 50, null, null },
                    { 906, null, new DateTime(2025, 9, 22, 22, 15, 6, 319, DateTimeKind.Local).AddTicks(1357), true, false, 204, 1, 52, 50, null, null },
                    { 907, null, new DateTime(2025, 9, 22, 22, 15, 6, 319, DateTimeKind.Local).AddTicks(2128), true, false, 205, 1, 52, 50, null, null },
                    { 908, null, new DateTime(2025, 9, 22, 22, 15, 6, 319, DateTimeKind.Local).AddTicks(2658), true, false, 206, 1, 72, 50, null, null },
                    { 909, null, new DateTime(2025, 9, 22, 22, 15, 6, 319, DateTimeKind.Local).AddTicks(3159), true, false, 207, 1, 52, 50, null, null },
                    { 910, null, new DateTime(2025, 9, 22, 22, 15, 6, 319, DateTimeKind.Local).AddTicks(3639), true, false, 208, 1, 56, 50, null, null },
                    { 911, null, new DateTime(2025, 9, 22, 22, 15, 6, 319, DateTimeKind.Local).AddTicks(4178), true, false, 209, 1, 73, 50, null, null }
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
