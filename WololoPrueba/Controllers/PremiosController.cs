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
            public async Task<IEnumerable<PremioDto>> Listar() { return await premiosRepository.Listar(); }

            [HttpGet]
            [Route("{id}")]
            public async Task<PremioDto> Buscar(int id) { return await premiosRepository.Buscar(id); }

            [HttpPost]
            [Route("agregar")]
            public async Task<PremioDto> Agregar(PremioDto nuevo_p) { return await premiosRepository.Agregar(nuevo_p); }

            [HttpPut]
            [Route("modificar/{id}")]
            public async Task<PremioDto> Modificar(int id, PremioDto cambiar_p) { return await premiosRepository.Modificar(id, cambiar_p); }

            [HttpDelete]
            [Route("eliminar")]
            public async Task<bool> Eliminar(int id) { return await premiosRepository.Eliminar(id); }
        }
    
}
