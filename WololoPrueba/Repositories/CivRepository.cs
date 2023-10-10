using Microsoft.EntityFrameworkCore;
using WololoPrueba.DbContexts;
using WololoPrueba.Models;

namespace WololoPrueba.Repositories
{
    public class CivRepository: ICivRepository
    {
        private readonly AppDbContext bdcontexto;
        public CivRepository(AppDbContext bdcontexto) { this.bdcontexto = bdcontexto; }
        public CivRepository() { }
        public async Task<Civ> Buscar(int civId)
        {
            var civ = await bdcontexto.LasCivs.Where(c => c.CivId == civId).FirstOrDefaultAsync();
            return civ;
        }
        public async Task<IEnumerable<Civ>> Listar()
        {
            return await bdcontexto.LasCivs.ToListAsync();
        }
    }
}
