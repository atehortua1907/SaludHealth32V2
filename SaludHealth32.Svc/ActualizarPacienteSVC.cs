using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludHealth32.Common.BE;
using SaludHealth32.BackEnd.DAC;
using Fwk.Bases;
using SaludHealth32.ISVC.ActualizarPaciente;



namespace SaludHealth32.Svc
{
    /// <summary>
    /// Codigo del Servicio : aqui se llama a la DAC
    /// </summary>
    public class ActualizarPersonaSVC : BusinessService<ActualizarPacienteReq, ActualizarPacienteRes>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pServiceRequest"></param>
        /// <returns></returns>
        public override ActualizarPacienteRes Execute(ActualizarPacienteReq pServiceRequest)
        {
            ActualizarPacienteRes res = new ActualizarPacienteRes();

            //Hacer llamado a la DAC o DACs
            PacientesDAC.ActualizarPaciente(pServiceRequest.BusinessData);
            return res;
        }
    }
}
