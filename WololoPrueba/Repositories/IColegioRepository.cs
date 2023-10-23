using Microsoft.AspNetCore.Mvc;
using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;

namespace WololoPrueba.Repositories
{
    public interface IColegioRepository
    {
        public Task<IEnumerable<ColegioDto>> Listar();
        public Task<ColegioDto> Buscar(int id);
        public Task<ColegioDto> Agregar(ColegioDto nuevo_c);
        public Task<ColegioDto> Modificar(int id, ColegioDto cambiar_c);
        public Task<bool> Eliminar(int id);
    }
}
