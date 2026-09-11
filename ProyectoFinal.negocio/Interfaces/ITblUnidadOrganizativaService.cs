using ProyectoFinal.Negocio.DTOs.TblUnidadOrganizativa;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.Interfaces
{
    public interface ITblUnidadOrganizativaService
    {
        public Task Crear(CreateTblUnidadOrganizativaDTO unidadOrganizativa);
        public Task Actualizar(UpdateTblUnidadOrganizativaDTO unidadOrganizativa);
        public Task Eliminar(int idUnidadOrganizativa);
        public Task<ReadTblUnidadOrganizativaDTO> ObtenerPorId(int idUnidadOrganizativa);
        public Task<List<ReadTblUnidadOrganizativaDTO>> ObtenerUnidadesOrganizativas();
    }
}
