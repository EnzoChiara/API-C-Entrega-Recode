using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entrega.Migrations
{
    /// <inheritdoc />
    public partial class _9migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 1,
                column: "FotoPerfil",
                value: "https://thumbs2.imgbox.com/9a/af/fbs18nO2_t.jpeg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 1,
                column: "FotoPerfil",
                value: "https://imgbox.com/H7Zzi2TT");
        }
    }
}
