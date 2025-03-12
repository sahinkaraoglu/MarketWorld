using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketWorld.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6533), "Ürün Renk Seçenekleri" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6542), "Dahili Hafıza", "Hafıza" });

            migrationBuilder.InsertData(
                table: "PropertyValues",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "PropertyTypeId", "UpdatedById", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6587), true, false, 1, null, null, "Uzay Siyahı" },
                    { 2, null, new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6590), true, false, 1, null, null, "Gümüş" },
                    { 3, null, new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6592), true, false, 1, null, null, "Altın" },
                    { 4, null, new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6594), true, false, 1, null, null, "Mor" },
                    { 5, null, new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6595), true, false, 2, null, null, "128GB" },
                    { 6, null, new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6599), true, false, 2, null, null, "256GB" },
                    { 7, null, new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6600), true, false, 2, null, null, "512GB" },
                    { 8, null, new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6602), true, false, 2, null, null, "1TB" }
                });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 9, 53, 31, 210, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.InsertData(
                table: "ProductProperties",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "IsActive", "IsDeleted", "ProductId", "PropertyTypeId", "PropertyValueId", "Stock", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6681), true, false, 1, 1, 1, 50, null, null },
                    { 2, null, new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6693), true, false, 1, 1, 2, 45, null, null },
                    { 3, null, new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6695), true, false, 1, 1, 3, 30, null, null },
                    { 4, null, new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6697), true, false, 1, 1, 4, 25, null, null },
                    { 5, null, new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6698), true, false, 1, 2, 5, 100, null, null },
                    { 6, null, new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6702), true, false, 1, 2, 6, 75, null, null },
                    { 7, null, new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6703), true, false, 1, 2, 7, 50, null, null },
                    { 8, null, new DateTime(2025, 3, 12, 9, 53, 31, 211, DateTimeKind.Local).AddTicks(6705), true, false, 1, 2, 8, 25, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2025, 3, 11, 11, 53, 19, 566, DateTimeKind.Local).AddTicks(8430), "Ürün renk seçenekleri" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2025, 3, 11, 11, 53, 19, 566, DateTimeKind.Local).AddTicks(8441), "Ürün beden seçenekleri", "Beden" });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 11, 11, 53, 19, 565, DateTimeKind.Local).AddTicks(7678));
        }
    }
}
