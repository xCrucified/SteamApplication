using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SteamApplication.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 7, 31, 18, 36, 20, 339, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 7, 16, 18, 36, 20, 339, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 7, 1, 18, 36, 20, 339, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 6, 16, 18, 36, 20, 339, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 6, 1, 18, 36, 20, 339, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 5, 17, 18, 36, 20, 339, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 5, 2, 18, 36, 20, 339, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 4, 17, 18, 36, 20, 339, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 4, 2, 18, 36, 20, 339, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 3, 18, 18, 36, 20, 339, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2023, 3, 3, 18, 36, 20, 339, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2023, 2, 16, 18, 36, 20, 339, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2023, 2, 1, 18, 36, 20, 339, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2023, 1, 17, 18, 36, 20, 339, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2023, 1, 2, 18, 36, 20, 339, DateTimeKind.Local).AddTicks(6670));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 7, 30, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 7, 15, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 6, 30, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 6, 15, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 5, 31, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 5, 16, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 5, 1, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 4, 16, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 4, 1, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 3, 17, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2023, 3, 2, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2023, 2, 15, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2023, 1, 31, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2023, 1, 16, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2023, 1, 1, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5237));
        }
    }
}
