using Microsoft.EntityFrameworkCore;
using WololoPrueba.DbContexts;
using WololoPrueba.Models;

namespace WololoPrueba.Repositories
{
    public class ColegioRepository : IColegioRepository
    {
        private readonly AppDbContext bdcontexto;
        public ColegioRepository(AppDbContext bdcontexto) { this.bdcontexto = bdcontexto; }
        public ColegioRepository() { }
        public async Task<IEnumerable<Colegio>> Listar()
        {
            return await bdcontexto.LosColegios.ToListAsync();
        }
        public async Task<Colegio> Buscar(int id)
        {
            var colegio = await bdcontexto.LosColegios.Where(c => c.ColegioId == id).FirstOrDefaultAsync();
            return colegio;
        }
        public async Task<Colegio> Agregar(Colegio nuevo_c)
        {
            bdcontexto.LosColegios.Add(nuevo_c);
            await bdcontexto.SaveChangesAsync();
            return nuevo_c;
        }
        public async Task<Colegio> Modificar(Colegio cambiar_c)
        {
            bdcontexto.LosColegios.Update(cambiar_c);
            await bdcontexto.SaveChangesAsync();
            return cambiar_c;
        }
        public async Task<bool> Eliminar(int id)
        {
            var colegio = await bdcontexto.LosColegios.Where(c => c.ColegioId == id).FirstOrDefaultAsync();
            if (colegio == null) { return false; }
            bdcontexto.LosColegios.Remove(colegio);
            return true;
        }
    }
}