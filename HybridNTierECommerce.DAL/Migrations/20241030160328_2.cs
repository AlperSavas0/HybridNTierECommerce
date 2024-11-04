using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HybridNTierECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "34818fef-66fb-4747-b3a0-89ec9c77ffe3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ad9d80e9-9866-4e4d-9bf8-3a028123b0be");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8b8288b-de43-4a77-bc1f-a59db186f61f", new DateTime(2024, 10, 30, 19, 3, 27, 249, DateTimeKind.Local).AddTicks(2696), "AQAAAAIAAYagAAAAEEMFDt7fWuQeQLcwNG6CSK/I2EuNR7VgdgN3tf8XFAbjd16xy6wbJZjkL+INHZ/FKQ==", "062b85de-fee4-4252-812f-5d93bda9116c" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(769), "Quibusdam cum dicta deserunt qui iste ut suscipit perspiciatis omnis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(1320), "Aut aliquid nostrum soluta tempore debitis pariatur error sit vitae." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(1380), "İn qui voluptatem aut maiores tempore sed aliquid maxime laudantium." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(1535), "Quia quia quia accusamus explicabo quam illum laudantium praesentium autem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(1587), "Ut unde tempora enim totam consequatur molestias laborum in consequatur." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(1651), "Tempora adipisci corporis deserunt cumque commodi est ut consequatur illum." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(1700), "Quis ratione rem quia consectetur ea nostrum reiciendis omnis sed." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(1781), "Voluptates non ut assumenda distinctio voluptatem incidunt ad ducimus deserunt." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(1834), "İusto expedita consequatur saepe qui omnis qui dignissimos eaque qui." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(1884), "Sapiente eveniet et rerum nam harum consequatur placeat nam atque." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(2163), 514.01m, "Fantastic Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(2700), 880.39m, "Handmade Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(2862), 685.89m, "Handmade Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(3029), 365.84m, "Handcrafted Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(3170), 256.28m, "Licensed Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(3386), 532.91m, "Tasty Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(3525), 318.87m, "Fantastic Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(3702), 198.15m, "Licensed Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(3842), 829.56m, "Rustic Steel Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(4010), 806.07m, "Sleek Frozen Sausages" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "850420e5-dc3c-4bbd-a35e-367c268ae01d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0b906dec-71f2-45e2-beac-bfbdfa240030");

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
    }
}
