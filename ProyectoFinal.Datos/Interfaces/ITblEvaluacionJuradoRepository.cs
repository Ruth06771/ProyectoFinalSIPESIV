using ProyectoFinal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblEvaluacionJuradoRepository
    {
        //CRUD
        public Task Crear(TblEvaluacionJurado evaluacionJurado);
        public Task<TblEvaluacionJurado> ObtenerPorId(int idEvaluacionJurado);
        public Task<List<TblEvaluacionJurado>> ObtenerTodos();
        public Task Actualizar(TblEvaluacionJurado evaluacionJurado);
        public Task Eliminar(int idEvaluacionJurado);
    }
}
