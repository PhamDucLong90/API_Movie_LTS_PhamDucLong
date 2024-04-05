using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_XemPhim.Migrations
{
    /// <inheritdoc />
    public partial class v2024 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Token",
                table: "RefreshToken",
                newName: "Refresh_Token");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Refresh_Token",
                table: "RefreshToken",
                newName: "Token");
        }
    }
}
