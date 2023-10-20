﻿using Microsoft.AspNetCore.Mvc;
using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;
using WololoPrueba.Repositories;

namespace WololoPrueba.Controllers
{
    
        [ApiController]
        [Route("api/[controller]")]
        public class PremiosController : ControllerBase
        {
            private readonly IPremiosRepository premiosRepository;
            public PremiosController(IPremiosRepository premiosRepository) { this.premiosRepository = premiosRepository; }

            [HttpGet]
            [Route("listar")]
            public async Task<IEnumerable<Premios>> Listar() { return await premiosRepository.Listar(); }

            [HttpGet]
            [Route("{id}")]
            public async Task<Premios> Buscar(int id) { return await premiosRepository.Buscar(id); }

            [HttpPost]
            [Route("agregar")]
            public async Task<Premios> Agregar(PremiosCrearDto nuevo_p) { return await premiosRepository.Agregar(nuevo_p); }

            [HttpPut]
            [Route("modificar")]
            public async Task<Premios> Modificar(Premios cambiar_p) { return await premiosRepository.Modificar(cambiar_p); }

            [HttpDelete]
            [Route("eliminar")]
            public async Task<bool> Eliminar(int id) { return await premiosRepository.Eliminar(id); }
        }
    
}
