using Microsoft.EntityFrameworkCore;
using WololoPrueba.Models;
namespace WololoPrueba.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext() { }
    public AppDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Civ>LasCivs { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Civ>().HasData(
            new Civ
            {
                CivId = 1,
                CivName = "Asirios",
                FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/f/f8/Assyrian_AOE_DE_ROR_icon.png"
            },
            new Civ
            {
                CivId = 2,
                CivName = "Babilonios",
                FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/f/fe/Babylonian_AOE_DE_ROR_icon.png"
            },
            new Civ
            {
                CivId = 3,
                CivName = "Cartagineses",
                FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/b/b9/Carthaginian_AOE_DE_ROR_icon.png"
            },
            new Civ
            {
                CivId = 4,
                CivName = "Choson",
                FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/a/ad/Choson_AOE_DE_ROR_icon.png"
            },
            new Civ
            {
                CivId = 5,
                CivName = "Egipcios",
                FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/0/03/Egyptian_AOE_DE_ROR_icon.png"
            },
            new Civ
            {
                CivId = 6,
                CivName = "Fenicios",
                FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/8/82/Phoenician_AOE_DE_ROR_icon.png"
            },
            new Civ
            {
                CivId = 7,
                CivName = "Griegos",
                FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/1/13/Greek_AOE_DE_ROR_icon.png"
            },
            new Civ
            {
                CivId = 8,
                CivName = "Hititas",
                FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/a/aa/Hittite_AOE_DE_ROR_icon.png"
            },
            new Civ
            {
                CivId = 9,
                CivName = "Lac Viet",
                FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/9/98/Lac_Viet_AOE_DE_ROR_icon.png"
            },
            new Civ
            {
                CivId = 10,
                CivName = "Macedonios",
                FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/7/7d/Macedonian_AOE_DE_ROR_icon.png"
            },
            new Civ
            {
                CivId = 11,
                CivName = "Minoicos",
                FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/e/ec/Minoan_AOE_DE_ROR_icon.png"
            },
            new Civ
            {
                CivId = 12,
                CivName = "Palmireños",
                FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/7/7b/Palmyran_AOE_DE_ROR_icon.png"
            },
            new Civ
            {
                CivId = 13,
                CivName = "Persas",
                FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/5/57/Persian_AOE_DE_ROR_icon.png"
            },
            new Civ
            {
                CivId = 14,
                CivName = "Romanos",
                FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/4/44/Roman_AOE_DE_ROR_icon.png"
            },
            new Civ
            {
                CivId = 15,
                CivName = "Shang",
                FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/e/e4/Shang_AOE_DE_ROR_icon.png"
            },
            new Civ
            {
                CivId = 16,
                CivName = "Sumerios",
                FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/4/44/Sumerian_AOE_DE_ROR_icon.png"
            },
            new Civ
            {
                CivId = 17,
                CivName = "Yamato",
                FotoUrl = "https://static.wikia.nocookie.net/ageofempires/images/8/82/Yamato_AOE_DE_ROR_icon.png"
            }
        );
    }
}