using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SteamApplication.Migrations
{
    public partial class CreateRepositories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
