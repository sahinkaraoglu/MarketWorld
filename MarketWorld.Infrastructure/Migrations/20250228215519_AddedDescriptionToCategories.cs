using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketWorld.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedDescriptionToCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecVersion",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "RecVersion",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "RecVersion",
                table: "Categories");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 0, 55, 19, 146, DateTimeKind.Local).AddTicks(5728));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "RecVersion",
                table: "SubCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecVersion",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecVersion",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5303), 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5316), 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5317), 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5318), 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5319), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5403), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5404), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5405), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5407), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5408), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5409), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5410), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5411), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5412), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5413), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5415), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5416), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5417), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5418), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5419), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5420), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5421), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5423), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5424), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5425), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5426), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5427), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5428), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5429), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5430), 0 });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "RecVersion" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 36, 53, 340, DateTimeKind.Local).AddTicks(5431), 0 });
        }
    }
}
