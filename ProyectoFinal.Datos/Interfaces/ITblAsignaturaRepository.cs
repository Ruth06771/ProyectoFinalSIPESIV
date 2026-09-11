using ProyectoFinal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public class ITblAsignaturaRepository
    {
        public Task<int> Crear(TblAsignatura);
        public Task<int> Actualizar(TblAsignatura);
        public Task<int> Eliminar(int idAsignatura);
        public Task<int> ObtenerPorId(int idAsignatura);
        public Task<List<TblAsignatura>> ObtenerAsignaturas();
    }
}
