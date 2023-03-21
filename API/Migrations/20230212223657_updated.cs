using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Colab.Migrations
{
    /// <inheritdoc />
    public partial class updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProjectUser",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 25, 13, 5, 24, 201, DateTimeKind.Local).AddTicks(4805), "Corrupti nesciunt qu", 6, "Licensed Fresh Towels", new DateTime(2022, 9, 1, 22, 42, 18, 876, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 24, 19, 48, 23, 596, DateTimeKind.Local).AddTicks(740), "Nemo et nihil odio q", 2, "Ergonomic Frozen Fish", new DateTime(2022, 5, 9, 1, 44, 53, 590, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 23, 10, 53, 53, 102, DateTimeKind.Local).AddTicks(6710), "Ducimus quasi sit om", 6, "Intelligent Metal Sausages", new DateTime(2023, 1, 19, 20, 50, 34, 244, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 11, 3, 22, 26, 296, DateTimeKind.Local).AddTicks(1567), "Fuga illum necessita", 8, "Sleek Wooden Cheese", new DateTime(2022, 8, 31, 14, 10, 7, 418, DateTimeKind.Local).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 20, 12, 55, 27, 510, DateTimeKind.Local).AddTicks(8187), "Iure iusto rem tempo", 5, "Generic Fresh Gloves", new DateTime(2022, 9, 1, 13, 28, 3, 466, DateTimeKind.Local).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 9, 15, 25, 509, DateTimeKind.Local).AddTicks(4080), "Sequi sapiente aut o", 9, "Handcrafted Soft Table", new DateTime(2022, 8, 19, 23, 23, 42, 703, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 30, 1, 22, 42, 363, DateTimeKind.Local).AddTicks(356), "Repellendus ut et qu", 4, "Rustic Plastic Sausages", new DateTime(2022, 3, 27, 3, 42, 0, 426, DateTimeKind.Local).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 22, 21, 0, 19, 391, DateTimeKind.Local).AddTicks(4373), "Sit tempore incidunt", 9, "Fantastic Granite Pants", new DateTime(2022, 4, 17, 6, 22, 8, 393, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 9, 19, 38, 28, 353, DateTimeKind.Local).AddTicks(701), "Et illum nemo laudan", 1, "Practical Steel Tuna", new DateTime(2022, 3, 13, 21, 47, 6, 585, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 8, 0, 51, 38, 108, DateTimeKind.Local).AddTicks(258), "Repudiandae quaerat ", 7, "Tasty Cotton Tuna", new DateTime(2022, 9, 4, 6, 28, 12, 944, DateTimeKind.Local).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 27, 10, 53, 4, 698, DateTimeKind.Local).AddTicks(1940), "Quod consequatur rep", 2, "Generic Wooden Mouse", new DateTime(2022, 8, 16, 20, 12, 41, 928, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 30, 18, 39, 49, 799, DateTimeKind.Local).AddTicks(4991), "Repudiandae dolorum ", "Handmade Frozen Mouse", new DateTime(2022, 11, 10, 11, 51, 8, 830, DateTimeKind.Local).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 19, 15, 9, 14, 895, DateTimeKind.Local).AddTicks(1211), "Nulla et rerum enim ", 2, "Refined Cotton Shoes", new DateTime(2022, 4, 29, 2, 16, 56, 883, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 11, 17, 43, 44, 525, DateTimeKind.Local).AddTicks(7612), "Quo pariatur illo qu", "Generic Steel Table", new DateTime(2023, 1, 16, 11, 20, 45, 101, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 2, 20, 1, 26, 33, 323, DateTimeKind.Local).AddTicks(5722), "Dolorem quisquam qua", 2, "Awesome Metal Shoes", new DateTime(2023, 1, 16, 23, 18, 33, 345, DateTimeKind.Local).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 16, 2, 53, 32, 920, DateTimeKind.Local).AddTicks(4183), "Aliquam similique of", "Fantastic Wooden Cheese", new DateTime(2022, 3, 25, 8, 59, 24, 276, DateTimeKind.Local).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 12, 11, 55, 9, 197, DateTimeKind.Local).AddTicks(9428), "Ullam maiores assume", "Handcrafted Plastic Shoes", new DateTime(2022, 5, 23, 5, 12, 8, 887, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 2, 17, 8, 51, 15, 156, DateTimeKind.Local).AddTicks(2995), "Quo asperiores ullam", 5, "Ergonomic Plastic Bike", new DateTime(2022, 9, 24, 12, 55, 11, 649, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 20, 1, 53, 50, 573, DateTimeKind.Local).AddTicks(8230), "Vero saepe et. Quis ", 3, "Unbranded Cotton Gloves", new DateTime(2022, 4, 1, 2, 19, 13, 998, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 16, 22, 41, 42, 651, DateTimeKind.Local).AddTicks(9659), "Sapiente eos non qui", 5, "Tasty Fresh Bike", new DateTime(2022, 8, 16, 2, 32, 50, 732, DateTimeKind.Local).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Password", "RoleId" },
                values: new object[] { "Kenton_Hansen85@yahoo.com", "Eileen Streich", "W4h2EeVDro", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password", "RoleId" },
                values: new object[] { "Mattie65@yahoo.com", "Deja Ruecker", "6V6UMbK9kP", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Password", "RoleId" },
                values: new object[] { "Nyah_Nolan@yahoo.com", "Unique Glover", "ZJhl3U9nxH", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Password", "RoleId" },
                values: new object[] { "Providenci17@gmail.com", "Blair Romaguera", "dhDdWownGW", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Password", "RoleId" },
                values: new object[] { "Stan_Jenkins71@yahoo.com", "Kali Lakin", "Z5uuJOTjcy", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_UserId",
                table: "ProjectUser",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectUser");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 5, 0, 48, 10, 944, DateTimeKind.Local).AddTicks(337), "Rerum consectetur et", 3, "Small Wooden Computer", new DateTime(2022, 4, 20, 10, 30, 2, 676, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 21, 8, 53, 42, 820, DateTimeKind.Local).AddTicks(4521), "Sunt voluptas debiti", 3, "Tasty Frozen Salad", new DateTime(2023, 1, 10, 11, 30, 56, 711, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 31, 12, 29, 45, 102, DateTimeKind.Local).AddTicks(1875), "Et vero at fugit sin", 3, "Sleek Fresh Pants", new DateTime(2022, 11, 26, 7, 6, 47, 653, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 19, 5, 26, 2, 996, DateTimeKind.Local).AddTicks(9641), "Quod veniam in rerum", 3, "Incredible Cotton Shirt", new DateTime(2022, 8, 14, 19, 43, 56, 878, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 13, 1, 49, 12, 567, DateTimeKind.Local).AddTicks(9648), "Sit nesciunt velit i", 4, "Intelligent Concrete Pizza", new DateTime(2023, 1, 29, 13, 7, 57, 149, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 26, 0, 38, 20, 16, DateTimeKind.Local).AddTicks(9010), "Expedita dignissimos", 6, "Sleek Fresh Soap", new DateTime(2023, 1, 14, 12, 37, 23, 259, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 30, 18, 9, 18, 393, DateTimeKind.Local).AddTicks(9404), "Aspernatur ipsa volu", 8, "Unbranded Granite Salad", new DateTime(2022, 6, 26, 2, 37, 58, 355, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 28, 13, 16, 34, 926, DateTimeKind.Local).AddTicks(3090), "Nihil non ut non nes", 6, "Tasty Cotton Pants", new DateTime(2022, 4, 15, 1, 35, 0, 33, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 28, 10, 31, 5, 745, DateTimeKind.Local).AddTicks(6319), "Molestiae nemo accus", 6, "Handcrafted Fresh Soap", new DateTime(2023, 1, 9, 14, 51, 8, 715, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 31, 8, 58, 56, 926, DateTimeKind.Local).AddTicks(1939), "Sit quas voluptatibu", 10, "Fantastic Metal Bike", new DateTime(2022, 10, 3, 21, 12, 45, 64, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 2, 19, 3, 56, 34, 524, DateTimeKind.Local).AddTicks(9791), "Sed necessitatibus t", 3, "Gorgeous Metal Chips", new DateTime(2022, 5, 1, 10, 14, 38, 498, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 2, 9, 38, 14, 189, DateTimeKind.Local).AddTicks(4978), "Aut accusamus vitae ", "Handmade Cotton Gloves", new DateTime(2022, 3, 21, 6, 42, 27, 705, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 23, 31, 48, 572, DateTimeKind.Local).AddTicks(4917), "Ut soluta eligendi r", 3, "Small Rubber Tuna", new DateTime(2022, 6, 14, 8, 10, 19, 42, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 0, 12, 22, 114, DateTimeKind.Local).AddTicks(3990), "Ut autem explicabo u", "Intelligent Rubber Ball", new DateTime(2022, 8, 4, 23, 36, 9, 168, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 5, 6, 19, 51, 501, DateTimeKind.Local).AddTicks(1061), "Ut illo rerum. Ipsa ", 3, "Refined Rubber Cheese", new DateTime(2022, 3, 28, 4, 58, 10, 770, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 22, 5, 53, 18, 632, DateTimeKind.Local).AddTicks(1248), "Natus esse eius quis", "Generic Fresh Salad", new DateTime(2023, 1, 16, 21, 13, 37, 931, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 26, 16, 16, 15, 855, DateTimeKind.Local).AddTicks(3557), "Suscipit temporibus ", "Rustic Granite Chips", new DateTime(2022, 2, 16, 9, 6, 4, 768, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 15, 23, 57, 51, 547, DateTimeKind.Local).AddTicks(2615), "Voluptas ut ullam. C", 3, "Gorgeous Plastic Pizza", new DateTime(2022, 4, 26, 11, 55, 47, 84, DateTimeKind.Local).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 13, 8, 47, 38, 518, DateTimeKind.Local).AddTicks(5919), "Autem est non. Porro", 1, "Refined Wooden Sausages", new DateTime(2023, 1, 31, 3, 14, 35, 419, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 41, 5, 331, DateTimeKind.Local).AddTicks(6496), "Molestiae dolorum do", 1, "Tasty Steel Salad", new DateTime(2022, 8, 30, 13, 27, 8, 456, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Eloise3@gmail.com", "Natasha Roberts", "5y7mOr7KgO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Caterina_Kuvalis@gmail.com", "Janet Weber", "saCj8vLPpB" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Kristoffer.Nikolaus@gmail.com", "Arthur DuBuque", "XNrm9_0FZR" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Katlyn_Mosciski21@hotmail.com", "Audra Klocko", "bwM3bEu0HE" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Ricardo31@gmail.com", "Golda Dietrich", "p6AOsPIdYc" });
        }
    }
}
