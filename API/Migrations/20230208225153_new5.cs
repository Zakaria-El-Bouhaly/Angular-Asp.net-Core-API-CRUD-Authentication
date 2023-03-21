using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Colab.Migrations
{
    /// <inheritdoc />
    public partial class new5 : Migration
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

            migrationBuilder.DropIndex(
                name: "IX_Projects_UserId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectRefId",
                table: "Assignments");

            migrationBuilder.RenameColumn(
                name: "ownerId",
                table: "Projects",
                newName: "OwnerId");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Assignments",
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
                values: new object[] { new DateTime(2022, 6, 15, 10, 53, 27, 834, DateTimeKind.Local).AddTicks(8215), "Ut est nulla. Nulla ", 10, "Gorgeous Soft Computer", new DateTime(2022, 11, 14, 15, 0, 6, 44, DateTimeKind.Local).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 24, 14, 43, 47, 42, DateTimeKind.Local).AddTicks(9665), "Est ipsa beatae cupi", 7, "Ergonomic Cotton Ball", new DateTime(2022, 10, 30, 23, 14, 42, 783, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 18, 2, 41, 16, 97, DateTimeKind.Local).AddTicks(2525), "Laudantium dolores e", 5, "Generic Soft Tuna", new DateTime(2022, 2, 13, 14, 13, 20, 85, DateTimeKind.Local).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 20, 12, 34, 19, 897, DateTimeKind.Local).AddTicks(409), "Voluptatibus qui vol", 2, "Practical Steel Chair", new DateTime(2022, 8, 8, 12, 7, 33, 248, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 2, 28, 12, 5, 54, 5, DateTimeKind.Local).AddTicks(4005), "Minima perferendis s", 6, "Intelligent Soft Shoes", new DateTime(2022, 10, 27, 13, 0, 18, 601, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 3, 39, 47, 978, DateTimeKind.Local).AddTicks(3344), "Sit explicabo blandi", 9, "Unbranded Steel Shoes", new DateTime(2022, 11, 14, 1, 35, 0, 547, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 2, 20, 6, 46, 43, 329, DateTimeKind.Local).AddTicks(7359), "Fugiat quis consequa", 1, "Handcrafted Plastic Ball", new DateTime(2022, 3, 14, 8, 46, 5, 69, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 24, 20, 26, 44, 4, DateTimeKind.Local).AddTicks(3934), "Officia fugit quia d", 2, "Fantastic Granite Salad", new DateTime(2022, 8, 30, 0, 52, 57, 557, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 13, 23, 11, 37, 945, DateTimeKind.Local).AddTicks(1293), "Accusamus eaque culp", 3, "Gorgeous Steel Pizza", new DateTime(2022, 12, 1, 4, 3, 30, 492, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 23, 17, 59, 12, 287, DateTimeKind.Local).AddTicks(2694), "Cumque est et impedi", 8, "Fantastic Rubber Cheese", new DateTime(2022, 9, 1, 12, 52, 16, 304, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 23, 14, 31, 45, 395, DateTimeKind.Local).AddTicks(3), "Omnis dolor recusand", 3, "Practical Concrete Shoes", new DateTime(2022, 11, 15, 21, 54, 33, 533, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 12, 45, 49, 648, DateTimeKind.Local).AddTicks(7102), "Dolorem est unde sap", 1, "Awesome Plastic Mouse", new DateTime(2022, 10, 16, 6, 54, 45, 411, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 6, 2, 24, 20, 879, DateTimeKind.Local).AddTicks(6905), "Hic rerum nam molest", 4, "Ergonomic Steel Shirt", new DateTime(2022, 10, 26, 11, 18, 3, 606, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 18, 19, 58, 8, 454, DateTimeKind.Local).AddTicks(70), "Illum cum sed volupt", 3, "Practical Soft Keyboard", new DateTime(2023, 1, 7, 13, 34, 25, 17, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 21, 15, 48, 45, 564, DateTimeKind.Local).AddTicks(5152), "Doloribus commodi vo", 2, "Gorgeous Cotton Pants", new DateTime(2022, 9, 13, 3, 27, 35, 786, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 14, 47, 48, 16, DateTimeKind.Local).AddTicks(2700), "Quia atque error rer", 4, "Intelligent Frozen Chicken", new DateTime(2022, 10, 23, 23, 5, 58, 162, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 30, 0, 716, DateTimeKind.Local).AddTicks(5479), "Repudiandae itaque h", 1, "Incredible Fresh Pizza", new DateTime(2022, 6, 30, 13, 25, 51, 903, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 8, 12, 27, 52, 126, DateTimeKind.Local).AddTicks(8887), "Ipsa praesentium rep", 1, "Ergonomic Soft Keyboard", new DateTime(2022, 7, 11, 17, 31, 54, 478, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 11, 3, 18, 2, 437, DateTimeKind.Local).AddTicks(6499), "Aut necessitatibus q", 5, "Small Metal Shirt", new DateTime(2022, 11, 1, 15, 45, 3, 775, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 10, 9, 48, 51, 789, DateTimeKind.Local).AddTicks(8718), "Quae reiciendis magn", "Refined Soft Sausages", new DateTime(2022, 6, 2, 0, 50, 12, 588, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Michelle_Glover@yahoo.com", "Rowena Harris", "l1i4EtSxcu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Camille55@hotmail.com", "Kelli Smith", "7hI2SVsGwy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Lauren.Jerde@gmail.com", "Hassie Cormier", "nSK0jQLdTv" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Evalyn_Jenkins@yahoo.com", "Audra Breitenberg", "hD4cksfwl9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "Rocky.Collins@yahoo.com", "Jaylan Cummerata", "6pY6u3m2V3" });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_OwnerId",
                table: "Projects",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Projects_ProjectId",
                table: "Assignments",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_OwnerId",
                table: "Projects",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Projects_ProjectId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_OwnerId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_OwnerId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Projects",
                newName: "ownerId");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Projects",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Assignments",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "ProjectRefId",
                table: "Assignments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 16, 21, 17, 51, 40, DateTimeKind.Local).AddTicks(5886), "Sequi iusto omnis am", null, 2, "Handmade Wooden Ball", new DateTime(2022, 10, 6, 8, 7, 28, 411, DateTimeKind.Local).AddTicks(372) });

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
                columns: new[] { "CreatedAt", "Description", "ProjectId", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 28, 17, 30, 24, 903, DateTimeKind.Local).AddTicks(5220), "Quo amet consequuntu", null, 4, "Handmade Granite Shoes", new DateTime(2022, 4, 22, 18, 11, 43, 373, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "ProjectRefId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 15, 3, 17, 47, 916, DateTimeKind.Local).AddTicks(6045), "Beatae commodi repel", null, 4, "Rustic Granite Cheese", new DateTime(2022, 9, 2, 21, 14, 46, 688, DateTimeKind.Local).AddTicks(5291) });

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
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId", "ownerId" },
                values: new object[] { new DateTime(2023, 1, 23, 11, 42, 33, 131, DateTimeKind.Local).AddTicks(2082), "Quas beatae veniam d", "Rustic Steel Tuna", new DateTime(2022, 4, 20, 16, 34, 8, 384, DateTimeKind.Local).AddTicks(7997), null, 4 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId", "ownerId" },
                values: new object[] { new DateTime(2022, 2, 12, 3, 53, 53, 129, DateTimeKind.Local).AddTicks(1670), "Iusto voluptas simil", "Practical Cotton Shoes", new DateTime(2023, 1, 25, 1, 26, 14, 778, DateTimeKind.Local).AddTicks(743), null, 3 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId", "ownerId" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 44, 59, 898, DateTimeKind.Local).AddTicks(9459), "At est a quam ut ips", "Gorgeous Frozen Car", new DateTime(2022, 10, 29, 5, 36, 9, 394, DateTimeKind.Local).AddTicks(8190), null, 1 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId", "ownerId" },
                values: new object[] { new DateTime(2022, 9, 22, 6, 26, 51, 18, DateTimeKind.Local).AddTicks(395), "Voluptas expedita mo", "Incredible Concrete Chips", new DateTime(2022, 3, 12, 7, 59, 12, 497, DateTimeKind.Local).AddTicks(142), null, 1 });

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
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId", "ownerId" },
                values: new object[] { new DateTime(2022, 4, 20, 18, 24, 4, 846, DateTimeKind.Local).AddTicks(4365), "Nulla vitae repudian", "Unbranded Soft Pizza", new DateTime(2022, 5, 13, 4, 9, 28, 134, DateTimeKind.Local).AddTicks(2778), null, 4 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId", "ownerId" },
                values: new object[] { new DateTime(2022, 2, 12, 18, 46, 1, 638, DateTimeKind.Local).AddTicks(4538), "Aliquam blanditiis e", "Intelligent Fresh Soap", new DateTime(2022, 12, 6, 8, 9, 41, 692, DateTimeKind.Local).AddTicks(5904), null, 4 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 2, 17, 21, 38, 52, 59, DateTimeKind.Local).AddTicks(6618), "Corporis doloremque ", "Incredible Fresh Shirt", new DateTime(2022, 8, 2, 15, 45, 1, 846, DateTimeKind.Local).AddTicks(929), null });

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
    }
}
