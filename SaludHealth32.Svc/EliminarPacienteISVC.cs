using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludHealth32.Common.BE;
using Fwk.Bases;

namespace SaludHealth32.ISVC.EliminarPaciente
{
    public class EliminarPacienteReq : Request<PacienteBE>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EliminarPacienteReq()
        {
            this.ServiceName = "EliminarPacienteSVC";
        }

        public string ServiceName { get; set; }
    }
    /// <summary>
    /// Esto es lo que retorna el SVC en el Execute
    /// </summary>
    public class EliminarPacienteRes : Response<Result>
    {
    }

    public class Result : BaseEntity
    {
        public Guid Id { get; set; }
    }
}
