using ProyectoFinal.Datos.DataAccess;
using ProyectoFinal.Datos.Entities;
using ProyectoFinal.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Repository
{
    public class TblEvaluacionVisitanteRepository : ITblEvaluacionVisitanteRepository
    {
        private readonly ProyectoFinalDatabase _database;
        public TblEvaluacionVisitanteRepository(ProyectoFinalDatabase database)
        {
            _database = database;
        }
        public async Task Actualizar(TblEvaluacionVisitante evaluacionVisitante)
        {
            IEnumerable<int> personaResult = await _database.GetData<int>("", new TblEvaluacionVisitante
            {
                lEvaluacion_id = evaluacionVisitante.lEvaluacion_id,
                lProyecto_id = evaluacionVisitante.lProyecto_id,
                lVisitante_id = evaluacionVisitante.lVisitante_id,
                sPuntaje = evaluacionVisitante.sPuntaje,
                sEvaluacion_fecha = evaluacionVisitante.sEvaluacion_fecha,
                sEvaluacion_desc = evaluacionVisitante.sEvaluacion_desc
            });
        }

        public async Task Crear(TblEvaluacionVisitante evaluacionVisitante)
        {
            IEnumerable<int> personaResult = await _database.GetData<int>("", new TblEvaluacionVisitante
            {
                sPuntaje = evaluacionVisitante.sPuntaje,
                sEvaluacion_fecha = evaluacionVisitante.sEvaluacion_fecha,
                sEvaluacion_desc = evaluacionVisitante.sEvaluacion_desc
            });
        }

        public async Task Eliminar(int idEvaluacionVisitante)
        {
            IEnumerable<int> personaResult = await _database.GetData<int>("", new TblEvaluacionVisitante
            {
                lEvaluacion_id = idEvaluacionVisitante
            });
        }

        public async Task<TblEvaluacionVisitante> ObtenerPorId(int idEvaluacionVisitante)
        {
            IEnumerable<TblEvaluacionVisitante> personaResult = await _database.GetData<TblEvaluacionVisitante>("", new TblEvaluacionVisitante
            {
                lEvaluacion_id = idEvaluacionVisitante
            });
            return personaResult.FirstOrDefault();
        }

        public async Task<List<TblEvaluacionVisitante>> ObtenerTodos()
        {
            IEnumerable<TblEvaluacionVisitante> personaResult = await _database.GetData<TblEvaluacionVisitante>("");
            return personaResult.ToList();
        }
    }
}
