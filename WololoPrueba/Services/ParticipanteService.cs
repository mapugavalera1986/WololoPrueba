using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WololoPrueba.DbContexts;
using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;
using WololoPrueba.Repositories;

namespace WololoPrueba.Services
{
    public class ParticipanteService : IParticipanteRepository
    {
        private readonly AppDbContext bdcontexto;
        private readonly IMapper mapeador;

        public ParticipanteService(AppDbContext bdcontexto, IMapper mapeador)
        {
            this.bdcontexto = bdcontexto;
            this.mapeador = mapeador;
        }
        public ParticipanteService() { }

        public async Task<IEnumerable<Participante>> Listar()
        {
            return await bdcontexto.LosParticipantes.ToListAsync();
        }

        public async Task<Participante> Buscar(int id)
        {
            var participante = await bdcontexto.LosParticipantes.Where(p => p.ParticipanteId == id).FirstOrDefaultAsync();
            return participante;
        }

        public async Task<Participante> Agregar(ParticipanteCrearDto nuevo_p)
        {
            var participante_nuevo = mapeador.Map<Participante>(nuevo_p);
            bdcontexto.LosParticipantes.Add(participante_nuevo);
            await bdcontexto.SaveChangesAsync();
            return participante_nuevo;
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
            if (participante == null) { return false; }
            bdcontexto.LosParticipantes.Remove(participante);
            await bdcontexto.SaveChangesAsync();
            return true;
        }
    }
}
