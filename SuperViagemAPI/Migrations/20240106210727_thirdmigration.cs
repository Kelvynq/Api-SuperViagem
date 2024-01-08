using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SuperViagemAPI.Migrations
{
    /// <inheritdoc />
    public partial class thirdmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "usuario",
                columns: new[] { "id", "usuario_email", "usuario_nome", "usuarioURL", "usuario_senha" },
                values: new object[,]
                {
                    { 1, "jose.pedro@gmail.com", "José Pedro", "hhtps://www.jose123.com", "jose123" },
                    { 2, "victor.diniz@gmail.com", "Victor Diniz", "hhtps://www.jose123.com", "victor123" },
                    { 3, "agnaldo.ribeiro@gmail.com", "Agnaldo Ribeiro", "hhtps://www.jose123.com", "agnaldo123" },
                    { 4, "pamela.lucia@gmail.com", "Pamela Lucia", "hhtps://www.jose123.com", "pamela123" },
                    { 5, "maria.ferraz@gmail.com", "Maria Ferraz", "hhtps://www.jose123.com", "maria123" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
