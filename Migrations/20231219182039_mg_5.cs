using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_16.Migrations
{
    public partial class mg_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Statistices",
                table: "Statistices");

            migrationBuilder.RenameTable(
                name: "Statistices",
                newName: "Statistics");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statistics",
                table: "Statistics",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Statistics",
                table: "Statistics");

            migrationBuilder.RenameTable(
                name: "Statistics",
                newName: "Statistices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statistices",
                table: "Statistices",
                column: "Id");
        }
    }
}
