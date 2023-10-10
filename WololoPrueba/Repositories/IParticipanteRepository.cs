using WololoPrueba.DbContexts;
using WololoPrueba.Models;

namespace WololoPrueba.Repositories
{
    public interface IParticipanteRepository
    {
        public Task<IEnumerable<Participante>> Listar();
        public Task<Participante> Buscar(int id);
        public Task<Participante> Agregar(Participante nuevo_p);
        public Task<Participante> Modificar(Participante cambiar_p);
        public Task<bool> Eliminar(int id);
    }
}
