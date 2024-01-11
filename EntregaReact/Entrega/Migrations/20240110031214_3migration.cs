using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Entrega.Migrations
{
    /// <inheritdoc />
    public partial class _3migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "games",
                columns: new[] { "id", "genre", "name", "price", "url" },
                values: new object[,]
                {
                    { 1, "RPG", "The Witcher 3", 59.99m, "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png" },
                    { 2, "RPG", "The Witcher 2", 19.99m, "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png" },
                    { 3, "RPG", "The Witcher", 9.99m, "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png" },
                    { 4, "RPG", "Cyberpunk 2077", 59.99m, "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "games",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "games",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "games",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "games",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
