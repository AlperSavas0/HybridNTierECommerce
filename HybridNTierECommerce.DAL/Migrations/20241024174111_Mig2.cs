using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HybridNTierECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModifiedData",
                table: "Profiles",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedData",
                table: "Products",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedData",
                table: "Orders",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedData",
                table: "OrderDetails",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedData",
                table: "Categories",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedData",
                table: "AspNetUsers",
                newName: "ModifiedDate");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "850420e5-dc3c-4bbd-a35e-367c268ae01d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 2, "0b906dec-71f2-45e2-beac-bfbdfa240030", "Member", "MEMBER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce232ea5-e048-4724-ba19-936fc97b9139", new DateTime(2024, 10, 24, 20, 41, 10, 615, DateTimeKind.Local).AddTicks(819), "AQAAAAIAAYagAAAAEPP8NVfQebNkLm8y20zk81wcT4BWCNqZOUL95f0oOHFzf+zVaNsnCKVGzyfGpp1jDA==", "a81ebb86-7103-4624-a78b-b60a3037395d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2024, 10, 24, 20, 41, 10, 665, DateTimeKind.Local).AddTicks(9037), "Sunt dolorem voluptatem quas consectetur ipsa quo occaecati ut neque." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2024, 10, 24, 20, 41, 10, 665, DateTimeKind.Local).AddTicks(9702), "Et sint molestiae perferendis eius accusamus laboriosam labore porro et." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2024, 10, 24, 20, 41, 10, 665, DateTimeKind.Local).AddTicks(9774), "Maiores sit sit animi est quo commodi nisi ab architecto." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2024, 10, 24, 20, 41, 10, 665, DateTimeKind.Local).AddTicks(9833), "Eaque provident est quaerat dolore cum deserunt consequatur voluptatibus aut." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2024, 10, 24, 20, 41, 10, 666, DateTimeKind.Local).AddTicks(9), "Harum maiores dolorem ullam ad voluptas omnis quia expedita deserunt." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2024, 10, 24, 20, 41, 10, 666, DateTimeKind.Local).AddTicks(74), "Sint vero ut porro error rerum enim maxime dolorem eaque." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 10, 24, 20, 41, 10, 666, DateTimeKind.Local).AddTicks(122), "Qui nihil aliquam rerum est dignissimos recusandae doloremque iure necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2024, 10, 24, 20, 41, 10, 666, DateTimeKind.Local).AddTicks(175), "Minima sunt perspiciatis nihil excepturi facilis deserunt eveniet deleniti odit." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2024, 10, 24, 20, 41, 10, 666, DateTimeKind.Local).AddTicks(257), "Sit minus minus ut recusandae voluptatem quaerat voluptatem voluptatem et." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2024, 10, 24, 20, 41, 10, 666, DateTimeKind.Local).AddTicks(308), "Praesentium necessitatibus laudantium autem mollitia ut ipsam doloribus qui dolores." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 24, 20, 41, 10, 666, DateTimeKind.Local).AddTicks(532), 741.62m, "Ergonomic Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 24, 20, 41, 10, 666, DateTimeKind.Local).AddTicks(1072), 340.03m, "Tasty Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 24, 20, 41, 10, 666, DateTimeKind.Local).AddTicks(1236), 443.87m, "Generic Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 24, 20, 41, 10, 666, DateTimeKind.Local).AddTicks(1421), 18.43m, "Awesome Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 24, 20, 41, 10, 666, DateTimeKind.Local).AddTicks(1566), 722.59m, "Ergonomic Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 24, 20, 41, 10, 666, DateTimeKind.Local).AddTicks(1739), 361.01m, "Handcrafted Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 24, 20, 41, 10, 666, DateTimeKind.Local).AddTicks(1884), 778.41m, "Incredible Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 24, 20, 41, 10, 666, DateTimeKind.Local).AddTicks(2024), 488.74m, "Incredible Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 24, 20, 41, 10, 666, DateTimeKind.Local).AddTicks(2185), 376.48m, "Licensed Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 24, 20, 41, 10, 666, DateTimeKind.Local).AddTicks(2408), 834.76m, "Generic Granite Car" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Profiles",
                newName: "ModifiedData");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Products",
                newName: "ModifiedData");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Orders",
                newName: "ModifiedData");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "OrderDetails",
                newName: "ModifiedData");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Categories",
                newName: "ModifiedData");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "AspNetUsers",
                newName: "ModifiedData");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b4c04b5c-8d3b-4f9c-a896-0c99bdb3e018");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb93794a-a173-49b4-85cf-73f2a5e6a8d9", new DateTime(2024, 10, 14, 15, 55, 59, 35, DateTimeKind.Local).AddTicks(5221), "AQAAAAIAAYagAAAAEBQw2D1aMiv02bjXVaGlxwzw11yo3ZZ71GuMPYXA9SNGlyBFmnLkhdwDjWDhqnVnUw==", "44372f89-741b-4766-9723-b20b9b3545a2" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(1407), "Qui est aliquid necessitatibus et minima saepe odit fugiat sit." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(1831), "Soluta culpa consequatur sit reiciendis et deserunt magni commodi quod." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(1956), "Sit voluptates consequatur corporis et qui inventore in quo quia." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(2012), "Sint est illum nobis corporis culpa aut omnis nam et." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(2066), "Quo non eum voluptatem explicabo qui ipsum modi dolor sint." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(2120), "Perferendis voluptates rerum in eaque nesciunt ea in qui architecto." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(2169), "Quos sed quia autem at aut inventore qui veritatis ut." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(2242), "Aut aut recusandae ut veniam vel qui quia qui et." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(2291), "Quis tenetur esse facere minima omnis deleniti sed occaecati ratione." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(2344), "Doloribus minima vel quam veritatis sunt nobis debitis ratione tempore." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(2441), 718.68m, "Ergonomic Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(2909), 476.91m, "Incredible Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(3069), 262.30m, "Sleek Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(3236), 938.77m, "Incredible Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(3375), 937.62m, "Ergonomic Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(3582), 404.03m, "Generic Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(3728), 934.60m, "Sleek Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(3904), 1.62m, "Practical Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(4045), 473.69m, "Intelligent Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 55, 59, 84, DateTimeKind.Local).AddTicks(4212), 808.12m, "Gorgeous Rubber Keyboard" });
        }
    }
}
