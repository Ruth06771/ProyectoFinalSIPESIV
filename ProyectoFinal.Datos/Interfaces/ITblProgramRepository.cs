using ProyectoFinal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblProgramRepository
    {
        public Task Crear(TblProgram program);
        public Task<TblProgram> ObtenerPorId(int idProgram);
        public Task<List<TblProgram>> ObtenerTodos();
        public Task Actualizar(TblProgram program);
        public Task Eliminar(int idProgram);
    }
}
