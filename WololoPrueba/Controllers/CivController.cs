using Microsoft.AspNetCore.Mvc;
using WololoPrueba.Models;
using WololoPrueba.Repositories;

namespace WololoPrueba.Controllers
{
    [ApiController]
    [Route("aoeconcurso/[controller]")]
    public class CivController: ControllerBase
    {
        private readonly ICivRepository civRepository;
        public CivController(ICivRepository civRepository) { this.civRepository = civRepository; }
        [HttpGet]
        public async Task<IEnumerable<Civ>> GetCivs() { return await civRepository.GetCivs(); }
    }
}