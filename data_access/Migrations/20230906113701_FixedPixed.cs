using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SteamApplication.Migrations
{
    public partial class FixedPixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 8, 7, 14, 37, 0, 766, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 7, 23, 14, 37, 0, 766, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 7, 8, 14, 37, 0, 766, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 6, 23, 14, 37, 0, 766, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 6, 8, 14, 37, 0, 766, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 5, 24, 14, 37, 0, 766, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 5, 9, 14, 37, 0, 766, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 4, 24, 14, 37, 0, 766, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 4, 9, 14, 37, 0, 766, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 3, 25, 14, 37, 0, 766, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2023, 3, 10, 14, 37, 0, 766, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2023, 2, 23, 14, 37, 0, 766, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2023, 2, 8, 14, 37, 0, 766, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2023, 1, 24, 14, 37, 0, 766, DateTimeKind.Local).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2023, 1, 9, 14, 37, 0, 766, DateTimeKind.Local).AddTicks(36));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 8, 5, 20, 34, 9, 639, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 7, 21, 20, 34, 9, 639, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 7, 6, 20, 34, 9, 639, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 6, 21, 20, 34, 9, 639, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 6, 6, 20, 34, 9, 639, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 5, 22, 20, 34, 9, 639, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 5, 7, 20, 34, 9, 639, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 4, 22, 20, 34, 9, 639, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 4, 7, 20, 34, 9, 639, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 3, 23, 20, 34, 9, 639, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2023, 3, 8, 20, 34, 9, 639, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2023, 2, 21, 20, 34, 9, 639, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2023, 2, 6, 20, 34, 9, 639, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2023, 1, 22, 20, 34, 9, 639, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2023, 1, 7, 20, 34, 9, 639, DateTimeKind.Local).AddTicks(5316));
        }
    }
}
