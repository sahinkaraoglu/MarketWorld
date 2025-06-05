using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketWorld.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Brands",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4803), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4806), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4807), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4808), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4809), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4844), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4845), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4846), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4847), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4849), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4850), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4851), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4852), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4853), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4854), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4855), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4856), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4858), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4859), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4860), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4861), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4862), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4863), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4864), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4866), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4867), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4868), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4869), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4870), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4871), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4872), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4873), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4874), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4876), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4877), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4878), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4879), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4880), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4881), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4882), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4883), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4884), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4885), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4886), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4887), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4888), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4889), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4890), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4891), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4892), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4893), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4894), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4895), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4896), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4897), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4898), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4899), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4900), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4901), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4901), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4902), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4903), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4904), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4905), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4906), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4981), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4983), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4984), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4985), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4986), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4987), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4988), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4988), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4989), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4990), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4991), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4992), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4993), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4994), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4995), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4996), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4997), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4998), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4999), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5000), true });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5001), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 316, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 317, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 467,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 468,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 469,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 470,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 471,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 472,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 473,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 474,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 475,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 476,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 477,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 478,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 479,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 480,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 481,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 482,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 483,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 484,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 485,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 486,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 487,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 488,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 489,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 490,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 491,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 492,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 493,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 494,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 496,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 497,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 498,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 499,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 501,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 502,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 503,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 504,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 505,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 506,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 507,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 508,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 509,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 510,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 511,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 512,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 513,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 514,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 515,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 516,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 517,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 518,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 519,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 520,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 521,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 522,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 523,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 524,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 525,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 526,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 527,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 528,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 529,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 530,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 531,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 532,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 533,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 534,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 535,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 536,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 537,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 538,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 539,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 540,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 541,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 542,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 543,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 544,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 545,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 546,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 547,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 548,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 549,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 550,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 551,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 552,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 553,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 554,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 555,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 556,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 557,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 558,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 559,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 560,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 561,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 562,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 563,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 564,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 565,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 566,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 567,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 568,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 569,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 570,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 571,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 572,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 573,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 574,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 575,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 576,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 577,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 578,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 318, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 579,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 580,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 581,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 582,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 583,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 584,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 585,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 586,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 587,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 588,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 589,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 590,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 591,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 592,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 593,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 594,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 595,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 596,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 597,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 598,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 599,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 601,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 602,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 603,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 604,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 605,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 606,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 607,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 608,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 609,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 610,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 611,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 612,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 613,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 614,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 615,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 616,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 617,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 618,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 619,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 620,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 621,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 622,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 623,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 624,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 625,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 626,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 627,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 628,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 629,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 630,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 631,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 632,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 633,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 634,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 635,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 636,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 637,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 638,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 639,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 640,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 641,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 642,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 643,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 644,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 645,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 646,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 647,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 648,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 649,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 650,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 651,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 652,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 653,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 654,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 655,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 656,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 657,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 658,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 659,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 660,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 661,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 662,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 663,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 664,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 665,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 666,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 667,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 668,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 669,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 670,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 671,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 672,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 673,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 674,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 675,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 676,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 677,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 678,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 679,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 680,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 681,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 682,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 683,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 684,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 685,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 686,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 687,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 688,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 689,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 690,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 691,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 692,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 693,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 694,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 695,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 696,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 697,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 698,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 699,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 701,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 702,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 703,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 704,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 705,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 706,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 707,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 708,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 709,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 710,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 711,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 712,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 713,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 714,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 715,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 716,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 717,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 718,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 719,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 720,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 721,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 722,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 723,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 724,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 725,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 726,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 319, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 727,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 728,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 729,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 730,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 731,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 732,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 733,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 734,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 735,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 736,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 737,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 738,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 739,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 740,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 741,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 742,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 743,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 744,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 745,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 746,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 747,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 748,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 749,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 750,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 751,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 752,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 753,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 754,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 755,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 756,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 757,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 758,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 759,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 760,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 320, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 761,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 762,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 763,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 764,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 765,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 766,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 767,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 768,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 769,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 770,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 771,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 772,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 773,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 774,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 775,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 776,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 777,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 778,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 779,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 780,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 781,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 782,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 783,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 784,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 785,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 786,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 787,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 788,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 789,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 790,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 321, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 791,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 792,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 793,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 794,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 795,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 796,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 797,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 798,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 799,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 801,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 802,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 803,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 804,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 805,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 806,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 807,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 808,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 809,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 810,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 811,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 812,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 813,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 814,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 815,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 816,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 817,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 818,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 819,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 820,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 821,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 822,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 322, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 823,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 323, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 824,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 323, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 825,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 323, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 826,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 323, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 827,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 323, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 828,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 323, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 829,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 323, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 830,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 323, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 831,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 323, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 832,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 323, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 833,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 323, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 834,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 324, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 835,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 324, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 836,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 324, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 837,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 324, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 838,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 324, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 839,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 324, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 840,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 324, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 841,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 324, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 842,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 325, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 843,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 325, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 844,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 325, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 845,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 325, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 846,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 325, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 847,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 325, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 848,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 325, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 849,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 325, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 850,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 325, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 851,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 325, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 852,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 325, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 853,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 325, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 854,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 325, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 855,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 325, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 856,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 326, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 857,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 326, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 858,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 326, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 859,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 326, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 860,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 326, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 861,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 326, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 862,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 326, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 863,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 326, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 864,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 326, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 865,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 326, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 866,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 326, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 867,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 326, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 868,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 326, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 869,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 326, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 870,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 326, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 871,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 326, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 872,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 873,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 874,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 875,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 876,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 877,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 878,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 879,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 880,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 881,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 882,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 883,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 884,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 885,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 886,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 887,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 888,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 889,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 890,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 891,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 327, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 892,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 893,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 894,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 895,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 896,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 897,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 898,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 899,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 901,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 902,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 903,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 904,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 905,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 906,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 907,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 908,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 909,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 910,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 911,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 328, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5117), 868310 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5122), 865093 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5128), 420852 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5133), 845739 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5136), 192098 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5141), 973422 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5149), 332059 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5152), 976639 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5156), 646867 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5191), 292236 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5194), 560140 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5198), 296916 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5207), 639636 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5210), 737902 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5212), 746187 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5215), 962804 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5221), 188507 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5226), 985316 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5230), 549332 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5232), 348748 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5235), 138435 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5238), 112719 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5246), 951481 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5249), 220032 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5253), 812155 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5257), 318188 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5265), 420698 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5268), 632261 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5270), 424231 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5272), 344757 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5275), 294059 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5277), 539111 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5286), 487469 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5291), 807427 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5294), 713365 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5298), 304977 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5304), 617881 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5307), 605388 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5326), 217435 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5330), 304500 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5333), 900358 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5336), 431260 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5342), 633650 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5345), 607089 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5348), 593111 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5353), 800494 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5355), 957239 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5358), 406363 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5362), 942376 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5365), 296472 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5367), 100476 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5370), 329056 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5372), 603515 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5382), 347836 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5384), 958232 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5386), 738994 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5389), 728566 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5391), 120066 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5395), 786397 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5401), 936239 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5403), 848036 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5406), 728306 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5410), 683667 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5413), 290353 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5416), 200527 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5454), 561210 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5460), 898301 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5462), 580995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5465), 126214 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5470), 946075 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5472), 829124 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5479), 813031 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5485), 302105 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5488), 175903 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5490), 353251 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5492), 145648 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5495), 504462 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5500), 630123 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5502), 411482 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5507), 572058 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5509), 286048 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5514), 734966 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5518), 618454 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5520), 253651 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5528), 429847 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5530), 264380 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5533), 465266 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5538), 538687 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5542), 502910 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5544), 491904 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5547), 912221 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5549), 138189 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5551), 888339 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5558), 384356 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5561), 131117 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5563), 560397 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5566), 709581 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5569), 290186 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5571), 401384 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5609), 313477 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5616), 148730 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5619), 791719 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5621), 912742 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5625), 854413 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5628), 314253 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5631), 922655 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5636), 361389 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5639), 784682 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5642), 921990 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5645), 646972 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5649), 780063 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5655), 993294 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5657), 391059 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5659), 919650 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5661), 860585 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5665), 198221 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5668), 514300 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5676), 682842 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5680), 528406 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5682), 139362 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5685), 876963 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5687), 828000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5695), 727947 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5697), 669918 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5700), 598059 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5702), 207591 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5705), 494067 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5707), 755935 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5709), 205856 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5738), 546902 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5742), 965182 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5744), 154733 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5747), 838530 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5753), 953296 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5756), 898701 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5761), 242493 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5764), 774933 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5766), 229937 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5773), 414911 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5775), 489097 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5778), 281486 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5781), 862080 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5783), 226363 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5785), 105034 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5788), 405507 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5792), 168107 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5796), 562193 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5800), 766055 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5802), 208070 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5805), 103093 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5813), 304345 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5816), 154284 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5818), 661841 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5821), 921021 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5823), 364886 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5826), 763321 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5854), 358854 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5857), 195943 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5860), 578836 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5864), 995393 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5870), 135935 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(5873), 408458 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6008), 100542 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6013), 503259 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6015), 635209 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6019), 883239 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6022), 317043 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6028), 863851 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6030), 931079 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6033), 708816 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6038), 469294 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6042), 405316 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6046), 748068 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6049), 143642 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6052), 399543 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6054), 297122 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6057), 722971 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6061), 392782 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6065), 543158 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6068), 686519 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6070), 858073 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6073), 152934 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6076), 680556 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6079), 579517 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6088), 657064 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6093), 661121 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6099), 785269 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6106), 963653 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6108), 769799 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6136), 964318 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6144), 425129 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6148), 209573 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6151), 373466 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6155), 640233 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6158), 353470 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6164), 519657 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6167), 462999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6170), 978094 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6174), 896631 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6177), 200405 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6183), 352854 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6186), 515329 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6188), 150543 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6191), 339184 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6195), 665995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6198), 648153 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6203), 219207 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6208), 444326 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(6211), 198606 });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 315, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 0, 23, 44, 314, DateTimeKind.Local).AddTicks(4773));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Brands");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 526, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 527, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 467,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 468,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 469,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 470,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 471,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 472,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 473,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 474,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 475,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 476,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 477,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 478,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 479,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 480,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 481,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 482,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 483,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 484,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 485,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 486,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 487,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 488,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 489,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 490,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 491,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 492,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 493,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 494,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 496,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 497,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 498,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 499,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 501,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 502,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 503,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 504,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 505,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 506,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 507,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 508,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 509,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 510,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 511,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 512,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 513,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 514,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 515,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 516,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 517,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 518,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 519,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 520,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 521,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 522,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 523,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 524,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 525,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 526,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 527,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 528,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 529,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 530,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 531,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 532,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 533,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 534,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 535,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 536,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 537,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 538,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 539,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 540,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 541,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 542,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 543,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 544,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 545,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 546,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 547,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 548,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 549,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 550,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 551,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 552,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 553,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 554,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 555,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 556,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 557,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 558,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 559,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 560,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 561,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 562,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 563,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 564,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 565,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 566,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 567,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 568,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 569,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 570,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 571,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 572,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 573,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 574,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 575,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 576,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 577,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 578,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 528, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 579,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 580,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 581,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 582,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 583,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 584,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 585,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 586,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 587,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 588,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 589,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 590,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 591,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 592,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 593,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 594,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 595,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 596,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 597,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 598,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 599,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 601,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 602,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 603,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 604,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 605,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 606,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 607,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 608,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 609,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 610,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 611,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 612,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 613,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 614,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 615,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 616,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 617,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 618,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 619,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 620,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 621,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 622,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 623,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 624,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 625,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 626,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 627,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 628,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 629,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 630,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 631,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 632,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 633,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 634,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 635,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 636,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 637,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 638,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 639,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 640,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 641,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 642,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 643,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 644,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 645,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 646,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 647,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 648,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 649,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 650,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 651,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 652,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 653,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 654,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 655,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 656,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 657,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 658,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 659,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 660,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 661,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 662,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 663,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 664,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 665,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 666,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 667,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 668,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 669,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 670,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 671,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 672,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 673,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 674,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 675,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 676,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 677,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 678,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 679,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 680,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 681,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 682,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 683,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 684,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 685,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 686,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 687,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 688,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 689,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 690,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 691,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 692,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 693,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 694,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 695,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 696,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 697,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 698,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 699,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 701,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 702,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 703,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 704,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 705,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 706,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 707,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 708,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 709,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 710,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 711,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 712,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 713,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 714,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 715,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 716,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 717,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 718,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 719,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 720,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 721,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 722,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 723,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 724,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 725,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 726,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 727,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 728,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 729,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 730,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 731,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 732,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 529, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 733,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 734,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 735,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 736,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 737,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 738,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 739,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 740,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 741,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 742,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 743,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 744,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 745,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 746,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 747,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 748,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 749,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 750,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 751,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 752,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 753,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 754,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 755,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 756,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 757,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 758,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 759,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 760,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 761,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 762,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 763,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 764,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 765,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 766,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 767,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 768,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 769,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 770,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 771,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 772,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 773,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 774,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 775,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 776,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 530, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 777,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 778,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 779,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 780,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 781,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 782,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 783,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 784,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 785,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 786,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 787,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 788,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 789,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 790,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 791,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 792,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 793,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 794,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 795,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 796,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 797,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 798,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 799,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 801,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 802,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 803,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 804,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 805,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 806,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 807,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 808,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 809,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 810,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 811,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 812,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 813,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 814,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 815,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 816,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 817,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 818,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 819,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 820,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 821,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 822,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 531, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 823,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 532, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 824,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 532, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 825,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 532, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 826,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 532, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 827,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 532, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 828,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 532, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 829,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 532, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 830,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 532, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 831,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 532, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 832,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 532, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 833,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 532, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 834,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 835,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 836,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 837,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 838,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 839,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 840,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 841,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 842,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 843,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 844,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 845,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 846,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 847,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 848,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 849,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 850,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 851,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 533, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 852,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 853,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 854,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 855,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 856,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 857,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 858,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 859,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 860,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 861,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 862,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 863,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 864,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 865,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 866,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 867,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 868,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 869,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 534, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 870,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 871,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 872,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 873,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 874,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 875,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 876,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 877,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 878,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 879,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 880,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 881,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 882,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 883,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 884,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 885,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 886,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 887,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 888,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 889,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 890,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 535, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 891,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 892,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 893,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 894,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 895,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 896,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 897,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 898,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 899,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 901,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 902,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 903,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 904,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 905,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 906,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 907,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 908,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 909,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 910,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 536, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "ProductProperties",
                keyColumn: "Id",
                keyValue: 911,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 537, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2858), 181809 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2864), 991432 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2869), 297664 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2875), 470690 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2908), 692118 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2915), 797445 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2920), 221779 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2923), 408987 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2925), 925213 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2928), 558079 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2936), 925327 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2938), 196290 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2941), 741571 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2944), 338428 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2947), 939630 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2952), 107928 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2956), 314927 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2959), 555294 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2962), 889443 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2964), 130008 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2967), 386498 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2972), 471459 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2974), 589795 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2977), 304176 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2979), 214353 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2984), 234669 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2986), 830910 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2993), 995308 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2996), 749923 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2998), 712002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3001), 890727 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3005), 644370 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3012), 999156 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3034), 319811 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3038), 621920 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3043), 581795 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3045), 243015 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3051), 835681 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3054), 690435 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3057), 117010 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3060), 628299 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3062), 429062 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3071), 417163 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3074), 111228 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3077), 973297 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3081), 758653 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3085), 938679 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3091), 798736 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3096), 329611 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3098), 781810 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3101), 634232 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3103), 558945 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3110), 302891 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3115), 163091 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3118), 660491 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3122), 899882 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3129), 131985 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3132), 981142 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3135), 884321 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3139), 973543 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3141), 468432 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3144), 926732 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3148), 289630 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3151), 920356 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3154), 871180 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3193), 262710 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3196), 852930 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3198), 329948 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3201), 741640 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3208), 735600 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3212), 610872 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3215), 890535 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3218), 695544 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3220), 642085 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3229), 190794 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3231), 718931 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3237), 100408 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3240), 811065 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3242), 623480 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3246), 671934 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3248), 138715 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3252), 263979 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3255), 244432 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3258), 624278 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3260), 801895 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3265), 538508 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3268), 694357 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3270), 767063 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3273), 533442 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3276), 215454 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3279), 850742 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3285), 354018 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3289), 701721 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3295), 796543 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3327), 811643 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3330), 539441 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3332), 250438 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3335), 577480 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3339), 573963 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3344), 829257 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3347), 813508 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3354), 458521 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3357), 507439 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3363), 191514 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3365), 150829 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3367), 242594 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3370), 957475 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3372), 696684 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3374), 776024 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3376), 567926 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3382), 354551 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3384), 234460 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3386), 259441 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3390), 689211 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3394), 854216 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3396), 374353 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3404), 668670 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3406), 373957 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3408), 894005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3411), 685090 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3414), 628475 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3416), 800588 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3422), 289648 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3424), 610326 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3426), 527015 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3428), 511407 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3431), 811172 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3461), 315964 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3464), 596172 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3469), 629722 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3471), 897651 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3473), 640649 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3480), 317293 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3482), 919126 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3485), 449438 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3490), 853959 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3492), 965839 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3499), 752046 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3502), 709691 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3505), 229641 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3507), 445737 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3510), 773218 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3512), 463734 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3514), 690750 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3517), 257122 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3519), 641155 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3521), 787882 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3525), 219959 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3528), 302481 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3530), 409072 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3533), 718927 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3535), 366384 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3561), 395411 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3564), 340519 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3567), 276269 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3571), 671585 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3573), 785044 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3578), 616370 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3582), 177540 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3585), 847832 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3588), 878514 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3591), 505076 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3593), 199871 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3600), 504011 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3603), 783735 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3606), 671320 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3609), 449814 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3611), 374332 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3618), 473735 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3621), 789737 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3624), 946514 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3627), 252588 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3629), 145878 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3632), 791558 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3638), 997913 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3641), 209277 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3644), 418423 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3646), 690589 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3649), 124463 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3651), 405723 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3657), 422644 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3659), 161704 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3662), 900306 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3664), 209731 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3667), 772081 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3690), 837400 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3695), 164763 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3698), 871819 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3701), 200241 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3703), 473479 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3706), 122265 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3709), 762771 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3716), 490744 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3719), 791714 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3722), 205091 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3724), 658938 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3727), 635649 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3734), 533659 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3737), 852957 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3739), 584094 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3741), 123298 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3744), 790041 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3746), 797945 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3754), 498024 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3760), 163530 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3762), 270691 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3765), 776481 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3768), 287171 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedDate", "ProductCode" },
                values: new object[] { new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(3773), 739081 });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 14, 26, 29, 525, DateTimeKind.Local).AddTicks(2600));
        }
    }
}
