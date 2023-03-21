using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Colab.Migrations
{
    /// <inheritdoc />
    public partial class updated5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 1, 7, 31, 41, 179, DateTimeKind.Local).AddTicks(541), "Reiciendis praesenti", false, 5, "Rustic Rubber Gloves", new DateTime(2023, 2, 2, 11, 11, 44, 682, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 29, 4, 40, 47, 81, DateTimeKind.Local).AddTicks(3529), "Veniam animi ipsa et", 8, "Generic Granite Hat", new DateTime(2023, 1, 11, 7, 35, 0, 163, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 24, 5, 52, 12, 376, DateTimeKind.Local).AddTicks(8740), "Odit vel recusandae ", true, 6, "Rustic Soft Pizza", new DateTime(2022, 7, 15, 12, 37, 52, 42, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 13, 15, 27, 24, 887, DateTimeKind.Local).AddTicks(3185), "Tempora et soluta no", false, 3, "Small Fresh Ball", new DateTime(2022, 7, 16, 20, 6, 2, 295, DateTimeKind.Local).AddTicks(3726) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 18, 16, 18, 41, 703, DateTimeKind.Local).AddTicks(9437), "Hic consequatur dict", 4, "Incredible Steel Chips", new DateTime(2022, 3, 8, 9, 20, 23, 967, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 14, 19, 42, 31, 788, DateTimeKind.Local).AddTicks(2044), "Quam soluta at volup", true, 9, "Fantastic Fresh Table", new DateTime(2022, 10, 11, 20, 18, 32, 702, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 15, 5, 50, 44, 703, DateTimeKind.Local).AddTicks(523), "Dolor perspiciatis o", false, 5, "Small Cotton Pizza", new DateTime(2022, 6, 24, 4, 39, 43, 358, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 30, 14, 44, 33, 402, DateTimeKind.Local).AddTicks(1939), "Ut et rerum dolores ", 7, "Rustic Frozen Bacon", new DateTime(2022, 8, 2, 20, 16, 35, 384, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 2, 18, 12, 34, 817, DateTimeKind.Local).AddTicks(6046), "Quo odit incidunt er", "Handcrafted Wooden Keyboard", new DateTime(2022, 11, 23, 4, 13, 44, 565, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 17, 22, 44, 22, 765, DateTimeKind.Local).AddTicks(9824), "Atque rem iure numqu", false, 1, "Intelligent Soft Salad", new DateTime(2022, 11, 5, 0, 52, 13, 405, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 23, 19, 56, 14, 868, DateTimeKind.Local).AddTicks(1320), "Soluta atque atque l", 5, "Licensed Wooden Salad", new DateTime(2022, 8, 23, 0, 45, 17, 351, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 0, 44, 19, 604, DateTimeKind.Local).AddTicks(918), "Ex eos porro recusan", false, 6, "Fantastic Plastic Tuna", new DateTime(2022, 2, 13, 18, 30, 45, 692, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 19, 18, 23, 27, 211, DateTimeKind.Local).AddTicks(7408), "Necessitatibus delen", 5, "Refined Metal Chips", new DateTime(2022, 2, 25, 21, 12, 15, 302, DateTimeKind.Local).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 30, 17, 5, 25, 459, DateTimeKind.Local).AddTicks(153), "Perferendis velit en", true, 2, "Handcrafted Concrete Mouse", new DateTime(2022, 12, 21, 19, 18, 52, 186, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 21, 22, 11, 48, 706, DateTimeKind.Local).AddTicks(9190), "Laboriosam optio aut", 2, "Intelligent Soft Computer", new DateTime(2023, 2, 10, 16, 26, 46, 770, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 9, 23, 36, 42, 818, DateTimeKind.Local).AddTicks(3391), "Nisi exercitationem ", 1, "Ergonomic Cotton Hat", new DateTime(2022, 12, 23, 9, 32, 53, 26, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 8, 19, 55, 11, 985, DateTimeKind.Local).AddTicks(373), "Laudantium iure pari", 6, "Generic Soft Chicken", new DateTime(2022, 5, 20, 19, 55, 6, 991, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 6, 10, 22, 12, 739, DateTimeKind.Local).AddTicks(8050), "Mollitia rem ducimus", 8, "Rustic Concrete Mouse", new DateTime(2022, 8, 7, 19, 13, 27, 571, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 15, 16, 26, 12, 539, DateTimeKind.Local).AddTicks(7700), "Rem est libero labor", false, 6, "Unbranded Metal Gloves", new DateTime(2022, 2, 18, 8, 12, 52, 101, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 16, 4, 19, 52, 870, DateTimeKind.Local).AddTicks(5243), "Sapiente quo numquam", "Licensed Granite Tuna", new DateTime(2022, 3, 16, 9, 12, 42, 511, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 31, 1, 26, 52, 570, DateTimeKind.Local).AddTicks(927), "Iste similique quas ", "Unbranded Wooden Salad", new DateTime(2022, 10, 2, 9, 11, 5, 489, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 24, 14, 10, 33, 137, DateTimeKind.Local).AddTicks(1585), "Blanditiis quia aut.", "Handcrafted Granite Fish", new DateTime(2022, 3, 24, 3, 12, 27, 383, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 8, 16, 27, 22, 721, DateTimeKind.Local).AddTicks(8863), "Sed aut culpa vel ex", "Refined Granite Chips", new DateTime(2022, 7, 16, 23, 4, 31, 516, DateTimeKind.Local).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 30, 4, 30, 39, 643, DateTimeKind.Local).AddTicks(4294), "Voluptas iusto expli", "Ergonomic Plastic Soap", new DateTime(2022, 11, 26, 14, 32, 42, 663, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 12, 10, 12, 51, 964, DateTimeKind.Local).AddTicks(6521), "Officiis exercitatio", "Small Cotton Chips", new DateTime(2022, 9, 15, 22, 16, 9, 454, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 7, 10, 21, 40, 813, DateTimeKind.Local).AddTicks(6767), "Voluptas quasi hic n", "Gorgeous Frozen Shirt", new DateTime(2022, 3, 5, 8, 11, 45, 667, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 22, 45, 29, 935, DateTimeKind.Local).AddTicks(8127), "Rem ea fugit. Accusa", "Fantastic Fresh Table", new DateTime(2022, 3, 1, 18, 13, 17, 745, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 24, 14, 28, 50, 693, DateTimeKind.Local).AddTicks(2027), "In eveniet facilis a", "Handmade Soft Soap", new DateTime(2022, 3, 22, 12, 53, 3, 596, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 19, 19, 34, 22, 521, DateTimeKind.Local).AddTicks(9008), "Ut est iusto est ali", "Generic Rubber Salad", new DateTime(2022, 6, 23, 21, 26, 48, 797, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 1, 4, 23, 17, 360, DateTimeKind.Local).AddTicks(9417), "Eum vero reiciendis ", "Handcrafted Cotton Tuna", new DateTime(2022, 6, 23, 13, 46, 29, 752, DateTimeKind.Local).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Isaias.Bednar95@gmail.com", "Turner Hansen", "c3DdkMNGO8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Osborne.Pagac70@gmail.com", "Katelyn Gerhold", "OcV4c5V1dM" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Shanna_Luettgen@yahoo.com", "Urban Nienow", "AIs9F2DIvf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Guiseppe_Vandervort65@yahoo.com", "Prince Hyatt", "iDDoMcGeS7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Collin23@yahoo.com", "Alycia Anderson", "Jkd4ddtBhS" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 6, 15, 22, 23, 108, DateTimeKind.Local).AddTicks(2175), "Fuga dolore vitae qu", true, 4, "Practical Rubber Bacon", new DateTime(2022, 10, 4, 23, 4, 37, 571, DateTimeKind.Local).AddTicks(777) });

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
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 6, 22, 43, 8, 736, DateTimeKind.Local).AddTicks(2327), "Consequatur dignissi", false, 6, "Practical Metal Pants", new DateTime(2022, 3, 7, 18, 54, 13, 213, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 6, 10, 41, 57, 193, DateTimeKind.Local).AddTicks(2404), "Odio ab eius assumen", true, 4, "Generic Wooden Shirt", new DateTime(2022, 10, 28, 12, 42, 26, 786, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 2, 15, 12, 20, 30, 335, DateTimeKind.Local).AddTicks(7120), "Eius cupiditate saep", 10, "Handmade Metal Car", new DateTime(2022, 12, 20, 17, 25, 20, 276, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 14, 12, 36, 35, 284, DateTimeKind.Local).AddTicks(1213), "Maxime quasi deserun", "Generic Wooden Hat", new DateTime(2023, 1, 6, 7, 9, 0, 723, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 28, 23, 11, 43, 317, DateTimeKind.Local).AddTicks(9639), "Et impedit corrupti ", true, 10, "Incredible Wooden Keyboard", new DateTime(2022, 10, 3, 18, 16, 8, 706, DateTimeKind.Local).AddTicks(5453) });

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
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 10, 11, 29, 0, 537, DateTimeKind.Local).AddTicks(1240), "Necessitatibus eaque", true, 7, "Tasty Cotton Hat", new DateTime(2022, 12, 27, 21, 49, 20, 457, DateTimeKind.Local).AddTicks(6851) });

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
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 16, 2, 6, 0, 737, DateTimeKind.Local).AddTicks(7042), "Sit libero ducimus n", false, 5, "Handmade Frozen Car", new DateTime(2022, 9, 5, 12, 3, 22, 421, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 4, 14, 51, 26, 533, DateTimeKind.Local).AddTicks(8416), "Provident vel aliqua", 4, "Awesome Plastic Gloves", new DateTime(2022, 11, 14, 4, 19, 35, 15, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 24, 23, 12, 24, 67, DateTimeKind.Local).AddTicks(1442), "Et eum excepturi. Et", 7, "Handcrafted Fresh Ball", new DateTime(2022, 3, 21, 6, 59, 59, 657, DateTimeKind.Local).AddTicks(8084) });

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
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 12, 20, 39, 11, 469, DateTimeKind.Local).AddTicks(4864), "Maiores delectus del", 5, "Gorgeous Metal Keyboard", new DateTime(2022, 2, 13, 5, 51, 32, 976, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Description", "IsCompleted", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 30, 19, 18, 25, 180, DateTimeKind.Local).AddTicks(7094), "Quisquam ipsa distin", true, 9, "Generic Cotton Chips", new DateTime(2022, 7, 13, 21, 18, 2, 679, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 27, 15, 55, 49, 89, DateTimeKind.Local).AddTicks(1543), "Tempora sed voluptat", "Incredible Wooden Shirt", new DateTime(2022, 11, 17, 6, 59, 15, 308, DateTimeKind.Local).AddTicks(6968) });

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
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Sofia.Larson86@hotmail.com", "Richie Mayer", "McxH2O8kwv" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Abigayle_Bruen@hotmail.com", "Jamar Kessler", "b7ULHvgPDH" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Nichole.Crist44@hotmail.com", "Ariane Windler", "Kh4VQQmkwv" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Nicklaus.Zboncak@yahoo.com", "Kian Kessler", "FR0LuP4rMs" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Myra.Terry26@hotmail.com", "Carlie Frami", "R5B5OgZX8g" });
        }
    }
}
