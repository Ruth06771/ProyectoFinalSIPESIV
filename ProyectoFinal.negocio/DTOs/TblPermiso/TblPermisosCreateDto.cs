using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Negocio.DTOs.TblPermiso
{
    public class TblPermisosCreateDto
    {
        public int lRol_id { get; set; }
        public int lProgram_id { get; set; }
        public bool insertar { get; set; }
        public bool actualizar { get; set; }
        public bool consultar { get; set; }
        public bool eliminar { get; set; }
    }
}
