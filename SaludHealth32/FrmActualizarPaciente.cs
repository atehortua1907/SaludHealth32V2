using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fwk.Exceptions;
using Fwk.HelperFunctions;
using SaludHealth32.Common.BE;
using SaludHealth32.FrontEnd;


namespace SaludHealth32.FrontEnd
{
    public partial class FrmActualizarPaciente : Form
    {

        PacienteBE currentPacienteBE = null;

        public FrmActualizarPaciente()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                currentPacienteBE.Apellidos = txtApellido.Text;
                currentPacienteBE.Nombre = txtNombre.Text;
                ServicesCalls.ActualizarPaciente(currentPacienteBE);

                //currentPacienteBE = ServicesCalls.ObtenerPaciente(currentPacienteBE.Numref);
            }


            catch (Exception ex)
            {
               // throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
                String strError = ExceptionHelper.GetAllMessageException(ex);
            }




        }
    }
}
