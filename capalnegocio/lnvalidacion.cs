using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capalnegocio
{
    class lnvalidacion
    {
        public string validacion(string campo)
        {
            string retorno = "";

            if (campo != null)
            {
                switch(campo.GetType().ToString())
                { 
                    case "System.Decimal":
                        retorno = campo.ToString().Replace(",", ".");
                        break;
                    case "System.Double":
                        retorno = campo.ToString().Replace(",", ".");
                        break;
                    //case "System.DateTime":
                    //    if((campo.ToString == "01/01/0001 12:00:00 a.m.")
                    //     || (campo.ToString == "01/01/0001 0:00:00"))
                    //    {

                    //    }
                       // break;
                }
            }

            return campo;
        }

    }
}
