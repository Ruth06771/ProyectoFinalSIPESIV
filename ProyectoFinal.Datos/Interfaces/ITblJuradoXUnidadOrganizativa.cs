using ProyectoFinal.Datos.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblJuradoXUnidadOrganizativaRepository
    {
        Task Crear(TblJuradoXUnidadOrganizativa juradoXUnidad);
        Task<TblJuradoXUnidadOrganizativa> ObtenerPorId(int idJuradoXUnidad);
        Task<List<TblJuradoXUnidadOrganizativa>> ObtenerTodos();
        Task Actualizar(TblJuradoXUnidadOrganizativa juradoXUnidad);
        Task Eliminar(int idJuradoXUnidad);
    }
}

