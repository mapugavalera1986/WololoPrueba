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
        public async Task<IEnumerable<ParticipanteDto>> Listar() { return await participanteRepository.Listar(); }

        [HttpGet]
        [Route("{id}")]
        public async Task<ParticipanteDto> Buscar(int id) { return await participanteRepository.Buscar(id);}

        [HttpPost]
        [Route("agregar")]
        public async Task<ParticipanteDto> Agregar(ParticipanteDto nuevo_p) { return await participanteRepository.Agregar(nuevo_p); }

        [HttpPut]
        [Route("modificar/{id}")]
        public async Task<ParticipanteDto> Modificar(int id, ParticipanteDto cambiar_p) { return await participanteRepository.Modificar(id, cambiar_p); }

        [HttpDelete]
        [Route("eliminar")]
        public async Task<bool> Eliminar(int id) { return await participanteRepository.Eliminar(id); }
    }
}
