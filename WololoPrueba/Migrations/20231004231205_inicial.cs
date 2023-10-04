using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WololoPrueba.Migrations
{
    public partial class inicial : Migration
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

            migrationBuilder.InsertData(
                table: "LasCivs",
                columns: new[] { "CivId", "CivName", "FotoUrl" },
                values: new object[] { 1, "Asirios", "https://static.wikia.nocookie.net/ageofempires/images/f/f8/Assyrian_AOE_DE_ROR_icon.png/revision/latest?cb=20230611040714" });

            migrationBuilder.InsertData(
                table: "LasCivs",
                columns: new[] { "CivId", "CivName", "FotoUrl" },
                values: new object[] { 2, "Babilonios", "https://static.wikia.nocookie.net/ageofempires/images/f/fe/Babylonian_AOE_DE_ROR_icon.png/revision/latest?cb=20230611040835" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LasCivs");
        }
    }
}
