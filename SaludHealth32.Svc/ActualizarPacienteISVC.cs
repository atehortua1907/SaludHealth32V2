using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludHealth32.Common.BE;
using Fwk.Bases;

namespace SaludHealth32.ISVC.ActualizarPaciente
{
    public class ActualizarPacienteReq : Request<PacienteBE>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ActualizarPacienteReq()
        {
            this.ServiceName = "ActualizarPacienteSVC";
        }
    }
    /// <summary>
    /// Esto es lo que retorna el SVC en el Execute
    /// </summary>
    public class ActualizarPacienteRes : Response<DummyContract>
    {
    }
}
