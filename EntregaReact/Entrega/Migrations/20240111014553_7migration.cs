using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entrega.Migrations
{
    /// <inheritdoc />
    public partial class _7migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 4,
                column: "FotoPerfil",
                value: "https://psicoter.com.br/wp-content/uploads/2019/01/pessoa-flexivel-seja-mais-flexivel.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 4,
                column: "FotoPerfil",
                value: "https://ibb.co/2S9wJ7r");
        }
    }
}
