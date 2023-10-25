using Microsoft.AspNetCore.Mvc;
using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;
using WololoPrueba.Repositories;

namespace WololoPrueba.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParticipanteController: ControllerBase
    {
        private readonly IParticipanteRepository participanteRepository;
        public ParticipanteController(IParticipanteRepository participanteRepository) { this.participanteRepository = participanteRepository; }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ParticipanteDto>>> Listar() { 
            return StatusCode(StatusCodes.Status200OK, await participanteRepository.Listar()); }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ParticipanteDto>> Buscar(int id) {
            return StatusCode(StatusCodes.Status200OK, await participanteRepository.Buscar(id));}

        [HttpPost]
        [Route("agregar")]
        public async Task<ActionResult<ParticipanteDto>> Agregar(ParticipanteDto nuevo_p) { 
            return StatusCode(StatusCodes.Status201Created, await participanteRepository.Agregar(nuevo_p)); }

        [HttpPut]
        [Route("modificar/{id}")]
        public async Task<ActionResult<ParticipanteDto>> Modificar(int id, ParticipanteDto cambiar_p) { 
            return StatusCode(StatusCodes.Status200OK, await participanteRepository.Modificar(id, cambiar_p)); }

        [HttpDelete]
        [Route("eliminar")]
        public async Task<ActionResult<bool>> Eliminar(int id) { 
            return StatusCode(StatusCodes.Status200OK, await participanteRepository.Eliminar(id)); }
    }
}
