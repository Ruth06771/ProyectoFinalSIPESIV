using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.DTOs.TblEvaluacionJurado
{
    public class CreateTblEvaluacionJuradoDTO
    {
        public int lProyecto_id { get; set; }
        public int lJurado_id { get; set; }
        public DateTime sEvaluacionJurado_fecha { get; set; }
        public TextWriter? sEvaluacionJurado_obs { get; set; }
    }
}
