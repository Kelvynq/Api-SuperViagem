using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperViagemAPI.Migrations
{
    /// <inheritdoc />
    public partial class _5migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "usuario",
                columns: new[] { "id", "usuario_email", "usuario_nome", "usuarioURL", "usuario_senha" },
                values: new object[] { 6, "vanessa.lopes@gmail.com", "Vanessa Lopes", "hhtps://www.jose123.com", "vanessa123" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 6);
        }
    }
}
