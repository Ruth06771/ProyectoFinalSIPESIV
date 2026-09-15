using ProyectoFinal.Datos.Entities;
using ProyectoFinal.Datos.Interfaces;
using ProyectoFinal.Negocio.DTOs.TblRol;
using ProyectoFinal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.Services
{
    public class TblRolService : ITblRolService
    {
        private readonly ITblRolRepository _tblRolRepository;
        public TblRolService(ITblRolRepository tblRolRepository)
        {
            _tblRolRepository = tblRolRepository;
        }

        public async Task Actualizar(UpdateTblRolDTO rol)
        {
            TblRol objRol = new TblRol
            {
                lRol_id = rol.lRol_id,
                sRol_nm = rol.sRol_nm,
                sRol_desc = rol.sRol_desc
            };
            await _tblRolRepository.Actualizar(objRol);
        }

        public async Task Crear(CreateTblRolDTO rol)
        {
            TblRol objRol = new TblRol
            {
                sRol_nm = rol.sRol_nm,
                sRol_desc = rol.sRol_desc
            };
            await _tblRolRepository.Crear(objRol);
        }

        public async Task Eliminar(int idRol)
        {
            await _tblRolRepository.Eliminar(idRol);
        }

        public async Task<ReadTblRolDTO> ObtenerPorId(int idRol)
        {
            var result = await _tblRolRepository.ObtenerPorId(idRol);
            if (result is null) return null;
            return new ReadTblRolDTO
            {
                lRol_id = result.lRol_id,
                sRol_nm = result.sRol_nm,
                sRol_desc = result.sRol_desc
            };
        }

        public async Task<List<ReadTblRolDTO>> ObtenerTodos()
        {
            var roles = await _tblRolRepository.ObtenerTodos();
            var rolesDTO = new List<ReadTblRolDTO>();

            foreach (var rol in roles)
            {
                var rolDTO = new ReadTblRolDTO
                {
                    lRol_id = rol.lRol_id,
                    sRol_nm = rol.sRol_nm,
                    sRol_desc = rol.sRol_desc
                };
                rolesDTO.Add(rolDTO);
            }

            return rolesDTO;
        }
    }
}
