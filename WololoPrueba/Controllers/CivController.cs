using Microsoft.AspNetCore.Mvc;
using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;
using WololoPrueba.Repositories;

namespace WololoPrueba.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CivController: ControllerBase
    {
        private readonly ICivRepository civRepository;
        public CivController(ICivRepository civRepository) { this.civRepository = civRepository; }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CivDto>>> Listar() {
            return StatusCode(StatusCodes.Status200OK, await civRepository.Listar()); }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<CivDto>> Buscar(int id) {
            return StatusCode(StatusCodes.Status200OK, await civRepository.Buscar(id)); }
    }
}