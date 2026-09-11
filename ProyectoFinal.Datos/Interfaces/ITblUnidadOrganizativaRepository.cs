using ProyectoFinal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public class ITblUnidadOrganizativaRepository
    {
        public Task<int> Crear(TblUnidadOrganizativa UnidadOrganizativa); 
        public Task<int> Actualizar(TblUnidadOrganizativa UnidadOrganizativa);
        public Task<int> Eliminar(int idUnidadOrganizativa);
        public Task<int> ObtenerPorId(int idUnidadOrganizativa);
        public Task<List<TblUnidadOrganizativa>> ObtenerUnidadesOrganizativas();
    }
}
