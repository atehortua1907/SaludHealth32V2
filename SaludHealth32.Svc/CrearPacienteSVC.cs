using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludHealth32.BackEnd.DAC;
using SaludHealth32.ISVC.CrearPaciente;
using Fwk.Bases;

namespace SaludHealth32.Svc
{
    /// <summary>
    /// Codigo del Servicio : aqui se llama a la DAC
    /// </summary>
    public class CrearPacienteSVC : BusinessService<CrearPacienteReq, CrearPacienteRes>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pServiceRequest"></param>
        /// <returns></returns>
        public override CrearPacienteRes Execute(CrearPacienteReq pServiceRequest)
        {
            CrearPacienteRes res = new CrearPacienteRes();

            //Hacer llamado a la DAC o DACs
            PacientesDAC.CrearPaciente(pServiceRequest.BusinessData);
            return res;
        }
    }
}
