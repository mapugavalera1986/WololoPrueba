using Microsoft.AspNetCore.Mvc;
using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;
using WololoPrueba.Repositories;

namespace WololoPrueba.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColegioController: ControllerBase
    {
        private readonly IColegioRepository colegioRepository;
        public ColegioController(IColegioRepository colegioRepository) { this.colegioRepository = colegioRepository; }

        [HttpGet]
        public async Task<IEnumerable<Colegio>> Listar() { return await colegioRepository.Listar(); }

        [HttpGet]
        [Route("{id}")]
        public async Task<Colegio> Buscar(int id) { return await colegioRepository.Buscar(id); }

        [HttpPost]
        [Route("agregar")]
        public async Task<Colegio> Agregar(ColegioCrearDto nuevo_c) { return await colegioRepository.Agregar(nuevo_c); }

        [HttpPut]
        [Route("modificar")]
        public async Task<Colegio> Modificar(Colegio cambiar_c) { return await colegioRepository.Modificar(cambiar_c); }

        [HttpDelete]
        [Route("eliminar")]
        public async Task<bool> Eliminar(int id) { return await colegioRepository.Eliminar(id); }
    }
}
