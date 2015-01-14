using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
   public abstract class DAOFactory
    {
       public abstract IPersona getPersonaDAO();

       public static DAOFactory getDAOFactory(string db)
       {
           switch (db)
           {
               case "mysql":
                   return new MySqlFactory();

           }
           return null;
       }
    }
}
