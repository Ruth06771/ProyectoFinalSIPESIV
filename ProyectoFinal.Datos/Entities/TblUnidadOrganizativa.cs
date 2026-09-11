using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Entities
{
   public class TblUnidadOrganizativa
    {
        public int lUnidadOrganizativa_id { get; set; }
        public int lInstitucion_id { get; set; }
        public string sUnidadOrganizativa_nm { get; set; }
        public string sUnidadOrganizativa_tipo { get; set; }

    }
}
