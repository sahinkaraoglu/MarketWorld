using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketWorld.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCategorySeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "DbTableId", "Description", "IsDeleted", "Name", "RecVersion", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2025, 2, 28, 21, 4, 15, 72, DateTimeKind.Local).AddTicks(8222), null, "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar", false, "Elektronik", 0, null, null },
                    { 2L, null, new DateTime(2025, 2, 28, 21, 4, 15, 72, DateTimeKind.Local).AddTicks(8240), null, "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları", false, "Giyim & Aksesuar", 0, null, null },
                    { 3L, null, new DateTime(2025, 2, 28, 21, 4, 15, 72, DateTimeKind.Local).AddTicks(8241), null, "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili", false, "Ev & Yaşam", 0, null, null },
                    { 4L, null, new DateTime(2025, 2, 28, 21, 4, 15, 72, DateTimeKind.Local).AddTicks(8243), null, "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri", false, "Kozmetik & Kişisel Bakım", 0, null, null },
                    { 5L, null, new DateTime(2025, 2, 28, 21, 4, 15, 72, DateTimeKind.Local).AddTicks(8269), null, "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri", false, "Spor & Outdoor", 0, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L);
        }
    }
}
