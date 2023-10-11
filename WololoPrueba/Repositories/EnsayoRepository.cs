using Microsoft.EntityFrameworkCore;
using WololoPrueba.DbContexts;
using WololoPrueba.Models;

namespace WololoPrueba.Repositories
{
    public class EnsayoRepository : IEnsayoRepository
    {
        private readonly AppDbContext bdContexto;    
        public EnsayoRepository(AppDbContext bdContexto) { this.bdContexto = bdContexto; }
        public EnsayoRepository() { }


        public async Task<Ensayo> Agregar(Ensayo ensayo)
        {
            bdContexto.Add(ensayo);
            await bdContexto.SaveChangesAsync();
            return ensayo;
        }

        public async Task<Ensayo> Buscar(int id)
        {
            var ensayo = await bdContexto.LosEnsayos.Where(e => e.EnsayoId == id).FirstOrDefaultAsync();
            return ensayo;
        }

        public async Task<IEnumerable<Ensayo>> Listar()
        {
            return await bdContexto.LosEnsayos.ToListAsync();       
        }
    }
}
