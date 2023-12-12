using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Experience the very beginning as we go back to the first generation that started it all.", "https://upload.wikimedia.org/wikipedia/en/thumb/a/af/Pok%C3%A9mon_Red_and_Blue_cover_art.webp/546px-Pok%C3%A9mon_Red_and_Blue_cover_art.webp.png", 80.00m, "Pokemon Red, Blue and Yellow bundle" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Experience the sequels that changed everything and perfected the formula for the biggest franchice in the early 2000s.", "https://upload.wikimedia.org/wikipedia/en/4/4c/Pok%C3%A9mon_box_art_-_Gold_Version.png", 299.99m, "Pokemon Gold and Silver bundle" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "The wild child of the ever growing family of triple pack games and the start of the advanced generation of poekmon games, with more features than you could possibly count!", "https://upload.wikimedia.org/wikipedia/en/b/be/PokemonRubySapphireBox.jpg", 479.95m, "Pokemon Ruby and Sapphire bundle" });
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
        }
    }
}
