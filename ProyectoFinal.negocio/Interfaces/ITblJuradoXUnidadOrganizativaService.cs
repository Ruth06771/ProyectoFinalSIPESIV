using ProyectoFinal.Negocio.DTOs.TblJuradoXUnidadOrganzativa;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoFinal.Negocio.Interfaces
{
    public interface ITblJuradoXUnidadOrganizativaService
    {
        public Task Crear(CreateTblJuradoXUnidadOrganzativaDTO juradoXUnidad);
        public Task Actualizar(UpdateTblJuradoXUnidadOrganzativaDTO juradoXUnidad);
        public Task Eliminar(int idJuradoXUnidad);
        public Task<List<ReadTblJuradoXUnidadOrganzativaDTO>> ObtenerTodos();
        public Task<ReadTblJuradoXUnidadOrganzativaDTO> ObtenerPorId(int idJuradoXUnidad);
    }
}
