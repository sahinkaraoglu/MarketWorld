using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketWorld.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Addresses");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 840, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 841, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 467,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 468,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 469,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 470,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 471,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 472,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 473,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 474,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 475,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 476,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 477,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 478,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 479,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 480,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 481,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 482,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 483,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 484,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 485,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 486,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 487,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 488,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 489,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 490,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 491,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 492,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 493,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 494,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 496,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 497,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 498,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 499,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 501,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 502,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 503,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 504,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 505,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 506,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 507,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 508,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 509,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 510,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 511,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 512,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 513,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 514,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 515,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 516,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 517,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 518,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 519,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 520,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 521,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 522,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 523,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 524,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 525,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 526,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 527,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 528,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 529,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 530,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 531,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 532,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 533,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 534,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 535,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 536,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 537,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 538,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 539,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 540,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 541,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 542,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 543,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 544,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 545,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 546,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 547,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 548,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 549,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 550,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 551,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 552,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 553,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 554,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 555,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 556,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 557,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 558,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 559,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 560,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 561,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 562,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 563,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 564,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 565,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 566,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 567,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 568,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 569,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 570,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 571,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 572,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 573,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 574,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 575,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 576,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 577,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 578,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 579,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 580,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 581,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 582,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 583,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 584,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 585,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 586,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 587,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 588,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 589,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 590,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 591,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 592,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 593,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 594,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 595,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 596,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 597,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 598,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 599,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 842, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 601,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 602,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 603,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 604,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 605,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 606,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 607,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 608,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 609,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 610,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 611,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 612,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 613,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 614,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 615,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 616,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 617,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 618,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 619,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 620,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 621,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 622,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 623,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 624,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 625,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 626,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 627,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 628,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 629,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 630,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 631,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 632,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 633,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 634,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 635,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 636,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 637,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 638,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 639,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 640,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 641,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 642,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 643,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 644,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 645,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 646,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 647,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 648,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 649,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 650,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 651,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 652,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 653,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 654,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 655,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 656,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 657,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 658,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 659,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 660,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 661,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 662,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 663,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 664,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 665,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 666,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 667,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 668,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 669,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 670,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 671,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 672,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 673,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 674,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 675,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 676,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 677,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 678,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 679,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 680,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 681,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 682,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 683,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 684,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 685,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 686,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 687,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 688,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 689,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 690,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 691,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 692,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 693,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 694,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 695,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 696,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 697,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 698,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 699,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 701,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 702,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 703,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 704,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 705,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 706,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 707,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 708,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 709,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 710,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 711,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 712,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 713,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 714,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 715,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 716,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 717,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 718,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 719,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 720,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 721,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 722,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 723,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 724,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 725,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 726,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 727,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 728,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 729,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 730,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 843, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 731,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 732,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 733,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 734,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 735,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 736,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 737,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 738,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 739,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 740,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 741,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 742,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 743,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 744,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 745,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 746,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 747,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 748,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 749,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 750,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 751,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 752,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 753,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 754,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 755,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 756,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 757,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 758,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 759,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 760,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 761,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 762,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 763,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 764,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 765,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 766,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 767,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 768,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 769,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 770,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 771,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 772,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 844, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 773,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 774,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 775,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 776,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 777,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 778,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 779,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 780,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 781,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 782,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 783,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 784,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 785,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 786,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 787,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 788,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 789,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 790,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 791,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 792,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 793,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 794,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 795,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 796,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 797,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 798,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 799,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 801,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 802,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 803,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 804,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 805,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 806,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 807,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 808,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 809,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 810,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 811,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 812,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 813,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 814,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 845, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 815,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 816,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 817,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 818,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 819,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 820,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 821,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 822,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 823,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 824,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 825,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 826,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 827,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 828,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 829,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 830,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 831,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 832,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 833,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 846, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 834,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 847, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 835,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 847, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 836,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 847, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 837,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 847, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 838,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 847, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 839,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 847, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 840,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 847, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 841,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 847, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 842,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 847, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 843,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 847, DateTimeKind.Local).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 844,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 847, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 845,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 847, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 846,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 847, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 847,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 847, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 848,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 849,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 850,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 851,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 852,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 853,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 854,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 855,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 856,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 857,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 858,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 859,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 860,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 861,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 862,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 863,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 864,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 865,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 866,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 867,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 868,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 869,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 848, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 870,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 871,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 872,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 873,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 874,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 875,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 876,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 877,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 878,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 879,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 880,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 881,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 882,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 883,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 884,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 885,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 886,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 887,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 888,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 889,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 890,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 849, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 891,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 892,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 893,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 894,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 895,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 896,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 897,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 898,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 899,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 901,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 902,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 903,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 904,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 905,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 906,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 907,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 908,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 909,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 910,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 911,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 850, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9748), 580905 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9753), 955258 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9759), 377867 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9761), 546237 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9765), 555712 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9769), 627201 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9774), 544543 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9829), 892743 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9837), 119896 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9843), 847420 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9846), 931575 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9848), 187217 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9851), 525890 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9856), 998213 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9858), 270679 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9861), 638178 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9864), 791838 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9867), 283071 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9869), 862266 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9871), 161262 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9874), 148874 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9877), 760535 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9880), 195076 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9882), 545867 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9884), 959067 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9890), 604263 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9894), 552860 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9896), 475378 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9899), 617844 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9901), 476957 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9904), 683747 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9906), 910526 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9908), 712425 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9912), 687896 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9915), 584097 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9917), 448935 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9921), 158928 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9950), 921383 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9953), 585703 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9957), 449623 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9959), 317539 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9962), 549369 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9966), 170544 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9969), 893681 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9972), 420904 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9976), 986088 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9980), 115365 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9983), 879739 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9985), 734738 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9990), 744106 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9992), 296053 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9994), 485942 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9996), 246646 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(1), 144784 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3), 544996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(5), 831102 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(8), 434923 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(12), 432282 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(15), 167739 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(17), 418291 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(19), 343111 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(21), 498036 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(25), 446713 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(28), 533974 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(36), 787554 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(82), 770659 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(85), 618109 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(88), 779030 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(94), 682341 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(97), 241000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(100), 558081 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(103), 237067 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(106), 124606 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(109), 785709 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(111), 416118 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(114), 422035 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(116), 617904 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(119), 782219 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(122), 497604 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(124), 641164 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(126), 500731 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(129), 580472 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(131), 122805 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(133), 385768 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(136), 439678 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(138), 504754 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(141), 245167 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(143), 260650 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(145), 201301 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(148), 373975 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(150), 929519 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(158), 584193 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(160), 362717 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(163), 582606 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(165), 464139 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(170), 640345 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(172), 427445 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(175), 741937 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(177), 323107 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(202), 781243 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(205), 939363 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(207), 571984 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(210), 904397 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(213), 612561 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(215), 400695 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(217), 666548 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(219), 344609 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(221), 669661 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(223), 577967 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(225), 834028 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(227), 789377 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(230), 855658 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(234), 764641 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(239), 222405 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(241), 419597 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(244), 384396 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(248), 245859 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(250), 681101 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(252), 683527 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(255), 867956 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(258), 552899 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(260), 159471 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(263), 807951 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(265), 879972 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(267), 485216 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(270), 571618 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(272), 198195 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(274), 953507 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(278), 265933 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(330), 535492 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(333), 114286 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(335), 533142 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(337), 762364 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(341), 499430 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(345), 908675 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(347), 571343 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(352), 397500 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(354), 193947 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(357), 375788 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(359), 600033 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(361), 351072 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(364), 800982 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(366), 830170 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(372), 901053 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(376), 162490 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(379), 486688 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(383), 589428 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(385), 748207 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(387), 600823 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(390), 615867 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(394), 174784 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(396), 815947 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(398), 503019 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(401), 943022 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(408), 900311 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(411), 437045 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(436), 184289 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(439), 313106 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(442), 695036 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(445), 763092 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(448), 187733 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(451), 481764 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(455), 952384 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(458), 458493 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(462), 806430 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(465), 883127 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(467), 792822 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(470), 213000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(478), 839401 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(481), 666520 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(483), 136832 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(485), 469589 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(488), 518517 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(490), 913184 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(493), 115219 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(495), 654378 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(501), 215836 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(504), 337407 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(507), 272477 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(512), 763490 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(514), 989014 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(517), 889071 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(520), 482935 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(522), 909148 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(525), 790601 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(528), 354452 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(531), 621056 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(535), 189161 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(537), 849890 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(556), 276309 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(559), 861669 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(562), 264930 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(564), 119059 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(567), 826053 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(570), 249337 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(573), 655063 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(576), 471697 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(579), 935788 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(582), 798704 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(586), 410368 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(590), 351192 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(593), 661824 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(595), 530010 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(598), 603998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(600), 630573 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(603), 392338 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(606), 154234 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(609), 346917 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(611), 654145 });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 839, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 20, 27, 0, 838, DateTimeKind.Local).AddTicks(9493));
        }
    }
}
