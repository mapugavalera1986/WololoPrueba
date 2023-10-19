using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;

namespace WololoPrueba.Repositories
{
    public interface IPremiosRepository
    {
        public Task<IEnumerable<Premios>> Listar();
        public Task<Premios> Buscar(int id);
        public Task<Premios> Agregar(PremiosCrearDto nuevo_p);
        public Task<Premios> Modificar(Premios cambiar_p);
        public Task<bool> Eliminar(int id);
    }
}
