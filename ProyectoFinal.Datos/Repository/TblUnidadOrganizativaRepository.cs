using ProyectoFinal.Datos.DataAccess;
using ProyectoFinal.Datos.Entities;
using ProyectoFinal.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Repository
{
    public class TblUnidadOrganizativaRepository : ITblUnidadOrganizativaRepository
    {
      private readonly ProyectoFinalDatabase _database;
        public TblUnidadOrganizativaRepository(ProyectoFinalDatabase database)
        {
            _database = database;
        }

        public async Task<int> Crear(TblUnidadOrganizativa unidad)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblunidad_organizativa_crear", new
            {
                lInstitucion_id = unidad.lInstitucion_id,
                sUnidadOrganizativa_nm = unidad.sUnidadOrganizativa_nm,
                sUnidadOrganizativa_tipo = unidad.sUnidadOrganizativa_tipo,
            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Actualizar(TblUnidadOrganizativa unidad)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblunidad_organizativa_actualizar", new TblUnidadOrganizativa
            {
                lUnidadOrganizativa_id = unidad.lUnidadOrganizativa_id,
                lInstitucion_id = unidad.lInstitucion_id,
                sUnidadOrganizativa_nm = unidad.sUnidadOrganizativa_nm,
                sUnidadOrganizativa_tipo = unidad.sUnidadOrganizativa_tipo,
            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Eliminar(int unidad)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblunidad_organizativa_eliminar", new
            {
                lUnidadOrganizativa_id = unidad
            });
            return resultado.FirstOrDefault();
        }
        public async Task<List<TblUnidadOrganizativa>> ObtenerUnidadesOrganizativas()
        {
            IEnumerable<TblUnidadOrganizativa> resultado = await _database.GetData<TblUnidadOrganizativa>("fn_tblunidad_organizativa_obtener_unidades");
            return resultado.ToList();
        }

        public async Task<TblUnidadOrganizativa> ObtenerPorId(int unidad)
        {
            IEnumerable<TblUnidadOrganizativa> resultado = await _database.GetData<TblUnidadOrganizativa>("fn_tblunidad_organizativa_obtener_por_id", new
            {
                lUnidadOrganizativa_id = unidad 
            });
            return resultado.FirstOrDefault();
        }

    }
}
