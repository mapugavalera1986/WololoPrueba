﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WololoPrueba.DbContexts;
using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;
using WololoPrueba.Repositories;

namespace WololoPrueba.Services
{
    
        public class PremiosService : IPremiosRepository
        {
            private readonly AppDbContext bdcontexto;
            private readonly IMapper mapeador;

            public PremiosService(AppDbContext bdcontexto, IMapper mapeador)
            {
                this.bdcontexto = bdcontexto;
                this.mapeador = mapeador;
            }
            public PremiosService() { }

            public async Task<IEnumerable<Premio>> Listar()
            {
                return await bdcontexto.LosPremios.ToListAsync();
            }

            public async Task<Premio> Buscar(int id)
            {
                var premios = await bdcontexto.LosPremios.Where(p => p.PremioId == id).FirstOrDefaultAsync();
                return premios;
            }

            public async Task<Premio> Agregar(PremioDto nuevo_p)
            {
                var premio_nuevo = mapeador.Map<Premio>(nuevo_p);
                bdcontexto.LosPremios.Add(premio_nuevo);
                await bdcontexto.SaveChangesAsync();
                return premio_nuevo;
            }

            public async Task<Premio> Modificar(Premio cambiar_p)
            {
                bdcontexto.LosPremios.Update(cambiar_p);
                await bdcontexto.SaveChangesAsync();
                return cambiar_p;
            }

            public async Task<bool> Eliminar(int id)
            {
                var premio = await bdcontexto.LosPremios.Where(p => p.PremioId == id).FirstOrDefaultAsync();
                if (premio == null) { return false; }
                bdcontexto.LosPremios.Remove(premio);
                await bdcontexto.SaveChangesAsync();
                return true;
            }
        }
}
