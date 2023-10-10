using WololoPrueba.Models;

namespace WololoPrueba.Repositories
{
    public interface IColegioRepository
    {
        public Task<IEnumerable<Colegio>> Listar();
        public Task<Colegio> Buscar(int id);
        public Task<Colegio> Agregar(Colegio nuevo_c);
        public Task<Colegio> Modificar(Colegio cambiar_c);
        public Task<bool> Eliminar(int id);
    }
}
