using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Entities
{
    public class TblPremiacion
    {
        public int lPremiacion_id { get; set; }
        public int lProyecto_id { get; set; }
        public int lEvento_id { get; set; }
        public string sPremiacion_tipo { get; set; }
        public string sPosicion {  get; set; }
    }
}
