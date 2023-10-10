using WololoPrueba.Models;

namespace WololoPrueba.Repositories
{
    public interface ICivRepository
    {
        public Task<IEnumerable<Civ>> Listar();
        public Task<Civ> Buscar(int civId);
    }
}