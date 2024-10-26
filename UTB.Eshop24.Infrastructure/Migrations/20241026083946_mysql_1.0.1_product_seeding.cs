using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UTB.Eshop24.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mysql_101_product_seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "ImageSrc", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Nejlepší chleba na světě", "", "Chleba", 50.0 },
                    { 2, "Nejlepší rohlík v galaxii", "", "Rohlík", 2.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
