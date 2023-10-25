using Microsoft.AspNetCore.Mvc;
using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;
using WololoPrueba.Repositories;

namespace WololoPrueba.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class EnsayoController : ControllerBase
    {
        private readonly IEnsayoRepository ensayoRepository;
        public EnsayoController(IEnsayoRepository ensayoRepository) { this.ensayoRepository = ensayoRepository; }

        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<IEnumerable<EnsayoDto>>> listarEnsayo() {
            return StatusCode(StatusCodes.Status200OK, await ensayoRepository.Listar());
        }
        [HttpPost]
        [Route("agregar")]
        public async Task<ActionResult<EnsayoDto>> agregar(EnsayoDto ensayo)
        {
            return StatusCode(StatusCodes.Status201Created, await ensayoRepository.Agregar(ensayo));
        }
        [HttpGet]
        [Route("buscar/{id}")]
        public async Task<ActionResult<EnsayoDto>> buscar(int id)
        {
            return StatusCode(StatusCodes.Status200OK, await ensayoRepository.Buscar(id));
        }
    }
}
