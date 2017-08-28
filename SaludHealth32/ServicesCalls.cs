using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludHealth32.Common.BE;
using BE = SaludHealth32.Common.BE;
using Fwk.Bases;
using Fwk.Exceptions;
using SaludHealth32.ISVC.ValidarNumeroRef;
using SaludHealth32.ISVC.ObtenerPacienteId;
using SaludHealth32.ISVC.EliminarPaciente;
using SaludHealth32.ISVC.CrearPaciente;
using SaludHealth32.ISVC.BuscarPaciente;
using SaludHealth32.ISVC.ActualizarPaciente;

// Clase donde se llaman los servicios

namespace SaludHealth32.FrontEnd
{
    public class ServicesCalls
    {


        internal static void ActualizarPaciente(BE.PacienteBE currentPacienteBE)
        {
            ActualizarPacienteReq req = new ActualizarPacienteReq();

            req.BusinessData = currentPacienteBE;

            ActualizarPacienteRes res = req.ExecuteService
                <ActualizarPacienteReq, ActualizarPacienteRes>(req);
            if (res.Error != null)
            {
                Exception ex = ExceptionHelper.ProcessException(res.Error);
                throw ex;
            }
        }

        internal static BE.PacienteBE ObtenerPaciente(Guid Id)
        {
            ObtenerPacienteIdReq req = new ObtenerPacienteIdReq();
            req.BusinessData.Id = Id;

            ObtenerPacienteIdRes res = req.ExecuteService<ObtenerPacienteIdReq, ObtenerPacienteIdRes>(req);

            if (res.Error != null)
            {
                Exception ex = ExceptionHelper.ProcessException(res.Error);
                throw ex;
            }
            return res.BusinessData;

        }

         internal static PacienteList BuscarPaciente(String name)
        {

            BuscarPacienteReq req = new BuscarPacienteReq();
            req.BusinessData.Nombre = name;

            BuscarPacienteRes res = req.ExecuteService<BuscarPacienteReq, BuscarPacienteRes>(req);

            if (res.Error != null)
            {
                Exception ex = ExceptionHelper.ProcessException(res.Error);
                throw ex;
            }
            return res.BusinessData;
        }
    }
}
