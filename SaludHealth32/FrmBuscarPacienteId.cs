using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaludHealth32.Common.BE;
using Fwk.HelperFunctions;
using Fwk.Exceptions;


namespace SaludHealth32.FrontEnd
{
    public partial class FrmBuscarPacienteId : Form
    {

        PacienteBE currentPacienteBE = null;

        public FrmBuscarPacienteId()
        {
            InitializeComponent();
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            try
            {
                Guid Id_obtener = Guid.Parse(txtIdPaciente.Text);
                currentPacienteBE = ServicesCalls.ObtenerPaciente(Id_obtener);
                txtNombre.Text = currentPacienteBE.Nombre;
                txtApellido.Text = currentPacienteBE.Apellidos;
                if (currentPacienteBE != null)
                    txtResultado.Text = currentPacienteBE.GetXml();

            }
            catch (Exception ex)
            {
                String strError = ExceptionHelper.GetAllMessageException(ex);
                txtError.Text = strError;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = String.Empty;
            txtError.Text = String.Empty;
            txtApellido.Text = String.Empty;
            txtNombre.Text = String.Empty;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtIdPaciente_Validating(object sender, CancelEventArgs e)
        {

            if (txtIdPaciente.Text.Trim() == "")
            {
                txtError.Text = ("Se solicita este campo");
                txtIdPaciente.Focus();
            }
        }

        private void txtIdPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
