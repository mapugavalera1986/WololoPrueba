using Microsoft.AspNetCore.Mvc;
using WololoPrueba.Models;
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
    }
}
