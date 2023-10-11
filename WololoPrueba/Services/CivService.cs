using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WololoPrueba.DbContexts;
using WololoPrueba.Models;
using WololoPrueba.Repositories;

namespace WololoPrueba.Services
{
    public class CivService : ICivRepository
    {
        private readonly AppDbContext bdcontexto;
        public CivService(AppDbContext bdcontexto)
        {
            this.bdcontexto = bdcontexto;
        }
        public CivService() { }

        public async Task<Civ> Buscar(int civId)
        {
            var civ = await bdcontexto.LasCivs.Where(c => c.CivId == civId).FirstOrDefaultAsync();
            return civ;
        }

        public async Task<IEnumerable<Civ>> Listar()
        {
            return await bdcontexto.LasCivs.ToListAsync();
        }
    }
}
