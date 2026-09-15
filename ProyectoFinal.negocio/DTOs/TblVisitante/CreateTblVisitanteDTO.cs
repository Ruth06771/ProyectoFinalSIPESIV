using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.DTOs.TblVisitante
{
    public class CreateTblVisitanteDTO
    {
        public int lEvento_id { get; set; }
        public string sVisitante_nm { get; set; }
        public string? sVisitante_email { get; set; }
        public string? sVisitante_telf { get; set; }
        public string? sVisitante_ci { get; set; }
        public string? sVisitante_inst { get; set; }
    }
}
