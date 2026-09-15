using ProyectoFinal.Datos.DataAccess;
using ProyectoFinal.Datos.Entities;
using ProyectoFinal.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Repository
{
    public class TblProyectoXPersonaRepository : ITblProyectoXPersona
    {
        public readonly ProyectoFinalDatabase _database;
        public TblProyectoXPersonaRepository(ProyectoFinalDatabase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblProyectoXPersona proyectoXPersona)
        {
            IEnumerable<int> personaResult = await _database.GetData<int>("", new TblProyectoXPersona
            {
                lProyectoXPersona_id = proyectoXPersona.lProyectoXPersona_id,
                lProyecto_id = proyectoXPersona.lProyecto_id,
                lPersona_id = proyectoXPersona.lPersona_id
            });
        }

        public Task Crear(TblEvaluacionVisitante evaluacionVisitante)
        {
            throw new NotImplementedException();
        }

        public Task Crear(TblProyectoXPersona proyectoXPersona)
        {
            throw new NotImplementedException();
        }

        public Task Eliminar(int idEvaluacionVisitante)
        {
            throw new NotImplementedException();
        }

        public Task<TblEvaluacionVisitante> ObtenerPorId(int idEvaluacionVisitante)
        {
            throw new NotImplementedException();
        }

        public Task<List<TblEvaluacionVisitante>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        Task<TblProyectoXPersona> ITblProyectoXPersona.ObtenerPorId(int idProyectoXPersona)
        {
            throw new NotImplementedException();
        }

        Task<List<TblProyectoXPersona>> ITblProyectoXPersona.ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
