using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WololoPrueba.Migrations
{
    public partial class migrationEnsayo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LosEnsayos",
                columns: table => new
                {
                    EnsayoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParticipanteId = table.Column<int>(type: "int", nullable: false),
                    CivId = table.Column<int>(type: "int", nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LosEnsayos", x => x.EnsayoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LosEnsayos");
        }
    }
}
