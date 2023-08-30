using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SteamApplication.Migrations
{
    public partial class AddUnitOfWork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 7, 31, 19, 58, 49, 455, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 7, 16, 19, 58, 49, 455, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 7, 1, 19, 58, 49, 455, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 6, 16, 19, 58, 49, 455, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 6, 1, 19, 58, 49, 455, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 5, 17, 19, 58, 49, 455, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 5, 2, 19, 58, 49, 455, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 4, 17, 19, 58, 49, 455, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 4, 2, 19, 58, 49, 455, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 3, 18, 19, 58, 49, 455, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2023, 3, 3, 19, 58, 49, 455, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2023, 2, 16, 19, 58, 49, 455, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2023, 2, 1, 19, 58, 49, 455, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2023, 1, 17, 19, 58, 49, 455, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2023, 1, 2, 19, 58, 49, 455, DateTimeKind.Local).AddTicks(9046));
        }
    }
}
