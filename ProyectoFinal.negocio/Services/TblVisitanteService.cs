using ProyectoFinal.Datos.Entities;
using ProyectoFinal.Datos.Interfaces;
using ProyectoFinal.Datos.Repository;
using ProyectoFinal.Negocio.DTOs.TblVisitante;
using ProyectoFinal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.Services
{
    public class TblVisitanteService : ITblVisitanteService
    {
        private readonly ITblVisitanteRepository _tblVisitanteRepository;
            public TblVisitanteService(ITblVisitanteRepository tblVisitanteRepository)
        {
            _tblVisitanteRepository = tblVisitanteRepository;
        }
        public async Task Actualizar(UpdateTblVisitanteDTO visitante)
        {
            TblVisitante objVisitante = new TblVisitante
            {
                lVisitante_id = visitante.lVisitante_id,
                lEvento_id = visitante.lEvento_id,
                sVisitante_nm = visitante.sVisitante_nm,
                sVisitante_email = visitante.sVisitante_email,
                sVisitante_telf = visitante.sVisitante_telf,
                sVisitante_ci = visitante.sVisitante_ci,
                sVisitante_inst = visitante.sVisitante_inst
            };
            await _tblVisitanteRepository.Actualizar(objVisitante);
        }

        public async Task Crear(CreateTblVisitanteDTO visitante)
        {
            TblVisitante objVisitante = new TblVisitante
            {
                lEvento_id = visitante.lEvento_id,
                sVisitante_nm = visitante.sVisitante_nm,
                sVisitante_email = visitante.sVisitante_email,
                sVisitante_telf = visitante.sVisitante_telf,
                sVisitante_ci = visitante.sVisitante_ci,
                sVisitante_inst = visitante.sVisitante_inst
            };
            await _tblVisitanteRepository.Crear(objVisitante);
        }

        public async Task Eliminar(int idVisitante)
        {
            await _tblVisitanteRepository.Eliminar(idVisitante);
        }

        public async Task<ReadTblVisitanteDTO> ObtenerPorId(int idVisitante)
        {
            var result = await _tblVisitanteRepository.ObtenerPorId(idVisitante);
            if (result is null) return null;
            return new ReadTblVisitanteDTO
            {
                lVisitante_id = result.lVisitante_id,
                lEvento_id = result.lEvento_id,
                sVisitante_nm = result.sVisitante_nm,
                sVisitante_email = result.sVisitante_email,
                sVisitante_telf = result.sVisitante_telf,
                sVisitante_ci = result.sVisitante_ci,
                sVisitante_inst = result.sVisitante_inst
            };
        }

        public async Task<List<ReadTblVisitanteDTO>> ObtenerTodos()
        {
            var visitantes = await _tblVisitanteRepository.ObtenerTodos();
            var VisitantesDTO = new List<ReadTblVisitanteDTO>();
            foreach (var visitante in visitantes)
            {
                var visitanteDTO = new ReadTblVisitanteDTO
                {
                    lVisitante_id = visitante.lVisitante_id,
                    lEvento_id = visitante.lEvento_id,
                    sVisitante_nm = visitante.sVisitante_nm,
                    sVisitante_email = visitante.sVisitante_email,
                    sVisitante_telf = visitante.sVisitante_telf,
                    sVisitante_ci = visitante.sVisitante_ci,
                    sVisitante_inst = visitante.sVisitante_inst
                };
                VisitantesDTO.Add(visitanteDTO);
            }
            return VisitantesDTO;
        }
    }
}
