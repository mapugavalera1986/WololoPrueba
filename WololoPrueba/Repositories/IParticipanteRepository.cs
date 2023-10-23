using WololoPrueba.DbContexts;
using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;

namespace WololoPrueba.Repositories
{
    public interface IParticipanteRepository
    {
        public Task<IEnumerable<ParticipanteDto>> Listar();
        public Task<ParticipanteDto> Buscar(int id);
        public Task<ParticipanteDto> Agregar(ParticipanteDto nuevo_p);
        public Task<ParticipanteDto> Modificar(int id, ParticipanteDto cambiar_p);
        public Task<bool> Eliminar(int id);
    }
}
