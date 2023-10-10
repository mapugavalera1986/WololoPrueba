using Microsoft.AspNetCore.Mvc;
using WololoPrueba.Models;
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
        public async Task<IEnumerable<Civ>> Listar() { return await civRepository.Listar(); }

        [HttpGet]
        [Route("{id}")]
        public async Task<Civ> Buscar(int id) { return await civRepository.Buscar(id); }
    }
}