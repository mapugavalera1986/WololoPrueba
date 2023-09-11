using Microsoft.EntityFrameworkCore;
using WololoPrueba.Models;
namespace WololoPrueba.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Civ>LasCivs { get; set; }
    }
}