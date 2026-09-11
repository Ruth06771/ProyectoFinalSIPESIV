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

        public Task<int> Actualizar(TblSubParametro subParametro)
        {
            throw new NotImplementedException();
        }

        public Task<int> Crear(TblSubParametro subParametro)
        {
            throw new NotImplementedException();
        }

        public Task<int> Eliminar(int idSubParametro)
        {
            throw new NotImplementedException();
        }

        public Task<TblSubParametro> ObtenerPorId(int idSubParametro)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TblSubParametro>> ObtenerSubParametros()
        {
            IEnumerable<TblSubParametro> resultado = await _database.GetData<TblSubParametro>("fn_tblsubparametro_obtenertodos");
            return resultado.ToList();
        }
    }
}
