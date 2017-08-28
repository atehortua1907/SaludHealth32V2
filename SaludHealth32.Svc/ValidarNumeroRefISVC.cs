using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fwk.Bases;
using SaludHealth32.Common.BE;


namespace SaludHealth32.ISVC.ValidarNumeroRef
{
    
    public class ValidarNumeroRefReq : Request<Param>
    {
        public ValidarNumeroRefReq()
        {
            this.ServiceName = "ValidarNumeroRefSVC";
        }
    }
    public class Param : BaseEntity
    {
        public string id { get; set; }

    }

    public class ValidarNumeroRefRes:Response<PacienteList>{}
}
