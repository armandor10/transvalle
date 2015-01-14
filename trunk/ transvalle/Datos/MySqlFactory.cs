using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
   public class MySqlFactory:DAOFactory
    {
        public override IPersona getPersonaDAO()
        {
            return new MySqlPersonaDAO();
        }
    }
}
