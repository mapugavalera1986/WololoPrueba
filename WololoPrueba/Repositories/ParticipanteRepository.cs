using Microsoft.EntityFrameworkCore;
using WololoPrueba.DbContexts;
using WololoPrueba.Models;

namespace WololoPrueba.Repositories
{
    public class ParticipanteRepository : IParticipanteRepository
    {
        private readonly AppDbContext bdcontexto;
        public ParticipanteRepository(AppDbContext bdcontexto) { this.bdcontexto = bdcontexto; }
        public ParticipanteRepository() { }

        public async Task<IEnumerable<Participante>> Listar()
        {
            return await bdcontexto.LosParticipantes.ToListAsync();
        }

        public async Task<Participante> Buscar(int id)
        {
            var participante = await bdcontexto.LosParticipantes.Where(p => p.ParticipanteId == id).FirstOrDefaultAsync();
            return participante;
        }

        public async Task<Participante> Agregar(Participante nuevo_p)
        {
            bdcontexto.LosParticipantes.Add(nuevo_p);
            await bdcontexto.SaveChangesAsync();
            return nuevo_p;
        }

        public async Task<Participante> Modificar(Participante cambiar_p)
        {
            bdcontexto.LosParticipantes.Update(cambiar_p);
            await bdcontexto.SaveChangesAsync();
            return cambiar_p;
        }

        public async Task<bool> Eliminar(int id)
        {
            var participante = await bdcontexto.LosParticipantes.Where(p => p.ParticipanteId == id).FirstOrDefaultAsync();
            if(participante == null) { return false; }
            bdcontexto.LosParticipantes.Remove(participante);
            await bdcontexto.SaveChangesAsync();
            return true;
        }
    }
}
