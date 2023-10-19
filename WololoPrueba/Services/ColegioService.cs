using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WololoPrueba.DbContexts;
using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;
using WololoPrueba.Repositories;

namespace WololoPrueba.Services
{
    public class ColegioService : IColegioRepository
    {
        private readonly AppDbContext bdcontexto;
        private readonly IMapper mapeador;

        public ColegioService(AppDbContext bdcontexto, IMapper mapeador)
        {
            this.bdcontexto = bdcontexto;
            this.mapeador = mapeador;
        }
        public ColegioService() { }

        public Task<IEnumerable<ColegioCrearDto>> Listar()
        {
            return Listar(bdcontexto);
        }

        public async Task<IEnumerable<ColegioCrearDto>> Listar(AppDbContext bdcontexto)
        {
            var lascosas = await bdcontexto.LosColegios.ForEachAsync(c => mapeador.Map<ColegioCrearDto>(c));
            return lascosas;
        }

        public async Task<Colegio> Buscar(int id)
        {
            var colegio = await bdcontexto.LosColegios.Where(c => c.ColegioId == id).FirstOrDefaultAsync();
            return colegio;
        }

        public async Task<Colegio> Agregar(ColegioCrearDto nuevo_c)
        {
            var colegio_nuevo = mapeador.Map<Colegio>(nuevo_c);
            bdcontexto.LosColegios.Add(colegio_nuevo);
            await bdcontexto.SaveChangesAsync();
            return colegio_nuevo;
        }

        public async Task<Colegio> Modificar(Colegio cambiar_c)
        {
            bdcontexto.LosColegios.Update(cambiar_c);
            await bdcontexto.SaveChangesAsync();
            return cambiar_c;
        }

        public async Task<bool> Eliminar(int id)
        {
            var colegio = await bdcontexto.LosColegios.Where(c => c.ColegioId == id).FirstOrDefaultAsync();
            if (colegio == null) { return false; }
            bdcontexto.LosColegios.Remove(colegio);
            await bdcontexto.SaveChangesAsync();
            return true;
        }
    }
}