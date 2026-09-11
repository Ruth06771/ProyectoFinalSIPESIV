using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProyectoFinal.Datos.Entities
{
    public class TblParametro
    {
        public int lParametro_id { get; set; }
        [StringLength(100)]
        public string sParametro_nm { get; set; }
        public string sParametro_desc { get; set; }
    }
}
