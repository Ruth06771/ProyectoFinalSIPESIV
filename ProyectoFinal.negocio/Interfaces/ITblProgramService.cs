using ProyectoFinal.Negocio.DTOs.TblProgram;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.Interfaces
{
    public interface ITblProgramService
    {
        // CRUD
        public Task Crear(CreateTblProgramDTO program);
        public Task Actualizar(UpdateTblProgramDTO program);
        public Task Eliminar(int idProgram);
        public Task<List<ReadTblProgramDTO>> ObtenerTodos();
        public Task<ReadTblProgramDTO> ObtenerPorId(int idProgram);
    }
}
