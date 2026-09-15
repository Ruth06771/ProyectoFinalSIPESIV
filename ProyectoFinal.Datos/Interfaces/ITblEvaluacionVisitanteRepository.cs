using ProyectoFinal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblEvaluacionVisitanteRepository
    {
        //CRUD
        public Task Crear(TblEvaluacionVisitante evaluacionVisitante);
        public Task<TblEvaluacionVisitante> ObtenerPorId(int idEvaluacionVisitante);
        public Task<List<TblEvaluacionVisitante>> ObtenerTodos();
        public Task Actualizar(TblEvaluacionVisitante evaluacionVisitante);
        public Task Eliminar(int idEvaluacionVisitante);
    }
}
