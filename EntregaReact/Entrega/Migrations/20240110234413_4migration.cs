using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entrega.Migrations
{
    /// <inheritdoc />
    public partial class _4migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_games",
                table: "games");

            migrationBuilder.DropColumn(
                name: "price",
                table: "games");

            migrationBuilder.RenameTable(
                name: "games",
                newName: "Usuario");

            migrationBuilder.RenameColumn(
                name: "url",
                table: "Usuario",
                newName: "sobrenome");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Usuario",
                newName: "senha");

            migrationBuilder.RenameColumn(
                name: "genre",
                table: "Usuario",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Usuario",
                newName: "IDUsuario");

            migrationBuilder.AddColumn<string>(
                name: "FotoPerfil",
                table: "Usuario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Usuario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "informacoesContato",
                table: "Usuario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "IDUsuario");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 1,
                columns: new[] { "informacoesContato", "email", "FotoPerfil", "nome", "senha", "sobrenome" },
                values: new object[] { "11998751632", "lucasreno@gmail.com", "Lucas.jpeg", "Lucas ", "marechalr6", "Renó" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 2,
                columns: new[] { "informacoesContato", "email", "FotoPerfil", "nome", "senha", "sobrenome" },
                values: new object[] { "11996290461", "henriquefaria@gmail.com", "Henrique.jpeg", "Henrique ", "niner6", "Faria" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 3,
                columns: new[] { "informacoesContato", "email", "FotoPerfil", "nome", "senha", "sobrenome" },
                values: new object[] { "119987142390", "enzochiara@gmail.com", "Enzo.jpeg", "Enzo ", "texugor6", "Chiaramonte" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 4,
                columns: new[] { "informacoesContato", "email", "FotoPerfil", "nome", "senha", "sobrenome" },
                values: new object[] { "11998751632", "lucasreno@gmail.com", "Lucas.jpeg", "Lucas ", "marechalreno", "Renó" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "FotoPerfil",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "informacoesContato",
                table: "Usuario");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "games");

            migrationBuilder.RenameColumn(
                name: "sobrenome",
                table: "games",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "senha",
                table: "games",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "games",
                newName: "genre");

            migrationBuilder.RenameColumn(
                name: "IDUsuario",
                table: "games",
                newName: "id");

            migrationBuilder.AddColumn<decimal>(
                name: "price",
                table: "games",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_games",
                table: "games",
                column: "id");

            migrationBuilder.UpdateData(
                table: "games",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "genre", "name", "price", "url" },
                values: new object[] { "RPG", "The Witcher 3", 59.99m, "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png" });

            migrationBuilder.UpdateData(
                table: "games",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "genre", "name", "price", "url" },
                values: new object[] { "RPG", "The Witcher 2", 19.99m, "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png" });

            migrationBuilder.UpdateData(
                table: "games",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "genre", "name", "price", "url" },
                values: new object[] { "RPG", "The Witcher", 9.99m, "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png" });

            migrationBuilder.UpdateData(
                table: "games",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "genre", "name", "price", "url" },
                values: new object[] { "RPG", "Cyberpunk 2077", 59.99m, "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png" });
        }
    }
}
