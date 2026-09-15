using ProyectoFinal.Datos.Entities;
using ProyectoFinal.Datos.Interfaces;
using ProyectoFinal.Negocio.DTOs.TblProgram;
using ProyectoFinal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.Services
{
    public class TblProgramService : ITblProgramService
    {
        private readonly ITblProgramRepository _tblProgramRepository;
        public TblProgramService(ITblProgramRepository tblProgramRepository)
        {
            _tblProgramRepository = tblProgramRepository;
        }

        public async Task Actualizar(UpdateTblProgramDTO program)
        {
            TblProgram objProgram = new TblProgram
            {
                lProgram_id = program.lProgram_id,
                sProgram_nm = program.sProgram_nm,
                sProgram_desc = program.sProgram_desc
            };
            await _tblProgramRepository.Actualizar(objProgram);
        }

        public async Task Crear(CreateTblProgramDTO program)
        {
            TblProgram objProgram = new TblProgram
            {
                sProgram_nm = program.sProgram_nm,
                sProgram_desc = program.sProgram_desc
            };
            await _tblProgramRepository.Crear(objProgram);
        }

        public async Task Eliminar(int idProgram)
        {
            await _tblProgramRepository.Eliminar(idProgram);
        }

        public async Task<ReadTblProgramDTO> ObtenerPorId(int idProgram)
        {
            var result = await _tblProgramRepository.ObtenerPorId(idProgram);
            if (result is null) return null;
            return new ReadTblProgramDTO
            {
                lProgram_id = result.lProgram_id,
                sProgram_nm = result.sProgram_nm,
                sProgram_desc = result.sProgram_desc
            };
        }

        public async Task<List<ReadTblProgramDTO>> ObtenerTodos()
        {
            var programs = await _tblProgramRepository.ObtenerTodos();
            var programsDTO = new List<ReadTblProgramDTO>();

            foreach (var program in programs)
            {
                var programDTO = new ReadTblProgramDTO
                {
                    lProgram_id = program.lProgram_id,
                    sProgram_nm = program.sProgram_nm,
                    sProgram_desc = program.sProgram_desc
                };
                programsDTO.Add(programDTO);
            }

            return programsDTO;
        }
    }
}
