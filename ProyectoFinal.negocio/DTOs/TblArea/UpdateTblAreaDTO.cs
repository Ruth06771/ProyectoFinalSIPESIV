using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.DTOs.TblArea
{
    public class UpdateTblAreaDTO
    {
        public int lArea_id { get; set; }
        public int lUnidadOrganizativa_id { get; set; }
        public string sArea_nm { get; set; }
        public string sArea_tipo { get; set; }

    }
}
