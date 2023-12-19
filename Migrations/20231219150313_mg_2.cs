using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_16.Migrations
{
    public partial class mg_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StatisticsDuration",
                table: "Statistices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StatisticsPercent",
                table: "Statistices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StatisticsPercentages",
                table: "Statistices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StatisticsTime",
                table: "Statistices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "StatisticsVisit",
                table: "Statistices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatisticsDuration",
                table: "Statistices");

            migrationBuilder.DropColumn(
                name: "StatisticsPercent",
                table: "Statistices");

            migrationBuilder.DropColumn(
                name: "StatisticsPercentages",
                table: "Statistices");

            migrationBuilder.DropColumn(
                name: "StatisticsTime",
                table: "Statistices");

            migrationBuilder.DropColumn(
                name: "StatisticsVisit",
                table: "Statistices");
        }
    }
}
