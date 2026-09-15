using ProyectoFinal.Datos.Entities;
using ProyectoFinal.Datos.Interfaces;
using ProyectoFinal.Negocio.DTOs.TblPermiso;
using ProyectoFinal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.Services
{
    public class TblPermisosService : ITblPermisosService
    {
        private readonly ITblPermisosRepository _tblPermisosRepository;
        public TblPermisosService(ITblPermisosRepository tblPermisosRepository)
        {
            _tblPermisosRepository = tblPermisosRepository;
        }

        public async Task Actualizar(TblPermisosUpdateDto permisos)
        {
            TblPermisos objPermisos = new TblPermisos
            {
                lPermisos_id = permisos.lPermisos_id,
                lRol_id = permisos.lRol_id,
                lProgram_id = permisos.lProgram_id,
                Insertar = permisos.Insertar,
                Actualizar = permisos.Actualizar,
                Consultar = permisos.Consultar,
                Eliminar = permisos.Eliminar
            };
            await _tblPermisosRepository.Actualizar(objPermisos);
        }

        public async Task Crear(TblPermisosCreateDto permisos)
        {
            TblPermisos objPermisos = new TblPermisos
            {
                lRol_id = permisos.lRol_id,
                lProgram_id = permisos.lProgram_id,
                Insertar = permisos.Insertar,
                Actualizar = permisos.Actualizar,
                Consultar = permisos.Consultar,
                Eliminar = permisos.Eliminar
            };
            await _tblPermisosRepository.Crear(objPermisos);
        }

        public async Task Eliminar(int idPermisos)
        {
            await _tblPermisosRepository.Eliminar(idPermisos);
        }

        public async Task<TblPermisosReadDto> ObtenerPorId(int idPermisos)
        {
            var result = await _tblPermisosRepository.ObtenerPorId(idPermisos);
            if (result is null) return null;
            return new TblPermisosReadDto
            {
                lPermisos_id = result.lPermisos_id,
                lRol_id = result.lRol_id,
                lProgram_id = result.lProgram_id,
                Insertar = result.Insertar,
                Actualizar = result.Actualizar,
                Consultar = result.Consultar,
                Eliminar = result.Eliminar
            };
        }

        public async Task<List<TblPermisosReadDto>> ObtenerTodos()
        {
            var permisos = await _tblPermisosRepository.ObtenerTodos();
            var permisosDTO = new List<TblPermisosReadDto>();

            foreach (var permiso in permisos)
            {
                var permisoDTO = new TblPermisosReadDto
                {
                    lPermisos_id = permiso.lPermisos_id,
                    lRol_id = permiso.lRol_id,
                    lProgram_id = permiso.lProgram_id,
                    Insertar = permiso.Insertar,
                    Actualizar = permiso.Actualizar,
                    Consultar = permiso.Consultar,
                    Eliminar = permiso.Eliminar
                };
                permisosDTO.Add(permisoDTO);
            }

            return permisosDTO;
        }
    }
}
