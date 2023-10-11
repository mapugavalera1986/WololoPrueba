using Microsoft.AspNetCore.Mvc;
using WololoPrueba.Models;
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
        public async Task<IEnumerable<Ensayo>> listarEnsayo() {
            return await ensayoRepository.Listar();
        }
        [HttpPost]
        [Route("agregar")]
        public async Task<Ensayo> agregar(Ensayo ensayo)
        {
            return await ensayoRepository.Agregar(ensayo);
        }
        [HttpGet]
        [Route("buscar/{id}")]
        public async Task<Ensayo> buscar(int id)
        {
            return await ensayoRepository.Buscar(id);
        }
        

        
        
    }
}
