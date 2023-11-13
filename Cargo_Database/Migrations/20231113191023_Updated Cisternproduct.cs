using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cargo_Database.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCisternproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cistern",
                newName: "ProductDescription");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductDescription",
                table: "Cistern",
                newName: "Description");
        }
    }
}
