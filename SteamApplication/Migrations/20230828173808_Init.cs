using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SteamApplication.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Followers = table.Column<int>(type: "int", nullable: true),
                    Rate = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platform",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platform", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Followers = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsVerifiedAccount = table.Column<bool>(type: "bit", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<short>(type: "smallint", nullable: true),
                    PlatformId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Game_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Game_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Game_Platform_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platform",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateTable(
                name: "Market",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Market", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Market_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Market_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Category 1" },
                    { 2, "Category 2" },
                    { 3, "Category 3" },
                    { 4, "Category 4" },
                    { 5, "Category 5" },
                    { 6, "Category 6" },
                    { 7, "Category 7" },
                    { 8, "Category 8" },
                    { 9, "Category 9" },
                    { 10, "Category 10" },
                    { 11, "Category 11" },
                    { 12, "Category 12" },
                    { 13, "Category 13" },
                    { 14, "Category 14" },
                    { 15, "Category 15" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Country 1" },
                    { 2, "Country 2" },
                    { 3, "Country 3" },
                    { 4, "Country 4" },
                    { 5, "Country 5" },
                    { 6, "Country 6" },
                    { 7, "Country 7" },
                    { 8, "Country 8" },
                    { 9, "Country 9" },
                    { 10, "Country 10" },
                    { 11, "Country 11" },
                    { 12, "Country 12" },
                    { 13, "Country 13" },
                    { 14, "Country 14" },
                    { 15, "Country 15" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Followers", "Name", "Rate" },
                values: new object[,]
                {
                    { 1, 100, "Group 1", (short)4 },
                    { 2, 200, "Group 2", (short)3 },
                    { 3, 300, "Group 3", (short)5 },
                    { 4, 400, "Group 4", (short)4 },
                    { 5, 500, "Group 5", (short)3 },
                    { 6, 600, "Group 6", (short)4 },
                    { 7, 700, "Group 7", (short)5 },
                    { 8, 800, "Group 8", (short)3 },
                    { 9, 900, "Group 9", (short)4 },
                    { 10, 1000, "Group 10", (short)5 },
                    { 11, 1100, "Group 11", (short)3 },
                    { 12, 1200, "Group 12", (short)4 }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Followers", "Name", "Rate" },
                values: new object[,]
                {
                    { 13, 1300, "Group 13", (short)5 },
                    { 14, 1400, "Group 14", (short)3 },
                    { 15, 1500, "Group 15", (short)4 }
                });

            migrationBuilder.InsertData(
                table: "Platform",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Platform 1" },
                    { 2, "Platform 2" },
                    { 3, "Platform 3" },
                    { 4, "Platform 4" },
                    { 5, "Platform 5" },
                    { 6, "Platform 6" },
                    { 7, "Platform 7" },
                    { 8, "Platform 8" },
                    { 9, "Platform 9" },
                    { 10, "Platform 10" },
                    { 11, "Platform 11" },
                    { 12, "Platform 12" },
                    { 13, "Platform 13" },
                    { 14, "Platform 14" },
                    { 15, "Platform 15" }
                });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Position 1" },
                    { 2, "Position 2" },
                    { 3, "Position 3" },
                    { 4, "Position 4" },
                    { 5, "Position 5" },
                    { 6, "Position 6" },
                    { 7, "Position 7" },
                    { 8, "Position 8" },
                    { 9, "Position 9" },
                    { 10, "Position 10" },
                    { 11, "Position 11" },
                    { 12, "Position 12" },
                    { 13, "Position 13" },
                    { 14, "Position 14" },
                    { 15, "Position 15" }
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "CountryId", "Followers", "Name" },
                values: new object[,]
                {
                    { 1, 1, 100, "Developer 1" },
                    { 2, 2, 200, "Developer 2" },
                    { 3, 3, 300, "Developer 3" },
                    { 4, 4, 400, "Developer 4" },
                    { 5, 5, 500, "Developer 5" },
                    { 6, 6, 600, "Developer 6" },
                    { 7, 7, 700, "Developer 7" },
                    { 8, 8, 800, "Developer 8" },
                    { 9, 9, 900, "Developer 9" },
                    { 10, 10, 1000, "Developer 10" },
                    { 11, 11, 1100, "Developer 11" },
                    { 12, 12, 1200, "Developer 12" },
                    { 13, 13, 1300, "Developer 13" },
                    { 14, 14, 1400, "Developer 14" },
                    { 15, 15, 1500, "Developer 15" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CountryId", "Date", "Email", "IsVerifiedAccount", "NickName", "Password", "Phone", "PositionId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 29, 20, 38, 8, 632, DateTimeKind.Local).AddTicks(3955), "user1@example.com", true, "User1", "password1", "1234567890", 1 },
                    { 2, 2, new DateTime(2023, 7, 14, 20, 38, 8, 632, DateTimeKind.Local).AddTicks(3968), "user2@example.com", false, "User2", "password2", "9876543210", 2 },
                    { 3, 3, new DateTime(2023, 6, 29, 20, 38, 8, 632, DateTimeKind.Local).AddTicks(3969), "user3@example.com", true, "User3", "password3", "5555555555", 3 },
                    { 4, 4, new DateTime(2023, 6, 14, 20, 38, 8, 632, DateTimeKind.Local).AddTicks(3971), "user4@example.com", false, "User4", "password4", "4444444444", 4 },
                    { 5, 5, new DateTime(2023, 5, 30, 20, 38, 8, 632, DateTimeKind.Local).AddTicks(3972), "user5@example.com", true, "User5", "password5", "5555555555", 5 },
                    { 6, 6, new DateTime(2023, 5, 15, 20, 38, 8, 632, DateTimeKind.Local).AddTicks(3974), "user6@example.com", true, "User6", "password6", "6666666666", 6 },
                    { 7, 7, new DateTime(2023, 4, 30, 20, 38, 8, 632, DateTimeKind.Local).AddTicks(3975), "user7@example.com", false, "User7", "password7", "7777777777", 7 },
                    { 8, 8, new DateTime(2023, 4, 15, 20, 38, 8, 632, DateTimeKind.Local).AddTicks(3978), "user8@example.com", true, "User8", "password8", "8888888888", 8 },
                    { 9, 9, new DateTime(2023, 3, 31, 20, 38, 8, 632, DateTimeKind.Local).AddTicks(3979), "user9@example.com", false, "User9", "password9", "9999999999", 9 },
                    { 10, 10, new DateTime(2023, 3, 16, 20, 38, 8, 632, DateTimeKind.Local).AddTicks(3980), "user10@example.com", true, "User10", "password10", "1010101010", 10 },
                    { 11, 11, new DateTime(2023, 3, 1, 20, 38, 8, 632, DateTimeKind.Local).AddTicks(3981), "user11@example.com", false, "User11", "password11", "1111111111", 11 },
                    { 12, 12, new DateTime(2023, 2, 14, 20, 38, 8, 632, DateTimeKind.Local).AddTicks(3982), "user12@example.com", true, "User12", "password12", "1212121212", 12 },
                    { 13, 13, new DateTime(2023, 1, 30, 20, 38, 8, 632, DateTimeKind.Local).AddTicks(3983), "user13@example.com", true, "User13", "password13", "1313131313", 13 },
                    { 14, 14, new DateTime(2023, 1, 15, 20, 38, 8, 632, DateTimeKind.Local).AddTicks(3984), "user14@example.com", false, "User14", "password14", "1414141414", 14 },
                    { 15, 15, new DateTime(2022, 12, 31, 20, 38, 8, 632, DateTimeKind.Local).AddTicks(3985), "user15@example.com", true, "User15", "password15", "1515151515", 15 }
                });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "Id", "CategoryId", "CompanyId", "Cost", "Description", "Name", "PlatformId", "Rate" },
                values: new object[,]
                {
                    { 1, 1, 1, 9.99m, "Description 1", "Game 1", null, (short)4 },
                    { 2, 2, 2, 19.99m, "Description 2", "Game 2", null, (short)3 },
                    { 3, 3, 3, 14.99m, "Description 3", "Game 3", null, (short)5 },
                    { 4, 4, 4, 29.99m, "Description 4", "Game 4", null, (short)4 },
                    { 5, 5, 5, 9.99m, "Description 5", "Game 5", null, (short)3 },
                    { 6, 6, 6, 19.99m, "Description 6", "Game 6", null, (short)4 },
                    { 7, 7, 7, 14.99m, "Description 7", "Game 7", null, (short)5 },
                    { 8, 8, 8, 29.99m, "Description 8", "Game 8", null, (short)3 },
                    { 9, 9, 9, 9.99m, "Description 9", "Game 9", null, (short)4 },
                    { 10, 10, 10, 19.99m, "Description 10", "Game 10", null, (short)5 },
                    { 11, 11, 11, 14.99m, "Description 11", "Game 11", null, (short)3 },
                    { 12, 12, 12, 29.99m, "Description 12", "Game 12", null, (short)4 },
                    { 13, 13, 13, 9.99m, "Description 13", "Game 13", null, (short)5 },
                    { 14, 14, 14, 19.99m, "Description 14", "Game 14", null, (short)3 },
                    { 15, 15, 15, 14.99m, "Description 15", "Game 15", null, (short)4 }
                });

            migrationBuilder.InsertData(
                table: "Market",
                columns: new[] { "Id", "CompanyId", "GameId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 },
                    { 6, 6, 6 },
                    { 7, 7, 7 },
                    { 8, 8, 8 },
                    { 9, 9, 9 },
                    { 10, 10, 10 },
                    { 11, 11, 11 },
                    { 12, 12, 12 },
                    { 13, 13, 13 },
                    { 14, 14, 14 },
                    { 15, 15, 15 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "GameId", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, "Review 1", 1, 4, 1 },
                    { 2, "Review 2", 2, 5, 2 },
                    { 3, "Review 3", 3, 3, 3 },
                    { 4, "Review 4", 4, 4, 4 },
                    { 5, "Review 5", 5, 5, 5 },
                    { 6, "Review 6", 6, 4, 6 },
                    { 7, "Review 7", 7, 3, 7 },
                    { 8, "Review 8", 8, 5, 8 },
                    { 9, "Review 9", 9, 4, 9 },
                    { 10, "Review 10", 10, 3, 10 },
                    { 11, "Review 11", 11, 4, 11 },
                    { 12, "Review 12", 12, 5, 12 },
                    { 13, "Review 13", 13, 4, 13 },
                    { 14, "Review 14", 14, 3, 14 },
                    { 15, "Review 15", 15, 5, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company_CountryId",
                table: "Company",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_CategoryId",
                table: "Game",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_CompanyId",
                table: "Game",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_PlatformId",
                table: "Game",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsUser_UsersId",
                table: "GroupsUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Market_CompanyId",
                table: "Market",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Market_GameId",
                table: "Market",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_GameId",
                table: "Review",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserId",
                table: "Review",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CountryId",
                table: "User",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PositionId",
                table: "User",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupsUser");

            migrationBuilder.DropTable(
                name: "Market");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Platform");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
