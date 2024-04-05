using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_XemPhim.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAdmin",
                table: "User",
                newName: "IsActive");

            migrationBuilder.AddColumn<int>(
                name: "Point",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Point",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "User",
                newName: "IsAdmin");
        }
    }
}
