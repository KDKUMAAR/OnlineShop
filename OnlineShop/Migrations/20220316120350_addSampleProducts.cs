using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Migrations
{
    public partial class addSampleProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImagePath", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, "Test Description", "/images/mobile_1.jpg", 300m, "Product 1" },
                    { 2, "Test Description", "/images/mobile_2.jpg", 400m, "Product 2" },
                    { 3, "Test Description", "/images/mobile_3.jpg", 500m, "Product 3" },
                    { 4, "Test Description", "/images/mobile_4.jpg", 600m, "Product 4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
