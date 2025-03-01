using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketWorld.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewEntityChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DbTableId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DbTableId",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "DbTableId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DbTableId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "DbTableId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DbTableId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "DbTableId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DbTableId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "DbTableId",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "DbTableId",
                table: "Addresses");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 20, 14, 43, 253, DateTimeKind.Local).AddTicks(2009));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DbTableId",
                table: "Users",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DbTableId",
                table: "SubCategories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DbTableId",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DbTableId",
                table: "Payments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DbTableId",
                table: "Orders",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DbTableId",
                table: "OrderItems",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DbTableId",
                table: "Categories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DbTableId",
                table: "Carts",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DbTableId",
                table: "CartItems",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DbTableId",
                table: "Addresses",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4023), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4085), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4087), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4088), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4089), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4201), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4203), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4204), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4205), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4207), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4208), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4209), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4210), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4211), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4212), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4291), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4292), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4293), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4294), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4296), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4297), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4298), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4299), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4300), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4302), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4303), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4304), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4305), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4306), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4310), null });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "DbTableId" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 12, 13, 892, DateTimeKind.Local).AddTicks(4323), null });
        }
    }
}
