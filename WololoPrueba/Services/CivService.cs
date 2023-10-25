using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WololoPrueba.DbContexts;
using WololoPrueba.Excepciones;
using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;
using WololoPrueba.Repositories;

namespace WololoPrueba.Services
{
    public class CivService : ICivRepository
    {
        private readonly AppDbContext bdcontexto;
        private readonly IMapper mapeador;

        public CivService(AppDbContext bdcontexto, IMapper mapeador)
        {
            this.bdcontexto = bdcontexto;
            this.mapeador = mapeador;
        }
        public CivService() { }

        public async Task<CivDto> Buscar(int civId)
        {
            var civ = await bdcontexto.LasCivs.Where(c => c.CivId == civId).FirstOrDefaultAsync();
            if (civ == null) { throw new NotFoundException($"No se encontró una civilización con la id {civId}"); }
            return mapeador.Map<CivDto>(civ);
        }

        public async Task<IEnumerable<CivDto>> Listar()
        {
            var las_civs = await bdcontexto.LasCivs.ToListAsync();
            return mapeador.Map<List<CivDto>>(las_civs);
        }
    }
}
