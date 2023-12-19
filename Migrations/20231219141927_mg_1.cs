using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_16.Migrations
{
    public partial class mg_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statistices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Statistic = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StatisticsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatisticsPercentage = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistices", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statistices");
        }
    }
}
