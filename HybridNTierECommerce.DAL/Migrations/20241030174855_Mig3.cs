using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HybridNTierECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "91081929-9164-4a8e-ac84-93398788b00b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "567c5b73-d9df-40c6-9f72-214332240501");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "269daa65-0c75-4cd3-b942-467fa2cd262e", new DateTime(2024, 10, 30, 20, 48, 54, 602, DateTimeKind.Local).AddTicks(504), "AQAAAAIAAYagAAAAEHKTP2m2UUiDxEcpExNxycre1DZTPw3dz7I0bLM8l8LinvhbBBZo16e7u3n5rIHG1A==", "86acae91-829c-4fc9-b4d8-9923afeb3536" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 10, 30, 20, 48, 54, 649, DateTimeKind.Local).AddTicks(9088), "Consequatur quae voluptatum ut et ab quam sequi vel sunt." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2024, 10, 30, 20, 48, 54, 649, DateTimeKind.Local).AddTicks(9625), "Tempora rerum sint ea vel ratione ducimus omnis aperiam iure." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2024, 10, 30, 20, 48, 54, 649, DateTimeKind.Local).AddTicks(9687), "İmpedit doloribus facere accusantium corrupti ea doloremque dolorem odit omnis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2024, 10, 30, 20, 48, 54, 649, DateTimeKind.Local).AddTicks(9746), "Et soluta praesentium et explicabo atque doloremque incidunt ut illum." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2024, 10, 30, 20, 48, 54, 649, DateTimeKind.Local).AddTicks(9867), "İpsum quas quidem odit quis id consequatur qui id consequuntur." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2024, 10, 30, 20, 48, 54, 649, DateTimeKind.Local).AddTicks(9927), "Repudiandae ipsa et repellat sapiente consectetur accusamus dolores qui voluptates." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2024, 10, 30, 20, 48, 54, 649, DateTimeKind.Local).AddTicks(9981), "Aliquam officiis sit vero dolor voluptatibus amet molestias iure provident." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(33), "Quia porro quia recusandae nostrum fugit quasi vitae eveniet molestiae." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(140), "Sunt at reiciendis a sint fugit similique repellendus quo et." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(240), "Tempore debitis a mollitia perferendis dolorem ipsum doloremque omnis qui." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(451), 404.45m, "Sleek Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(972), 951.47m, "Gorgeous Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(1131), 149.39m, "Gorgeous Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(1292), 136.83m, "Intelligent Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(1433), 10.03m, "Intelligent Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(1641), 347.04m, "Handmade Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(1785), 799.20m, "Gorgeous Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(1973), 255.12m, "Licensed Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(2114), 267.89m, "Intelligent Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Price", "ProductName" },
                values: new object[] { new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(2276), 156.60m, "Practical Wooden Chicken" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 10, 30, 19, 3, 27, 305, DateTimeKind.Local).AddTicks(769), "Quibusdam cum dicta deserunt qui iste ut suscipit perspiciatis omnis." });

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
    }
}
