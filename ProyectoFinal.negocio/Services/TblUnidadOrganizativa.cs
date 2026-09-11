using ProyectoFinal.Datos.Entities;
using ProyectoFinal.Datos.Interfaces;
using ProyectoFinal.Datos.Repository;
using ProyectoFinal.Negocio.DTOs.TblInstitucion;
using ProyectoFinal.Negocio.DTOs.TblSubParametro;
using ProyectoFinal.Negocio.DTOs.TblUnidadOrganizativa;
using ProyectoFinal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.Services
{
    public class TblUnidadOrganizativa : ITblUnidadOrganizativaService
    {
        private readonly ITblUnidadOrganizativaRepository _tblUnidadOrganizativaRepository;
        public TblUnidadOrganizativa(ITblUnidadOrganizativaRepository tblUnidadOrganizativaRepository)
        {
            _tblUnidadOrganizativaRepository = tblUnidadOrganizativaRepository;
        }
        public async Task Actualizar(UpdateTblUnidadOrganizativaDTO unidadOrganizativa)
        {
            TblUnidadOrganizativa unidadOrganizativaActualizada = new TblUnidadOrganizativa
            {
                lUnidadOrganizativa_id = unidadOrganizativa.lUnidadOrganizativa_id,
                lInstitucion_id = unidadOrganizativa.lInstitucion_id,
                sUnidadOrganizativa_nm = unidadOrganizativa.sUnidadOrganizativa_nm,
                sUnidadOrganizativa_tipo = unidadOrganizativa.sUnidadOrganizativa_tipo
            };
            int resultado = await _tblUnidadOrganizativaRepository.Actualizar(unidadOrganizativaActualizada);
            if (resultado == 0)
            {
                throw new Exception("Ocurrió un error al actualizar la unidad organizativa");
            }
        }

        public async Task Crear(CreateTblUnidadOrganizativaDTO unidadOrganizativa)
        {
            TblUnidadOrganizativa unidadOrganizativaCreada = new TblUnidadOrganizativa
            {
                lInstitucion_id = unidadOrganizativa.lInstitucion_id,
                sUnidadOrganizativa_nm = unidadOrganizativa.sUnidadOrganizativa_nm,
                sUnidadOrganizativa_tipo = unidadOrganizativa.sUnidadOrganizativa_tipo
            };
            int resultado = await _tblUnidadOrganizativaRepository.Crear(unidadOrganizativaCreada);
            if (resultado == 0)
            {
                throw new Exception("Ocurrió un error al crear la unidad organizativa");
            }
        }

    
        public async Task Eliminar(int idUnidadOrganizativa)
        {
            int resultado = await _tblUnidadOrganizativaRepository.Eliminar(idUnidadOrganizativa);
            if (resultado == 0)
            {
                throw new Exception("Ocurrió un error al eliminar la unidad organizativa");
            }
        }

        public async Task<ReadTblUnidadOrganizativaDTO> ObtenerPorId(int idUnidadOrganizativa)
        {
            var unidadOrganizativa = await _tblUnidadOrganizativaRepository.ObtenerPorId(idUnidadOrganizativa);
            if (unidadOrganizativa == null)
            {
                return null;
            }
            return new ReadTblUnidadOrganizativaDTO
            {
                lUnidadOrganizativa_id = unidadOrganizativa.lUnidadOrganizativa_id,
                lInstitucion_id = unidadOrganizativa.lInstitucion_id,
                sUnidadOrganizativa_nm = unidadOrganizativa.sUnidadOrganizativa_nm,
                sUnidadOrganizativa_tipo = unidadOrganizativa.sUnidadOrganizativa_tipo
            };
        }

        public async Task<List<ReadTblUnidadOrganizativaDTO>> ObtenerSubParametros()
        {
            var subParametros = await _tblUnidadOrganizativaRepository.ObtenerSubParametros();
            return subParametros.Select(subparam => new ReadTblUnidadOrganizativaDTO
            {
                lUnidadOrganizativa_id = subparam.lUnidadOrganizativa_id,
                lInstitucion_id = subparam.lInstitucion_id,
                sUnidadOrganizativa_nm = subparam.sUnidadOrganizativa_nm,
                sUnidadOrganizativa_tipo = subparam.sUnidadOrganizativa_tipo
            }).ToList();
        }
    }
}
