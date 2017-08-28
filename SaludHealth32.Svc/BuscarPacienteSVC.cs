using Fwk.Bases;
using SaludHealth32.BackEnd.DAC;
using SaludHealth32.ISVC.BuscarPaciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SaludHealth32.Svc
{
    public class BuscarPacienteSVC : BusinessService<BuscarPacienteReq, BuscarPacienteRes>
    {
        public override BuscarPacienteRes Execute(BuscarPacienteReq pServiceRequest)
        {
            BuscarPacienteRes result = new BuscarPacienteRes();

            result.BusinessData = PacientesDAC.BuscarPacientes(pServiceRequest.BusinessData.Nombre ,pServiceRequest.BusinessData.Apellido,null);
          
            return result;
        }
    }
}
