using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WololoPrueba.DbContexts;
using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;
using WololoPrueba.Repositories;

namespace WololoPrueba.Services
{
    
        public class PremioService : IPremioRepository
        {
            private readonly AppDbContext bdcontexto;
            private readonly IMapper mapeador;

            public PremioService(AppDbContext bdcontexto, IMapper mapeador)
            {
                this.bdcontexto = bdcontexto;
                this.mapeador = mapeador;
            }
            public PremioService() { }

        public async Task<IEnumerable<PremioDto>> Listar()
        {
            var los_premios = await bdcontexto.LosPremios.ToListAsync();
            return mapeador.Map<List<PremioDto>>(los_premios);
        }

        public async Task<PremioDto> Buscar(int id)
        {
            var el_premio = await bdcontexto.LosPremios.Where(p => p.PremioId == id).FirstOrDefaultAsync();
            return mapeador.Map<PremioDto>(el_premio);
        }

        public async Task<PremioDto> Agregar(PremioDto nuevo_p)
        {
            var premio_nuevo = mapeador.Map<Premio>(nuevo_p);
            bdcontexto.LosPremios.Add(premio_nuevo);
            await bdcontexto.SaveChangesAsync();
            return mapeador.Map<PremioDto>(premio_nuevo);
        }

        public async Task<PremioDto> Modificar(int id, PremioDto cambiar_p)
        {
            var premio_cambiar = await bdcontexto.LosPremios.Where(p => p.PremioId == id).FirstOrDefaultAsync();
            if (premio_cambiar == null) { return null; }
            else { premio_cambiar.PremioId = id; premio_cambiar.NombPremio = cambiar_p.NombPremio; }
            bdcontexto.LosPremios.Update(premio_cambiar);
            await bdcontexto.SaveChangesAsync();
            return mapeador.Map<PremioDto>(premio_cambiar);
        }

        public async Task<bool> Eliminar(int id)
        {
            var el_premio = await bdcontexto.LosPremios.Where(p => p.PremioId == id).FirstOrDefaultAsync();
            if (el_premio == null) { return false; }
            bdcontexto.LosPremios.Remove(el_premio);
            await bdcontexto.SaveChangesAsync();
            return true;
        }
    }
}
