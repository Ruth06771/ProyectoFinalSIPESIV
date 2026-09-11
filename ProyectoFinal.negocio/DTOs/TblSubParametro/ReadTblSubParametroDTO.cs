using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.DTOs.TblSubParametro
{
    public class ReadTblSubParametroDTO
    {
        public int lSubParametro_id { get; set; }
        public int lParametro_id { get; set; }
        public string sSubParametro_nm { get; set; }
        public string sSubParametro_desc { get; set; }
    }
}
