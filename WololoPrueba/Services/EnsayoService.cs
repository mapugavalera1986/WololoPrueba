using Microsoft.EntityFrameworkCore;
using WololoPrueba.DbContexts;
using WololoPrueba.Models;
using WololoPrueba.Repositories;

namespace WololoPrueba.Services
{
    public class EnsayoService : IEnsayoRepository
    {
        private readonly AppDbContext bdContexto;
        public EnsayoService(AppDbContext bdContexto) { this.bdContexto = bdContexto; }
        public EnsayoService() { }


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
