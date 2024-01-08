using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperViagemAPI.Migrations
{
    /// <inheritdoc />
    public partial class _7migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                column: "usuarioURL",
                value: "https://cdn-icons-png.flaticon.com/512/6073/6073873.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                column: "usuarioURL",
                value: "hhtps://www.jose123.com");
        }
    }
}
