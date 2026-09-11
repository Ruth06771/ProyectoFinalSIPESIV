using ProyectoFinal.Negocio.DTOs.TblAsignatura;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.Interfaces
{
    public interface ITblAsignaturaService
    {
        public Task Crear(CreateTblAsignaturaDTO asignatura);
        public Task Actualizar(UpdateTblAsignaturaDTO asignatura);
        public Task Eliminar(int idAsignatura);
        public Task<ReadTblAsignaturaDTO> ObtenerPorId(int idAsignatura);
        public Task<List<ReadTblAsignaturaDTO>> ObtenerAsignaturas();
    }
}
