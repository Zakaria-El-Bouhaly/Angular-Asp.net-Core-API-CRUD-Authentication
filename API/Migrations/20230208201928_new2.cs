using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Colab.Migrations
{
    /// <inheritdoc />
    public partial class new2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Projects");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Projects",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

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
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 8, 9, 16, 13, 900, DateTimeKind.Local).AddTicks(5420), "Earum voluptates nih", 4, "Sleek Concrete Keyboard", new DateTime(2022, 5, 11, 3, 20, 43, 921, DateTimeKind.Local).AddTicks(9428) });

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
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 21, 1, 51, 25, 414, DateTimeKind.Local).AddTicks(6637), "Ea eligendi vitae po", 10, "Practical Concrete Towels", new DateTime(2022, 9, 20, 2, 24, 3, 99, DateTimeKind.Local).AddTicks(19) });

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
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 3, 17, 7, 26, 4, 71, DateTimeKind.Local).AddTicks(5693), "Rerum aut numquam au", "Tasty Steel Ball", new DateTime(2022, 4, 18, 6, 1, 46, 230, DateTimeKind.Local).AddTicks(204), 1 });

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
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 11, 18, 14, 12, 5, 132, DateTimeKind.Local).AddTicks(9030), "Doloribus cupiditate", "Practical Concrete Chicken", new DateTime(2022, 8, 1, 19, 13, 7, 764, DateTimeKind.Local).AddTicks(8805), 1 });

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
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 12, 14, 11, 49, 32, 263, DateTimeKind.Local).AddTicks(7806), "Officiis qui expedit", "Small Soft Pants", new DateTime(2022, 6, 7, 23, 19, 20, 582, DateTimeKind.Local).AddTicks(9029), 3 });

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
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 7, 29, 4, 14, 15, 461, DateTimeKind.Local).AddTicks(7205), "Illum itaque dicta e", "Intelligent Fresh Gloves", new DateTime(2022, 10, 31, 16, 21, 16, 306, DateTimeKind.Local).AddTicks(9811), 1 });

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
                name: "FK_Projects_Users_UserId",
                table: "Projects",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Projects",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Projects",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 14, 0, 40, 498, DateTimeKind.Local).AddTicks(5276), "Repudiandae doloremq", 3, "Handmade Fresh Shirt", new DateTime(2022, 5, 10, 3, 56, 40, 792, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 8, 19, 4, 58, 873, DateTimeKind.Local).AddTicks(924), "Ratione officia dese", 14, "Licensed Wooden Shirt", new DateTime(2022, 2, 18, 12, 47, 20, 979, DateTimeKind.Local).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 17, 11, 33, 49, 625, DateTimeKind.Local).AddTicks(6837), "Excepturi accusamus ", 8, "Gorgeous Plastic Chicken", new DateTime(2023, 1, 12, 7, 4, 33, 685, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 2, 25, 12, 13, 45, 470, DateTimeKind.Local).AddTicks(3122), "Corrupti ipsum ipsam", 12, "Sleek Steel Keyboard", new DateTime(2022, 10, 13, 7, 52, 1, 394, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 17, 11, 50, 52, 93, DateTimeKind.Local).AddTicks(362), "Voluptates sequi per", 20, "Ergonomic Granite Ball", new DateTime(2022, 6, 5, 5, 16, 38, 34, DateTimeKind.Local).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 6, 22, 11, 6, 72, DateTimeKind.Local).AddTicks(436), "Voluptas totam praes", 6, "Intelligent Metal Towels", new DateTime(2022, 7, 27, 6, 24, 32, 38, DateTimeKind.Local).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 21, 16, 27, 29, 682, DateTimeKind.Local).AddTicks(5008), "Molestias quis quas ", 4, "Intelligent Metal Table", new DateTime(2023, 1, 11, 12, 59, 59, 676, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 3, 10, 19, 718, DateTimeKind.Local).AddTicks(9876), "Consequatur illo aut", 18, "Awesome Steel Salad", new DateTime(2022, 10, 20, 2, 23, 38, 165, DateTimeKind.Local).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 4, 10, 56, 33, 524, DateTimeKind.Local).AddTicks(3875), "Pariatur accusantium", 17, "Small Steel Chips", new DateTime(2022, 6, 29, 16, 28, 52, 354, DateTimeKind.Local).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 11, 16, 19, 38, 958, DateTimeKind.Local).AddTicks(119), "Cumque accusamus per", 5, "Gorgeous Plastic Bacon", new DateTime(2022, 11, 2, 5, 31, 54, 900, DateTimeKind.Local).AddTicks(9736) });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 11, new DateTime(2022, 5, 15, 6, 54, 53, 753, DateTimeKind.Local).AddTicks(3250), "Architecto impedit q", 3, "Generic Concrete Fish", new DateTime(2022, 12, 6, 23, 22, 23, 746, DateTimeKind.Local).AddTicks(776) },
                    { 14, new DateTime(2022, 11, 21, 5, 56, 6, 298, DateTimeKind.Local).AddTicks(5716), "Voluptate consequatu", 2, "Practical Rubber Hat", new DateTime(2022, 11, 26, 22, 2, 24, 738, DateTimeKind.Local).AddTicks(426) },
                    { 18, new DateTime(2022, 7, 28, 22, 38, 23, 869, DateTimeKind.Local).AddTicks(2619), "Eaque voluptatum ali", 10, "Sleek Frozen Sausages", new DateTime(2022, 11, 22, 21, 26, 48, 770, DateTimeKind.Local).AddTicks(7766) },
                    { 19, new DateTime(2022, 7, 9, 22, 41, 59, 353, DateTimeKind.Local).AddTicks(3135), "Libero voluptatem pe", 10, "Ergonomic Frozen Chicken", new DateTime(2022, 11, 12, 6, 45, 3, 777, DateTimeKind.Local).AddTicks(4013) },
                    { 20, new DateTime(2022, 10, 28, 3, 29, 45, 846, DateTimeKind.Local).AddTicks(599), "Consequatur vel dele", 8, "Ergonomic Rubber Shoes", new DateTime(2022, 11, 2, 5, 36, 29, 126, DateTimeKind.Local).AddTicks(8016) }
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 11, 15, 9, 2, 4, 506, DateTimeKind.Local).AddTicks(3313), "Aliquid voluptatem q", 3, "Refined Concrete Bike", new DateTime(2022, 3, 24, 13, 27, 37, 705, DateTimeKind.Local).AddTicks(7059), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 9, 28, 422, DateTimeKind.Local).AddTicks(8728), "Nihil quibusdam et a", 4, "Generic Metal Gloves", new DateTime(2022, 7, 29, 5, 19, 52, 355, DateTimeKind.Local).AddTicks(8809), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 6, 16, 19, 3, 53, 227, DateTimeKind.Local).AddTicks(9567), "Et id explicabo inci", 1, "Incredible Soft Hat", new DateTime(2023, 1, 12, 18, 7, 11, 124, DateTimeKind.Local).AddTicks(4695), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 8, 9, 4, 54, 47, 338, DateTimeKind.Local).AddTicks(7457), "Nihil illo ad dolore", 3, "Unbranded Rubber Shoes", new DateTime(2022, 5, 31, 10, 38, 50, 88, DateTimeKind.Local).AddTicks(6478), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 10, 16, 18, 50, 28, 784, DateTimeKind.Local).AddTicks(1748), "Hic voluptatem atque", 4, "Ergonomic Granite Bike", new DateTime(2022, 4, 27, 13, 3, 53, 490, DateTimeKind.Local).AddTicks(2909), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 3, 20, 4, 1, 7, 725, DateTimeKind.Local).AddTicks(4208), "Iste natus explicabo", 3, "Fantastic Cotton Pants", new DateTime(2022, 8, 7, 9, 3, 47, 762, DateTimeKind.Local).AddTicks(1482), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 8, 3, 21, 46, 53, 128, DateTimeKind.Local).AddTicks(5195), "Qui sed sit ut reici", 3, "Sleek Wooden Mouse", new DateTime(2022, 3, 18, 4, 4, 26, 119, DateTimeKind.Local).AddTicks(6753), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 7, 12, 12, 36, 33, 514, DateTimeKind.Local).AddTicks(5402), "Et consequatur incid", 3, "Refined Concrete Table", new DateTime(2022, 5, 20, 19, 14, 59, 217, DateTimeKind.Local).AddTicks(801), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 11, 27, 16, 31, 24, 6, DateTimeKind.Local).AddTicks(1670), "Et rerum quos quibus", 5, "Generic Cotton Salad", new DateTime(2023, 1, 26, 2, 55, 36, 551, DateTimeKind.Local).AddTicks(7496), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 7, 6, 8, 38, 54, 799, DateTimeKind.Local).AddTicks(2868), "Dolores maxime eaque", 2, "Incredible Fresh Towels", new DateTime(2022, 5, 22, 15, 38, 49, 749, DateTimeKind.Local).AddTicks(7682), null });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 11, new DateTime(2022, 5, 6, 0, 44, 33, 963, DateTimeKind.Local).AddTicks(2757), "Sed quaerat quos ali", 2, "Small Plastic Shirt", new DateTime(2022, 5, 10, 9, 42, 0, 706, DateTimeKind.Local).AddTicks(7903), null },
                    { 12, new DateTime(2022, 11, 5, 6, 59, 6, 188, DateTimeKind.Local).AddTicks(7464), "Repudiandae laborios", 1, "Sleek Granite Car", new DateTime(2022, 12, 27, 20, 20, 16, 64, DateTimeKind.Local).AddTicks(1422), null },
                    { 13, new DateTime(2022, 3, 15, 3, 41, 54, 972, DateTimeKind.Local).AddTicks(2770), "Quia delectus sit cu", 4, "Gorgeous Metal Fish", new DateTime(2022, 2, 17, 15, 39, 23, 354, DateTimeKind.Local).AddTicks(268), null },
                    { 14, new DateTime(2022, 11, 26, 23, 55, 13, 636, DateTimeKind.Local).AddTicks(5218), "Sunt ut enim vel dic", 4, "Practical Wooden Keyboard", new DateTime(2022, 12, 12, 1, 57, 45, 441, DateTimeKind.Local).AddTicks(9344), null },
                    { 15, new DateTime(2023, 1, 11, 14, 44, 18, 410, DateTimeKind.Local).AddTicks(9899), "Rem commodi rem. Dol", 5, "Licensed Fresh Tuna", new DateTime(2022, 11, 11, 4, 42, 55, 93, DateTimeKind.Local).AddTicks(767), null },
                    { 16, new DateTime(2022, 4, 11, 10, 23, 14, 937, DateTimeKind.Local).AddTicks(8793), "Ad dolorem in. Eius ", 4, "Small Fresh Computer", new DateTime(2022, 10, 31, 4, 3, 50, 187, DateTimeKind.Local).AddTicks(2555), null },
                    { 17, new DateTime(2022, 4, 19, 7, 56, 31, 22, DateTimeKind.Local).AddTicks(8969), "Praesentium fugit au", 4, "Handmade Cotton Salad", new DateTime(2022, 10, 14, 7, 12, 13, 110, DateTimeKind.Local).AddTicks(7858), null },
                    { 18, new DateTime(2022, 8, 30, 13, 30, 28, 390, DateTimeKind.Local).AddTicks(2457), "Quis incidunt verita", 3, "Generic Soft Salad", new DateTime(2022, 4, 16, 15, 13, 7, 201, DateTimeKind.Local).AddTicks(4434), null },
                    { 19, new DateTime(2022, 4, 30, 13, 8, 21, 596, DateTimeKind.Local).AddTicks(4823), "Ea vel libero vel. A", 5, "Fantastic Plastic Chicken", new DateTime(2022, 6, 3, 0, 6, 30, 42, DateTimeKind.Local).AddTicks(2985), null },
                    { 20, new DateTime(2022, 7, 30, 1, 2, 3, 30, DateTimeKind.Local).AddTicks(2282), "Commodi quia cum. Mo", 4, "Rustic Plastic Cheese", new DateTime(2022, 12, 11, 14, 8, 2, 615, DateTimeKind.Local).AddTicks(3497), null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Janelle.Swift60@yahoo.com", "Madisyn Dickinson", "SCl9SMvi2c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Stevie22@yahoo.com", "Emery Carter", "iw0u9aRjEI" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Rylee_Towne@gmail.com", "Ariel Jaskolski", "k6eTQL1KZe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Adolf_Gusikowski@yahoo.com", "Noelia Parker", "vMeSvnQqcm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Cicero.Huel13@hotmail.com", "Schuyler Windler", "bTBiBW3H9b" });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 12, new DateTime(2022, 6, 15, 14, 58, 54, 680, DateTimeKind.Local).AddTicks(7445), "Amet sed molestias a", 14, "Handcrafted Cotton Car", new DateTime(2022, 10, 27, 10, 6, 9, 704, DateTimeKind.Local).AddTicks(6368) },
                    { 13, new DateTime(2023, 1, 11, 14, 26, 6, 725, DateTimeKind.Local).AddTicks(5702), "Aperiam sapiente ut ", 20, "Tasty Wooden Gloves", new DateTime(2022, 2, 21, 13, 46, 14, 960, DateTimeKind.Local).AddTicks(5331) },
                    { 15, new DateTime(2022, 6, 8, 11, 38, 38, 939, DateTimeKind.Local).AddTicks(2053), "Quia voluptatem quod", 14, "Handcrafted Fresh Sausages", new DateTime(2022, 8, 9, 13, 14, 8, 993, DateTimeKind.Local).AddTicks(5423) },
                    { 16, new DateTime(2022, 9, 20, 16, 40, 49, 420, DateTimeKind.Local).AddTicks(1309), "Totam rerum voluptat", 11, "Sleek Fresh Soap", new DateTime(2022, 4, 14, 20, 5, 0, 179, DateTimeKind.Local).AddTicks(1113) },
                    { 17, new DateTime(2022, 11, 4, 13, 28, 51, 461, DateTimeKind.Local).AddTicks(5475), "Molestiae optio sapi", 17, "Handcrafted Soft Pants", new DateTime(2022, 10, 22, 18, 25, 35, 218, DateTimeKind.Local).AddTicks(5027) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
