using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.DTOs.TblProyectoXPersona
{
    public class UpdateTblProyectoXPersonaDTO
    {
        public int lProyectoXPersona_id { get; set; }
        public int lProyecto_id { get; set; }
        public int lPersona_id { get; set; }
    }
}
