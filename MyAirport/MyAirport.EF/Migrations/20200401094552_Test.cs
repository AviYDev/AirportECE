using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IA.MyAirport.EF.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "date_creation",
                table: "Bagages",
                type: "char(12)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "date_creation",
                table: "Bagages",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(12)");
        }
    }
}
