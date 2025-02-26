using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketWorld.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class HomePc : Migration
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "ParentId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elektronik ürünler, bilgisayarlar, telefonlar ve diğer teknolojik cihazlar", "Elektronik", null, null },
                    { 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Erkek, kadın ve çocuk giyim ürünleri ve aksesuarları", "Giyim & Aksesuar", null, null },
                    { 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ev dekorasyon, mobilya, mutfak eşyaları ve ev tekstili", "Ev & Yaşam", null, null },
                    { 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kozmetik ürünleri, parfümler ve kişisel bakım ürünleri", "Kozmetik & Kişisel Bakım", null, null },
                    { 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spor ekipmanları, spor giyim ve outdoor aktivite ürünleri", "Spor & Outdoor", null, null },
                    { 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dizüstü, masaüstü bilgisayarlar ve tabletler", "Bilgisayarlar & Tabletler", 1, null },
                    { 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yazıcılar, tarayıcılar ve projeksiyon cihazları", "Yazıcılar & Projeksiyon", 1, null },
                    { 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akıllı telefonlar ve aksesuarları", "Telefonlar", 1, null },
                    { 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buzdolabı, çamaşır makinesi ve diğer beyaz eşyalar", "Beyaz Eşya", 1, null },
                    { 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Klimalar, ısıtıcılar ve hava temizleyiciler", "Klima ve Isıtıcılar", 1, null },
                    { 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kadın, erkek ve çocuk ayakkabıları, çantalar ve aksesuarlar", "Ayakkabı & Çanta", 2, null },
                    { 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kadın giyim ürünleri, elbiseler, üst giyim ve alt giyim", "Kadın Giyim", 2, null },
                    { 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Erkek giyim ürünleri, takım elbiseler, üst giyim ve alt giyim", "Erkek Giyim", 2, null },
                    { 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kız ve erkek çocuk giyim ürünleri", "Çocuk Giyim", 2, null },
                    { 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oturma grupları, yatak odası, yemek odası ve ofis mobilyaları", "Mobilya", 3, null },
                    { 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nevresim takımları, perdeler, halılar ve dekoratif tekstil ürünleri", "Ev Tekstili", 3, null },
                    { 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ev dekorasyon ürünleri, tablolar, aynalar ve aydınlatma sistemleri", "Dekorasyon & Aydınlatma", 3, null },
                    { 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pişirme, servis ve saklama ürünleri, mutfak aletleri", "Mutfak Gereçleri", 3, null },
                    { 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Banyo aksesuarları, temizlik ve düzenleme ürünleri", "Banyo & Ev Gereçleri", 3, null },
                    { 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kırtasiye malzemeleri, ofis gereçleri ve okul ürünleri", "Kırtasiye & Ofis", 3, null },
                    { 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kadın ve erkek parfümleri, deodorantlar ve vücut spreyleri", "Parfüm & Deodarant", 4, null },
                    { 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saç bakım ve şekillendirme ürünleri", "Saç Şekillendirme", 4, null },
                    { 23, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yüz ve vücut bakım ürünleri, kremler ve serumlar", "Cilt Bakımı", 4, null },
                    { 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Renkli kozmetik ve makyaj malzemeleri", "Makyaj", 4, null },
                    { 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitamin, takviye gıdalar ve medikal ürünler", "Sağlık & Medikal Ürünler", 4, null },
                    { 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diş bakım ürünleri ve ağız bakım ürünleri", "Ağız & Diş Bakımı", 4, null },
                    { 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fitness ekipmanları, kondisyon aletleri ve aksesuarları", "Fitness & Kondisyon", 5, null },
                    { 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spor giyim ürünleri, spor ayakkabılar ve aksesuarlar", "Spor Giyim & Ayakkabı", 5, null },
                    { 29, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kamp malzemeleri, outdoor giyim ve ekipmanlar", "Outdoor & Kamp", 5, null },
                    { 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kayak ekipmanları ve kış sporları malzemeleri", "Kış Sporları", 5, null },
                    { 31, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yüzme ve su sporları ekipmanları", "Su Sporları", 5, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
