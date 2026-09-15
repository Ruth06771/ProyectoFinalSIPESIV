using System;
using System.Collections.Generic;
using System.Text;


namespace ProyectoFinal.Negocio.DTOs.TblUsuario
{
    public class TblUsuarioCreateDto
    {
        public int lPersona_id { get; set; }
        public int lRol_id { get; set; }
        public string sUsername { get; set; }
        public string sPassword { get; set; }
        public bool bEstado { get; set; }
    }
}