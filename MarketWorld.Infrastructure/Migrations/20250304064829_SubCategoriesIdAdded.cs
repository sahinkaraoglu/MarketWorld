using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketWorld.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SubCategoriesIdAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "CartItems",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 653, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "EntityId", "EntityType", "IsDeleted", "Path", "ProductId", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 4, 9, 48, 28, 655, DateTimeKind.Local).AddTicks(5260), 1, 1, false, "/images/products/iphone-14-pro.jpg", null, null, null },
                    { 2, null, new DateTime(2025, 3, 4, 9, 48, 28, 655, DateTimeKind.Local).AddTicks(5262), 2, 1, false, "/images/products/samsung-s23.jpg", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "CreatedById", "CreatedDate", "Description", "DiscountPrice", "HasDiscount", "IsActive", "IsDeleted", "Name", "Price", "Stock", "SubCategoryId", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Apple", null, null, new DateTime(2025, 3, 4, 9, 48, 28, 655, DateTimeKind.Local).AddTicks(5210), "Apple iPhone 14 Pro 256 GB Uzay Siyahı Cep Telefonu", 54999.99m, true, true, false, "iPhone 14 Pro", 56999.99m, 100, 3, null, null },
                    { 2, "Samsung", null, null, new DateTime(2025, 3, 4, 9, 48, 28, 655, DateTimeKind.Local).AddTicks(5220), "Samsung Galaxy S23 Ultra 256 GB Krem Cep Telefonu", 39999.99m, true, true, false, "Samsung Galaxy S23", 41999.99m, 150, 3, null, null }
                });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 655, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 655, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 9, 48, 28, 654, DateTimeKind.Local).AddTicks(467));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "CartItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 944, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 944, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 9, 34, 0, 942, DateTimeKind.Local).AddTicks(8358));
        }
    }
}
