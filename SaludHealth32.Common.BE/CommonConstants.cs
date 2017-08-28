using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace SaludHealth32.Common.BE
{
   public class CommonConstants
    {
        const string CnnStringName = "cnncapa";
        public static string CnnString = String.Empty;
        static CommonConstants()
        {
            if (System.Configuration.ConfigurationManager.ConnectionStrings[CnnStringName] != null)
                CnnString = System.Configuration.ConfigurationManager.ConnectionStrings[CnnStringName].ConnectionString;
            else
                throw new Fwk.Exceptions.TechnicalException("Falta la cadena");
        }
    }
}
