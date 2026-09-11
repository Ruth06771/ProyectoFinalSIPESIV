using ProyectoFinal.Datos.DataAccess;
using ProyectoFinal.Datos.Entities;
using ProyectoFinal.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Repository
{
    public class TblParametroRepository : ITblParametroRepository 
    {
        private readonly ProyectoFinalDatabase _database; 
        public TblParametroRepository(ProyectoFinalDatabase database)
        {
            _database = database;
        } 

        public async Task<int> Actualizar(TblParametro parametro)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblparametro_actualizar", new TblParametro
            {
                lParametro_id = parametro.lParametro_id,
                sParametro_nm = parametro.sParametro_nm,
                sParametro_desc = parametro.sParametro_desc
            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Crear(TblParametro parametro)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblparametro_crear", new
            {
                sParametro_nm = parametro.sParametro_nm,
                sParametro_desc = parametro.sParametro_desc
            });
            return resultado.FirstOrDefault();
        }

        public async Task<int> Eliminar(int idParametro)
        {
            IEnumerable<int> resultado = await _database.GetData<int>("fn_tblparametro_eliminar", new
            {
                lParametro_id = idParametro
            });
            return resultado.FirstOrDefault();
        }

        public async Task<List<TblParametro>> ObtenerParametros()
        {
            IEnumerable<TblParametro> resultado = await _database.GetData<TblParametro>("fn_tblparametro_obtenertodos");
            return resultado.ToList();
        }

        public async Task<TblParametro> ObtenerPorId(int idParametro)
        {
            IEnumerable<TblParametro> resultado = await _database.GetData<TblParametro>("fn_tblparametro_obtenerporid", new
            {
                lParametro_id = idParametro
            });
            return resultado.FirstOrDefault();
        }

    }
}
