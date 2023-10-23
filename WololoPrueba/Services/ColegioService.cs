using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<IEnumerable<ColegioDto>> Listar()
        {
            var los_colegios = await bdcontexto.LosColegios.ToListAsync();
            return mapeador.Map<List<ColegioDto>>(los_colegios);
        }

        public async Task<ColegioDto> Buscar(int id)
        {
            var colegio = await bdcontexto.LosColegios.Where(c => c.ColegioId == id).FirstOrDefaultAsync();
            return mapeador.Map<ColegioDto>(colegio);
        }

        public async Task<ColegioDto> Agregar(ColegioDto nuevo_c)
        {
            var colegio_nuevo = mapeador.Map<Colegio>(nuevo_c);
            bdcontexto.LosColegios.Add(colegio_nuevo);
            await bdcontexto.SaveChangesAsync();
            return mapeador.Map<ColegioDto>(colegio_nuevo);
        }

        public async Task<ColegioDto> Modificar(int id, ColegioDto cambiar_c)
        {
            var colegio_cambiar = await bdcontexto.LosColegios.Where(c => c.ColegioId == id).FirstOrDefaultAsync();
            if(colegio_cambiar == null)
            {
                return null;
            }
            else
            {
                colegio_cambiar.ColegioId = id;
                colegio_cambiar.Nmbr = cambiar_c.Nmbr;
                colegio_cambiar.Nivel = cambiar_c.Nivel;
                colegio_cambiar.Direccn = cambiar_c.Direccn;
                bdcontexto.LosColegios.Update(colegio_cambiar);
                await bdcontexto.SaveChangesAsync();
                return mapeador.Map<ColegioDto>(colegio_cambiar);
            }
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