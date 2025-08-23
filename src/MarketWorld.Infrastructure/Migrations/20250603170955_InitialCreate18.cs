using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketWorld.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 629, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 629, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 629, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 629, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 629, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 631, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 632, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 467,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 468,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 469,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 470,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 471,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 472,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 473,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 474,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 475,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 476,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 477,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 478,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 479,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 480,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 481,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 482,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 483,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 484,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 485,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 486,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 487,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 488,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 489,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 490,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 633, DateTimeKind.Local).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 491,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 492,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 493,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 494,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 496,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 497,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 498,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 499,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 501,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 502,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 503,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 504,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 505,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 506,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 507,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 508,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 509,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 510,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 511,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 512,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 513,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 514,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 515,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 516,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 517,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 518,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 519,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 520,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 521,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 522,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 523,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 524,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 525,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 526,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 527,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 528,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 529,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 530,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 531,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 532,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 533,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 534,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 535,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 536,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 537,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 538,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 539,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 540,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 541,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 542,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 543,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 544,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 545,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 546,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 547,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 548,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 549,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 550,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 551,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 552,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 553,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 554,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 555,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 556,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 557,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 558,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 559,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 560,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 561,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 562,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 563,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 564,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 565,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 566,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 567,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 568,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 569,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 570,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 571,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 572,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 573,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 574,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 575,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 576,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 577,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 578,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 579,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 580,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 581,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 582,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 583,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 584,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 585,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 586,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 587,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 588,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 589,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 590,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 591,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 592,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 593,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 594,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 595,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 596,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 597,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 598,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 599,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 601,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 602,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 603,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 604,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 605,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 606,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 607,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 608,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 609,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 610,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 611,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 612,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 613,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 614,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 615,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 616,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 617,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 618,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 619,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 620,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 621,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 622,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 623,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 624,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 625,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 626,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 627,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 628,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 629,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 630,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 631,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 632,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 633,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 634,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 635,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 636,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 637,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 638,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 639,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 640,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 641,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 642,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 643,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 644,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 645,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 646,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 647,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 648,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 649,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 650,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 651,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 652,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 653,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 654,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 655,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 656,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 657,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 658,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 659,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 660,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 661,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 662,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 663,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 664,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 665,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 666,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 667,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 668,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 669,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 670,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 671,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 672,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 673,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 674,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 675,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 676,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 677,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 634, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 678,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 679,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 680,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 681,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 682,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 683,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 684,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 685,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 686,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 687,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 688,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 689,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 690,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 691,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 692,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 693,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 694,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 695,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 696,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 697,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 698,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 699,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 701,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 702,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 703,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 704,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 705,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 706,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 707,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 708,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 709,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 710,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 711,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 712,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 713,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 714,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 715,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 716,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 717,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 718,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 719,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 720,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 721,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 722,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 723,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 724,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 725,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 726,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 727,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 728,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 729,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 730,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 731,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 732,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 733,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 734,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 735,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 736,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 737,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 738,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 739,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 740,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 741,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 742,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 635, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 743,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 744,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 745,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 746,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 747,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 748,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 749,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 750,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 751,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 752,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 753,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 754,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 755,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 756,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 757,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 758,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 759,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 760,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 761,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 762,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 763,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 764,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 765,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 766,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 767,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 768,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 769,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 770,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 771,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 772,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 773,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 774,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 775,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 776,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 777,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 778,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 779,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 780,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 781,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 782,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 783,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 784,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 636, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 785,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 786,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 787,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 788,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 789,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 790,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 791,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 792,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 793,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 794,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 795,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 796,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 797,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 798,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 799,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 801,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 802,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 803,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 804,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 805,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 806,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 807,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 808,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 809,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 810,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 811,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 812,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 813,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 814,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 815,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 816,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 817,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 818,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 819,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 820,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 821,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 822,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 823,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 637, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 824,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 638, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 825,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 638, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 826,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 638, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 827,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 638, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 828,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 638, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 829,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 638, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 830,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 638, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 831,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 638, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 832,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 638, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 833,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 638, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 834,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 835,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 836,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 837,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 838,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 839,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 840,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 841,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 842,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 843,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 844,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 845,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 846,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 847,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 848,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 849,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 850,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 851,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 852,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 639, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 853,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 854,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 855,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 856,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 857,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 858,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 859,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 860,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 861,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 862,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 863,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 864,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 865,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 866,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 867,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 868,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 869,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 870,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 871,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 872,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 873,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 874,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 640, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 875,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 876,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 877,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 878,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 879,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 880,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 881,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 882,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 883,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 884,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 885,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 886,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 887,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 888,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 889,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 890,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 891,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 892,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 893,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 894,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 641, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 895,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 642, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 896,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 642, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 897,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 642, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 898,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 642, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 899,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 642, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 642, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 901,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 642, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 902,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 642, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 903,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 642, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 904,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 642, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 905,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 642, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 906,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 642, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 907,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 642, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 908,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 642, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 909,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 642, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 910,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 642, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 911,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 642, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(669), 655684 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(678), 141888 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(690), 874043 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(693), 793996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(696), 864410 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(765), 989319 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(768), 651209 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(771), 501458 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(774), 150413 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(778), 270572 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(784), 543225 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(788), 603239 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(790), 665391 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(795), 940746 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(798), 836876 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(805), 807473 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(807), 891387 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(813), 253989 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(824), 489103 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(826), 706515 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(830), 776901 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(833), 262774 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(836), 803166 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(844), 482179 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(847), 107634 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(851), 860800 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(854), 528450 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(857), 140097 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(862), 508330 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(866), 549496 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(870), 922446 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(874), 902310 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(877), 344257 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(884), 780260 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(913), 370363 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(917), 110252 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(921), 175943 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(925), 320783 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(928), 441046 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(931), 456519 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(942), 485455 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(945), 458574 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(948), 642291 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(952), 459683 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(960), 960486 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(966), 939696 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(969), 763739 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(973), 728795 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(980), 890235 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(984), 743335 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(987), 508685 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(990), 239502 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(994), 674059 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1001), 449594 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1004), 628367 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1007), 934971 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1010), 490038 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1013), 535399 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1019), 190637 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1023), 801501 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1027), 319605 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1030), 164897 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1033), 551743 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1041), 421536 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1049), 953619 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1087), 939350 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1098), 507769 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1101), 889886 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1106), 268213 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1109), 259109 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1111), 383168 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1118), 967969 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1121), 513741 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1124), 807397 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1130), 869594 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1139), 608668 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1143), 419480 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1146), 397052 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1150), 592457 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1157), 483203 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1159), 627386 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1163), 825237 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1166), 606945 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1170), 293718 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1172), 989313 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1176), 254764 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1179), 172393 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1181), 514229 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1184), 303027 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1189), 873776 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1195), 911667 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1198), 769671 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1201), 277499 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1204), 393135 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1206), 181637 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1209), 854341 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1247), 786274 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1253), 309935 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1257), 508773 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1260), 136544 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1263), 823568 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1328), 536784 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1333), 620362 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1336), 547067 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1341), 877916 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1344), 663430 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1350), 959621 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1353), 638051 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1356), 298037 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1359), 125989 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1364), 235479 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1371), 686413 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1375), 563105 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1378), 594019 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1380), 492677 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1383), 623126 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1390), 662262 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1394), 225153 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1397), 814280 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1399), 379222 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1402), 827183 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1413), 832287 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1416), 298173 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1423), 843530 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1430), 211103 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1433), 896526 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1435), 297331 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1438), 663210 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1440), 715962 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1499), 187350 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1502), 361920 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1510), 471569 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1514), 152046 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1517), 194153 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1520), 147981 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1526), 423272 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1530), 821737 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1533), 980606 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1536), 394205 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1539), 824974 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1547), 441451 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1550), 702778 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1553), 930679 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1556), 453740 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1558), 312163 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1561), 206899 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1567), 793793 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1569), 543380 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1572), 325454 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1576), 181000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1580), 932432 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1587), 840335 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1590), 591063 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1639), 343470 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1647), 545967 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1652), 601752 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1655), 190093 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1663), 736269 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1666), 356845 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1672), 912408 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1675), 757130 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1678), 953905 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1680), 332501 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1685), 113674 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1690), 621274 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1693), 418041 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1697), 644563 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1704), 195366 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1707), 528084 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1710), 553120 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1713), 830899 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1716), 731303 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1718), 363424 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1722), 727901 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1728), 892077 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1731), 665907 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1734), 935903 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1737), 350843 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1781), 648981 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1786), 697553 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1788), 222718 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1792), 713256 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1795), 717365 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1801), 582906 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1804), 553035 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1807), 334556 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1918), 862080 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1922), 187981 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1925), 264273 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1929), 734681 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1932), 126531 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1937), 615736 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1940), 523292 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1949), 663772 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1957), 962614 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1960), 833798 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1964), 426095 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1969), 523070 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1976), 145433 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1980), 247105 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1983), 998519 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1986), 314550 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1990), 570237 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(1999), 607293 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2002), 429604 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2005), 138697 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2009), 274836 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2017), 900929 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(2020), 682993 });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 20, 9, 54, 630, DateTimeKind.Local).AddTicks(252));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Addresses");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 168, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 169, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 467,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 468,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 469,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 470,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 471,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 472,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 473,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 474,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 475,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 476,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 477,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 478,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 479,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 480,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 481,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 482,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 483,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 484,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 485,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 486,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 487,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 488,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 489,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 490,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 491,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 492,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 493,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 494,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 496,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 497,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 498,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 499,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 501,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 502,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 503,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 504,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 505,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 506,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 507,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 508,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 509,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 510,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 511,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 512,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 513,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 514,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 515,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 516,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 517,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 518,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 519,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 520,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 521,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 522,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 523,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 524,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 525,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 526,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 527,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 528,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 529,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 530,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 531,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 532,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 533,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 534,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 535,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 536,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 537,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 538,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 539,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 540,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 541,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 542,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 543,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 544,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 545,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 546,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 547,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 548,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 549,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 550,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 551,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 552,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 553,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 554,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 555,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 556,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 170, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 557,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 558,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 559,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 560,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 561,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 562,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 563,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 564,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 565,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 566,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 567,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 568,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 569,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 570,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 571,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 572,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 573,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 574,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 575,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 576,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 577,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 578,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 579,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 580,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 581,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 582,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 583,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 584,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 585,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 586,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 587,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 588,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 589,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 590,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 591,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 592,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 593,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 594,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 595,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 596,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 597,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 598,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 599,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 601,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 602,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 603,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 604,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 605,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 606,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 607,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 608,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 609,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 610,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 611,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 612,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 613,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 614,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 615,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 616,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 617,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 618,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 619,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 620,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 621,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 622,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 623,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 624,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 625,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 626,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 627,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 628,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 629,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 630,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 631,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 632,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 633,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 634,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 635,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 636,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 637,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 638,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 639,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 640,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 641,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 642,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 643,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 644,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 645,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 646,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 647,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 648,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 649,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 650,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 651,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 652,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 653,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 654,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 655,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 656,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 657,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 658,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 659,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 660,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 661,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 662,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 663,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 664,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 665,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 666,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 667,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 668,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 669,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 670,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 671,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 672,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 673,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 674,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 675,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 676,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 677,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 678,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 679,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 680,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 681,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 682,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 683,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 684,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 685,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 686,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 687,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 688,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 689,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 690,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 691,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 692,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 693,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 694,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 695,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 696,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 697,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 698,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 699,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 701,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 702,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 703,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 704,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 705,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 706,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 707,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 708,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 709,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 710,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 711,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 712,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 713,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 714,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 715,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 716,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 717,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 718,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 719,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 720,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 721,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 722,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 723,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 724,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 171, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 725,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 726,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 727,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 728,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 729,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 730,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 731,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 732,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 733,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 734,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 735,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 736,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 737,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 738,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 739,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 740,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 741,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 742,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 743,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 744,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 745,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 746,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 747,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 748,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 749,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 750,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 751,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 752,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 753,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 754,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 755,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 756,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 757,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 758,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 759,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 760,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 761,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 762,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 763,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 764,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 765,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 766,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 767,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 768,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 172, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 769,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 770,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 771,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 772,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 773,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 774,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 775,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 776,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 777,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 778,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 779,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 780,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 781,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 782,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 783,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 784,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 785,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 786,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 787,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 788,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 789,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 790,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 791,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 792,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 793,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 794,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 795,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 796,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 797,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 798,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 799,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 801,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 802,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 803,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 804,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 173, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 805,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 806,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 807,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 808,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 809,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 810,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 811,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 812,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 813,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 814,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 815,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 816,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 817,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 818,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 819,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 820,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 821,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 822,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 823,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 824,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 825,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 826,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 827,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 174, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 828,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 175, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 829,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 175, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 830,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 175, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 831,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 175, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 832,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 175, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 833,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 175, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 834,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 175, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 835,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 836,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 837,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 838,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 839,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 840,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 841,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 842,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 843,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 844,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 845,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 846,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 847,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 848,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 849,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 850,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 851,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 852,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 853,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 176, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 854,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 855,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 856,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 857,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 858,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 859,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 860,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 861,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 862,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 863,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 864,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 865,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 866,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 867,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 868,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 869,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 870,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 871,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 872,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 873,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 177, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 874,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 875,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 876,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 877,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 878,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 879,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 880,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 881,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 882,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 883,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 884,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 885,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 886,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 887,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 888,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 889,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 890,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 891,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 892,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 178, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 893,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 894,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 895,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 896,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 897,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 898,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 899,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 901,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 902,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 903,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 904,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 905,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 906,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 907,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 908,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 909,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 910,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 911,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 179, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3319), 529623 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3325), 832851 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3331), 398256 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3338), 785063 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3340), 114217 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3344), 196661 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3351), 147604 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3353), 349477 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3356), 557482 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3360), 274728 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3370), 409004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3372), 895830 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3375), 790966 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3378), 393698 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3414), 531783 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3417), 487771 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3420), 691765 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3424), 314044 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3429), 867801 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3431), 583115 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3433), 778883 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3436), 559140 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3439), 770833 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3441), 805517 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3447), 386328 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3450), 362130 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3452), 651189 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3455), 566523 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3459), 208675 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3462), 570357 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3467), 691767 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3471), 111704 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3476), 293690 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3480), 599198 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3488), 628255 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3490), 993520 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3494), 888815 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3497), 626890 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3501), 853783 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3507), 652549 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3509), 261347 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3513), 436430 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3516), 583335 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3518), 159977 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3551), 792201 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3554), 136489 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3557), 266101 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3560), 445654 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3565), 622693 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3569), 908460 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3572), 161043 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3576), 372264 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3579), 996880 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3588), 455613 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3592), 124714 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3595), 443970 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3597), 236233 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3604), 303575 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3607), 392803 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3610), 561011 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3615), 464792 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3619), 883874 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3625), 194068 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3629), 164374 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3633), 340387 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3637), 643926 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3639), 287902 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3644), 211706 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3646), 255328 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3650), 112230 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3653), 522549 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3656), 161373 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3689), 785577 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3692), 832490 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3694), 689420 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3697), 589522 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3702), 185970 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3705), 960879 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3707), 248369 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3710), 360639 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3712), 644212 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3714), 178279 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3717), 186693 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3723), 208828 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3726), 838256 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3731), 510588 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3733), 384297 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3736), 824445 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3741), 164141 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3744), 418458 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3747), 868044 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3749), 604865 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3752), 932293 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3756), 815391 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3763), 534402 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3765), 823113 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3768), 231215 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3771), 969860 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3775), 881377 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3781), 418461 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3784), 528719 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3787), 553200 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3789), 531688 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3792), 878318 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3794), 264654 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3799), 979410 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3849), 848601 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3852), 902347 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3858), 316876 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3861), 719868 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3864), 687187 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3866), 834473 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3870), 763781 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3873), 954039 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3879), 707403 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3881), 945273 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3883), 985083 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3885), 105293 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3890), 684747 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3892), 796723 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3898), 852328 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3902), 783885 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3905), 518132 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3907), 324520 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3910), 915426 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3917), 284192 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3919), 220051 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3921), 895278 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3923), 879296 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3929), 938089 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3983), 714620 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3987), 278098 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3989), 690302 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3998), 923541 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4001), 679749 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4005), 500685 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4008), 782899 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4015), 601969 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4017), 208669 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4020), 592279 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4023), 731883 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4025), 679649 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4029), 562754 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4038), 940053 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4043), 760640 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4045), 352293 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4048), 396014 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4056), 955567 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4059), 279173 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4063), 964184 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4065), 651501 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4068), 472272 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4074), 866902 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4077), 560234 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4080), 363076 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4083), 886376 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4086), 289411 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4093), 161584 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4096), 868295 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4099), 632986 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4102), 829754 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4104), 814807 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4107), 679997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4137), 470517 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4141), 762211 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4145), 274032 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4151), 968725 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4154), 556316 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4157), 202286 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4160), 261021 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4164), 796191 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4167), 373353 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4171), 556706 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4175), 867247 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4178), 753513 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4181), 311480 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4186), 231166 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4191), 173704 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4194), 285902 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4198), 772868 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4201), 575339 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4204), 855370 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4207), 681926 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4210), 241873 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4213), 492931 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4215), 375326 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4218), 134269 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4222), 951379 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4225), 440853 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4229), 157149 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4233), 850906 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4235), 588863 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4238), 322202 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4242), 336882 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4250), 995285 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4253), 677977 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4300), 933400 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4302), 919998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4309), 425276 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4312), 496724 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4315), 269231 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4318), 287679 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4321), 268806 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4328), 527530 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4331), 860361 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4335), 143398 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4338), 927533 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4340), 792248 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(4343), 277121 });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 19, 59, 57, 167, DateTimeKind.Local).AddTicks(3039));
        }
    }
}
