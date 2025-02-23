using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketWorld.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddElectronicsSubCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "ParentId", "UpdatedDate" },
                values: new object[,]
                {
                    { 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dizüstü, masaüstü bilgisayarlar ve tabletler", "Bilgisayarlar & Tabletler", 1, null },
                    { 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yazıcılar, tarayıcılar ve projeksiyon cihazları", "Yazıcılar & Projeksiyon", 1, null },
                    { 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akıllı telefonlar ve aksesuarları", "Telefonlar", 1, null },
                    { 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar", "Beyaz Eşya", 1, null },
                    { 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Klimalar, ısıtıcılar ve hava temizleyiciler", "Klima ve Isıtıcılar", 1, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
