using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludHealth32.Common.BE;
using Fwk.Bases;

namespace SaludHealth32.ISVC.CrearPaciente
{
    /// <summary>
    /// Esto se envia son los parametros del SVC o Servicio
    /// </summary>
    public class CrearPacienteReq : Request<PacienteBE>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CrearPacienteReq()
        {
            this.ServiceName = "CrearPacienteSVC";
        }
        public string ServiceName { get; set; }
    }
    /// <summary>
    /// Esto es lo que retorna el SVC en el Execute
    /// </summary>
    public class CrearPacienteRes : Response<Result>
    {
    }
    public class Result : BaseEntity
    {
        public Guid Id { get; set; }
    }
}
