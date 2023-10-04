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
            new Civ { CivId=1, CivName= "Asirios",
                FotoUrl= "https://static.wikia.nocookie.net/ageofempires/images/f/f8/Assyrian_AOE_DE_ROR_icon.png/revision/latest?cb=20230611040714"
            },
            new Civ { CivId=2, CivName="Babilonios",
                FotoUrl= "https://static.wikia.nocookie.net/ageofempires/images/f/fe/Babylonian_AOE_DE_ROR_icon.png/revision/latest?cb=20230611040835"
            }
        );
    }
}