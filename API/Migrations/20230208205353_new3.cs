using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Colab.Migrations
{
    /// <inheritdoc />
    public partial class new3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Projects_ProjectId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Projects",
                newName: "ownerId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                newName: "IX_Projects_ownerId");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Assignments",
                newName: "ProjectRefId");

            migrationBuilder.RenameIndex(
                name: "IX_Assignments_ProjectId",
                table: "Assignments",
                newName: "IX_Assignments_ProjectRefId");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 7, 14, 38, 12, 404, DateTimeKind.Local).AddTicks(483), "Ea voluptas dolor po", 2, "Handcrafted Wooden Towels", new DateTime(2022, 8, 24, 5, 39, 53, 332, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 21, 8, 13, 23, 90, DateTimeKind.Local).AddTicks(5948), "Sed eaque sint et te", 2, "Gorgeous Concrete Bacon", new DateTime(2022, 8, 28, 16, 15, 16, 870, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 21, 22, 58, 36, 572, DateTimeKind.Local).AddTicks(3573), "Eos magni quibusdam ", 4, "Sleek Cotton Shoes", new DateTime(2022, 12, 7, 12, 56, 46, 249, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 40, 38, 87, DateTimeKind.Local).AddTicks(5837), "Nulla qui illum tene", 4, "Gorgeous Granite Gloves", new DateTime(2022, 4, 1, 17, 58, 8, 138, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 7, 3, 52, 5, 442, DateTimeKind.Local).AddTicks(5640), "Vel temporibus ea. C", "Awesome Cotton Sausages", new DateTime(2022, 8, 10, 1, 38, 33, 274, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 10, 6, 34, 160, DateTimeKind.Local).AddTicks(9545), "Error laudantium por", 3, "Refined Rubber Hat", new DateTime(2022, 6, 5, 7, 39, 54, 260, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 9, 14, 9, 21, 438, DateTimeKind.Local).AddTicks(760), "Quaerat non perspici", 7, "Ergonomic Wooden Shoes", new DateTime(2022, 6, 11, 23, 34, 38, 127, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 14, 17, 21, 5, 604, DateTimeKind.Local).AddTicks(1754), "Aut quas sint et est", 7, "Fantastic Granite Ball", new DateTime(2022, 10, 21, 23, 29, 14, 928, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 2, 22, 50, 32, 176, DateTimeKind.Local).AddTicks(7771), "Explicabo nesciunt b", "Intelligent Wooden Car", new DateTime(2023, 1, 24, 23, 5, 23, 616, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 22, 17, 59, 47, 364, DateTimeKind.Local).AddTicks(9117), "Doloribus molestiae ", 4, "Rustic Wooden Bike", new DateTime(2022, 7, 22, 22, 38, 59, 702, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 11, 3, 29, 22, 831, DateTimeKind.Local).AddTicks(5820), "Reprehenderit nemo e", "Small Soft Shirt", new DateTime(2023, 2, 5, 15, 2, 55, 783, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "ownerId" },
                values: new object[] { new DateTime(2023, 1, 3, 19, 7, 52, 135, DateTimeKind.Local).AddTicks(2534), "Id optio sunt earum.", "Handcrafted Metal Bacon", new DateTime(2023, 2, 5, 0, 39, 47, 986, DateTimeKind.Local).AddTicks(5994), 4 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "ownerId" },
                values: new object[] { new DateTime(2022, 8, 25, 1, 51, 27, 728, DateTimeKind.Local).AddTicks(6937), "Minus velit facere d", "Refined Rubber Sausages", new DateTime(2022, 7, 22, 1, 7, 22, 957, DateTimeKind.Local).AddTicks(4670), 3 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "ownerId" },
                values: new object[] { new DateTime(2023, 1, 15, 8, 59, 48, 508, DateTimeKind.Local).AddTicks(662), "Quia et ut animi fac", "Awesome Rubber Shirt", new DateTime(2022, 11, 26, 21, 46, 53, 247, DateTimeKind.Local).AddTicks(4449), 1 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 30, 8, 33, 41, 476, DateTimeKind.Local).AddTicks(6677), "Incidunt est sunt co", "Generic Metal Keyboard", new DateTime(2022, 3, 11, 22, 20, 11, 456, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "ownerId" },
                values: new object[] { new DateTime(2022, 5, 12, 6, 54, 50, 970, DateTimeKind.Local).AddTicks(1784), "Culpa et molestiae i", "Intelligent Steel Table", new DateTime(2022, 3, 25, 14, 38, 19, 422, DateTimeKind.Local).AddTicks(6014), 4 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 16, 4, 17, 41, 466, DateTimeKind.Local).AddTicks(737), "Corporis omnis volup", "Generic Frozen Mouse", new DateTime(2023, 1, 23, 8, 26, 52, 755, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "ownerId" },
                values: new object[] { new DateTime(2022, 6, 18, 15, 30, 1, 110, DateTimeKind.Local).AddTicks(7201), "Occaecati voluptatib", "Awesome Steel Salad", new DateTime(2022, 7, 30, 19, 4, 48, 584, DateTimeKind.Local).AddTicks(1216), 4 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "ownerId" },
                values: new object[] { new DateTime(2022, 5, 30, 19, 27, 55, 131, DateTimeKind.Local).AddTicks(2908), "Molestias autem erro", "Handcrafted Frozen Chicken", new DateTime(2022, 11, 4, 23, 50, 1, 85, DateTimeKind.Local).AddTicks(7353), 4 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 11, 4, 20, 16, 965, DateTimeKind.Local).AddTicks(5285), "Repellat quod ipsam ", "Ergonomic Concrete Bike", new DateTime(2022, 8, 21, 1, 32, 30, 168, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Alfred51@yahoo.com", "Florence Crona", "mBFlK5WhSb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Garnet3@yahoo.com", "Kieran Schowalter", "YbIYHeN6DD" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Crystal_Runte@gmail.com", "Alfred Grant", "6VNhGVBWB_" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Domenico34@yahoo.com", "Caroline Hoeger", "OLwykXljuE" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Matilde29@gmail.com", "Neoma Torphy", "HzhKEqL5bK" });

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Projects_ProjectRefId",
                table: "Assignments",
                column: "ProjectRefId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_ownerId",
                table: "Projects",
                column: "ownerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Projects_ProjectRefId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_ownerId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "ownerId",
                table: "Projects",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_ownerId",
                table: "Projects",
                newName: "IX_Projects_UserId");

            migrationBuilder.RenameColumn(
                name: "ProjectRefId",
                table: "Assignments",
                newName: "ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Assignments_ProjectRefId",
                table: "Assignments",
                newName: "IX_Assignments_ProjectId");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 15, 1, 32, 7, 451, DateTimeKind.Local).AddTicks(9713), "Quia quia reiciendis", 10, "Ergonomic Granite Computer", new DateTime(2022, 10, 30, 9, 35, 22, 96, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 9, 46, 24, 325, DateTimeKind.Local).AddTicks(3690), "Quia neque officiis ", 7, "Generic Soft Soap", new DateTime(2022, 8, 26, 8, 51, 35, 400, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 2, 28, 2, 25, 5, 577, DateTimeKind.Local).AddTicks(1377), "Voluptas earum nostr", 7, "Handcrafted Plastic Ball", new DateTime(2022, 2, 21, 0, 2, 29, 120, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 5, 18, 51, 57, 972, DateTimeKind.Local).AddTicks(3001), "Harum totam sint et ", 10, "Generic Cotton Towels", new DateTime(2022, 5, 10, 15, 21, 29, 795, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 8, 9, 16, 13, 900, DateTimeKind.Local).AddTicks(5420), "Earum voluptates nih", "Sleek Concrete Keyboard", new DateTime(2022, 5, 11, 3, 20, 43, 921, DateTimeKind.Local).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 19, 4, 11, 17, 198, DateTimeKind.Local).AddTicks(5763), "Sint dolorum rerum d", 7, "Fantastic Granite Hat", new DateTime(2022, 9, 11, 5, 0, 2, 961, DateTimeKind.Local).AddTicks(8507) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 38, 41, 464, DateTimeKind.Local).AddTicks(119), "Sit amet vitae qui s", 8, "Licensed Cotton Keyboard", new DateTime(2022, 4, 21, 12, 48, 43, 740, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 17, 5, 17, 47, 231, DateTimeKind.Local).AddTicks(6557), "Excepturi qui volupt", 5, "Refined Soft Towels", new DateTime(2022, 10, 16, 16, 35, 29, 385, DateTimeKind.Local).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 21, 1, 51, 25, 414, DateTimeKind.Local).AddTicks(6637), "Ea eligendi vitae po", "Practical Concrete Towels", new DateTime(2022, 9, 20, 2, 24, 3, 99, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 11, 22, 49, 20, 891, DateTimeKind.Local).AddTicks(9436), "Ipsum porro rem nemo", 9, "Small Metal Sausages", new DateTime(2023, 2, 5, 21, 49, 28, 395, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 17, 7, 26, 4, 71, DateTimeKind.Local).AddTicks(5693), "Rerum aut numquam au", "Tasty Steel Ball", new DateTime(2022, 4, 18, 6, 1, 46, 230, DateTimeKind.Local).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 5, 12, 17, 2, 1, 156, DateTimeKind.Local).AddTicks(6236), "Ullam numquam eos al", "Practical Plastic Computer", new DateTime(2023, 1, 13, 7, 7, 23, 82, DateTimeKind.Local).AddTicks(2059), 2 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 11, 26, 3, 41, 14, 669, DateTimeKind.Local).AddTicks(9908), "Neque quisquam aperi", "Generic Rubber Car", new DateTime(2022, 2, 13, 19, 48, 36, 169, DateTimeKind.Local).AddTicks(2440), 5 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 3, 15, 13, 29, 19, 341, DateTimeKind.Local).AddTicks(976), "Vel est rerum volupt", "Handmade Wooden Bike", new DateTime(2022, 2, 9, 3, 25, 34, 268, DateTimeKind.Local).AddTicks(4262), 4 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 14, 12, 5, 132, DateTimeKind.Local).AddTicks(9030), "Doloribus cupiditate", "Practical Concrete Chicken", new DateTime(2022, 8, 1, 19, 13, 7, 764, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 7, 19, 12, 47, 23, 744, DateTimeKind.Local).AddTicks(1761), "Corporis consequatur", "Ergonomic Cotton Gloves", new DateTime(2022, 7, 9, 7, 54, 30, 500, DateTimeKind.Local).AddTicks(9044), 3 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 14, 11, 49, 32, 263, DateTimeKind.Local).AddTicks(7806), "Officiis qui expedit", "Small Soft Pants", new DateTime(2022, 6, 7, 23, 19, 20, 582, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 1, 2, 22, 57, 18, 379, DateTimeKind.Local).AddTicks(4088), "Sit est vel omnis vo", "Licensed Concrete Ball", new DateTime(2022, 5, 17, 21, 14, 53, 973, DateTimeKind.Local).AddTicks(1001), 2 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 4, 26, 13, 30, 32, 701, DateTimeKind.Local).AddTicks(114), "Culpa ipsam itaque h", "Awesome Concrete Chips", new DateTime(2022, 12, 21, 23, 3, 38, 55, DateTimeKind.Local).AddTicks(2041), 2 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 29, 4, 14, 15, 461, DateTimeKind.Local).AddTicks(7205), "Illum itaque dicta e", "Intelligent Fresh Gloves", new DateTime(2022, 10, 31, 16, 21, 16, 306, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Mireya27@gmail.com", "Karlie McCullough", "lZB6oTopUG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Vallie_Schmeler@yahoo.com", "Allene Yost", "8kLpXdsBDi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Loma_Schaden@yahoo.com", "Dariana Casper", "Yh1OYoWmxA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Nathen45@gmail.com", "Kelton Tromp", "sbASngRG6b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Darwin.Von33@gmail.com", "Jada Dietrich", "4Cx1VsE9gh" });

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Projects_ProjectId",
                table: "Assignments",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
