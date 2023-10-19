﻿using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;

namespace WololoPrueba.Repositories
{
    public interface IColegioRepository
    {
        public Task<IEnumerable<ColegioCrearDto>> Listar();
        public Task<Colegio> Buscar(int id);
        public Task<Colegio> Agregar(ColegioCrearDto nuevo_c);
        public Task<Colegio> Modificar(Colegio cambiar_c);
        public Task<bool> Eliminar(int id);
    }
}
