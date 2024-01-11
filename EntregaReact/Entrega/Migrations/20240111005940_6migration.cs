using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entrega.Migrations
{
    /// <inheritdoc />
    public partial class _6migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 1,
                column: "FotoPerfil",
                value: "https://ibb.co/Pr9tVNy");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 2,
                column: "FotoPerfil",
                value: "https://ibb.co/mTk15x6");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 3,
                column: "FotoPerfil",
                value: "https://ibb.co/S0RXTC5");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 4,
                column: "FotoPerfil",
                value: "https://ibb.co/2S9wJ7r");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 1,
                column: "FotoPerfil",
                value: "Lucas.jpeg");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 2,
                column: "FotoPerfil",
                value: "Henrique.jpeg");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 3,
                column: "FotoPerfil",
                value: "Enzo.jpeg");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 4,
                column: "FotoPerfil",
                value: "Nadine.jpeg");
        }
    }
}
