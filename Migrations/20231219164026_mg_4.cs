using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_16.Migrations
{
    public partial class mg_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StatisticsVisit",
                table: "Statistices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatisticsVisits",
                table: "Statistices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatisticsVisits",
                table: "Statistices");

            migrationBuilder.AlterColumn<string>(
                name: "StatisticsVisit",
                table: "Statistices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
