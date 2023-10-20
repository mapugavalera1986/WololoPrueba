using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;

namespace WololoPrueba.Repositories
{
    public interface ICivRepository
    {
        public Task<IEnumerable<CivDto>> Listar();
        public Task<CivDto> Buscar(int civId);
    }
}