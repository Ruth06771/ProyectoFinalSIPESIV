using ProyectoFinal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public class ITblParametroRepository
    {
        public Task<int> Crear(TblParametro parametro);
        public Task<int> Actualizar(TblParametro parametro);
        public Task<int> Eliminar(int idParametro);
        public Task<TblParametro> ObtenerPorId(int idParametro);
        public Task<List<TblParametro>> ObtenerParametros();

    }
}
