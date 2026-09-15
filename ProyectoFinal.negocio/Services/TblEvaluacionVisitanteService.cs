using ProyectoFinal.Datos.Entities;
using ProyectoFinal.Datos.Interfaces;
using ProyectoFinal.Datos.Repository;
using ProyectoFinal.Negocio.DTOs.TblEvaluacionVisitante;
using ProyectoFinal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.Services
{
    public class TblEvaluacionVisitanteService : ITblEvaluacionVisitanteService
    {
        private readonly ITblEvaluacionVisitanteRepository _tblEvaluacionVisitanteRepository;
        public TblEvaluacionVisitanteService(ITblEvaluacionVisitanteRepository tblEvaluacionVisitanteRepository)
        {
            _tblEvaluacionVisitanteRepository = tblEvaluacionVisitanteRepository;
        }
        public async Task Actualizar(UpdateTblEvaluacionVisitanteDTO evaluacionVisitante)
        {
            TblEvaluacionVisitante objEvaluacionVisitante = new TblEvaluacionVisitante
            {
                lEvaluacion_id = evaluacionVisitante.lEvaluacion_id,
                lProyecto_id = evaluacionVisitante.lProyecto_id,
                lVisitante_id = evaluacionVisitante.lVisitante_id,
                sPuntaje = evaluacionVisitante.sPuntaje,
                sEvaluacion_fecha = evaluacionVisitante.sEvaluacion_fecha,
                sEvaluacion_desc = evaluacionVisitante.sEvaluacion_desc
            };
            await _tblEvaluacionVisitanteRepository.Actualizar(objEvaluacionVisitante);
        }

        public async Task Crear(CreateTblEvaluacionVisitanteDTO evaluacionVisitante)
        {
            TblEvaluacionVisitante objEvaluacionVisitante = new TblEvaluacionVisitante
            {
                lProyecto_id = evaluacionVisitante.lProyecto_id,
                lVisitante_id = evaluacionVisitante.lVisitante_id,
                sPuntaje = evaluacionVisitante.sPuntaje,
                sEvaluacion_fecha = evaluacionVisitante.sEvaluacion_fecha,
                sEvaluacion_desc = evaluacionVisitante.sEvaluacion_desc
            };
            await _tblEvaluacionVisitanteRepository.Crear(objEvaluacionVisitante);
        }

        public async Task Eliminar(int idEvaluacionVisitante)
        {
            await _tblEvaluacionVisitanteRepository.Eliminar(idEvaluacionVisitante);
        }

        public async Task<ReadTblEvaluacionVisitanteDTO> ObtenerPorId(int idEvaluacionVisitante)
        {
            var result = await _tblEvaluacionVisitanteRepository.ObtenerPorId(idEvaluacionVisitante);
            if (result is null) return null;
            return new ReadTblEvaluacionVisitanteDTO
            {
                lEvaluacion_id = result.lEvaluacion_id,
                lProyecto_id = result.lProyecto_id,
                lVisitante_id = result.lVisitante_id,
                sPuntaje = result.sPuntaje,
                sEvaluacion_fecha = result.sEvaluacion_fecha,
                sEvaluacion_desc = result.sEvaluacion_desc
            };
        }

        public async Task<List<ReadTblEvaluacionVisitanteDTO>> ObtenerTodos()
        {
            var evaluacionVisitantes = await _tblEvaluacionVisitanteRepository.ObtenerTodos();
            var EvaluacionVisitantesDTO = new List<ReadTblEvaluacionVisitanteDTO>();

            foreach (var evaluacionVisitante in evaluacionVisitantes)
            {
                var evaluacionVisitanteDTO = new ReadTblEvaluacionVisitanteDTO
                {
                    lEvaluacion_id = evaluacionVisitante.lEvaluacion_id,
                    lProyecto_id = evaluacionVisitante.lProyecto_id,
                    lVisitante_id = evaluacionVisitante.lVisitante_id,
                    sPuntaje = evaluacionVisitante.sPuntaje,
                    sEvaluacion_fecha = evaluacionVisitante.sEvaluacion_fecha,
                    sEvaluacion_desc = evaluacionVisitante.sEvaluacion_desc
                };
                EvaluacionVisitantesDTO.Add(evaluacionVisitanteDTO);
            }

            return EvaluacionVisitantesDTO;
        }
    }
}
