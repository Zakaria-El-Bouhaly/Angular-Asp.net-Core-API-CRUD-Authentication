using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Colab.Migrations
{
    /// <inheritdoc />
    public partial class haha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    OwnerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    ProjectId = table.Column<int>(type: "INTEGER", nullable: false)
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
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "Rosemary_Hickle5@yahoo.com", "Vena Walsh", "_vXg4k2x71" },
                    { 2, "Hubert42@gmail.com", "Helene Torp", "0b5YYSq6G9" },
                    { 3, "Brooks46@yahoo.com", "Constance Mueller", "sjIzImTl2c" },
                    { 4, "Eldon.Murray@gmail.com", "Shanon Auer", "N0xdxHFpL5" },
                    { 5, "Katlynn.Considine@gmail.com", "Ima Braun", "VDozahKnYq" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 23, 21, 3, 18, 923, DateTimeKind.Local).AddTicks(5276), "Aliquid suscipit qui", 5, "Generic Cotton Chair", new DateTime(2022, 8, 21, 12, 57, 16, 921, DateTimeKind.Local).AddTicks(6419) },
                    { 2, new DateTime(2022, 8, 26, 7, 24, 26, 825, DateTimeKind.Local).AddTicks(6747), "Rem numquam sed dist", 5, "Fantastic Fresh Ball", new DateTime(2022, 4, 4, 1, 4, 44, 964, DateTimeKind.Local).AddTicks(3253) },
                    { 3, new DateTime(2022, 3, 13, 10, 34, 13, 769, DateTimeKind.Local).AddTicks(9674), "Quidem in in ea a of", 1, "Sleek Fresh Fish", new DateTime(2022, 6, 11, 20, 3, 48, 207, DateTimeKind.Local).AddTicks(7405) },
                    { 4, new DateTime(2022, 4, 25, 20, 10, 19, 7, DateTimeKind.Local).AddTicks(4290), "Ut laborum dolorum p", 3, "Refined Frozen Cheese", new DateTime(2023, 1, 27, 20, 7, 37, 547, DateTimeKind.Local).AddTicks(7464) },
                    { 5, new DateTime(2022, 4, 6, 2, 43, 1, 379, DateTimeKind.Local).AddTicks(9554), "Sit et vero. Dicta l", 1, "Ergonomic Concrete Sausages", new DateTime(2022, 4, 23, 16, 58, 3, 917, DateTimeKind.Local).AddTicks(6585) },
                    { 6, new DateTime(2022, 7, 8, 22, 36, 27, 553, DateTimeKind.Local).AddTicks(3186), "Commodi pariatur rem", 2, "Gorgeous Steel Shoes", new DateTime(2022, 3, 16, 19, 49, 30, 807, DateTimeKind.Local).AddTicks(8439) },
                    { 7, new DateTime(2022, 2, 19, 9, 59, 49, 305, DateTimeKind.Local).AddTicks(9862), "Necessitatibus qui l", 5, "Fantastic Rubber Bike", new DateTime(2023, 1, 29, 22, 53, 8, 129, DateTimeKind.Local).AddTicks(2916) },
                    { 8, new DateTime(2023, 2, 6, 0, 32, 32, 860, DateTimeKind.Local).AddTicks(4923), "Blanditiis fuga et a", 2, "Generic Granite Mouse", new DateTime(2022, 4, 9, 18, 3, 48, 510, DateTimeKind.Local).AddTicks(6923) },
                    { 9, new DateTime(2022, 11, 26, 11, 11, 15, 579, DateTimeKind.Local).AddTicks(1292), "Corporis in neque ex", 4, "Intelligent Granite Salad", new DateTime(2022, 6, 30, 20, 28, 28, 427, DateTimeKind.Local).AddTicks(5528) },
                    { 10, new DateTime(2023, 1, 22, 0, 7, 26, 988, DateTimeKind.Local).AddTicks(6786), "Eveniet doloremque r", 4, "Incredible Cotton Computer", new DateTime(2022, 4, 12, 11, 9, 11, 392, DateTimeKind.Local).AddTicks(6302) },
                    { 11, new DateTime(2022, 12, 11, 18, 27, 29, 607, DateTimeKind.Local).AddTicks(6106), "Dolorem perferendis ", 4, "Unbranded Cotton Car", new DateTime(2022, 10, 9, 16, 38, 15, 761, DateTimeKind.Local).AddTicks(9670) },
                    { 12, new DateTime(2022, 2, 23, 3, 4, 58, 747, DateTimeKind.Local).AddTicks(6650), "Corrupti ratione dic", 4, "Unbranded Fresh Shirt", new DateTime(2022, 12, 11, 0, 16, 38, 311, DateTimeKind.Local).AddTicks(219) },
                    { 13, new DateTime(2022, 9, 12, 16, 48, 43, 715, DateTimeKind.Local).AddTicks(9596), "Eum officiis est in ", 5, "Incredible Soft Keyboard", new DateTime(2022, 7, 22, 22, 4, 59, 635, DateTimeKind.Local).AddTicks(7596) },
                    { 14, new DateTime(2023, 1, 4, 0, 46, 52, 315, DateTimeKind.Local).AddTicks(4887), "Voluptate reiciendis", 4, "Awesome Concrete Sausages", new DateTime(2022, 2, 21, 12, 9, 16, 615, DateTimeKind.Local).AddTicks(1350) },
                    { 15, new DateTime(2023, 1, 12, 19, 51, 49, 513, DateTimeKind.Local).AddTicks(7110), "Eaque ipsam non inci", 3, "Licensed Concrete Tuna", new DateTime(2022, 5, 31, 0, 15, 21, 902, DateTimeKind.Local).AddTicks(4200) },
                    { 16, new DateTime(2022, 3, 17, 11, 3, 35, 24, DateTimeKind.Local).AddTicks(856), "Adipisci quos autem ", 3, "Gorgeous Rubber Shoes", new DateTime(2022, 5, 1, 20, 48, 6, 159, DateTimeKind.Local).AddTicks(5446) },
                    { 17, new DateTime(2022, 6, 11, 15, 24, 14, 656, DateTimeKind.Local).AddTicks(588), "Illum ea accusamus. ", 1, "Incredible Wooden Keyboard", new DateTime(2023, 1, 23, 1, 41, 30, 510, DateTimeKind.Local).AddTicks(7336) },
                    { 18, new DateTime(2022, 3, 29, 7, 26, 5, 498, DateTimeKind.Local).AddTicks(2714), "Dignissimos necessit", 2, "Fantastic Fresh Gloves", new DateTime(2022, 2, 14, 21, 38, 23, 704, DateTimeKind.Local).AddTicks(5292) },
                    { 19, new DateTime(2022, 11, 7, 9, 59, 40, 364, DateTimeKind.Local).AddTicks(5627), "Dolor et dolorem et ", 5, "Ergonomic Wooden Pants", new DateTime(2022, 6, 12, 2, 10, 48, 667, DateTimeKind.Local).AddTicks(4980) },
                    { 20, new DateTime(2022, 3, 19, 2, 33, 48, 913, DateTimeKind.Local).AddTicks(6584), "Beatae corrupti aut ", 3, "Incredible Soft Cheese", new DateTime(2023, 1, 14, 15, 40, 43, 782, DateTimeKind.Local).AddTicks(1451) }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 12, 6, 31, 42, 47, DateTimeKind.Local).AddTicks(9996), "Sed quasi corrupti l", 1, "Awesome Soft Gloves", new DateTime(2022, 6, 29, 17, 24, 44, 999, DateTimeKind.Local).AddTicks(9641) },
                    { 2, new DateTime(2022, 3, 11, 6, 5, 16, 664, DateTimeKind.Local).AddTicks(7997), "Placeat sequi est. F", 7, "Small Plastic Computer", new DateTime(2022, 10, 25, 0, 41, 23, 373, DateTimeKind.Local).AddTicks(1426) },
                    { 3, new DateTime(2023, 1, 11, 17, 16, 43, 6, DateTimeKind.Local).AddTicks(5467), "Qui qui ad incidunt ", 10, "Fantastic Soft Cheese", new DateTime(2022, 12, 27, 11, 48, 59, 798, DateTimeKind.Local).AddTicks(7429) },
                    { 4, new DateTime(2022, 8, 29, 19, 3, 24, 425, DateTimeKind.Local).AddTicks(3637), "Dolores eaque quasi ", 16, "Unbranded Plastic Cheese", new DateTime(2022, 6, 20, 6, 21, 25, 125, DateTimeKind.Local).AddTicks(8584) },
                    { 5, new DateTime(2022, 9, 3, 17, 39, 35, 749, DateTimeKind.Local).AddTicks(5689), "Illum omnis tempore ", 15, "Refined Frozen Chair", new DateTime(2022, 12, 28, 14, 28, 21, 388, DateTimeKind.Local).AddTicks(644) },
                    { 6, new DateTime(2022, 4, 13, 22, 13, 24, 425, DateTimeKind.Local).AddTicks(2299), "Quasi voluptate quia", 12, "Fantastic Cotton Shoes", new DateTime(2023, 1, 7, 16, 57, 27, 961, DateTimeKind.Local).AddTicks(8249) },
                    { 7, new DateTime(2022, 8, 27, 6, 32, 2, 296, DateTimeKind.Local).AddTicks(5951), "Quo facilis maxime p", 10, "Incredible Rubber Keyboard", new DateTime(2022, 3, 20, 6, 2, 46, 806, DateTimeKind.Local).AddTicks(6494) },
                    { 8, new DateTime(2022, 10, 2, 10, 37, 2, 867, DateTimeKind.Local).AddTicks(4773), "Nulla ut quia. Et su", 5, "Unbranded Steel Hat", new DateTime(2022, 7, 14, 10, 51, 57, 265, DateTimeKind.Local).AddTicks(6524) },
                    { 9, new DateTime(2022, 11, 27, 12, 52, 31, 81, DateTimeKind.Local).AddTicks(7363), "Aliquam est exceptur", 10, "Small Cotton Shoes", new DateTime(2022, 4, 27, 7, 34, 28, 250, DateTimeKind.Local).AddTicks(745) },
                    { 10, new DateTime(2022, 10, 31, 21, 54, 54, 339, DateTimeKind.Local).AddTicks(994), "Dolores officiis pro", 15, "Handmade Soft Salad", new DateTime(2022, 2, 21, 10, 4, 4, 960, DateTimeKind.Local).AddTicks(5451) },
                    { 11, new DateTime(2022, 7, 19, 21, 13, 45, 904, DateTimeKind.Local).AddTicks(2734), "Eligendi aliquam exc", 20, "Ergonomic Steel Gloves", new DateTime(2022, 3, 27, 9, 7, 2, 197, DateTimeKind.Local).AddTicks(2506) },
                    { 12, new DateTime(2022, 9, 12, 23, 25, 42, 758, DateTimeKind.Local).AddTicks(7761), "Ut voluptates distin", 16, "Sleek Metal Mouse", new DateTime(2023, 1, 25, 6, 53, 14, 421, DateTimeKind.Local).AddTicks(550) },
                    { 13, new DateTime(2022, 5, 8, 0, 51, 39, 634, DateTimeKind.Local).AddTicks(1467), "Numquam pariatur eaq", 11, "Ergonomic Concrete Chair", new DateTime(2022, 12, 8, 19, 20, 22, 346, DateTimeKind.Local).AddTicks(9203) },
                    { 14, new DateTime(2022, 3, 25, 23, 34, 23, 238, DateTimeKind.Local).AddTicks(899), "Dolore nam eligendi ", 5, "Fantastic Plastic Hat", new DateTime(2022, 3, 5, 21, 26, 19, 733, DateTimeKind.Local).AddTicks(9501) },
                    { 15, new DateTime(2022, 11, 2, 8, 43, 4, 237, DateTimeKind.Local).AddTicks(7392), "Unde non ut voluptat", 14, "Fantastic Cotton Towels", new DateTime(2022, 7, 30, 23, 38, 3, 373, DateTimeKind.Local).AddTicks(6188) },
                    { 16, new DateTime(2022, 11, 14, 9, 41, 41, 714, DateTimeKind.Local).AddTicks(8732), "Inventore quibusdam ", 12, "Awesome Fresh Ball", new DateTime(2022, 7, 6, 21, 41, 34, 799, DateTimeKind.Local).AddTicks(8542) },
                    { 17, new DateTime(2022, 10, 21, 22, 49, 18, 745, DateTimeKind.Local).AddTicks(3024), "Occaecati voluptatib", 3, "Tasty Wooden Soap", new DateTime(2022, 6, 12, 16, 35, 18, 507, DateTimeKind.Local).AddTicks(8655) },
                    { 18, new DateTime(2022, 9, 6, 1, 6, 11, 139, DateTimeKind.Local).AddTicks(8264), "Vel cupiditate exped", 9, "Rustic Fresh Car", new DateTime(2022, 3, 13, 6, 26, 0, 195, DateTimeKind.Local).AddTicks(758) },
                    { 19, new DateTime(2022, 5, 22, 23, 8, 23, 895, DateTimeKind.Local).AddTicks(6964), "Recusandae quos impe", 3, "Handcrafted Soft Computer", new DateTime(2023, 2, 4, 6, 16, 16, 427, DateTimeKind.Local).AddTicks(5806) },
                    { 20, new DateTime(2022, 3, 7, 19, 0, 17, 514, DateTimeKind.Local).AddTicks(7539), "Aut aut voluptatem r", 10, "Tasty Concrete Pizza", new DateTime(2022, 11, 23, 16, 37, 27, 221, DateTimeKind.Local).AddTicks(538) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_ProjectId",
                table: "Assignments",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_OwnerId",
                table: "Projects",
                column: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
