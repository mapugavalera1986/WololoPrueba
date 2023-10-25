using Microsoft.AspNetCore.Mvc;
using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;
using WololoPrueba.Repositories;

namespace WololoPrueba.Controllers
{
    
        [ApiController]
        [Route("api/[controller]")]
        public class PremiosController : ControllerBase
        {
            private readonly IPremioRepository premiosRepository;
            public PremiosController(IPremioRepository premiosRepository) { this.premiosRepository = premiosRepository; }

            [HttpGet]
            [Route("listar")]
            public async Task<ActionResult<IEnumerable<PremioDto>>> Listar() { 
            return StatusCode(StatusCodes.Status200OK, await premiosRepository.Listar()); 
        }

            [HttpGet]
            [Route("{id}")]
            public async Task<ActionResult<PremioDto>> Buscar(int id) {
            return StatusCode(StatusCodes.Status200OK, await premiosRepository.Buscar(id)); }

            [HttpPost]
            [Route("agregar")]
            public async Task<ActionResult<PremioDto>> Agregar(PremioDto nuevo_p) { 
            return StatusCode(StatusCodes.Status201Created, await premiosRepository.Agregar(nuevo_p)); }

            [HttpPut]
            [Route("modificar/{id}")]
            public async Task<ActionResult<PremioDto>> Modificar(int id, PremioDto cambiar_p) { 
            return StatusCode(StatusCodes.Status200OK, await premiosRepository.Modificar(id, cambiar_p)); }

            [HttpDelete]
            [Route("eliminar")]
            public async Task<ActionResult<bool>> Eliminar(int id) {
            return StatusCode(StatusCodes.Status200OK, await premiosRepository.Eliminar(id)); }
        }
    
}
