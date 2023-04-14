using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Colab.Migrations
{
    /// <inheritdoc />
    public partial class passwordreset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PasswordResetTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Token = table.Column<string>(type: "TEXT", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordResetTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PasswordResetTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2022, 9, 24, 17, 27, 28, 532, DateTimeKind.Local).AddTicks(5243), "Voluptate consequatu", 9, "Small Plastic Chair", new DateTime(2023, 1, 30, 1, 37, 26, 884, DateTimeKind.Local).AddTicks(1147), 2, 2 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2022, 11, 1, 15, 28, 43, 981, DateTimeKind.Local).AddTicks(7911), "Unde sit consequatur", 9, "Ergonomic Granite Gloves", new DateTime(2022, 11, 26, 21, 26, 53, 195, DateTimeKind.Local).AddTicks(7196), 5, 2 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 9, 8, 19, 55, 50, 807, DateTimeKind.Local).AddTicks(2297), "Nihil error esse mod", 7, "Sleek Frozen Soap", new DateTime(2022, 5, 12, 0, 5, 8, 39, DateTimeKind.Local).AddTicks(8101), 4 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "state" },
                values: new object[] { new DateTime(2022, 4, 8, 16, 12, 3, 96, DateTimeKind.Local).AddTicks(3400), "Autem itaque magni e", 6, "Intelligent Rubber Shirt", new DateTime(2022, 12, 24, 5, 0, 7, 337, DateTimeKind.Local).AddTicks(3055), 2 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2023, 3, 8, 3, 47, 50, 1, DateTimeKind.Local).AddTicks(4289), "Ut velit architecto ", 3, "Awesome Frozen Chicken", new DateTime(2023, 1, 15, 13, 54, 3, 907, DateTimeKind.Local).AddTicks(2507), 5, 0 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 10, 8, 9, 33, 26, 201, DateTimeKind.Local).AddTicks(8518), "Non mollitia exercit", 4, "Practical Concrete Cheese", new DateTime(2022, 5, 24, 13, 23, 17, 620, DateTimeKind.Local).AddTicks(8524), 5 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2022, 7, 20, 0, 26, 11, 349, DateTimeKind.Local).AddTicks(2371), "Sed qui optio iusto ", 5, "Ergonomic Soft Pizza", new DateTime(2022, 4, 11, 22, 51, 59, 262, DateTimeKind.Local).AddTicks(5924), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2022, 6, 3, 18, 31, 21, 932, DateTimeKind.Local).AddTicks(1358), "Culpa veniam possimu", 10, "Handcrafted Frozen Keyboard", new DateTime(2022, 5, 4, 5, 54, 0, 368, DateTimeKind.Local).AddTicks(8235), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "state" },
                values: new object[] { new DateTime(2023, 3, 2, 2, 18, 54, 233, DateTimeKind.Local).AddTicks(9933), "Repellat rerum quod ", 4, "Ergonomic Cotton Ball", new DateTime(2023, 3, 5, 0, 5, 51, 554, DateTimeKind.Local).AddTicks(3487), 0 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2022, 6, 22, 22, 26, 2, 827, DateTimeKind.Local).AddTicks(1651), "Rerum ipsam providen", 1, "Ergonomic Rubber Bacon", new DateTime(2023, 1, 25, 13, 50, 30, 50, DateTimeKind.Local).AddTicks(7723), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2022, 4, 9, 7, 20, 57, 122, DateTimeKind.Local).AddTicks(3494), "Reprehenderit velit ", 10, "Gorgeous Fresh Salad", new DateTime(2022, 5, 8, 22, 33, 44, 365, DateTimeKind.Local).AddTicks(2263), 3, 0 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 1, 43, 17, 365, DateTimeKind.Local).AddTicks(6492), "Qui dignissimos quis", 4, "Licensed Granite Towels", new DateTime(2022, 7, 9, 14, 7, 52, 959, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 13, 7, 27, 46, 731, DateTimeKind.Local).AddTicks(3873), "Sint totam adipisci.", 1, "Intelligent Metal Gloves", new DateTime(2023, 2, 3, 8, 58, 34, 277, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2023, 1, 15, 20, 31, 32, 566, DateTimeKind.Local).AddTicks(1936), "Quia sequi molestiae", 5, "Practical Frozen Shirt", new DateTime(2023, 4, 4, 6, 57, 22, 117, DateTimeKind.Local).AddTicks(3640), 3, 0 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 10, 5, 13, 15, 11, 468, DateTimeKind.Local).AddTicks(8903), "Laudantium debitis l", 7, "Incredible Wooden Sausages", new DateTime(2022, 11, 22, 22, 32, 14, 479, DateTimeKind.Local).AddTicks(9686), 1 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 8, 14, 21, 25, 14, 7, DateTimeKind.Local).AddTicks(8724), "Reprehenderit ut ita", 6, "Licensed Concrete Bacon", new DateTime(2022, 6, 21, 16, 5, 19, 180, DateTimeKind.Local).AddTicks(176), 3 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2023, 3, 15, 22, 27, 46, 425, DateTimeKind.Local).AddTicks(5716), "Ad molestiae enim eo", 4, "Practical Soft Salad", new DateTime(2022, 4, 10, 1, 8, 4, 474, DateTimeKind.Local).AddTicks(2087), 3, 0 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 21, 41, 437, DateTimeKind.Local).AddTicks(4126), "Unde quo possimus mo", "Fantastic Soft Computer", new DateTime(2022, 6, 14, 15, 10, 14, 312, DateTimeKind.Local).AddTicks(6104), 1, 2 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "state" },
                values: new object[] { new DateTime(2022, 6, 12, 16, 59, 59, 671, DateTimeKind.Local).AddTicks(8086), "Eius facilis ad nobi", 1, "Incredible Metal Fish", new DateTime(2022, 11, 24, 15, 11, 21, 855, DateTimeKind.Local).AddTicks(7518), 2 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2022, 8, 20, 4, 37, 17, 752, DateTimeKind.Local).AddTicks(9622), "Molestiae perspiciat", "Gorgeous Cotton Mouse", new DateTime(2022, 10, 7, 12, 30, 7, 717, DateTimeKind.Local).AddTicks(6952), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 13, 4, 38, 11, 872, DateTimeKind.Local).AddTicks(3153), "Itaque est inventore", "Awesome Plastic Cheese", new DateTime(2022, 6, 19, 19, 30, 5, 609, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 16, 14, 29, 42, 908, DateTimeKind.Local).AddTicks(882), "Sit sed dolorem recu", "Handmade Granite Chicken", new DateTime(2022, 9, 4, 7, 28, 10, 134, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 7, 3, 32, 30, 166, DateTimeKind.Local).AddTicks(2866), "Est perspiciatis qui", "Rustic Frozen Towels", new DateTime(2022, 5, 28, 0, 53, 37, 902, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 7, 6, 58, 55, 665, DateTimeKind.Local).AddTicks(7928), "Est est ducimus saep", "Intelligent Concrete Shoes", new DateTime(2022, 11, 24, 18, 27, 35, 503, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 17, 0, 120, DateTimeKind.Local).AddTicks(3939), "Architecto omnis nem", "Handcrafted Soft Cheese", new DateTime(2023, 1, 18, 20, 1, 43, 550, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 5, 8, 35, 4, 694, DateTimeKind.Local).AddTicks(3275), "Id officia dolorem i", "Tasty Frozen Chicken", new DateTime(2022, 8, 27, 13, 37, 41, 224, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 48, 10, 684, DateTimeKind.Local).AddTicks(2675), "Debitis dignissimos ", "Sleek Cotton Tuna", new DateTime(2022, 6, 1, 0, 43, 19, 394, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 7, 12, 21, 36, 124, DateTimeKind.Local).AddTicks(9738), "Et molestiae officia", "Unbranded Rubber Car", new DateTime(2022, 9, 22, 4, 41, 29, 872, DateTimeKind.Local).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 11, 14, 59, 19, 47, DateTimeKind.Local).AddTicks(590), "Ut libero et sapient", "Handmade Plastic Bike", new DateTime(2022, 11, 28, 11, 48, 26, 618, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 24, 22, 41, 33, 447, DateTimeKind.Local).AddTicks(4176), "Aliquid alias autem ", "Handmade Plastic Fish", new DateTime(2022, 8, 30, 10, 45, 4, 270, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Password", "profilePicture" },
                values: new object[] { "Delphine_Stroman86@gmail.com", "Joanne Ortiz", "$2a$11$WDRnnEeoGt/S569ZArapT.jpb.Vwwi13aS67vFct5mB2EEjXqACRK", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/164.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password", "profilePicture" },
                values: new object[] { "Hyman.Kulas@hotmail.com", "Rahul Hodkiewicz", "$2a$11$GOltA.d/bE2qOerTXGIxVeKhX.ElZlrMCGT6LrQ0gLFzczysYwN/i", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/498.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Password", "profilePicture" },
                values: new object[] { "Modesto_Williamson61@hotmail.com", "Brent Weber", "$2a$11$4Fcw33d5ruCwjlEMZOj95eFvcqL1Tumh/lW3YbJw/Pu6.QC2LWJGO", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/104.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Password", "profilePicture" },
                values: new object[] { "Sallie.Brown@hotmail.com", "Maxwell Rogahn", "$2a$11$bnQERpVaO3aLxiMDPUnerO49jF4IgqyhIqI9X7MfCU2NqfyCyYzJ.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1120.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Password", "profilePicture" },
                values: new object[] { "Shawn9@gmail.com", "Georgiana Bode", "$2a$11$4Y9VL0TF0gs1o3JK1GYjue/0GQ8QoDS3Nl0ppHIK4XZo1teucMp4.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1114.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_PasswordResetTokens_UserId",
                table: "PasswordResetTokens",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PasswordResetTokens");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2022, 10, 14, 10, 36, 28, 290, DateTimeKind.Local).AddTicks(1549), "Delectus eligendi re", 5, "Intelligent Metal Pizza", new DateTime(2022, 12, 4, 21, 43, 55, 371, DateTimeKind.Local).AddTicks(4882), 1, 0 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2022, 11, 9, 21, 16, 35, 360, DateTimeKind.Local).AddTicks(1928), "Ex qui facilis reici", 7, "Small Concrete Salad", new DateTime(2023, 3, 31, 9, 33, 50, 595, DateTimeKind.Local).AddTicks(681), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2023, 2, 28, 19, 21, 20, 200, DateTimeKind.Local).AddTicks(2970), "Illum aut enim quas ", 4, "Fantastic Metal Car", new DateTime(2022, 9, 5, 8, 25, 27, 965, DateTimeKind.Local).AddTicks(9649), 5 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "state" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 41, 47, 381, DateTimeKind.Local).AddTicks(3619), "Iure vero perferendi", 8, "Unbranded Concrete Shoes", new DateTime(2022, 10, 9, 10, 56, 54, 801, DateTimeKind.Local).AddTicks(4625), 1 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2022, 11, 21, 23, 29, 36, 560, DateTimeKind.Local).AddTicks(2725), "Ut sapiente qui qui ", 7, "Ergonomic Frozen Cheese", new DateTime(2023, 2, 2, 20, 11, 27, 439, DateTimeKind.Local).AddTicks(7450), 1, 2 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 5, 12, 12, 1, 55, 193, DateTimeKind.Local).AddTicks(8326), "Hic autem dolor. Qui", 7, "Gorgeous Fresh Fish", new DateTime(2022, 8, 16, 12, 46, 33, 411, DateTimeKind.Local).AddTicks(3702), 4 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2022, 9, 15, 15, 11, 36, 537, DateTimeKind.Local).AddTicks(7432), "Quidem ex ut exceptu", 2, "Awesome Rubber Pants", new DateTime(2022, 4, 20, 3, 58, 0, 706, DateTimeKind.Local).AddTicks(8813), 2, 0 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2022, 12, 21, 12, 26, 3, 289, DateTimeKind.Local).AddTicks(4702), "Quod eveniet error e", 3, "Incredible Concrete Bacon", new DateTime(2022, 9, 19, 13, 19, 58, 508, DateTimeKind.Local).AddTicks(7025), 5, 0 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "state" },
                values: new object[] { new DateTime(2022, 8, 7, 21, 47, 13, 190, DateTimeKind.Local).AddTicks(8448), "In temporibus labori", 8, "Fantastic Steel Shirt", new DateTime(2022, 4, 14, 20, 37, 33, 153, DateTimeKind.Local).AddTicks(72), 1 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2023, 2, 4, 22, 37, 40, 542, DateTimeKind.Local).AddTicks(23), "Numquam non cum aspe", 9, "Small Concrete Mouse", new DateTime(2022, 9, 10, 19, 28, 27, 851, DateTimeKind.Local).AddTicks(3453), 1, 0 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2022, 5, 14, 20, 53, 4, 3, DateTimeKind.Local).AddTicks(8535), "Voluptatem voluptati", 3, "Gorgeous Granite Keyboard", new DateTime(2022, 6, 16, 20, 20, 29, 189, DateTimeKind.Local).AddTicks(4845), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 17, 3, 1, 59, 255, DateTimeKind.Local).AddTicks(5378), "Quisquam impedit ten", 8, "Practical Cotton Chair", new DateTime(2022, 9, 29, 10, 57, 1, 682, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 26, 18, 17, 34, 30, DateTimeKind.Local).AddTicks(2227), "Placeat provident mo", 8, "Ergonomic Metal Chair", new DateTime(2023, 1, 29, 15, 1, 18, 570, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2023, 3, 21, 3, 46, 10, 669, DateTimeKind.Local).AddTicks(8569), "Eum quisquam tenetur", 2, "Licensed Metal Table", new DateTime(2023, 2, 28, 21, 16, 0, 739, DateTimeKind.Local).AddTicks(5707), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 7, 1, 10, 29, 44, 637, DateTimeKind.Local).AddTicks(9038), "Rem maxime alias nob", 10, "Unbranded Metal Towels", new DateTime(2022, 11, 3, 2, 20, 6, 926, DateTimeKind.Local).AddTicks(1976), 5 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2022, 7, 1, 10, 25, 59, 239, DateTimeKind.Local).AddTicks(2792), "Voluptas doloribus m", 5, "Fantastic Frozen Table", new DateTime(2022, 8, 28, 17, 46, 51, 878, DateTimeKind.Local).AddTicks(6676), 1 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2023, 3, 12, 16, 13, 57, 487, DateTimeKind.Local).AddTicks(3830), "Debitis maiores dele", 1, "Practical Steel Towels", new DateTime(2022, 5, 24, 8, 44, 36, 183, DateTimeKind.Local).AddTicks(5076), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2022, 5, 8, 22, 59, 35, 335, DateTimeKind.Local).AddTicks(5661), "Aliquam impedit adip", "Rustic Rubber Tuna", new DateTime(2022, 10, 2, 4, 42, 34, 344, DateTimeKind.Local).AddTicks(1987), 4, 0 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Description", "ProjectId", "Title", "UpdatedAt", "state" },
                values: new object[] { new DateTime(2022, 8, 31, 17, 28, 58, 753, DateTimeKind.Local).AddTicks(305), "Occaecati inventore ", 10, "Tasty Rubber Hat", new DateTime(2023, 1, 5, 12, 59, 34, 991, DateTimeKind.Local).AddTicks(7968), 1 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt", "UserId", "state" },
                values: new object[] { new DateTime(2022, 12, 22, 1, 9, 59, 184, DateTimeKind.Local).AddTicks(2290), "Sunt quaerat quos ha", "Awesome Concrete Chicken", new DateTime(2022, 10, 11, 21, 51, 21, 895, DateTimeKind.Local).AddTicks(4613), 4, 2 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 22, 10, 51, 8, 701, DateTimeKind.Local).AddTicks(2689), "Commodi non consecte", "Intelligent Rubber Ball", new DateTime(2022, 6, 28, 11, 32, 56, 367, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 10, 16, 3, 43, 48, 631, DateTimeKind.Local).AddTicks(9174), "Nostrum voluptatum i", "Licensed Frozen Keyboard", new DateTime(2022, 6, 21, 2, 59, 30, 57, DateTimeKind.Local).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 18, 9, 39, 252, DateTimeKind.Local).AddTicks(3531), "Sapiente et cupidita", "Unbranded Metal Salad", new DateTime(2022, 10, 29, 13, 52, 39, 233, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 15, 5, 35, 22, 831, DateTimeKind.Local).AddTicks(1368), "Eos incidunt nesciun", "Awesome Fresh Bacon", new DateTime(2022, 8, 22, 2, 36, 23, 69, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 13, 13, 6, 42, 622, DateTimeKind.Local).AddTicks(7763), "Et ullam quo volupta", "Rustic Frozen Tuna", new DateTime(2022, 7, 28, 0, 15, 39, 32, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 16, 5, 15, 10, 39, DateTimeKind.Local).AddTicks(5014), "Dolores eius at labo", "Practical Steel Towels", new DateTime(2022, 6, 21, 16, 41, 9, 508, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 27, 12, 30, 43, 451, DateTimeKind.Local).AddTicks(6213), "Odit consectetur inc", "Awesome Plastic Salad", new DateTime(2023, 1, 28, 2, 32, 33, 665, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 22, 10, 125, DateTimeKind.Local).AddTicks(3852), "Harum maxime ipsum e", "Practical Rubber Cheese", new DateTime(2022, 11, 11, 1, 34, 36, 827, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 19, 19, 22, 49, 330, DateTimeKind.Local).AddTicks(9212), "Odit ipsa pariatur n", "Awesome Soft Salad", new DateTime(2022, 10, 9, 14, 15, 20, 522, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 23, 4, 36, 16, 870, DateTimeKind.Local).AddTicks(5872), "Possimus blanditiis ", "Awesome Soft Chicken", new DateTime(2022, 5, 7, 6, 27, 44, 401, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Password", "profilePicture" },
                values: new object[] { "Clair.Armstrong@gmail.com", "Terrance Yost", "$2a$11$DWVaVHU84mKxkh60rDYCBeD0a2q.fuxS/ob9iSK8ZoCcQN.Tiy.zy", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1221.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password", "profilePicture" },
                values: new object[] { "Aletha65@gmail.com", "Rocky Bins", "$2a$11$ld4b26Tj8ttjXhCVw3Lg/.x5slVjxjVvFg3iI8itmjOre4A4ZoM.m", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/561.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Password", "profilePicture" },
                values: new object[] { "Efren50@hotmail.com", "Gavin Kilback", "$2a$11$T3sal18Z5yipe7MdRpAnDOnM9oa7UNTGsmf7h4eJhfKkORQQlQQNS", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/377.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Password", "profilePicture" },
                values: new object[] { "Lazaro.Shanahan@yahoo.com", "Erick Murphy", "$2a$11$7E4//9k48X2XeaIjsEMcwuLmnFxe/BecNdTgpg1d9Gmz5EE4kccuS", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/129.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Password", "profilePicture" },
                values: new object[] { "Waylon.Schamberger12@gmail.com", "Taya Labadie", "$2a$11$2fWJE0JAtDWMgmRcOSBEIu7F4eXYdRz6JcsRVVxSXHR2HhpN.Dtfq", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/932.jpg" });
        }
    }
}
