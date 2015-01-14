using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
  public class Persona
    {
        public string PApellido { get; set; }
        public string SApellido { get; set; }
        public string PNombre { get; set; }
        public string SNombre { get; set; }
        public string Cedula { get; set; }
        public System.DateTime FchNac { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string EPS { get; set; }
        public string Pension { get; set; }
        public string RH { get; set; }
        public string TConductor { get; set; }
        public string Transvalle_Nit { get; set; }
        public long Usuario_idUsuario { get; set; }

        //public virtual transvalle transvalle { get; set; }
        //public virtual usuario usuario { get; set; }
    }
}
