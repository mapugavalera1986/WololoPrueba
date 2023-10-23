using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;

namespace WololoPrueba.Repositories
{
    public interface IPremiosRepository
    {
        public Task<IEnumerable<PremioDto>> Listar();
        public Task<PremioDto> Buscar(int id);
        public Task<PremioDto> Agregar(PremioDto nuevo_p);
        public Task<PremioDto> Modificar(PremioDto cambiar_p);
        public Task<bool> Eliminar(int id);
    }
}
