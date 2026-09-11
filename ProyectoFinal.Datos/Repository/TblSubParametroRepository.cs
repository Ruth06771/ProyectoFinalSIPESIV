using ProyectoFinal.Datos.DataAccess;
using ProyectoFinal.Datos.Entities;
using ProyectoFinal.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Repository
{
    public class TblSubParametroRepository : ITblSubParametroRepository
    {
        private readonly ProyectoFinalDatabase _database;
        public TblSubParametroRepository(ProyectoFinalDatabase database)
        {
            _database = database;
        }
        public async Task<List<TblSubParametro>> ObtenerSubParametros()
        {
            IEnumerable<TblSubParametro> resultado = await _database.GetData<TblSubParametro>("fn_tblsubparametro_obtenertodos");
            return resultado.ToList();
        }
    }
}
