using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Colab.Migrations
{
    /// <inheritdoc />
    public partial class updt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    IsVerified = table.Column<bool>(type: "INTEGER", nullable: false),
                    profilePicture = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    IsAdmin = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    state = table.Column<int>(type: "INTEGER", nullable: false),
                    ProjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignments_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailVerifTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Token = table.Column<string>(type: "TEXT", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailVerifTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailVerifTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectUser",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsOwner = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUser", x => new { x.ProjectId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ProjectUser_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 22, 10, 51, 8, 701, DateTimeKind.Local).AddTicks(2689), "Commodi non consecte", "Intelligent Rubber Ball", new DateTime(2022, 6, 28, 11, 32, 56, 367, DateTimeKind.Local).AddTicks(8108) },
                    { 2, new DateTime(2022, 10, 16, 3, 43, 48, 631, DateTimeKind.Local).AddTicks(9174), "Nostrum voluptatum i", "Licensed Frozen Keyboard", new DateTime(2022, 6, 21, 2, 59, 30, 57, DateTimeKind.Local).AddTicks(6934) },
                    { 3, new DateTime(2022, 11, 24, 18, 9, 39, 252, DateTimeKind.Local).AddTicks(3531), "Sapiente et cupidita", "Unbranded Metal Salad", new DateTime(2022, 10, 29, 13, 52, 39, 233, DateTimeKind.Local).AddTicks(8861) },
                    { 4, new DateTime(2022, 8, 15, 5, 35, 22, 831, DateTimeKind.Local).AddTicks(1368), "Eos incidunt nesciun", "Awesome Fresh Bacon", new DateTime(2022, 8, 22, 2, 36, 23, 69, DateTimeKind.Local).AddTicks(7868) },
                    { 5, new DateTime(2022, 6, 13, 13, 6, 42, 622, DateTimeKind.Local).AddTicks(7763), "Et ullam quo volupta", "Rustic Frozen Tuna", new DateTime(2022, 7, 28, 0, 15, 39, 32, DateTimeKind.Local).AddTicks(5777) },
                    { 6, new DateTime(2022, 7, 16, 5, 15, 10, 39, DateTimeKind.Local).AddTicks(5014), "Dolores eius at labo", "Practical Steel Towels", new DateTime(2022, 6, 21, 16, 41, 9, 508, DateTimeKind.Local).AddTicks(7475) },
                    { 7, new DateTime(2022, 5, 27, 12, 30, 43, 451, DateTimeKind.Local).AddTicks(6213), "Odit consectetur inc", "Awesome Plastic Salad", new DateTime(2023, 1, 28, 2, 32, 33, 665, DateTimeKind.Local).AddTicks(810) },
                    { 8, new DateTime(2022, 4, 18, 22, 22, 10, 125, DateTimeKind.Local).AddTicks(3852), "Harum maxime ipsum e", "Practical Rubber Cheese", new DateTime(2022, 11, 11, 1, 34, 36, 827, DateTimeKind.Local).AddTicks(7496) },
                    { 9, new DateTime(2022, 5, 19, 19, 22, 49, 330, DateTimeKind.Local).AddTicks(9212), "Odit ipsa pariatur n", "Awesome Soft Salad", new DateTime(2022, 10, 9, 14, 15, 20, 522, DateTimeKind.Local).AddTicks(1708) },
                    { 10, new DateTime(2023, 2, 23, 4, 36, 16, 870, DateTimeKind.Local).AddTicks(5872), "Possimus blanditiis ", "Awesome Soft Chicken", new DateTime(2022, 5, 7, 6, 27, 44, 401, DateTimeKind.Local).AddTicks(9106) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsAdmin", "IsVerified", "Name", "Password", "profilePicture" },
                values: new object[,]
                {
                    { 1, "Clair.Armstrong@gmail.com", false, false, "Terrance Yost", "$2a$11$DWVaVHU84mKxkh60rDYCBeD0a2q.fuxS/ob9iSK8ZoCcQN.Tiy.zy", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1221.jpg" },
                    { 2, "Aletha65@gmail.com", false, false, "Rocky Bins", "$2a$11$ld4b26Tj8ttjXhCVw3Lg/.x5slVjxjVvFg3iI8itmjOre4A4ZoM.m", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/561.jpg" },
                    { 3, "Efren50@hotmail.com", false, false, "Gavin Kilback", "$2a$11$T3sal18Z5yipe7MdRpAnDOnM9oa7UNTGsmf7h4eJhfKkORQQlQQNS", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/377.jpg" },
                    { 4, "Lazaro.Shanahan@yahoo.com", false, false, "Erick Murphy", "$2a$11$7E4//9k48X2XeaIjsEMcwuLmnFxe/BecNdTgpg1d9Gmz5EE4kccuS", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/129.jpg" },
                    { 5, "Waylon.Schamberger12@gmail.com", false, false, "Taya Labadie", "$2a$11$2fWJE0JAtDWMgmRcOSBEIu7F4eXYdRz6JcsRVVxSXHR2HhpN.Dtfq", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/932.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 14, 10, 36, 28, 290, DateTimeKind.Local).AddTicks(1549), "Delectus eligendi re", 5, "Intelligent Metal Pizza", new DateTime(2022, 12, 4, 21, 43, 55, 371, DateTimeKind.Local).AddTicks(4882), 1, 0 },
                    { 2, new DateTime(2022, 11, 9, 21, 16, 35, 360, DateTimeKind.Local).AddTicks(1928), "Ex qui facilis reici", 7, "Small Concrete Salad", new DateTime(2023, 3, 31, 9, 33, 50, 595, DateTimeKind.Local).AddTicks(681), 4, 1 },
                    { 3, new DateTime(2023, 2, 28, 19, 21, 20, 200, DateTimeKind.Local).AddTicks(2970), "Illum aut enim quas ", 4, "Fantastic Metal Car", new DateTime(2022, 9, 5, 8, 25, 27, 965, DateTimeKind.Local).AddTicks(9649), 5, 0 },
                    { 4, new DateTime(2022, 9, 27, 13, 41, 47, 381, DateTimeKind.Local).AddTicks(3619), "Iure vero perferendi", 8, "Unbranded Concrete Shoes", new DateTime(2022, 10, 9, 10, 56, 54, 801, DateTimeKind.Local).AddTicks(4625), 1, 1 },
                    { 5, new DateTime(2022, 11, 21, 23, 29, 36, 560, DateTimeKind.Local).AddTicks(2725), "Ut sapiente qui qui ", 7, "Ergonomic Frozen Cheese", new DateTime(2023, 2, 2, 20, 11, 27, 439, DateTimeKind.Local).AddTicks(7450), 1, 2 },
                    { 6, new DateTime(2022, 5, 12, 12, 1, 55, 193, DateTimeKind.Local).AddTicks(8326), "Hic autem dolor. Qui", 7, "Gorgeous Fresh Fish", new DateTime(2022, 8, 16, 12, 46, 33, 411, DateTimeKind.Local).AddTicks(3702), 4, 0 },
                    { 7, new DateTime(2022, 9, 15, 15, 11, 36, 537, DateTimeKind.Local).AddTicks(7432), "Quidem ex ut exceptu", 2, "Awesome Rubber Pants", new DateTime(2022, 4, 20, 3, 58, 0, 706, DateTimeKind.Local).AddTicks(8813), 2, 0 },
                    { 8, new DateTime(2022, 12, 21, 12, 26, 3, 289, DateTimeKind.Local).AddTicks(4702), "Quod eveniet error e", 3, "Incredible Concrete Bacon", new DateTime(2022, 9, 19, 13, 19, 58, 508, DateTimeKind.Local).AddTicks(7025), 5, 0 },
                    { 9, new DateTime(2022, 8, 7, 21, 47, 13, 190, DateTimeKind.Local).AddTicks(8448), "In temporibus labori", 8, "Fantastic Steel Shirt", new DateTime(2022, 4, 14, 20, 37, 33, 153, DateTimeKind.Local).AddTicks(72), 4, 1 },
                    { 10, new DateTime(2023, 2, 4, 22, 37, 40, 542, DateTimeKind.Local).AddTicks(23), "Numquam non cum aspe", 9, "Small Concrete Mouse", new DateTime(2022, 9, 10, 19, 28, 27, 851, DateTimeKind.Local).AddTicks(3453), 1, 0 },
                    { 11, new DateTime(2022, 5, 14, 20, 53, 4, 3, DateTimeKind.Local).AddTicks(8535), "Voluptatem voluptati", 3, "Gorgeous Granite Keyboard", new DateTime(2022, 6, 16, 20, 20, 29, 189, DateTimeKind.Local).AddTicks(4845), 1, 1 },
                    { 12, new DateTime(2022, 4, 17, 3, 1, 59, 255, DateTimeKind.Local).AddTicks(5378), "Quisquam impedit ten", 8, "Practical Cotton Chair", new DateTime(2022, 9, 29, 10, 57, 1, 682, DateTimeKind.Local).AddTicks(3143), 1, 2 },
                    { 13, new DateTime(2022, 4, 26, 18, 17, 34, 30, DateTimeKind.Local).AddTicks(2227), "Placeat provident mo", 8, "Ergonomic Metal Chair", new DateTime(2023, 1, 29, 15, 1, 18, 570, DateTimeKind.Local).AddTicks(881), 1, 1 },
                    { 14, new DateTime(2023, 3, 21, 3, 46, 10, 669, DateTimeKind.Local).AddTicks(8569), "Eum quisquam tenetur", 2, "Licensed Metal Table", new DateTime(2023, 2, 28, 21, 16, 0, 739, DateTimeKind.Local).AddTicks(5707), 5, 1 },
                    { 15, new DateTime(2022, 7, 1, 10, 29, 44, 637, DateTimeKind.Local).AddTicks(9038), "Rem maxime alias nob", 10, "Unbranded Metal Towels", new DateTime(2022, 11, 3, 2, 20, 6, 926, DateTimeKind.Local).AddTicks(1976), 5, 2 },
                    { 16, new DateTime(2022, 7, 1, 10, 25, 59, 239, DateTimeKind.Local).AddTicks(2792), "Voluptas doloribus m", 5, "Fantastic Frozen Table", new DateTime(2022, 8, 28, 17, 46, 51, 878, DateTimeKind.Local).AddTicks(6676), 1, 1 },
                    { 17, new DateTime(2023, 3, 12, 16, 13, 57, 487, DateTimeKind.Local).AddTicks(3830), "Debitis maiores dele", 1, "Practical Steel Towels", new DateTime(2022, 5, 24, 8, 44, 36, 183, DateTimeKind.Local).AddTicks(5076), 5, 1 },
                    { 18, new DateTime(2022, 5, 8, 22, 59, 35, 335, DateTimeKind.Local).AddTicks(5661), "Aliquam impedit adip", 2, "Rustic Rubber Tuna", new DateTime(2022, 10, 2, 4, 42, 34, 344, DateTimeKind.Local).AddTicks(1987), 4, 0 },
                    { 19, new DateTime(2022, 8, 31, 17, 28, 58, 753, DateTimeKind.Local).AddTicks(305), "Occaecati inventore ", 10, "Tasty Rubber Hat", new DateTime(2023, 1, 5, 12, 59, 34, 991, DateTimeKind.Local).AddTicks(7968), 5, 1 },
                    { 20, new DateTime(2022, 12, 22, 1, 9, 59, 184, DateTimeKind.Local).AddTicks(2290), "Sunt quaerat quos ha", 7, "Awesome Concrete Chicken", new DateTime(2022, 10, 11, 21, 51, 21, 895, DateTimeKind.Local).AddTicks(4613), 4, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_ProjectId",
                table: "Assignments",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_UserId",
                table: "Assignments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailVerifTokens_UserId",
                table: "EmailVerifTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_UserId",
                table: "ProjectUser",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "EmailVerifTokens");

            migrationBuilder.DropTable(
                name: "ProjectUser");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
