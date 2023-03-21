using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Colab.Migrations
{
    /// <inheritdoc />
    public partial class updated4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_OwnerId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_OwnerId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Users",
                newName: "IsAdmin");

            migrationBuilder.AddColumn<bool>(
                name: "IsOwner",
                table: "ProjectUser",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 23, 58, 22, 426, DateTimeKind.Local).AddTicks(9294), "Architecto soluta no", true, 4, "Intelligent Granite Shoes", new DateTime(2022, 8, 25, 1, 10, 0, 270, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 8, 22, 25, 359, DateTimeKind.Local).AddTicks(5951), "Dolorem officiis qui", 6, "Awesome Plastic Bacon", new DateTime(2022, 4, 29, 17, 19, 49, 718, DateTimeKind.Local).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 11, 8, 24, 21, 40, DateTimeKind.Local).AddTicks(838), "Mollitia ut necessit", false, 3, "Rustic Plastic Tuna", new DateTime(2022, 11, 26, 22, 35, 27, 241, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 6, 15, 22, 23, 108, DateTimeKind.Local).AddTicks(2175), "Fuga dolore vitae qu", 4, "Practical Rubber Bacon", new DateTime(2022, 10, 4, 23, 4, 37, 571, DateTimeKind.Local).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 16, 10, 20, 10, 33, DateTimeKind.Local).AddTicks(3942), "Ut id fugiat iusto q", 9, "Intelligent Rubber Bike", new DateTime(2023, 2, 11, 4, 25, 44, 864, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 6, 22, 43, 8, 736, DateTimeKind.Local).AddTicks(2327), "Consequatur dignissi", 6, "Practical Metal Pants", new DateTime(2022, 3, 7, 18, 54, 13, 213, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 6, 10, 41, 57, 193, DateTimeKind.Local).AddTicks(2404), "Odio ab eius assumen", 4, "Generic Wooden Shirt", new DateTime(2022, 10, 28, 12, 42, 26, 786, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 2, 15, 12, 20, 30, 335, DateTimeKind.Local).AddTicks(7120), "Eius cupiditate saep", false, 10, "Handmade Metal Car", new DateTime(2022, 12, 20, 17, 25, 20, 276, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 14, 12, 36, 35, 284, DateTimeKind.Local).AddTicks(1213), "Maxime quasi deserun", false, 6, "Generic Wooden Hat", new DateTime(2023, 1, 6, 7, 9, 0, 723, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 28, 23, 11, 43, 317, DateTimeKind.Local).AddTicks(9639), "Et impedit corrupti ", 10, "Incredible Wooden Keyboard", new DateTime(2022, 10, 3, 18, 16, 8, 706, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 26, 20, 11, 58, 670, DateTimeKind.Local).AddTicks(5700), "Cumque cupiditate la", 9, "Handcrafted Metal Sausages", new DateTime(2023, 2, 10, 23, 42, 37, 562, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 10, 11, 29, 0, 537, DateTimeKind.Local).AddTicks(1240), "Necessitatibus eaque", 7, "Tasty Cotton Hat", new DateTime(2022, 12, 27, 21, 49, 20, 457, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 18, 7, 862, DateTimeKind.Local).AddTicks(5249), "Neque hic et aut lab", 3, "Gorgeous Steel Cheese", new DateTime(2022, 12, 3, 23, 31, 3, 941, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 16, 2, 6, 0, 737, DateTimeKind.Local).AddTicks(7042), "Sit libero ducimus n", 5, "Handmade Frozen Car", new DateTime(2022, 9, 5, 12, 3, 22, 421, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 4, 14, 51, 26, 533, DateTimeKind.Local).AddTicks(8416), "Provident vel aliqua", true, 4, "Awesome Plastic Gloves", new DateTime(2022, 11, 14, 4, 19, 35, 15, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 24, 23, 12, 24, 67, DateTimeKind.Local).AddTicks(1442), "Et eum excepturi. Et", "Handcrafted Fresh Ball", new DateTime(2022, 3, 21, 6, 59, 59, 657, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 9, 20, 58, 40, 706, DateTimeKind.Local).AddTicks(3292), "Ab ex nobis tenetur ", 5, "Awesome Fresh Chicken", new DateTime(2023, 1, 17, 4, 50, 15, 368, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 12, 20, 39, 11, 469, DateTimeKind.Local).AddTicks(4864), "Maiores delectus del", true, 5, "Gorgeous Metal Keyboard", new DateTime(2022, 2, 13, 5, 51, 32, 976, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 30, 19, 18, 25, 180, DateTimeKind.Local).AddTicks(7094), "Quisquam ipsa distin", 9, "Generic Cotton Chips", new DateTime(2022, 7, 13, 21, 18, 2, 679, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 27, 15, 55, 49, 89, DateTimeKind.Local).AddTicks(1543), "Tempora sed voluptat", 6, "Incredible Wooden Shirt", new DateTime(2022, 11, 17, 6, 59, 15, 308, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 13, 10, 9, 27, 7, DateTimeKind.Local).AddTicks(5329), "Possimus molestiae a", "Generic Rubber Chicken", new DateTime(2022, 2, 17, 14, 16, 6, 224, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 24, 7, 29, 32, 21, DateTimeKind.Local).AddTicks(8134), "Repudiandae explicab", "Generic Steel Pizza", new DateTime(2022, 9, 29, 17, 52, 25, 809, DateTimeKind.Local).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 11, 0, 50, 10, 122, DateTimeKind.Local).AddTicks(9400), "Dolor neque quibusda", "Rustic Frozen Mouse", new DateTime(2022, 6, 17, 23, 56, 25, 858, DateTimeKind.Local).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 27, 12, 34, 58, 754, DateTimeKind.Local).AddTicks(8272), "Iure et ipsum fugiat", "Practical Rubber Keyboard", new DateTime(2022, 3, 9, 4, 10, 9, 515, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 30, 6, 658, DateTimeKind.Local).AddTicks(189), "Voluptas unde nemo t", "Small Plastic Keyboard", new DateTime(2022, 5, 14, 7, 57, 56, 363, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 12, 16, 14, 42, 732, DateTimeKind.Local).AddTicks(5860), "At deleniti animi qu", "Ergonomic Plastic Cheese", new DateTime(2022, 3, 23, 16, 7, 31, 498, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 18, 21, 50, 49, 19, DateTimeKind.Local).AddTicks(5132), "Et aut vel. Quasi ar", "Fantastic Frozen Sausages", new DateTime(2022, 3, 10, 11, 55, 35, 92, DateTimeKind.Local).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 11, 18, 9, 17, 706, DateTimeKind.Local).AddTicks(7741), "Voluptatem aspernatu", "Gorgeous Granite Salad", new DateTime(2022, 10, 25, 15, 19, 13, 957, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 22, 23, 58, 51, 124, DateTimeKind.Local).AddTicks(2147), "Quos consequatur ad ", "Gorgeous Rubber Shoes", new DateTime(2022, 12, 17, 21, 43, 52, 621, DateTimeKind.Local).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 1, 22, 2, 27, 91, DateTimeKind.Local).AddTicks(3697), "Reprehenderit id arc", "Awesome Concrete Fish", new DateTime(2022, 4, 5, 17, 56, 17, 789, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "IsAdmin", "Name", "Password" },
                values: new object[] { "Sofia.Larson86@hotmail.com", false, "Richie Mayer", "McxH2O8kwv" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "IsAdmin", "Name", "Password" },
                values: new object[] { "Abigayle_Bruen@hotmail.com", false, "Jamar Kessler", "b7ULHvgPDH" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "IsAdmin", "Name", "Password" },
                values: new object[] { "Nichole.Crist44@hotmail.com", false, "Ariane Windler", "Kh4VQQmkwv" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "IsAdmin", "Name", "Password" },
                values: new object[] { "Nicklaus.Zboncak@yahoo.com", false, "Kian Kessler", "FR0LuP4rMs" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "IsAdmin", "Name", "Password" },
                values: new object[] { "Myra.Terry26@hotmail.com", false, "Carlie Frami", "R5B5OgZX8g" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOwner",
                table: "ProjectUser");

            migrationBuilder.RenameColumn(
                name: "IsAdmin",
                table: "Users",
                newName: "RoleId");

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
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 3, 7, 58, 22, 142, DateTimeKind.Local).AddTicks(3940), "Porro saepe ipsam ut", false, 6, "Small Cotton Car", new DateTime(2022, 10, 3, 14, 50, 43, 324, DateTimeKind.Local).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 29, 18, 10, 29, 386, DateTimeKind.Local).AddTicks(3129), "Itaque enim ab exerc", 7, "Awesome Cotton Pants", new DateTime(2022, 11, 3, 8, 18, 27, 353, DateTimeKind.Local).AddTicks(9140) });

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
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 4, 15, 24, 23, 960, DateTimeKind.Local).AddTicks(1068), "Consectetur et aut a", 1, "Tasty Cotton Cheese", new DateTime(2022, 5, 8, 14, 21, 49, 828, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 3, 11, 10, 48, 662, DateTimeKind.Local).AddTicks(9038), "Facere maxime velit ", 2, "Awesome Steel Table", new DateTime(2022, 7, 28, 7, 47, 16, 346, DateTimeKind.Local).AddTicks(808) });

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
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 39, 33, 513, DateTimeKind.Local).AddTicks(5122), "Accusamus officiis q", 6, "Sleek Metal Car", new DateTime(2022, 9, 9, 3, 31, 17, 520, DateTimeKind.Local).AddTicks(631) });

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
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 26, 2, 29, 55, 755, DateTimeKind.Local).AddTicks(6164), "Velit minima cumque ", 6, "Unbranded Granite Car", new DateTime(2022, 4, 13, 14, 50, 9, 973, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 19, 13, 28, 55, 434, DateTimeKind.Local).AddTicks(5104), "Aperiam quidem liber", 10, "Handmade Concrete Salad", new DateTime(2022, 12, 14, 11, 18, 16, 356, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 20, 22, 2, 49, 191, DateTimeKind.Local).AddTicks(7544), "Et non dolores digni", 4, "Generic Metal Ball", new DateTime(2022, 11, 1, 20, 33, 47, 787, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 25, 3, 56, 52, 543, DateTimeKind.Local).AddTicks(2257), "Ut cumque tempore di", 10, "Rustic Cotton Sausages", new DateTime(2023, 1, 27, 15, 37, 32, 70, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 27, 14, 11, 44, 736, DateTimeKind.Local).AddTicks(9214), "Odit omnis unde aute", 1, "Tasty Metal Towels", new DateTime(2023, 1, 18, 23, 20, 38, 911, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 3, 21, 30, 19, 141, DateTimeKind.Local).AddTicks(1987), "In sequi laborum dol", false, 5, "Tasty Soft Computer", new DateTime(2023, 1, 27, 17, 52, 11, 745, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 16, 0, 21, 3, 974, DateTimeKind.Local).AddTicks(9140), "Aut ratione beatae. ", "Handcrafted Metal Sausages", new DateTime(2022, 6, 8, 16, 59, 45, 569, DateTimeKind.Local).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 30, 21, 19, 22, 254, DateTimeKind.Local).AddTicks(4189), "Cupiditate autem deb", 8, "Sleek Metal Chips", new DateTime(2022, 3, 18, 17, 34, 54, 709, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 9, 4, 32, 19, 243, DateTimeKind.Local).AddTicks(9689), "Aut perspiciatis ull", false, 9, "Tasty Steel Pizza", new DateTime(2022, 11, 15, 14, 33, 45, 818, DateTimeKind.Local).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 20, 5, 30, 31, 546, DateTimeKind.Local).AddTicks(413), "Sed ea voluptates pl", 6, "Fantastic Granite Car", new DateTime(2022, 8, 8, 21, 55, 10, 953, DateTimeKind.Local).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 9, 8, 55, 4, 757, DateTimeKind.Local).AddTicks(3512), "Quia molestiae sunt ", 4, "Intelligent Granite Mouse", new DateTime(2022, 5, 5, 8, 16, 27, 335, DateTimeKind.Local).AddTicks(6745) });

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
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 12, 11, 10, 38, 508, DateTimeKind.Local).AddTicks(3964), "Reprehenderit repreh", 4, "Refined Steel Chicken", new DateTime(2022, 7, 18, 2, 55, 42, 477, DateTimeKind.Local).AddTicks(2694) });

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
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 2, 0, 17, 53, 6, DateTimeKind.Local).AddTicks(7020), "Repellat mollitia es", 4, "Unbranded Wooden Gloves", new DateTime(2022, 4, 12, 17, 36, 13, 369, DateTimeKind.Local).AddTicks(958) });

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
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 19, 22, 27, 32, 138, DateTimeKind.Local).AddTicks(2053), "Voluptate architecto", 3, "Sleek Steel Car", new DateTime(2022, 4, 20, 2, 12, 11, 89, DateTimeKind.Local).AddTicks(102) });

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
                columns: new[] { "Email", "Name", "Password", "RoleId" },
                values: new object[] { "Denis_Gerhold97@yahoo.com", "Gregorio Fritsch", "Tlh_xkHOd2", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password", "RoleId" },
                values: new object[] { "Edgar.White58@hotmail.com", "Lavina Batz", "gLoDcMAKr5", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Password", "RoleId" },
                values: new object[] { "Fredrick_Beer60@hotmail.com", "Guy Bosco", "Tgz0G5Z6wb", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Password", "RoleId" },
                values: new object[] { "Pearl.Trantow29@hotmail.com", "Chelsie Deckow", "yHMUoClmSn", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Password", "RoleId" },
                values: new object[] { "Lenny_Watsica27@yahoo.com", "Kylee Adams", "5EcOndITa0", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_OwnerId",
                table: "Projects",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_OwnerId",
                table: "Projects",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
