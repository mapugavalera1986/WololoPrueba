using Microsoft.AspNetCore.Mvc;
using WololoPrueba.Models;
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
        public async Task<IEnumerable<Participante>> Listar() { return await participanteRepository.Listar(); }

        [HttpGet]
        [Route("{id}")]
        public async Task<Participante> Buscar(int id) { return await participanteRepository.Buscar(id);}

        [HttpPost]
        [Route("agregar")]
        public async Task<Participante> Agregar(Participante nuevo_p) { return await participanteRepository.Agregar(nuevo_p); }

        [HttpPut]
        [Route("modificar")]
        public async Task<Participante> Modificar(Participante nuevo_p) { return await participanteRepository.Modificar(nuevo_p); }

        [HttpDelete]
        [Route("eliminar")]
        public async Task<bool> Eliminar(int id) { return await participanteRepository.Eliminar(id); }
    }
}
