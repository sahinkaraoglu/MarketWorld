using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketWorld.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreditCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaskedCardNumber",
                table: "CreditCards",
                newName: "Cvv");

            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "CreditCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 581, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 467,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 468,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 469,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 470,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 471,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 472,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 473,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 474,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 475,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 476,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 477,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 478,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 479,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 480,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 481,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 482,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 483,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 484,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 485,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 486,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 487,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 488,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 489,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 490,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 491,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 492,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 493,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 494,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 496,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 497,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 498,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 499,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 501,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 502,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 503,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 504,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 505,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 506,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 507,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 508,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 509,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 510,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 511,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 512,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 513,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 514,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 515,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 516,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 517,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 518,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 519,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 520,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 521,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 522,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 523,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 524,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 525,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 526,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 527,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 528,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 529,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 530,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 531,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 532,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 533,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 534,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 535,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 536,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 537,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 538,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 539,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 540,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 541,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 542,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 543,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 544,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 545,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 546,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 547,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 548,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 549,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 550,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 551,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 552,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 553,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 554,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 555,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 556,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 557,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 558,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 559,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 560,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 561,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 562,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 563,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 564,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 565,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 566,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 567,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 568,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 569,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 570,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 571,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 572,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 573,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 574,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 575,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 576,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 577,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 578,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 579,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 580,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 581,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 582,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 583,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 584,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 585,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 586,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 587,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 588,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 589,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 590,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 591,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 592,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 593,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 594,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 595,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 596,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 597,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 598,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 599,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 601,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 602,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 603,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 604,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 605,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 606,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 607,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 608,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 609,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 610,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 611,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 612,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 613,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 614,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 615,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 616,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 617,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 618,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 619,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 620,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 621,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 622,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 623,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 624,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 625,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 626,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 627,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 628,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 629,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 630,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 631,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 632,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 633,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 634,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 635,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 636,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 637,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 638,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 639,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 640,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 641,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 642,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 643,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 644,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 645,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 646,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 647,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 648,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 649,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 650,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 651,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 652,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 653,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 654,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 655,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 656,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 657,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 658,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 659,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 660,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 661,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 662,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 663,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 664,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 665,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 666,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 582, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 667,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 668,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 669,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 670,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 671,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 672,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 673,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 674,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 675,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 676,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 677,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 678,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 679,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 680,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 681,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 682,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 683,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 684,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 685,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 686,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 687,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 688,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 689,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 690,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 691,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 692,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 693,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 694,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 695,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 696,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 697,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 698,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 699,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 701,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 702,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 703,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 704,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 705,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 706,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 707,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 708,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 709,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 710,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 711,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 712,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 713,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 714,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 715,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 716,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 717,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 718,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 719,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 720,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 721,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 722,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 723,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 724,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 725,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 726,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 727,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 728,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 729,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 730,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 731,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 732,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 733,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 734,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 735,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 736,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 737,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 738,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 739,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 740,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 741,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 742,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 743,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 744,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 745,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 746,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 747,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 748,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 749,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 750,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 751,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 752,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 753,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 754,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 755,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 756,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 583, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 757,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 758,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 759,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 760,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 761,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 762,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 763,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 764,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 765,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 766,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 767,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 768,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 769,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 770,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 771,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 772,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 773,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 774,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 775,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 776,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 777,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 778,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 779,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 780,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 781,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 782,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 783,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 784,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 785,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 786,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 787,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 788,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 789,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 790,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 791,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 792,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 793,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 794,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 795,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 796,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 797,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 798,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 799,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 801,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 802,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 803,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 804,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 805,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 806,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 807,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 808,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 809,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 810,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 584, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 811,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 812,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 813,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 814,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 815,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 816,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 817,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 818,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 819,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 820,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 821,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 822,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 823,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 824,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 825,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 826,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 827,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 828,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 829,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 830,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 831,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 832,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 833,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 834,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 835,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 836,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 837,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 838,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 839,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 840,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 841,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 842,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 843,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 844,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 845,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 846,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 847,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 585, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 848,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 849,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 850,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 851,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 852,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 853,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 854,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 855,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 856,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 857,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 858,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 859,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 860,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 861,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 862,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 863,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 864,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 865,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 866,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 867,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 868,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 869,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 870,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 871,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 872,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 873,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 874,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 875,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 876,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 586, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 877,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 878,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 879,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 880,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 881,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 882,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 883,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 884,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 885,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 886,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 887,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 888,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 889,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 890,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 891,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 892,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 893,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 894,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 895,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 896,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 897,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 898,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 899,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 901,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 902,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 587, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 903,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 588, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 904,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 588, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 905,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 588, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 906,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 588, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 907,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 588, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 908,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 588, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 909,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 588, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 910,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 588, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 911,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 588, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 580, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 15, 19, 8, 579, DateTimeKind.Local).AddTicks(9256));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "CreditCards");

            migrationBuilder.RenameColumn(
                name: "Cvv",
                table: "CreditCards",
                newName: "MaskedCardNumber");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 856, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 467,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 468,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 469,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 470,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 471,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 472,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 473,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 474,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 475,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 476,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 477,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 478,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 479,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 480,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 481,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 482,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 483,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 484,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 485,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 486,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 487,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 488,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 489,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 490,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 491,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 492,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 493,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 494,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 496,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 497,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 498,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 499,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 501,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 502,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 503,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 504,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 505,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 506,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 507,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 508,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 509,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 510,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 511,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 512,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 513,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 514,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 515,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 516,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 517,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 518,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 519,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 520,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 521,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 522,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 523,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 524,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 525,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 526,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 527,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 528,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 529,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 530,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 531,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 532,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 533,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 534,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 535,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 536,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 537,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 538,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 539,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 540,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 541,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 542,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 543,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 544,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 545,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 546,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 547,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 548,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 549,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 550,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 551,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 552,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 553,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 554,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 555,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 556,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 557,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 558,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 559,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 560,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 561,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 562,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 563,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 564,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 565,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 566,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 567,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 568,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 569,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 570,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 571,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 572,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 573,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 574,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 575,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 576,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 577,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 578,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 579,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 580,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 581,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 582,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 583,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 584,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 585,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 586,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 587,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 588,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 589,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 857, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 590,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 591,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 592,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 593,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 594,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 595,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 596,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 597,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 598,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 599,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 601,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 602,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 603,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 604,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 605,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 606,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 607,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 608,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 609,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 610,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 611,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 612,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 613,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 614,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 615,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 616,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 617,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 618,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 619,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 620,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 621,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 622,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 623,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 624,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 625,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 626,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 627,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 628,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 629,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 630,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 631,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 632,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 633,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 634,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 635,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 636,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 637,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 638,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 639,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 640,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 641,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 642,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 643,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 644,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 645,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 646,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 647,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 648,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 649,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 650,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 651,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 652,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 653,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 654,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 655,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 656,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 657,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 658,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 659,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 660,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 661,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 662,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 663,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 664,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 665,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 666,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 667,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 668,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 669,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 670,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 671,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 672,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 673,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 674,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 675,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 676,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 677,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 678,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 679,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 680,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 681,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 682,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 683,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 684,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 685,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 686,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 687,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 688,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 689,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 690,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 691,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 692,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 693,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 694,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 695,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 696,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 697,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 698,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 699,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 701,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 702,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 703,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 704,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 705,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 706,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 707,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 708,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 709,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 710,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 711,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 712,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 713,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 714,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 715,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 716,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 717,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 718,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 719,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 720,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 721,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 722,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 723,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 724,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 725,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 726,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 727,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 728,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 729,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 730,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 731,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 732,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 733,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 734,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 735,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 736,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 737,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 738,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 739,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 740,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 741,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 742,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 858, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 743,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 744,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 745,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 746,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 747,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 748,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 749,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 750,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 751,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 752,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 753,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 754,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 755,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 756,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 757,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 758,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 759,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 760,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 761,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 762,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 763,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 764,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 765,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 766,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 767,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 768,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 769,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 770,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 771,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 772,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 773,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 774,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 775,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 776,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 777,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 778,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 779,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 780,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 781,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 782,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 783,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 784,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 785,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 786,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 787,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 788,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 789,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 790,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 791,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 792,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 793,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 794,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 859, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 795,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 796,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 797,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 798,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 799,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 801,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 802,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 803,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 804,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 805,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 806,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 807,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 808,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 809,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 810,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 811,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 812,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 813,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 814,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 815,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 816,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 817,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 818,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 819,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 820,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 821,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 822,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 823,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 824,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 825,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 860, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 826,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 827,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 828,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 829,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 830,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 831,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 832,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 833,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 834,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 835,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 836,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 837,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 838,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 839,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 840,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 841,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 842,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 843,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 844,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 845,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 846,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 847,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 861, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 848,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 849,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 850,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 851,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 852,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 853,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 854,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 855,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 856,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 857,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 858,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 859,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 860,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 861,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 862,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 863,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 864,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 865,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 866,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 867,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 868,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 869,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 870,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 871,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 862, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 872,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 873,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 874,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 875,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 876,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 877,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 878,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 879,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 880,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 881,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 882,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 883,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 884,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 885,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 886,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 887,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 888,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 889,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 890,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 891,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 892,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 893,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 894,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 895,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 863, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 896,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 864, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 897,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 864, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 898,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 864, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 899,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 864, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 864, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 901,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 864, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 902,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 864, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 903,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 864, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 904,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 864, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 905,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 864, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 906,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 864, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 907,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 864, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 908,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 864, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 909,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 864, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 910,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 864, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 911,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 864, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 855, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 14, 51, 24, 854, DateTimeKind.Local).AddTicks(8203));
        }
    }
}
