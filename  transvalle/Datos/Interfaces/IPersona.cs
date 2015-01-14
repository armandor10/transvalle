using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using Entidades;

namespace Datos
{
    interface IPersona
    {
        Entidades.Persona getPersona(string cedula);
    }
}
