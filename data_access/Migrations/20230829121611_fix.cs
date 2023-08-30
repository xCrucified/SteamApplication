using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SteamApplication.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupsUser");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "GroupId" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5204), 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "GroupId" },
                values: new object[] { new DateTime(2023, 7, 15, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5217), 2 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "GroupId" },
                values: new object[] { new DateTime(2023, 6, 30, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5219), 3 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "GroupId" },
                values: new object[] { new DateTime(2023, 6, 15, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5220), 4 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "GroupId" },
                values: new object[] { new DateTime(2023, 5, 31, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5224), 5 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "GroupId" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5226), 6 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "GroupId" },
                values: new object[] { new DateTime(2023, 5, 1, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5228), 7 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "GroupId" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5229), 8 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "GroupId" },
                values: new object[] { new DateTime(2023, 4, 1, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5230), 9 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "GroupId" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5231), 10 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "GroupId" },
                values: new object[] { new DateTime(2023, 3, 2, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5232), 11 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "GroupId" },
                values: new object[] { new DateTime(2023, 2, 15, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5233), 12 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "GroupId" },
                values: new object[] { new DateTime(2023, 1, 31, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5235), 13 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "GroupId" },
                values: new object[] { new DateTime(2023, 1, 16, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5236), 14 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "GroupId" },
                values: new object[] { new DateTime(2023, 1, 1, 15, 16, 10, 694, DateTimeKind.Local).AddTicks(5237), 15 });

            migrationBuilder.CreateIndex(
                name: "IX_User_GroupId",
                table: "User",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Groups_GroupId",
                table: "User",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Groups_GroupId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_GroupId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "User");

            migrationBuilder.CreateTable(
                name: "GroupsUser",
                columns: table => new
                {
                    GroupsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupsUser", x => new { x.GroupsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_GroupsUser_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupsUser_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 7, 30, 15, 13, 34, 177, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 7, 15, 15, 13, 34, 177, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 6, 30, 15, 13, 34, 177, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 6, 15, 15, 13, 34, 177, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 5, 31, 15, 13, 34, 177, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 5, 16, 15, 13, 34, 177, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 5, 1, 15, 13, 34, 177, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 4, 16, 15, 13, 34, 177, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 4, 1, 15, 13, 34, 177, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 3, 17, 15, 13, 34, 177, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2023, 3, 2, 15, 13, 34, 177, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2023, 2, 15, 15, 13, 34, 177, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2023, 1, 31, 15, 13, 34, 177, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2023, 1, 16, 15, 13, 34, 177, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2023, 1, 1, 15, 13, 34, 177, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.CreateIndex(
                name: "IX_GroupsUser_UsersId",
                table: "GroupsUser",
                column: "UsersId");
        }
    }
}
