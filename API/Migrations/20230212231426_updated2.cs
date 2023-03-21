using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Colab.Migrations
{
    /// <inheritdoc />
    public partial class updated2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Assignments",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 49, 16, 762, DateTimeKind.Local).AddTicks(6143), "Fuga ducimus enim mo", false, 9, "Refined Metal Towels", new DateTime(2022, 8, 3, 11, 29, 42, 414, DateTimeKind.Local).AddTicks(3472) });

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
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 2, 23, 9, 16, 417, DateTimeKind.Local).AddTicks(9129), "Iure et et dicta rep", false, 8, "Refined Wooden Chicken", new DateTime(2022, 10, 29, 1, 7, 20, 625, DateTimeKind.Local).AddTicks(3939) });

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
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 17, 10, 17, 10, 150, DateTimeKind.Local).AddTicks(1482), "Itaque quis voluptat", 4, "Rustic Wooden Hat", new DateTime(2022, 7, 20, 4, 45, 37, 149, DateTimeKind.Local).AddTicks(5511) });

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
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 23, 17, 0, 21, 94, DateTimeKind.Local).AddTicks(9239), "Dolores ad ut nemo v", 4, "Small Steel Sausages", new DateTime(2022, 10, 30, 7, 23, 50, 67, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 30, 7, 48, 35, 306, DateTimeKind.Local).AddTicks(6404), "Placeat non ut labor", "Fantastic Rubber Cheese", new DateTime(2022, 7, 24, 17, 3, 6, 466, DateTimeKind.Local).AddTicks(9937) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Assignments");

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
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 30, 18, 39, 49, 799, DateTimeKind.Local).AddTicks(4991), "Repudiandae dolorum ", 2, "Handmade Frozen Mouse", new DateTime(2022, 11, 10, 11, 51, 8, 830, DateTimeKind.Local).AddTicks(7439) });

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
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 11, 17, 43, 44, 525, DateTimeKind.Local).AddTicks(7612), "Quo pariatur illo qu", 1, "Generic Steel Table", new DateTime(2023, 1, 16, 11, 20, 45, 101, DateTimeKind.Local).AddTicks(9491) });

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
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 12, 11, 55, 9, 197, DateTimeKind.Local).AddTicks(9428), "Ullam maiores assume", 5, "Handcrafted Plastic Shoes", new DateTime(2022, 5, 23, 5, 12, 8, 887, DateTimeKind.Local).AddTicks(4847) });

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
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 20, 1, 53, 50, 573, DateTimeKind.Local).AddTicks(8230), "Vero saepe et. Quis ", "Unbranded Cotton Gloves", new DateTime(2022, 4, 1, 2, 19, 13, 998, DateTimeKind.Local).AddTicks(780) });

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
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Kenton_Hansen85@yahoo.com", "Eileen Streich", "W4h2EeVDro" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Mattie65@yahoo.com", "Deja Ruecker", "6V6UMbK9kP" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Nyah_Nolan@yahoo.com", "Unique Glover", "ZJhl3U9nxH" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Providenci17@gmail.com", "Blair Romaguera", "dhDdWownGW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Stan_Jenkins71@yahoo.com", "Kali Lakin", "Z5uuJOTjcy" });
        }
    }
}
