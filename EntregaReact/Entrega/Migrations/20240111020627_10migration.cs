using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entrega.Migrations
{
    /// <inheritdoc />
    public partial class _10migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 1,
                column: "FotoPerfil",
                value: "https://thumbs2.imgbox.com/60/44/H7Zzi2TT_t.jpeg");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 2,
                column: "FotoPerfil",
                value: "https://thumbs2.imgbox.com/7a/38/wdCxVgSk_t.jpeg");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 3,
                column: "FotoPerfil",
                value: "https://thumbs2.imgbox.com/16/95/iD9v1mWN_t.jpeg");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 4,
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
                value: "https://thumbs2.imgbox.com/9a/af/fbs18nO2_t.jpeg");

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
                value: "https://psicoter.com.br/wp-content/uploads/2019/01/pessoa-flexivel-seja-mais-flexivel.jpg");
        }
    }
}
