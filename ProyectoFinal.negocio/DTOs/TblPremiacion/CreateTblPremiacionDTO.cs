using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.DTOs.TblPremiacion
{
    public class CreateTblPremiacionDTO
    {
            public int lProyecto_id { get; set; }
            public int lEvento_id { get; set; }
            public string sPremiacion_tipo { get; set; }
            public string sPosicion { get; set; }
    }
}
