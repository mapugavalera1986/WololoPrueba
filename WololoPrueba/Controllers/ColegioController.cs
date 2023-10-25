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
        public async Task<ActionResult<IEnumerable<ColegioDto>>> Listar() {
            return StatusCode(StatusCodes.Status200OK, await colegioRepository.Listar()); }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ColegioDto>> Buscar(int id) {
            return StatusCode(StatusCodes.Status200OK, await colegioRepository.Buscar(id)); }

        [HttpPost]
        [Route("agregar")]
        public async Task<ActionResult<ColegioDto>> Agregar(ColegioDto nuevo_c) {
            return StatusCode(StatusCodes.Status201Created, await colegioRepository.Agregar(nuevo_c)); }

        [HttpPut]
        [Route("modificar/{id}")]
        public async Task<ActionResult<ColegioDto>> Modificar(int id, ColegioDto cambiar_c) { 
            return StatusCode(StatusCodes.Status200OK, await colegioRepository.Modificar(id, cambiar_c)); }

        [HttpDelete]
        [Route("eliminar")]
        public async Task<ActionResult<bool>> Eliminar(int id) { 
            return StatusCode(StatusCodes.Status200OK, await colegioRepository.Eliminar(id)); }
    }
}
