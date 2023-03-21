using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Colab.Migrations
{
    /// <inheritdoc />
    public partial class updated3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 3, 7, 58, 22, 142, DateTimeKind.Local).AddTicks(3940), "Porro saepe ipsam ut", 6, "Small Cotton Car", new DateTime(2022, 10, 3, 14, 50, 43, 324, DateTimeKind.Local).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 18, 10, 29, 386, DateTimeKind.Local).AddTicks(3129), "Itaque enim ab exerc", true, 7, "Awesome Cotton Pants", new DateTime(2022, 11, 3, 8, 18, 27, 353, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 9, 26, 31, 795, DateTimeKind.Local).AddTicks(759), "Hic omnis sit ut aut", true, 4, "Awesome Granite Sausages", new DateTime(2022, 11, 28, 15, 13, 34, 367, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 4, 15, 24, 23, 960, DateTimeKind.Local).AddTicks(1068), "Consectetur et aut a", true, 1, "Tasty Cotton Cheese", new DateTime(2022, 5, 8, 14, 21, 49, 828, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 3, 11, 10, 48, 662, DateTimeKind.Local).AddTicks(9038), "Facere maxime velit ", true, 2, "Awesome Steel Table", new DateTime(2022, 7, 28, 7, 47, 16, 346, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 24, 11, 42, 10, 380, DateTimeKind.Local).AddTicks(8050), "Voluptas voluptatum ", 2, "Awesome Granite Gloves", new DateTime(2023, 1, 13, 4, 43, 0, 791, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 39, 33, 513, DateTimeKind.Local).AddTicks(5122), "Accusamus officiis q", true, 6, "Sleek Metal Car", new DateTime(2022, 9, 9, 3, 31, 17, 520, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 22, 4, 51, 55, 910, DateTimeKind.Local).AddTicks(9478), "Sequi qui eum nam do", true, 4, "Generic Concrete Bacon", new DateTime(2022, 6, 12, 19, 30, 11, 121, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 26, 13, 40, 40, 422, DateTimeKind.Local).AddTicks(7090), "Minus excepturi susc", true, 5, "Rustic Plastic Keyboard", new DateTime(2022, 4, 30, 1, 23, 43, 766, DateTimeKind.Local).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 26, 2, 29, 55, 755, DateTimeKind.Local).AddTicks(6164), "Velit minima cumque ", true, 6, "Unbranded Granite Car", new DateTime(2022, 4, 13, 14, 50, 9, 973, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 11, new DateTime(2022, 8, 19, 13, 28, 55, 434, DateTimeKind.Local).AddTicks(5104), "Aperiam quidem liber", true, 10, "Handmade Concrete Salad", new DateTime(2022, 12, 14, 11, 18, 16, 356, DateTimeKind.Local).AddTicks(3808) },
                    { 12, new DateTime(2022, 4, 20, 22, 2, 49, 191, DateTimeKind.Local).AddTicks(7544), "Et non dolores digni", true, 4, "Generic Metal Ball", new DateTime(2022, 11, 1, 20, 33, 47, 787, DateTimeKind.Local).AddTicks(5115) },
                    { 13, new DateTime(2022, 3, 25, 3, 56, 52, 543, DateTimeKind.Local).AddTicks(2257), "Ut cumque tempore di", true, 10, "Rustic Cotton Sausages", new DateTime(2023, 1, 27, 15, 37, 32, 70, DateTimeKind.Local).AddTicks(5045) },
                    { 14, new DateTime(2022, 5, 27, 14, 11, 44, 736, DateTimeKind.Local).AddTicks(9214), "Odit omnis unde aute", false, 1, "Tasty Metal Towels", new DateTime(2023, 1, 18, 23, 20, 38, 911, DateTimeKind.Local).AddTicks(7767) },
                    { 15, new DateTime(2022, 6, 3, 21, 30, 19, 141, DateTimeKind.Local).AddTicks(1987), "In sequi laborum dol", false, 5, "Tasty Soft Computer", new DateTime(2023, 1, 27, 17, 52, 11, 745, DateTimeKind.Local).AddTicks(61) },
                    { 16, new DateTime(2022, 3, 16, 0, 21, 3, 974, DateTimeKind.Local).AddTicks(9140), "Aut ratione beatae. ", true, 7, "Handcrafted Metal Sausages", new DateTime(2022, 6, 8, 16, 59, 45, 569, DateTimeKind.Local).AddTicks(1342) },
                    { 17, new DateTime(2023, 1, 30, 21, 19, 22, 254, DateTimeKind.Local).AddTicks(4189), "Cupiditate autem deb", true, 8, "Sleek Metal Chips", new DateTime(2022, 3, 18, 17, 34, 54, 709, DateTimeKind.Local).AddTicks(9531) },
                    { 18, new DateTime(2022, 3, 9, 4, 32, 19, 243, DateTimeKind.Local).AddTicks(9689), "Aut perspiciatis ull", false, 9, "Tasty Steel Pizza", new DateTime(2022, 11, 15, 14, 33, 45, 818, DateTimeKind.Local).AddTicks(216) },
                    { 19, new DateTime(2022, 3, 20, 5, 30, 31, 546, DateTimeKind.Local).AddTicks(413), "Sed ea voluptates pl", true, 6, "Fantastic Granite Car", new DateTime(2022, 8, 8, 21, 55, 10, 953, DateTimeKind.Local).AddTicks(3879) },
                    { 20, new DateTime(2022, 5, 9, 8, 55, 4, 757, DateTimeKind.Local).AddTicks(3512), "Quia molestiae sunt ", false, 4, "Intelligent Granite Mouse", new DateTime(2022, 5, 5, 8, 16, 27, 335, DateTimeKind.Local).AddTicks(6745) }
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 28, 8, 37, 54, 965, DateTimeKind.Local).AddTicks(9379), "Et et sint nihil nes", 4, "Gorgeous Frozen Hat", new DateTime(2022, 8, 3, 15, 20, 39, 111, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 12, 11, 10, 38, 508, DateTimeKind.Local).AddTicks(3964), "Reprehenderit repreh", "Refined Steel Chicken", new DateTime(2022, 7, 18, 2, 55, 42, 477, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 3, 12, 59, 31, 228, DateTimeKind.Local).AddTicks(5863), "Quo est consequatur ", 5, "Generic Rubber Ball", new DateTime(2022, 2, 25, 11, 7, 36, 177, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 28, 11, 44, 49, 67, DateTimeKind.Local).AddTicks(1253), "Libero qui velit eos", 4, "Gorgeous Fresh Gloves", new DateTime(2022, 12, 9, 20, 45, 37, 7, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 2, 0, 17, 53, 6, DateTimeKind.Local).AddTicks(7020), "Repellat mollitia es", "Unbranded Wooden Gloves", new DateTime(2022, 4, 12, 17, 36, 13, 369, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 2, 14, 13, 17, 18, 41, DateTimeKind.Local).AddTicks(6033), "Laborum iusto rem eo", 2, "Fantastic Fresh Chicken", new DateTime(2022, 3, 15, 19, 2, 42, 710, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 29, 8, 54, 9, 711, DateTimeKind.Local).AddTicks(2453), "Quasi aliquam animi ", 5, "Tasty Metal Table", new DateTime(2022, 12, 20, 12, 8, 42, 931, DateTimeKind.Local).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 25, 8, 16, 35, 184, DateTimeKind.Local).AddTicks(1145), "Laboriosam velit atq", 2, "Awesome Rubber Pizza", new DateTime(2022, 8, 15, 11, 37, 31, 488, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 19, 22, 27, 32, 138, DateTimeKind.Local).AddTicks(2053), "Voluptate architecto", "Sleek Steel Car", new DateTime(2022, 4, 20, 2, 12, 11, 89, DateTimeKind.Local).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 13, 19, 58, 32, 578, DateTimeKind.Local).AddTicks(6939), "Et inventore volupta", 4, "Ergonomic Wooden Keyboard", new DateTime(2022, 6, 28, 22, 25, 2, 373, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Denis_Gerhold97@yahoo.com", "Gregorio Fritsch", "Tlh_xkHOd2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Edgar.White58@hotmail.com", "Lavina Batz", "gLoDcMAKr5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Fredrick_Beer60@hotmail.com", "Guy Bosco", "Tgz0G5Z6wb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Pearl.Trantow29@hotmail.com", "Chelsie Deckow", "yHMUoClmSn" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Lenny_Watsica27@yahoo.com", "Kylee Adams", "5EcOndITa0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 49, 16, 762, DateTimeKind.Local).AddTicks(6143), "Fuga ducimus enim mo", 9, "Refined Metal Towels", new DateTime(2022, 8, 3, 11, 29, 42, 414, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 15, 16, 14, 38, 57, DateTimeKind.Local).AddTicks(6136), "Quidem molestias off", false, 3, "Practical Granite Shoes", new DateTime(2022, 11, 27, 16, 21, 6, 415, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 5, 45, 36, 9, DateTimeKind.Local).AddTicks(366), "Quo omnis fugit est ", false, 1, "Licensed Metal Computer", new DateTime(2023, 1, 30, 11, 53, 57, 6, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 30, 21, 31, 21, 580, DateTimeKind.Local).AddTicks(8238), "Qui qui provident ei", false, 6, "Tasty Plastic Computer", new DateTime(2022, 4, 30, 5, 56, 33, 219, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 20, 7, 28, 50, 217, DateTimeKind.Local).AddTicks(1659), "Quos molestiae autem", false, 10, "Fantastic Concrete Shoes", new DateTime(2022, 9, 30, 8, 25, 40, 226, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 2, 23, 9, 16, 417, DateTimeKind.Local).AddTicks(9129), "Iure et et dicta rep", 8, "Refined Wooden Chicken", new DateTime(2022, 10, 29, 1, 7, 20, 625, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 14, 18, 7, 46, 958, DateTimeKind.Local).AddTicks(9055), "Velit et velit nostr", false, 5, "Small Fresh Shirt", new DateTime(2022, 5, 2, 10, 52, 15, 228, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 11, 19, 29, 21, 371, DateTimeKind.Local).AddTicks(7727), "Eius voluptatem quis", false, 3, "Licensed Metal Car", new DateTime(2022, 8, 17, 1, 18, 16, 433, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 11, 15, 15, 37, 941, DateTimeKind.Local).AddTicks(7841), "Adipisci excepturi m", false, 9, "Gorgeous Plastic Car", new DateTime(2022, 10, 14, 6, 27, 55, 87, DateTimeKind.Local).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 14, 12, 6, 50, 832, DateTimeKind.Local).AddTicks(3920), "Aut hic placeat reic", false, 4, "Handmade Concrete Sausages", new DateTime(2022, 8, 6, 15, 55, 50, 677, DateTimeKind.Local).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 18, 12, 4, 55, 417, DateTimeKind.Local).AddTicks(4859), "Voluptatem sit volup", 5, "Refined Rubber Computer", new DateTime(2022, 10, 29, 20, 4, 53, 562, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 17, 10, 17, 10, 150, DateTimeKind.Local).AddTicks(1482), "Itaque quis voluptat", "Rustic Wooden Hat", new DateTime(2022, 7, 20, 4, 45, 37, 149, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 16, 10, 35, 7, 610, DateTimeKind.Local).AddTicks(7550), "Aut voluptates ullam", 3, "Handmade Plastic Tuna", new DateTime(2022, 6, 14, 22, 45, 45, 778, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 1, 50, 7, 176, DateTimeKind.Local).AddTicks(2990), "Quas animi et veniam", 2, "Unbranded Soft Mouse", new DateTime(2022, 4, 5, 22, 42, 36, 121, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 23, 17, 0, 21, 94, DateTimeKind.Local).AddTicks(9239), "Dolores ad ut nemo v", "Small Steel Sausages", new DateTime(2022, 10, 30, 7, 23, 50, 67, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 30, 7, 48, 35, 306, DateTimeKind.Local).AddTicks(6404), "Placeat non ut labor", 4, "Fantastic Rubber Cheese", new DateTime(2022, 7, 24, 17, 3, 6, 466, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 31, 13, 38, 51, 285, DateTimeKind.Local).AddTicks(3679), "Fuga repudiandae vol", 4, "Practical Concrete Pizza", new DateTime(2022, 11, 11, 3, 20, 4, 510, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 6, 23, 14, 17, 747, DateTimeKind.Local).AddTicks(8667), "Necessitatibus maxim", 3, "Licensed Wooden Chair", new DateTime(2022, 10, 25, 17, 47, 9, 562, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 31, 14, 34, 13, 212, DateTimeKind.Local).AddTicks(5643), "Aspernatur voluptate", "Small Cotton Cheese", new DateTime(2023, 1, 8, 6, 48, 39, 680, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 4, 11, 57, 20, 947, DateTimeKind.Local).AddTicks(3151), "Dolorem animi enim d", 3, "Rustic Steel Keyboard", new DateTime(2022, 12, 18, 3, 53, 0, 782, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Brooklyn.Conroy4@hotmail.com", "Reece Kassulke", "uGkfqKWKgz" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Kaleigh.Cremin@yahoo.com", "Daisy Marks", "fBt1Cxi93C" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Ava_Simonis@yahoo.com", "Deborah DuBuque", "CGA9XGzebW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Newton69@hotmail.com", "Norbert Hegmann", "Gei9bYve_w" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Ian_Berge@hotmail.com", "Isaias Beahan", "9OXcQxRem7" });
        }
    }
}
