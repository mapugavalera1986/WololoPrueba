using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;

namespace WololoPrueba.Repositories
{
    public interface IEnsayoRepository
    {
        public Task<IEnumerable<EnsayoDto>> Listar();
        public Task<EnsayoDto> Buscar(int id);
        public Task<EnsayoDto> Agregar(EnsayoDto ensayo);

    }
}
