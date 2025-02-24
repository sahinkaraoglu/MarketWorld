using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketWorld.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddHomeAndLivingSubCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "ParentId", "UpdatedDate" },
                values: new object[,]
                {
                    { 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları", "Mobilya", 3, null },
                    { 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri", "Ev Tekstili", 3, null },
                    { 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri", "Dekorasyon & Aydınlatma", 3, null },
                    { 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pişirme, servis ve saklama ürünleri, mutfak aletleri", "Mutfak Gereçleri", 3, null },
                    { 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Banyo aksesuarları, temizlik ve düzenleme ürünleri", "Banyo & Ev Gereçleri", 3, null },
                    { 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri", "Kırtasiye & Ofis", 3, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
