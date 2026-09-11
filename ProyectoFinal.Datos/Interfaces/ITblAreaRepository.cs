using ProyectoFinal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public class ITblAreaRepository
    {
        public Task<int> Crear(TblArea);
        public Task<int> Actualizar(TblArea);
        public Task<int> Eliminar(int area); 
        public Task<int> ObtenerPorId(int area);
        public Task<List<TblArea>> ObtenerAreas();
    }
}
