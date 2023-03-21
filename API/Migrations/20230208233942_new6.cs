using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Colab.Migrations
{
    /// <inheritdoc />
    public partial class new6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 2, 19, 3, 56, 34, 524, DateTimeKind.Local).AddTicks(9791), "Sed necessitatibus t", "Gorgeous Metal Chips", new DateTime(2022, 5, 1, 10, 14, 38, 498, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 2, 9, 38, 14, 189, DateTimeKind.Local).AddTicks(4978), "Aut accusamus vitae ", 2, "Handmade Cotton Gloves", new DateTime(2022, 3, 21, 6, 42, 27, 705, DateTimeKind.Local).AddTicks(7917) });

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
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 0, 12, 22, 114, DateTimeKind.Local).AddTicks(3990), "Ut autem explicabo u", 1, "Intelligent Rubber Ball", new DateTime(2022, 8, 4, 23, 36, 9, 168, DateTimeKind.Local).AddTicks(7057) });

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
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 26, 16, 16, 15, 855, DateTimeKind.Local).AddTicks(3557), "Suscipit temporibus ", 5, "Rustic Granite Chips", new DateTime(2022, 2, 16, 9, 6, 4, 768, DateTimeKind.Local).AddTicks(8341) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 23, 14, 31, 45, 395, DateTimeKind.Local).AddTicks(3), "Omnis dolor recusand", "Practical Concrete Shoes", new DateTime(2022, 11, 15, 21, 54, 33, 533, DateTimeKind.Local).AddTicks(6470) });

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
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 14, 47, 48, 16, DateTimeKind.Local).AddTicks(2700), "Quia atque error rer", "Intelligent Frozen Chicken", new DateTime(2022, 10, 23, 23, 5, 58, 162, DateTimeKind.Local).AddTicks(5033) });

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
                columns: new[] { "CreatedAt", "Description", "OwnerId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 10, 9, 48, 51, 789, DateTimeKind.Local).AddTicks(8718), "Quae reiciendis magn", 5, "Refined Soft Sausages", new DateTime(2022, 6, 2, 0, 50, 12, 588, DateTimeKind.Local).AddTicks(7442) });

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
        }
    }
}
