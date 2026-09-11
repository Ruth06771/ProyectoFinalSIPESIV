using ProyectoFinal.Datos.Entities;
using ProyectoFinal.Datos.Interfaces;
using ProyectoFinal.Negocio.DTOs.TblParametro;
using ProyectoFinal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.Services
{
    public class TblParametroService : ITblParametroService
    {
        private readonly ITblParametroRepository _tblParametroRepository;

        public TblParametroService(ITblParametroRepository tblParametroRepository)
        {
            _tblParametroRepository = tblParametroRepository;
        }

        public async Task Actualizar(UpdateTblParametroDTO parametro)
        {
            TblParametro parametroActualizado = new TblParametro
            {
                lParametro_id = parametro.lParametro_id,
                sParametro_desc = parametro.sParametro_desc,
                sParametro_nm = parametro.sParametro_nm
            };
            int resultado = await _tblParametroRepository.Actualizar(parametroActualizado);
            if (resultado == 0)
            {
                throw new Exception("Ocurrió un error al actualizar el parametro");
            }
        }

        public async Task Crear(CreateTblParametroDTO parametro)
        {
            TblParametro parametroCreado = new TblParametro
            {
                sParametro_desc = parametro.sParametro_desc,
                sParametro_nm = parametro.sParametro_nm
            };
            int resultado = await _tblParametroRepository.Crear(parametroCreado);
            if (resultado == 0)
            {
                throw new Exception("Ocurrió un error al crear el parametro");
            }
        }

        public async Task Eliminar(int idParametro)
        {
            int resultado = await _tblParametroRepository.Eliminar(idParametro);
            if (resultado == 0)
            {
                throw new Exception("Ocurrió un error al eliminar el parametro");
            }
        }

        public async Task<List<ReadTblParametroDTO>> ObtenerParametros()
        {
            var parametros = await _tblParametroRepository.ObtenerParametros();
            return parametros.Select(param => new ReadTblParametroDTO
            {
                lParametro_id = param.lParametro_id,
                sParametro_desc = param.sParametro_desc,
                sParametro_nm = param.sParametro_nm
            }).ToList();
        }

        public async Task<ReadTblParametroDTO> ObtenerPorId(int idParametro)
        {
            var parametro = await _tblParametroRepository.ObtenerPorId(idParametro);
            if (parametro == null)
            {
                return null;
            }
            return new ReadTblParametroDTO
            {
                lParametro_id = parametro.lParametro_id,
                sParametro_desc = parametro.sParametro_desc,
                sParametro_nm = parametro.sParametro_nm
            };
        }
    }
}
