using ProyectoFinal.Datos.DataAccess;
using ProyectoFinal.Datos.Entities;
using ProyectoFinal.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Repository
{
    public class TblEvaluacionJuradoRepository : ITblEvaluacionJuradoRepository
    {
        private readonly ProyectoFinalDatabase _database;
        public TblEvaluacionJuradoRepository(ProyectoFinalDatabase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblEvaluacionJurado evaluacionJurado)
        {
            IEnumerable<int> personaResult = await _database.GetData<int>("", new TblEvaluacionJurado
            {
                lEvaluacionJurado_id = evaluacionJurado.lEvaluacionJurado_id,
                lProyecto_id = evaluacionJurado.lProyecto_id,
                lJurado_id = evaluacionJurado.lJurado_id,
                sEvaluacionJurado_fecha = evaluacionJurado.sEvaluacionJurado_fecha,
                sEvaluacionJurado_obs = evaluacionJurado.sEvaluacionJurado_obs
            });
        }

        public async Task Crear(TblEvaluacionJurado evaluacionJurado)
        {
            IEnumerable<int> personaResult = await _database.GetData<int>("", new TblEvaluacionJurado
            {
                sEvaluacionJurado_fecha = evaluacionJurado.sEvaluacionJurado_fecha,
                sEvaluacionJurado_obs = evaluacionJurado.sEvaluacionJurado_obs
            });

        }

        public async Task Eliminar(int idEvaluacionJurado)
        {
            IEnumerable<int> personaResult = await _database.GetData<int>("", new TblEvaluacionJurado
            {
                lEvaluacionJurado_id = idEvaluacionJurado
            });
        }

        public async Task<TblEvaluacionJurado> ObtenerPorId(int idEvaluacionJurado)
        {
            IEnumerable<TblEvaluacionJurado> personaResult = await _database.GetData<TblEvaluacionJurado>("", new TblEvaluacionJurado
            {
                lEvaluacionJurado_id = idEvaluacionJurado
            });
            return personaResult.FirstOrDefault();
        }

        public async Task<List<TblEvaluacionJurado>> ObtenerTodos()
        {
            IEnumerable<TblEvaluacionJurado> personaResult = await _database.GetData<TblEvaluacionJurado>("");
            return personaResult.ToList();
        }
    }
}
