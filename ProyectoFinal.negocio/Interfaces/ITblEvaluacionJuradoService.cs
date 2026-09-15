using ProyectoFinal.Negocio.DTOs.TblEvaluacionJurado;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.Interfaces
{
    public interface ITblEvaluacionJuradoService
    {
        public Task Crear(CreateTblEvaluacionJuradoDTO evaluacionJurado);
        public Task Actualizar(UpdateTblEvaluacionJuradoDTO evaluacionJurado);
        public Task Eliminar(int idEvaluacionJurado);
        public Task<List<ReadTblEvaluacionJuradoDTO>> ObtenerTodos();
        public Task<ReadTblEvaluacionJuradoDTO> ObtenerPorId(int idEvaluacionJurado);
    }
}
