using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketWorld.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate30 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "SubCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 513, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 467,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 468,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 469,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 470,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 471,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 472,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 473,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 474,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 475,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 476,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 477,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 478,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 479,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 480,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 481,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 482,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 483,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 484,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 485,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 486,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 487,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 488,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 489,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 490,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 491,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 492,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 493,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 494,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 496,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 497,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 498,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 499,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 501,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 502,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 503,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 504,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 505,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 506,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 507,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 508,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 509,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 510,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 511,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 512,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 513,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 514,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 515,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 516,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 517,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 518,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 519,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 520,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 521,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 522,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 523,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 514, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 524,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 525,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 526,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 527,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 528,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 529,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 530,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 531,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 532,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 533,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 534,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 535,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 536,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 537,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 538,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 539,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 540,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 541,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 542,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 543,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 544,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 545,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 546,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 547,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 548,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 549,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 550,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 551,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 552,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 553,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 554,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 555,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 556,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 557,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 558,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 559,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 560,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 561,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 562,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 563,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 564,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 565,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 566,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 567,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 568,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 569,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 570,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 571,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 572,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 573,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 574,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 575,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 576,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 577,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 578,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 579,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 580,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 581,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 582,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 583,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 584,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 585,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 586,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 587,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 588,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 589,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 590,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 591,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 592,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 593,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 594,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 595,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 596,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 597,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 598,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 599,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 601,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 602,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 603,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 604,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 605,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 606,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 607,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 608,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 609,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 610,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 611,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 612,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 613,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 614,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 615,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 616,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 617,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 618,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 619,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 620,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 621,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 622,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 623,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 624,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 625,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 626,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 627,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 628,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 629,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 630,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 631,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 632,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 633,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 634,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 635,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 636,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 637,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 638,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 639,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 640,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 641,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 642,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 643,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 644,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 645,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 646,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 647,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 648,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 649,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 650,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 651,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 652,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 653,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 654,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 655,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 656,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 657,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 658,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 659,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 660,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 661,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 662,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 663,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 664,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 665,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 666,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 667,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 668,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 669,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 670,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 671,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 672,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 673,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 674,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 675,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 676,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 677,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 678,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 679,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 680,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 681,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 682,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 683,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 684,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 685,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 686,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 687,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 688,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 689,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 690,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 691,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 692,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 693,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 694,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 695,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 696,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 697,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 698,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 699,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 701,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 702,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 703,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 704,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 705,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 706,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 707,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 708,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 709,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 710,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 711,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 712,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 713,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 714,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 715,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 716,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 717,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 718,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 719,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 720,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 515, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 721,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 722,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 723,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 724,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 725,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 726,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 727,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 728,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 729,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 730,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 731,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 732,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 733,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 734,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 735,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 736,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 737,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 738,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 739,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 740,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 741,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 742,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 743,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 744,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 745,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 746,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 747,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 748,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 749,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 750,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 751,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 752,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 753,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 754,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 755,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 756,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 757,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 758,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 516, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 759,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 760,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 761,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 762,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 763,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 764,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 765,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 766,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 767,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 768,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 769,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 770,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 771,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 772,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 773,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 774,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 775,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 776,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 777,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 778,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 517, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 779,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 780,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 781,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 782,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 783,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 784,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 785,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 786,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 787,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 788,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 789,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 790,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 791,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 792,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 793,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 794,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 795,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 796,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 797,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 798,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 799,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 801,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 802,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 803,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 804,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 805,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 806,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 807,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 808,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 809,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 810,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 811,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 812,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 813,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 814,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 518, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 815,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 816,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 817,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 818,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 819,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 820,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 821,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 822,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 823,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 824,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 825,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 826,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 827,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 828,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 829,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 830,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 831,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 832,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 519, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 833,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 520, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 834,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 521, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 835,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 521, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 836,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 521, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 837,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 521, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 838,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 521, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 839,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 521, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 840,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 521, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 841,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 521, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 842,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 521, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 843,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 844,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 845,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 846,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 847,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 848,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 849,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 850,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 851,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 852,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 853,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 854,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 855,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 856,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 857,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 858,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 859,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 860,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 861,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 522, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 862,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 523, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 863,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 523, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 864,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 523, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 865,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 523, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 866,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 523, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 867,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 523, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 868,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 523, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 869,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 523, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 870,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 523, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 871,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 523, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 872,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 523, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 873,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 523, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 874,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 523, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 875,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 523, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 876,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 523, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 877,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 523, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 878,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 523, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 879,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 524, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 880,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 524, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 881,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 524, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 882,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 524, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 883,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 524, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 884,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 524, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 885,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 524, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 886,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 524, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 887,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 524, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 888,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 524, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 889,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 524, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 890,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 524, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 891,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 525, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 892,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 525, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 893,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 525, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 894,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 525, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 895,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 525, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 896,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 525, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 897,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 525, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 898,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 525, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 899,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 525, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 525, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 901,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 525, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 902,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 525, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 903,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 525, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 904,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 526, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 905,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 526, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 906,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 526, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 907,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 526, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 908,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 526, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 909,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 526, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 910,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 526, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 911,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 526, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5762), 272548 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5771), 709673 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5776), 288767 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5779), 435053 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5786), 161261 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5792), 438358 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5796), 445100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5798), 191752 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5801), 449390 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5806), 228281 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5809), 110264 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5814), 512999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5817), 338739 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5820), 999559 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5825), 731140 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5828), 903510 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5830), 745737 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5835), 665998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5838), 672244 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5840), 171914 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5844), 457659 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5847), 243335 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5851), 191150 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5854), 501146 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5856), 110519 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5859), 698076 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5861), 321747 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5891), 956829 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5894), 534197 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5896), 594723 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5899), 512072 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5901), 958408 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5906), 157709 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5910), 663509 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5913), 307121 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5918), 846628 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5922), 156946 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5924), 640004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5930), 891166 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5932), 850048 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5935), 675947 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5940), 782261 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5945), 861503 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5947), 949030 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5950), 544922 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5952), 618766 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5955), 353936 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5959), 366767 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5961), 156175 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5966), 275496 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5971), 911558 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5976), 183849 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5978), 427420 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5982), 249078 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5985), 874771 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5988), 108856 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5990), 975527 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5994), 688258 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6012), 114923 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6016), 664091 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6019), 588838 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6022), 235991 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6025), 395125 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6028), 821722 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6034), 880572 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6037), 356366 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6040), 845863 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6043), 586397 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6047), 272440 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6049), 176791 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6052), 878159 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6058), 221139 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6061), 429472 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6064), 737679 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6068), 214230 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6071), 775447 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6074), 361793 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6076), 994765 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6079), 673070 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6083), 879329 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6085), 547481 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6088), 589272 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6090), 531167 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6093), 697380 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6098), 844814 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6100), 656442 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6139), 292511 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6144), 706490 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6147), 121265 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6149), 837307 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6152), 147661 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6155), 803148 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6158), 833791 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6161), 154842 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6163), 625864 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6166), 888872 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6168), 827295 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6171), 798996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6173), 591284 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6175), 131841 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6178), 638797 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6181), 510261 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6184), 517986 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6188), 455449 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6190), 891089 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6193), 954215 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6195), 645482 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6198), 637792 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6203), 770898 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6205), 772236 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6209), 340755 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6211), 965697 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6216), 418240 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6218), 675690 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6221), 622267 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6225), 411209 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6229), 434993 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6231), 120931 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6234), 776271 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6279), 788202 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6282), 505389 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6284), 775834 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6286), 207260 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6289), 240123 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6296), 979992 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6298), 730779 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6301), 425241 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6303), 515536 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6306), 601525 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6321), 738967 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6324), 753951 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6326), 762012 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6328), 795769 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6332), 330911 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6334), 601681 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6337), 341658 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6340), 670940 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6343), 888807 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6347), 293576 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6351), 688556 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6353), 465179 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6357), 209524 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6360), 261449 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6410), 784295 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6412), 749148 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6415), 509106 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6418), 884962 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6421), 879855 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6424), 505593 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6427), 587267 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6429), 124660 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6433), 489538 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6435), 815524 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6442), 725391 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6444), 879870 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6446), 356292 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6449), 382940 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6452), 524835 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6455), 503649 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6457), 250933 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6463), 996505 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6466), 544588 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6469), 207017 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6471), 608444 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6473), 905298 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6476), 225906 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6478), 453970 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6486), 342123 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6490), 107513 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6492), 532722 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6494), 496354 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6496), 107486 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6499), 164837 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6502), 517975 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6505), 659109 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6512), 639973 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6558), 789270 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6560), 789298 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6562), 481887 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6564), 956991 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6568), 823339 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6570), 458771 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6573), 657662 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6577), 528314 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6579), 732629 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6582), 108113 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6584), 129260 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6587), 416125 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6594), 196188 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6596), 932589 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6603), 446666 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6610), 965080 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6614), 785253 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6616), 424424 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6619), 693664 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6621), 469196 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6624), 359454 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6626), 399012 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6630), 931198 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6632), 861867 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6634), 940298 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6637), 340860 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6639), 466079 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6642), 122577 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6646), 934886 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6648), 578147 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6651), 346236 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6653), 996511 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(6656), 690008 });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 16, 41, 19, 512, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5406), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5408), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5410), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5411), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5412), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5413), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5415), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5418), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5419), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5467), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5468), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5470), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5471), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5472), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5474), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5475), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5476), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5477), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5479), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5480), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5481), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5484), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5485), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5486), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5487), false });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 41, 19, 511, DateTimeKind.Local).AddTicks(5489), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "SubCategories");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 790, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 791, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 467,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 468,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 469,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 470,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 471,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 472,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 473,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 474,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 475,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 476,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 477,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 478,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 479,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 480,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 481,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 482,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 483,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 484,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 485,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 486,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 487,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 488,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 489,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 490,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 491,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 492,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 493,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 494,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 496,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 497,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 498,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 499,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 501,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 502,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 503,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 504,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 505,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 506,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 507,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 508,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 509,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 510,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 511,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 512,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 792, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 513,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 514,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 515,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 516,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 517,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 518,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 519,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 520,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 521,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 522,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 523,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 524,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 525,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 526,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 527,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 528,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 529,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 530,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 531,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 532,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 533,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 534,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 535,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 536,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 537,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 538,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 539,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 540,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 541,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 542,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 543,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 544,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 545,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 546,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 547,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 548,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 549,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 550,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 551,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 552,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 553,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 554,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 555,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 556,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 557,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 558,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 559,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 560,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 561,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 562,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 563,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 564,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 565,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 566,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 567,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 568,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 569,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 570,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 571,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 572,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 573,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 574,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 575,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 576,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 577,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 578,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 579,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 580,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 581,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 582,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 583,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 584,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 585,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 586,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 587,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 588,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 589,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 590,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 591,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 592,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 593,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 594,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 595,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 596,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 597,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 598,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 599,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 601,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 602,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 603,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 604,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 605,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 606,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 607,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 608,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 609,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 610,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 611,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 612,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 613,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 614,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 615,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 616,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 617,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 618,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 619,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 620,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 621,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 622,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 623,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 624,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 625,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 626,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 627,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 628,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 629,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 630,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 631,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 632,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 633,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 634,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 635,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 636,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 637,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 638,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 639,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 640,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 641,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 642,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 643,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 644,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 645,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 646,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 647,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 648,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 649,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 650,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 651,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 652,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 653,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 654,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 655,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 656,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 657,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 658,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 659,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 660,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 661,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 662,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 663,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 664,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 665,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 666,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 667,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 668,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 669,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 670,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 671,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 672,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 673,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 674,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 675,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 676,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 677,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 678,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 679,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 680,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 681,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 682,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 683,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 684,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 685,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 686,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 687,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 688,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 793, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 689,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 690,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 691,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 692,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 693,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 694,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 695,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 696,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 697,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 698,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 699,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 701,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 702,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 703,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 704,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 705,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 706,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 707,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 708,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 709,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 710,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 711,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 712,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 713,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 714,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 715,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 716,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 717,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 718,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 719,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 720,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 721,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 722,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 723,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 724,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 725,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 726,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 727,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 728,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 729,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 730,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 731,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 732,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 733,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 734,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 735,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 736,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 737,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 738,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 739,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 740,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 741,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 742,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 794, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 743,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 744,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 745,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 746,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 747,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 748,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 749,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 750,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 751,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 752,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 753,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 754,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 755,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 756,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 757,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 758,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 759,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 760,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 761,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 762,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 763,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 764,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 765,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 766,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 767,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 768,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 769,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 770,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 771,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 772,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 795, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 773,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 774,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 775,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 776,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 777,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 778,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 779,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 780,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 781,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 782,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 783,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 784,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 785,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 786,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 787,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 788,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 789,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 790,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 791,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 792,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 793,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 794,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 795,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 796,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 797,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 798,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 799,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 801,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 802,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 803,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 804,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 796, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 805,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 806,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 807,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 808,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 809,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 810,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 811,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 812,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 813,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 814,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 815,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 816,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 817,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 818,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 819,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 820,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 821,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 822,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 823,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 824,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 825,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 826,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 827,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 828,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 829,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 830,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 831,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 832,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 833,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 797, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 834,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 798, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 835,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 798, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 836,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 798, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 837,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 798, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 838,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 798, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 839,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 798, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 840,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 841,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 842,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 843,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 844,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 845,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 846,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 847,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 848,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 849,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 850,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 851,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 852,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 853,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 854,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 855,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 856,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 857,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 858,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 859,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 860,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 799, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 861,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 862,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 863,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 864,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 865,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 866,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 867,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 868,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 869,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 870,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 871,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 872,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 873,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 874,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 875,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 876,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 877,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 878,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 879,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 880,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 800, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 881,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 882,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 883,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 884,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 885,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 886,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 887,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 888,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 889,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 890,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 891,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 892,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 893,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 894,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 895,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 896,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 897,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 898,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 899,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 801, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 901,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 802, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 902,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 802, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 903,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 802, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 904,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 802, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 905,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 802, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 906,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 802, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 907,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 802, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 908,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 802, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 909,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 802, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 910,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 802, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 911,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 802, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7284), 778420 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7288), 174958 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7292), 155802 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7294), 313630 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7297), 999766 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7324), 353143 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7326), 558648 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7332), 829160 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7334), 439971 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7341), 575255 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7345), 551697 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7352), 901426 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7354), 531583 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7361), 262865 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7364), 974902 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7370), 446368 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7373), 341069 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7382), 850376 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7386), 653406 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7389), 357838 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7392), 880514 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7395), 365207 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7399), 865050 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7404), 632067 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7406), 754214 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7408), 865720 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7411), 582084 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7413), 292664 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7420), 313299 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7423), 648971 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7428), 374584 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7430), 415247 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7433), 899772 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7483), 485420 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7486), 485120 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7489), 607923 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7499), 334041 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7504), 663699 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7509), 553608 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7512), 669696 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7517), 716702 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7519), 806718 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7521), 773005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7525), 466019 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7528), 688607 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7531), 731580 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7536), 335493 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7539), 484147 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7542), 349222 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7545), 720331 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7548), 389872 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7551), 336660 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7556), 879453 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7559), 463886 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7561), 883771 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7565), 278161 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7568), 173605 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7570), 829099 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7575), 332193 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7579), 818644 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7581), 194739 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7583), 986801 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7586), 666724 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7589), 815535 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7595), 271935 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7634), 813965 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7637), 976598 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7640), 907370 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7642), 880971 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7645), 273325 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7648), 202471 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7653), 666069 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7657), 166472 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7659), 910270 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7661), 474440 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7663), 384534 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7667), 836839 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7673), 980925 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7675), 793147 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7679), 504117 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7681), 564990 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7684), 428452 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7687), 141861 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7694), 710205 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7697), 163191 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7700), 856063 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7702), 345446 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7704), 791885 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7707), 778271 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7714), 182631 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7716), 563422 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7718), 877887 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7721), 309586 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7723), 792827 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7727), 407599 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7754), 465600 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7757), 128170 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7759), 372855 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7764), 757631 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7771), 357075 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7777), 501809 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7780), 552552 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7782), 946224 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7790), 808564 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7792), 711723 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7794), 920381 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7796), 651851 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7799), 961731 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7801), 977539 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7804), 562335 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7809), 816169 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7811), 570716 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7813), 119577 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7817), 579726 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7818), 254479 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7821), 961663 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7825), 175137 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7826), 110377 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7829), 296885 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7832), 661212 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7835), 251329 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7840), 565478 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7842), 471840 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7850), 959303 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7852), 572816 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7855), 530688 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7857), 663454 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7860), 914365 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7888), 960646 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7892), 830272 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7895), 693125 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7898), 341484 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7901), 850692 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7908), 369993 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7912), 818987 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7914), 129757 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7917), 237823 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7920), 473490 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7922), 532528 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7928), 920357 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7930), 957921 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7932), 731558 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7935), 588667 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7937), 229863 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7940), 976424 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7947), 685483 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7950), 274812 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7954), 865029 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7957), 497273 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7960), 814185 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7967), 467190 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7971), 737421 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7974), 473176 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(7998), 644132 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8001), 814692 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8005), 170910 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8008), 880387 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8010), 357543 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8013), 673446 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8015), 154884 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8018), 216424 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8020), 677896 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8024), 236705 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8027), 901408 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8030), 740940 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8032), 278675 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8035), 636484 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8037), 872062 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8044), 870940 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8046), 401998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8048), 396858 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8052), 484533 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8055), 147659 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8058), 418826 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8064), 319266 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8068), 288610 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8070), 958048 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8073), 450789 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8076), 653637 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8078), 837265 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8080), 960997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8084), 272692 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8087), 109253 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8089), 304508 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8091), 362551 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8093), 468760 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8124), 716017 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8127), 597719 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8129), 987106 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8133), 344780 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8136), 817215 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8143), 321118 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8145), 125351 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8147), 888175 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8152), 755323 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8154), 876571 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8157), 131952 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8165), 941545 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8168), 862712 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8171), 969235 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8173), 118922 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8176), 119221 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8182), 314264 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8184), 874054 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8186), 480065 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8188), 624051 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8192), 454760 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8195), 183874 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(8201), 910638 });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 789, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 2, 29, 3, 788, DateTimeKind.Local).AddTicks(6982));
        }
    }
}
