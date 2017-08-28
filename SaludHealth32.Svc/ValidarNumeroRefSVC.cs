using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludHealth32.Common;
using SaludHealth32.BackEnd.DAC;
using SaludHealth32.ISVC.ValidarNumeroRef;
using Fwk.Bases;

namespace SaludHealth32.Svc
{
    /// <summary>
    /// Envia los parametros del servicio.
    /// </summary>
    //public class ValidarNumeroRefSVC
    //{

    //}

    public class ValidarNumeroRefSVC : BusinessService<ValidarNumeroRefReq, ValidarNumeroRefRes>
    {
        
        public override ValidarNumeroRefRes
            Execute(ValidarNumeroRefReq pServiceRequest)
        {
            ValidarNumeroRefRes res = new ValidarNumeroRefRes();

            //Hacer llamado a la DAC o DACs
            res.BusinessData = PacientesDAC.Validacion(null);
            return res;
        }
    }
}
