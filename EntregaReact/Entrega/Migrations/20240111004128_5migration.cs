using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entrega.Migrations
{
    /// <inheritdoc />
    public partial class _5migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 4,
                columns: new[] { "informacoesContato", "email", "FotoPerfil", "nome", "senha", "sobrenome" },
                values: new object[] { "119056718302", "nadinesouza@gmail.com", "Nadine.jpeg", "Nadine ", "nadiner6", "Souza" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IDUsuario",
                keyValue: 4,
                columns: new[] { "informacoesContato", "email", "FotoPerfil", "nome", "senha", "sobrenome" },
                values: new object[] { "11998751632", "lucasreno@gmail.com", "Lucas.jpeg", "Lucas ", "marechalreno", "Renó" });
        }
    }
}
