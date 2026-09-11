using ProyectoFinal.Negocio.DTOs.TblParametro;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.Interfaces
{
    public interface ITblParametroService
    {
        public Task Crear(CreateTblParametroDTO parametro);
        public Task Actualizar(UpdateTblParametroDTO parametro);
        public Task Eliminar(int idParametro);
        public Task<ReadTblParametroDTO> ObtenerPorId(int idParametro);
        public Task<List<ReadTblParametroDTO>> ObtenerParametros();
    }
}
