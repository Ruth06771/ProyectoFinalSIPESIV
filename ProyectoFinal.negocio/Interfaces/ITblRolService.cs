using ProyectoFinal.Negocio.DTOs.TblRol;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.Interfaces
{
    public interface ITblRolService
    {
        // CRUD
        public Task Crear(CreateTblRolDTO rol);
        public Task Actualizar(UpdateTblRolDTO rol);
        public Task Eliminar(int idRol);
        public Task<List<ReadTblRolDTO>> ObtenerTodos();
        public Task<ReadTblRolDTO> ObtenerPorId(int idRol);
    }
}
