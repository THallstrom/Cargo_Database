using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cargo_Database.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cistern",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CisternName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxVolym = table.Column<int>(type: "int", nullable: false),
                    MaxUllage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cistern", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vessel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VesselName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HarbourName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vessel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CisternMeasure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Volym = table.Column<int>(type: "int", nullable: false),
                    Ullage = table.Column<int>(type: "int", nullable: false),
                    CisternId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CisternMeasure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CisternMeasure_Cistern_CisternId",
                        column: x => x.CisternId,
                        principalTable: "Cistern",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductVolym = table.Column<int>(type: "int", nullable: false),
                    CisternId = table.Column<int>(type: "int", nullable: false),
                    VesselId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cargo_Cistern_CisternId",
                        column: x => x.CisternId,
                        principalTable: "Cistern",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cargo_Vessel_VesselId",
                        column: x => x.VesselId,
                        principalTable: "Vessel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_CisternId",
                table: "Cargo",
                column: "CisternId");

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_VesselId",
                table: "Cargo",
                column: "VesselId");

            migrationBuilder.CreateIndex(
                name: "IX_CisternMeasure_CisternId",
                table: "CisternMeasure",
                column: "CisternId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "CisternMeasure");

            migrationBuilder.DropTable(
                name: "Vessel");

            migrationBuilder.DropTable(
                name: "Cistern");
        }
    }
}
