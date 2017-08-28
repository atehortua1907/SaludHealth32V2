using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludHealth32.BackEnd.DAC;
using Fwk.Bases;
using SaludHealth32.ISVC.ObtenerPacienteId;

namespace SaludHealth32.Svc
{
    /// <summary>
    /// Codigo del Servicio : aqui se llama a la DAC
    /// </summary>
    public class ObtenerPacienteIdSVC : BusinessService<ObtenerPacienteIdReq, ObtenerPacienteIdRes>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pServiceRequest"></param>
        /// <returns></returns>
        public override ObtenerPacienteIdRes
            Execute(ObtenerPacienteIdReq pServiceRequest)
        {
            ObtenerPacienteIdRes res = new ObtenerPacienteIdRes();

            //Hacer llamado a la DAC o DACs

            res.BusinessData = PacientesDAC.ObtenerPacienteId(pServiceRequest.BusinessData.Id);
            return res;

        }
    }
}
