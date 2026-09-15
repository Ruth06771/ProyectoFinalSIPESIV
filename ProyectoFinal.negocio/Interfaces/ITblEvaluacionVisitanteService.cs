using ProyectoFinal.Negocio.DTOs.TblEvaluacionVisitante;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.Interfaces
{
    public interface ITblEvaluacionVisitanteService
    {
        public Task Crear(CreateTblEvaluacionVisitanteDTO evaluacionVisitante);
        public Task Actualizar(UpdateTblEvaluacionVisitanteDTO evaluacionVisitante);
        public Task Eliminar(int idEvaluacionVisitante);
        public Task<List<ReadTblEvaluacionVisitanteDTO>> ObtenerTodos();
        public Task<ReadTblEvaluacionVisitanteDTO> ObtenerPorId(int idEvaluacionVisitante);
    }
}
