using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fwk.Bases;
using SaludHealth32.Common.BE;

namespace SaludHealth32.ISVC.ObtenerPacienteId
{
    public class ObtenerPacienteIdReq : Request<Param>
    {
        public ObtenerPacienteIdReq()
        {
            this.ServiceName = "ObtenerPacienteIdSVC";
        }
    }
    public class  Param:BaseEntity
    {
        public Guid Id { get; set; }
    }

    public class ObtenerPacienteIdRes : Response<PacienteBE>
    {
    }
}
