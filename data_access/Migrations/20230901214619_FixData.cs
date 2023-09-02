using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SteamApplication.Migrations
{
    public partial class FixData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 8, 3, 0, 46, 19, 509, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 7, 19, 0, 46, 19, 509, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 7, 4, 0, 46, 19, 509, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 6, 19, 0, 46, 19, 509, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 6, 4, 0, 46, 19, 509, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 5, 20, 0, 46, 19, 509, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 5, 5, 0, 46, 19, 509, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 4, 20, 0, 46, 19, 509, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 4, 5, 0, 46, 19, 509, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 3, 21, 0, 46, 19, 509, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2023, 3, 6, 0, 46, 19, 509, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2023, 2, 19, 0, 46, 19, 509, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2023, 2, 4, 0, 46, 19, 509, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2023, 1, 20, 0, 46, 19, 509, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2023, 1, 5, 0, 46, 19, 509, DateTimeKind.Local).AddTicks(9908));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 7, 31, 20, 20, 43, 851, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 7, 16, 20, 20, 43, 851, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 7, 1, 20, 20, 43, 851, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 6, 16, 20, 20, 43, 851, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 6, 1, 20, 20, 43, 851, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 5, 17, 20, 20, 43, 851, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 5, 2, 20, 20, 43, 851, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 4, 17, 20, 20, 43, 851, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 4, 2, 20, 20, 43, 851, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 3, 18, 20, 20, 43, 851, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2023, 3, 3, 20, 20, 43, 851, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2023, 2, 16, 20, 20, 43, 851, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2023, 2, 1, 20, 20, 43, 851, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2023, 1, 17, 20, 20, 43, 851, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2023, 1, 2, 20, 20, 43, 851, DateTimeKind.Local).AddTicks(884));
        }
    }
}
