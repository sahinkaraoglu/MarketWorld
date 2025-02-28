using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketWorld.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddBaseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CreatedById",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DbTableId",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedById",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecVersion",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "CreatedById",
                table: "Categories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DbTableId",
                table: "Categories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedById",
                table: "Categories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecVersion",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedById", "DbTableId", "IsDeleted", "ModifiedById", "ModifiedDate", "RecVersion" },
                values: new object[] { null, null, false, null, null, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DbTableId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "RecVersion",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DbTableId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "RecVersion",
                table: "Categories");
        }
    }
}
