using ProyectoFinal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblAreaRepository
    {
        public Task<int> Crear(TblArea area);
        public Task<int> Actualizar(TblArea area);
        public Task<int> Eliminar(int area); 
        public Task<TblArea> ObtenerPorId(int area);
        public Task<List<TblArea>> ObtenerAreas();
    }
}
