using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketWorld.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSubCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedDate", "DbTableId", "Description", "IsDeleted", "Name", "RecVersion", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 6L, 2L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9181), null, "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar", false, "Ayakkabı & Çanta", 0, null, null },
                    { 7L, 2L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9182), null, "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim", false, "Kadın Giyim", 0, null, null },
                    { 8L, 2L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9183), null, "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim", false, "Erkek Giyim", 0, null, null },
                    { 9L, 2L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9184), null, "Kız ve erkek çocuk giyim ürünleri", false, "Çocuk Giyim", 0, null, null },
                    { 10L, 3L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9186), null, "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları", false, "Mobilya", 0, null, null },
                    { 11L, 3L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9187), null, "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri", false, "Ev Tekstili", 0, null, null },
                    { 12L, 3L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9188), null, "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri", false, "Dekorasyon & Aydınlatma", 0, null, null },
                    { 13L, 3L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9189), null, "Pişirme, servis ve saklama ürünleri, mutfak aletleri", false, "Mutfak Gereçleri", 0, null, null },
                    { 14L, 3L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9191), null, "Banyo aksesuarları, temizlik ve düzenleme ürünleri", false, "Banyo & Ev Gereçleri", 0, null, null },
                    { 15L, 3L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9193), null, "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri", false, "Kırtasiye & Ofis", 0, null, null },
                    { 16L, 4L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9194), null, "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri", false, "Parfüm & Deodorant", 0, null, null },
                    { 17L, 4L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9196), null, "Saç bakım ve şekillendirme ürünleri", false, "Saç Şekillendirme", 0, null, null },
                    { 18L, 4L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9197), null, "Yüz ve vücut bakım ürünleri, kremler ve serumlar", false, "Cilt Bakımı", 0, null, null },
                    { 19L, 4L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9198), null, "Renkli kozmetik ve makyaj malzemeleri", false, "Makyaj", 0, null, null },
                    { 20L, 4L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9199), null, "Vitamin, takviye gıdalar ve medikal ürünler", false, "Sağlık & Medikal Ürünler", 0, null, null },
                    { 21L, 4L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9200), null, "Diş bakım ürünleri ve ağız bakım ürünleri", false, "Ağız & Diş Bakımı", 0, null, null },
                    { 22L, 5L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9202), null, "Fitness ekipmanları, kondisyon aletleri ve aksesuarları", false, "Fitness & Kondisyon", 0, null, null },
                    { 23L, 5L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9203), null, "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar", false, "Spor Giyim & Ayakkabı", 0, null, null },
                    { 24L, 5L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9204), null, "Kamp malzemeleri, outdoor giyim ve ekipmanlar", false, "Outdoor & Kamp", 0, null, null },
                    { 25L, 5L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9205), null, "Kayak ekipmanları ve kış sporları malzemeleri", false, "Kış Sporları", 0, null, null },
                    { 26L, 5L, null, new DateTime(2025, 2, 28, 22, 12, 23, 464, DateTimeKind.Local).AddTicks(9207), null, "Yüzme ve su sporları ekipmanları", false, "Su Sporları", 0, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 9, 0, 599, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 9, 0, 599, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 9, 0, 599, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 9, 0, 599, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 9, 0, 599, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 9, 0, 599, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 9, 0, 599, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 9, 0, 599, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 9, 0, 599, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 22, 9, 0, 599, DateTimeKind.Local).AddTicks(8793));
        }
    }
}
