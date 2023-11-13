using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cargo_Database.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCistern : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CisternLocation",
                table: "Cistern",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CisternLocation",
                table: "Cistern");
        }
    }
}
