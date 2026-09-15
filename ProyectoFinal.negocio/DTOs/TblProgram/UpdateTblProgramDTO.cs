using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.DTOs.TblProgram
{
    public class UpdateTblProgramDTO
    {
        public int lProgram_id { get; set; }
        public string sProgram_nm { get; set; }
        public string sProgram_desc { get; set; }
    }
}
