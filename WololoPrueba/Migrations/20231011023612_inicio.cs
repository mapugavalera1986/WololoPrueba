using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WololoPrueba.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LasCivs",
                columns: table => new
                {
                    CivId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CivName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LasCivs", x => x.CivId);
                });

            migrationBuilder.CreateTable(
                name: "LosColegios",
                columns: table => new
                {
                    ColegioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nmbr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nivel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LosColegios", x => x.ColegioId);
                });

            migrationBuilder.CreateTable(
                name: "LosParticipantes",
                columns: table => new
                {
                    ParticipanteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nmbrs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aplld = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNac = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CorreoE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LosParticipantes", x => x.ParticipanteId);
                });

            migrationBuilder.InsertData(
                table: "LasCivs",
                columns: new[] { "CivId", "CivName", "FotoUrl" },
                values: new object[,]
                {
                    { 1, "Asirios", "https://static.wikia.nocookie.net/ageofempires/images/f/f8/Assyrian_AOE_DE_ROR_icon.png" },
                    { 2, "Babilonios", "https://static.wikia.nocookie.net/ageofempires/images/f/fe/Babylonian_AOE_DE_ROR_icon.png" },
                    { 3, "Cartagineses", "https://static.wikia.nocookie.net/ageofempires/images/b/b9/Carthaginian_AOE_DE_ROR_icon.png" },
                    { 4, "Choson", "https://static.wikia.nocookie.net/ageofempires/images/a/ad/Choson_AOE_DE_ROR_icon.png" },
                    { 5, "Egipcios", "https://static.wikia.nocookie.net/ageofempires/images/0/03/Egyptian_AOE_DE_ROR_icon.png" },
                    { 6, "Fenicios", "https://static.wikia.nocookie.net/ageofempires/images/8/82/Phoenician_AOE_DE_ROR_icon.png" },
                    { 7, "Griegos", "https://static.wikia.nocookie.net/ageofempires/images/1/13/Greek_AOE_DE_ROR_icon.png" },
                    { 8, "Hititas", "https://static.wikia.nocookie.net/ageofempires/images/a/aa/Hittite_AOE_DE_ROR_icon.png" },
                    { 9, "Lac Viet", "https://static.wikia.nocookie.net/ageofempires/images/9/98/Lac_Viet_AOE_DE_ROR_icon.png" },
                    { 10, "Macedonios", "https://static.wikia.nocookie.net/ageofempires/images/7/7d/Macedonian_AOE_DE_ROR_icon.png" },
                    { 11, "Minoicos", "https://static.wikia.nocookie.net/ageofempires/images/e/ec/Minoan_AOE_DE_ROR_icon.png" },
                    { 12, "Palmireños", "https://static.wikia.nocookie.net/ageofempires/images/7/7b/Palmyran_AOE_DE_ROR_icon.png" },
                    { 13, "Persas", "https://static.wikia.nocookie.net/ageofempires/images/5/57/Persian_AOE_DE_ROR_icon.png" },
                    { 14, "Romanos", "https://static.wikia.nocookie.net/ageofempires/images/4/44/Roman_AOE_DE_ROR_icon.png" },
                    { 15, "Shang", "https://static.wikia.nocookie.net/ageofempires/images/e/e4/Shang_AOE_DE_ROR_icon.png" },
                    { 16, "Sumerios", "https://static.wikia.nocookie.net/ageofempires/images/4/44/Sumerian_AOE_DE_ROR_icon.png" },
                    { 17, "Yamato", "https://static.wikia.nocookie.net/ageofempires/images/8/82/Yamato_AOE_DE_ROR_icon.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LasCivs");

            migrationBuilder.DropTable(
                name: "LosColegios");

            migrationBuilder.DropTable(
                name: "LosParticipantes");
        }
    }
}
