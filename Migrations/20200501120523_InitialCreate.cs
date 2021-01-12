using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanificatorSali.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sala",
                columns: table => new
                {
                    salaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Denumire = table.Column<string>(nullable: true),
                    Etaj = table.Column<int>(nullable: false),
                    capacitate = table.Column<int>(nullable: false),
                    infosala = table.Column<string>(nullable: true),
                    disponibila = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sala", x => x.salaID);
                });

            migrationBuilder.CreateTable(
                name: "Evenimente",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    start_data = table.Column<DateTime>(nullable: false),
                    sfarsit_data = table.Column<DateTime>(nullable: false),
                    Titlu = table.Column<string>(nullable: true),
                    Descriere = table.Column<string>(nullable: true),
                    culoare = table.Column<string>(nullable: true),
                    salaID = table.Column<int>(nullable: false),
                    participanti = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evenimente", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Evenimente_Sala_salaID",
                        column: x => x.salaID,
                        principalTable: "Sala",
                        principalColumn: "salaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evenimente_salaID",
                table: "Evenimente",
                column: "salaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evenimente");

            migrationBuilder.DropTable(
                name: "Sala");
        }
    }
}
