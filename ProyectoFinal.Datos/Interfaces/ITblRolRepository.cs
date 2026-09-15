using ProyectoFinal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblRolRepository
    {
        public Task Crear(TblRol rol);
        public Task<TblRol> ObtenerPorId(int idRol);
        public Task<List<TblRol>> ObtenerTodos();
        public Task Actualizar(TblRol rol);
        public Task Eliminar(int idRol);
    }
}
