using ProyectoFinal.Datos.DataAccess;
using ProyectoFinal.Datos.Entities;
using ProyectoFinal.Datos.Interfaces;

namespace ProyectoFinal.Datos.Repository
{
    public class TblProyectoRepository : ITblProyectoRepository
    {
        private readonly ProyectoFinalDatabase _database;

        public TblProyectoRepository(ProyectoFinalDatabase database)
        {
            _database = database;
        }

        public async Task Crear(TblProyecto proyecto)
        {
            IEnumerable<int> proyectoResult = await _database.GetData<int>("fn_tblproyecto_crear", new
            {
                lasignatura_id = proyecto.lAsignatura_id, // integer
                sproyecto_nm = proyecto.sProyecto_nm,     // text
                sproyecto_desc = proyecto.sProyecto_desc, // text
                sproyecto_tipo = proyecto.sProyecto_tipo, // text
                sproyecto_estado = proyecto.sProyecto_estado, // boolean
                sproyecto_video = proyecto.sProyecto_video  // text
            });
        }

        public async Task Actualizar(TblProyecto proyecto)
        {
            IEnumerable<int> proyectoResult = await _database.GetData<int>("fn_tblproyecto_actualizar", new
            {
                lproyecto_id = proyecto.lProyecto_id,
                lasignatura_id = proyecto.lAsignatura_id,
                sproyecto_nm = proyecto.sProyecto_nm,
                sproyecto_desc = proyecto.sProyecto_desc,
                sproyecto_tipo = proyecto.sProyecto_tipo,
                sproyecto_estado = proyecto.sProyecto_estado,
                sproyecto_video = proyecto.sProyecto_video
            });
        }

        public async Task Eliminar(int idProyecto)
        {
            IEnumerable<int> proyectoResult = await _database.GetData<int>("fn_tblproyecto_eliminar", new
            {
                lproyecto_id = idProyecto
            });
        }

        public async Task<TblProyecto> ObtenerPorId(int idProyecto)
        {
            IEnumerable<TblProyecto> proyectoResult = await _database.GetData<TblProyecto>("fn_tblproyecto_obtenerporid", new
            {
                lproyecto_id = idProyecto
            });
            return proyectoResult.FirstOrDefault();
        }

        public async Task<List<TblProyecto>> ObtenerTodos()
        {
            IEnumerable<TblProyecto> proyectoResult = await _database.GetData<TblProyecto>("fn_tblproyecto_obtenertodos");
            return proyectoResult.ToList();
        }
    }
}
