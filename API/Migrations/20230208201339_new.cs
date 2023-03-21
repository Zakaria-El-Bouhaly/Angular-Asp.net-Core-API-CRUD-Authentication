using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Colab.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
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

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Projects",
                type: "INTEGER",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 15, 6, 54, 53, 753, DateTimeKind.Local).AddTicks(3250), "Architecto impedit q", 3, "Generic Concrete Fish", new DateTime(2022, 12, 6, 23, 22, 23, 746, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 15, 14, 58, 54, 680, DateTimeKind.Local).AddTicks(7445), "Amet sed molestias a", 14, "Handcrafted Cotton Car", new DateTime(2022, 10, 27, 10, 6, 9, 704, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 11, 14, 26, 6, 725, DateTimeKind.Local).AddTicks(5702), "Aperiam sapiente ut ", 20, "Tasty Wooden Gloves", new DateTime(2022, 2, 21, 13, 46, 14, 960, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 21, 5, 56, 6, 298, DateTimeKind.Local).AddTicks(5716), "Voluptate consequatu", 2, "Practical Rubber Hat", new DateTime(2022, 11, 26, 22, 2, 24, 738, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 8, 11, 38, 38, 939, DateTimeKind.Local).AddTicks(2053), "Quia voluptatem quod", "Handcrafted Fresh Sausages", new DateTime(2022, 8, 9, 13, 14, 8, 993, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 20, 16, 40, 49, 420, DateTimeKind.Local).AddTicks(1309), "Totam rerum voluptat", 11, "Sleek Fresh Soap", new DateTime(2022, 4, 14, 20, 5, 0, 179, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 28, 51, 461, DateTimeKind.Local).AddTicks(5475), "Molestiae optio sapi", 17, "Handcrafted Soft Pants", new DateTime(2022, 10, 22, 18, 25, 35, 218, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 28, 22, 38, 23, 869, DateTimeKind.Local).AddTicks(2619), "Eaque voluptatum ali", 10, "Sleek Frozen Sausages", new DateTime(2022, 11, 22, 21, 26, 48, 770, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 9, 22, 41, 59, 353, DateTimeKind.Local).AddTicks(3135), "Libero voluptatem pe", 10, "Ergonomic Frozen Chicken", new DateTime(2022, 11, 12, 6, 45, 3, 777, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 28, 3, 29, 45, 846, DateTimeKind.Local).AddTicks(599), "Consequatur vel dele", 8, "Ergonomic Rubber Shoes", new DateTime(2022, 11, 2, 5, 36, 29, 126, DateTimeKind.Local).AddTicks(8016) });

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
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 6, 16, 19, 3, 53, 227, DateTimeKind.Local).AddTicks(9567), "Et id explicabo inci", "Incredible Soft Hat", new DateTime(2023, 1, 12, 18, 7, 11, 124, DateTimeKind.Local).AddTicks(4695), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 8, 9, 4, 54, 47, 338, DateTimeKind.Local).AddTicks(7457), "Nihil illo ad dolore", "Unbranded Rubber Shoes", new DateTime(2022, 5, 31, 10, 38, 50, 88, DateTimeKind.Local).AddTicks(6478), null });

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

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 5, 6, 0, 44, 33, 963, DateTimeKind.Local).AddTicks(2757), "Sed quaerat quos ali", 2, "Small Plastic Shirt", new DateTime(2022, 5, 10, 9, 42, 0, 706, DateTimeKind.Local).AddTicks(7903), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 11, 5, 6, 59, 6, 188, DateTimeKind.Local).AddTicks(7464), "Repudiandae laborios", 1, "Sleek Granite Car", new DateTime(2022, 12, 27, 20, 20, 16, 64, DateTimeKind.Local).AddTicks(1422), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 3, 15, 3, 41, 54, 972, DateTimeKind.Local).AddTicks(2770), "Quia delectus sit cu", 4, "Gorgeous Metal Fish", new DateTime(2022, 2, 17, 15, 39, 23, 354, DateTimeKind.Local).AddTicks(268), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 11, 26, 23, 55, 13, 636, DateTimeKind.Local).AddTicks(5218), "Sunt ut enim vel dic", "Practical Wooden Keyboard", new DateTime(2022, 12, 12, 1, 57, 45, 441, DateTimeKind.Local).AddTicks(9344), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 1, 11, 14, 44, 18, 410, DateTimeKind.Local).AddTicks(9899), "Rem commodi rem. Dol", 5, "Licensed Fresh Tuna", new DateTime(2022, 11, 11, 4, 42, 55, 93, DateTimeKind.Local).AddTicks(767), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 4, 11, 10, 23, 14, 937, DateTimeKind.Local).AddTicks(8793), "Ad dolorem in. Eius ", 4, "Small Fresh Computer", new DateTime(2022, 10, 31, 4, 3, 50, 187, DateTimeKind.Local).AddTicks(2555), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 4, 19, 7, 56, 31, 22, DateTimeKind.Local).AddTicks(8969), "Praesentium fugit au", 4, "Handmade Cotton Salad", new DateTime(2022, 10, 14, 7, 12, 13, 110, DateTimeKind.Local).AddTicks(7858), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 8, 30, 13, 30, 28, 390, DateTimeKind.Local).AddTicks(2457), "Quis incidunt verita", 3, "Generic Soft Salad", new DateTime(2022, 4, 16, 15, 13, 7, 201, DateTimeKind.Local).AddTicks(4434), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 4, 30, 13, 8, 21, 596, DateTimeKind.Local).AddTicks(4823), "Ea vel libero vel. A", "Fantastic Plastic Chicken", new DateTime(2022, 6, 3, 0, 6, 30, 42, DateTimeKind.Local).AddTicks(2985), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 7, 30, 1, 2, 3, 30, DateTimeKind.Local).AddTicks(2282), "Commodi quia cum. Mo", 4, "Rustic Plastic Cheese", new DateTime(2022, 12, 11, 14, 8, 2, 615, DateTimeKind.Local).AddTicks(3497), null });

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

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_UserId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 12, 6, 31, 42, 47, DateTimeKind.Local).AddTicks(9996), "Sed quasi corrupti l", 1, "Awesome Soft Gloves", new DateTime(2022, 6, 29, 17, 24, 44, 999, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 11, 6, 5, 16, 664, DateTimeKind.Local).AddTicks(7997), "Placeat sequi est. F", 7, "Small Plastic Computer", new DateTime(2022, 10, 25, 0, 41, 23, 373, DateTimeKind.Local).AddTicks(1426) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 11, 17, 16, 43, 6, DateTimeKind.Local).AddTicks(5467), "Qui qui ad incidunt ", 10, "Fantastic Soft Cheese", new DateTime(2022, 12, 27, 11, 48, 59, 798, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 29, 19, 3, 24, 425, DateTimeKind.Local).AddTicks(3637), "Dolores eaque quasi ", 16, "Unbranded Plastic Cheese", new DateTime(2022, 6, 20, 6, 21, 25, 125, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 3, 17, 39, 35, 749, DateTimeKind.Local).AddTicks(5689), "Illum omnis tempore ", 15, "Refined Frozen Chair", new DateTime(2022, 12, 28, 14, 28, 21, 388, DateTimeKind.Local).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 13, 22, 13, 24, 425, DateTimeKind.Local).AddTicks(2299), "Quasi voluptate quia", 12, "Fantastic Cotton Shoes", new DateTime(2023, 1, 7, 16, 57, 27, 961, DateTimeKind.Local).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 27, 6, 32, 2, 296, DateTimeKind.Local).AddTicks(5951), "Quo facilis maxime p", 10, "Incredible Rubber Keyboard", new DateTime(2022, 3, 20, 6, 2, 46, 806, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 2, 10, 37, 2, 867, DateTimeKind.Local).AddTicks(4773), "Nulla ut quia. Et su", 5, "Unbranded Steel Hat", new DateTime(2022, 7, 14, 10, 51, 57, 265, DateTimeKind.Local).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 27, 12, 52, 31, 81, DateTimeKind.Local).AddTicks(7363), "Aliquam est exceptur", 10, "Small Cotton Shoes", new DateTime(2022, 4, 27, 7, 34, 28, 250, DateTimeKind.Local).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 31, 21, 54, 54, 339, DateTimeKind.Local).AddTicks(994), "Dolores officiis pro", 15, "Handmade Soft Salad", new DateTime(2022, 2, 21, 10, 4, 4, 960, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 19, 21, 13, 45, 904, DateTimeKind.Local).AddTicks(2734), "Eligendi aliquam exc", 20, "Ergonomic Steel Gloves", new DateTime(2022, 3, 27, 9, 7, 2, 197, DateTimeKind.Local).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 12, 23, 25, 42, 758, DateTimeKind.Local).AddTicks(7761), "Ut voluptates distin", 16, "Sleek Metal Mouse", new DateTime(2023, 1, 25, 6, 53, 14, 421, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 51, 39, 634, DateTimeKind.Local).AddTicks(1467), "Numquam pariatur eaq", 11, "Ergonomic Concrete Chair", new DateTime(2022, 12, 8, 19, 20, 22, 346, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 25, 23, 34, 23, 238, DateTimeKind.Local).AddTicks(899), "Dolore nam eligendi ", 5, "Fantastic Plastic Hat", new DateTime(2022, 3, 5, 21, 26, 19, 733, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 2, 8, 43, 4, 237, DateTimeKind.Local).AddTicks(7392), "Unde non ut voluptat", "Fantastic Cotton Towels", new DateTime(2022, 7, 30, 23, 38, 3, 373, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 14, 9, 41, 41, 714, DateTimeKind.Local).AddTicks(8732), "Inventore quibusdam ", 12, "Awesome Fresh Ball", new DateTime(2022, 7, 6, 21, 41, 34, 799, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 21, 22, 49, 18, 745, DateTimeKind.Local).AddTicks(3024), "Occaecati voluptatib", 3, "Tasty Wooden Soap", new DateTime(2022, 6, 12, 16, 35, 18, 507, DateTimeKind.Local).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 6, 1, 6, 11, 139, DateTimeKind.Local).AddTicks(8264), "Vel cupiditate exped", 9, "Rustic Fresh Car", new DateTime(2022, 3, 13, 6, 26, 0, 195, DateTimeKind.Local).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 22, 23, 8, 23, 895, DateTimeKind.Local).AddTicks(6964), "Recusandae quos impe", 3, "Handcrafted Soft Computer", new DateTime(2023, 2, 4, 6, 16, 16, 427, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 7, 19, 0, 17, 514, DateTimeKind.Local).AddTicks(7539), "Aut aut voluptatem r", 10, "Tasty Concrete Pizza", new DateTime(2022, 11, 23, 16, 37, 27, 221, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 23, 21, 3, 18, 923, DateTimeKind.Local).AddTicks(5276), "Aliquid suscipit qui", 5, "Generic Cotton Chair", new DateTime(2022, 8, 21, 12, 57, 16, 921, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 26, 7, 24, 26, 825, DateTimeKind.Local).AddTicks(6747), "Rem numquam sed dist", 5, "Fantastic Fresh Ball", new DateTime(2022, 4, 4, 1, 4, 44, 964, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 34, 13, 769, DateTimeKind.Local).AddTicks(9674), "Quidem in in ea a of", "Sleek Fresh Fish", new DateTime(2022, 6, 11, 20, 3, 48, 207, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 25, 20, 10, 19, 7, DateTimeKind.Local).AddTicks(4290), "Ut laborum dolorum p", "Refined Frozen Cheese", new DateTime(2023, 1, 27, 20, 7, 37, 547, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 6, 2, 43, 1, 379, DateTimeKind.Local).AddTicks(9554), "Sit et vero. Dicta l", 1, "Ergonomic Concrete Sausages", new DateTime(2022, 4, 23, 16, 58, 3, 917, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 8, 22, 36, 27, 553, DateTimeKind.Local).AddTicks(3186), "Commodi pariatur rem", 2, "Gorgeous Steel Shoes", new DateTime(2022, 3, 16, 19, 49, 30, 807, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 2, 19, 9, 59, 49, 305, DateTimeKind.Local).AddTicks(9862), "Necessitatibus qui l", 5, "Fantastic Rubber Bike", new DateTime(2023, 1, 29, 22, 53, 8, 129, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 6, 0, 32, 32, 860, DateTimeKind.Local).AddTicks(4923), "Blanditiis fuga et a", 2, "Generic Granite Mouse", new DateTime(2022, 4, 9, 18, 3, 48, 510, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 26, 11, 11, 15, 579, DateTimeKind.Local).AddTicks(1292), "Corporis in neque ex", 4, "Intelligent Granite Salad", new DateTime(2022, 6, 30, 20, 28, 28, 427, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 7, 26, 988, DateTimeKind.Local).AddTicks(6786), "Eveniet doloremque r", 4, "Incredible Cotton Computer", new DateTime(2022, 4, 12, 11, 9, 11, 392, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 11, 18, 27, 29, 607, DateTimeKind.Local).AddTicks(6106), "Dolorem perferendis ", 4, "Unbranded Cotton Car", new DateTime(2022, 10, 9, 16, 38, 15, 761, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 2, 23, 3, 4, 58, 747, DateTimeKind.Local).AddTicks(6650), "Corrupti ratione dic", 4, "Unbranded Fresh Shirt", new DateTime(2022, 12, 11, 0, 16, 38, 311, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 12, 16, 48, 43, 715, DateTimeKind.Local).AddTicks(9596), "Eum officiis est in ", 5, "Incredible Soft Keyboard", new DateTime(2022, 7, 22, 22, 4, 59, 635, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 4, 0, 46, 52, 315, DateTimeKind.Local).AddTicks(4887), "Voluptate reiciendis", "Awesome Concrete Sausages", new DateTime(2022, 2, 21, 12, 9, 16, 615, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 12, 19, 51, 49, 513, DateTimeKind.Local).AddTicks(7110), "Eaque ipsam non inci", 3, "Licensed Concrete Tuna", new DateTime(2022, 5, 31, 0, 15, 21, 902, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 17, 11, 3, 35, 24, DateTimeKind.Local).AddTicks(856), "Adipisci quos autem ", 3, "Gorgeous Rubber Shoes", new DateTime(2022, 5, 1, 20, 48, 6, 159, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 11, 15, 24, 14, 656, DateTimeKind.Local).AddTicks(588), "Illum ea accusamus. ", 1, "Incredible Wooden Keyboard", new DateTime(2023, 1, 23, 1, 41, 30, 510, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 29, 7, 26, 5, 498, DateTimeKind.Local).AddTicks(2714), "Dignissimos necessit", 2, "Fantastic Fresh Gloves", new DateTime(2022, 2, 14, 21, 38, 23, 704, DateTimeKind.Local).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 7, 9, 59, 40, 364, DateTimeKind.Local).AddTicks(5627), "Dolor et dolorem et ", "Ergonomic Wooden Pants", new DateTime(2022, 6, 12, 2, 10, 48, 667, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 19, 2, 33, 48, 913, DateTimeKind.Local).AddTicks(6584), "Beatae corrupti aut ", 3, "Incredible Soft Cheese", new DateTime(2023, 1, 14, 15, 40, 43, 782, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Rosemary_Hickle5@yahoo.com", "Vena Walsh", "_vXg4k2x71" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Hubert42@gmail.com", "Helene Torp", "0b5YYSq6G9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Brooks46@yahoo.com", "Constance Mueller", "sjIzImTl2c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Eldon.Murray@gmail.com", "Shanon Auer", "N0xdxHFpL5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Katlynn.Considine@gmail.com", "Ima Braun", "VDozahKnYq" });

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
