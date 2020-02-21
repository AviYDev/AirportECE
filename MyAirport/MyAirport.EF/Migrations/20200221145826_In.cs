using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IA.MyAirport.EF.Migrations
{
    public partial class In : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bagages",
                columns: table => new
                {
                    BagageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolID = table.Column<int>(nullable: false),
                    code_iata = table.Column<string>(nullable: true),
                    date_creation = table.Column<DateTime>(nullable: false),
                    classe = table.Column<string>(nullable: false),
                    prioritaire = table.Column<byte>(nullable: false),
                    sta = table.Column<string>(nullable: false),
                    ssur = table.Column<string>(nullable: true),
                    destination = table.Column<string>(nullable: true),
                    escale = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bagages", x => x.BagageID);
                });

            migrationBuilder.CreateTable(
                name: "Vols",
                columns: table => new
                {
                    VolID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cie = table.Column<int>(nullable: false),
                    lig = table.Column<string>(nullable: true),
                    jex = table.Column<short>(nullable: false),
                    dhc = table.Column<DateTime>(nullable: false),
                    pkg = table.Column<string>(nullable: true),
                    imm = table.Column<string>(nullable: true),
                    pax = table.Column<short>(nullable: false),
                    des = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vols", x => x.VolID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bagages");

            migrationBuilder.DropTable(
                name: "Vols");
        }
    }
}
