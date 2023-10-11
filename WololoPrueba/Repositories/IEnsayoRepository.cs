using WololoPrueba.Models;

namespace WololoPrueba.Repositories
{
    public interface IEnsayoRepository
    {
        public Task<IEnumerable<Ensayo>> Listar();
        public Task<Ensayo> Buscar(int id);
        public Task<Ensayo> Agregar(Ensayo ensayo);

    }
}
