using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudWeather.Report.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "weatherReport",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AverageHighF = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AverageLowF = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RainfallTotalInches = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SnowTotalInches = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weatherReport", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "weatherReport");
        }
    }
}
