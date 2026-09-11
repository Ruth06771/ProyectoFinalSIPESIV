using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.DTOs.TblUnidadOrganizativa
{
    public class ReadTblUnidadOrganizativaDTO
    {
        public int lUnidadOrganizativa_id { get; set; }
        public int lInstitucion_id { get; set; }
        public string sUnidadOrganizativa_nm { get; set; }
        public string sUnidadOrganizativa_tipo { get; set; }
    }
}
