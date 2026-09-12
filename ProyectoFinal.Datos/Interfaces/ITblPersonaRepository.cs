using ProyectoFinal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblPersonaRepository
    {
        // CRUD
        public Task<int> Crear(TblPersona persona);
        public Task<int> Actualizar(TblPersona persona);
        public Task<int> Eliminar(int idPersona);
        public Task<TblPersona> ObtenerPorId(int idPersona);
        public Task<List<TblPersona>> ObtenerTodos();
    }
}
