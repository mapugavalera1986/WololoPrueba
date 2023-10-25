using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WololoPrueba.DbContexts;
using WololoPrueba.Excepciones;
using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;
using WololoPrueba.Repositories;

namespace WololoPrueba.Services
{
    public class EnsayoService : IEnsayoRepository
    {
        private readonly AppDbContext bdContexto;
        private readonly IMapper mapeador;
        public EnsayoService(AppDbContext bdContexto, IMapper mapeador)
        { this.bdContexto = bdContexto; this.mapeador = mapeador; }
        public EnsayoService() { }

        public async Task<EnsayoDto> Agregar(EnsayoDto ensayo)
        {
            var procesar_ensayo = mapeador.Map<Ensayo>(ensayo);
            bdContexto.LosEnsayos.Add(procesar_ensayo);
            await bdContexto.SaveChangesAsync();
            return mapeador.Map<EnsayoDto>(ensayo);
        }

        public async Task<EnsayoDto> Buscar(int id)
        {
            var ensayo = await bdContexto.LosEnsayos.Where(e => e.EnsayoId == id).FirstOrDefaultAsync();
            if (ensayo == null) { throw new NotFoundException($"No se encontró un ensayo con la id {id}"); }
            return mapeador.Map<EnsayoDto>(ensayo);
        }

        public async Task<IEnumerable<EnsayoDto>> Listar()
        {
            var los_ensayos = await bdContexto.LosEnsayos.ToListAsync();
            return mapeador.Map<List<EnsayoDto>>(los_ensayos);
        }
    }
}
