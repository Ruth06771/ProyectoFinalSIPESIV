using ProyectoFinal.Negocio.DTOs.TblInstitucion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.Interfaces
{
    public interface ITblInstitucionService
    {
        public Task Crear(CreateTblInstitucionDTO institucion);
        public Task Actualizar(UpdateTblInstitucionDTO institucion);
        public Task Eliminar(int idInstitucion);
        public Task<ReadTblInstitucionDTO> ObtenerPorId(int idInstitucion);
        public Task<List<ReadTblInstitucionDTO>> ObtenerInstituciones();
    }
}
