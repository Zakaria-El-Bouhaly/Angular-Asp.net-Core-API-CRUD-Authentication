using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Colab.Migrations
{
    /// <inheritdoc />
    public partial class thismysql : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    Password = table.Column<string>(type: "longtext", nullable: false),
                    IsAdmin = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
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
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProjectUser",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsOwner = table.Column<bool>(type: "tinyint(1)", nullable: false)
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
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 8, 11, 22, 1, 4, DateTimeKind.Local).AddTicks(8979), "Alias saepe corporis", "Refined Frozen Table", new DateTime(2022, 5, 24, 13, 18, 52, 264, DateTimeKind.Local).AddTicks(3679) },
                    { 2, new DateTime(2022, 7, 21, 5, 49, 24, 806, DateTimeKind.Local).AddTicks(7642), "Laudantium quia plac", "Intelligent Concrete Computer", new DateTime(2022, 7, 27, 12, 30, 9, 28, DateTimeKind.Local).AddTicks(875) },
                    { 3, new DateTime(2022, 5, 30, 19, 12, 7, 581, DateTimeKind.Local).AddTicks(2126), "Maiores repudiandae ", "Practical Cotton Towels", new DateTime(2022, 4, 4, 15, 45, 36, 13, DateTimeKind.Local).AddTicks(1792) },
                    { 4, new DateTime(2022, 11, 5, 19, 25, 29, 986, DateTimeKind.Local).AddTicks(115), "Officia eius cum hic", "Ergonomic Steel Car", new DateTime(2022, 5, 22, 13, 35, 15, 312, DateTimeKind.Local).AddTicks(3449) },
                    { 5, new DateTime(2022, 8, 19, 20, 19, 52, 944, DateTimeKind.Local).AddTicks(6809), "Accusantium iusto ve", "Unbranded Plastic Chips", new DateTime(2022, 12, 19, 21, 20, 46, 360, DateTimeKind.Local).AddTicks(4752) },
                    { 6, new DateTime(2022, 4, 22, 18, 57, 31, 589, DateTimeKind.Local).AddTicks(5498), "Placeat adipisci ear", "Fantastic Frozen Salad", new DateTime(2022, 11, 20, 2, 32, 16, 131, DateTimeKind.Local).AddTicks(9004) },
                    { 7, new DateTime(2022, 6, 23, 16, 54, 29, 396, DateTimeKind.Local).AddTicks(8883), "Et quia odit autem e", "Fantastic Metal Computer", new DateTime(2022, 10, 19, 22, 48, 19, 481, DateTimeKind.Local).AddTicks(6089) },
                    { 8, new DateTime(2022, 12, 2, 10, 28, 31, 532, DateTimeKind.Local).AddTicks(3789), "Magnam reiciendis et", "Rustic Steel Keyboard", new DateTime(2023, 2, 23, 17, 25, 7, 727, DateTimeKind.Local).AddTicks(3465) },
                    { 9, new DateTime(2022, 4, 4, 6, 1, 53, 451, DateTimeKind.Local).AddTicks(2049), "Ullam culpa voluptat", "Licensed Cotton Computer", new DateTime(2023, 3, 13, 2, 52, 10, 507, DateTimeKind.Local).AddTicks(2081) },
                    { 10, new DateTime(2022, 11, 8, 17, 32, 14, 162, DateTimeKind.Local).AddTicks(3555), "Nesciunt consequatur", "Practical Concrete Chair", new DateTime(2022, 11, 22, 1, 9, 14, 211, DateTimeKind.Local).AddTicks(1009) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsAdmin", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "Dameon.Crona@gmail.com", false, "Alvis Mayert", "rh57Up58LO" },
                    { 2, "Juliet.Treutel@hotmail.com", false, "Karine Brakus", "X8VDFlVAQ1" },
                    { 3, "Jed_Gottlieb59@hotmail.com", false, "Shyann Nitzsche", "V5Y6FN4BfK" },
                    { 4, "Archibald30@hotmail.com", false, "Benny Krajcik", "qmSPLufyWY" },
                    { 5, "Cassandre_OReilly@hotmail.com", false, "Jalen Renner", "uBsLFvj7vM" }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 24, 12, 0, 10, 847, DateTimeKind.Local).AddTicks(3247), "Eos quod et dolores ", false, 4, "Small Frozen Pants", new DateTime(2022, 5, 20, 21, 59, 42, 706, DateTimeKind.Local).AddTicks(7279) },
                    { 2, new DateTime(2023, 1, 16, 14, 24, 14, 382, DateTimeKind.Local).AddTicks(7778), "A error autem vel do", true, 2, "Small Concrete Fish", new DateTime(2023, 2, 8, 10, 40, 20, 44, DateTimeKind.Local).AddTicks(4031) },
                    { 3, new DateTime(2023, 2, 1, 16, 41, 12, 73, DateTimeKind.Local).AddTicks(734), "Commodi est aperiam ", true, 9, "Incredible Soft Car", new DateTime(2022, 11, 1, 8, 46, 16, 174, DateTimeKind.Local).AddTicks(3489) },
                    { 4, new DateTime(2023, 1, 28, 13, 55, 52, 771, DateTimeKind.Local).AddTicks(7339), "Ut voluptate qui cup", true, 1, "Rustic Metal Cheese", new DateTime(2022, 7, 17, 22, 17, 23, 639, DateTimeKind.Local).AddTicks(6881) },
                    { 5, new DateTime(2022, 6, 4, 2, 14, 56, 944, DateTimeKind.Local).AddTicks(4289), "Delectus voluptatum ", false, 6, "Generic Concrete Salad", new DateTime(2022, 7, 31, 18, 57, 10, 845, DateTimeKind.Local).AddTicks(7501) },
                    { 6, new DateTime(2022, 4, 18, 23, 49, 54, 778, DateTimeKind.Local).AddTicks(1090), "Numquam non vitae ve", true, 10, "Sleek Plastic Chicken", new DateTime(2022, 12, 1, 3, 46, 16, 226, DateTimeKind.Local).AddTicks(4175) },
                    { 7, new DateTime(2023, 1, 23, 21, 42, 44, 789, DateTimeKind.Local).AddTicks(8429), "Consequatur quibusda", true, 2, "Gorgeous Steel Chicken", new DateTime(2023, 1, 9, 10, 33, 25, 395, DateTimeKind.Local).AddTicks(915) },
                    { 8, new DateTime(2022, 4, 15, 6, 5, 54, 555, DateTimeKind.Local).AddTicks(5254), "Et facere aut nesciu", true, 9, "Tasty Fresh Mouse", new DateTime(2022, 10, 1, 5, 6, 8, 747, DateTimeKind.Local).AddTicks(8236) },
                    { 9, new DateTime(2023, 2, 17, 1, 48, 25, 895, DateTimeKind.Local).AddTicks(4737), "Corrupti saepe tenet", true, 3, "Tasty Cotton Chicken", new DateTime(2022, 7, 9, 18, 15, 37, 116, DateTimeKind.Local).AddTicks(6995) },
                    { 10, new DateTime(2022, 4, 23, 5, 36, 24, 243, DateTimeKind.Local).AddTicks(284), "Dolorem illo officia", false, 6, "Generic Granite Chicken", new DateTime(2023, 3, 1, 7, 0, 44, 49, DateTimeKind.Local).AddTicks(5593) },
                    { 11, new DateTime(2023, 3, 31, 16, 31, 42, 166, DateTimeKind.Local).AddTicks(8658), "Sint iste repellendu", false, 6, "Handmade Soft Tuna", new DateTime(2022, 8, 27, 5, 43, 33, 545, DateTimeKind.Local).AddTicks(6507) },
                    { 12, new DateTime(2022, 6, 19, 9, 52, 34, 741, DateTimeKind.Local).AddTicks(1557), "Quia asperiores volu", false, 5, "Small Plastic Hat", new DateTime(2022, 10, 18, 16, 13, 14, 466, DateTimeKind.Local).AddTicks(3101) },
                    { 13, new DateTime(2022, 9, 13, 5, 38, 19, 641, DateTimeKind.Local).AddTicks(2807), "Quas ipsum iure dolo", false, 4, "Rustic Plastic Soap", new DateTime(2022, 5, 6, 15, 3, 31, 309, DateTimeKind.Local).AddTicks(7957) },
                    { 14, new DateTime(2022, 7, 3, 18, 42, 20, 739, DateTimeKind.Local).AddTicks(4853), "Consequatur quasi id", true, 2, "Incredible Soft Bacon", new DateTime(2023, 2, 1, 22, 50, 55, 551, DateTimeKind.Local).AddTicks(4133) },
                    { 15, new DateTime(2023, 1, 16, 21, 58, 29, 499, DateTimeKind.Local).AddTicks(4709), "Velit excepturi reru", false, 8, "Small Concrete Pants", new DateTime(2023, 3, 30, 3, 16, 6, 355, DateTimeKind.Local).AddTicks(7477) },
                    { 16, new DateTime(2022, 12, 10, 0, 11, 34, 662, DateTimeKind.Local).AddTicks(9044), "Nesciunt consequatur", true, 8, "Licensed Steel Keyboard", new DateTime(2022, 10, 9, 19, 14, 1, 514, DateTimeKind.Local).AddTicks(7354) },
                    { 17, new DateTime(2022, 11, 2, 7, 52, 47, 357, DateTimeKind.Local).AddTicks(3522), "Voluptate saepe corr", true, 9, "Handcrafted Fresh Sausages", new DateTime(2023, 2, 22, 3, 28, 29, 778, DateTimeKind.Local).AddTicks(8475) },
                    { 18, new DateTime(2022, 10, 6, 8, 58, 56, 466, DateTimeKind.Local).AddTicks(892), "Cupiditate at nobis ", true, 3, "Intelligent Soft Soap", new DateTime(2022, 10, 13, 16, 59, 19, 427, DateTimeKind.Local).AddTicks(3426) },
                    { 19, new DateTime(2022, 10, 25, 12, 53, 16, 359, DateTimeKind.Local).AddTicks(6027), "Eius et placeat accu", false, 2, "Awesome Concrete Gloves", new DateTime(2022, 5, 1, 4, 29, 21, 904, DateTimeKind.Local).AddTicks(7371) },
                    { 20, new DateTime(2022, 6, 27, 23, 5, 49, 154, DateTimeKind.Local).AddTicks(9369), "Ad recusandae iure s", false, 8, "Generic Frozen Fish", new DateTime(2022, 8, 25, 6, 51, 57, 44, DateTimeKind.Local).AddTicks(1782) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_ProjectId",
                table: "Assignments",
                column: "ProjectId");

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
                name: "ProjectUser");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
