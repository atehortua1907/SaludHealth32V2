using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludHealth32.Common.BE;
using Fwk.Bases;

namespace SaludHealth32.ISVC.BuscarPaciente
{
   
    public class BuscarPacienteReq : Request<Param>
    {
        public BuscarPacienteReq()
        {
            this.ServiceName = "BuscarPacienteSVC";
        }
    }

    public class Param : BaseEntity
    {
        public Guid Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }

    }

    public class BuscarPacienteRes : Response<PacienteList> { }
   
}
