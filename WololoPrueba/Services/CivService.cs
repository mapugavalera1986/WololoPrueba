using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WololoPrueba.DbContexts;
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
            return mapeador.Map<CivDto>(civ);
        }

        public async Task<IEnumerable<CivDto>> Listar()
        {
            var las_civs = await bdcontexto.LasCivs.ToListAsync();
            return mapeador.Map<List<CivDto>>(las_civs);
        }
    }
}
