using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WololoPrueba.DbContexts;
using WololoPrueba.Excepciones;
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

        public async Task<IEnumerable<ParticipanteDto>> Listar()
        {
            var los_participantes = await bdcontexto.LosParticipantes.ToListAsync();
            return mapeador.Map<List<ParticipanteDto>>(los_participantes);
        }

        public async Task<ParticipanteDto> Buscar(int id)
        {
            var participante = await bdcontexto.LosParticipantes.Where(p => p.ParticipanteId == id).FirstOrDefaultAsync();
            if (participante == null) { throw new NotFoundException($"No se encontró un participante con la id {id}"); }
            return mapeador.Map<ParticipanteDto>(participante);
        }

        public async Task<ParticipanteDto> Agregar(ParticipanteDto nuevo_p)
        {
            var participante_nuevo = mapeador.Map<Participante>(nuevo_p);
            bdcontexto.LosParticipantes.Add(participante_nuevo);
            await bdcontexto.SaveChangesAsync();
            return mapeador.Map<ParticipanteDto>(participante_nuevo);
        }

        public async Task<ParticipanteDto> Modificar(int id, ParticipanteDto cambiar_p)
        {
            var participante_cambiar = await bdcontexto.LosParticipantes.Where(p => p.ParticipanteId == id).FirstOrDefaultAsync();
            if(participante_cambiar == null)
            {
                throw new NotFoundException($"No se encontró un participante con la id {id}");
            }
            else
            {
                participante_cambiar.ParticipanteId = id;
                participante_cambiar.Nmbrs = cambiar_p.Nmbrs;
                participante_cambiar.Aplld = cambiar_p.Aplld;
                participante_cambiar.Dni = cambiar_p.Dni;
                participante_cambiar.FechaNac = cambiar_p.FechaNac;
                participante_cambiar.ColegioId = cambiar_p.ColegioId;
                bdcontexto.LosParticipantes.Update(participante_cambiar);
                await bdcontexto.SaveChangesAsync();
                return mapeador.Map<ParticipanteDto>(participante_cambiar);
            }
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
