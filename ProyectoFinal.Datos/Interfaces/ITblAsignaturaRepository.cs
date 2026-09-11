using ProyectoFinal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblAsignaturaRepository
    {
        public Task<int> Crear(TblAsignatura asignatura);
        public Task<int> Actualizar(TblAsignatura asignatura);
        public Task<int> Eliminar(int idAsignatura);
        public Task<TblAsignatura> ObtenerPorId(int idAsignatura);
        public Task<List<TblAsignatura>> ObtenerAsignaturas();
    }
}
