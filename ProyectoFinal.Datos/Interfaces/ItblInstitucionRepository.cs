using ProyectoFinal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public class ItblInstitucionRepository
    {
        public Task<int> Crear(TblInstitucion);
        public Task<int> Actualizar(TblInstitucion);
        public Task<int> Eliminar(int idInstitucion);
        public Task<int> ObtenerPorId(int idInstitucion);
        public Task<List<TblInstitucion>> ObtenerInstituciones();
    }
}
