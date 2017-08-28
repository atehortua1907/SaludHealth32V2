using SaludHealth32.Common.BE;
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


namespace SaludHealth32.FrontEnd
{
    public partial class FrmListadoPacientes : Form
    {
        PacienteList paramLista = new PacienteList();
        public FrmListadoPacientes()
        {
            InitializeComponent();
            try
            {
                var personaList = ServicesCalls.BuscarPaciente("");
                pacienteBindingSource.DataSource = personaList;
                pacienteBindingSource.Sort = "Nombre DESC";
                if (personaList != null)
                    lblError.Text = personaList.GetXml();
            }
            catch (Exception ex)
            {
                String strError = ExceptionHelper.GetAllMessageException(ex);
                //this.txtError.BackColor = Color.Red;
                txtError.Text = strError;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmListadoPacientes_Load(object sender, EventArgs e)
        {
        }

        private void pacienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtError_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
