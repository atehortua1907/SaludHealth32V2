using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludHealth32.BackEnd.DAC;
using SaludHealth32.ISVC.EliminarPaciente;
using Fwk.Bases;

namespace SaludHealth32.Svc
{
    public class EliminarPacienteSVC : BusinessService<EliminarPacienteReq, EliminarPacienteRes>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pServiceRequest"></param>
        /// <returns></returns>
        public override EliminarPacienteRes Execute(EliminarPacienteReq pServiceRequest)
        {
            EliminarPacienteRes res = new EliminarPacienteRes();

            //Hacer llamado a la DAC o DACs
            PacientesDAC.EliminarPaciente(pServiceRequest.BusinessData);
            return res;
        }
    }
}
