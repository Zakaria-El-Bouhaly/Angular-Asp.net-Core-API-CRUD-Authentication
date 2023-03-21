using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Colab.Migrations
{
    /// <inheritdoc />
    public partial class new4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Projects_ProjectRefId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_ownerId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ownerId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_ProjectRefId",
                table: "Assignments");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Projects",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Assignments",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 16, 21, 17, 51, 40, DateTimeKind.Local).AddTicks(5886), "Sequi iusto omnis am", null, "Handmade Wooden Ball", new DateTime(2022, 10, 6, 8, 7, 28, 411, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 24, 23, 44, 17, 831, DateTimeKind.Local).AddTicks(4276), "Enim inventore reici", null, 8, "Awesome Concrete Fish", new DateTime(2022, 10, 10, 2, 27, 56, 89, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 27, 9, 33, 58, 358, DateTimeKind.Local).AddTicks(8997), "Est quia aut odit do", null, 10, "Gorgeous Fresh Gloves", new DateTime(2022, 10, 5, 10, 39, 11, 471, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 28, 17, 30, 24, 903, DateTimeKind.Local).AddTicks(5220), "Quo amet consequuntu", null, "Handmade Granite Shoes", new DateTime(2022, 4, 22, 18, 11, 43, 373, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 15, 3, 17, 47, 916, DateTimeKind.Local).AddTicks(6045), "Beatae commodi repel", null, "Rustic Granite Cheese", new DateTime(2022, 9, 2, 21, 14, 46, 688, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 14, 1, 32, 20, 64, DateTimeKind.Local).AddTicks(9940), "Voluptatum asperiore", null, 5, "Practical Fresh Bike", new DateTime(2022, 11, 30, 18, 16, 48, 494, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 11, 5, 16, 35, 486, DateTimeKind.Local).AddTicks(2518), "Rerum aut natus quid", null, 1, "Fantastic Cotton Hat", new DateTime(2022, 9, 14, 5, 1, 38, 799, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 2, 8, 43, DateTimeKind.Local).AddTicks(956), "Eligendi neque cumqu", null, 3, "Awesome Rubber Towels", new DateTime(2022, 8, 14, 18, 0, 26, 666, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 3, 12, 50, 53, 609, DateTimeKind.Local).AddTicks(2748), "Et tempore itaque cu", null, 8, "Small Granite Shirt", new DateTime(2023, 1, 20, 4, 52, 9, 697, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 2, 23, 17, 35, 12, 446, DateTimeKind.Local).AddTicks(108), "Qui amet sed vel por", null, 3, "Refined Wooden Salad", new DateTime(2023, 1, 8, 6, 5, 57, 855, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId", "ownerId" },
                values: new object[] { new DateTime(2023, 2, 8, 5, 50, 54, 432, DateTimeKind.Local).AddTicks(4155), "Explicabo est dolore", "Licensed Fresh Table", new DateTime(2022, 8, 16, 23, 13, 46, 373, DateTimeKind.Local).AddTicks(2010), null, 2 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 1, 23, 11, 42, 33, 131, DateTimeKind.Local).AddTicks(2082), "Quas beatae veniam d", "Rustic Steel Tuna", new DateTime(2022, 4, 20, 16, 34, 8, 384, DateTimeKind.Local).AddTicks(7997), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 2, 12, 3, 53, 53, 129, DateTimeKind.Local).AddTicks(1670), "Iusto voluptas simil", "Practical Cotton Shoes", new DateTime(2023, 1, 25, 1, 26, 14, 778, DateTimeKind.Local).AddTicks(743), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 44, 59, 898, DateTimeKind.Local).AddTicks(9459), "At est a quam ut ips", "Gorgeous Frozen Car", new DateTime(2022, 10, 29, 5, 36, 9, 394, DateTimeKind.Local).AddTicks(8190), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 9, 22, 6, 26, 51, 18, DateTimeKind.Local).AddTicks(395), "Voluptas expedita mo", "Incredible Concrete Chips", new DateTime(2022, 3, 12, 7, 59, 12, 497, DateTimeKind.Local).AddTicks(142), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId", "ownerId" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 31, 45, 52, DateTimeKind.Local).AddTicks(883), "Et est harum beatae ", "Small Fresh Pants", new DateTime(2022, 7, 30, 7, 38, 41, 374, DateTimeKind.Local).AddTicks(8042), null, 1 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId", "ownerId" },
                values: new object[] { new DateTime(2022, 7, 29, 6, 36, 11, 655, DateTimeKind.Local).AddTicks(4502), "In et assumenda porr", "Handcrafted Wooden Ball", new DateTime(2022, 12, 31, 15, 18, 54, 423, DateTimeKind.Local).AddTicks(5650), null, 4 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 4, 20, 18, 24, 4, 846, DateTimeKind.Local).AddTicks(4365), "Nulla vitae repudian", "Unbranded Soft Pizza", new DateTime(2022, 5, 13, 4, 9, 28, 134, DateTimeKind.Local).AddTicks(2778), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 2, 12, 18, 46, 1, 638, DateTimeKind.Local).AddTicks(4538), "Aliquam blanditiis e", "Intelligent Fresh Soap", new DateTime(2022, 12, 6, 8, 9, 41, 692, DateTimeKind.Local).AddTicks(5904), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId", "ownerId" },
                values: new object[] { new DateTime(2022, 2, 17, 21, 38, 52, 59, DateTimeKind.Local).AddTicks(6618), "Corporis doloremque ", "Incredible Fresh Shirt", new DateTime(2022, 8, 2, 15, 45, 1, 846, DateTimeKind.Local).AddTicks(929), null, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Shane2@yahoo.com", "Jaylan Tillman", "3SQqpEfUIT" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Vilma.Bartoletti@hotmail.com", "Jairo Shanahan", "qOgZjM9SwO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Kevin88@yahoo.com", "Roma Ebert", "To_5gOLIN3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Gertrude.Jakubowski88@yahoo.com", "Adell Purdy", "hp5ntEDUgJ" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Lennie.Russel87@hotmail.com", "Anastasia Bosco", "icwMXXvAV9" });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_ProjectId",
                table: "Assignments",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Projects_ProjectId",
                table: "Assignments",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

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
                name: "FK_Assignments_Projects_ProjectId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_UserId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_ProjectId",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Assignments");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 7, 14, 38, 12, 404, DateTimeKind.Local).AddTicks(483), "Ea voluptas dolor po", "Handcrafted Wooden Towels", new DateTime(2022, 8, 24, 5, 39, 53, 332, DateTimeKind.Local).AddTicks(8537) });

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
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 40, 38, 87, DateTimeKind.Local).AddTicks(5837), "Nulla qui illum tene", "Gorgeous Granite Gloves", new DateTime(2022, 4, 1, 17, 58, 8, 138, DateTimeKind.Local).AddTicks(8774) });

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
                columns: new[] { "CreatedAt", "Description", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 2, 22, 50, 32, 176, DateTimeKind.Local).AddTicks(7771), "Explicabo nesciunt b", 10, "Intelligent Wooden Car", new DateTime(2023, 1, 24, 23, 5, 23, 616, DateTimeKind.Local).AddTicks(1422) });

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
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "ownerId" },
                values: new object[] { new DateTime(2022, 4, 11, 3, 29, 22, 831, DateTimeKind.Local).AddTicks(5820), "Reprehenderit nemo e", "Small Soft Shirt", new DateTime(2023, 2, 5, 15, 2, 55, 783, DateTimeKind.Local).AddTicks(7249), 1 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 3, 19, 7, 52, 135, DateTimeKind.Local).AddTicks(2534), "Id optio sunt earum.", "Handcrafted Metal Bacon", new DateTime(2023, 2, 5, 0, 39, 47, 986, DateTimeKind.Local).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 25, 1, 51, 27, 728, DateTimeKind.Local).AddTicks(6937), "Minus velit facere d", "Refined Rubber Sausages", new DateTime(2022, 7, 22, 1, 7, 22, 957, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 15, 8, 59, 48, 508, DateTimeKind.Local).AddTicks(662), "Quia et ut animi fac", "Awesome Rubber Shirt", new DateTime(2022, 11, 26, 21, 46, 53, 247, DateTimeKind.Local).AddTicks(4449) });

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
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "ownerId" },
                values: new object[] { new DateTime(2022, 6, 16, 4, 17, 41, 466, DateTimeKind.Local).AddTicks(737), "Corporis omnis volup", "Generic Frozen Mouse", new DateTime(2023, 1, 23, 8, 26, 52, 755, DateTimeKind.Local).AddTicks(429), 3 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 18, 15, 30, 1, 110, DateTimeKind.Local).AddTicks(7201), "Occaecati voluptatib", "Awesome Steel Salad", new DateTime(2022, 7, 30, 19, 4, 48, 584, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 30, 19, 27, 55, 131, DateTimeKind.Local).AddTicks(2908), "Molestias autem erro", "Handcrafted Frozen Chicken", new DateTime(2022, 11, 4, 23, 50, 1, 85, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "ownerId" },
                values: new object[] { new DateTime(2022, 7, 11, 4, 20, 16, 965, DateTimeKind.Local).AddTicks(5285), "Repellat quod ipsam ", "Ergonomic Concrete Bike", new DateTime(2022, 8, 21, 1, 32, 30, 168, DateTimeKind.Local).AddTicks(1833), 1 });

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

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ownerId",
                table: "Projects",
                column: "ownerId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_ProjectRefId",
                table: "Assignments",
                column: "ProjectRefId");

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
    }
}
